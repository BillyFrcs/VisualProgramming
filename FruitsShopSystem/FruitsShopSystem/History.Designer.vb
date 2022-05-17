<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class History
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.ConfirmMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.ErrorMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.SuccessMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.FruitsHtmlToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.HistoryTransactionDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SearchHistoryTransactionCircleButton = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.SearchHistoryTransactionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.HistoryHtmlToolTip = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.PrintHistoryTransactionGradientButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2NotificationPaint1 = New Guna.UI2.WinForms.Guna2NotificationPaint(Me.components)
        Me.HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintHistoryTransactionDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogUserTransaction = New System.Windows.Forms.PrintPreviewDialog()
        Me.DeleteGradientButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.RefreshGradientButton = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.HistoryTransactionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'HistoryTransactionDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.HistoryTransactionDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.HistoryTransactionDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistoryTransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HistoryTransactionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.HistoryTransactionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HistoryTransactionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.HistoryTransactionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HistoryTransactionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.HistoryTransactionDataGridView.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HistoryTransactionDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.HistoryTransactionDataGridView.EnableHeadersVisualStyles = False
        Me.HistoryTransactionDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HistoryTransactionDataGridView.Location = New System.Drawing.Point(26, 90)
        Me.HistoryTransactionDataGridView.Name = "HistoryTransactionDataGridView"
        Me.HistoryTransactionDataGridView.ReadOnly = True
        Me.HistoryTransactionDataGridView.RowHeadersVisible = False
        Me.HistoryTransactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HistoryTransactionDataGridView.Size = New System.Drawing.Size(727, 334)
        Me.HistoryTransactionDataGridView.TabIndex = 45
        Me.HistoryTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.HistoryTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.HistoryTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.HistoryTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.HistoryTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.HistoryTransactionDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.HistoryTransactionDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HistoryTransactionDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HistoryTransactionDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.HistoryTransactionDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.HistoryTransactionDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.HistoryTransactionDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.HistoryTransactionDataGridView.ThemeStyle.HeaderStyle.Height = 4
        Me.HistoryTransactionDataGridView.ThemeStyle.ReadOnly = True
        Me.HistoryTransactionDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.HistoryTransactionDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.HistoryTransactionDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.HistoryTransactionDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.HistoryTransactionDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.HistoryTransactionDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HistoryTransactionDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(26, 22)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(102, 39)
        Me.Guna2HtmlLabel2.TabIndex = 46
        Me.Guna2HtmlLabel2.Text = "History"
        '
        'SearchHistoryTransactionCircleButton
        '
        Me.SearchHistoryTransactionCircleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchHistoryTransactionCircleButton.Animated = True
        Me.SearchHistoryTransactionCircleButton.BackColor = System.Drawing.Color.Transparent
        Me.SearchHistoryTransactionCircleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SearchHistoryTransactionCircleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SearchHistoryTransactionCircleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SearchHistoryTransactionCircleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SearchHistoryTransactionCircleButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SearchHistoryTransactionCircleButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SearchHistoryTransactionCircleButton.ForeColor = System.Drawing.Color.White
        Me.SearchHistoryTransactionCircleButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchHistoryTransactionCircleButton.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.SearchHistoryTransactionCircleButton.Image = CType(resources.GetObject("SearchHistoryTransactionCircleButton.Image"), System.Drawing.Image)
        Me.SearchHistoryTransactionCircleButton.ImageSize = New System.Drawing.Size(15, 15)
        Me.SearchHistoryTransactionCircleButton.IndicateFocus = True
        Me.SearchHistoryTransactionCircleButton.Location = New System.Drawing.Point(573, 30)
        Me.SearchHistoryTransactionCircleButton.Name = "SearchHistoryTransactionCircleButton"
        Me.SearchHistoryTransactionCircleButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.SearchHistoryTransactionCircleButton.Size = New System.Drawing.Size(30, 30)
        Me.SearchHistoryTransactionCircleButton.TabIndex = 51
        Me.SearchHistoryTransactionCircleButton.UseTransparentBackground = True
        '
        'SearchHistoryTransactionTextBox
        '
        Me.SearchHistoryTransactionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SearchHistoryTransactionTextBox.Animated = True
        Me.SearchHistoryTransactionTextBox.AutoRoundedCorners = True
        Me.SearchHistoryTransactionTextBox.BorderRadius = 23
        Me.SearchHistoryTransactionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchHistoryTransactionTextBox.DefaultText = ""
        Me.SearchHistoryTransactionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchHistoryTransactionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchHistoryTransactionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchHistoryTransactionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchHistoryTransactionTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SearchHistoryTransactionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchHistoryTransactionTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SearchHistoryTransactionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchHistoryTransactionTextBox.Location = New System.Drawing.Point(560, 22)
        Me.SearchHistoryTransactionTextBox.Name = "SearchHistoryTransactionTextBox"
        Me.SearchHistoryTransactionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchHistoryTransactionTextBox.PlaceholderText = "Search Transaction"
        Me.SearchHistoryTransactionTextBox.SelectedText = ""
        Me.SearchHistoryTransactionTextBox.Size = New System.Drawing.Size(193, 48)
        Me.SearchHistoryTransactionTextBox.TabIndex = 50
        Me.SearchHistoryTransactionTextBox.TextOffset = New System.Drawing.Point(36, 0)
        '
        'HistoryHtmlToolTip
        '
        Me.HistoryHtmlToolTip.AllowLinksHandling = True
        Me.HistoryHtmlToolTip.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'PrintHistoryTransactionGradientButton
        '
        Me.PrintHistoryTransactionGradientButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PrintHistoryTransactionGradientButton.Animated = True
        Me.PrintHistoryTransactionGradientButton.AutoRoundedCorners = True
        Me.PrintHistoryTransactionGradientButton.BackColor = System.Drawing.Color.Transparent
        Me.PrintHistoryTransactionGradientButton.BorderRadius = 17
        Me.PrintHistoryTransactionGradientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PrintHistoryTransactionGradientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PrintHistoryTransactionGradientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PrintHistoryTransactionGradientButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PrintHistoryTransactionGradientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PrintHistoryTransactionGradientButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrintHistoryTransactionGradientButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.PrintHistoryTransactionGradientButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.PrintHistoryTransactionGradientButton.ForeColor = System.Drawing.Color.White
        Me.PrintHistoryTransactionGradientButton.Image = CType(resources.GetObject("PrintHistoryTransactionGradientButton.Image"), System.Drawing.Image)
        Me.PrintHistoryTransactionGradientButton.IndicateFocus = True
        Me.PrintHistoryTransactionGradientButton.Location = New System.Drawing.Point(440, 30)
        Me.PrintHistoryTransactionGradientButton.Name = "PrintHistoryTransactionGradientButton"
        Me.PrintHistoryTransactionGradientButton.Size = New System.Drawing.Size(100, 37)
        Me.PrintHistoryTransactionGradientButton.TabIndex = 159
        Me.PrintHistoryTransactionGradientButton.Text = "Print"
        Me.PrintHistoryTransactionGradientButton.UseTransparentBackground = True
        '
        'HistoryBindingSource
        '
        Me.HistoryBindingSource.DataSource = GetType(FruitsShopSystem.History)
        '
        'PrintHistoryTransactionDocument
        '
        '
        'PrintPreviewDialogUserTransaction
        '
        Me.PrintPreviewDialogUserTransaction.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogUserTransaction.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogUserTransaction.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogUserTransaction.Enabled = True
        Me.PrintPreviewDialogUserTransaction.Icon = CType(resources.GetObject("PrintPreviewDialogUserTransaction.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogUserTransaction.Name = "PrintPreviewDialogUserTransaction"
        Me.PrintPreviewDialogUserTransaction.Visible = False
        '
        'DeleteGradientButton
        '
        Me.DeleteGradientButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteGradientButton.Animated = True
        Me.DeleteGradientButton.AutoRoundedCorners = True
        Me.DeleteGradientButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteGradientButton.BorderRadius = 17
        Me.DeleteGradientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DeleteGradientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DeleteGradientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteGradientButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DeleteGradientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DeleteGradientButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DeleteGradientButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DeleteGradientButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DeleteGradientButton.ForeColor = System.Drawing.Color.White
        Me.DeleteGradientButton.Image = CType(resources.GetObject("DeleteGradientButton.Image"), System.Drawing.Image)
        Me.DeleteGradientButton.IndicateFocus = True
        Me.DeleteGradientButton.Location = New System.Drawing.Point(334, 30)
        Me.DeleteGradientButton.Name = "DeleteGradientButton"
        Me.DeleteGradientButton.Size = New System.Drawing.Size(100, 37)
        Me.DeleteGradientButton.TabIndex = 160
        Me.DeleteGradientButton.Text = "Delete"
        Me.DeleteGradientButton.UseTransparentBackground = True
        '
        'RefreshGradientButton
        '
        Me.RefreshGradientButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshGradientButton.Animated = True
        Me.RefreshGradientButton.AutoRoundedCorners = True
        Me.RefreshGradientButton.BackColor = System.Drawing.Color.Transparent
        Me.RefreshGradientButton.BorderRadius = 20
        Me.RefreshGradientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RefreshGradientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RefreshGradientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RefreshGradientButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RefreshGradientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RefreshGradientButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.RefreshGradientButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.RefreshGradientButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RefreshGradientButton.ForeColor = System.Drawing.Color.White
        Me.RefreshGradientButton.Image = CType(resources.GetObject("RefreshGradientButton.Image"), System.Drawing.Image)
        Me.RefreshGradientButton.IndicateFocus = True
        Me.RefreshGradientButton.Location = New System.Drawing.Point(228, 30)
        Me.RefreshGradientButton.Name = "RefreshGradientButton"
        Me.RefreshGradientButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.RefreshGradientButton.Size = New System.Drawing.Size(100, 42)
        Me.RefreshGradientButton.TabIndex = 161
        Me.RefreshGradientButton.Text = "Refresh"
        Me.RefreshGradientButton.UseTransparentBackground = True
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 466)
        Me.Controls.Add(Me.RefreshGradientButton)
        Me.Controls.Add(Me.DeleteGradientButton)
        Me.Controls.Add(Me.PrintHistoryTransactionGradientButton)
        Me.Controls.Add(Me.SearchHistoryTransactionCircleButton)
        Me.Controls.Add(Me.SearchHistoryTransactionTextBox)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.HistoryTransactionDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "History"
        Me.Text = "History"
        CType(Me.HistoryTransactionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents ConfirmMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents ErrorMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents SuccessMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents FruitsHtmlToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents HistoryTransactionDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents SearchHistoryTransactionCircleButton As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents SearchHistoryTransactionTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents HistoryHtmlToolTip As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents PrintHistoryTransactionGradientButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2NotificationPaint1 As Guna.UI2.WinForms.Guna2NotificationPaint
    Friend WithEvents HistoryBindingSource As BindingSource
    Friend WithEvents PrintHistoryTransactionDocument As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogUserTransaction As PrintPreviewDialog
    Friend WithEvents DeleteGradientButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents RefreshGradientButton As Guna.UI2.WinForms.Guna2GradientButton
End Class
