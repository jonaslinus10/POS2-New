<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateDeliveredProduct
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpExDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbProdPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbProdQty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbProdName = New System.Windows.Forms.TextBox()
        Me.BtnSaveProduct = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbProdInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbProdCustomerName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ChkBoxDelivered = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(20, 366)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 28)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Purchase Date"
        '
        'DtpExDate
        '
        Me.DtpExDate.CalendarFont = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpExDate.Enabled = False
        Me.DtpExDate.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpExDate.Location = New System.Drawing.Point(18, 400)
        Me.DtpExDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DtpExDate.Name = "DtpExDate"
        Me.DtpExDate.Size = New System.Drawing.Size(385, 34)
        Me.DtpExDate.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(214, 295)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 28)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Price"
        '
        'TbProdPrice
        '
        Me.TbProdPrice.BackColor = System.Drawing.Color.Gainsboro
        Me.TbProdPrice.Enabled = False
        Me.TbProdPrice.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdPrice.Location = New System.Drawing.Point(212, 326)
        Me.TbProdPrice.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdPrice.Name = "TbProdPrice"
        Me.TbProdPrice.ReadOnly = True
        Me.TbProdPrice.Size = New System.Drawing.Size(190, 33)
        Me.TbProdPrice.TabIndex = 110
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(18, 295)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 28)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Quantity"
        '
        'TbProdQty
        '
        Me.TbProdQty.BackColor = System.Drawing.Color.Gainsboro
        Me.TbProdQty.Enabled = False
        Me.TbProdQty.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdQty.Location = New System.Drawing.Point(16, 326)
        Me.TbProdQty.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdQty.Multiline = True
        Me.TbProdQty.Name = "TbProdQty"
        Me.TbProdQty.ReadOnly = True
        Me.TbProdQty.Size = New System.Drawing.Size(184, 36)
        Me.TbProdQty.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 225)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 28)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Item Name"
        '
        'TbProdName
        '
        Me.TbProdName.BackColor = System.Drawing.Color.Gainsboro
        Me.TbProdName.Enabled = False
        Me.TbProdName.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdName.Location = New System.Drawing.Point(15, 255)
        Me.TbProdName.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdName.Name = "TbProdName"
        Me.TbProdName.ReadOnly = True
        Me.TbProdName.Size = New System.Drawing.Size(385, 33)
        Me.TbProdName.TabIndex = 101
        '
        'BtnSaveProduct
        '
        Me.BtnSaveProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveProduct.FlatAppearance.BorderSize = 0
        Me.BtnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveProduct.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveProduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSaveProduct.Location = New System.Drawing.Point(105, 600)
        Me.BtnSaveProduct.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnSaveProduct.Name = "BtnSaveProduct"
        Me.BtnSaveProduct.Size = New System.Drawing.Size(207, 55)
        Me.BtnSaveProduct.TabIndex = 100
        Me.BtnSaveProduct.Text = "Proceed"
        Me.BtnSaveProduct.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(358, 2)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(63, 65)
        Me.BtnExit.TabIndex = 99
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 45)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Update Sale"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(18, 75)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 28)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "Invoice Number"
        '
        'TbProdInvoiceNo
        '
        Me.TbProdInvoiceNo.BackColor = System.Drawing.Color.Gainsboro
        Me.TbProdInvoiceNo.Enabled = False
        Me.TbProdInvoiceNo.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdInvoiceNo.Location = New System.Drawing.Point(16, 106)
        Me.TbProdInvoiceNo.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdInvoiceNo.Name = "TbProdInvoiceNo"
        Me.TbProdInvoiceNo.ReadOnly = True
        Me.TbProdInvoiceNo.Size = New System.Drawing.Size(385, 33)
        Me.TbProdInvoiceNo.TabIndex = 119
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(18, 146)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 28)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "Customer Name"
        '
        'TbProdCustomerName
        '
        Me.TbProdCustomerName.BackColor = System.Drawing.Color.Gainsboro
        Me.TbProdCustomerName.Enabled = False
        Me.TbProdCustomerName.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProdCustomerName.Location = New System.Drawing.Point(16, 177)
        Me.TbProdCustomerName.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbProdCustomerName.Name = "TbProdCustomerName"
        Me.TbProdCustomerName.ReadOnly = True
        Me.TbProdCustomerName.Size = New System.Drawing.Size(385, 33)
        Me.TbProdCustomerName.TabIndex = 121
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(20, 440)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 28)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Delivery Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(18, 474)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(385, 34)
        Me.DateTimePicker1.TabIndex = 123
        '
        'ChkBoxDelivered
        '
        Me.ChkBoxDelivered.AutoSize = True
        Me.ChkBoxDelivered.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBoxDelivered.Location = New System.Drawing.Point(22, 522)
        Me.ChkBoxDelivered.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkBoxDelivered.Name = "ChkBoxDelivered"
        Me.ChkBoxDelivered.Size = New System.Drawing.Size(177, 34)
        Me.ChkBoxDelivered.TabIndex = 125
        Me.ChkBoxDelivered.Text = "Set Delivered"
        Me.ChkBoxDelivered.UseVisualStyleBackColor = True
        '
        'FormUpdateDeliveredProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(423, 666)
        Me.Controls.Add(Me.ChkBoxDelivered)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TbProdCustomerName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TbProdInvoiceNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtpExDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TbProdPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbProdQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbProdName)
        Me.Controls.Add(Me.BtnSaveProduct)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormUpdateDeliveredProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdateDeliveredProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpExDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TbProdPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbProdQty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbProdName As TextBox
    Friend WithEvents BtnSaveProduct As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TbProdInvoiceNo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TbProdCustomerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ChkBoxDelivered As CheckBox
End Class
