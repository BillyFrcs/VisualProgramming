Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms

Public Class UserAccount
    ' Register properties
    Private Property _NameRegister As String
    Private Property _EmailRegister As String
    Private Property _PasswordRegister As String

    ' Login properties
    Private Property _EmailLogin As String
    Private Property _PasswordLogin As String

    Private ReadOnly _empty As String = String.Empty

    ' Email validation
    Private ReadOnly _regex As New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")

    ' SQL Connection to the database
    Private Const _serverName = "BILLY\BILLY"
    Private Const _databaseName = "FruitsShop"

    Private ReadOnly _SQLConnection As New SqlConnection($"Data Source={_serverName};Initial Catalog={_databaseName};Integrated Security=True")

    Private Shared _Instance As UserAccount

    Private Sub LoginLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordRegisterTextBox.UseSystemPasswordChar = True
        PasswordLoginTextBox.UseSystemPasswordChar = True

        ' Focus on the text box
        NameTextBox.Focus()
        EmailLoginTextBox.Focus()
    End Sub

    ''' <summary>
    ''' Singleton pattern of UserAccount class
    ''' </summary>
    ''' <returns>UserAccount (Object)</returns>
    Public Shared Function Instance() As UserAccount
        If _Instance Is Nothing Then
            _Instance = New UserAccount()
        End If

        Return _Instance
    End Function

    Private Sub LoginLabelClick(sender As Object, e As EventArgs) Handles LoginCursorLabel.Click
        RegisterShadowPanel.Visible = False
        TransitionUserAccountPage.HideSync(RegisterShadowPanel)

        ClearRegisterTextBox()
    End Sub

    Private Sub CreateAccountButtonClick(sender As Object, e As EventArgs) Handles CreateAccounButton.Click
        RegisterShadowPanel.Visible = True
        TransitionUserAccountPage.ShowSync(RegisterShadowPanel)

        ClearLoginTextBox()
    End Sub

    Private Sub RegisterGradientButtonClick(sender As Object, e As EventArgs) Handles RegisterGradientButton.Click
        InitializeRegisterAccount()

        RegisterAccount()
    End Sub

    ''' <summary>
    ''' Register user account
    ''' </summary>
    Private Sub RegisterAccount()
        Try
            If _NameRegister = _empty Or _EmailRegister = _empty Or _PasswordRegister = _empty Then
                ErrorMessageDialog.Show("Yoo the form is still empty!", "Error")
            Else
                If Not _regex.IsMatch(_EmailRegister) Then
                    ErrorMessageDialog.Show("Email is not valid", "Error")

                    EmailRegisterTextBox.Select()
                Else
                    _SQLConnection.Open()

                    Dim insertQuery As String = $"INSERT INTO {_databaseName}.dbo.UserAccount ([Name], [Email], [Password]) VALUES ('" & _NameRegister & "', '" & _EmailRegister & "', '" & _PasswordRegister & "')"

                    Using SQLCommand As New SqlCommand
                        With SQLCommand
                            .Connection = _SQLConnection
                            .CommandType = CommandType.Text
                            .CommandText = insertQuery

                            SQLCommand.Parameters.AddWithValue("@Name", _NameRegister)
                            SQLCommand.Parameters.AddWithValue("@Email", _EmailRegister)
                            SQLCommand.Parameters.AddWithValue("@Password", _PasswordRegister)

                            .ExecuteNonQuery()
                        End With

                        _SQLConnection.Close()

                        ClearRegisterTextBox()

                        Dim getName() As String = _NameRegister.Split(" "c)

                        SuccessMessageDialog.Show($"Registration Successfully, Welcome {getName(0).Replace(_NameRegister, _NameRegister)}!", "Success")

                        UserDashboard.Show()

                        Me.Hide()
                    End Using
                End If
            End If
        Catch ex As SqlException
            ErrorMessageDialog.Show(ex.Message())
        End Try
    End Sub

    Private Sub LoginGradientButtonClick(sender As Object, e As EventArgs) Handles LoginGradientButton.Click
        InitializeLoginAccount()

        LoginAccount()
    End Sub

    ''' <summary>
    ''' Login user account
    ''' </summary>
    Private Sub LoginAccount()
        Try
            If _EmailLogin = _empty Or _PasswordLogin = _empty Then
                ErrorMessageDialog.Show("Yoo the form is still empty!", "Error")
            Else
                If _regex.IsMatch(_EmailLogin) Then
                    _SQLConnection.Open()

                    Dim selectQuery As String = $"SELECT * FROM {_databaseName}.dbo.UserAccount WHERE Email = '" & _EmailLogin & "' AND Password = '" & _PasswordLogin & "'"

                    Using SQLCommand As New SqlCommand
                        With SQLCommand
                            .Connection = _SQLConnection
                            .CommandType = CommandType.Text
                            .CommandText = selectQuery

                            SQLCommand.Parameters.AddWithValue("@Email", _EmailLogin)
                            SQLCommand.Parameters.AddWithValue("@Password", _PasswordLogin)
                        End With

                        Dim adapter As New SqlDataAdapter(SQLCommand)
                        Dim table As New DataTable

                        adapter.Fill(table)

                        SQLCommand.ExecuteNonQuery()
                        _SQLConnection.Close()

                        If table.Rows.Count = 0 Then
                            ErrorMessageDialog.Show("Email or Password is incorrect!", "Error")
                        Else
                            Try
                                ClearLoginTextBox()

                                _SQLConnection.Open()

                                Dim nameQuery = $"SELECT Name FROM {_databaseName}.dbo.UserAccount WHERE Email = '" & _EmailLogin & "'"

                                Dim NewSQLCommand As New SqlCommand(nameQuery, _SQLConnection)

                                NewSQLCommand.Parameters.AddWithValue("@Email", _EmailLogin)

                                Dim executeName As String = NewSQLCommand.ExecuteScalar()

                                Dim getName() As String = executeName.Split(" "c)

                                SuccessMessageDialog.Show($"Login Successfully, Welcome back {getName(0).Replace(executeName, executeName)}!", "Success")

                                UserDashboard.Show()

                                Me.Hide()
                            Catch ex As SqlException
                                ErrorMessageDialog.Show(ex.Message())
                            Finally
                                _SQLConnection.Close()
                            End Try
                        End If
                    End Using
                Else
                    ErrorMessageDialog.Show("Email is not valid", "Error")

                    EmailLoginTextBox.Select()
                End If
            End If
        Catch ex As SqlException
            ErrorMessageDialog.Show(ex.Message())
        End Try
    End Sub

    ''' <summary>
    ''' Initialize the register account
    ''' </summary>
    Private Sub InitializeRegisterAccount()
        _NameRegister = NameTextBox.Text.Trim
        _EmailRegister = EmailRegisterTextBox.Text.Trim
        _PasswordRegister = PasswordRegisterTextBox.Text.Trim
    End Sub

    ''' <summary>
    ''' Initialize the login account
    ''' </summary>
    Private Sub InitializeLoginAccount()
        _EmailLogin = EmailLoginTextBox.Text.Trim()
        _PasswordLogin = PasswordLoginTextBox.Text.Trim()
    End Sub

    ''' <summary>
    ''' Clear the register text box
    ''' </summary>
    Private Sub ClearRegisterTextBox()
        NameTextBox.Clear()
        EmailRegisterTextBox.Clear()
        PasswordRegisterTextBox.Clear()
    End Sub

    ''' <summary>
    ''' Clear the login text box
    ''' </summary>
    Private Sub ClearLoginTextBox()
        EmailLoginTextBox.Clear()
        PasswordLoginTextBox.Clear()
    End Sub

    Private Sub ShowPasswordToggleSwitchCheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordRegisterToggleSwitch.CheckedChanged, ShowPasswordLoginToggleSwitch.CheckedChanged
        ' Register password checked
        If ShowPasswordRegisterToggleSwitch.Checked = True Then
            PasswordRegisterTextBox.UseSystemPasswordChar = False
        Else
            PasswordRegisterTextBox.UseSystemPasswordChar = True
        End If

        ' Login password checked
        If ShowPasswordLoginToggleSwitch.Checked Then
            PasswordLoginTextBox.UseSystemPasswordChar = False
        Else
            PasswordLoginTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ExitGradientButtonClick(sender As Object, e As EventArgs) Handles ExitGradientButton.Click
        Dim confirmToQuit As MsgBoxResult = ConfirmMessageDialog.Show("Are you sure want to quit?", "Confirmation")

        If confirmToQuit = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub NameRegisterTextBoxMouseHover() Handles NameTextBox.MouseHover
        NameToolTip.SetToolTip(NameTextBox, "Input your Name")
    End Sub

    Private Sub EmailRegisterTextBoxMouseHover() Handles EmailRegisterTextBox.MouseHover, EmailLoginTextBox.MouseHover
        Const caption = "Input your Email"

        EmailToolTip.SetToolTip(EmailRegisterTextBox, caption)
        EmailToolTip.SetToolTip(EmailLoginTextBox, caption)
    End Sub

    Private Sub PasswordRegisterTextBoxMouseHover() Handles PasswordRegisterTextBox.MouseHover, PasswordLoginTextBox.MouseHover
        Const caption = "Input your Password"

        PasswordToolTip.SetToolTip(PasswordRegisterTextBox, caption)
        PasswordToolTip.SetToolTip(PasswordLoginTextBox, caption)
    End Sub
End Class