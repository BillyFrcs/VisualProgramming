﻿Imports System.Data.SqlClient

Public Class Dashboard
    Private ReadOnly _connect As New SqlConnection("Data Source=BILLY;Initial Catalog=UserDatabase;Integrated Security=True")

    Private ReadOnly _empty = String.Empty

    Private _Bitmap As Bitmap

    Private Sub ExitButtonClick(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim confirmToQuit As MsgBoxResult = MessageBox.Show("Are you sure want to quit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If (confirmToQuit = MsgBoxResult.Yes) Then
            Close()
        End If
    End Sub

    Private Sub SaveButtonClick(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim firstName As String = FirstNameTextBox.Text
        Dim lastName As String = LastNameTextBox.Text
        Dim phone As String = Val(PhoneTextBox.Text)
        Dim email As String = EmailTextBox.Text

        Try
            ' check input is null or empty
            If firstName IsNot _empty And lastName IsNot _empty And phone IsNot _empty And email IsNot _empty Then

                _connect.Open()

                Dim command As New SqlCommand("INSERT INTO UserDatabase.dbo.Information (FirstName, LastName, Phone, Email) VALUES ('" & firstName & "', '" & lastName & "', '" & phone & "', '" & email & "')", _connect)

                command.ExecuteNonQuery()

                _connect.Close()

                MessageBox.Show("Data Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LoadDataInGridView()
            Else
                MessageBox.Show("Please fill all the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As SqlException
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub LoadDataInGridView()
        Try
            Dim command As New SqlCommand("SELECT * FROM UserDatabase.dbo.Information", _connect)
            Dim dataAdapter As New SqlDataAdapter(command)

            Dim dataTable As New DataTable

            dataAdapter.Fill(dataTable)

            DashboardDataGridView.DataSource = dataTable
        Catch ex As SqlException
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub DashboardLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGridView()

        ' DashboardDataGridView.Columns.Remove("ID")

        DashboardDataGridView.Columns.RemoveAt(0)
    End Sub

    Private Sub DeleteButtonClick(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If DeleteNameTextBox.Text IsNot _empty Then
                If MessageBox.Show("Are you sure want to delete your data?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = MsgBoxResult.Ok Then
                    _connect.Open()

                    Dim name As String = DeleteNameTextBox.Text

                    Dim command As New SqlCommand("DELETE FROM UserDatabase.dbo.Information WHERE FirstName='" & name & "'", _connect)

                    command.ExecuteNonQuery()

                    MessageBox.Show("Data Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    _connect.Close()

                    LoadDataInGridView()
                End If
            Else
                MessageBox.Show("Please fill the name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As SqlException
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SearchDataButtonClick(sender As Object, e As EventArgs) Handles SearchDataButton.Click
        Try
            If SearchNameTextBox.Text IsNot _empty Then
                Dim searchName As String = SearchNameTextBox.Text

                ' Search data when user enter the first name
                ' Dim command As New SqlCommand("SELECT * FROM UserDatabase.dbo.Information WHERE FirstName='" & searchName & "'", _connect)

                ' Search data when user enter the first or last name
                ' Dim command As New SqlCommand("SELECT * FROM UserDatabase.dbo.Information WHERE FirstName='" & searchName & "' OR LastName='" & searchName & "'", _connect)

                ' Search data using like operator
                ' Dim command As New SqlCommand("SELECT * FROM UserDatabase.dbo.Information WHERE FirstName LIKE '%" & searchName & "%' OR LastName LIKE '%" & searchName & "%'", _connect)

                ' Search data using concat
                Dim command As New SqlCommand("SELECT * FROM UserDatabase.dbo.Information WHERE CONCAT(FirstName, LastName) LIKE '%" & searchName & "%'", _connect)

                Dim dataAdapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable

                dataAdapter.Fill(dataTable)

                DashboardDataGridView.DataSource = dataTable
            Else
                MessageBox.Show("Please fill the name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As SqlException
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub ClearButtonClick(sender As Object, e As EventArgs) Handles ClearButton.Click
        FirstNameTextBox.Text = String.Empty
        LastNameTextBox.Text = String.Empty
        PhoneTextBox.Text = String.Empty
        EmailTextBox.Text = String.Empty

        SearchNameTextBox.Text = _empty
        DeleteNameTextBox.Text = _empty
    End Sub

    Private Sub PrintButtonClick(sender As Object, e As EventArgs) Handles PrintButton.Click
        Dim printHeight As Integer = DashboardDataGridView.Height
        DashboardDataGridView.Height = DashboardDataGridView.RowCount * DashboardDataGridView.RowTemplate.Height
        _Bitmap = New Bitmap(DashboardDataGridView.Width, DashboardDataGridView.Height)
        DashboardDataGridView.DrawToBitmap(_Bitmap, New Rectangle(0, 0, DashboardDataGridView.Width, DashboardDataGridView.Height))

        PrintPreviewDialogUserData.Document = PrintUserDocument
        PrintPreviewDialogUserData.PrintPreviewControl.Zoom = 1
        PrintPreviewDialogUserData.ShowDialog()

        DashboardDataGridView.Height = printHeight
    End Sub

    Private Sub PrintUserDocumentPrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintUserDocument.PrintPage
        e.Graphics.DrawImage(_Bitmap, 200, 50)

        Dim rectangle = e.PageSettings.PrintableArea

        If DashboardDataGridView.Height - rectangle.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub
End Class