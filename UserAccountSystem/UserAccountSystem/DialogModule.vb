Module DialogModule
    Public Class Debug
        Public Shared ReadOnly Instance As Debug = New Debug

        ''' <summary>
        ''' Debug log for message box
        ''' </summary>
        ''' <param name="message">Message box</param>
        ''' <param name="caption">Caption box</param>
        ''' <returns>MessageBox</returns>
        Public Function Log(message As String, caption As String, Optional ByVal isConfirm As Boolean = False)
            Const information = "Information"

            If caption.Equals(information) And Not isConfirm Then
                Return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf caption.Equals(information) And isConfirm = True Then
                Return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Else
                Return MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Function

        ''' <summary>
        ''' Log mini box
        ''' </summary>
        ''' <param name="message">Message box</param>
        ''' <param name="title">Caption box</param>
        Public Shared Sub LogMiniBox(message As String, title As String)
            If title.Equals("Information") Then
                MsgBox(message, MsgBoxStyle.Information, title)
            Else
                MsgBox(message, MsgBoxStyle.Critical, title)
            End If
        End Sub

        ''' <summary>
        ''' Debug log error for validation
        ''' </summary>
        ''' <param name="textBox">Text box</param>
        ''' <param name="message">Message error</param>
        Public Sub LogError(textBox As TextBox, message As String)
            Dim errorValidate = New SignIn

            errorValidate.GetErrorValidation().SetError(textBox, message)
        End Sub
    End Class
End Module