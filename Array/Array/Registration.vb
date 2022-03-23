Public Class Registration
    Private Sub RegistrationLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ArrList(3, 1) As String

        ArrList(0, 0) = "NIM"
        ArrList(0, 1) = "NAMA"
        ArrList(1, 0) = "JENIS KELAMIN"
        ArrList(1, 1) = "PRODI"
        ArrList(2, 0) = "Laki-Laki"
        ArrList(2, 1) = "Perempuan"
        ArrList(3, 0) = "S1 Informatika"
        ArrList(3, 1) = "S1 Sistem Informasi"

        ListViewRegistration.GridLines = True
        ListViewRegistration.View = View.Details

        For i = 0 To 1
            For j = 0 To 1
                ListViewRegistration.Columns.Add(ArrList(i, j), 100)
            Next j
        Next i

        For i = 2 To 2
            For j = 0 To 1
                ComboBoxGender.Items.Add(ArrList(i, j))
            Next j
        Next i

        For i = 3 To 3
            For j = 0 To 1
                ComboBoxCourses.Items.Add(ArrList(i, j))
            Next j
        Next i
    End Sub

    Private Sub CloseButtonClick(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub AddButtonClick(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim ArrList(3) As String

        ArrList(0) = Val(TextBoxNIM.Text)
        ArrList(1) = TextBoxName.Text
        ArrList(2) = ComboBoxGender.Text
        ArrList(3) = ComboBoxCourses.Text

        Dim ListItem As ListViewItem = New ListViewItem

        ListItem = ListViewRegistration.Items.Add(ArrList(0))
        ListItem.SubItems.Add(ArrList(1))
        ListItem.SubItems.Add(ArrList(2))
        ListItem.SubItems.Add(ArrList(3))

        TextBoxNIM.Text = TextBoxNIM.Text + 1
        TextBoxName.Text = String.Empty
        ComboBoxGender.Text = String.Empty
        ComboBoxCourses.Text = String.Empty
        TextBoxName.Focus()
    End Sub
End Class
