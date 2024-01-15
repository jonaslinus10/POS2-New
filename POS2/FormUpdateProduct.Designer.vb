<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUpdateProduct
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
        Me.BtnSaveProduct = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbProdPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbProdType = New System.Windows.Forms.ComboBox()
        Me.TbProdBrand = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbProdName = New System.Windows.Forms.TextBox()
        Me.TbProdColor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbProdUnit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbProdStock = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbProdSize = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DtpExDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbProdCriticalStockLimit = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnSaveProduct
        '
        Me.BtnSaveProduct.BackColor = System.Drawing.Color.DarkRed
        Me.BtnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveProduct.FlatAppearance.BorderSize = 0
        Me.BtnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveProduct.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveProduct.ForeColor = System.Drawing.Color.White
        Me.BtnSaveProduct.Location = New System.Drawing.Point(109, 452)
        Me.BtnSaveProduct.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnSaveProduct.Name = "BtnSaveProduct"
        Me.BtnSaveProduct.Size = New System.Drawing.Size(171, 44)
        Me.BtnSaveProduct.TabIndex = 78
        Me.BtnSaveProduct.Text = "Proceed"
        Me.BtnSaveProduct.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(318, 2)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(56, 52)
        Me.BtnExit.TabIndex = 77
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 37)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Update Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(19, 228)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 23)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Price"
        '
        'TbProdPrice
        '
        Me.TbProdPrice.BackColor = System.Drawing.Color.White
        Me.TbProdPrice.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdPrice.Location = New System.Drawing.Point(16, 252)
        Me.TbProdPrice.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdPrice.Name = "TbProdPrice"
        Me.TbProdPrice.Size = New System.Drawing.Size(108, 29)
        Me.TbProdPrice.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(18, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(19, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Item Type"
        '
        'CbProdType
        '
        Me.CbProdType.BackColor = System.Drawing.Color.Silver
        Me.CbProdType.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProdType.ForeColor = System.Drawing.Color.Black
        Me.CbProdType.FormattingEnabled = True
        Me.CbProdType.Location = New System.Drawing.Point(16, 194)
        Me.CbProdType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbProdType.Name = "CbProdType"
        Me.CbProdType.Size = New System.Drawing.Size(164, 29)
        Me.CbProdType.TabIndex = 82
        '
        'TbProdBrand
        '
        Me.TbProdBrand.BackColor = System.Drawing.Color.Silver
        Me.TbProdBrand.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdBrand.Location = New System.Drawing.Point(16, 134)
        Me.TbProdBrand.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdBrand.Multiline = True
        Me.TbProdBrand.Name = "TbProdBrand"
        Me.TbProdBrand.ReadOnly = True
        Me.TbProdBrand.Size = New System.Drawing.Size(164, 30)
        Me.TbProdBrand.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(19, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 23)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Brand"
        '
        'TbProdName
        '
        Me.TbProdName.BackColor = System.Drawing.Color.Silver
        Me.TbProdName.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdName.Location = New System.Drawing.Point(16, 73)
        Me.TbProdName.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdName.Name = "TbProdName"
        Me.TbProdName.ReadOnly = True
        Me.TbProdName.Size = New System.Drawing.Size(343, 29)
        Me.TbProdName.TabIndex = 79
        '
        'TbProdColor
        '
        Me.TbProdColor.BackColor = System.Drawing.Color.Silver
        Me.TbProdColor.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdColor.Location = New System.Drawing.Point(189, 134)
        Me.TbProdColor.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdColor.Name = "TbProdColor"
        Me.TbProdColor.ReadOnly = True
        Me.TbProdColor.Size = New System.Drawing.Size(169, 29)
        Me.TbProdColor.TabIndex = 88
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(192, 110)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 23)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Color"
        '
        'CbProdUnit
        '
        Me.CbProdUnit.BackColor = System.Drawing.Color.Silver
        Me.CbProdUnit.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProdUnit.ForeColor = System.Drawing.Color.Black
        Me.CbProdUnit.FormattingEnabled = True
        Me.CbProdUnit.Items.AddRange(New Object() {"Kilo", "Litre", "Gallon", "Piece", "Meter", "Pack", "Feet", "Length", "Roll"})
        Me.CbProdUnit.Location = New System.Drawing.Point(189, 194)
        Me.CbProdUnit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbProdUnit.Name = "CbProdUnit"
        Me.CbProdUnit.Size = New System.Drawing.Size(169, 29)
        Me.CbProdUnit.TabIndex = 87
        Me.CbProdUnit.Text = "Kilo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(190, 166)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 23)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Item Unit"
        '
        'TbProdStock
        '
        Me.TbProdStock.BackColor = System.Drawing.Color.Silver
        Me.TbProdStock.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdStock.Location = New System.Drawing.Point(131, 252)
        Me.TbProdStock.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdStock.Name = "TbProdStock"
        Me.TbProdStock.ReadOnly = True
        Me.TbProdStock.Size = New System.Drawing.Size(108, 29)
        Me.TbProdStock.TabIndex = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(133, 228)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 23)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Stock"
        '
        'TbProdSize
        '
        Me.TbProdSize.BackColor = System.Drawing.Color.Silver
        Me.TbProdSize.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdSize.Location = New System.Drawing.Point(248, 252)
        Me.TbProdSize.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdSize.Name = "TbProdSize"
        Me.TbProdSize.ReadOnly = True
        Me.TbProdSize.Size = New System.Drawing.Size(111, 29)
        Me.TbProdSize.TabIndex = 96
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(251, 228)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 23)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Unit Size"
        '
        'DtpExDate
        '
        Me.DtpExDate.Enabled = False
        Me.DtpExDate.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpExDate.Location = New System.Drawing.Point(11, 382)
        Me.DtpExDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DtpExDate.Name = "DtpExDate"
        Me.DtpExDate.Size = New System.Drawing.Size(343, 30)
        Me.DtpExDate.TabIndex = 90
        Me.DtpExDate.Value = New Date(2023, 5, 11, 14, 53, 55, 0)
        Me.DtpExDate.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(12, 356)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 23)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Expiration Date"
        Me.Label6.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(18, 284)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 23)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Critical Stock Limit"
        '
        'TbProdCriticalStockLimit
        '
        Me.TbProdCriticalStockLimit.BackColor = System.Drawing.Color.Silver
        Me.TbProdCriticalStockLimit.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdCriticalStockLimit.Location = New System.Drawing.Point(16, 316)
        Me.TbProdCriticalStockLimit.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdCriticalStockLimit.Name = "TbProdCriticalStockLimit"
        Me.TbProdCriticalStockLimit.ReadOnly = True
        Me.TbProdCriticalStockLimit.Size = New System.Drawing.Size(108, 29)
        Me.TbProdCriticalStockLimit.TabIndex = 98
        '
        'FormUpdateProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(376, 505)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TbProdCriticalStockLimit)
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
        Me.MaximumSize = New System.Drawing.Size(376, 505)
        Me.MinimumSize = New System.Drawing.Size(376, 505)
        Me.Name = "FormUpdateProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdateProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents BtnSaveProduct As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbProdPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbProdType As ComboBox
    Friend WithEvents TbProdBrand As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbProdName As TextBox
    Friend WithEvents TbProdColor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CbProdUnit As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbProdStock As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbProdSize As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DtpExDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TbProdCriticalStockLimit As TextBox
End Class
