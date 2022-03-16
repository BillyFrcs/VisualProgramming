Public Class DoUntil
    Private _day As Integer
    Private _month As Integer

    Private Sub GenerateDayItemsButton(sender As Object, e As EventArgs) Handles GenerateDayButton.Click
        _day = 1

        Do
            ListBoxMonth.Items.Add(WeekdayName(_day))

            _day += 1
        Loop Until _day > 7

        GenerateMonthButton.Enabled = False
    End Sub

    Private Sub GenerateMonthItemsButton(sender As Object, e As EventArgs) Handles GenerateMonthButton.Click
        _month = 1

        Do
            ListBoxMonth.Items.Add(MonthName(_month))

            _month += 1
        Loop Until _month > 12

        GenerateDayButton.Enabled = False
    End Sub

    Private Sub ClearItemsButton(sender As Object, e As EventArgs) Handles ClearButton.Click
        ListBoxMonth.Items.Clear()

        GenerateDayButton.Enabled = True
        GenerateMonthButton.Enabled = True
    End Sub

    Private Sub ExitAppButton(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class