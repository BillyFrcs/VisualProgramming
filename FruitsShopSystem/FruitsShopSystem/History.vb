Imports System.Data.SqlClient

Public Class History
    Private _searchData As String

    Private ReadOnly _empty As String = String.Empty

    Private _Bitmap As Bitmap

    ' SQL Connection to the database
    Private Const _serverName = "BILLY"
    Private Const _databaseName = "FruitsShop"

    Private ReadOnly _SQLConnection As New SqlConnection($"Data Source={_serverName};Initial Catalog={_databaseName};Integrated Security=True")

    Private Sub HistoryLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayUserTransaction()
    End Sub

    Private Sub SearchHistoryCircleButtonClick(sender As Object, e As EventArgs) Handles SearchHistoryTransactionCircleButton.Click
        InitializeData()

        Try
            If _searchData IsNot _empty Then
                _SQLConnection.Open()

                Dim searchQuery = $"SELECT * FROM {_databaseName}.dbo.[Transaction] WHERE Transaction_ID LIKE '%" & _searchData & "%' OR Fruit_Name LIKE '%" & _searchData & "%'"

                Using SQLCommand As New SqlCommand()
                    With SQLCommand
                        .Connection = _SQLConnection
                        .CommandType = CommandType.Text
                        .CommandText = searchQuery

                        Dim SQLDataReader As SqlDataReader = .ExecuteReader()

                        Dim dataTable As New DataTable()

                        dataTable.Load(SQLDataReader)

                        HistoryTransactionDataGridView.DataSource = dataTable
                    End With
                End Using

                ClearData()

                _SQLConnection.Close()
            Else
                ErrorMessageDialog.Show("Yoo the search box is still empty!", "Error")
            End If
        Catch ex As SqlException
            ErrorMessageDialog.Show(ex.Message(), "Error")
        End Try
    End Sub

    ''' <summary>
    ''' Initializes the data.
    ''' </summary>
    Private Sub InitializeData()
        _searchData = SearchHistoryTransactionTextBox.Text
    End Sub

    ''' <summary>
    ''' Clear the text box
    ''' </summary>
    Private Sub ClearData()
        SearchHistoryTransactionTextBox.Clear()
    End Sub

    ''' <summary>
    ''' Display all the user transaction
    ''' </summary>
    Private Sub DisplayUserTransaction()
        Try
            _SQLConnection.Open()

            Dim selectQuery = $"SELECT * FROM {_databaseName}.dbo.[Transaction]"

            Using SQLCommand As New SqlCommand()
                With SQLCommand
                    .Connection = _SQLConnection
                    .CommandType = CommandType.Text
                    .CommandText = selectQuery

                    Dim reader As SqlDataAdapter = New SqlDataAdapter(SQLCommand)

                    Dim dataTable As New DataTable()

                    reader.Fill(dataTable)

                    HistoryTransactionDataGridView.DataSource = dataTable

                    HistoryTransactionDataGridView.Columns(0).HeaderText = "Transaction ID"
                    HistoryTransactionDataGridView.Columns(1).HeaderText = "Fruit Name"
                    HistoryTransactionDataGridView.Columns(2).HeaderText = "Total Fruits"
                    HistoryTransactionDataGridView.Columns(3).HeaderText = "Total Price"
                    HistoryTransactionDataGridView.Columns(4).HeaderText = "Transaction Time"
                    HistoryTransactionDataGridView.Columns(5).HeaderText = "Transaction Date"
                End With
            End Using

            _SQLConnection.Close()
        Catch ex As SqlException
            ErrorMessageDialog.Show(ex.Message(), "Error")
        End Try
    End Sub

    Private Sub PrintButtonClick(sender As Object, e As EventArgs) Handles PrintHistoryTransactionGradientButton.Click
        Dim printHeight As Integer = HistoryTransactionDataGridView.Height

        HistoryTransactionDataGridView.Height = HistoryTransactionDataGridView.RowCount * HistoryTransactionDataGridView.RowTemplate.Height
        _Bitmap = New Bitmap(HistoryTransactionDataGridView.Width, HistoryTransactionDataGridView.Height)
        HistoryTransactionDataGridView.DrawToBitmap(_Bitmap, New Rectangle(0, 0, HistoryTransactionDataGridView.Width, HistoryTransactionDataGridView.Height))

        PrintPreviewDialogUserTransaction.Document = PrintHistoryTransactionDocument
        PrintPreviewDialogUserTransaction.PrintPreviewControl.Zoom = 1
        PrintPreviewDialogUserTransaction.ShowDialog()

        HistoryTransactionDataGridView.Height = printHeight
    End Sub

    Private Sub PrintUserDocumentPrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintHistoryTransactionDocument.PrintPage
        Const x As Integer = 50
        Const y As Integer = 50

        e.Graphics.DrawImage(_Bitmap, x, y)

        Dim rectangle = e.PageSettings.PrintableArea

        If HistoryTransactionDataGridView.Height - rectangle.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub

    Private Sub DeleteGradientButtonClick(sender As Object, e As EventArgs) Handles DeleteGradientButton.Click
        For Each row As DataGridViewRow In HistoryTransactionDataGridView.SelectedRows
            Dim transactionID As String = row.Cells(0).Value.ToString()

            Try
                _SQLConnection.Open()

                Dim deleteQuery = $"DELETE FROM {_databaseName}.dbo.[Transaction] WHERE Transaction_ID = '{transactionID}'"

                Using SQLCommand As New SqlCommand()
                    With SQLCommand
                        .Connection = _SQLConnection
                        .CommandType = CommandType.Text
                        .CommandText = deleteQuery

                        .ExecuteNonQuery()
                    End With
                End Using

                _SQLConnection.Close()

                UpdateDataTransaction()
            Catch ex As SqlException
                ErrorMessageDialog.Show(ex.Message(), "Error")
            Finally
                _SQLConnection.Close()
            End Try
        Next
    End Sub

    ''' <summary>
    ''' Update user data transaction 
    ''' </summary>
    Public Sub UpdateDataTransaction()
        Try
            _SQLConnection.Open()

            Dim searchQuery = $"SELECT * FROM {_databaseName}.dbo.[Transaction]"

            Using SQLCommand As New SqlCommand()
                With SQLCommand
                    .Connection = _SQLConnection
                    .CommandType = CommandType.Text
                    .CommandText = searchQuery

                    Dim SQLDataReader As SqlDataReader = .ExecuteReader()

                    Dim dataTable As New DataTable()

                    dataTable.Load(SQLDataReader)

                    HistoryTransactionDataGridView.DataSource = dataTable
                End With
            End Using

            _SQLConnection.Close()
        Catch ex As SqlException
            ErrorMessageDialog.Show(ex.Message(), "Error")
        End Try
    End Sub
End Class