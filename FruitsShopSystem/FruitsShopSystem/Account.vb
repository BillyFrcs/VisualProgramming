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
        InitializeAccount()

        PasswordTextBox.UseSystemPasswordChar = True
    End Sub

    ''' <summary>
    ''' Initialize the user account form
    ''' </summary>
    Private Sub InitializeAccount()
        _Name = NameTextBox.Text
        _Email = EmailTextBox.Text
        _Password = PasswordTextBox.Text
    End Sub

    Private Sub AccountTextBoxMouseHover() Handles NameTextBox.MouseHover, EmailTextBox.MouseHover, PasswordTextBox.MouseHover
        NameToolTip.SetToolTip(NameTextBox, "Your Name")
        EmailToolTip.SetToolTip(EmailTextBox, "Your Email Address")
        PasswordToolTip.SetToolTip(PasswordTextBox, "Your Password")
    End Sub

    Private Sub UpdateGradientButtonClick(sender As Object, e As EventArgs) Handles UpdateGradientButton.Click
        Call InitializeAccount()

        Try
            If _Name IsNot _empty And _Email IsNot _empty And _Password IsNot _empty Then
                If _regex.IsMatch(_Email) Then
                    _SQLConnection.Open()

                    Dim updateQuery = $"UPDATE {_databaseName}.dbo.UserAccount SET Name = '" & _Name & "' , Email = '" & _Email & "' , Password = '" & _Password & "' WHERE Email = '" & _Email & "'"

                    Using SQLCommand As New SqlCommand(updateQuery)
                        With SQLCommand
                            .Connection = _SQLConnection
                            .CommandType = CommandType.Text

                            .Parameters.AddWithValue("@Name", _Name)
                            .Parameters.AddWithValue("@Email", _Email)
                            .Parameters.AddWithValue("@Password", _Password)

                            .ExecuteNonQuery()
                        End With

                        SuccessMessageDialog.Show("Your account has been updated", "Success")
                    End Using
                Else
                    ErrorMessageDialog.Show("Invalid email address!", "Error")
                End If
            Else
                ErrorMessageDialog.Show("Please fill all the fields!", "Error")
            End If
        Catch ex As SqlException
            ErrorMessageDialog.Show(ex.Message(), "Error")
        Finally
            _SQLConnection.Close()
        End Try
    End Sub

    Private Sub ShowPasswordToggleSwitchCheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordToggleSwitch.CheckedChanged
        If ShowPasswordToggleSwitch.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub EmailSearchGradientButtonClick(sender As Object, e As EventArgs) Handles EmailSearchGradientButton.Click
        Call InitializeAccount()

        Try
            If _Email IsNot _empty Then
                If _regex.IsMatch(_Email) Then
                    _SQLConnection.Open()

                    Dim selectQuery = $"SELECT Name, Email, Password FROM {_databaseName}.dbo.UserAccount WHERE Email = '" & _Email & "'"

                    Using SQLCommand As New SqlCommand(selectQuery)
                        With SQLCommand
                            .CommandType = CommandType.Text
                            .Connection = _SQLConnection

                            .Parameters.AddWithValue("@Email", _Email)

                            Dim adapter As New SqlDataAdapter(SQLCommand)
                            Dim dataTable As New DataTable()

                            adapter.Fill(dataTable)

                            SQLCommand.ExecuteNonQuery()

                            If dataTable.Rows.Count > 0 Then
                                Using sqlReader As SqlDataReader = SQLCommand.ExecuteReader()
                                    While sqlReader.Read() = True
                                        NameTextBox.Text = sqlReader("Name").ToString()
                                        EmailTextBox.Text = sqlReader("Email").ToString()
                                        PasswordTextBox.Text = sqlReader("Password").ToString()
                                    End While

                                    SuccessMessageDialog.Show("Found your data!", "Success")
                                End Using
                            Else
                                Call ClearAccount()

                                ErrorMessageDialog.Show("Email address not found!", "Error")
                            End If
                        End With
                    End Using
                Else
                    ErrorMessageDialog.Show("Invalid email address!", "Error")
                End If
            Else
                ErrorMessageDialog.Show("Please fill your email address!", "Error")
            End If
        Catch ex As SqlException
            ErrorMessageDialog.Show(ex.Message(), "Error")
        Finally
            _SQLConnection.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Clear account text box
    ''' </summary>
    Private Sub ClearAccount()
        NameTextBox.Clear()
        EmailTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub
End Class