<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewReturnedProduct
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
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbInvoiceNumber = New System.Windows.Forms.Label()
        Me.TbProductName = New System.Windows.Forms.Label()
        Me.TbCustomerName = New System.Windows.Forms.Label()
        Me.TbRemarks = New System.Windows.Forms.Label()
        Me.TbDateAndTime = New System.Windows.Forms.Label()
        Me.TbPrice = New System.Windows.Forms.Label()
        Me.TbQty = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(377, 1)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(42, 42)
        Me.BtnExit.TabIndex = 56
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Invoice Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 30)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Returned Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(13, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 19)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Remarks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(13, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 19)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(13, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 19)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(13, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(13, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 19)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Item Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(13, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 19)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Customer Name"
        '
        'TbInvoiceNumber
        '
        Me.TbInvoiceNumber.AutoSize = True
        Me.TbInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbInvoiceNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TbInvoiceNumber.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbInvoiceNumber.ForeColor = System.Drawing.Color.IndianRed
        Me.TbInvoiceNumber.Location = New System.Drawing.Point(16, 58)
        Me.TbInvoiceNumber.Name = "TbInvoiceNumber"
        Me.TbInvoiceNumber.Size = New System.Drawing.Size(77, 23)
        Me.TbInvoiceNumber.TabIndex = 64
        Me.TbInvoiceNumber.Text = "Remarks"
        Me.TbInvoiceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbProductName
        '
        Me.TbProductName.AutoSize = True
        Me.TbProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TbProductName.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProductName.ForeColor = System.Drawing.Color.IndianRed
        Me.TbProductName.Location = New System.Drawing.Point(17, 142)
        Me.TbProductName.Name = "TbProductName"
        Me.TbProductName.Size = New System.Drawing.Size(77, 23)
        Me.TbProductName.TabIndex = 65
        Me.TbProductName.Text = "Remarks"
        Me.TbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbCustomerName
        '
        Me.TbCustomerName.AutoSize = True
        Me.TbCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TbCustomerName.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCustomerName.ForeColor = System.Drawing.Color.IndianRed
        Me.TbCustomerName.Location = New System.Drawing.Point(16, 100)
        Me.TbCustomerName.Name = "TbCustomerName"
        Me.TbCustomerName.Size = New System.Drawing.Size(77, 23)
        Me.TbCustomerName.TabIndex = 66
        Me.TbCustomerName.Text = "Remarks"
        Me.TbCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbRemarks
        '
        Me.TbRemarks.AutoSize = True
        Me.TbRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbRemarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TbRemarks.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbRemarks.ForeColor = System.Drawing.Color.IndianRed
        Me.TbRemarks.Location = New System.Drawing.Point(16, 310)
        Me.TbRemarks.Name = "TbRemarks"
        Me.TbRemarks.Size = New System.Drawing.Size(77, 23)
        Me.TbRemarks.TabIndex = 67
        Me.TbRemarks.Text = "Remarks"
        Me.TbRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbDateAndTime
        '
        Me.TbDateAndTime.AutoSize = True
        Me.TbDateAndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbDateAndTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TbDateAndTime.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDateAndTime.ForeColor = System.Drawing.Color.IndianRed
        Me.TbDateAndTime.Location = New System.Drawing.Point(17, 268)
        Me.TbDateAndTime.Name = "TbDateAndTime"
        Me.TbDateAndTime.Size = New System.Drawing.Size(77, 23)
        Me.TbDateAndTime.TabIndex = 68
        Me.TbDateAndTime.Text = "Remarks"
        Me.TbDateAndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbPrice
        '
        Me.TbPrice.AutoSize = True
        Me.TbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TbPrice.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPrice.ForeColor = System.Drawing.Color.IndianRed
        Me.TbPrice.Location = New System.Drawing.Point(17, 226)
        Me.TbPrice.Name = "TbPrice"
        Me.TbPrice.Size = New System.Drawing.Size(77, 23)
        Me.TbPrice.TabIndex = 69
        Me.TbPrice.Text = "Remarks"
        Me.TbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbQty
        '
        Me.TbQty.AutoSize = True
        Me.TbQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TbQty.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbQty.ForeColor = System.Drawing.Color.IndianRed
        Me.TbQty.Location = New System.Drawing.Point(17, 184)
        Me.TbQty.Name = "TbQty"
        Me.TbQty.Size = New System.Drawing.Size(77, 23)
        Me.TbQty.TabIndex = 70
        Me.TbQty.Text = "Remarks"
        Me.TbQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormViewReturnedProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(420, 450)
        Me.Controls.Add(Me.TbQty)
        Me.Controls.Add(Me.TbPrice)
        Me.Controls.Add(Me.TbDateAndTime)
        Me.Controls.Add(Me.TbRemarks)
        Me.Controls.Add(Me.TbCustomerName)
        Me.Controls.Add(Me.TbProductName)
        Me.Controls.Add(Me.TbInvoiceNumber)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormViewReturnedProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormViewReturnedProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TbInvoiceNumber As Label
    Friend WithEvents TbProductName As Label
    Friend WithEvents TbCustomerName As Label
    Friend WithEvents TbRemarks As Label
    Friend WithEvents TbDateAndTime As Label
    Friend WithEvents TbPrice As Label
    Friend WithEvents TbQty As Label
End Class
