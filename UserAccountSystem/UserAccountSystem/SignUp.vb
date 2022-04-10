Imports System.IO

Public Class SignUp
    Private _Name As String
    Private _Username As String
    Private _Email As String
    Private _Password As String
    Private _Language As String
    Private _Gender As String

    Private _WriteUserData As StreamWriter
    Private _ReadData As StreamReader

    Private Sub SignInToolStripMenuItemClick(sender As Object, e As EventArgs) Handles SignInToolStripMenuItem.Click
        SignIn.ShowDialog()
    End Sub

    Private Sub CloseButtonClick(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim confirmToQuit As MsgBoxResult = DialogModule.Debug.Instance.Log("Are you sure want to quit?", "Information", True)

        If (confirmToQuit = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub CreateAccountButtonClick(sender As Object, e As EventArgs) Handles CreateAccountButton.Click
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
            Debug.Instance.Log("Success to create new account!", "Information")

            ' Save data into a file
            _WriteUserData = New StreamWriter(_Username + UserModule.Path, True)

            _WriteUserData.WriteLine(_Name)
            _WriteUserData.WriteLine(_Username)
            _WriteUserData.WriteLine(_Email)
            _WriteUserData.WriteLine(_Password)
            _WriteUserData.WriteLine(_Language)
            _WriteUserData.WriteLine(_Gender)

            _WriteUserData.Close()

            ' Display user information
            ReadUserData(_Username)

            Dashboard.ShowDialog()
        Else
            MsgBox("Please complete the form to Sign Up your account!", MsgBoxStyle.Critical, "Warning")
        End If
    End Sub

    Private Sub CreateAccountButtonMouseHover() Handles CreateAccountButton.MouseHover
        CreateAccountButton.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub CreateAccountButtonMouseLeave() Handles CreateAccountButton.MouseLeave
        CreateAccountButton.BackColor = Color.White
    End Sub

    Private Sub CloseButtonMouseHover() Handles CloseButton.MouseHover
        CloseButton.BackColor = Color.IndianRed
    End Sub

    Private Sub CloseButtonMouseLeave() Handles CloseButton.MouseLeave
        CloseButton.BackColor = Color.White
    End Sub

    ''' <summary>
    ''' Read user data from Database file
    ''' </summary>
    Public Sub ReadUserData(username As String)
        ' Check if the user's data is exists or not
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
            ' Debug.Instance.Log($"{RealName}{username}{Email}{Password}{Language}{Gender}", "Information")
        End If
    End Sub

    Private Sub LoadSignUp() Handles MyBase.Load
        Me.PasswordTextBox.PasswordChar = "•"

        LanguageCollection()
    End Sub

    Private Sub ShowPasswordCheckBoxCheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked = True Then
            Me.PasswordTextBox.PasswordChar = String.Empty
        Else
            Me.PasswordTextBox.PasswordChar = "•"
        End If
    End Sub

    Private Sub LanguageCollection()
        Dim collection As New List(Of String)({"English", "Indonesian", "Spanish", "French", "Korean"})

        ' Dim collection As New List(Of String)

        ' collection.Add("English")
        ' collection.Add("Indonesian")
        ' collection.Add("Spanish")
        ' collection.Add("French")
        ' collection.Add("Korean")

        For Each col As String In collection
            LanguageComboBox.Items.Add(col)
        Next
    End Sub
End Class