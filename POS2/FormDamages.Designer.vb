<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDamages
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DtpDamages = New System.Windows.Forms.DateTimePicker()
        Me.BtnDamagePrint = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbFormDamagesSearch = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LvReportsDamages = New System.Windows.Forms.ListView()
        Me.itemid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Classification = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sizes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colors = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.remarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.date_damage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DtpDamages)
        Me.Panel3.Controls.Add(Me.BtnDamagePrint)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TbFormDamagesSearch)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(938, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(445, 118)
        Me.Panel3.TabIndex = 3
        '
        'DtpDamages
        '
        Me.DtpDamages.CalendarFont = New System.Drawing.Font("Nirmala UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDamages.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDamages.Location = New System.Drawing.Point(6, 31)
        Me.DtpDamages.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpDamages.Name = "DtpDamages"
        Me.DtpDamages.Size = New System.Drawing.Size(290, 27)
        Me.DtpDamages.TabIndex = 7
        '
        'BtnDamagePrint
        '
        Me.BtnDamagePrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnDamagePrint.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDamagePrint.ForeColor = System.Drawing.Color.White
        Me.BtnDamagePrint.Location = New System.Drawing.Point(311, 80)
        Me.BtnDamagePrint.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDamagePrint.Name = "BtnDamagePrint"
        Me.BtnDamagePrint.Size = New System.Drawing.Size(126, 32)
        Me.BtnDamagePrint.TabIndex = 6
        Me.BtnDamagePrint.Text = "Print"
        Me.BtnDamagePrint.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Filter by Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search By Item Id"
        '
        'TbFormDamagesSearch
        '
        Me.TbFormDamagesSearch.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbFormDamagesSearch.Location = New System.Drawing.Point(8, 85)
        Me.TbFormDamagesSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TbFormDamagesSearch.Name = "TbFormDamagesSearch"
        Me.TbFormDamagesSearch.Size = New System.Drawing.Size(290, 27)
        Me.TbFormDamagesSearch.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LvReportsDamages)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 118)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1383, 481)
        Me.Panel2.TabIndex = 3
        '
        'LvReportsDamages
        '
        Me.LvReportsDamages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LvReportsDamages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.itemid, Me.category, Me.ItemName, Me.Classification, Me.Brand, Me.Sizes, Me.Colors, Me.Quantity, Me.remarks, Me.date_damage})
        Me.LvReportsDamages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvReportsDamages.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvReportsDamages.FullRowSelect = True
        Me.LvReportsDamages.GridLines = True
        Me.LvReportsDamages.HideSelection = False
        Me.LvReportsDamages.Location = New System.Drawing.Point(0, 0)
        Me.LvReportsDamages.Margin = New System.Windows.Forms.Padding(4)
        Me.LvReportsDamages.MultiSelect = False
        Me.LvReportsDamages.Name = "LvReportsDamages"
        Me.LvReportsDamages.Size = New System.Drawing.Size(1383, 481)
        Me.LvReportsDamages.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.LvReportsDamages.TabIndex = 10
        Me.LvReportsDamages.UseCompatibleStateImageBehavior = False
        Me.LvReportsDamages.View = System.Windows.Forms.View.Details
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
        'remarks
        '
        Me.remarks.Text = "Remarks"
        Me.remarks.Width = 100
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
        Me.Panel1.Size = New System.Drawing.Size(1383, 118)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(8, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 54)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Damaged Items"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(493, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(445, 118)
        Me.Panel4.TabIndex = 4
        '
        'date_damage
        '
        Me.date_damage.Text = "Date"
        '
        'FormDamages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1383, 599)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormDamages"
        Me.Text = "FormDamages"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TbFormDamagesSearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents DtpDamages As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDamagePrint As Button
    Friend WithEvents LvReportsDamages As ListView
    Friend WithEvents itemid As ColumnHeader
    Friend WithEvents category As ColumnHeader
    Friend WithEvents ItemName As ColumnHeader
    Friend WithEvents Classification As ColumnHeader
    Friend WithEvents Brand As ColumnHeader
    Friend WithEvents Sizes As ColumnHeader
    Friend WithEvents Colors As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents remarks As ColumnHeader
    Friend WithEvents date_damage As ColumnHeader
End Class
