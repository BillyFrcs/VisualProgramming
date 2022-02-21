Public Class InputForm
    Private _name As String
    Private _email As String

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Dim DataForm As DisplayDataForm = New DisplayDataForm

        DataForm.DataName = NameTextBox.Text
        DataForm.DataEmail = EmailTextBox.Text

        _name = NameTextBox.Text
        _email = EmailTextBox.Text

        If _name IsNot String.Empty And _email IsNot String.Empty Then
            DataForm.Show()
        Else
            MsgBox("Please fill the form first!", MsgBoxStyle.Critical, "Warning")
        End If
    End Sub
End Class
