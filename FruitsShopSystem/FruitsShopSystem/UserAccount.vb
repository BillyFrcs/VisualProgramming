Public Class UserAccount
    ' Register properties
    Private Property _NameRegister As String
    Private Property _EmailRegister As String
    Private Property _PasswordRegister As String

    ' Login properties
    Private Property _EmailLogin As String
    Private Property _PasswordLogin As String

    Private ReadOnly _empty As String = String.Empty

    Private Sub LoginLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordRegisterTextBox.UseSystemPasswordChar = True
        PasswordLoginTextBox.UseSystemPasswordChar = True
    End Sub

    Private Sub LoginLabelClick(sender As Object, e As EventArgs) Handles LoginCursorLabel.Click
        RegisterGuna2ShadowPanel.Visible = False
        Guna2Transition1.HideSync(RegisterGuna2ShadowPanel)
    End Sub

    Private Sub CreateAccountButtonClick(sender As Object, e As EventArgs) Handles CreateAccounButton.Click
        RegisterGuna2ShadowPanel.Visible = True
        Guna2Transition1.ShowSync(RegisterGuna2ShadowPanel)
    End Sub

    Private Sub RegisterGradientButtonClick(sender As Object, e As EventArgs) Handles RegisterGradientButton.Click
        InitializeRegisterAccount()

        If _NameRegister = _empty Or _EmailRegister = _empty Or _PasswordRegister = _empty Then
            ErrorMessageDialog.Show("Please fill the form!", "Error")
        Else
            SuccessMessageDialog.Show("Registration Successfully!", "Success")
        End If
    End Sub

    Private Sub InitializeRegisterAccount()
        _NameRegister = NameTextBox.Text
        _EmailRegister = EmailRegisterTextBox.Text
        _PasswordRegister = PasswordRegisterTextBox.Text
    End Sub

    Private Sub InitializeLoginAccount()
        _EmailLogin = EmailLoginTextBox.Text
        _PasswordLogin = PasswordLoginTextBox.Text
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

    Private Sub LoginGradientButtonClick(sender As Object, e As EventArgs) Handles LoginGradientButton.Click
        InitializeLoginAccount()

        If _EmailLogin = _empty Or _PasswordLogin = _empty Then
            ErrorMessageDialog.Show("Please fill the form!", "Error")
        Else
            SuccessMessageDialog.Show("Login Successfully!", "Success")
        End If
    End Sub
End Class