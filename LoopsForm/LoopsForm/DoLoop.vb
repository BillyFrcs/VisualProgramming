Public Class DoLoop
    Private _number As Integer

    Private Sub GenerateEvenAndOddNumberButton(sender As Object, e As EventArgs) Handles GenerateButton.Click
        _number = Val(InputNumberTextBox.Text)

        Do
            _number = _number Mod 2

            If _number = 0 Then
                MessageBox.Show($"{InputNumberTextBox.Text} is an even number", "Even Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Do
            ElseIf _number = 1 Then
                MessageBox.Show($"{InputNumberTextBox.Text} is an odd number", "Odd Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Do
            End If
        Loop While Not _number
    End Sub

    Private Sub ClearInputButton(sender As Object, e As EventArgs) Handles ClearButton.Click
        InputNumberTextBox.Text = String.Empty
    End Sub

    Private Sub ExitAppButtonClick(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class