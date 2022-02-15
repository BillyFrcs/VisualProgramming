Public Class Login
    Private Const _Username = "BillyFrcs"
    Private Const _Password = "billy19"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If Me.UsernameBox.Text.Equals(_Username) And Me.PasswordBox.Text.Equals(_Password) Then
            ' Display username as an information
            Username = "BillyFrcs"

            Information.Show()
        Else
            MessageBox.Show("You're not authorized!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' MsgBox("You're not authorized!")
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub Load_Login(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PasswordBox.PasswordChar = "•"
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked = True Then
            Me.PasswordBox.PasswordChar = String.Empty
        Else
            Me.PasswordBox.PasswordChar = "•"
        End If
    End Sub
End Class
