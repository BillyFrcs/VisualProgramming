Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Home
    Private _apple As String
    Private _grapes As String
    Private _lemon As String
    Private _pear As String
    Private _pineApple As String
    Private _strawberry As String

    Private ReadOnly _empty As String = String.Empty

    ' SQL Connection to the database
    Private Const _serverName = "BILLY"
    Private Const _databaseName = "FruitsShop"

    ' Private ReadOnly _SQLConnection As New SqlConnection($"Data Source={_serverName};Initial Catalog={_databaseName};Integrated Security=True")

    Private Sub FruitsTextBoxMouseHover() Handles AppleTextBox.MouseHover, GrapesTextBox.MouseHover, LemonTextBox.MouseHover, PearTextBox.MouseHover, PineappleTextBox.MouseHover, StrawberryTextBox.MouseHover
        FruitsHtmlToolTip.SetToolTip(AppleTextBox, "Number of Apple")
        FruitsHtmlToolTip.SetToolTip(GrapesTextBox, "Number of Grapes")
        FruitsHtmlToolTip.SetToolTip(LemonTextBox, "Number of Lemon")
        FruitsHtmlToolTip.SetToolTip(PearTextBox, "Number of Pear")
        FruitsHtmlToolTip.SetToolTip(PineappleTextBox, "Number of Pineapple")
        FruitsHtmlToolTip.SetToolTip(StrawberryTextBox, "Number of Strawberry")
    End Sub

    Private Sub AddToCartGradientButtonClick(sender As Object, e As EventArgs) Handles AddToCartGradientButton.Click
        InitializeFruits()

        If _apple IsNot _empty Or _grapes IsNot _empty Or _lemon IsNot _empty Or _pear IsNot _empty Or _pineApple IsNot _empty Or _strawberry IsNot _empty Then
            ClearFruits()

            SuccessMessageDialog.Show("Successfully added to cart!", "Success")
        Else
            ErrorMessageDialog.Show("Please order something :)", "Oops...")
        End If
    End Sub

    ''' <summary>
    ''' Initialize fruits variable
    ''' </summary>
    Private Sub InitializeFruits()
        _apple = AppleTextBox.Text
        _grapes = GrapesTextBox.Text
        _lemon = LemonTextBox.Text
        _pear = PearTextBox.Text
        _pineApple = PineappleTextBox.Text
        _strawberry = StrawberryTextBox.Text
    End Sub

    ''' <summary>
    ''' Clear fruits text box
    ''' </summary>
    Private Sub ClearFruits()
        AppleTextBox.Clear()
        GrapesTextBox.Clear()
        LemonTextBox.Clear()
        PearTextBox.Clear()
        PineappleTextBox.Clear()
        StrawberryTextBox.Clear()
    End Sub
End Class