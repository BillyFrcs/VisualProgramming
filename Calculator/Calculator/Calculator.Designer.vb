<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        Me.ButtonZero = New System.Windows.Forms.Button()
        Me.ButtonOne = New System.Windows.Forms.Button()
        Me.ButtonFour = New System.Windows.Forms.Button()
        Me.ButtonSeven = New System.Windows.Forms.Button()
        Me.ButtonEight = New System.Windows.Forms.Button()
        Me.ButtonFive = New System.Windows.Forms.Button()
        Me.ButtonTwo = New System.Windows.Forms.Button()
        Me.DecimalButton = New System.Windows.Forms.Button()
        Me.ButtonNine = New System.Windows.Forms.Button()
        Me.ButtonSix = New System.Windows.Forms.Button()
        Me.ButtonThree = New System.Windows.Forms.Button()
        Me.CalculateResultButton = New System.Windows.Forms.Button()
        Me.ButtonAddition = New System.Windows.Forms.Button()
        Me.ButtonSubtraction = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivision = New System.Windows.Forms.Button()
        Me.CalculatorGroupBox = New System.Windows.Forms.GroupBox()
        Me.BackspaceButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.DeleteToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ShowResultToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DisplayResultLabel = New System.Windows.Forms.Label()
        Me.CalculatorGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonZero
        '
        Me.ButtonZero.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonZero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonZero.Location = New System.Drawing.Point(14, 214)
        Me.ButtonZero.Name = "ButtonZero"
        Me.ButtonZero.Size = New System.Drawing.Size(49, 44)
        Me.ButtonZero.TabIndex = 0
        Me.ButtonZero.Text = "0"
        Me.ButtonZero.UseVisualStyleBackColor = False
        '
        'ButtonOne
        '
        Me.ButtonOne.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonOne.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonOne.Location = New System.Drawing.Point(14, 164)
        Me.ButtonOne.Name = "ButtonOne"
        Me.ButtonOne.Size = New System.Drawing.Size(49, 44)
        Me.ButtonOne.TabIndex = 1
        Me.ButtonOne.Text = "1"
        Me.ButtonOne.UseVisualStyleBackColor = False
        '
        'ButtonFour
        '
        Me.ButtonFour.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonFour.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonFour.Location = New System.Drawing.Point(14, 114)
        Me.ButtonFour.Name = "ButtonFour"
        Me.ButtonFour.Size = New System.Drawing.Size(50, 44)
        Me.ButtonFour.TabIndex = 2
        Me.ButtonFour.Text = "4"
        Me.ButtonFour.UseVisualStyleBackColor = False
        '
        'ButtonSeven
        '
        Me.ButtonSeven.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonSeven.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSeven.Location = New System.Drawing.Point(15, 64)
        Me.ButtonSeven.Name = "ButtonSeven"
        Me.ButtonSeven.Size = New System.Drawing.Size(49, 44)
        Me.ButtonSeven.TabIndex = 3
        Me.ButtonSeven.Text = "7"
        Me.ButtonSeven.UseVisualStyleBackColor = False
        '
        'ButtonEight
        '
        Me.ButtonEight.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonEight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonEight.Location = New System.Drawing.Point(88, 64)
        Me.ButtonEight.Name = "ButtonEight"
        Me.ButtonEight.Size = New System.Drawing.Size(48, 44)
        Me.ButtonEight.TabIndex = 4
        Me.ButtonEight.Text = "8"
        Me.ButtonEight.UseVisualStyleBackColor = False
        '
        'ButtonFive
        '
        Me.ButtonFive.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonFive.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonFive.Location = New System.Drawing.Point(89, 114)
        Me.ButtonFive.Name = "ButtonFive"
        Me.ButtonFive.Size = New System.Drawing.Size(47, 44)
        Me.ButtonFive.TabIndex = 5
        Me.ButtonFive.Text = "5"
        Me.ButtonFive.UseVisualStyleBackColor = False
        '
        'ButtonTwo
        '
        Me.ButtonTwo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonTwo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTwo.Location = New System.Drawing.Point(89, 164)
        Me.ButtonTwo.Name = "ButtonTwo"
        Me.ButtonTwo.Size = New System.Drawing.Size(47, 44)
        Me.ButtonTwo.TabIndex = 6
        Me.ButtonTwo.Text = "2"
        Me.ButtonTwo.UseVisualStyleBackColor = False
        '
        'DecimalButton
        '
        Me.DecimalButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DecimalButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DecimalButton.Location = New System.Drawing.Point(89, 214)
        Me.DecimalButton.Name = "DecimalButton"
        Me.DecimalButton.Size = New System.Drawing.Size(47, 44)
        Me.DecimalButton.TabIndex = 7
        Me.DecimalButton.Text = "."
        Me.DecimalButton.UseVisualStyleBackColor = False
        '
        'ButtonNine
        '
        Me.ButtonNine.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonNine.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonNine.Location = New System.Drawing.Point(157, 64)
        Me.ButtonNine.Name = "ButtonNine"
        Me.ButtonNine.Size = New System.Drawing.Size(49, 44)
        Me.ButtonNine.TabIndex = 8
        Me.ButtonNine.Text = "9"
        Me.ButtonNine.UseVisualStyleBackColor = False
        '
        'ButtonSix
        '
        Me.ButtonSix.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonSix.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSix.Location = New System.Drawing.Point(157, 114)
        Me.ButtonSix.Name = "ButtonSix"
        Me.ButtonSix.Size = New System.Drawing.Size(49, 44)
        Me.ButtonSix.TabIndex = 9
        Me.ButtonSix.Text = "6"
        Me.ButtonSix.UseVisualStyleBackColor = False
        '
        'ButtonThree
        '
        Me.ButtonThree.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonThree.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonThree.Location = New System.Drawing.Point(157, 164)
        Me.ButtonThree.Name = "ButtonThree"
        Me.ButtonThree.Size = New System.Drawing.Size(49, 44)
        Me.ButtonThree.TabIndex = 10
        Me.ButtonThree.Text = "3"
        Me.ButtonThree.UseVisualStyleBackColor = False
        '
        'CalculateResultButton
        '
        Me.CalculateResultButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CalculateResultButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CalculateResultButton.Location = New System.Drawing.Point(157, 214)
        Me.CalculateResultButton.Name = "CalculateResultButton"
        Me.CalculateResultButton.Size = New System.Drawing.Size(49, 44)
        Me.CalculateResultButton.TabIndex = 11
        Me.CalculateResultButton.Text = "="
        Me.CalculateResultButton.UseVisualStyleBackColor = False
        '
        'ButtonAddition
        '
        Me.ButtonAddition.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonAddition.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonAddition.Location = New System.Drawing.Point(231, 64)
        Me.ButtonAddition.Name = "ButtonAddition"
        Me.ButtonAddition.Size = New System.Drawing.Size(48, 44)
        Me.ButtonAddition.TabIndex = 12
        Me.ButtonAddition.Text = "+"
        Me.ButtonAddition.UseVisualStyleBackColor = False
        '
        'ButtonSubtraction
        '
        Me.ButtonSubtraction.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonSubtraction.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSubtraction.Location = New System.Drawing.Point(231, 114)
        Me.ButtonSubtraction.Name = "ButtonSubtraction"
        Me.ButtonSubtraction.Size = New System.Drawing.Size(48, 44)
        Me.ButtonSubtraction.TabIndex = 13
        Me.ButtonSubtraction.Text = "-"
        Me.ButtonSubtraction.UseVisualStyleBackColor = False
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonMultiply.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonMultiply.Location = New System.Drawing.Point(231, 164)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(48, 44)
        Me.ButtonMultiply.TabIndex = 14
        Me.ButtonMultiply.Text = "x"
        Me.ButtonMultiply.UseVisualStyleBackColor = False
        '
        'ButtonDivision
        '
        Me.ButtonDivision.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonDivision.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonDivision.Location = New System.Drawing.Point(231, 214)
        Me.ButtonDivision.Name = "ButtonDivision"
        Me.ButtonDivision.Size = New System.Drawing.Size(48, 44)
        Me.ButtonDivision.TabIndex = 15
        Me.ButtonDivision.Text = "÷"
        Me.ButtonDivision.UseVisualStyleBackColor = False
        '
        'CalculatorGroupBox
        '
        Me.CalculatorGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalculatorGroupBox.Controls.Add(Me.BackspaceButton)
        Me.CalculatorGroupBox.Controls.Add(Me.DeleteButton)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonSeven)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonDivision)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonZero)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonMultiply)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonOne)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonSubtraction)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonFour)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonAddition)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonEight)
        Me.CalculatorGroupBox.Controls.Add(Me.CalculateResultButton)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonFive)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonThree)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonTwo)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonSix)
        Me.CalculatorGroupBox.Controls.Add(Me.DecimalButton)
        Me.CalculatorGroupBox.Controls.Add(Me.ButtonNine)
        Me.CalculatorGroupBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CalculatorGroupBox.Location = New System.Drawing.Point(12, 149)
        Me.CalculatorGroupBox.Name = "CalculatorGroupBox"
        Me.CalculatorGroupBox.Size = New System.Drawing.Size(285, 269)
        Me.CalculatorGroupBox.TabIndex = 16
        Me.CalculatorGroupBox.TabStop = False
        '
        'BackspaceButton
        '
        Me.BackspaceButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackspaceButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BackspaceButton.Location = New System.Drawing.Point(88, 14)
        Me.BackspaceButton.Name = "BackspaceButton"
        Me.BackspaceButton.Size = New System.Drawing.Size(48, 44)
        Me.BackspaceButton.TabIndex = 17
        Me.BackspaceButton.Text = "⌫"
        Me.BackspaceButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DeleteButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteButton.Location = New System.Drawing.Point(157, 14)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(122, 44)
        Me.DeleteButton.TabIndex = 16
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'DisplayResultLabel
        '
        Me.DisplayResultLabel.AutoSize = True
        Me.DisplayResultLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DisplayResultLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DisplayResultLabel.Location = New System.Drawing.Point(12, 59)
        Me.DisplayResultLabel.Name = "DisplayResultLabel"
        Me.DisplayResultLabel.Size = New System.Drawing.Size(29, 32)
        Me.DisplayResultLabel.TabIndex = 17
        Me.DisplayResultLabel.Text = "0"
        Me.DisplayResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(309, 450)
        Me.Controls.Add(Me.DisplayResultLabel)
        Me.Controls.Add(Me.CalculatorGroupBox)
        Me.Name = "Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.CalculatorGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonZero As Button
    Friend WithEvents ButtonOne As Button
    Friend WithEvents ButtonFour As Button
    Friend WithEvents ButtonSeven As Button
    Friend WithEvents ButtonEight As Button
    Friend WithEvents ButtonFive As Button
    Friend WithEvents ButtonTwo As Button
    Friend WithEvents DecimalButton As Button
    Friend WithEvents ButtonNine As Button
    Friend WithEvents ButtonSix As Button
    Friend WithEvents ButtonThree As Button
    Friend WithEvents CalculateResultButton As Button
    Friend WithEvents ButtonAddition As Button
    Friend WithEvents ButtonSubtraction As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivision As Button
    Friend WithEvents CalculatorGroupBox As GroupBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents DeleteToolTip As ToolTip
    Friend WithEvents ShowResultToolTip As ToolTip
    Friend WithEvents DisplayResultLabel As Label
    Friend WithEvents BackspaceButton As Button
End Class
