Public Class ForNext
    Private _text As String
    Private _totalNumber As Integer

    Private Sub ExitAppButton(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub ClearItemsButton(sender As Object, e As EventArgs) Handles ClearButton.Click
        InputSomethingTextBox.Text = String.Empty
        LoopCountTextBox.Text = String.Empty

        ListBoxItems.Items.Clear()
    End Sub

    Private Sub GenerateItemsButton(sender As Object, e As EventArgs) Handles GenerateButton.Click
        _text = InputSomethingTextBox.Text
        _totalNumber = Val(LoopCountTextBox.Text)

        For i = 0 + 1 To _totalNumber
            ListBoxItems.Items.Add(_text)
        Next
    End Sub
End Class
