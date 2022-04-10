<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.UsernameToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.EmailToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PasswordToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProviderValidation = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProviderValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(341, 142)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(188, 23)
        Me.UsernameTextBox.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(261, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Username"
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackButton.Location = New System.Drawing.Point(440, 260)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(89, 34)
        Me.BackButton.TabIndex = 28
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LoginButton.Location = New System.Drawing.Point(341, 260)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(89, 34)
        Me.LoginButton.TabIndex = 27
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(341, 206)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(188, 23)
        Me.PasswordTextBox.TabIndex = 26
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(341, 171)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(188, 23)
        Me.EmailTextBox.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(261, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(261, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Email"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(341, 72)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(105, 37)
        Me.Title.TabIndex = 18
        Me.Title.Text = "Sign In"
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(341, 235)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(108, 19)
        Me.ShowPasswordCheckBox.TabIndex = 34
        Me.ShowPasswordCheckBox.Text = "Show Password"
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'ErrorProviderValidation
        '
        Me.ErrorProviderValidation.ContainerControl = Me
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ShowPasswordCheckBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Title)
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign In"
        CType(Me.ErrorProviderValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents LoginButton As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Title As Label
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents UsernameToolTip As ToolTip
    Friend WithEvents EmailToolTip As ToolTip
    Friend WithEvents PasswordToolTip As ToolTip
    Friend WithEvents ErrorProviderValidation As ErrorProvider
End Class
