Public Class Form1
    Private _name As String = "Billy"

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox($"Hi {_name}!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.KeyPress
        Dim message As String = $"Hey {_name} you pressed me."

        MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.MouseUp
        MsgBox("Yooo " & _name)
    End Sub
End Class
