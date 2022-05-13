<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserAccount
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAccount))
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.EmailLoginTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordLoginTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ShowPasswordLoginToggleSwitch = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.ShowPasswordGuna2HtmlLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LoginGradientButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.CreateAccounButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.BackgroundGuna2PictureBox = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.LoginShadowPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.RegisterShadowPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LoginCursorLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.RegisterGradientButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.EmailRegisterTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordRegisterTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ShowPasswordRegisterToggleSwitch = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.TransitionUserAccountPage = New Guna.UI2.WinForms.Guna2Transition()
        Me.ExitGradientButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ErrorMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.SuccessMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.ConfirmMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.NameToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.EmailToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.PasswordToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        CType(Me.BackgroundGuna2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginShadowPanel.SuspendLayout()
        Me.RegisterShadowPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.BorderRadius = 20
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'EmailLoginTextBox
        '
        Me.EmailLoginTextBox.Animated = True
        Me.EmailLoginTextBox.BorderRadius = 10
        Me.EmailLoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TransitionUserAccountPage.SetDecoration(Me.EmailLoginTextBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.EmailLoginTextBox.DefaultText = ""
        Me.EmailLoginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EmailLoginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EmailLoginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailLoginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailLoginTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.EmailLoginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailLoginTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EmailLoginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailLoginTextBox.IconLeft = CType(resources.GetObject("EmailLoginTextBox.IconLeft"), System.Drawing.Image)
        Me.EmailLoginTextBox.Location = New System.Drawing.Point(27, 86)
        Me.EmailLoginTextBox.Name = "EmailLoginTextBox"
        Me.EmailLoginTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailLoginTextBox.PlaceholderText = "Email"
        Me.EmailLoginTextBox.SelectedText = ""
        Me.EmailLoginTextBox.Size = New System.Drawing.Size(262, 36)
        Me.EmailLoginTextBox.TabIndex = 1
        '
        'PasswordLoginTextBox
        '
        Me.PasswordLoginTextBox.Animated = True
        Me.PasswordLoginTextBox.BorderRadius = 10
        Me.PasswordLoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TransitionUserAccountPage.SetDecoration(Me.PasswordLoginTextBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PasswordLoginTextBox.DefaultText = ""
        Me.PasswordLoginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordLoginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordLoginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordLoginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordLoginTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PasswordLoginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordLoginTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordLoginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordLoginTextBox.IconLeft = CType(resources.GetObject("PasswordLoginTextBox.IconLeft"), System.Drawing.Image)
        Me.PasswordLoginTextBox.Location = New System.Drawing.Point(27, 147)
        Me.PasswordLoginTextBox.Name = "PasswordLoginTextBox"
        Me.PasswordLoginTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordLoginTextBox.PlaceholderText = "Password"
        Me.PasswordLoginTextBox.SelectedText = ""
        Me.PasswordLoginTextBox.Size = New System.Drawing.Size(262, 36)
        Me.PasswordLoginTextBox.TabIndex = 2
        '
        'ShowPasswordLoginToggleSwitch
        '
        Me.ShowPasswordLoginToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ShowPasswordLoginToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ShowPasswordLoginToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPasswordLoginToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White
        Me.TransitionUserAccountPage.SetDecoration(Me.ShowPasswordLoginToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowPasswordLoginToggleSwitch.Location = New System.Drawing.Point(27, 201)
        Me.ShowPasswordLoginToggleSwitch.Name = "ShowPasswordLoginToggleSwitch"
        Me.ShowPasswordLoginToggleSwitch.Size = New System.Drawing.Size(35, 20)
        Me.ShowPasswordLoginToggleSwitch.TabIndex = 3
        Me.ShowPasswordLoginToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPasswordLoginToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPasswordLoginToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPasswordLoginToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'ShowPasswordGuna2HtmlLabel
        '
        Me.ShowPasswordGuna2HtmlLabel.BackColor = System.Drawing.Color.Transparent
        Me.TransitionUserAccountPage.SetDecoration(Me.ShowPasswordGuna2HtmlLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowPasswordGuna2HtmlLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPasswordGuna2HtmlLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ShowPasswordGuna2HtmlLabel.Location = New System.Drawing.Point(68, 201)
        Me.ShowPasswordGuna2HtmlLabel.Name = "ShowPasswordGuna2HtmlLabel"
        Me.ShowPasswordGuna2HtmlLabel.Size = New System.Drawing.Size(98, 19)
        Me.ShowPasswordGuna2HtmlLabel.TabIndex = 5
        Me.ShowPasswordGuna2HtmlLabel.Text = "Show Password"
        '
        'LoginGradientButton
        '
        Me.LoginGradientButton.Animated = True
        Me.LoginGradientButton.AutoRoundedCorners = True
        Me.LoginGradientButton.BackColor = System.Drawing.Color.Transparent
        Me.LoginGradientButton.BorderRadius = 21
        Me.TransitionUserAccountPage.SetDecoration(Me.LoginGradientButton, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoginGradientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginGradientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginGradientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginGradientButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginGradientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginGradientButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LoginGradientButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LoginGradientButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LoginGradientButton.ForeColor = System.Drawing.Color.White
        Me.LoginGradientButton.IndicateFocus = True
        Me.LoginGradientButton.Location = New System.Drawing.Point(27, 249)
        Me.LoginGradientButton.Name = "LoginGradientButton"
        Me.LoginGradientButton.Size = New System.Drawing.Size(262, 45)
        Me.LoginGradientButton.TabIndex = 6
        Me.LoginGradientButton.Text = "Login"
        Me.LoginGradientButton.UseTransparentBackground = True
        '
        'CreateAccounButton
        '
        Me.CreateAccounButton.Animated = True
        Me.CreateAccounButton.AutoRoundedCorners = True
        Me.CreateAccounButton.BackColor = System.Drawing.Color.Transparent
        Me.CreateAccounButton.BorderRadius = 21
        Me.TransitionUserAccountPage.SetDecoration(Me.CreateAccounButton, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CreateAccounButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CreateAccounButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CreateAccounButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CreateAccounButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CreateAccounButton.FillColor = System.Drawing.Color.Transparent
        Me.CreateAccounButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CreateAccounButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CreateAccounButton.Image = CType(resources.GetObject("CreateAccounButton.Image"), System.Drawing.Image)
        Me.CreateAccounButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CreateAccounButton.IndicateFocus = True
        Me.CreateAccounButton.Location = New System.Drawing.Point(27, 329)
        Me.CreateAccounButton.Name = "CreateAccounButton"
        Me.CreateAccounButton.Size = New System.Drawing.Size(262, 45)
        Me.CreateAccounButton.TabIndex = 7
        Me.CreateAccounButton.Text = "Create an Account"
        Me.CreateAccounButton.UseTransparentBackground = True
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.TransitionUserAccountPage.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(59, 17)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(193, 39)
        Me.Guna2HtmlLabel1.TabIndex = 8
        Me.Guna2HtmlLabel1.Text = "Login Account"
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'BackgroundGuna2PictureBox
        '
        Me.BackgroundGuna2PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundGuna2PictureBox.BorderRadius = 5
        Me.TransitionUserAccountPage.SetDecoration(Me.BackgroundGuna2PictureBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BackgroundGuna2PictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.BackgroundGuna2PictureBox.Image = CType(resources.GetObject("BackgroundGuna2PictureBox.Image"), System.Drawing.Image)
        Me.BackgroundGuna2PictureBox.ImageRotate = 0!
        Me.BackgroundGuna2PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.BackgroundGuna2PictureBox.Name = "BackgroundGuna2PictureBox"
        Me.BackgroundGuna2PictureBox.Size = New System.Drawing.Size(250, 500)
        Me.BackgroundGuna2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackgroundGuna2PictureBox.TabIndex = 9
        Me.BackgroundGuna2PictureBox.TabStop = False
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TransitionUserAccountPage.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(662, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(26, 24)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.TransitionUserAccountPage.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(630, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(26, 24)
        Me.Guna2ControlBox2.TabIndex = 10
        '
        'LoginShadowPanel
        '
        Me.LoginShadowPanel.BackColor = System.Drawing.Color.Transparent
        Me.LoginShadowPanel.Controls.Add(Me.Guna2HtmlLabel1)
        Me.LoginShadowPanel.Controls.Add(Me.RegisterShadowPanel)
        Me.LoginShadowPanel.Controls.Add(Me.LoginGradientButton)
        Me.LoginShadowPanel.Controls.Add(Me.EmailLoginTextBox)
        Me.LoginShadowPanel.Controls.Add(Me.CreateAccounButton)
        Me.LoginShadowPanel.Controls.Add(Me.PasswordLoginTextBox)
        Me.LoginShadowPanel.Controls.Add(Me.ShowPasswordGuna2HtmlLabel)
        Me.LoginShadowPanel.Controls.Add(Me.ShowPasswordLoginToggleSwitch)
        Me.TransitionUserAccountPage.SetDecoration(Me.LoginShadowPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoginShadowPanel.FillColor = System.Drawing.Color.White
        Me.LoginShadowPanel.Location = New System.Drawing.Point(327, 42)
        Me.LoginShadowPanel.Name = "LoginShadowPanel"
        Me.LoginShadowPanel.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.LoginShadowPanel.ShadowDepth = 10
        Me.LoginShadowPanel.ShadowShift = 10
        Me.LoginShadowPanel.Size = New System.Drawing.Size(316, 403)
        Me.LoginShadowPanel.TabIndex = 11
        '
        'RegisterShadowPanel
        '
        Me.RegisterShadowPanel.BackColor = System.Drawing.Color.Transparent
        Me.RegisterShadowPanel.Controls.Add(Me.Guna2HtmlLabel4)
        Me.RegisterShadowPanel.Controls.Add(Me.LoginCursorLabel)
        Me.RegisterShadowPanel.Controls.Add(Me.NameTextBox)
        Me.RegisterShadowPanel.Controls.Add(Me.Guna2HtmlLabel2)
        Me.RegisterShadowPanel.Controls.Add(Me.RegisterGradientButton)
        Me.RegisterShadowPanel.Controls.Add(Me.EmailRegisterTextBox)
        Me.RegisterShadowPanel.Controls.Add(Me.PasswordRegisterTextBox)
        Me.RegisterShadowPanel.Controls.Add(Me.Guna2HtmlLabel3)
        Me.RegisterShadowPanel.Controls.Add(Me.ShowPasswordRegisterToggleSwitch)
        Me.TransitionUserAccountPage.SetDecoration(Me.RegisterShadowPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.RegisterShadowPanel.FillColor = System.Drawing.Color.White
        Me.RegisterShadowPanel.Location = New System.Drawing.Point(0, 0)
        Me.RegisterShadowPanel.Name = "RegisterShadowPanel"
        Me.RegisterShadowPanel.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.RegisterShadowPanel.ShadowDepth = 10
        Me.RegisterShadowPanel.ShadowShift = 10
        Me.RegisterShadowPanel.Size = New System.Drawing.Size(316, 403)
        Me.RegisterShadowPanel.TabIndex = 11
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.TransitionUserAccountPage.SetDecoration(Me.Guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(115, 359)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(138, 15)
        Me.Guna2HtmlLabel4.TabIndex = 12
        Me.Guna2HtmlLabel4.Text = "Already have an Account?"
        '
        'LoginCursorLabel
        '
        Me.LoginCursorLabel.AutoSize = True
        Me.LoginCursorLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransitionUserAccountPage.SetDecoration(Me.LoginCursorLabel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoginCursorLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginCursorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LoginCursorLabel.Location = New System.Drawing.Point(250, 357)
        Me.LoginCursorLabel.Name = "LoginCursorLabel"
        Me.LoginCursorLabel.Size = New System.Drawing.Size(43, 17)
        Me.LoginCursorLabel.TabIndex = 11
        Me.LoginCursorLabel.Text = "Login"
        '
        'NameTextBox
        '
        Me.NameTextBox.Animated = True
        Me.NameTextBox.BorderRadius = 10
        Me.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TransitionUserAccountPage.SetDecoration(Me.NameTextBox, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.NameTextBox.Location = New System.Drawing.Point(29, 86)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NameTextBox.PlaceholderText = "Name"
        Me.NameTextBox.SelectedText = ""
        Me.NameTextBox.Size = New System.Drawing.Size(262, 36)
        Me.NameTextBox.TabIndex = 10
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.TransitionUserAccountPage.SetDecoration(Me.Guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(59, 17)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(204, 39)
        Me.Guna2HtmlLabel2.TabIndex = 8
        Me.Guna2HtmlLabel2.Text = "Create Account"
        '
        'RegisterGradientButton
        '
        Me.RegisterGradientButton.Animated = True
        Me.RegisterGradientButton.AutoRoundedCorners = True
        Me.RegisterGradientButton.BackColor = System.Drawing.Color.Transparent
        Me.RegisterGradientButton.BorderRadius = 21
        Me.TransitionUserAccountPage.SetDecoration(Me.RegisterGradientButton, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.RegisterGradientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RegisterGradientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RegisterGradientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RegisterGradientButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RegisterGradientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RegisterGradientButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RegisterGradientButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RegisterGradientButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RegisterGradientButton.ForeColor = System.Drawing.Color.White
        Me.RegisterGradientButton.IndicateFocus = True
        Me.RegisterGradientButton.Location = New System.Drawing.Point(29, 300)
        Me.RegisterGradientButton.Name = "RegisterGradientButton"
        Me.RegisterGradientButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.RegisterGradientButton.Size = New System.Drawing.Size(262, 45)
        Me.RegisterGradientButton.TabIndex = 6
        Me.RegisterGradientButton.Text = "Register"
        Me.RegisterGradientButton.UseTransparentBackground = True
        '
        'EmailRegisterTextBox
        '
        Me.EmailRegisterTextBox.Animated = True
        Me.EmailRegisterTextBox.BorderRadius = 10
        Me.EmailRegisterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TransitionUserAccountPage.SetDecoration(Me.EmailRegisterTextBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.EmailRegisterTextBox.DefaultText = ""
        Me.EmailRegisterTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EmailRegisterTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EmailRegisterTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailRegisterTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailRegisterTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.EmailRegisterTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailRegisterTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EmailRegisterTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailRegisterTextBox.IconLeft = CType(resources.GetObject("EmailRegisterTextBox.IconLeft"), System.Drawing.Image)
        Me.EmailRegisterTextBox.Location = New System.Drawing.Point(29, 147)
        Me.EmailRegisterTextBox.Name = "EmailRegisterTextBox"
        Me.EmailRegisterTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailRegisterTextBox.PlaceholderText = "Email"
        Me.EmailRegisterTextBox.SelectedText = ""
        Me.EmailRegisterTextBox.Size = New System.Drawing.Size(262, 36)
        Me.EmailRegisterTextBox.TabIndex = 1
        '
        'PasswordRegisterTextBox
        '
        Me.PasswordRegisterTextBox.Animated = True
        Me.PasswordRegisterTextBox.BorderRadius = 10
        Me.PasswordRegisterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TransitionUserAccountPage.SetDecoration(Me.PasswordRegisterTextBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PasswordRegisterTextBox.DefaultText = ""
        Me.PasswordRegisterTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordRegisterTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordRegisterTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordRegisterTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordRegisterTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PasswordRegisterTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordRegisterTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordRegisterTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordRegisterTextBox.IconLeft = CType(resources.GetObject("PasswordRegisterTextBox.IconLeft"), System.Drawing.Image)
        Me.PasswordRegisterTextBox.Location = New System.Drawing.Point(29, 207)
        Me.PasswordRegisterTextBox.Name = "PasswordRegisterTextBox"
        Me.PasswordRegisterTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordRegisterTextBox.PlaceholderText = "Password"
        Me.PasswordRegisterTextBox.SelectedText = ""
        Me.PasswordRegisterTextBox.Size = New System.Drawing.Size(262, 36)
        Me.PasswordRegisterTextBox.TabIndex = 2
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.TransitionUserAccountPage.SetDecoration(Me.Guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(73, 262)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(98, 19)
        Me.Guna2HtmlLabel3.TabIndex = 5
        Me.Guna2HtmlLabel3.Text = "Show Password"
        '
        'ShowPasswordRegisterToggleSwitch
        '
        Me.ShowPasswordRegisterToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ShowPasswordRegisterToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ShowPasswordRegisterToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPasswordRegisterToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White
        Me.TransitionUserAccountPage.SetDecoration(Me.ShowPasswordRegisterToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ShowPasswordRegisterToggleSwitch.Location = New System.Drawing.Point(32, 262)
        Me.ShowPasswordRegisterToggleSwitch.Name = "ShowPasswordRegisterToggleSwitch"
        Me.ShowPasswordRegisterToggleSwitch.Size = New System.Drawing.Size(35, 20)
        Me.ShowPasswordRegisterToggleSwitch.TabIndex = 3
        Me.ShowPasswordRegisterToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPasswordRegisterToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPasswordRegisterToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPasswordRegisterToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'TransitionUserAccountPage
        '
        Me.TransitionUserAccountPage.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.TransitionUserAccountPage.DefaultAnimation = Animation1
        '
        'ExitGradientButton
        '
        Me.ExitGradientButton.Animated = True
        Me.ExitGradientButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitGradientButton.BorderRadius = 10
        Me.TransitionUserAccountPage.SetDecoration(Me.ExitGradientButton, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ExitGradientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ExitGradientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ExitGradientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ExitGradientButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ExitGradientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ExitGradientButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ExitGradientButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ExitGradientButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ExitGradientButton.ForeColor = System.Drawing.Color.White
        Me.ExitGradientButton.IndicateFocus = True
        Me.ExitGradientButton.Location = New System.Drawing.Point(603, 451)
        Me.ExitGradientButton.Name = "ExitGradientButton"
        Me.ExitGradientButton.Size = New System.Drawing.Size(85, 37)
        Me.ExitGradientButton.TabIndex = 13
        Me.ExitGradientButton.Text = "Exit"
        Me.ExitGradientButton.UseTransparentBackground = True
        '
        'ErrorMessageDialog
        '
        Me.ErrorMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.ErrorMessageDialog.Caption = ""
        Me.ErrorMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.[Error]
        Me.ErrorMessageDialog.Parent = Me
        Me.ErrorMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.ErrorMessageDialog.Text = ""
        '
        'SuccessMessageDialog
        '
        Me.SuccessMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.SuccessMessageDialog.Caption = Nothing
        Me.SuccessMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        Me.SuccessMessageDialog.Parent = Me
        Me.SuccessMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.SuccessMessageDialog.Text = Nothing
        '
        'ConfirmMessageDialog
        '
        Me.ConfirmMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo
        Me.ConfirmMessageDialog.Caption = Nothing
        Me.ConfirmMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question
        Me.ConfirmMessageDialog.Parent = Me
        Me.ConfirmMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.ConfirmMessageDialog.Text = Nothing
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
        'UserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.ExitGradientButton)
        Me.Controls.Add(Me.LoginShadowPanel)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.BackgroundGuna2PictureBox)
        Me.TransitionUserAccountPage.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.BackgroundGuna2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginShadowPanel.ResumeLayout(False)
        Me.LoginShadowPanel.PerformLayout()
        Me.RegisterShadowPanel.ResumeLayout(False)
        Me.RegisterShadowPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents EmailLoginTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordLoginTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ShowPasswordLoginToggleSwitch As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents ShowPasswordGuna2HtmlLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LoginGradientButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents CreateAccounButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents BackgroundGuna2PictureBox As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents LoginShadowPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents RegisterShadowPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents RegisterGradientButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents EmailRegisterTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordRegisterTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ShowPasswordRegisterToggleSwitch As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents NameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TransitionUserAccountPage As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents LoginCursorLabel As Label
    Friend WithEvents ErrorMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents SuccessMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ExitGradientButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ConfirmMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents NameToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents EmailToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents PasswordToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
