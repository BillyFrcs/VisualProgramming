Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports FruitsShopSystem.Shop

Public Class Transaction
    Private _fruitsList As String
    Private _totalTransactionFruits As Integer
    Private _totalFruits As Integer

    Private _resultPayment As Decimal

    Private ReadOnly _empty As String = String.Empty

    Private _fruitName As String
    Private _transactionID As String
    Private _timeTransaction As String
    Private _dateTransaction As String

    ' SQL Connection to the database
    Private Const _serverName = "BILLY"
    Private Const _databaseName = "FruitsShop"

    Private ReadOnly _SQLConnection As New SqlConnection($"Data Source={_serverName};Initial Catalog={_databaseName};Integrated Security=True")

    Private Sub TransactionLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        FruitsComboBox.Enabled = False
        TotalFruitsTextBox.Enabled = False

        Dim fruits As New List(Of String)({"Apple", "Grapes", "Lemon", "Pear", "Pineapple", "Strawberry"})

        For Each fruit As String In fruits
            FruitsListComboBox.Items.Add(fruit)
            FruitsComboBox.Items.Add(fruit)
        Next
    End Sub

    ''' <summary>
    ''' Initializes the data.
    ''' </summary>
    Private Sub InitializeData()
        _fruitsList = FruitsListComboBox.Text
        _totalTransactionFruits = Val(TotalTransactionFruitsTextBox.Text)
        _totalFruits = Val(TotalFruitsTextBox.Text)
        _fruitName = FruitsComboBox.Text
    End Sub

    ''' <summary>
    ''' Clear the data text box
    ''' </summary>
    Private Sub ClearData()
        FruitsListComboBox.SelectedIndex = -1
        TotalTransactionFruitsTextBox.Clear()
    End Sub

    Private Sub ClearUpdateData()
        FruitsComboBox.SelectedIndex = -1
        TotalFruitsTextBox.Text = _empty
    End Sub

    Private Sub ShowToggleSwitchCheckedChanged(sender As Object, e As EventArgs) Handles ShowUpdateTransactionToggleSwitch.CheckedChanged
        If ShowUpdateTransactionToggleSwitch.Checked = True Then
            FruitsComboBox.Enabled = True
            TotalFruitsTextBox.Enabled = True
        Else
            FruitsComboBox.Enabled = False
            TotalFruitsTextBox.Enabled = False
        End If
    End Sub

    Private Sub ClearGradientButtonClick(sender As Object, e As EventArgs) Handles ClearGradientButton.Click
        Call ClearData()
        Call ClearUpdateData()
    End Sub

    Private Sub AddToCartGradientButtonClick(sender As Object, e As EventArgs) Handles AddToCartGradientButton.Click
        InitializeData()

        If FruitsListComboBox.SelectedItem Is Nothing And _totalTransactionFruits <= 0 Then
            ErrorMessageDialog.Show("Please order something :)", "Error")
        Else
            FruitsComboBox.SelectedItem = _fruitsList
            TotalFruitsTextBox.Text = _totalTransactionFruits

            CalculateFruits()

            ClearData()

            SuccessMessageDialog.Show("Successfully added to Cart!", "Success")
        End If
    End Sub

    Private Sub UpdateTransactionGradientButtonClick(sender As Object, e As EventArgs) Handles UpdateTransactionGradientButton.Click
        InitializeData()

        If FruitsComboBox.SelectedItem Is Nothing And _totalFruits <= 0 Then
            ErrorMessageDialog.Show("Your cart is still empty!", "Error")
        Else
            FruitsComboBox.SelectedItem = FruitsComboBox.Text
            TotalFruitsTextBox.Text = Val(TotalFruitsTextBox.Text)

            CalculateFruits()

            ClearUpdateData()

            SuccessMessageDialog.Show("Update Successfully", "Success")
        End If
    End Sub

    ''' <summary>
    ''' Calculate the total fruits                               
    ''' </summary>
    Private Sub CalculateFruits()
        Dim totalFruits As Integer = Val(TotalFruitsTextBox.Text)

        Const style = "STANDARD"

        Select Case FruitsComboBox.Text
            Case "Apple"
                _resultPayment = Fruits.Apple * totalFruits

                TotalPaymentTextBox.Text = Format(_resultPayment.ToString(), style)
                ResultTotalPaymentHtmlLabel.Text = Format(_resultPayment.ToString(), style)

            Case "Grapes"
                _resultPayment = Fruits.Grapes * totalFruits

                TotalPaymentTextBox.Text = Format(_resultPayment.ToString(), style)
                ResultTotalPaymentHtmlLabel.Text = Format(_resultPayment.ToString(), style)

            Case "Lemon"
                _resultPayment = Fruits.Lemon * totalFruits

                TotalPaymentTextBox.Text = Format(_resultPayment.ToString(), style)
                ResultTotalPaymentHtmlLabel.Text = Format(_resultPayment.ToString(), style)

            Case "Pear"
                _resultPayment = Fruits.Pear * totalFruits

                TotalPaymentTextBox.Text = Format(_resultPayment.ToString(), style)
                ResultTotalPaymentHtmlLabel.Text = Format(_resultPayment.ToString(), style)

            Case "Pineapple"
                _resultPayment = Fruits.Pineapple * totalFruits

                TotalPaymentTextBox.Text = Format(_resultPayment.ToString(), style)
                ResultTotalPaymentHtmlLabel.Text = Format(_resultPayment.ToString(), style)

            Case "Strawberry"
                _resultPayment = Fruits.Strawberry * totalFruits

                TotalPaymentTextBox.Text = Format(_resultPayment.ToString(), style)
                ResultTotalPaymentHtmlLabel.Text = Format(_resultPayment.ToString(), style)
        End Select
    End Sub

    Private Sub PayGradientButtonClick(sender As Object, e As EventArgs) Handles PayGradientButton.Click
        Call InitializeData()

        If FruitsComboBox.SelectedItem Is Nothing And _totalFruits <= 0 Then
            ErrorMessageDialog.Show("You haven't order anything yet :)", "Error")
        Else
            SaveUserTransaction()

            Dim historyTransaction As New History()

            historyTransaction.UpdateDataTransaction()

            UserDashboard.Dashboard.GetBalance(_resultPayment)    

            SuccessMessageDialog.Show("Thanks for Paying :D", "Success")
        End If
    End Sub

    ''' <summary>
    ''' Auto generate the transaction from the server
    ''' </summary>
    Private Sub InitializeToServer()
        _transactionID = GetUniqueID(10)
        _timeTransaction = TimeOfDay.ToString("h:mm:ss tt")
        _dateTransaction = String.Format("{0:dd/MM/yyyy}", Date.Now)
    End Sub

    Private Sub SaveUserTransaction()
        Call InitializeData()
        Call InitializeToServer()

        Try
            _SQLConnection.Open()

            Dim updateQuery = $"INSERT INTO {_databaseName}.dbo.[Transaction] ([Transaction_ID], [Fruit_Name], [Total_Fruits], [Time_Transaction], [Date_Transaction], [Total_Price]) VALUES ('" & _transactionID & "', '" & _fruitName & "', '" & _totalFruits & "', '" & _timeTransaction & "', '" & _dateTransaction & "', '" & _resultPayment & "')"

            Using SQLCommand As New SqlCommand()
                With SQLCommand
                    .Connection = _SQLConnection
                    .CommandType = CommandType.Text
                    .CommandText = updateQuery

                    .Parameters.AddWithValue("@Transaction_ID", _transactionID)
                    .Parameters.AddWithValue("@Fruit_Name", _fruitName)
                    .Parameters.AddWithValue("@Total_Fruits", _totalFruits)
                    .Parameters.AddWithValue("@Time_Transaction", _timeTransaction)
                    .Parameters.AddWithValue("@Date_Transaction", _dateTransaction)
                    .Parameters.AddWithValue("@Total_Price", _resultPayment)

                    .ExecuteNonQuery()
                End With

                _SQLConnection.Close()
            End Using
        Catch ex As SqlException
            ErrorMessageDialog.Show(ex.Message(), "Error")
        End Try
    End Sub

    ''' <summary>
    ''' Get the unique ID
    ''' </summary>
    ''' <param name="maxSize">Max siz (Integer)</param>
    ''' <returns></returns>
    Private Function GetUniqueID(ByVal maxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}

        chars = "123456789".ToCharArray()

        Dim data As Byte() = New Byte(0) {}

        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)

        data = New Byte(maxSize - 1) {}
        crypto.GetNonZeroBytes(data)

        Dim result As New StringBuilder(maxSize)

        For Each value As Byte In data
            result.Append(chars(value Mod (chars.Length)))
        Next

        Return result.ToString()
    End Function
End Class