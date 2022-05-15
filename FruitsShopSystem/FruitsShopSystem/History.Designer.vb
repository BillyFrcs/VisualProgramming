<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.ConfirmMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.ErrorMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.SuccessMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.FruitsHtmlToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.SuspendLayout()
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'ConfirmMessageDialog
        '
        Me.ConfirmMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo
        Me.ConfirmMessageDialog.Caption = Nothing
        Me.ConfirmMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question
        Me.ConfirmMessageDialog.Parent = Nothing
        Me.ConfirmMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.ConfirmMessageDialog.Text = Nothing
        '
        'ErrorMessageDialog
        '
        Me.ErrorMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.ErrorMessageDialog.Caption = ""
        Me.ErrorMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.[Error]
        Me.ErrorMessageDialog.Parent = Nothing
        Me.ErrorMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.ErrorMessageDialog.Text = ""
        '
        'SuccessMessageDialog
        '
        Me.SuccessMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.SuccessMessageDialog.Caption = Nothing
        Me.SuccessMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        Me.SuccessMessageDialog.Parent = Nothing
        Me.SuccessMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.SuccessMessageDialog.Text = Nothing
        '
        'FruitsHtmlToolTip
        '
        Me.FruitsHtmlToolTip.AllowLinksHandling = True
        Me.FruitsHtmlToolTip.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 466)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "History"
        Me.Text = "History"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents ConfirmMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents ErrorMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents SuccessMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents FruitsHtmlToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
