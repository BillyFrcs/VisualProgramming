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
        Me.components = New System.ComponentModel.Container()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.LanguageLabel = New System.Windows.Forms.Label()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DeleteAccountButton = New System.Windows.Forms.Button()
        Me.NameLabelTitle = New System.Windows.Forms.Label()
        Me.UsernameLabelDelete = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeleteUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBoxDashboard = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameLabel.Location = New System.Drawing.Point(328, 108)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(67, 23)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name:"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UsernameLabel.Location = New System.Drawing.Point(327, 145)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(105, 23)
        Me.UsernameLabel.TabIndex = 2
        Me.UsernameLabel.Text = "Username:"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmailLabel.Location = New System.Drawing.Point(328, 184)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(64, 23)
        Me.EmailLabel.TabIndex = 3
        Me.EmailLabel.Text = "Email:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PasswordLabel.Location = New System.Drawing.Point(328, 216)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(104, 23)
        Me.PasswordLabel.TabIndex = 4
        Me.PasswordLabel.Text = "Password:"
        '
        'LanguageLabel
        '
        Me.LanguageLabel.AutoSize = True
        Me.LanguageLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LanguageLabel.Location = New System.Drawing.Point(328, 250)
        Me.LanguageLabel.Name = "LanguageLabel"
        Me.LanguageLabel.Size = New System.Drawing.Size(102, 23)
        Me.LanguageLabel.TabIndex = 5
        Me.LanguageLabel.Text = "Language:"
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GenderLabel.Location = New System.Drawing.Point(328, 287)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(82, 23)
        Me.GenderLabel.TabIndex = 6
        Me.GenderLabel.Text = "Gender:"
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CloseButton.Location = New System.Drawing.Point(699, 404)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(89, 34)
        Me.CloseButton.TabIndex = 29
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'DeleteAccountButton
        '
        Me.DeleteAccountButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteAccountButton.Location = New System.Drawing.Point(585, 404)
        Me.DeleteAccountButton.Name = "DeleteAccountButton"
        Me.DeleteAccountButton.Size = New System.Drawing.Size(108, 34)
        Me.DeleteAccountButton.TabIndex = 30
        Me.DeleteAccountButton.Text = "Delete Account"
        Me.DeleteAccountButton.UseVisualStyleBackColor = True
        '
        'NameLabelTitle
        '
        Me.NameLabelTitle.AutoSize = True
        Me.NameLabelTitle.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NameLabelTitle.Location = New System.Drawing.Point(25, 22)
        Me.NameLabelTitle.Name = "NameLabelTitle"
        Me.NameLabelTitle.Size = New System.Drawing.Size(180, 33)
        Me.NameLabelTitle.TabIndex = 31
        Me.NameLabelTitle.Text = "Hello, Name"
        '
        'UsernameLabelDelete
        '
        Me.UsernameLabelDelete.AutoSize = True
        Me.UsernameLabelDelete.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UsernameLabelDelete.ForeColor = System.Drawing.Color.IndianRed
        Me.UsernameLabelDelete.Location = New System.Drawing.Point(12, 414)
        Me.UsernameLabelDelete.Name = "UsernameLabelDelete"
        Me.UsernameLabelDelete.Size = New System.Drawing.Size(99, 23)
        Me.UsernameLabelDelete.TabIndex = 32
        Me.UsernameLabelDelete.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(12, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Input your username to delete your account!"
        '
        'DeleteUsernameTextBox
        '
        Me.DeleteUsernameTextBox.Location = New System.Drawing.Point(117, 414)
        Me.DeleteUsernameTextBox.Name = "DeleteUsernameTextBox"
        Me.DeleteUsernameTextBox.Size = New System.Drawing.Size(144, 23)
        Me.DeleteUsernameTextBox.TabIndex = 34
        '
        'PictureBoxDashboard
        '
        Me.PictureBoxDashboard.Image = Global.UserAccountSystem.My.Resources.Resources.kisspng_gumball_watterson_anais_watterson_darwin_watterson_misto_quente_5b245a928e31d5_0756621815291091385824
        Me.PictureBoxDashboard.Location = New System.Drawing.Point(67, 129)
        Me.PictureBoxDashboard.Name = "PictureBoxDashboard"
        Me.PictureBoxDashboard.Size = New System.Drawing.Size(194, 181)
        Me.PictureBoxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxDashboard.TabIndex = 35
        Me.PictureBoxDashboard.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBoxDashboard)
        Me.Controls.Add(Me.DeleteUsernameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UsernameLabelDelete)
        Me.Controls.Add(Me.NameLabelTitle)
        Me.Controls.Add(Me.DeleteAccountButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.GenderLabel)
        Me.Controls.Add(Me.LanguageLabel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.PictureBoxDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents LanguageLabel As Label
    Friend WithEvents GenderLabel As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents DeleteAccountButton As Button
    Friend WithEvents NameLabelTitle As Label
    Friend WithEvents UsernameLabelDelete As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DeleteUsernameTextBox As TextBox
    Friend WithEvents UsernameToolTip As ToolTip
    Friend WithEvents PictureBoxDashboard As PictureBox
End Class
