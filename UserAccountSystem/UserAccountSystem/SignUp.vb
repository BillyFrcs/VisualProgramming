Imports System.IO

Public Class SignUp
    Private _Name As String
    Private _Username As String
    Private _Email As String
    Private _Password As String
    Private _Language As String
    Private _Gender As String

    Private _WriteUserdata As StreamWriter
    Private _ReadData As StreamReader

    Private Sub SignInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignInToolStripMenuItem.Click
        SignIn.ShowDialog()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub CreateAccountButton_Click(sender As Object, e As EventArgs) Handles CreateAccountButton.Click
        SaveNewAccount()
    End Sub

    ''' <summary>
    ''' Save new user account
    ''' </summary>
    Private Sub SaveNewAccount()
        CreateNewAccount()
    End Sub

    ''' <summary>
    ''' Initialize user data 
    ''' </summary>
    Private Sub InitializeUserData()
        _Name = NameTextBox.Text
        _Username = UsernameTextBox.Text
        _Email = EmailTextBox.Text
        _Password = PasswordTextBox.Text
        _Language = LanguageComboBox.Text

        If MaleRadioButton.Checked = True Then
            _Gender = MaleRadioButton.Text
        ElseIf FemaleRadioButton.Checked = True Then
            _Gender = FemaleRadioButton.Text
        Else
            _Gender = UnknownRadioButton.Text
        End If
    End Sub

    ''' <summary>
    ''' Create new user account and save the data into Database file
    ''' </summary>
    Private Sub CreateNewAccount()
        InitializeUserData()

        Dim empty As String = String.Empty

        If _Name IsNot empty And _Username IsNot empty And _Email IsNot empty And _Password IsNot empty And _Language IsNot empty And _Gender IsNot empty Then
            MessageBox.Show("Success to create new account!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Save data into a file
            _WriteUserdata = New StreamWriter(_Username + UserModule.Path, True)

            _WriteUserdata.WriteLine(_Name)
            _WriteUserdata.WriteLine(_Username)
            _WriteUserdata.WriteLine(_Email)
            _WriteUserdata.WriteLine(_Password)
            _WriteUserdata.WriteLine(_Language)
            _WriteUserdata.WriteLine(_Gender)

            _WriteUserdata.Close()

            ' Display user information
            ReadUserData(_Username)

            UserInformation.ShowDialog()
        Else
            MsgBox("Please complete the form to Sign Up your account!", MsgBoxStyle.Critical, "Warning")
        End If
    End Sub

    Private Sub CreateAccountButton_MouseHover() Handles CreateAccountButton.MouseHover
        CreateAccountButton.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub CreateAccountButton_MouseLeave() Handles CreateAccountButton.MouseLeave
        CreateAccountButton.BackColor = Color.White
    End Sub

    Private Sub CloseButton_MouseHover() Handles CloseButton.MouseHover
        CloseButton.BackColor = Color.IndianRed
    End Sub

    Private Sub CloseButton_MouseLeave() Handles CloseButton.MouseLeave
        CloseButton.BackColor = Color.White
    End Sub

    ''' <summary>
    ''' Read user data from Database file
    ''' </summary>
    Public Sub ReadUserData(username As String)
        If File.Exists(username + UserModule.Path) Then
            _ReadData = New StreamReader(username + UserModule.Path, True)

            While Not _ReadData.EndOfStream
                _Name = _ReadData.ReadLine & vbCrLf
                _Username = _ReadData.ReadLine & vbCrLf
                _Email = _ReadData.ReadLine & vbCrLf
                _Password = _ReadData.ReadLine & vbCrLf
                _Language = _ReadData.ReadLine & vbCrLf
                _Gender = _ReadData.ReadLine & vbCrLf
            End While

            ' Global variables
            UserModule.RealName = _Name
            UserModule.Username = _Username
            UserModule.Email = _Email
            UserModule.Password = _Password
            UserModule.Language = _Language
            UserModule.Gender = _Gender

            _ReadData.Close()

            ' DEBUG
            ' DebugLog($"{RealName}{Username}{Email}{Password}{Language}{Gender}", "Information")
        End If
    End Sub

    Private Sub Load_SignUp() Handles MyBase.Load
        Me.PasswordTextBox.PasswordChar = "•"
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked = True Then
            Me.PasswordTextBox.PasswordChar = String.Empty
        Else
            Me.PasswordTextBox.PasswordChar = "•"
        End If
    End Sub
End Class
