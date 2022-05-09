﻿Imports System.Data.SqlClient

Public Class UserAccount
    ' Register properties
    Private Property _NameRegister As String
    Private Property _EmailRegister As String
    Private Property _PasswordRegister As String

    ' Login properties
    Private Property _EmailLogin As String
    Private Property _PasswordLogin As String

    Private ReadOnly _empty As String = String.Empty

    ' SQL Connection to the database
    Private ReadOnly _SQLConnection As New SqlConnection("Data Source=BILLY;Initial Catalog=FruitsShop;Integrated Security=True")

    ' Private _SQLCommand As SqlCommand

    Private Sub LoginLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordRegisterTextBox.UseSystemPasswordChar = True
        PasswordLoginTextBox.UseSystemPasswordChar = True

        ' Focus on the text box
        NameTextBox.Focus()
        EmailLoginTextBox.Focus()
    End Sub

    Private Sub LoginLabelClick(sender As Object, e As EventArgs) Handles LoginCursorLabel.Click
        RegisterShadowPanel.Visible = False
        TransitionUserAccountPage.HideSync(RegisterShadowPanel)
    End Sub

    Private Sub CreateAccountButtonClick(sender As Object, e As EventArgs) Handles CreateAccounButton.Click
        RegisterShadowPanel.Visible = True
        TransitionUserAccountPage.ShowSync(RegisterShadowPanel)
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
                ErrorMessageDialog.Show(New ArgumentNullException().Message(), "Error")
            Else
                _SQLConnection.Open()

                Dim insertQuery As String = "INSERT INTO FruitsShop.dbo.UserAccount ([Name], [Email], [Password]) VALUES ('" & _NameRegister & "', '" & _EmailRegister & "', '" & _PasswordRegister & "')"

                Using SQLCommand As New SqlCommand
                    With SQLCommand
                        .Connection = _SQLConnection
                        .CommandType = CommandType.Text
                        .CommandText = insertQuery

                        SQLCommand.Parameters.AddWithValue("@Name", _NameRegister)
                        SQLCommand.Parameters.AddWithValue("@Email", _EmailRegister)
                        SQLCommand.Parameters.AddWithValue("@Password", _PasswordRegister)
                    End With

                    SQLCommand.ExecuteNonQuery()
                    _SQLConnection.Close()

                    SuccessMessageDialog.Show($"Registration Successfully, Welcome {_NameRegister}!", "Success")
                End Using
            End If
        Catch ex As SQLException
            ErrorMessageDialog.Show(ex.Message())
        End Try

#If COMMENT Then
        Try
            If _NameRegister = _empty Or _EmailRegister = _empty Or _PasswordRegister = _empty Then
                ErrorMessageDialog.Show("Please fill the form!", "Error")
            Else
                _SQLConnection.Open()

                _SQLCommand = New SqlCommand("INSERT INTO FruitsShop.dbo.UserAccount ([Name], [Email], [Password]) VALUES ('" & _NameRegister & "', '" & _EmailRegister & "', '" & _PasswordRegister & "')", _SQLConnection)

                _SQLCommand.ExecuteNonQuery()

                _SQLConnection.Close()

                SuccessMessageDialog.Show("Registration Successfully!", "Success")
            End If
        Catch ex As SQLException
            ErrorMessageDialog.Show($"{ex.Message()}")
        End Try
#End If
    End Sub

    Private Sub LoginGradientButtonClick(sender As Object, e As EventArgs) Handles LoginGradientButton.Click
        InitializeLoginAccount()

        LoginAccount()
    End Sub

    ''' <summary>
    ''' Login user account
    ''' </summary>
    Private Sub LoginAccount()
        If _EmailLogin = _empty Or _PasswordLogin = _empty Then
            ErrorMessageDialog.Show(New ArgumentNullException().Message(), "Error")
        Else
            Try
                _SQLConnection.Open()

                Dim selectQuery As String = "SELECT * FROM FruitsShop.dbo.UserAccount WHERE Email = '" & _EmailLogin & "' AND Password = '" & _PasswordLogin & "'"

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
                        SuccessMessageDialog.Show($"Login Successfully!", "Success")
                    End If
                End Using
            Catch ex As SQLException
                ErrorMessageDialog.Show(ex.Message())
            End Try
        End If
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
End Class