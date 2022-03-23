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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNIM = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCourses = New System.Windows.Forms.ComboBox()
        Me.ListViewRegistration = New System.Windows.Forms.ListView()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(57, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(57, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(57, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JENIS KELAMIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(57, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PROGRAM STUDI"
        '
        'TextBoxNIM
        '
        Me.TextBoxNIM.Location = New System.Drawing.Point(215, 33)
        Me.TextBoxNIM.Name = "TextBoxNIM"
        Me.TextBoxNIM.Size = New System.Drawing.Size(175, 23)
        Me.TextBoxNIM.TabIndex = 4
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(215, 75)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(175, 23)
        Me.TextBoxName.TabIndex = 5
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Location = New System.Drawing.Point(215, 115)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(175, 23)
        Me.ComboBoxGender.TabIndex = 6
        '
        'ComboBoxCourses
        '
        Me.ComboBoxCourses.FormattingEnabled = True
        Me.ComboBoxCourses.Location = New System.Drawing.Point(215, 160)
        Me.ComboBoxCourses.Name = "ComboBoxCourses"
        Me.ComboBoxCourses.Size = New System.Drawing.Size(175, 23)
        Me.ComboBoxCourses.TabIndex = 7
        '
        'ListViewRegistration
        '
        Me.ListViewRegistration.Location = New System.Drawing.Point(29, 275)
        Me.ListViewRegistration.Name = "ListViewRegistration"
        Me.ListViewRegistration.Size = New System.Drawing.Size(361, 144)
        Me.ListViewRegistration.TabIndex = 8
        Me.ListViewRegistration.UseCompatibleStateImageBehavior = False
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AddButton.Location = New System.Drawing.Point(215, 219)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 28)
        Me.AddButton.TabIndex = 9
        Me.AddButton.Text = "Tambah"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(315, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ListViewRegistration)
        Me.Controls.Add(Me.ComboBoxCourses)
        Me.Controls.Add(Me.ComboBoxGender)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxNIM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registration"
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxNIM As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents ComboBoxCourses As ComboBox
    Friend WithEvents ListViewRegistration As ListView
    Friend WithEvents AddButton As Button
    Friend WithEvents Button2 As Button
End Class
