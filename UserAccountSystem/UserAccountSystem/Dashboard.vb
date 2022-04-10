Imports System.IO

Public Class Dashboard
    Private _Username As String

    Private Sub CloseButtonClick(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim confirmToQuit As MsgBoxResult = DialogModule.Debug.Instance.Log("Are you sure want to quit?", "Information", True)

        If (confirmToQuit = MsgBoxResult.Yes) Then
            Close()
        End If
    End Sub

    Private Sub LoadUserDashboard() Handles MyBase.Load
        SignUp.Hide()
        SignIn.Hide()

        Dim Name() As String = RealName.Split(" "c)

        Text = $"{Name(0)}'s Dashboard"

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
        Dim Name() As String = realName.Split(" "c)

        NameLabelTitle.Text = $"Hello, {Name(0).Replace("Name", realName) + "!"}"
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

        PictureBoxDashboard.Image = Nothing
    End Sub

    Private Sub DeleteAccountButtonClick(sender As Object, e As EventArgs) Handles DeleteAccountButton.Click
        DeleteUserAccount()
    End Sub

    Private Sub DeleteUserAccount()
        _Username = DeleteUsernameTextBox.Text

        If _Username IsNot String.Empty Then
            If Not File.Exists(_Username & UserModule.FileName) Then
                MessageBox.Show("Cannot found your account, or maybe you've been deleted your account!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim confirmToDelete As MsgBoxResult = DialogModule.Debug.Instance.Log("Are you sure want to delete your account?", "Information", True)

                ' Confirm dialog to delete account
                If confirmToDelete = MsgBoxResult.Yes Then
                    ResetUserInformation()

                    ' Delete user account data
                    My.Computer.FileSystem.DeleteFile(_Username & UserModule.FileName)

                    FileClose()

                    MessageBox.Show("Delete account successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MsgBox("Please input your username first!", MsgBoxStyle.Critical, "Warning")
        End If
    End Sub

    Private Sub DeleteAccountButtonMouseHover() Handles DeleteAccountButton.MouseHover
        DeleteAccountButton.BackColor = Color.Red
    End Sub

    Private Sub DeleteAccountButtonMouseLeave() Handles DeleteAccountButton.MouseLeave
        DeleteAccountButton.BackColor = Color.White
    End Sub

    Private Sub CloseButtonMouseHover() Handles CloseButton.MouseHover
        CloseButton.BackColor = Color.IndianRed
    End Sub

    Private Sub CloseButtonMouseLeave() Handles CloseButton.MouseLeave
        CloseButton.BackColor = Color.White
    End Sub

    Private Sub DeleteUsernameTextBoxMouseHover() Handles DeleteUsernameTextBox.MouseHover
        UsernameToolTip.SetToolTip(DeleteUsernameTextBox, "Input your Username")
    End Sub
End Class