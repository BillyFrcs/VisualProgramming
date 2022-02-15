Public Class Information
    Private Sub Information_Load(sender As Object, e As EventArgs) Handles Me.Load
        Login.Hide()

        MessageBox.Show("Welcome! " & Username, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' MsgBox("Welcome! " & Username)

        Me.UsernameLabel.Text = "Hi, " & Username
    End Sub

    Private Sub Information_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub
End Class