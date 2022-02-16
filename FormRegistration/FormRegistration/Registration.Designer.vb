<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registration
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboText = New System.Windows.Forms.ComboBox()
        Me.ProgramComboText = New System.Windows.Forms.ComboBox()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(208, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(208, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(208, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Progam"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(290, 121)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(166, 23)
        Me.NameTextBox.TabIndex = 3
        '
        'GenderComboText
        '
        Me.GenderComboText.FormattingEnabled = True
        Me.GenderComboText.Items.AddRange(New Object() {"Man", "Woman"})
        Me.GenderComboText.Location = New System.Drawing.Point(290, 158)
        Me.GenderComboText.Name = "GenderComboText"
        Me.GenderComboText.Size = New System.Drawing.Size(166, 23)
        Me.GenderComboText.TabIndex = 4
        '
        'ProgramComboText
        '
        Me.ProgramComboText.FormattingEnabled = True
        Me.ProgramComboText.Items.AddRange(New Object() {"Computer Science", "Game Programming", "Web Development", "Application Development", "3D Artist"})
        Me.ProgramComboText.Location = New System.Drawing.Point(290, 202)
        Me.ProgramComboText.Name = "ProgramComboText"
        Me.ProgramComboText.Size = New System.Drawing.Size(166, 23)
        Me.ProgramComboText.TabIndex = 5
        '
        'ShowButton
        '
        Me.ShowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowButton.Location = New System.Drawing.Point(290, 262)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(74, 34)
        Me.ShowButton.TabIndex = 6
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.Location = New System.Drawing.Point(370, 262)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 34)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Red
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CloseButton.Location = New System.Drawing.Point(451, 262)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 34)
        Me.CloseButton.TabIndex = 8
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(208, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(326, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Student Registration"
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(747, 449)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.ProgramComboText)
        Me.Controls.Add(Me.GenderComboText)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents GenderComboText As ComboBox
    Friend WithEvents ProgramComboText As ComboBox
    Friend WithEvents ShowButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label4 As Label
End Class
