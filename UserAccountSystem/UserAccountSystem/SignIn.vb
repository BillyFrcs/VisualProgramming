﻿Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions

Public Class SignIn
    Private _Username As String
    Private _Email As String
    Private _Password As String

    Private ReadOnly _UserData As SignUp = New SignUp

    Private Sub CancelButtonClick(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Hide()

        ' SignUp.ShowDialog()
    End Sub

    Private Sub LoadSignIn() Handles MyBase.Load
        ' SignUp.Hide()

        Me.PasswordTextBox.PasswordChar = "•"
    End Sub

    Private Sub ShowPasswordCheckBoxCheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked Then
            Me.PasswordTextBox.PasswordChar = String.Empty
        Else
            Me.PasswordTextBox.PasswordChar = "•"
        End If
    End Sub

    Private Sub LoginButtonClick(sender As Object, e As EventArgs) Handles LoginButton.Click
        InitializeUserData()

        ' Display user information
        _UserData.ReadUserData(_Username)

        Dim empty As String = String.Empty

        If _Username IsNot empty And _Email IsNot empty And _Password IsNot empty Then
            If File.Exists(_Username + UserModule.FileName) Then
                ' Find user account in database
                Dim findUserAccount = File.ReadAllLines(_Username + UserModule.FileName)

                If findUserAccount.Contains(_Username) And findUserAccount.Contains(_Email) And findUserAccount.Contains(_Password) Then
                    Debug.LogMiniBox($"Welcome back {_Username}!", "Information")

                    Dashboard.ShowDialog()

                    FileClose()
                Else
                    Debug.LogMiniBox("Cannot found your account, please try again!", "Warning")
                End If
            Else
                MessageBox.Show("Please create your account first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MsgBox("Please fill the SignIn form!", MsgBoxStyle.Critical, "Warning")

            ' MessageBox.Show("Please fill the SignIn form!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ''' <summary>
    ''' Initialize user data to SignIn
    ''' </summary>
    Private Sub InitializeUserData()
        _Username = UsernameTextBox.Text
        _Email = EmailTextBox.Text
        _Password = PasswordTextBox.Text
    End Sub

    Private Sub LoginButtonMouseHover() Handles LoginButton.MouseHover
        LoginButton.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub LoginButtonMouseLeave() Handles LoginButton.MouseLeave
        LoginButton.BackColor = Color.White
    End Sub

    Private Sub BackButtonMouseHover() Handles CancelButton.MouseHover
        CancelButton.BackColor = Color.IndianRed
    End Sub

    Private Sub BackButtonMouseLeave() Handles CancelButton.MouseLeave
        CancelButton.BackColor = Color.White
    End Sub

    Private Sub UserNameTextBoxMouseHover() Handles UsernameTextBox.MouseHover
        UsernameToolTip.SetToolTip(UsernameTextBox, "Input your Username")
    End Sub

    Private Sub EmailTextBoxMouseHover() Handles EmailTextBox.MouseHover
        EmailToolTip.SetToolTip(EmailTextBox, "Input your Email")
    End Sub

    Private Sub PasswordTextBoxMouseHover() Handles PasswordTextBox.MouseHover
        PasswordToolTip.SetToolTip(PasswordTextBox, "Input your Password")
    End Sub

    Private Sub LoginButtonValidating(sender As Object, e As CancelEventArgs) Handles LoginButton.Validating
        If String.IsNullOrEmpty(UsernameTextBox.Text.Trim) Then
            Debug.Instance.LogError(UsernameTextBox, "Username is required!")
        Else
            Debug.Instance.LogError(UsernameTextBox, String.Empty)
        End If

        If String.IsNullOrEmpty(EmailTextBox.Text.Trim) Then
            Debug.Instance.LogError(EmailTextBox, "Email is required!")
        Else
            Debug.Instance.LogError(EmailTextBox, String.Empty)
        End If

        If String.IsNullOrEmpty(PasswordTextBox.Text.Trim) Then
            Debug.Instance.LogError(PasswordTextBox, "Password is required!")
        Else
            Debug.Instance.LogError(PasswordTextBox, String.Empty)
        End If
    End Sub

    Public Function GetErrorValidation()
        Return ErrorProviderValidation
    End Function
End Class