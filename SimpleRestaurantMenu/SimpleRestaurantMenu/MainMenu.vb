Public Class MainMenu
    ' Price text box items
    Private _FriedRiceAmount As Long
    Private _ChipsBurgerAmount As Long
    Private _CheesePizzaAmount As Long
    Private _ChickenWingAmount As Long
    Private _WagyuAmount As Long

    Private Const ZERO = 0

    Private _MenuItem As MenuItem = New MenuItem

    Private Sub CalculateButtonClick(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If sender.name.ToString.Contains("CalculateButton") = True Then
            CalculateMenuItem()
        End If
    End Sub

    ''' <summary>
    ''' Calculate items
    ''' </summary>
    Private Sub CalculateMenuItem()
        InitMenuItem()

        If (_FriedRiceAmount > ZERO) Or (_ChipsBurgerAmount > ZERO) Or (_CheesePizzaAmount > ZERO) Or (_ChickenWingAmount > ZERO) Or (_WagyuAmount > ZERO) Then
            ' Calculate total menu
            _MenuItem.TotalPayment = _MenuItem.FriedRicePrice + _MenuItem.ChipsBurgerPrice + _MenuItem.CheesePizzaPrice + _MenuItem.ChickenWingPrice + _MenuItem.WagyuPrice

            ' Display the total payment with standard format number 
            TotalPaymentLabel.Text = String.Concat($"Total Payment: Rp {Strings.Format(_MenuItem.TotalPayment.ToString(), "STANDARD")}")
        Else
            MenuItem.MessagePopUp("Please order a food!", "Warning")
        End If
    End Sub

    ''' <summary>
    ''' Initialize items
    ''' </summary>
    Private Sub InitMenuItem()
        ' Initialize to handle text box items
        _FriedRiceAmount = Val(FriedRiceAmountTextBox.Text)
        _ChipsBurgerAmount = Val(ChipsBurgerAmountTextBox.Text)
        _CheesePizzaAmount = Val(CheesePizzaAmountTextBox.Text)
        _ChickenWingAmount = Val(ChickenWingAmountTextBox.Text)
        _WagyuAmount = Val(WagyuAmountTextBox.Text)

        ' Initialize to calculate total payment
        _MenuItem.FriedRicePrice *= _FriedRiceAmount
        _MenuItem.ChipsBurgerPrice *= _ChipsBurgerAmount
        _MenuItem.CheesePizzaPrice *= _CheesePizzaAmount
        _MenuItem.ChickenWingPrice *= _ChickenWingAmount
        _MenuItem.WagyuPrice *= _WagyuAmount
    End Sub

    Private Sub MainMenuLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        FriedRiceAmountTextBox.Enabled = False
        ChipsBurgerAmountTextBox.Enabled = False
        CheesePizzaAmountTextBox.Enabled = False
        ChickenWingAmountTextBox.Enabled = False
        WagyuAmountTextBox.Enabled = False
    End Sub

    Private Sub CalculateButtonMouseHover() Handles CalculateButton.MouseHover
        CalculateButton.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub CalculateButtonMouseLeave() Handles CalculateButton.MouseLeave
        CalculateButton.BackColor = Color.White
    End Sub

    Private Sub ResetButtonMouseHover() Handles ResetButton.MouseHover
        ResetButton.BackColor = Color.YellowGreen
    End Sub

    Private Sub ResetButtonMouseLeave() Handles ResetButton.MouseLeave
        ResetButton.BackColor = Color.White
    End Sub

    Private Sub ExitButtonMouseHover() Handles ExitButton.MouseHover
        ExitButton.BackColor = Color.IndianRed
    End Sub

    Private Sub ExitButtonMouseLeave() Handles ExitButton.MouseLeave
        ExitButton.BackColor = Color.White
    End Sub

    Private Sub ShowButtonMouseHover() Handles ShowButton.MouseHover
        ShowButton.BackColor = Color.BlueViolet
    End Sub

    Private Sub ShowButtonMouseLeave() Handles ShowButton.MouseLeave
        ShowButton.BackColor = Color.White
    End Sub

    Private Sub FriedRiceTextBoxMouseHover() Handles FriedRiceAmountTextBox.MouseHover
        FriedRiceToolTip.SetToolTip(FriedRiceAmountTextBox, "Amount Of Fried Rice")
    End Sub

    Private Sub ChipsBurgerTextBoxMouseHover() Handles ChipsBurgerAmountTextBox.MouseHover
        ChipsBurgerTooltip.SetToolTip(ChipsBurgerAmountTextBox, "Amount Of Chips Burger")
    End Sub

    Private Sub CheesePizzaTextBoxMouseHover() Handles CheesePizzaAmountTextBox.MouseHover
        CheesePizzaToolTip.SetToolTip(CheesePizzaAmountTextBox, "Amount Of Cheese Burger")
    End Sub

    Private Sub ChickenWingTextBoxMouseHover() Handles ChickenWingAmountTextBox.MouseHover
        ChickenWingToolTip.SetToolTip(ChickenWingAmountTextBox, "Amount Of Chicken Wing")
    End Sub

    Private Sub WagyuTextBoxMouseHover() Handles WagyuAmountTextBox.MouseHover
        WagyuToolTip.SetToolTip(WagyuAmountTextBox, "Amount Of Wagyu")
    End Sub

    Private Sub FriedRiceCheckBoxCheckedChanged(sender As Object, e As EventArgs) Handles FriedRiceCheckBox.CheckedChanged
        If FriedRiceCheckBox.Checked = vbTrue Then
            FriedRiceAmountTextBox.Enabled = True
        Else
            FriedRiceAmountTextBox.Enabled = False
        End If
    End Sub

    Private Sub ChipsBurgerCheckBoxCheckedChanged(sender As Object, e As EventArgs) Handles ChipsBurgerCheckBox.CheckedChanged
        If ChipsBurgerCheckBox.Checked = vbTrue Then
            ChipsBurgerAmountTextBox.Enabled = True
        Else
            ChipsBurgerAmountTextBox.Enabled = False
        End If
    End Sub

    Private Sub CheesePizzaCheckBoxCheckedChanged(sender As Object, e As EventArgs) Handles CheesePizzaCheckBox.CheckedChanged
        If CheesePizzaCheckBox.Checked = vbTrue Then
            CheesePizzaAmountTextBox.Enabled = True
        Else
            CheesePizzaAmountTextBox.Enabled = False
        End If
    End Sub

    Private Sub ChickenWingCheckBoxCheckedChanged(sender As Object, e As EventArgs) Handles ChickenWingCheckBox.CheckedChanged
        If ChickenWingCheckBox.Checked = vbTrue Then
            ChickenWingAmountTextBox.Enabled = True
        Else
            ChickenWingAmountTextBox.Enabled = False
        End If
    End Sub

    Private Sub WagyuCheckBoxCheckedChanged(sender As Object, e As EventArgs) Handles WagyuCheckBox.CheckedChanged
        If WagyuCheckBox.Checked = vbTrue Then
            WagyuAmountTextBox.Enabled = True
        Else
            WagyuAmountTextBox.Enabled = False
        End If
    End Sub

    Private Sub ResetButtonClick(sender As Object, e As EventArgs) Handles ResetButton.Click
        If (_FriedRiceAmount > ZERO) Or (_ChipsBurgerAmount > ZERO) Or (_CheesePizzaAmount > ZERO) Or (_ChickenWingAmount > ZERO) Or (_WagyuAmount > ZERO) Then
            ResetItems()
        Else
            MenuItem.MessagePopUp("Please order a food!", "Warning")
        End If
    End Sub

    Private Sub ResetItems()
        ' Items text box
        FriedRiceAmountTextBox.Clear()
        ChipsBurgerAmountTextBox.Clear()
        CheesePizzaAmountTextBox.Clear()
        ChickenWingAmountTextBox.Clear()
        WagyuAmountTextBox.Clear()

        ' Items check box
        FriedRiceCheckBox.Checked = False
        ChipsBurgerCheckBox.Checked = False
        CheesePizzaCheckBox.Checked = False
        ChickenWingCheckBox.Checked = False
        WagyuCheckBox.Checked = False

        ' Order recap
        OrderListBox.Items.Clear()
        ShowButtonMenu = True

        ' Total payment
        TotalPaymentLabel.Text = String.Concat($"Total Payment: Rp")
        _MenuItem.TotalPayment = ZERO
        _MenuItem.FriedRicePrice = ZERO
        _MenuItem.ChipsBurgerPrice = ZERO
        _MenuItem.CheesePizzaPrice = ZERO
        _MenuItem.ChickenWingPrice = ZERO
        _MenuItem.WagyuPrice = ZERO

        _FriedRiceAmount = ZERO
        _ChipsBurgerAmount = ZERO
        _CheesePizzaAmount = ZERO
        _ChickenWingAmount = ZERO
        _WagyuAmount = ZERO
    End Sub

    Private Sub ExitButtonClick(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim confirmToQuit As MsgBoxResult = MessageBox.Show("Are you sure want to quit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        ' Confirm dialog to delete account
        If confirmToQuit = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub ShowOrderFoodButtonClick() Handles ShowButton.Click
        InitMenuItem()

        If (_FriedRiceAmount > ZERO) Or (_ChipsBurgerAmount > ZERO) Or (_CheesePizzaAmount > ZERO) Or (_ChickenWingAmount > ZERO) Or (_WagyuAmount > ZERO) Then
            If FriedRiceCheckBox.Checked = True Then
                ShowButtonMenu = False

                OrderListBox.Items.Add(String.Concat($"{FriedRiceCheckBox.Text} {FriedRiceAmountTextBox.Text} {vbCrLf}"))
            End If

            If ChipsBurgerCheckBox.Checked = True Then
                ShowButtonMenu = False

                OrderListBox.Items.Add(String.Concat($"{ChipsBurgerCheckBox.Text} {ChipsBurgerAmountTextBox.Text} {vbCrLf}"))
            End If

            If CheesePizzaCheckBox.Checked = True Then
                ShowButtonMenu = False

                OrderListBox.Items.Add(String.Concat($"{CheesePizzaCheckBox.Text} {CheesePizzaAmountTextBox.Text} {vbCrLf}"))
            End If

            If ChickenWingCheckBox.Checked = True Then
                ShowButtonMenu = False

                OrderListBox.Items.Add(String.Concat($"{ChickenWingCheckBox.Text} {ChickenWingAmountTextBox.Text} {vbCrLf}"))
            End If

            If WagyuCheckBox.Checked = True Then
                ShowButtonMenu = False

                OrderListBox.Items.Add(String.Concat($"{WagyuCheckBox.Text} {WagyuAmountTextBox.Text} {vbCrLf}"))
            End If
        Else
            MenuItem.MessagePopUp("Please order a food!", "Warning")
        End If
    End Sub

    ''' <summary>
    ''' Get show button component
    ''' </summary>
    ''' <returns>ShowButton.Enabled</returns>
    Private Property ShowButtonMenu() As Boolean
        Get
            Return ShowButton.Enabled
        End Get

        Set(value As Boolean)
            ShowButton.Enabled = value
        End Set
    End Property
End Class
