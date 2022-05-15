Public Class History
    Private _searchData As String
    Private _searchEmail As String

    Private ReadOnly _empty As String = String.Empty

    Private Sub SearchHistoryCircleButtonClick(sender As Object, e As EventArgs) Handles SearchHistoryTransactionCircleButton.Click
        InitializeData()

        If _searchData IsNot _empty Then
            ClearData()
        Else
            ErrorMessageDialog.Show("Yoo the search box is still empty!", "Error")
        End If
    End Sub

    ''' <summary>
    ''' Initializes the data.
    ''' </summary>
    Private Sub InitializeData()
        _searchEmail = SearchEmailTextBox.Text
        _searchData = SearchHistoryTransactionTextBox.Text
    End Sub

    ''' <summary>
    ''' Clear the text box
    ''' </summary>
    Private Sub ClearData()
        SearchEmailTextBox.Clear()
        SearchHistoryTransactionTextBox.Clear()
    End Sub

    Private Sub SearchEmailCircleButtonClick(sender As Object, e As EventArgs) Handles SearchEmailCircleButton.Click
        InitializeData()

        If _searchEmail IsNot _empty Then
            ClearData()
        Else
            ErrorMessageDialog.Show("Yoo the search box is still empty!", "Error")
        End If
    End Sub
End Class