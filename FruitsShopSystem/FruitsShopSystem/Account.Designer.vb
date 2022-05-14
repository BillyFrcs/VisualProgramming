<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Account
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Account))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.NameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.UpdateGradientButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.EmailTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ShowPasswordToggleSwitch = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.ConfirmMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.ErrorMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.SuccessMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.NameToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.EmailToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.PasswordToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.Animated = True
        Me.NameTextBox.BorderRadius = 10
        Me.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NameTextBox.DefaultText = ""
        Me.NameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTextBox.IconLeft = CType(resources.GetObject("NameTextBox.IconLeft"), System.Drawing.Image)
        Me.NameTextBox.Location = New System.Drawing.Point(251, 94)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NameTextBox.PlaceholderText = "Name"
        Me.NameTextBox.SelectedText = ""
        Me.NameTextBox.Size = New System.Drawing.Size(294, 36)
        Me.NameTextBox.TabIndex = 31
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(304, 25)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(183, 39)
        Me.Guna2HtmlLabel2.TabIndex = 30
        Me.Guna2HtmlLabel2.Text = "Your Account"
        '
        'UpdateGradientButton
        '
        Me.UpdateGradientButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateGradientButton.Animated = True
        Me.UpdateGradientButton.AutoRoundedCorners = True
        Me.UpdateGradientButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdateGradientButton.BorderRadius = 21
        Me.UpdateGradientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UpdateGradientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UpdateGradientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UpdateGradientButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UpdateGradientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UpdateGradientButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateGradientButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateGradientButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.UpdateGradientButton.ForeColor = System.Drawing.Color.White
        Me.UpdateGradientButton.Image = CType(resources.GetObject("UpdateGradientButton.Image"), System.Drawing.Image)
        Me.UpdateGradientButton.IndicateFocus = True
        Me.UpdateGradientButton.Location = New System.Drawing.Point(251, 303)
        Me.UpdateGradientButton.Name = "UpdateGradientButton"
        Me.UpdateGradientButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.UpdateGradientButton.Size = New System.Drawing.Size(294, 45)
        Me.UpdateGradientButton.TabIndex = 29
        Me.UpdateGradientButton.Text = "Update"
        Me.UpdateGradientButton.UseTransparentBackground = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailTextBox.Animated = True
        Me.EmailTextBox.BorderRadius = 10
        Me.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailTextBox.DefaultText = ""
        Me.EmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.EmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTextBox.IconLeft = CType(resources.GetObject("EmailTextBox.IconLeft"), System.Drawing.Image)
        Me.EmailTextBox.Location = New System.Drawing.Point(251, 155)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailTextBox.PlaceholderText = "Email"
        Me.EmailTextBox.SelectedText = ""
        Me.EmailTextBox.Size = New System.Drawing.Size(294, 36)
        Me.EmailTextBox.TabIndex = 25
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordTextBox.Animated = True
        Me.PasswordTextBox.BorderRadius = 10
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextBox.DefaultText = ""
        Me.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextBox.IconLeft = CType(resources.GetObject("PasswordTextBox.IconLeft"), System.Drawing.Image)
        Me.PasswordTextBox.Location = New System.Drawing.Point(251, 215)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTextBox.PlaceholderText = "Password"
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.Size = New System.Drawing.Size(294, 36)
        Me.PasswordTextBox.TabIndex = 26
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(294, 257)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(98, 19)
        Me.Guna2HtmlLabel3.TabIndex = 28
        Me.Guna2HtmlLabel3.Text = "Show Password"
        '
        'ShowPasswordToggleSwitch
        '
        Me.ShowPasswordToggleSwitch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowPasswordToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowPasswordToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowPasswordToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPasswordToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White
        Me.ShowPasswordToggleSwitch.Location = New System.Drawing.Point(253, 257)
        Me.ShowPasswordToggleSwitch.Name = "ShowPasswordToggleSwitch"
        Me.ShowPasswordToggleSwitch.Size = New System.Drawing.Size(35, 20)
        Me.ShowPasswordToggleSwitch.TabIndex = 27
        Me.ShowPasswordToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPasswordToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPasswordToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPasswordToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White
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
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'NameToolTip
        '
        Me.NameToolTip.AllowLinksHandling = True
        Me.NameToolTip.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'EmailToolTip
        '
        Me.EmailToolTip.AllowLinksHandling = True
        Me.EmailToolTip.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'PasswordToolTip
        '
        Me.PasswordToolTip.AllowLinksHandling = True
        Me.PasswordToolTip.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 411)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.UpdateGradientButton)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.ShowPasswordToggleSwitch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Account"
        Me.Text = "Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents NameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UpdateGradientButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents EmailTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ShowPasswordToggleSwitch As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents ConfirmMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents ErrorMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents SuccessMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents NameToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents EmailToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents PasswordToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
