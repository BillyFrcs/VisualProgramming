Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports FruitsShopSystem.Shop

Public Class Transaction
    Private _email As String

    Private _fruitsList As String
    Private _totalTransactionFruits As Integer
    Private _totalFruits As Integer

    Private _resultPayment As Decimal

    Private ReadOnly _empty As String = String.Empty

    ' Email validation
    Private ReadOnly _regex As New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")

    ' SQL Connection to the database
    Private Const _serverName = "BILLY"
    Private Const _databaseName = "FruitsShop"

    Private ReadOnly _SQLConnection As New SqlConnection($"Data Source={_serverName};Initial Catalog={_databaseName};Integrated Security=True")

    Private Sub TransactionLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        PromoCodeTextBox.Enabled = False

        FruitsComboBox.Enabled = False
        TotalFruitsTextBox.Enabled = False

        Dim fruits As New List(Of String)({"Apple", "Grapes", "Lemon", "Pear", "Pineapple", "Strawberry"})

        For Each fruit As String In fruits
            FruitsListComboBox.Items.Add(fruit)
            FruitsComboBox.Items.Add(fruit)
        Next
    End Sub

    Private Sub SearchEmailCircleButtonClick(sender As Object, e As EventArgs) Handles SearchEmailCircleButton.Click
        InitializeData()

        If _email IsNot _empty Then
            ClearEmail()
        Else
            ErrorMessageDialog.Show("Yoo the search box is still empty!", "Error")
        End If
    End Sub

    ''' <summary>
    ''' Initializes the data.
    ''' </summary>
    Private Sub InitializeData()
        _email = EmailTextBox.Text

        _fruitsList = FruitsListComboBox.Text
        _totalTransactionFruits = Val(TotalTransactionFruitsTextBox.Text)
        _totalFruits = Val(TotalFruitsTextBox.Text)
    End Sub

    ''' <summary>
    ''' Clear the email text box
    ''' </summary>
    Private Sub ClearEmail()
        EmailTextBox.Clear()
    End Sub

    ''' <summary>
    ''' Clear the data text box
    ''' </summary>
    Private Sub ClearData()
        FruitsListComboBox.SelectedIndex = -1
        TotalTransactionFruitsTextBox.Clear()
        PromoCodeTextBox.Clear()
    End Sub

    Private Sub EmailTextBoxMouseHover() Handles EmailTextBox.MouseHover
        EmailHtmlToolTip.SetToolTip(EmailTextBox, "Your Email Address")
    End Sub

    Private Sub ShowToggleSwitchCheckedChanged(sender As Object, e As EventArgs) Handles ShowPromoCodeToggleSwitch.CheckedChanged, ShowUpdateTransactionToggleSwitch.CheckedChanged
        If ShowPromoCodeToggleSwitch.Checked = True Then
            PromoCodeTextBox.Enabled = True
        Else
            PromoCodeTextBox.Enabled = False
        End If

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

            SuccessMessageDialog.Show("Update Successfully", "Success")
        End If
    End Sub

    ''' <summary>
    ''' Calculate the fruits                               
    ''' </summary>
    Private Sub CalculateFruits()
        Dim totalFruits As Integer = Val(TotalFruitsTextBox.Text)

        If FruitsComboBox.SelectedItem = "Apple" Then
            _resultPayment = Fruits.Apple * totalFruits

            TotalPaymentTextBox.Text = _resultPayment.ToString()
            ResultTotalPaymentHtmlLabel.Text = _resultPayment.ToString()
        ElseIf FruitsComboBox.SelectedItem = "Grapes" Then
            _resultPayment = Fruits.Grapes * totalFruits

            TotalPaymentTextBox.Text = _resultPayment
            ResultTotalPaymentHtmlLabel.Text = _resultPayment.ToString()
        ElseIf FruitsComboBox.SelectedItem = "Lemon" Then
            _resultPayment = Fruits.Lemon * totalFruits

            TotalPaymentTextBox.Text = _resultPayment
            ResultTotalPaymentHtmlLabel.Text = _resultPayment.ToString()
        ElseIf FruitsComboBox.SelectedItem = "Pear" Then
            _resultPayment = Fruits.Pear * totalFruits

            TotalPaymentTextBox.Text = _resultPayment
            ResultTotalPaymentHtmlLabel.Text = _resultPayment.ToString()
        ElseIf FruitsComboBox.SelectedItem = "Pineapple" Then
            _resultPayment = Fruits.Pineapple * totalFruits

            TotalPaymentTextBox.Text = _resultPayment
            ResultTotalPaymentHtmlLabel.Text = _resultPayment.ToString()
        ElseIf FruitsComboBox.SelectedItem = "Strawberry" Then
            _resultPayment = Fruits.Strawberry * totalFruits

            TotalPaymentTextBox.Text = _resultPayment
            ResultTotalPaymentHtmlLabel.Text = _resultPayment.ToString()
        End If
    End Sub

    Private Sub PayGradientButtonClick(sender As Object, e As EventArgs) Handles PayGradientButton.Click
        InitializeData()

        If FruitsComboBox.SelectedItem Is Nothing And _totalFruits <= 0 Then
            ErrorMessageDialog.Show("you haven't order anything yet :)", "Error")
        Else
            If _email IsNot _empty Then
                If _regex.IsMatch(_email) Then
                    SuccessMessageDialog.Show("Payment Successfully!", "Success")
                Else
                    ErrorMessageDialog.Show("Invalid Email Address!", "Error")
                End If
            Else
                ErrorMessageDialog.Show("Please enter your email address!", "Error")
            End If
        End If
    End Sub
End Class