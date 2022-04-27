<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyForm
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
        Me.NoRegistrationTextBox = New System.Windows.Forms.TextBox()
        Me.NameRegisterTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PlaceOfBirthTextBox = New System.Windows.Forms.TextBox()
        Me.ListViewRegistration = New System.Windows.Forms.ListView()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NoRegistrationLabel = New System.Windows.Forms.Label()
        Me.NameRegisterLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.PlaceOfBirthLabel = New System.Windows.Forms.Label()
        Me.DateOfBirthLabel = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ResultConsultantRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TotalPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TotalPaymentLabel = New System.Windows.Forms.Label()
        Me.ResultConsultantLabel = New System.Windows.Forms.Label()
        Me.PriceConsultantLabel = New System.Windows.Forms.Label()
        Me.PriceConsultantTextBox = New System.Windows.Forms.TextBox()
        Me.BPJSLabel = New System.Windows.Forms.Label()
        Me.BPJSNo = New System.Windows.Forms.RadioButton()
        Me.BPJSYes = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(270, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KLINIK GRAHA MEDIKA"
        '
        'NoRegistrationTextBox
        '
        Me.NoRegistrationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoRegistrationTextBox.Location = New System.Drawing.Point(118, 62)
        Me.NoRegistrationTextBox.Name = "NoRegistrationTextBox"
        Me.NoRegistrationTextBox.Size = New System.Drawing.Size(46, 23)
        Me.NoRegistrationTextBox.TabIndex = 1
        '
        'NameRegisterTextBox
        '
        Me.NameRegisterTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NameRegisterTextBox.Location = New System.Drawing.Point(118, 104)
        Me.NameRegisterTextBox.Name = "NameRegisterTextBox"
        Me.NameRegisterTextBox.Size = New System.Drawing.Size(200, 23)
        Me.NameRegisterTextBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddressTextBox.Location = New System.Drawing.Point(118, 149)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 23)
        Me.AddressTextBox.TabIndex = 3
        '
        'PlaceOfBirthTextBox
        '
        Me.PlaceOfBirthTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PlaceOfBirthTextBox.Location = New System.Drawing.Point(118, 192)
        Me.PlaceOfBirthTextBox.Name = "PlaceOfBirthTextBox"
        Me.PlaceOfBirthTextBox.Size = New System.Drawing.Size(200, 23)
        Me.PlaceOfBirthTextBox.TabIndex = 4
        '
        'ListViewRegistration
        '
        Me.ListViewRegistration.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListViewRegistration.Location = New System.Drawing.Point(12, 282)
        Me.ListViewRegistration.Name = "ListViewRegistration"
        Me.ListViewRegistration.Size = New System.Drawing.Size(306, 146)
        Me.ListViewRegistration.TabIndex = 5
        Me.ListViewRegistration.UseCompatibleStateImageBehavior = False
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(118, 234)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.DateOfBirthDateTimePicker.TabIndex = 6
        '
        'NoRegistrationLabel
        '
        Me.NoRegistrationLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NoRegistrationLabel.AutoSize = True
        Me.NoRegistrationLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NoRegistrationLabel.Location = New System.Drawing.Point(12, 63)
        Me.NoRegistrationLabel.Name = "NoRegistrationLabel"
        Me.NoRegistrationLabel.Size = New System.Drawing.Size(100, 17)
        Me.NoRegistrationLabel.TabIndex = 7
        Me.NoRegistrationLabel.Text = "No Pendaftaran"
        '
        'NameRegisterLabel
        '
        Me.NameRegisterLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NameRegisterLabel.AutoSize = True
        Me.NameRegisterLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameRegisterLabel.Location = New System.Drawing.Point(12, 104)
        Me.NameRegisterLabel.Name = "NameRegisterLabel"
        Me.NameRegisterLabel.Size = New System.Drawing.Size(103, 17)
        Me.NameRegisterLabel.TabIndex = 8
        Me.NameRegisterLabel.Text = "Nama Pendaftar"
        '
        'AddressLabel
        '
        Me.AddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddressLabel.Location = New System.Drawing.Point(12, 150)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(48, 17)
        Me.AddressLabel.TabIndex = 9
        Me.AddressLabel.Text = "Alamat"
        '
        'PlaceOfBirthLabel
        '
        Me.PlaceOfBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PlaceOfBirthLabel.AutoSize = True
        Me.PlaceOfBirthLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PlaceOfBirthLabel.Location = New System.Drawing.Point(12, 193)
        Me.PlaceOfBirthLabel.Name = "PlaceOfBirthLabel"
        Me.PlaceOfBirthLabel.Size = New System.Drawing.Size(83, 17)
        Me.PlaceOfBirthLabel.TabIndex = 10
        Me.PlaceOfBirthLabel.Text = "Tempat Lahir"
        '
        'DateOfBirthLabel
        '
        Me.DateOfBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateOfBirthLabel.AutoSize = True
        Me.DateOfBirthLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateOfBirthLabel.Location = New System.Drawing.Point(12, 238)
        Me.DateOfBirthLabel.Name = "DateOfBirthLabel"
        Me.DateOfBirthLabel.Size = New System.Drawing.Size(83, 17)
        Me.DateOfBirthLabel.TabIndex = 11
        Me.DateOfBirthLabel.Text = "Tanggal lahir"
        '
        'AddButton
        '
        Me.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddButton.Location = New System.Drawing.Point(335, 282)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 35)
        Me.AddButton.TabIndex = 12
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ClearButton.Location = New System.Drawing.Point(335, 340)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 35)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CloseButton.Location = New System.Drawing.Point(335, 393)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 35)
        Me.CloseButton.TabIndex = 14
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.ResultConsultantRichTextBox)
        Me.GroupBox1.Controls.Add(Me.TotalPaymentTextBox)
        Me.GroupBox1.Controls.Add(Me.CalculateButton)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.TotalPaymentLabel)
        Me.GroupBox1.Controls.Add(Me.ResultConsultantLabel)
        Me.GroupBox1.Controls.Add(Me.PriceConsultantLabel)
        Me.GroupBox1.Controls.Add(Me.PriceConsultantTextBox)
        Me.GroupBox1.Controls.Add(Me.BPJSLabel)
        Me.GroupBox1.Controls.Add(Me.BPJSNo)
        Me.GroupBox1.Controls.Add(Me.BPJSYes)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(426, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 333)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Perhitungan Pembayaran"
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DeleteButton.Location = New System.Drawing.Point(281, 298)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 35)
        Me.DeleteButton.TabIndex = 16
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ResultConsultantRichTextBox
        '
        Me.ResultConsultantRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ResultConsultantRichTextBox.Location = New System.Drawing.Point(15, 130)
        Me.ResultConsultantRichTextBox.Name = "ResultConsultantRichTextBox"
        Me.ResultConsultantRichTextBox.Size = New System.Drawing.Size(248, 96)
        Me.ResultConsultantRichTextBox.TabIndex = 12
        Me.ResultConsultantRichTextBox.Text = ""
        '
        'TotalPaymentTextBox
        '
        Me.TotalPaymentTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TotalPaymentTextBox.Location = New System.Drawing.Point(110, 277)
        Me.TotalPaymentTextBox.Name = "TotalPaymentTextBox"
        Me.TotalPaymentTextBox.Size = New System.Drawing.Size(153, 25)
        Me.TotalPaymentTextBox.TabIndex = 10
        '
        'CalculateButton
        '
        Me.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CalculateButton.Location = New System.Drawing.Point(281, 158)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 34)
        Me.CalculateButton.TabIndex = 9
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SaveButton.Location = New System.Drawing.Point(281, 250)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 34)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TotalPaymentLabel
        '
        Me.TotalPaymentLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TotalPaymentLabel.AutoSize = True
        Me.TotalPaymentLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalPaymentLabel.Location = New System.Drawing.Point(22, 279)
        Me.TotalPaymentLabel.Name = "TotalPaymentLabel"
        Me.TotalPaymentLabel.Size = New System.Drawing.Size(82, 17)
        Me.TotalPaymentLabel.TabIndex = 7
        Me.TotalPaymentLabel.Text = "Jumlah Biaya"
        '
        'ResultConsultantLabel
        '
        Me.ResultConsultantLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ResultConsultantLabel.AutoSize = True
        Me.ResultConsultantLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultConsultantLabel.Location = New System.Drawing.Point(15, 102)
        Me.ResultConsultantLabel.Name = "ResultConsultantLabel"
        Me.ResultConsultantLabel.Size = New System.Drawing.Size(148, 17)
        Me.ResultConsultantLabel.TabIndex = 5
        Me.ResultConsultantLabel.Text = "Hasil Konsultasi / Resep"
        '
        'PriceConsultantLabel
        '
        Me.PriceConsultantLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PriceConsultantLabel.AutoSize = True
        Me.PriceConsultantLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PriceConsultantLabel.Location = New System.Drawing.Point(15, 66)
        Me.PriceConsultantLabel.Name = "PriceConsultantLabel"
        Me.PriceConsultantLabel.Size = New System.Drawing.Size(124, 17)
        Me.PriceConsultantLabel.TabIndex = 4
        Me.PriceConsultantLabel.Text = "Biaya Konsultasi Rp."
        '
        'PriceConsultantTextBox
        '
        Me.PriceConsultantTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PriceConsultantTextBox.Location = New System.Drawing.Point(145, 66)
        Me.PriceConsultantTextBox.Name = "PriceConsultantTextBox"
        Me.PriceConsultantTextBox.Size = New System.Drawing.Size(122, 25)
        Me.PriceConsultantTextBox.TabIndex = 3
        '
        'BPJSLabel
        '
        Me.BPJSLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BPJSLabel.AutoSize = True
        Me.BPJSLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BPJSLabel.Location = New System.Drawing.Point(15, 26)
        Me.BPJSLabel.Name = "BPJSLabel"
        Me.BPJSLabel.Size = New System.Drawing.Size(91, 17)
        Me.BPJSLabel.TabIndex = 2
        Me.BPJSLabel.Text = "Penerima BPJS"
        '
        'BPJSNo
        '
        Me.BPJSNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BPJSNo.AutoSize = True
        Me.BPJSNo.Location = New System.Drawing.Point(210, 26)
        Me.BPJSNo.Name = "BPJSNo"
        Me.BPJSNo.Size = New System.Drawing.Size(57, 21)
        Me.BPJSNo.TabIndex = 1
        Me.BPJSNo.TabStop = True
        Me.BPJSNo.Text = "Tidak"
        Me.BPJSNo.UseVisualStyleBackColor = True
        '
        'BPJSYes
        '
        Me.BPJSYes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BPJSYes.AutoSize = True
        Me.BPJSYes.Location = New System.Drawing.Point(151, 26)
        Me.BPJSYes.Name = "BPJSYes"
        Me.BPJSYes.Size = New System.Drawing.Size(39, 21)
        Me.BPJSYes.TabIndex = 0
        Me.BPJSYes.TabStop = True
        Me.BPJSYes.Text = "Ya"
        Me.BPJSYes.UseVisualStyleBackColor = True
        '
        'MyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.DateOfBirthLabel)
        Me.Controls.Add(Me.PlaceOfBirthLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.NameRegisterLabel)
        Me.Controls.Add(Me.NoRegistrationLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(Me.ListViewRegistration)
        Me.Controls.Add(Me.PlaceOfBirthTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.NameRegisterTextBox)
        Me.Controls.Add(Me.NoRegistrationTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MyForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KLINIK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NoRegistrationTextBox As TextBox
    Friend WithEvents NameRegisterTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PlaceOfBirthTextBox As TextBox
    Friend WithEvents ListViewRegistration As ListView
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents NoRegistrationLabel As Label
    Friend WithEvents NameRegisterLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents PlaceOfBirthLabel As Label
    Friend WithEvents DateOfBirthLabel As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TotalPaymentTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents TotalPaymentLabel As Label
    Friend WithEvents ResultConsultantLabel As Label
    Friend WithEvents PriceConsultantLabel As Label
    Friend WithEvents PriceConsultantTextBox As TextBox
    Friend WithEvents BPJSLabel As Label
    Friend WithEvents BPJSNo As RadioButton
    Friend WithEvents BPJSYes As RadioButton
    Friend WithEvents ResultConsultantRichTextBox As RichTextBox
    Friend WithEvents DeleteButton As Button
End Class
