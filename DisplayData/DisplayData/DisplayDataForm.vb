﻿Public Class DisplayDataForm
    Public Property DataName As String
    Public Property DataEmail As String

    Private Sub DisplayDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameLabel.Text = String.Concat($"Name:{DataName}")
        EmailLabel.Text = String.Concat($"Email:{DataEmail}")
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
    End Sub
End Class