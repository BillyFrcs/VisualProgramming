<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForNext
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
        Me.ListBoxItems = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InputSomethingTextBox = New System.Windows.Forms.TextBox()
        Me.LoopCountTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(144, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "For Next"
        '
        'ListBoxItems
        '
        Me.ListBoxItems.FormattingEnabled = True
        Me.ListBoxItems.ItemHeight = 15
        Me.ListBoxItems.Location = New System.Drawing.Point(46, 150)
        Me.ListBoxItems.Name = "ListBoxItems"
        Me.ListBoxItems.Size = New System.Drawing.Size(307, 154)
        Me.ListBoxItems.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Input Something"
        '
        'InputSomethingTextBox
        '
        Me.InputSomethingTextBox.Location = New System.Drawing.Point(166, 70)
        Me.InputSomethingTextBox.Name = "InputSomethingTextBox"
        Me.InputSomethingTextBox.Size = New System.Drawing.Size(187, 23)
        Me.InputSomethingTextBox.TabIndex = 3
        '
        'LoopCountTextBox
        '
        Me.LoopCountTextBox.Location = New System.Drawing.Point(166, 109)
        Me.LoopCountTextBox.Name = "LoopCountTextBox"
        Me.LoopCountTextBox.Size = New System.Drawing.Size(187, 23)
        Me.LoopCountTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Loop Count"
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(46, 346)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(82, 34)
        Me.GenerateButton.TabIndex = 6
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(153, 346)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(82, 34)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(271, 346)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(82, 34)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ForNext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 458)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.LoopCountTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.InputSomethingTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxItems)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ForNext"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "For Next"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxItems As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents InputSomethingTextBox As TextBox
    Friend WithEvents LoopCountTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GenerateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
