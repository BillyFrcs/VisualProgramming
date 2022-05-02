<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.DashboardDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchDataLabel = New System.Windows.Forms.Label()
        Me.SearchNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SearchDataButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DeleteNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintUserDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogUserData = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DashboardDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.EmailLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 302)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ClearButton.BackColor = System.Drawing.Color.BlueViolet
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.Location = New System.Drawing.Point(143, 230)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 39)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.Location = New System.Drawing.Point(242, 230)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 39)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmailTextBox.Location = New System.Drawing.Point(118, 173)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(199, 25)
        Me.EmailTextBox.TabIndex = 7
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PhoneTextBox.Location = New System.Drawing.Point(118, 134)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(199, 25)
        Me.PhoneTextBox.TabIndex = 6
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SaveButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SaveButton.Location = New System.Drawing.Point(41, 230)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 39)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LastNameTextBox.Location = New System.Drawing.Point(118, 90)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(199, 25)
        Me.LastNameTextBox.TabIndex = 5
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FirstNameTextBox.Location = New System.Drawing.Point(118, 48)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(199, 25)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FirstNameLabel.Location = New System.Drawing.Point(31, 48)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(71, 17)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First Name"
        '
        'EmailLabel
        '
        Me.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmailLabel.Location = New System.Drawing.Point(31, 173)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(39, 17)
        Me.EmailLabel.TabIndex = 3
        Me.EmailLabel.Text = "Email"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PhoneLabel.Location = New System.Drawing.Point(31, 134)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(44, 17)
        Me.PhoneLabel.TabIndex = 2
        Me.PhoneLabel.Text = "Phone"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LastNameLabel.Location = New System.Drawing.Point(31, 90)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(70, 17)
        Me.LastNameLabel.TabIndex = 1
        Me.LastNameLabel.Text = "Last Name"
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DeleteButton.BackColor = System.Drawing.Color.Crimson
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteButton.Location = New System.Drawing.Point(229, 51)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 39)
        Me.DeleteButton.TabIndex = 11
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'DashboardDataGridView
        '
        Me.DashboardDataGridView.AllowUserToOrderColumns = True
        Me.DashboardDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DashboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DashboardDataGridView.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DashboardDataGridView.Location = New System.Drawing.Point(17, 28)
        Me.DashboardDataGridView.Name = "DashboardDataGridView"
        Me.DashboardDataGridView.RowTemplate.Height = 25
        Me.DashboardDataGridView.Size = New System.Drawing.Size(445, 257)
        Me.DashboardDataGridView.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.DashboardDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(403, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 302)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data View"
        '
        'SearchDataLabel
        '
        Me.SearchDataLabel.AutoSize = True
        Me.SearchDataLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SearchDataLabel.Location = New System.Drawing.Point(18, 22)
        Me.SearchDataLabel.Name = "SearchDataLabel"
        Me.SearchDataLabel.Size = New System.Drawing.Size(47, 17)
        Me.SearchDataLabel.TabIndex = 13
        Me.SearchDataLabel.Text = "Search"
        '
        'SearchNameTextBox
        '
        Me.SearchNameTextBox.Location = New System.Drawing.Point(105, 22)
        Me.SearchNameTextBox.Name = "SearchNameTextBox"
        Me.SearchNameTextBox.Size = New System.Drawing.Size(199, 23)
        Me.SearchNameTextBox.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.SearchDataButton)
        Me.GroupBox3.Controls.Add(Me.SearchNameTextBox)
        Me.GroupBox3.Controls.Add(Me.SearchDataLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 354)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(338, 100)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Data"
        '
        'SearchDataButton
        '
        Me.SearchDataButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SearchDataButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SearchDataButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SearchDataButton.Location = New System.Drawing.Point(240, 55)
        Me.SearchDataButton.Name = "SearchDataButton"
        Me.SearchDataButton.Size = New System.Drawing.Size(75, 39)
        Me.SearchDataButton.TabIndex = 15
        Me.SearchDataButton.Text = "Search"
        Me.SearchDataButton.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.DeleteNameTextBox)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.DeleteButton)
        Me.GroupBox4.Location = New System.Drawing.Point(403, 354)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(327, 100)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Delete Data"
        '
        'DeleteNameTextBox
        '
        Me.DeleteNameTextBox.Location = New System.Drawing.Point(105, 22)
        Me.DeleteNameTextBox.Name = "DeleteNameTextBox"
        Me.DeleteNameTextBox.Size = New System.Drawing.Size(199, 23)
        Me.DeleteNameTextBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Delete"
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PrintButton.BackColor = System.Drawing.Color.Magenta
        Me.PrintButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PrintButton.Location = New System.Drawing.Point(38, 51)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 39)
        Me.PrintButton.TabIndex = 16
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'PrintUserDocument
        '
        '
        'PrintPreviewDialogUserData
        '
        Me.PrintPreviewDialogUserData.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogUserData.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogUserData.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogUserData.Enabled = True
        Me.PrintPreviewDialogUserData.Icon = CType(resources.GetObject("PrintPreviewDialogUserData.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogUserData.Name = "PrintPreviewDialogUserData"
        Me.PrintPreviewDialogUserData.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PrintButton)
        Me.GroupBox5.Location = New System.Drawing.Point(736, 338)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(138, 100)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Print"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 483)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DashboardDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents DashboardDataGridView As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SearchDataLabel As Label
    Friend WithEvents SearchNameTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SearchDataButton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DeleteNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintUserDocument As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogUserData As PrintPreviewDialog
    Friend WithEvents GroupBox5 As GroupBox
End Class
