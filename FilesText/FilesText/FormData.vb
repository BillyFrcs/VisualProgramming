Imports System.IO

Public Class FormData
    ' Path to stores the data
    Private ReadOnly Path As String = "C:\Development\VisualProgramming\FilesText\FilesText\Files\Data.txt"
    Private ReadOnly Directory As String = "C:\Development\VisualProgramming\FilesText\FilesText\Files"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create a folder in a specific directory
        My.Computer.FileSystem.CreateDirectory(Directory)

        Dim SaveData As StreamWriter

        ' Create a file in specific path
        SaveData = New StreamWriter(Path, True)

        Const firstName = "Billy "
        Const lastName = "Franscois"

        ' Write into a file
        SaveData.WriteAsync("Name: " & firstName)
        SaveData.WriteLine(lastName)

        MessageBox.Show("Save data successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        SaveData.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim DisplayData As StreamReader

        Dim data As String

        Try
            If File.Exists(Path) Then
                ' Display data form a file
                DisplayData = New StreamReader(Path)

                Do While Not DisplayData.EndOfStream
                    data = data & DisplayData.ReadLine & vbNewLine
                Loop

                MessageBox.Show(data, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please save data before display data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch
            DisplayData.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Not File.Exists(Path) Then
                MessageBox.Show("Cannot found any file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Delete file 
                File.Delete(Path)

                MessageBox.Show("Delete data successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch
            FileClose()
        End Try
    End Sub
End Class
