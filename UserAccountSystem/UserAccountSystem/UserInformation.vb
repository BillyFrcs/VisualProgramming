Imports System.IO

Public Class UserInformation
    Private _Username As String

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Load_UserInformation() Handles MyBase.Load
        SignUp.Hide()
        SignIn.Hide()

        DisplayUserInformation(UserModule.RealName, UserModule.Username, UserModule.Email, UserModule.Password, UserModule.Language, UserModule.Gender)
    End Sub

    ''' <summary>
    '''  Display user data in User Information form 
    ''' </summary>
    ''' <param name="realName">String</param>
    ''' <param name="username">String</param>
    ''' <param name="email">String</param>
    ''' <param name="password">String</param>
    ''' <param name="language">String</param>
    ''' <param name="gender">String</param>
    Private Sub DisplayUserInformation(realName As String, username As String, email As String, password As String, language As String, gender As String)
        NameLabelTitle.Text = $"Hi, {realName.Replace("Name:", "Hi,")}"
        NameLabel.Text = $"Name: {realName}"
        UsernameLabel.Text = $"Username: {username}"
        EmailLabel.Text = $"Email: {email}"
        PasswordLabel.Text = $"Password: {password}"
        LanguageLabel.Text = $"Language: {language}"
        GenderLabel.Text = $"Gender: {gender}"
    End Sub

    ''' <summary>
    ''' Reset user information after deleted user account
    ''' </summary>
    Private Sub ResetUserInformation()
        NameLabelTitle.Text = String.Empty
        NameLabel.Text = String.Empty
        UsernameLabel.Text = String.Empty
        EmailLabel.Text = String.Empty
        PasswordLabel.Text = String.Empty
        LanguageLabel.Text = String.Empty
        GenderLabel.Text = String.Empty
    End Sub

    Private Sub DeleteAccountButton_Click(sender As Object, e As EventArgs) Handles DeleteAccountButton.Click
        DeleteUserAccount()
    End Sub

    Private Sub DeleteUserAccount()
        _Username = DeleteUsernameTextBox.Text

        If _Username IsNot String.Empty Then
            If Not File.Exists(_Username & UserModule.Path) Then
                MessageBox.Show("Cannot found your account, or maybe you've been deleted your account!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim confirmToDelete As MsgBoxResult = MessageBox.Show("Are you sure want to delete your account?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                ' Confirm dialog to delete account
                If confirmToDelete = MsgBoxResult.Yes Then
                    ResetUserInformation()

                    ' Delete user account data
                    My.Computer.FileSystem.DeleteFile(_Username & UserModule.Path)

                    FileClose()

                    MessageBox.Show("Delete account successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
                MsgBox("Please enter your username first!", MsgBoxStyle.Critical, "Warning")
        End If
    End Sub

    Private Sub DeleteAccountButton_MouseHover() Handles DeleteAccountButton.MouseHover
        DeleteAccountButton.BackColor = Color.Red
    End Sub

    Private Sub DeleteAccountButton_MouseLeave() Handles DeleteAccountButton.MouseLeave
        DeleteAccountButton.BackColor = Color.White
    End Sub

    Private Sub CloseButton_MouseHover() Handles CloseButton.MouseHover
        CloseButton.BackColor = Color.IndianRed
    End Sub

    Private Sub CloseButton_MouseLeave() Handles CloseButton.MouseLeave
        CloseButton.BackColor = Color.White
    End Sub

    Private Sub DeleteUsernameTextBox_MouseHover() Handles DeleteUsernameTextBox.MouseHover
        UsernameToolTip.SetToolTip(DeleteUsernameTextBox, "Enter your Username")
    End Sub
End Class