<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClinic
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
        Me.NoRegisterLabel = New System.Windows.Forms.Label()
        Me.NameOfRegisterLabel = New System.Windows.Forms.Label()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NoRegisterTextBox = New System.Windows.Forms.TextBox()
        Me.NameOfRegisterTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.ListViewRegistration = New System.Windows.Forms.ListView()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ActionGroupBox = New System.Windows.Forms.GroupBox()
        Me.ActionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NoRegisterLabel
        '
        Me.NoRegisterLabel.AutoSize = True
        Me.NoRegisterLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NoRegisterLabel.Location = New System.Drawing.Point(123, 61)
        Me.NoRegisterLabel.Name = "NoRegisterLabel"
        Me.NoRegisterLabel.Size = New System.Drawing.Size(85, 17)
        Me.NoRegisterLabel.TabIndex = 0
        Me.NoRegisterLabel.Text = "No Register"
        '
        'NameOfRegisterLabel
        '
        Me.NameOfRegisterLabel.AutoSize = True
        Me.NameOfRegisterLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameOfRegisterLabel.Location = New System.Drawing.Point(123, 102)
        Me.NameOfRegisterLabel.Name = "NameOfRegisterLabel"
        Me.NameOfRegisterLabel.Size = New System.Drawing.Size(126, 17)
        Me.NameOfRegisterLabel.TabIndex = 1
        Me.NameOfRegisterLabel.Text = "Name Of Register"
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GenderLabel.Location = New System.Drawing.Point(123, 179)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(56, 17)
        Me.GenderLabel.TabIndex = 2
        Me.GenderLabel.Text = "Gender"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AgeLabel.Location = New System.Drawing.Point(123, 141)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(33, 17)
        Me.AgeLabel.TabIndex = 3
        Me.AgeLabel.Text = "Age"
        '
        'NoRegisterTextBox
        '
        Me.NoRegisterTextBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NoRegisterTextBox.Location = New System.Drawing.Point(260, 61)
        Me.NoRegisterTextBox.Name = "NoRegisterTextBox"
        Me.NoRegisterTextBox.Size = New System.Drawing.Size(212, 25)
        Me.NoRegisterTextBox.TabIndex = 5
        '
        'NameOfRegisterTextBox
        '
        Me.NameOfRegisterTextBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameOfRegisterTextBox.Location = New System.Drawing.Point(260, 102)
        Me.NameOfRegisterTextBox.Name = "NameOfRegisterTextBox"
        Me.NameOfRegisterTextBox.Size = New System.Drawing.Size(212, 25)
        Me.NameOfRegisterTextBox.TabIndex = 6
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AgeTextBox.Location = New System.Drawing.Point(260, 141)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(212, 25)
        Me.AgeTextBox.TabIndex = 7
        '
        'ListViewRegistration
        '
        Me.ListViewRegistration.Location = New System.Drawing.Point(12, 285)
        Me.ListViewRegistration.Name = "ListViewRegistration"
        Me.ListViewRegistration.Size = New System.Drawing.Size(572, 183)
        Me.ListViewRegistration.TabIndex = 8
        Me.ListViewRegistration.UseCompatibleStateImageBehavior = False
        '
        'RegisterButton
        '
        Me.RegisterButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RegisterButton.Location = New System.Drawing.Point(49, 21)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(94, 33)
        Me.RegisterButton.TabIndex = 9
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.Location = New System.Drawing.Point(175, 21)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(94, 33)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(175, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Welcome To Clinic Yooo"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Location = New System.Drawing.Point(260, 179)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(139, 24)
        Me.GenderComboBox.TabIndex = 13
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CloseButton.Location = New System.Drawing.Point(416, 21)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(94, 33)
        Me.CloseButton.TabIndex = 14
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteButton.Location = New System.Drawing.Point(293, 21)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(94, 33)
        Me.DeleteButton.TabIndex = 15
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ActionGroupBox
        '
        Me.ActionGroupBox.Controls.Add(Me.DeleteButton)
        Me.ActionGroupBox.Controls.Add(Me.CloseButton)
        Me.ActionGroupBox.Controls.Add(Me.RegisterButton)
        Me.ActionGroupBox.Controls.Add(Me.ClearButton)
        Me.ActionGroupBox.Location = New System.Drawing.Point(12, 209)
        Me.ActionGroupBox.Name = "ActionGroupBox"
        Me.ActionGroupBox.Size = New System.Drawing.Size(572, 67)
        Me.ActionGroupBox.TabIndex = 16
        Me.ActionGroupBox.TabStop = False
        Me.ActionGroupBox.Text = "Action"
        '
        'FormClinic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 480)
        Me.Controls.Add(Me.ActionGroupBox)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.ListViewRegistration)
        Me.Controls.Add(Me.NameOfRegisterTextBox)
        Me.Controls.Add(Me.NoRegisterTextBox)
        Me.Controls.Add(Me.GenderLabel)
        Me.Controls.Add(Me.NameOfRegisterLabel)
        Me.Controls.Add(Me.NoRegisterLabel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "FormClinic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clinic Yooo"
        Me.ActionGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoRegisterLabel As Label
    Friend WithEvents NameOfRegisterLabel As Label
    Friend WithEvents GenderLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NoRegisterTextBox As TextBox
    Friend WithEvents NameOfRegisterTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents ListViewRegistration As ListView
    Friend WithEvents RegisterButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ActionGroupBox As GroupBox
End Class
