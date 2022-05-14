Public Class Account
    Private Sub AccountTextBoxMouseHover() Handles NameTextBox.MouseHover, EmailTextBox.MouseHover, PasswordTextBox.MouseHover
        NameToolTip.SetToolTip(NameTextBox, "Your name")
        EmailToolTip.SetToolTip(EmailTextBox, "Your email address")
        PasswordToolTip.SetToolTip(PasswordTextBox, "Your password")
    End Sub

    Private Sub UpdateGradientButtonClick(sender As Object, e As EventArgs) Handles UpdateGradientButton.Click
        SuccessMessageDialog.Show("Update Successfully!", "Success")
    End Sub
End Class