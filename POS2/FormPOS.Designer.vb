<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPOS
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
        Me.PrintReceiptDocument = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DateTimePickerDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbPosOrderType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_OrderType = New System.Windows.Forms.Label()
        Me.TbPosCustomerContactNo = New System.Windows.Forms.TextBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.TbPosCustomerAddress = New System.Windows.Forms.TextBox()
        Me.lbl_Contact = New System.Windows.Forms.Label()
        Me.TbPosCustomerName = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.TbPosChange = New System.Windows.Forms.TextBox()
        Me.lbl_CName = New System.Windows.Forms.Label()
        Me.CbPosPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.TbPosCustomerTotalCash = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnReturnProduct = New System.Windows.Forms.Button()
        Me.BtnPosClearCustomerInfo = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LvPosOrders = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.LblPosItemsTotalPrice = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnDeleteItem = New System.Windows.Forms.Button()
        Me.BtnPosOrdersClear = New System.Windows.Forms.Button()
        Me.LvPosProducts = New System.Windows.Forms.ListView()
        Me.item_code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_classification = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.item_stock_unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbPosSortProducts = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbPosSearchProduct = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintReceiptDocument
        '
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1087, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 749)
        Me.Panel1.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.AutoSize = True
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.LblTime)
        Me.Panel8.Controls.Add(Me.LblDate)
        Me.Panel8.Controls.Add(Me.lblCurrentUser)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(279, 152)
        Me.Panel8.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(-3, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 27)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Hardware Store"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(0, -1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(280, 48)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "HONEST CITY"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ForeColor = System.Drawing.Color.Maroon
        Me.LblTime.Location = New System.Drawing.Point(13, 100)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(59, 28)
        Me.LblTime.TabIndex = 54
        Me.LblTime.Text = "Time"
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.ForeColor = System.Drawing.Color.Maroon
        Me.LblDate.Location = New System.Drawing.Point(15, 129)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(48, 23)
        Me.LblDate.TabIndex = 53
        Me.LblDate.Text = "Date"
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.Font = New System.Drawing.Font("Nirmala UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.lblCurrentUser.Location = New System.Drawing.Point(8, 63)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(238, 42)
        Me.lblCurrentUser.TabIndex = 52
        Me.lblCurrentUser.Text = "User"
        Me.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Panel6.Controls.Add(Me.DateTimePickerDeliveryDate)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.CbPosOrderType)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.lbl_OrderType)
        Me.Panel6.Controls.Add(Me.TbPosCustomerContactNo)
        Me.Panel6.Controls.Add(Me.lbl5)
        Me.Panel6.Controls.Add(Me.TbPosCustomerAddress)
        Me.Panel6.Controls.Add(Me.lbl_Contact)
        Me.Panel6.Controls.Add(Me.TbPosCustomerName)
        Me.Panel6.Controls.Add(Me.lbl4)
        Me.Panel6.Controls.Add(Me.lbl_Address)
        Me.Panel6.Controls.Add(Me.TbPosChange)
        Me.Panel6.Controls.Add(Me.lbl_CName)
        Me.Panel6.Controls.Add(Me.CbPosPaymentMethod)
        Me.Panel6.Controls.Add(Me.lbl3)
        Me.Panel6.Controls.Add(Me.TbPosCustomerTotalCash)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 155)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(279, 471)
        Me.Panel6.TabIndex = 17
        '
        'DateTimePickerDeliveryDate
        '
        Me.DateTimePickerDeliveryDate.Enabled = False
        Me.DateTimePickerDeliveryDate.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.DateTimePickerDeliveryDate.Location = New System.Drawing.Point(9, 128)
        Me.DateTimePickerDeliveryDate.Name = "DateTimePickerDeliveryDate"
        Me.DateTimePickerDeliveryDate.Size = New System.Drawing.Size(262, 23)
        Me.DateTimePickerDeliveryDate.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Delivery Date"
        '
        'CbPosOrderType
        '
        Me.CbPosOrderType.BackColor = System.Drawing.Color.White
        Me.CbPosOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPosOrderType.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPosOrderType.FormattingEnabled = True
        Me.CbPosOrderType.Items.AddRange(New Object() {"Deliver", "Walk-in"})
        Me.CbPosOrderType.Location = New System.Drawing.Point(10, 65)
        Me.CbPosOrderType.Name = "CbPosOrderType"
        Me.CbPosOrderType.Size = New System.Drawing.Size(262, 33)
        Me.CbPosOrderType.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(4, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 28)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Customer's Information"
        '
        'lbl_OrderType
        '
        Me.lbl_OrderType.AutoSize = True
        Me.lbl_OrderType.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OrderType.ForeColor = System.Drawing.Color.Black
        Me.lbl_OrderType.Location = New System.Drawing.Point(10, 39)
        Me.lbl_OrderType.Name = "lbl_OrderType"
        Me.lbl_OrderType.Size = New System.Drawing.Size(109, 25)
        Me.lbl_OrderType.TabIndex = 4
        Me.lbl_OrderType.Text = "Order Type:"
        '
        'TbPosCustomerContactNo
        '
        Me.TbPosCustomerContactNo.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPosCustomerContactNo.Location = New System.Drawing.Point(12, 355)
        Me.TbPosCustomerContactNo.MaxLength = 11
        Me.TbPosCustomerContactNo.Name = "TbPosCustomerContactNo"
        Me.TbPosCustomerContactNo.Size = New System.Drawing.Size(262, 32)
        Me.TbPosCustomerContactNo.TabIndex = 8
        Me.TbPosCustomerContactNo.Text = "09"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.Black
        Me.lbl5.Location = New System.Drawing.Point(11, 152)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(181, 25)
        Me.lbl5.TabIndex = 5
        Me.lbl5.Text = "Method of Payment:"
        '
        'TbPosCustomerAddress
        '
        Me.TbPosCustomerAddress.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPosCustomerAddress.Location = New System.Drawing.Point(11, 294)
        Me.TbPosCustomerAddress.MaxLength = 25
        Me.TbPosCustomerAddress.Name = "TbPosCustomerAddress"
        Me.TbPosCustomerAddress.Size = New System.Drawing.Size(262, 32)
        Me.TbPosCustomerAddress.TabIndex = 7
        '
        'lbl_Contact
        '
        Me.lbl_Contact.AutoSize = True
        Me.lbl_Contact.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contact.ForeColor = System.Drawing.Color.Black
        Me.lbl_Contact.Location = New System.Drawing.Point(9, 328)
        Me.lbl_Contact.Name = "lbl_Contact"
        Me.lbl_Contact.Size = New System.Drawing.Size(156, 25)
        Me.lbl_Contact.TabIndex = 2
        Me.lbl_Contact.Text = "Contact Number:"
        '
        'TbPosCustomerName
        '
        Me.TbPosCustomerName.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPosCustomerName.Location = New System.Drawing.Point(11, 235)
        Me.TbPosCustomerName.MaxLength = 25
        Me.TbPosCustomerName.Name = "TbPosCustomerName"
        Me.TbPosCustomerName.Size = New System.Drawing.Size(262, 32)
        Me.TbPosCustomerName.TabIndex = 6
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Black
        Me.lbl4.Location = New System.Drawing.Point(16, 430)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(81, 25)
        Me.lbl4.TabIndex = 4
        Me.lbl4.Text = "Change:"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address.ForeColor = System.Drawing.Color.Black
        Me.lbl_Address.Location = New System.Drawing.Point(11, 268)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(83, 25)
        Me.lbl_Address.TabIndex = 1
        Me.lbl_Address.Text = "Address:"
        '
        'TbPosChange
        '
        Me.TbPosChange.BackColor = System.Drawing.Color.LightGray
        Me.TbPosChange.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPosChange.Location = New System.Drawing.Point(104, 429)
        Me.TbPosChange.Name = "TbPosChange"
        Me.TbPosChange.ReadOnly = True
        Me.TbPosChange.Size = New System.Drawing.Size(169, 32)
        Me.TbPosChange.TabIndex = 15
        Me.TbPosChange.Text = "0.00"
        '
        'lbl_CName
        '
        Me.lbl_CName.AutoSize = True
        Me.lbl_CName.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CName.ForeColor = System.Drawing.Color.Black
        Me.lbl_CName.Location = New System.Drawing.Point(9, 208)
        Me.lbl_CName.Name = "lbl_CName"
        Me.lbl_CName.Size = New System.Drawing.Size(163, 25)
        Me.lbl_CName.TabIndex = 0
        Me.lbl_CName.Text = "Customer's Name:"
        '
        'CbPosPaymentMethod
        '
        Me.CbPosPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPosPaymentMethod.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPosPaymentMethod.FormattingEnabled = True
        Me.CbPosPaymentMethod.Items.AddRange(New Object() {"G-Cash", "Two-Payment Method"})
        Me.CbPosPaymentMethod.Location = New System.Drawing.Point(11, 178)
        Me.CbPosPaymentMethod.Name = "CbPosPaymentMethod"
        Me.CbPosPaymentMethod.Size = New System.Drawing.Size(262, 33)
        Me.CbPosPaymentMethod.TabIndex = 9
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Black
        Me.lbl3.Location = New System.Drawing.Point(40, 394)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(57, 25)
        Me.lbl3.TabIndex = 3
        Me.lbl3.Text = "Cash:"
        '
        'TbPosCustomerTotalCash
        '
        Me.TbPosCustomerTotalCash.BackColor = System.Drawing.Color.White
        Me.TbPosCustomerTotalCash.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPosCustomerTotalCash.Location = New System.Drawing.Point(104, 393)
        Me.TbPosCustomerTotalCash.Name = "TbPosCustomerTotalCash"
        Me.TbPosCustomerTotalCash.Size = New System.Drawing.Size(169, 32)
        Me.TbPosCustomerTotalCash.TabIndex = 10
        Me.TbPosCustomerTotalCash.Text = "0.00"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Panel5.Controls.Add(Me.BtnReturnProduct)
        Me.Panel5.Controls.Add(Me.BtnPosClearCustomerInfo)
        Me.Panel5.Controls.Add(Me.BtnPrint)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 626)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(279, 119)
        Me.Panel5.TabIndex = 49
        '
        'BtnReturnProduct
        '
        Me.BtnReturnProduct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReturnProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.BtnReturnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReturnProduct.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnReturnProduct.FlatAppearance.BorderSize = 2
        Me.BtnReturnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturnProduct.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturnProduct.ForeColor = System.Drawing.Color.Firebrick
        Me.BtnReturnProduct.Location = New System.Drawing.Point(4, 57)
        Me.BtnReturnProduct.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnReturnProduct.Name = "BtnReturnProduct"
        Me.BtnReturnProduct.Size = New System.Drawing.Size(272, 48)
        Me.BtnReturnProduct.TabIndex = 50
        Me.BtnReturnProduct.Text = "Item Return"
        Me.BtnReturnProduct.UseVisualStyleBackColor = False
        '
        'BtnPosClearCustomerInfo
        '
        Me.BtnPosClearCustomerInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPosClearCustomerInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BtnPosClearCustomerInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPosClearCustomerInfo.FlatAppearance.BorderSize = 0
        Me.BtnPosClearCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPosClearCustomerInfo.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPosClearCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnPosClearCustomerInfo.Location = New System.Drawing.Point(8, 5)
        Me.BtnPosClearCustomerInfo.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnPosClearCustomerInfo.Name = "BtnPosClearCustomerInfo"
        Me.BtnPosClearCustomerInfo.Size = New System.Drawing.Size(133, 50)
        Me.BtnPosClearCustomerInfo.TabIndex = 49
        Me.BtnPosClearCustomerInfo.Text = "Cancel"
        Me.BtnPosClearCustomerInfo.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.White
        Me.BtnPrint.Location = New System.Drawing.Point(148, 4)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(133, 50)
        Me.BtnPrint.TabIndex = 48
        Me.BtnPrint.Text = "Process Payment"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1370, 749)
        Me.Panel4.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.LvPosProducts)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1087, 749)
        Me.Panel3.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCoral
        Me.Panel2.Controls.Add(Me.LvPosOrders)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(607, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 616)
        Me.Panel2.TabIndex = 20
        '
        'LvPosOrders
        '
        Me.LvPosOrders.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LvPosOrders.CheckBoxes = True
        Me.LvPosOrders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LvPosOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvPosOrders.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvPosOrders.FullRowSelect = True
        Me.LvPosOrders.GridLines = True
        Me.LvPosOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvPosOrders.HideSelection = False
        Me.LvPosOrders.Location = New System.Drawing.Point(0, 0)
        Me.LvPosOrders.Name = "LvPosOrders"
        Me.LvPosOrders.Size = New System.Drawing.Size(480, 482)
        Me.LvPosOrders.TabIndex = 51
        Me.LvPosOrders.UseCompatibleStateImageBehavior = False
        Me.LvPosOrders.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item Code"
        Me.ColumnHeader1.Width = 104
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Name"
        Me.ColumnHeader2.Width = 165
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit Price"
        Me.ColumnHeader5.Width = 71
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Qty"
        Me.ColumnHeader6.Width = 52
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Sub Total"
        Me.ColumnHeader7.Width = 76
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Maroon
        Me.Panel9.Controls.Add(Me.LblPosItemsTotalPrice)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.BtnDeleteItem)
        Me.Panel9.Controls.Add(Me.BtnPosOrdersClear)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 482)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(480, 134)
        Me.Panel9.TabIndex = 50
        '
        'LblPosItemsTotalPrice
        '
        Me.LblPosItemsTotalPrice.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPosItemsTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.LblPosItemsTotalPrice.Location = New System.Drawing.Point(89, 8)
        Me.LblPosItemsTotalPrice.Name = "LblPosItemsTotalPrice"
        Me.LblPosItemsTotalPrice.Size = New System.Drawing.Size(365, 41)
        Me.LblPosItemsTotalPrice.TabIndex = 56
        Me.LblPosItemsTotalPrice.Text = "0.00"
        Me.LblPosItemsTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 31)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Total:"
        '
        'BtnDeleteItem
        '
        Me.BtnDeleteItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnDeleteItem.FlatAppearance.BorderSize = 2
        Me.BtnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteItem.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnDeleteItem.Location = New System.Drawing.Point(255, 70)
        Me.BtnDeleteItem.Name = "BtnDeleteItem"
        Me.BtnDeleteItem.Size = New System.Drawing.Size(178, 48)
        Me.BtnDeleteItem.TabIndex = 54
        Me.BtnDeleteItem.Text = "Clear Marked"
        Me.BtnDeleteItem.UseVisualStyleBackColor = True
        '
        'BtnPosOrdersClear
        '
        Me.BtnPosOrdersClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BtnPosOrdersClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPosOrdersClear.FlatAppearance.BorderSize = 0
        Me.BtnPosOrdersClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPosOrdersClear.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPosOrdersClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnPosOrdersClear.Location = New System.Drawing.Point(59, 70)
        Me.BtnPosOrdersClear.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnPosOrdersClear.Name = "BtnPosOrdersClear"
        Me.BtnPosOrdersClear.Size = New System.Drawing.Size(178, 48)
        Me.BtnPosOrdersClear.TabIndex = 49
        Me.BtnPosOrdersClear.Text = "Clear All"
        Me.BtnPosOrdersClear.UseVisualStyleBackColor = False
        '
        'LvPosProducts
        '
        Me.LvPosProducts.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.LvPosProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvPosProducts.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LvPosProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.item_code, Me.item_category, Me.item_name, Me.item_classification, Me.item_brand, Me.item_size, Me.item_color, Me.item_price, Me.item_stock_unit})
        Me.LvPosProducts.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LvPosProducts.FullRowSelect = True
        Me.LvPosProducts.GridLines = True
        Me.LvPosProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvPosProducts.HideSelection = False
        Me.LvPosProducts.Location = New System.Drawing.Point(0, 133)
        Me.LvPosProducts.MultiSelect = False
        Me.LvPosProducts.Name = "LvPosProducts"
        Me.LvPosProducts.Size = New System.Drawing.Size(607, 616)
        Me.LvPosProducts.TabIndex = 19
        Me.LvPosProducts.UseCompatibleStateImageBehavior = False
        Me.LvPosProducts.View = System.Windows.Forms.View.Details
        '
        'item_code
        '
        Me.item_code.Text = "Item Code"
        Me.item_code.Width = 115
        '
        'item_category
        '
        Me.item_category.Text = "Item Category"
        Me.item_category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.item_category.Width = 200
        '
        'item_name
        '
        Me.item_name.Text = "Item Name"
        Me.item_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.item_name.Width = 185
        '
        'item_classification
        '
        Me.item_classification.Text = "Classification"
        Me.item_classification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.item_classification.Width = 150
        '
        'item_brand
        '
        Me.item_brand.Text = "Item Brand"
        Me.item_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.item_brand.Width = 90
        '
        'item_size
        '
        Me.item_size.Text = "Size"
        Me.item_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.item_size.Width = 117
        '
        'item_color
        '
        Me.item_color.Text = "Color"
        '
        'item_price
        '
        Me.item_price.Text = "Price"
        Me.item_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.item_price.Width = 66
        '
        'item_stock_unit
        '
        Me.item_stock_unit.Text = "Stock"
        Me.item_stock_unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.item_stock_unit.Width = 70
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Maroon
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.BtnRefresh)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.CbPosSortProducts)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.TbPosSearchProduct)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1087, 133)
        Me.Panel7.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(607, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 48)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Customer's Cart"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.MenuStrip1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1087, 39)
        Me.Panel10.TabIndex = 21
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.BackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1087, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuToolStripMenuItem.Image = Global.POS2.My.Resources.Resources.ic_account_settings
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.MenuToolStripMenuItem.Text = "Profile"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnRefresh.Location = New System.Drawing.Point(459, 76)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(110, 34)
        Me.BtnRefresh.TabIndex = 50
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(299, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 32)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Sort By"
        '
        'CbPosSortProducts
        '
        Me.CbPosSortProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPosSortProducts.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.CbPosSortProducts.FormattingEnabled = True
        Me.CbPosSortProducts.Location = New System.Drawing.Point(303, 81)
        Me.CbPosSortProducts.Name = "CbPosSortProducts"
        Me.CbPosSortProducts.Size = New System.Drawing.Size(145, 27)
        Me.CbPosSortProducts.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(23, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 32)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Search Item Name"
        '
        'TbPosSearchProduct
        '
        Me.TbPosSearchProduct.BackColor = System.Drawing.Color.White
        Me.TbPosSearchProduct.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPosSearchProduct.ForeColor = System.Drawing.Color.Black
        Me.TbPosSearchProduct.Location = New System.Drawing.Point(28, 82)
        Me.TbPosSearchProduct.Margin = New System.Windows.Forms.Padding(7)
        Me.TbPosSearchProduct.Multiline = True
        Me.TbPosSearchProduct.Name = "TbPosSearchProduct"
        Me.TbPosSearchProduct.Size = New System.Drawing.Size(250, 28)
        Me.TbPosSearchProduct.TabIndex = 16
        '
        'FormPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FormPOS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Honest City Hardware"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintReceiptDocument As Printing.PrintDocument
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents lblCurrentUser As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DateTimePickerDeliveryDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents CbPosOrderType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_OrderType As Label
    Friend WithEvents TbPosCustomerContactNo As TextBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents TbPosCustomerAddress As TextBox
    Friend WithEvents lbl_Contact As Label
    Friend WithEvents TbPosCustomerName As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents TbPosChange As TextBox
    Friend WithEvents lbl_CName As Label
    Friend WithEvents CbPosPaymentMethod As ComboBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents TbPosCustomerTotalCash As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnReturnProduct As Button
    Friend WithEvents BtnPosClearCustomerInfo As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LvPosOrders As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Panel9 As Panel
    Friend WithEvents LblPosItemsTotalPrice As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnDeleteItem As Button
    Friend WithEvents BtnPosOrdersClear As Button
    Friend WithEvents LvPosProducts As ListView
    Friend WithEvents item_code As ColumnHeader
    Friend WithEvents item_name As ColumnHeader
    Friend WithEvents item_size As ColumnHeader
    Friend WithEvents item_price As ColumnHeader
    Friend WithEvents item_stock_unit As ColumnHeader
    Friend WithEvents item_brand As ColumnHeader
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CbPosSortProducts As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbPosSearchProduct As TextBox
    Friend WithEvents item_category As ColumnHeader
    Friend WithEvents item_classification As ColumnHeader
    Friend WithEvents item_color As ColumnHeader
End Class
