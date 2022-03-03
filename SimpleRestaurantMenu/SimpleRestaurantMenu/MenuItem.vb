Public Class MenuItem
    ' Item price
    Public FriedRicePrice As Integer = 50000
    Public ChipsBurgerPrice As Integer = 45000
    Public CheesePizzaPrice As Integer = 70000
    Public ChickenWingPrice As Integer = 65000
    Public WagyuPrice As Integer = 100000

    ' Payment
    Public TotalPayment As Integer = 0

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
