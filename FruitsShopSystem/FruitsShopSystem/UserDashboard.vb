Imports System.Data.SqlClient

Public Class UserDashboard
    ' SQL Connection to the database
    Private Const _serverName = "BILLY"
    Private Const _databaseName = "FruitsShop"

    Private ReadOnly _SQLConnection As New SqlConnection($"Data Source={_serverName};Initial Catalog={_databaseName};Integrated Security=True")

    Private Sub UserDashboardLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        UserStatus()

        HomeGradientButton.Checked = True

        If HomeGradientButton.Checked = True Then
            SwitchPanel(Home)
        End If
    End Sub

    Private Sub UserStatus()
        Try
            _SQLConnection.Open()

            StatusHtmlLabel.Text = String.Concat("Online")
            StatusHtmlLabel.ForeColor = Color.Lime
        Catch ex As SqlException
            StatusHtmlLabel.Text = String.Concat("Offline")
            StatusHtmlLabel.ForeColor = Color.Red
        Finally
            _SQLConnection.Close()
        End Try
    End Sub

    Private Sub ExitGradientButtonClick(sender As Object, e As EventArgs)
        Dim confirmToQuit As MsgBoxResult = ConfirmMessageDialog.Show("Are you sure want to quit?", "Confirmation")

        If confirmToQuit = MsgBoxResult.Yes Then
            Close()

            UserAccount.Close()
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

    Private Sub LogoutGradientButtonClick(sender As Object, e As EventArgs) Handles LogoutGradientButton.Click
        UserAccount.Show()

        Me.Close()
    End Sub
End Class