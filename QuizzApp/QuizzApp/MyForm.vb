Public Class MyForm
    Private ReadOnly _data(10, 10) As String
    Private ReadOnly _input(10) As String

    Private ReadOnly _empty = String.Empty

    ' Calculate the total payment
    Private _consultantPrice As Integer
    Private Const _discount As Integer = 30
    Private _calculateTotalPayment As Integer

    Private _ListItem As ListViewItem = New ListViewItem

    Private Sub CloseButtonClick(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim confirmToQuit As MsgBoxResult = MessageBox.Show("Are you sure want to quit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If (confirmToQuit = MsgBoxResult.Yes) Then
            Close()
        End If
    End Sub

    Private Sub AddButtonClick(sender As Object, e As EventArgs) Handles AddButton.Click
        If NoRegistrationTextBox.Text IsNot _empty And NameRegisterTextBox.Text IsNot _empty And AddressTextBox.Text IsNot _empty And PlaceOfBirthTextBox.Text IsNot _empty And DateOfBirthDateTimePicker.Text IsNot _empty And PriceConsultantTextBox.Text IsNot _empty And ResultConsultantRichTextBox.Text IsNot _empty Then
            SaveData()

            InputData()

            ' ClearRegistrationItems()
        Else
            MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub InputData()
        Dim listItem As ListViewItem = New ListViewItem

        listItem = ListViewRegistration.Items.Add(_input(0))

        listItem.SubItems.Add(_input(1))
        listItem.SubItems.Add(_input(2))
        listItem.SubItems.Add(_input(3))
        listItem.SubItems.Add(_input(4))
        listItem.SubItems.Add(_input(5))

        If (IsNumeric(_input(6))) Then
            listItem.SubItems.Add(Val(_input(6)))
        Else
            MessageBox.Show("Please input a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        listItem.SubItems.Add(_input(7))
        listItem.SubItems.Add(_input(8))
    End Sub

    Private Sub SaveData()
        _input(0) = NoRegistrationTextBox.Text
        _input(1) = NameRegisterTextBox.Text
        _input(2) = AddressTextBox.Text
        _input(3) = PlaceOfBirthTextBox.Text
        _input(4) = DateOfBirthDateTimePicker.Text

        If BPJSYes.Checked Then
            _input(5) = BPJSYes.Text
        ElseIf BPJSNo.Checked Then
            _input(5) = BPJSNo.Text
        Else
            _input(5) = "Unknown"
        End If

        _input(6) = PriceConsultantTextBox.Text
        _input(7) = ResultConsultantRichTextBox.Text
        _input(8) = TotalPaymentTextBox.Text

        NoRegistrationTextBox.Text += 1
    End Sub

    Private Sub MyFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        NoRegistrationTextBox.Text = 1
        NoRegistrationTextBox.Enabled = False

        TotalPaymentTextBox.Text = 0
        TotalPaymentTextBox.Enabled = False

        _data(0, 0) = NoRegistrationLabel.Text
        _data(0, 1) = NameRegisterLabel.Text
        _data(0, 2) = AddressLabel.Text
        _data(0, 3) = PlaceOfBirthLabel.Text
        _data(0, 4) = DateOfBirthLabel.Text
        _data(0, 5) = BPJSLabel.Text
        _data(0, 6) = PriceConsultantLabel.Text
        _data(0, 7) = ResultConsultantLabel.Text
        _data(0, 8) = TotalPaymentLabel.Text

        ListViewRegistration.GridLines = True
        ListViewRegistration.View = View.Details

        For i = 0 To 9
            For j = 0 To 9
                ListViewRegistration.Columns.Add(_data(i, j), 100)
            Next j
        Next i
    End Sub

    Private Sub ClearButtonClick(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim confirmToClear As MsgBoxResult = MessageBox.Show("Are you sure want to clear the form?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If (confirmToClear = MsgBoxResult.Yes) Then
            ClearRegistrationItems()
        End If
    End Sub

    Private Sub ClearRegistrationItems()
        NameRegisterTextBox.Text = String.Empty
        AddressTextBox.Text = String.Empty
        PlaceOfBirthTextBox.Text = String.Empty
        DateOfBirthDateTimePicker.Text = String.Empty

        PriceConsultantTextBox.Text = String.Empty
        ResultConsultantRichTextBox.Text = String.Empty
        TotalPaymentTextBox.Text = String.Empty
    End Sub

    Private Sub SaveButtonClick(sender As Object, e As EventArgs) Handles SaveButton.Click
        If NoRegistrationTextBox.Text IsNot _empty And NameRegisterTextBox.Text IsNot _empty And AddressTextBox.Text IsNot _empty And PlaceOfBirthTextBox.Text IsNot _empty And DateOfBirthDateTimePicker.Text IsNot _empty And PriceConsultantTextBox.Text IsNot _empty And ResultConsultantRichTextBox.Text IsNot _empty And TotalPaymentTextBox.Text IsNot _empty Then
            SaveData()

            InputData()

            ' ClearRegistrationItems()
        Else
            MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CalculateButtonClick(sender As Object, e As EventArgs) Handles CalculateButton.Click
        _consultantPrice = Val(PriceConsultantTextBox.Text)

        If PriceConsultantTextBox.Text IsNot _empty Then
            If BPJSYes.Checked Then
                ' Calculate the discount
                Dim resultDiscount = _consultantPrice * (_discount / 100)

                _calculateTotalPayment = _consultantPrice - resultDiscount

                TotalPaymentTextBox.Text = _calculateTotalPayment
            ElseIf BPJSNo.Checked Then
                TotalPaymentTextBox.Text = _consultantPrice
            Else
                TotalPaymentTextBox.Text = _consultantPrice
            End If
        Else
            MessageBox.Show("Please fill the price consultant field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DeleteButtonClick(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim confirmToDelete As MsgBoxResult = MessageBox.Show("Are you sure want to delete your data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If (confirmToDelete = MsgBoxResult.Yes) Then
            ' Only clear from the last element of list box
            DeleteItems()

            ' Clear all the items
            ' ListViewRegistration.Items.Clear()

            ' NOTE: Just play around with the 2 methods above
        End If
    End Sub

    Private Sub DeleteItems()
        Dim pos As Int32

        ' Use this to delete the last item in the list box (make sure to use the valid "Nama Pendaftar") if it's not it won't work
        For pos = ListViewRegistration.Items.Count - 1 To 0 Step -1
            _ListItem = ListViewRegistration.Items(pos)
            If _ListItem.SubItems(1).Text = NameRegisterTextBox.Text Then
                ListViewRegistration.Items.Remove(_ListItem)
            End If
        Next
    End Sub
End Class
