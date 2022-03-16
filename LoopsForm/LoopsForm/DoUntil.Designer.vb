<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoUntil
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxMonth = New System.Windows.Forms.ListBox()
        Me.GenerateDayButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GenerateMonthButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(148, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Do Until"
        '
        'ListBoxMonth
        '
        Me.ListBoxMonth.FormattingEnabled = True
        Me.ListBoxMonth.ItemHeight = 15
        Me.ListBoxMonth.Location = New System.Drawing.Point(28, 84)
        Me.ListBoxMonth.Name = "ListBoxMonth"
        Me.ListBoxMonth.Size = New System.Drawing.Size(162, 229)
        Me.ListBoxMonth.TabIndex = 10
        '
        'GenerateDayButton
        '
        Me.GenerateDayButton.Location = New System.Drawing.Point(248, 84)
        Me.GenerateDayButton.Name = "GenerateDayButton"
        Me.GenerateDayButton.Size = New System.Drawing.Size(102, 34)
        Me.GenerateDayButton.TabIndex = 11
        Me.GenerateDayButton.Text = "Generate Day"
        Me.GenerateDayButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(305, 279)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(82, 34)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(205, 279)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(82, 34)
        Me.ClearButton.TabIndex = 12
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'GenerateMonthButton
        '
        Me.GenerateMonthButton.Location = New System.Drawing.Point(248, 137)
        Me.GenerateMonthButton.Name = "GenerateMonthButton"
        Me.GenerateMonthButton.Size = New System.Drawing.Size(102, 34)
        Me.GenerateMonthButton.TabIndex = 14
        Me.GenerateMonthButton.Text = "Generate Month"
        Me.GenerateMonthButton.UseVisualStyleBackColor = True
        '
        'DoUntil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 394)
        Me.Controls.Add(Me.GenerateMonthButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.GenerateDayButton)
        Me.Controls.Add(Me.ListBoxMonth)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DoUntil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Do Until"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxMonth As ListBox
    Friend WithEvents GenerateDayButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents GenerateMonthButton As Button
End Class
