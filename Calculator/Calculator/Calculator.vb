Public Class Calculator
    Private _firstNumber As Double
    Private _secondNumber As Double
    Private _calculate As Double

    Private _operator As String

    Private Sub DeleteButtonMouseHover() Handles DeleteButton.MouseHover
        DeleteButton.BackColor = Color.IndianRed
    End Sub

    Private Sub DeleteButtonMouseLeave() Handles DeleteButton.MouseLeave
        DeleteButton.BackColor = Color.DarkGray
    End Sub

    Private Sub DeleteButtonTooltipMouseHover() Handles DeleteButton.MouseHover
        DeleteToolTip.SetToolTip(DeleteButton, "Delete")
    End Sub

    Private Sub ShowResultButtonMouseHover() Handles CalculateResultButton.MouseHover
        CalculateResultButton.BackColor = Color.GreenYellow
    End Sub

    Private Sub ShowResultButtonMouseLeave() Handles CalculateResultButton.MouseLeave
        CalculateResultButton.BackColor = Color.DarkGray
    End Sub

    Private Sub ShowResultCalculateButtonMouseHover() Handles CalculateResultButton.MouseHover
        ShowResultToolTip.SetToolTip(CalculateResultButton, "Show Result")
    End Sub

    Private Sub DeleteButtonClick(sender As Object, e As EventArgs) Handles DeleteButton.Click
        DisplayResultLabel.Text = "0"
    End Sub

    ''' <summary>
    ''' Input number and show the value 
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub NumberButton(sender As Object, e As EventArgs) Handles ButtonZero.Click, ButtonTwo.Click, ButtonThree.Click, ButtonSix.Click, ButtonSeven.Click, ButtonOne.Click, ButtonNine.Click, ButtonFour.Click, ButtonFive.Click, ButtonEight.Click, DecimalButton.Click
        Dim button As Button = sender

        If DisplayResultLabel.Text = "0" Then
            DisplayResultLabel.Text = String.Empty

            DisplayResultLabel.Text = button.Text
        ElseIf button.Text = "." Then
            If Not DisplayResultLabel.Text.Contains(".") Then
                DisplayResultLabel.Text += button.Text
            End If
        Else
            DisplayResultLabel.Text += button.Text
        End If
    End Sub

    ''' <summary>
    ''' Operator button
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub OperatorButton(sender As Object, e As EventArgs) Handles ButtonSubtraction.Click, ButtonMultiply.Click, ButtonDivision.Click, ButtonAddition.Click
        Dim button As Button = sender

        _firstNumber = Convert.ToDouble(DisplayResultLabel.Text)
        _operator = button.Text
        DisplayResultLabel.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Input operator to calculate the value
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub CalculateResultButton_Click(sender As Object, e As EventArgs) Handles CalculateResultButton.Click
        _secondNumber = Convert.ToDouble(DisplayResultLabel.Text)

        Select Case _operator
            Case "+"
                _calculate = _firstNumber + _secondNumber
                DisplayResultLabel.Text = Convert.ToString(_calculate)

            Case "-"
                _calculate = _firstNumber - _secondNumber
                DisplayResultLabel.Text = Convert.ToString(_calculate)

            Case "x"
                _calculate = _firstNumber * _secondNumber
                DisplayResultLabel.Text = Convert.ToString(_calculate)

            Case "÷"
                _calculate = _firstNumber / _secondNumber
                DisplayResultLabel.Text = Convert.ToString(_calculate)
        End Select
    End Sub

    ''' <summary>
    ''' Backspace button 
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub BackspaceButtonClick(sender As Object, e As EventArgs) Handles BackspaceButton.Click
        If DisplayResultLabel.Text.Length > 0 Then
            DisplayResultLabel.Text = DisplayResultLabel.Text.Remove(DisplayResultLabel.Text.Length - 1, 1)
        End If

        If DisplayResultLabel.Text = String.Empty Then
            DisplayResultLabel.Text = "0"
        End If
    End Sub
End Class