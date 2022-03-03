Public Class MenuItem
    ' Item price
    Public FriedRicePrice As Long = 50000
    Public ChipsBurgerPrice As Long = 45000
    Public CheesePizzaPrice As Long = 70000
    Public ChickenWingPrice As Long = 65000
    Public WagyuPrice As Long = 100000

    ' Payment
    Public TotalPayment As Long = 0

    ''' <summary>
    ''' Only for debugging purposes
    ''' </summary>
    ''' <param name="message">String</param>
    ''' <param name="caption">String</param>
    Public Shared Sub MessagePopUp(message As String, caption As String)
        If (caption.Equals("Information") Or caption.Equals("information")) Then
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
