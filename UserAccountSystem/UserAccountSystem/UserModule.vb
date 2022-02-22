Module UserModule
    Public RealName As String
    Public Username As String
    Public Email As String
    Public Password As String
    Public Language As String
    Public Gender As String

    ' Create new file as user database
    Public Const Path As String = "Database.data"

    ''' <summary>
    ''' Only for debug purposes
    ''' </summary>
    ''' <param name="message">String</param>
    ''' <param name="caption">String</param>
    Public Sub DebugLog(message As String, caption As String)
        If caption.Equals("Information") Then
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Module
