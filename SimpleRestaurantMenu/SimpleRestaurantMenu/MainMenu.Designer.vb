<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListMenuGroupBox = New System.Windows.Forms.GroupBox()
        Me.WagyuCheckBox = New System.Windows.Forms.CheckBox()
        Me.ChickenWingCheckBox = New System.Windows.Forms.CheckBox()
        Me.CheesePizzaCheckBox = New System.Windows.Forms.CheckBox()
        Me.ChipsBurgerCheckBox = New System.Windows.Forms.CheckBox()
        Me.FriedRiceCheckBox = New System.Windows.Forms.CheckBox()
        Me.WagyuAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ChickenWingAmountTextBox = New System.Windows.Forms.TextBox()
        Me.CheesePizzaAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ChipsBurgerAmountTextBox = New System.Windows.Forms.TextBox()
        Me.FriedRiceAmountTextBox = New System.Windows.Forms.TextBox()
        Me.WagyuLabel = New System.Windows.Forms.Label()
        Me.ChickenWingLabel = New System.Windows.Forms.Label()
        Me.CheesePizzaLabel = New System.Windows.Forms.Label()
        Me.ChipsBurgerLabel = New System.Windows.Forms.Label()
        Me.FriedRicePriceLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OrderListBox = New System.Windows.Forms.ListBox()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.PaymentGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalPaymentLabel = New System.Windows.Forms.Label()
        Me.FriedRiceToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ChipsBurgerTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheesePizzaToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ChickenWingToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.WagyuToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListMenuGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PaymentGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(279, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Restaurant Menu"
        '
        'ListMenuGroupBox
        '
        Me.ListMenuGroupBox.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ListMenuGroupBox.Controls.Add(Me.WagyuCheckBox)
        Me.ListMenuGroupBox.Controls.Add(Me.ChickenWingCheckBox)
        Me.ListMenuGroupBox.Controls.Add(Me.CheesePizzaCheckBox)
        Me.ListMenuGroupBox.Controls.Add(Me.ChipsBurgerCheckBox)
        Me.ListMenuGroupBox.Controls.Add(Me.FriedRiceCheckBox)
        Me.ListMenuGroupBox.Controls.Add(Me.WagyuAmountTextBox)
        Me.ListMenuGroupBox.Controls.Add(Me.ChickenWingAmountTextBox)
        Me.ListMenuGroupBox.Controls.Add(Me.CheesePizzaAmountTextBox)
        Me.ListMenuGroupBox.Controls.Add(Me.ChipsBurgerAmountTextBox)
        Me.ListMenuGroupBox.Controls.Add(Me.FriedRiceAmountTextBox)
        Me.ListMenuGroupBox.Controls.Add(Me.WagyuLabel)
        Me.ListMenuGroupBox.Controls.Add(Me.ChickenWingLabel)
        Me.ListMenuGroupBox.Controls.Add(Me.CheesePizzaLabel)
        Me.ListMenuGroupBox.Controls.Add(Me.ChipsBurgerLabel)
        Me.ListMenuGroupBox.Controls.Add(Me.FriedRicePriceLabel)
        Me.ListMenuGroupBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ListMenuGroupBox.Location = New System.Drawing.Point(62, 71)
        Me.ListMenuGroupBox.Name = "ListMenuGroupBox"
        Me.ListMenuGroupBox.Size = New System.Drawing.Size(307, 252)
        Me.ListMenuGroupBox.TabIndex = 1
        Me.ListMenuGroupBox.TabStop = False
        Me.ListMenuGroupBox.Text = "List Menu"
        '
        'WagyuCheckBox
        '
        Me.WagyuCheckBox.AutoSize = True
        Me.WagyuCheckBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WagyuCheckBox.Location = New System.Drawing.Point(6, 211)
        Me.WagyuCheckBox.Name = "WagyuCheckBox"
        Me.WagyuCheckBox.Size = New System.Drawing.Size(100, 20)
        Me.WagyuCheckBox.TabIndex = 15
        Me.WagyuCheckBox.Text = "Wagyu A10s"
        Me.WagyuCheckBox.UseVisualStyleBackColor = True
        '
        'ChickenWingCheckBox
        '
        Me.ChickenWingCheckBox.AutoSize = True
        Me.ChickenWingCheckBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChickenWingCheckBox.Location = New System.Drawing.Point(6, 166)
        Me.ChickenWingCheckBox.Name = "ChickenWingCheckBox"
        Me.ChickenWingCheckBox.Size = New System.Drawing.Size(107, 20)
        Me.ChickenWingCheckBox.TabIndex = 14
        Me.ChickenWingCheckBox.Text = "Chicken Wing"
        Me.ChickenWingCheckBox.UseVisualStyleBackColor = True
        '
        'CheesePizzaCheckBox
        '
        Me.CheesePizzaCheckBox.AutoSize = True
        Me.CheesePizzaCheckBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheesePizzaCheckBox.Location = New System.Drawing.Point(6, 118)
        Me.CheesePizzaCheckBox.Name = "CheesePizzaCheckBox"
        Me.CheesePizzaCheckBox.Size = New System.Drawing.Size(107, 20)
        Me.CheesePizzaCheckBox.TabIndex = 13
        Me.CheesePizzaCheckBox.Text = "Cheese Pizza"
        Me.CheesePizzaCheckBox.UseVisualStyleBackColor = True
        '
        'ChipsBurgerCheckBox
        '
        Me.ChipsBurgerCheckBox.AutoSize = True
        Me.ChipsBurgerCheckBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChipsBurgerCheckBox.Location = New System.Drawing.Point(6, 74)
        Me.ChipsBurgerCheckBox.Name = "ChipsBurgerCheckBox"
        Me.ChipsBurgerCheckBox.Size = New System.Drawing.Size(101, 20)
        Me.ChipsBurgerCheckBox.TabIndex = 12
        Me.ChipsBurgerCheckBox.Text = "Chips Burger"
        Me.ChipsBurgerCheckBox.UseVisualStyleBackColor = True
        '
        'FriedRiceCheckBox
        '
        Me.FriedRiceCheckBox.AutoSize = True
        Me.FriedRiceCheckBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FriedRiceCheckBox.Location = New System.Drawing.Point(6, 36)
        Me.FriedRiceCheckBox.Name = "FriedRiceCheckBox"
        Me.FriedRiceCheckBox.Size = New System.Drawing.Size(85, 20)
        Me.FriedRiceCheckBox.TabIndex = 11
        Me.FriedRiceCheckBox.Text = "Fried Rice"
        Me.FriedRiceCheckBox.UseVisualStyleBackColor = True
        '
        'WagyuAmountTextBox
        '
        Me.WagyuAmountTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WagyuAmountTextBox.Location = New System.Drawing.Point(244, 211)
        Me.WagyuAmountTextBox.Name = "WagyuAmountTextBox"
        Me.WagyuAmountTextBox.Size = New System.Drawing.Size(36, 22)
        Me.WagyuAmountTextBox.TabIndex = 10
        '
        'ChickenWingAmountTextBox
        '
        Me.ChickenWingAmountTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChickenWingAmountTextBox.Location = New System.Drawing.Point(244, 162)
        Me.ChickenWingAmountTextBox.Name = "ChickenWingAmountTextBox"
        Me.ChickenWingAmountTextBox.Size = New System.Drawing.Size(36, 22)
        Me.ChickenWingAmountTextBox.TabIndex = 2
        '
        'CheesePizzaAmountTextBox
        '
        Me.CheesePizzaAmountTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheesePizzaAmountTextBox.Location = New System.Drawing.Point(244, 118)
        Me.CheesePizzaAmountTextBox.Name = "CheesePizzaAmountTextBox"
        Me.CheesePizzaAmountTextBox.Size = New System.Drawing.Size(36, 22)
        Me.CheesePizzaAmountTextBox.TabIndex = 9
        '
        'ChipsBurgerAmountTextBox
        '
        Me.ChipsBurgerAmountTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChipsBurgerAmountTextBox.Location = New System.Drawing.Point(244, 70)
        Me.ChipsBurgerAmountTextBox.Name = "ChipsBurgerAmountTextBox"
        Me.ChipsBurgerAmountTextBox.Size = New System.Drawing.Size(36, 22)
        Me.ChipsBurgerAmountTextBox.TabIndex = 8
        '
        'FriedRiceAmountTextBox
        '
        Me.FriedRiceAmountTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FriedRiceAmountTextBox.Location = New System.Drawing.Point(244, 34)
        Me.FriedRiceAmountTextBox.Name = "FriedRiceAmountTextBox"
        Me.FriedRiceAmountTextBox.Size = New System.Drawing.Size(36, 22)
        Me.FriedRiceAmountTextBox.TabIndex = 7
        '
        'WagyuLabel
        '
        Me.WagyuLabel.AutoSize = True
        Me.WagyuLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WagyuLabel.Location = New System.Drawing.Point(166, 211)
        Me.WagyuLabel.Name = "WagyuLabel"
        Me.WagyuLabel.Size = New System.Drawing.Size(73, 16)
        Me.WagyuLabel.TabIndex = 6
        Me.WagyuLabel.Text = "Rp 100.000"
        '
        'ChickenWingLabel
        '
        Me.ChickenWingLabel.AutoSize = True
        Me.ChickenWingLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChickenWingLabel.Location = New System.Drawing.Point(166, 166)
        Me.ChickenWingLabel.Name = "ChickenWingLabel"
        Me.ChickenWingLabel.Size = New System.Drawing.Size(66, 16)
        Me.ChickenWingLabel.TabIndex = 2
        Me.ChickenWingLabel.Text = "Rp 65.000"
        '
        'CheesePizzaLabel
        '
        Me.CheesePizzaLabel.AutoSize = True
        Me.CheesePizzaLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheesePizzaLabel.Location = New System.Drawing.Point(166, 122)
        Me.CheesePizzaLabel.Name = "CheesePizzaLabel"
        Me.CheesePizzaLabel.Size = New System.Drawing.Size(66, 16)
        Me.CheesePizzaLabel.TabIndex = 2
        Me.CheesePizzaLabel.Text = "Rp 70.000"
        '
        'ChipsBurgerLabel
        '
        Me.ChipsBurgerLabel.AutoSize = True
        Me.ChipsBurgerLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChipsBurgerLabel.Location = New System.Drawing.Point(166, 74)
        Me.ChipsBurgerLabel.Name = "ChipsBurgerLabel"
        Me.ChipsBurgerLabel.Size = New System.Drawing.Size(66, 16)
        Me.ChipsBurgerLabel.TabIndex = 5
        Me.ChipsBurgerLabel.Text = "Rp 45.000"
        '
        'FriedRicePriceLabel
        '
        Me.FriedRicePriceLabel.AutoSize = True
        Me.FriedRicePriceLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FriedRicePriceLabel.Location = New System.Drawing.Point(166, 35)
        Me.FriedRicePriceLabel.Name = "FriedRicePriceLabel"
        Me.FriedRicePriceLabel.Size = New System.Drawing.Size(66, 16)
        Me.FriedRicePriceLabel.TabIndex = 2
        Me.FriedRicePriceLabel.Text = "Rp 50.000"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox1.Controls.Add(Me.OrderListBox)
        Me.GroupBox1.Controls.Add(Me.ShowButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(490, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 252)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Recap"
        '
        'OrderListBox
        '
        Me.OrderListBox.FormattingEnabled = True
        Me.OrderListBox.ItemHeight = 16
        Me.OrderListBox.Location = New System.Drawing.Point(19, 21)
        Me.OrderListBox.Name = "OrderListBox"
        Me.OrderListBox.Size = New System.Drawing.Size(240, 180)
        Me.OrderListBox.TabIndex = 5
        '
        'ShowButton
        '
        Me.ShowButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowButton.Location = New System.Drawing.Point(19, 211)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 34)
        Me.ShowButton.TabIndex = 0
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox2.Controls.Add(Me.ExitButton)
        Me.GroupBox2.Controls.Add(Me.ResetButton)
        Me.GroupBox2.Controls.Add(Me.CalculateButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(62, 356)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 70)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Process "
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.Location = New System.Drawing.Point(205, 33)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 25)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetButton.Location = New System.Drawing.Point(108, 33)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 25)
        Me.ResetButton.TabIndex = 1
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CalculateButton.Location = New System.Drawing.Point(6, 33)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 25)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'PaymentGroupBox
        '
        Me.PaymentGroupBox.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PaymentGroupBox.Controls.Add(Me.TotalPaymentLabel)
        Me.PaymentGroupBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PaymentGroupBox.Location = New System.Drawing.Point(490, 369)
        Me.PaymentGroupBox.Name = "PaymentGroupBox"
        Me.PaymentGroupBox.Size = New System.Drawing.Size(276, 58)
        Me.PaymentGroupBox.TabIndex = 4
        Me.PaymentGroupBox.TabStop = False
        Me.PaymentGroupBox.Text = "Payment"
        '
        'TotalPaymentLabel
        '
        Me.TotalPaymentLabel.AutoSize = True
        Me.TotalPaymentLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalPaymentLabel.Location = New System.Drawing.Point(6, 29)
        Me.TotalPaymentLabel.Name = "TotalPaymentLabel"
        Me.TotalPaymentLabel.Size = New System.Drawing.Size(114, 16)
        Me.TotalPaymentLabel.TabIndex = 0
        Me.TotalPaymentLabel.Text = "Total Payment: Rp"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 463)
        Me.Controls.Add(Me.PaymentGroupBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListMenuGroupBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ListMenuGroupBox.ResumeLayout(False)
        Me.ListMenuGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.PaymentGroupBox.ResumeLayout(False)
        Me.PaymentGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListMenuGroupBox As GroupBox
    Friend WithEvents WagyuLabel As Label
    Friend WithEvents ChickenWingLabel As Label
    Friend WithEvents CheesePizzaLabel As Label
    Friend WithEvents ChipsBurgerLabel As Label
    Friend WithEvents FriedRicePriceLabel As Label
    Friend WithEvents WagyuAmountTextBox As TextBox
    Friend WithEvents ChickenWingAmountTextBox As TextBox
    Friend WithEvents CheesePizzaAmountTextBox As TextBox
    Friend WithEvents ChipsBurgerAmountTextBox As TextBox
    Friend WithEvents FriedRiceAmountTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ShowButton As Button
    Friend WithEvents PaymentGroupBox As GroupBox
    Friend WithEvents TotalPaymentLabel As Label
    Friend WithEvents FriedRiceToolTip As ToolTip
    Friend WithEvents ChipsBurgerTooltip As ToolTip
    Friend WithEvents CheesePizzaToolTip As ToolTip
    Friend WithEvents ChickenWingToolTip As ToolTip
    Friend WithEvents WagyuToolTip As ToolTip
    Friend WithEvents WagyuCheckBox As CheckBox
    Friend WithEvents ChickenWingCheckBox As CheckBox
    Friend WithEvents CheesePizzaCheckBox As CheckBox
    Friend WithEvents ChipsBurgerCheckBox As CheckBox
    Friend WithEvents FriedRiceCheckBox As CheckBox
    Friend WithEvents OrderListBox As ListBox
End Class
