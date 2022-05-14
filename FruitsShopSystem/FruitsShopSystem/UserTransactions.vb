Public Class UserTransactions
    Private Sub UserTransactionsLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        HomeGradientButton.Checked = True
    End Sub

    Private Sub ExitGradientButton_Click(sender As Object, e As EventArgs) Handles ExitGradientButton.Click
        Dim confirmToQuit As MsgBoxResult = ConfirmMessageDialog.Show("Are you sure want to quit?", "Confirmation")

        If confirmToQuit = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
End Class