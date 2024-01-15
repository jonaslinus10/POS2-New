<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStockIn
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbProdSize = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbProdStock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbProdUnit = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpExDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbProdColor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbProdBrand = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbProdPrice = New System.Windows.Forms.TextBox()
        Me.CbProdType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbProdName = New System.Windows.Forms.TextBox()
        Me.BtnSaveProduct = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbProdStockIn = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(199, 170)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 23)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "Size"
        '
        'TbProdSize
        '
        Me.TbProdSize.BackColor = System.Drawing.Color.Silver
        Me.TbProdSize.Enabled = False
        Me.TbProdSize.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdSize.Location = New System.Drawing.Point(196, 198)
        Me.TbProdSize.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdSize.Name = "TbProdSize"
        Me.TbProdSize.ReadOnly = True
        Me.TbProdSize.Size = New System.Drawing.Size(160, 29)
        Me.TbProdSize.TabIndex = 118
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(24, 294)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 23)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Stock"
        '
        'TbProdStock
        '
        Me.TbProdStock.BackColor = System.Drawing.Color.Silver
        Me.TbProdStock.Enabled = False
        Me.TbProdStock.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdStock.Location = New System.Drawing.Point(21, 318)
        Me.TbProdStock.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdStock.Name = "TbProdStock"
        Me.TbProdStock.ReadOnly = True
        Me.TbProdStock.Size = New System.Drawing.Size(162, 29)
        Me.TbProdStock.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(19, 170)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 20)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Unit of Measurement"
        '
        'CbProdUnit
        '
        Me.CbProdUnit.BackColor = System.Drawing.Color.Silver
        Me.CbProdUnit.Enabled = False
        Me.CbProdUnit.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProdUnit.ForeColor = System.Drawing.Color.Black
        Me.CbProdUnit.FormattingEnabled = True
        Me.CbProdUnit.Items.AddRange(New Object() {"Kilo", "Litre", "Gallon", "Piece", "Meter", "Pack", "Feet", "Length", "Roll"})
        Me.CbProdUnit.Location = New System.Drawing.Point(18, 198)
        Me.CbProdUnit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbProdUnit.Name = "CbProdUnit"
        Me.CbProdUnit.Size = New System.Drawing.Size(167, 29)
        Me.CbProdUnit.TabIndex = 109
        Me.CbProdUnit.Text = "Kilo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(18, 357)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 23)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Expiration Date"
        '
        'DtpExDate
        '
        Me.DtpExDate.CalendarFont = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpExDate.Enabled = False
        Me.DtpExDate.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpExDate.Location = New System.Drawing.Point(14, 384)
        Me.DtpExDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DtpExDate.Name = "DtpExDate"
        Me.DtpExDate.Size = New System.Drawing.Size(340, 27)
        Me.DtpExDate.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(24, 230)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 23)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Color"
        '
        'TbProdColor
        '
        Me.TbProdColor.BackColor = System.Drawing.Color.Silver
        Me.TbProdColor.Enabled = False
        Me.TbProdColor.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdColor.Location = New System.Drawing.Point(19, 254)
        Me.TbProdColor.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdColor.Name = "TbProdColor"
        Me.TbProdColor.ReadOnly = True
        Me.TbProdColor.Size = New System.Drawing.Size(167, 29)
        Me.TbProdColor.TabIndex = 110
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(19, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 23)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Brand"
        '
        'TbProdBrand
        '
        Me.TbProdBrand.BackColor = System.Drawing.Color.Silver
        Me.TbProdBrand.Enabled = False
        Me.TbProdBrand.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdBrand.Location = New System.Drawing.Point(16, 134)
        Me.TbProdBrand.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdBrand.Multiline = True
        Me.TbProdBrand.Name = "TbProdBrand"
        Me.TbProdBrand.ReadOnly = True
        Me.TbProdBrand.Size = New System.Drawing.Size(164, 30)
        Me.TbProdBrand.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(199, 230)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 23)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Price"
        '
        'TbProdPrice
        '
        Me.TbProdPrice.BackColor = System.Drawing.Color.Silver
        Me.TbProdPrice.Enabled = False
        Me.TbProdPrice.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdPrice.Location = New System.Drawing.Point(196, 254)
        Me.TbProdPrice.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdPrice.Name = "TbProdPrice"
        Me.TbProdPrice.Size = New System.Drawing.Size(160, 29)
        Me.TbProdPrice.TabIndex = 105
        Me.TbProdPrice.Text = "0"
        '
        'CbProdType
        '
        Me.CbProdType.BackColor = System.Drawing.Color.Silver
        Me.CbProdType.Enabled = False
        Me.CbProdType.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProdType.ForeColor = System.Drawing.Color.Black
        Me.CbProdType.FormattingEnabled = True
        Me.CbProdType.Location = New System.Drawing.Point(194, 133)
        Me.CbProdType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbProdType.Name = "CbProdType"
        Me.CbProdType.Size = New System.Drawing.Size(164, 29)
        Me.CbProdType.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(199, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 23)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Item Name"
        '
        'TbProdName
        '
        Me.TbProdName.BackColor = System.Drawing.Color.Silver
        Me.TbProdName.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdName.Location = New System.Drawing.Point(16, 73)
        Me.TbProdName.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdName.Name = "TbProdName"
        Me.TbProdName.ReadOnly = True
        Me.TbProdName.Size = New System.Drawing.Size(340, 29)
        Me.TbProdName.TabIndex = 101
        '
        'BtnSaveProduct
        '
        Me.BtnSaveProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveProduct.FlatAppearance.BorderSize = 0
        Me.BtnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveProduct.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSaveProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSaveProduct.Location = New System.Drawing.Point(98, 427)
        Me.BtnSaveProduct.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnSaveProduct.Name = "BtnSaveProduct"
        Me.BtnSaveProduct.Size = New System.Drawing.Size(171, 44)
        Me.BtnSaveProduct.TabIndex = 100
        Me.BtnSaveProduct.Text = "Proceed"
        Me.BtnSaveProduct.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 37)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Stock In Item"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(199, 294)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 23)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "Stock In"
        '
        'TbProdStockIn
        '
        Me.TbProdStockIn.BackColor = System.Drawing.Color.White
        Me.TbProdStockIn.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdStockIn.Location = New System.Drawing.Point(196, 318)
        Me.TbProdStockIn.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdStockIn.Name = "TbProdStockIn"
        Me.TbProdStockIn.Size = New System.Drawing.Size(160, 29)
        Me.TbProdStockIn.TabIndex = 120
        Me.TbProdStockIn.Text = "1"
        Me.TbProdStockIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(316, 2)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(56, 52)
        Me.BtnExit.TabIndex = 99
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FormStockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(373, 480)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TbProdStockIn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TbProdSize)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbProdStock)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbProdUnit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtpExDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TbProdColor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbProdBrand)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbProdPrice)
        Me.Controls.Add(Me.CbProdType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbProdName)
        Me.Controls.Add(Me.BtnSaveProduct)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormStockIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormStockIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents TbProdSize As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbProdStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbProdUnit As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpExDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TbProdColor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbProdBrand As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbProdPrice As TextBox
    Friend WithEvents CbProdType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbProdName As TextBox
    Friend WithEvents BtnSaveProduct As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TbProdStockIn As TextBox
End Class
