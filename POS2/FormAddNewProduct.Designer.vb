<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddNewProduct
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
        Me.BtnSaveProduct = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbProdName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpExDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbProdStock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbProdColor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbProdPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbProdCritStockLimit = New System.Windows.Forms.TextBox()
        Me.CheckBoxDoesExpire = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Length = New System.Windows.Forms.CheckBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.txtThick = New System.Windows.Forms.TextBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.cbThick = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CbProdType = New System.Windows.Forms.ComboBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.cblengthWidth = New System.Windows.Forms.ComboBox()
        Me.cbHeight = New System.Windows.Forms.ComboBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.txtElectricity = New System.Windows.Forms.TextBox()
        Me.cbElectricity = New System.Windows.Forms.ComboBox()
        Me.cbWeight = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbVolume = New System.Windows.Forms.ComboBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.ComboBox()
        Me.TbProdBrand = New System.Windows.Forms.ComboBox()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(15, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Item"
        '
        'BtnSaveProduct
        '
        Me.BtnSaveProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveProduct.Enabled = False
        Me.BtnSaveProduct.FlatAppearance.BorderSize = 0
        Me.BtnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveProduct.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSaveProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSaveProduct.Location = New System.Drawing.Point(19, 475)
        Me.BtnSaveProduct.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnSaveProduct.Name = "BtnSaveProduct"
        Me.BtnSaveProduct.Size = New System.Drawing.Size(266, 68)
        Me.BtnSaveProduct.TabIndex = 55
        Me.BtnSaveProduct.Text = "Add Item Data"
        Me.BtnSaveProduct.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(312, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Brand"
        '
        'TbProdName
        '
        Me.TbProdName.BackColor = System.Drawing.Color.White
        Me.TbProdName.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdName.Location = New System.Drawing.Point(308, 73)
        Me.TbProdName.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TbProdName.Multiline = True
        Me.TbProdName.Name = "TbProdName"
        Me.TbProdName.Size = New System.Drawing.Size(183, 25)
        Me.TbProdName.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(308, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Category"
        '
        'DtpExDate
        '
        Me.DtpExDate.CalendarFont = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpExDate.Enabled = False
        Me.DtpExDate.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpExDate.Location = New System.Drawing.Point(19, 433)
        Me.DtpExDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DtpExDate.Name = "DtpExDate"
        Me.DtpExDate.Size = New System.Drawing.Size(248, 23)
        Me.DtpExDate.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(21, 413)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 19)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Expiration Date"
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(462, 3)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(43, 27)
        Me.BtnExit.TabIndex = 53
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(20, 480)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 19)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Initial Stock"
        Me.Label8.Visible = False
        '
        'TbProdStock
        '
        Me.TbProdStock.BackColor = System.Drawing.Color.White
        Me.TbProdStock.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdStock.Location = New System.Drawing.Point(20, 490)
        Me.TbProdStock.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TbProdStock.Multiline = True
        Me.TbProdStock.Name = "TbProdStock"
        Me.TbProdStock.Size = New System.Drawing.Size(264, 21)
        Me.TbProdStock.TabIndex = 100
        Me.TbProdStock.Text = "0"
        Me.TbProdStock.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(312, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 19)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "Color"
        '
        'TbProdColor
        '
        Me.TbProdColor.BackColor = System.Drawing.Color.White
        Me.TbProdColor.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdColor.Location = New System.Drawing.Point(312, 177)
        Me.TbProdColor.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TbProdColor.Multiline = True
        Me.TbProdColor.Name = "TbProdColor"
        Me.TbProdColor.Size = New System.Drawing.Size(172, 21)
        Me.TbProdColor.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(313, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Price"
        '
        'TbProdPrice
        '
        Me.TbProdPrice.BackColor = System.Drawing.Color.White
        Me.TbProdPrice.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdPrice.Location = New System.Drawing.Point(333, 229)
        Me.TbProdPrice.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TbProdPrice.Multiline = True
        Me.TbProdPrice.Name = "TbProdPrice"
        Me.TbProdPrice.Size = New System.Drawing.Size(151, 23)
        Me.TbProdPrice.TabIndex = 96
        Me.TbProdPrice.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(21, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 20)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Size"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(312, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 19)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Critical Stock Limit"
        '
        'TbProdCritStockLimit
        '
        Me.TbProdCritStockLimit.BackColor = System.Drawing.Color.White
        Me.TbProdCritStockLimit.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdCritStockLimit.Location = New System.Drawing.Point(312, 337)
        Me.TbProdCritStockLimit.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TbProdCritStockLimit.Multiline = True
        Me.TbProdCritStockLimit.Name = "TbProdCritStockLimit"
        Me.TbProdCritStockLimit.Size = New System.Drawing.Size(173, 28)
        Me.TbProdCritStockLimit.TabIndex = 104
        Me.TbProdCritStockLimit.Text = "0"
        '
        'CheckBoxDoesExpire
        '
        Me.CheckBoxDoesExpire.AutoSize = True
        Me.CheckBoxDoesExpire.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxDoesExpire.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.CheckBoxDoesExpire.Location = New System.Drawing.Point(19, 391)
        Me.CheckBoxDoesExpire.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxDoesExpire.Name = "CheckBoxDoesExpire"
        Me.CheckBoxDoesExpire.Size = New System.Drawing.Size(204, 23)
        Me.CheckBoxDoesExpire.TabIndex = 106
        Me.CheckBoxDoesExpire.Text = "Does this product expires?"
        Me.CheckBoxDoesExpire.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(23, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 20)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "Classification"
        '
        'Length
        '
        Me.Length.AutoSize = True
        Me.Length.Enabled = False
        Me.Length.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Length.Location = New System.Drawing.Point(21, 177)
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(67, 38)
        Me.Length.TabIndex = 111
        Me.Length.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Width:"
        Me.Length.ThreeState = True
        Me.Length.UseVisualStyleBackColor = True
        '
        'txtWidth
        '
        Me.txtWidth.BackColor = System.Drawing.Color.White
        Me.txtWidth.Enabled = False
        Me.txtWidth.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWidth.Location = New System.Drawing.Point(103, 195)
        Me.txtWidth.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtWidth.Multiline = True
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(99, 21)
        Me.txtWidth.TabIndex = 112
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox3.Location = New System.Drawing.Point(21, 220)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(72, 21)
        Me.CheckBox3.TabIndex = 115
        Me.CheckBox3.Text = "Height:"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'txtHeight
        '
        Me.txtHeight.BackColor = System.Drawing.Color.White
        Me.txtHeight.Enabled = False
        Me.txtHeight.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(103, 221)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtHeight.Multiline = True
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(99, 24)
        Me.txtHeight.TabIndex = 114
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckBox4.Location = New System.Drawing.Point(21, 248)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(95, 21)
        Me.CheckBox4.TabIndex = 117
        Me.CheckBox4.Text = "Thickness:"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'txtThick
        '
        Me.txtThick.BackColor = System.Drawing.Color.White
        Me.txtThick.Enabled = False
        Me.txtThick.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThick.Location = New System.Drawing.Point(103, 248)
        Me.txtThick.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtThick.Multiline = True
        Me.txtThick.Name = "txtThick"
        Me.txtThick.Size = New System.Drawing.Size(99, 25)
        Me.txtThick.TabIndex = 116
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(21, 275)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(75, 21)
        Me.CheckBox5.TabIndex = 119
        Me.CheckBox5.Text = "Weight:"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.White
        Me.txtWeight.Enabled = False
        Me.txtWeight.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(103, 275)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtWeight.Multiline = True
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(99, 26)
        Me.txtWeight.TabIndex = 118
        '
        'cbThick
        '
        Me.cbThick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThick.Enabled = False
        Me.cbThick.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbThick.ForeColor = System.Drawing.Color.Black
        Me.cbThick.FormattingEnabled = True
        Me.cbThick.ItemHeight = 17
        Me.cbThick.Items.AddRange(New Object() {"cm", "inch", "mm"})
        Me.cbThick.Location = New System.Drawing.Point(207, 248)
        Me.cbThick.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbThick.Name = "cbThick"
        Me.cbThick.Size = New System.Drawing.Size(77, 25)
        Me.cbThick.Sorted = True
        Me.cbThick.TabIndex = 122
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(313, 257)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 19)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "Unit"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.ForeColor = System.Drawing.Color.Black
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.ItemHeight = 17
        Me.ComboBox5.Items.AddRange(New Object() {"Bag", "Elf", "Piece" & Global.Microsoft.VisualBasic.ChrW(9), "Roll"})
        Me.ComboBox5.Location = New System.Drawing.Point(310, 280)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(175, 25)
        Me.ComboBox5.Sorted = True
        Me.ComboBox5.TabIndex = 124
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(32, 490)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 25)
        Me.TextBox1.TabIndex = 126
        Me.TextBox1.Text = "0"
        Me.TextBox1.Visible = False
        '
        'CbProdType
        '
        Me.CbProdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProdType.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProdType.ForeColor = System.Drawing.Color.Black
        Me.CbProdType.FormattingEnabled = True
        Me.CbProdType.Location = New System.Drawing.Point(23, 73)
        Me.CbProdType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbProdType.Name = "CbProdType"
        Me.CbProdType.Size = New System.Drawing.Size(251, 25)
        Me.CbProdType.TabIndex = 52
        '
        'txtLength
        '
        Me.txtLength.BackColor = System.Drawing.Color.White
        Me.txtLength.Enabled = False
        Me.txtLength.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(103, 172)
        Me.txtLength.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtLength.Multiline = True
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(99, 21)
        Me.txtLength.TabIndex = 129
        '
        'cblengthWidth
        '
        Me.cblengthWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblengthWidth.Enabled = False
        Me.cblengthWidth.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cblengthWidth.ForeColor = System.Drawing.Color.Black
        Me.cblengthWidth.FormattingEnabled = True
        Me.cblengthWidth.ItemHeight = 17
        Me.cblengthWidth.Items.AddRange(New Object() {"cm", "ft", "inch", "m", "mm", "yard"})
        Me.cblengthWidth.Location = New System.Drawing.Point(207, 183)
        Me.cblengthWidth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cblengthWidth.Name = "cblengthWidth"
        Me.cblengthWidth.Size = New System.Drawing.Size(77, 25)
        Me.cblengthWidth.Sorted = True
        Me.cblengthWidth.TabIndex = 134
        '
        'cbHeight
        '
        Me.cbHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHeight.Enabled = False
        Me.cbHeight.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHeight.ForeColor = System.Drawing.Color.Black
        Me.cbHeight.FormattingEnabled = True
        Me.cbHeight.ItemHeight = 17
        Me.cbHeight.Items.AddRange(New Object() {"cm", "ft", "inch", "m", "mm", "yard"})
        Me.cbHeight.Location = New System.Drawing.Point(207, 219)
        Me.cbHeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbHeight.Name = "cbHeight"
        Me.cbHeight.Size = New System.Drawing.Size(77, 25)
        Me.cbHeight.Sorted = True
        Me.cbHeight.TabIndex = 136
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Enabled = False
        Me.CheckBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.Location = New System.Drawing.Point(21, 303)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(91, 21)
        Me.CheckBox6.TabIndex = 137
        Me.CheckBox6.Text = "Electricity:"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'txtElectricity
        '
        Me.txtElectricity.BackColor = System.Drawing.Color.White
        Me.txtElectricity.Enabled = False
        Me.txtElectricity.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtElectricity.Location = New System.Drawing.Point(103, 303)
        Me.txtElectricity.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtElectricity.Multiline = True
        Me.txtElectricity.Name = "txtElectricity"
        Me.txtElectricity.Size = New System.Drawing.Size(99, 25)
        Me.txtElectricity.TabIndex = 138
        '
        'cbElectricity
        '
        Me.cbElectricity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbElectricity.Enabled = False
        Me.cbElectricity.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbElectricity.ForeColor = System.Drawing.Color.Black
        Me.cbElectricity.FormattingEnabled = True
        Me.cbElectricity.ItemHeight = 17
        Me.cbElectricity.Items.AddRange(New Object() {"ampheres", "voltage", "watts"})
        Me.cbElectricity.Location = New System.Drawing.Point(207, 301)
        Me.cbElectricity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbElectricity.Name = "cbElectricity"
        Me.cbElectricity.Size = New System.Drawing.Size(77, 25)
        Me.cbElectricity.Sorted = True
        Me.cbElectricity.TabIndex = 139
        '
        'cbWeight
        '
        Me.cbWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWeight.Enabled = False
        Me.cbWeight.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWeight.ForeColor = System.Drawing.Color.Black
        Me.cbWeight.FormattingEnabled = True
        Me.cbWeight.ItemHeight = 17
        Me.cbWeight.Items.AddRange(New Object() {"g", "kg", "pound"})
        Me.cbWeight.Location = New System.Drawing.Point(207, 275)
        Me.cbWeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbWeight.Name = "cbWeight"
        Me.cbWeight.Size = New System.Drawing.Size(77, 25)
        Me.cbWeight.Sorted = True
        Me.cbWeight.TabIndex = 140
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(312, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 19)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "₱"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(35, 175)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 17)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "Length:"
        '
        'cbVolume
        '
        Me.cbVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVolume.Enabled = False
        Me.cbVolume.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVolume.ForeColor = System.Drawing.Color.Black
        Me.cbVolume.FormattingEnabled = True
        Me.cbVolume.ItemHeight = 17
        Me.cbVolume.Items.AddRange(New Object() {"gallon", "L", "m3", "mL", "pint"})
        Me.cbVolume.Location = New System.Drawing.Point(207, 328)
        Me.cbVolume.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbVolume.Name = "cbVolume"
        Me.cbVolume.Size = New System.Drawing.Size(77, 25)
        Me.cbVolume.Sorted = True
        Me.cbVolume.TabIndex = 145
        '
        'txtVolume
        '
        Me.txtVolume.BackColor = System.Drawing.Color.White
        Me.txtVolume.Enabled = False
        Me.txtVolume.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.Location = New System.Drawing.Point(103, 329)
        Me.txtVolume.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtVolume.Multiline = True
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(99, 24)
        Me.txtVolume.TabIndex = 144
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(21, 331)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(78, 21)
        Me.CheckBox1.TabIndex = 143
        Me.CheckBox1.Text = "Volume:"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cbSize
        '
        Me.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSize.Enabled = False
        Me.cbSize.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSize.ForeColor = System.Drawing.Color.Black
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.ItemHeight = 17
        Me.cbSize.Items.AddRange(New Object() {"large", "medium", "small ", "standard"})
        Me.cbSize.Location = New System.Drawing.Point(103, 357)
        Me.cbSize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(182, 25)
        Me.cbSize.Sorted = True
        Me.cbSize.TabIndex = 148
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(21, 360)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(58, 21)
        Me.CheckBox2.TabIndex = 146
        Me.CheckBox2.Text = "Size:"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TextBox2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.FormattingEnabled = True
        Me.TextBox2.Location = New System.Drawing.Point(23, 123)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(248, 25)
        Me.TextBox2.TabIndex = 149
        '
        'TbProdBrand
        '
        Me.TbProdBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TbProdBrand.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdBrand.ForeColor = System.Drawing.Color.Black
        Me.TbProdBrand.FormattingEnabled = True
        Me.TbProdBrand.Location = New System.Drawing.Point(309, 123)
        Me.TbProdBrand.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TbProdBrand.Name = "TbProdBrand"
        Me.TbProdBrand.Size = New System.Drawing.Size(179, 25)
        Me.TbProdBrand.TabIndex = 150
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BackColor = System.Drawing.Color.White
        Me.txtItemDescription.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDescription.Location = New System.Drawing.Point(308, 403)
        Me.txtItemDescription.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtItemDescription.Multiline = True
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(173, 140)
        Me.txtItemDescription.TabIndex = 151
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(309, 378)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 19)
        Me.Label15.TabIndex = 152
        Me.Label15.Text = "Item Description"
        '
        'FormAddNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(512, 583)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtItemDescription)
        Me.Controls.Add(Me.BtnSaveProduct)
        Me.Controls.Add(Me.TbProdBrand)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.cbSize)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.cbVolume)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbWeight)
        Me.Controls.Add(Me.cbElectricity)
        Me.Controls.Add(Me.txtElectricity)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.cbHeight)
        Me.Controls.Add(Me.cblengthWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.cbThick)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.txtThick)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.Length)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CheckBoxDoesExpire)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TbProdCritStockLimit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbProdStock)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TbProdColor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbProdPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtpExDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.CbProdType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbProdName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(800, 800)
        Me.Name = "FormAddNewProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddNewProduct"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnSaveProduct As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TbProdName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpExDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TbProdStock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbProdColor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbProdPrice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TbProdCritStockLimit As TextBox
    Friend WithEvents CheckBoxDoesExpire As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Label12 As Label
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents txtThick As TextBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Length As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents cbThick As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CbProdType As ComboBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents cbHeight As ComboBox
    Friend WithEvents cblengthWidth As ComboBox
    Friend WithEvents cbElectricity As ComboBox
    Friend WithEvents txtElectricity As TextBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents cbWeight As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbVolume As ComboBox
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TbProdBrand As ComboBox
    Friend WithEvents TextBox2 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtItemDescription As TextBox
End Class
