Public Class Registration
    Private _Name As String
    Private _Gender As String
    Private _Program As String

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        _Name = NameTextBox.Text
        _Gender = GenderComboText.SelectedItem
        _Program = ProgramComboText.SelectedItem

        ShowInformation()
    End Sub

    Private Sub ShowInformation()
        If _Name IsNot String.Empty And _Gender IsNot String.Empty And _Program IsNot String.Empty Then
            MessageBox.Show($"Name: {_Name} {vbCrLf}Gender: {_Gender} {vbCrLf}Program: {_Program}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please fill the registration!", "Invalid", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CloseButton_Click() Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click() Handles ClearButton.Click
        ClearRegistration()
    End Sub

    Private Sub ClearRegistration()
        NameTextBox.Text = String.Empty
        GenderComboText.Text = String.Empty
        ProgramComboText.Text = String.Empty
    End Sub
End Class
