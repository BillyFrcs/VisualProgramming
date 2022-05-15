Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class Account
    Private Property _Name As String
    Private Property _Email As String
    Private Property _Password As String

    Private ReadOnly _empty As String = String.Empty

    ' Email validation
    Private ReadOnly _regex As New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")

    ' SQL Connection to the database
    Private Const _serverName = "BILLY"
    Private Const _databaseName = "FruitsShop"

    Private ReadOnly _SQLConnection As New SqlConnection($"Data Source={_serverName};Initial Catalog={_databaseName};Integrated Security=True")

    Private Sub AccountLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.UseSystemPasswordChar = True

        Try
            _SQLConnection.Open()

            ' Dim selectQuery = "SELECT Name, Email, Password FROM FruitsShop.dbo.UserAccount WHERE Email = '" & UserAccount.Instance().GetLoginEmail() & "'"
            Dim selectQuery = "SELECT Name, Email, Password FROM FruitsShop.dbo.UserAccount WHERE ID = 3"

            Using SQLCommand As New SqlCommand(selectQuery)
                With SQLCommand
                    .CommandType = CommandType.Text
                    .Connection = _SQLConnection

                    ' .Parameters.AddWithValue("@Email", UserAccount.Instance().GetLoginEmail())

                    Using sqlReader As SqlDataReader = SQLCommand.ExecuteReader()
                        While sqlReader.Read()
                            NameTextBox.Text = sqlReader("Name").ToString()
                            EmailTextBox.Text = sqlReader("Email").ToString()
                            PasswordTextBox.Text = sqlReader("Password").ToString()
                        End While
                    End Using
                End With
            End Using
        Catch ex As SqlException
            ErrorMessageDialog.Show(ex.Message(), "Error")
        Finally
            _SQLConnection.Close()
        End Try
    End Sub

    Private Sub InitializeAccount()
        _Name = NameTextBox.Text
        _Email = EmailTextBox.Text
        _Password = PasswordTextBox.Text
    End Sub

    Private Sub AccountTextBoxMouseHover() Handles NameTextBox.MouseHover, EmailTextBox.MouseHover, PasswordTextBox.MouseHover
        NameToolTip.SetToolTip(NameTextBox, "Your name")
        EmailToolTip.SetToolTip(EmailTextBox, "Your email address")
        PasswordToolTip.SetToolTip(PasswordTextBox, "Your password")
    End Sub

    Private Sub UpdateGradientButtonClick(sender As Object, e As EventArgs) Handles UpdateGradientButton.Click
        InitializeAccount()

        Try
            If _Name IsNot _empty And _Email IsNot _empty And _Password IsNot _empty Then
                If _regex.IsMatch(_Email) Then
                    SuccessMessageDialog.Show("Update Successfully!", "Success")
                Else
                    ErrorMessageDialog.Show("Invalid email address!", "Error")
                End If
            Else
                ErrorMessageDialog.Show("Please fill all the fields!", "Error")
            End If
        Catch ex As SqlException
            ErrorMessageDialog.Show(ex.Message(), "Error")
        End Try
    End Sub

    Private Sub ShowPasswordToggleSwitchCheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordToggleSwitch.CheckedChanged
        ' Login password checked  
        If ShowPasswordToggleSwitch.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub
End Class