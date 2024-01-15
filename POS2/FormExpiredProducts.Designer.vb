<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormExpiredProducts
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnExpiredPrint = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbFormExpiredSearch = New System.Windows.Forms.TextBox()
        Me.DtpExpired = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LvReportsExpirees = New System.Windows.Forms.ListView()
        Me.itemid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Classification = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sizes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colors = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExpirationDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnExpiredPrint)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TbFormExpiredSearch)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(766, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(445, 118)
        Me.Panel3.TabIndex = 3
        '
        'BtnExpiredPrint
        '
        Me.BtnExpiredPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnExpiredPrint.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnExpiredPrint.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExpiredPrint.Location = New System.Drawing.Point(306, 72)
        Me.BtnExpiredPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExpiredPrint.Name = "BtnExpiredPrint"
        Me.BtnExpiredPrint.Size = New System.Drawing.Size(126, 32)
        Me.BtnExpiredPrint.TabIndex = 6
        Me.BtnExpiredPrint.Text = "Print"
        Me.BtnExpiredPrint.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search By Item Id"
        '
        'TbFormExpiredSearch
        '
        Me.TbFormExpiredSearch.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbFormExpiredSearch.Location = New System.Drawing.Point(8, 77)
        Me.TbFormExpiredSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TbFormExpiredSearch.Name = "TbFormExpiredSearch"
        Me.TbFormExpiredSearch.Size = New System.Drawing.Size(290, 27)
        Me.TbFormExpiredSearch.TabIndex = 0
        '
        'DtpExpired
        '
        Me.DtpExpired.CalendarFont = New System.Drawing.Font("Nirmala UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpExpired.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpExpired.Location = New System.Drawing.Point(15, 80)
        Me.DtpExpired.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpExpired.Name = "DtpExpired"
        Me.DtpExpired.Size = New System.Drawing.Size(290, 27)
        Me.DtpExpired.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Filter by Date "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LvReportsExpirees)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 118)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1211, 481)
        Me.Panel2.TabIndex = 5
        '
        'LvReportsExpirees
        '
        Me.LvReportsExpirees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LvReportsExpirees.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.itemid, Me.category, Me.ItemName, Me.Classification, Me.Brand, Me.Sizes, Me.Colors, Me.Quantity, Me.ExpirationDate})
        Me.LvReportsExpirees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvReportsExpirees.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvReportsExpirees.FullRowSelect = True
        Me.LvReportsExpirees.GridLines = True
        Me.LvReportsExpirees.HideSelection = False
        Me.LvReportsExpirees.Location = New System.Drawing.Point(0, 0)
        Me.LvReportsExpirees.Margin = New System.Windows.Forms.Padding(4)
        Me.LvReportsExpirees.MultiSelect = False
        Me.LvReportsExpirees.Name = "LvReportsExpirees"
        Me.LvReportsExpirees.Size = New System.Drawing.Size(1211, 481)
        Me.LvReportsExpirees.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.LvReportsExpirees.TabIndex = 9
        Me.LvReportsExpirees.UseCompatibleStateImageBehavior = False
        Me.LvReportsExpirees.View = System.Windows.Forms.View.Details
        '
        'itemid
        '
        Me.itemid.Text = "Item Code"
        Me.itemid.Width = 150
        '
        'category
        '
        Me.category.Text = "Item Category"
        Me.category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.category.Width = 180
        '
        'ItemName
        '
        Me.ItemName.Text = "Item Name"
        Me.ItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ItemName.Width = 220
        '
        'Classification
        '
        Me.Classification.Text = "Classification"
        Me.Classification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Classification.Width = 183
        '
        'Brand
        '
        Me.Brand.Text = "Item Brand"
        Me.Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Brand.Width = 145
        '
        'Sizes
        '
        Me.Sizes.Text = "Size"
        Me.Sizes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sizes.Width = 125
        '
        'Colors
        '
        Me.Colors.Text = "Color"
        Me.Colors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Colors.Width = 110
        '
        'Quantity
        '
        Me.Quantity.Text = "QTY"
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Quantity.Width = 101
        '
        'ExpirationDate
        '
        Me.ExpirationDate.Text = "Expiration"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1211, 118)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(8, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 54)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Expired Items"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DtpExpired)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(321, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(445, 118)
        Me.Panel4.TabIndex = 4
        '
        'FormExpiredProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 599)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormExpiredProducts"
        Me.Text = "FormExpiredProducts"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TbFormExpiredSearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DtpExpired As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExpiredPrint As Button
    Friend WithEvents LvReportsExpirees As ListView
    Friend WithEvents itemid As ColumnHeader
    Friend WithEvents category As ColumnHeader
    Friend WithEvents ItemName As ColumnHeader
    Friend WithEvents Classification As ColumnHeader
    Friend WithEvents Brand As ColumnHeader
    Friend WithEvents Sizes As ColumnHeader
    Friend WithEvents Colors As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents ExpirationDate As ColumnHeader
End Class
