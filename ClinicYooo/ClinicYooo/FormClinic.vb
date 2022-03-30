Public Class FormClinic
    Private ReadOnly _array(3, 2) As String
    Private ReadOnly _items(3) As String

    Private _ListItem As ListViewItem = New ListViewItem

    Private Sub FormClinicLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        _array(0, 0) = NoRegisterLabel.Text
        _array(0, 1) = NameOfRegisterLabel.Text.Replace(NameOfRegisterLabel.Text, "Name")
        _array(1, 0) = AgeLabel.Text
        _array(1, 1) = GenderLabel.Text

        _array(2, 0) = "Male"
        _array(2, 1) = "Female"
        _array(2, 2) = "Unknown"

        ListViewRegistration.GridLines = True
        ListViewRegistration.View = View.Details

        For i = 0 To 1
            For j = 0 To 1
                ListViewRegistration.Columns.Add(_array(i, j), 142, HorizontalAlignment.Center)
            Next j
        Next i

        For i = 2 To 2
            For j = 0 To 2
                GenderComboBox.Items.Add(_array(i, j))
            Next j
        Next i
    End Sub

    Private Sub RegisterButtonClick(sender As Object, e As EventArgs) Handles RegisterButton.Click
        If NoRegisterTextBox.Text IsNot String.Empty And NameOfRegisterTextBox.Text IsNot String.Empty And AgeTextBox.Text IsNot String.Empty And GenderComboBox.Text IsNot String.Empty Then
            _items(0) = Val(NoRegisterTextBox.Text)
            _items(1) = NameOfRegisterTextBox.Text
            _items(2) = Val(AgeTextBox.Text)
            _items(3) = GenderComboBox.Text

            _ListItem = ListViewRegistration.Items.Add(_items(0))

            _ListItem.SubItems.Add(_items(1))
            _ListItem.SubItems.Add(_items(2))
            _ListItem.SubItems.Add(_items(3))

            NameOfRegisterTextBox.Focus()
        Else
            MsgBox("Please fill the registration form!", MsgBoxStyle.Critical, "Warning")
        End If
    End Sub

    Private Sub ClearButtonClick(sender As Object, e As EventArgs) Handles ClearButton.Click
        NoRegisterTextBox.Text = String.Empty
        NameOfRegisterTextBox.Text = String.Empty
        AgeTextBox.Text = String.Empty
        GenderComboBox.Text = String.Empty
    End Sub

    Private Sub DeleteButtonClick(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim pos As Int32

        For pos = ListViewRegistration.Items.Count - 1 To 0 Step -1
            _ListItem = ListViewRegistration.Items(pos)
            If _ListItem.SubItems(1).Text = NameOfRegisterTextBox.Text Then
                ListViewRegistration.Items.Remove(_ListItem)
            End If
        Next
    End Sub

    Private Sub CloseButtonClick(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim confirmToQuit As MsgBoxResult = MessageBox.Show("Are you sure want to quit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        ' Confirm dialog to delete account
        If confirmToQuit = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub RegisterButtonMouseHover() Handles RegisterButton.MouseHover
        RegisterButton.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub RegisterButtonMouseLeave() Handles RegisterButton.MouseLeave
        RegisterButton.BackColor = Color.White
    End Sub

    Private Sub ClearButtonMouseHover() Handles ClearButton.MouseHover
        ClearButton.BackColor = Color.YellowGreen
    End Sub

    Private Sub ClearButtonMouseLeave() Handles ClearButton.MouseLeave
        ClearButton.BackColor = Color.White
    End Sub

    Private Sub DeleteButtonMouseHover() Handles DeleteButton.MouseHover
        DeleteButton.BackColor = Color.IndianRed
    End Sub

    Private Sub DeleteButtonMouseLeave() Handles DeleteButton.MouseLeave
        DeleteButton.BackColor = Color.White
    End Sub

    Private Sub CloseButtonMouseHover() Handles CloseButton.MouseHover
        CloseButton.BackColor = Color.IndianRed
    End Sub

    Private Sub CloseButtonMouseLeave() Handles CloseButton.MouseLeave
        CloseButton.BackColor = Color.White
    End Sub
End Class
