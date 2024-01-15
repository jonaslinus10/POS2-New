<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDelivery
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbFormSalesSearch = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LvReportsSale = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Classification = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Remarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnFormDeliveryPrint = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDelivered = New System.Windows.Forms.Button()
        Me.tbNotDelivered = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnDeliveriesFilter = New System.Windows.Forms.Button()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Nirmala UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(23, 112)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(290, 27)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search By Invoice Number"
        '
        'TbFormSalesSearch
        '
        Me.TbFormSalesSearch.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbFormSalesSearch.Location = New System.Drawing.Point(21, 105)
        Me.TbFormSalesSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TbFormSalesSearch.Name = "TbFormSalesSearch"
        Me.TbFormSalesSearch.Size = New System.Drawing.Size(285, 27)
        Me.TbFormSalesSearch.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LvReportsSale)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 156)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1165, 443)
        Me.Panel2.TabIndex = 3
        '
        'LvReportsSale
        '
        Me.LvReportsSale.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader5, Me.Category, Me.ColumnHeader2, Me.Classification, Me.Brand, Me.Size, Me.Color, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.Remarks})
        Me.LvReportsSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvReportsSale.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvReportsSale.FullRowSelect = True
        Me.LvReportsSale.GridLines = True
        Me.LvReportsSale.HideSelection = False
        Me.LvReportsSale.Location = New System.Drawing.Point(0, 0)
        Me.LvReportsSale.Margin = New System.Windows.Forms.Padding(4)
        Me.LvReportsSale.Name = "LvReportsSale"
        Me.LvReportsSale.Size = New System.Drawing.Size(1165, 443)
        Me.LvReportsSale.TabIndex = 1
        Me.LvReportsSale.UseCompatibleStateImageBehavior = False
        Me.LvReportsSale.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Invoice Number"
        Me.ColumnHeader1.Width = 128
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Customer Name"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 164
        '
        'Category
        '
        Me.Category.Text = "Category"
        Me.Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Category.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 195
        '
        'Classification
        '
        Me.Classification.Text = "Classification"
        Me.Classification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Classification.Width = 131
        '
        'Brand
        '
        Me.Brand.Text = "Brand"
        Me.Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Brand.Width = 126
        '
        'Size
        '
        Me.Size.Text = "Size"
        Me.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Size.Width = 106
        '
        'Color
        '
        Me.Color.Text = "Color"
        Me.Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Color.Width = 92
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantity"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 130
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 130
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date Transaction"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 130
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Time Transaction"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 130
        '
        'Remarks
        '
        Me.Remarks.Text = "Remarks"
        Me.Remarks.Width = 130
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.BtnFormDeliveryPrint)
        Me.Panel3.Controls.Add(Me.TbFormSalesSearch)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(696, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(469, 156)
        Me.Panel3.TabIndex = 3
        '
        'BtnFormDeliveryPrint
        '
        Me.BtnFormDeliveryPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnFormDeliveryPrint.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormDeliveryPrint.ForeColor = System.Drawing.Color.White
        Me.BtnFormDeliveryPrint.Location = New System.Drawing.Point(325, 102)
        Me.BtnFormDeliveryPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnFormDeliveryPrint.Name = "BtnFormDeliveryPrint"
        Me.BtnFormDeliveryPrint.Size = New System.Drawing.Size(126, 32)
        Me.BtnFormDeliveryPrint.TabIndex = 6
        Me.BtnFormDeliveryPrint.Text = "Print"
        Me.BtnFormDeliveryPrint.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1165, 156)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 23.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(8, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 52)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Deliveries"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.tbDelivered)
        Me.Panel4.Controls.Add(Me.tbNotDelivered)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Controls.Add(Me.BtnDeliveriesFilter)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(227, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(469, 156)
        Me.Panel4.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Filter by Status"
        '
        'tbDelivered
        '
        Me.tbDelivered.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.tbDelivered.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDelivered.Location = New System.Drawing.Point(23, 51)
        Me.tbDelivered.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDelivered.Name = "tbDelivered"
        Me.tbDelivered.Size = New System.Drawing.Size(126, 32)
        Me.tbDelivered.TabIndex = 12
        Me.tbDelivered.Text = "Delivered"
        Me.tbDelivered.UseVisualStyleBackColor = False
        '
        'tbNotDelivered
        '
        Me.tbNotDelivered.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.tbNotDelivered.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNotDelivered.Location = New System.Drawing.Point(157, 51)
        Me.tbNotDelivered.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNotDelivered.Name = "tbNotDelivered"
        Me.tbNotDelivered.Size = New System.Drawing.Size(126, 32)
        Me.tbNotDelivered.TabIndex = 11
        Me.tbNotDelivered.Text = "Not Delivered"
        Me.tbNotDelivered.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 87)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Filter by Date Transaction"
        '
        'BtnDeliveriesFilter
        '
        Me.BtnDeliveriesFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnDeliveriesFilter.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeliveriesFilter.Location = New System.Drawing.Point(321, 107)
        Me.BtnDeliveriesFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeliveriesFilter.Name = "BtnDeliveriesFilter"
        Me.BtnDeliveriesFilter.Size = New System.Drawing.Size(126, 32)
        Me.BtnDeliveriesFilter.TabIndex = 8
        Me.BtnDeliveriesFilter.Text = "Filter Date"
        Me.BtnDeliveriesFilter.UseVisualStyleBackColor = False
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date of Delivery"
        Me.ColumnHeader8.Width = 130
        '
        'FormDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 599)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormDelivery"
        Me.Text = "FormDelivery"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TbFormSalesSearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnFormDeliveryPrint As Button
    Friend WithEvents BtnDeliveriesFilter As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNotDelivered As Button
    Friend WithEvents tbDelivered As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LvReportsSale As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Classification As ColumnHeader
    Friend WithEvents Brand As ColumnHeader
    Friend WithEvents Size As ColumnHeader
    Friend WithEvents Color As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Remarks As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
