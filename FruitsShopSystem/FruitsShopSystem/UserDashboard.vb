Public Class UserDashboard
    Private Sub UserTransactionsLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        HomeGradientButton.Checked = True

        If HomeGradientButton.Checked = True Then
            SwitchPanel(Home)
        End If
    End Sub

    Private Sub ExitGradientButtonClick(sender As Object, e As EventArgs) Handles ExitGradientButton.Click
        Dim confirmToQuit As MsgBoxResult = ConfirmMessageDialog.Show("Are you sure want to quit?", "Confirmation")

        If confirmToQuit = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub HomeGradientButtonClick(sender As Object, e As EventArgs) Handles HomeGradientButton.Click
        If HomeGradientButton.Checked = True Then
            SwitchPanel(Home)
        End If
    End Sub

    Private Sub AccountGradientButtonClick(sender As Object, e As EventArgs) Handles AccountGradientButton.Click
        If AccountGradientButton.Checked = True Then
            SwitchPanel(Account)
        End If
    End Sub

    ''' <summary>
    ''' Switch between panels
    ''' <param name="panel">Panel to be switched</param>
    ''' </summary>
    Private Sub SwitchPanel(ByVal panel As Form)
        HomePanel.Controls.Clear()
        panel.TopLevel = False
        HomePanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub ProfileCircleButtonClick(sender As Object, e As EventArgs) Handles ProfileCircleButton.Click
        AccountGradientButton.Checked = True

        SwitchPanel(Account)
    End Sub
End Class