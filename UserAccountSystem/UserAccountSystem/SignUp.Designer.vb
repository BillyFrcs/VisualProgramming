<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Me.Title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStripAccount = New System.Windows.Forms.MenuStrip()
        Me.SignUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignUpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.LanguageComboBox = New System.Windows.Forms.ComboBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CreateAccountButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UnknownRadioButton = New System.Windows.Forms.RadioButton()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBoxSignUp = New System.Windows.Forms.PictureBox()
        Me.MenuStripAccount.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxSignUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(337, 25)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(117, 37)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Sign Up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(257, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(257, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(257, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(257, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Language"
        '
        'MenuStripAccount
        '
        Me.MenuStripAccount.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignUpToolStripMenuItem})
        Me.MenuStripAccount.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripAccount.Name = "MenuStripAccount"
        Me.MenuStripAccount.Size = New System.Drawing.Size(800, 25)
        Me.MenuStripAccount.TabIndex = 5
        Me.MenuStripAccount.Text = "Account"
        '
        'SignUpToolStripMenuItem
        '
        Me.SignUpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignInToolStripMenuItem, Me.SignUpToolStripMenuItem1})
        Me.SignUpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SignUpToolStripMenuItem.Name = "SignUpToolStripMenuItem"
        Me.SignUpToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.SignUpToolStripMenuItem.Text = "Account"
        '
        'SignInToolStripMenuItem
        '
        Me.SignInToolStripMenuItem.Name = "SignInToolStripMenuItem"
        Me.SignInToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SignInToolStripMenuItem.Text = "Sign In"
        '
        'SignUpToolStripMenuItem1
        '
        Me.SignUpToolStripMenuItem1.Name = "SignUpToolStripMenuItem1"
        Me.SignUpToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.SignUpToolStripMenuItem1.Text = "Sign Up"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(337, 85)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(188, 23)
        Me.NameTextBox.TabIndex = 6
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(337, 146)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(188, 23)
        Me.EmailTextBox.TabIndex = 7
        '
        'LanguageComboBox
        '
        Me.LanguageComboBox.FormattingEnabled = True
        Me.LanguageComboBox.Location = New System.Drawing.Point(337, 235)
        Me.LanguageComboBox.Name = "LanguageComboBox"
        Me.LanguageComboBox.Size = New System.Drawing.Size(107, 23)
        Me.LanguageComboBox.TabIndex = 8
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(337, 181)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(188, 23)
        Me.PasswordTextBox.TabIndex = 9
        '
        'CreateAccountButton
        '
        Me.CreateAccountButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CreateAccountButton.Location = New System.Drawing.Point(337, 344)
        Me.CreateAccountButton.Name = "CreateAccountButton"
        Me.CreateAccountButton.Size = New System.Drawing.Size(107, 34)
        Me.CreateAccountButton.TabIndex = 10
        Me.CreateAccountButton.Text = "Create Account"
        Me.CreateAccountButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CloseButton.Location = New System.Drawing.Point(450, 344)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(86, 34)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(257, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Gender"
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(0, 22)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(53, 20)
        Me.MaleRadioButton.TabIndex = 13
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(55, 22)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(68, 20)
        Me.FemaleRadioButton.TabIndex = 14
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UnknownRadioButton)
        Me.GroupBox1.Controls.Add(Me.MaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.FemaleRadioButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(337, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 65)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Your Gender"
        '
        'UnknownRadioButton
        '
        Me.UnknownRadioButton.AutoSize = True
        Me.UnknownRadioButton.Location = New System.Drawing.Point(121, 22)
        Me.UnknownRadioButton.Name = "UnknownRadioButton"
        Me.UnknownRadioButton.Size = New System.Drawing.Size(78, 20)
        Me.UnknownRadioButton.TabIndex = 15
        Me.UnknownRadioButton.TabStop = True
        Me.UnknownRadioButton.Text = "Unknown"
        Me.UnknownRadioButton.UseVisualStyleBackColor = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(337, 117)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(188, 23)
        Me.UsernameTextBox.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(257, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Username"
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(336, 210)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(108, 19)
        Me.ShowPasswordCheckBox.TabIndex = 35
        Me.ShowPasswordCheckBox.Text = "Show Password"
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBoxSignUp
        '
        Me.PictureBoxSignUp.Image = Global.UserAccountSystem.My.Resources.Resources.Tobias
        Me.PictureBoxSignUp.Location = New System.Drawing.Point(12, 90)
        Me.PictureBoxSignUp.Name = "PictureBoxSignUp"
        Me.PictureBoxSignUp.Size = New System.Drawing.Size(239, 202)
        Me.PictureBoxSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxSignUp.TabIndex = 36
        Me.PictureBoxSignUp.TabStop = False
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBoxSignUp)
        Me.Controls.Add(Me.ShowPasswordCheckBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.CreateAccountButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.LanguageComboBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.MenuStripAccount)
        Me.MainMenuStrip = Me.MenuStripAccount
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.MenuStripAccount.ResumeLayout(False)
        Me.MenuStripAccount.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxSignUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStripAccount As MenuStrip
    Friend WithEvents SignUpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignUpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents LanguageComboBox As ComboBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents CreateAccountButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UnknownRadioButton As RadioButton
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents PictureBoxSignUp As PictureBox
End Class
