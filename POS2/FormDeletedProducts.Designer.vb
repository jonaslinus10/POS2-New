<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeletedProducts
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
        Me.Stock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Color = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnFormInventoryRefresh = New System.Windows.Forms.Button()
        Me.BtnFormInventorySearch = New System.Windows.Forms.Button()
        Me.CbInventoryCats = New System.Windows.Forms.ComboBox()
        Me.TbProductSearch = New System.Windows.Forms.TextBox()
        Me.Size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LvProducts = New System.Windows.Forms.ListView()
        Me.Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Expiration_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Stock
        '
        Me.Stock.Text = "Stock"
        Me.Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Stock.Width = 80
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Price.Width = 85
        '
        'Color
        '
        Me.Color.Text = "Color"
        Me.Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Color.Width = 86
        '
        'BtnFormInventoryRefresh
        '
        Me.BtnFormInventoryRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnFormInventoryRefresh.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormInventoryRefresh.Location = New System.Drawing.Point(377, 117)
        Me.BtnFormInventoryRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFormInventoryRefresh.Name = "BtnFormInventoryRefresh"
        Me.BtnFormInventoryRefresh.Size = New System.Drawing.Size(126, 32)
        Me.BtnFormInventoryRefresh.TabIndex = 10
        Me.BtnFormInventoryRefresh.Text = "Refresh"
        Me.BtnFormInventoryRefresh.UseVisualStyleBackColor = False
        '
        'BtnFormInventorySearch
        '
        Me.BtnFormInventorySearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnFormInventorySearch.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormInventorySearch.Location = New System.Drawing.Point(377, 81)
        Me.BtnFormInventorySearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnFormInventorySearch.Name = "BtnFormInventorySearch"
        Me.BtnFormInventorySearch.Size = New System.Drawing.Size(126, 32)
        Me.BtnFormInventorySearch.TabIndex = 9
        Me.BtnFormInventorySearch.Text = "Search"
        Me.BtnFormInventorySearch.UseVisualStyleBackColor = False
        '
        'CbInventoryCats
        '
        Me.CbInventoryCats.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbInventoryCats.FormattingEnabled = True
        Me.CbInventoryCats.Location = New System.Drawing.Point(14, 117)
        Me.CbInventoryCats.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbInventoryCats.Name = "CbInventoryCats"
        Me.CbInventoryCats.Size = New System.Drawing.Size(340, 28)
        Me.CbInventoryCats.TabIndex = 11
        '
        'TbProductSearch
        '
        Me.TbProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbProductSearch.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProductSearch.Location = New System.Drawing.Point(14, 85)
        Me.TbProductSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbProductSearch.Name = "TbProductSearch"
        Me.TbProductSearch.Size = New System.Drawing.Size(341, 27)
        Me.TbProductSearch.TabIndex = 0
        '
        'Size
        '
        Me.Size.Text = "Size"
        Me.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Size.Width = 95
        '
        'Unit
        '
        Me.Unit.Text = "Unit"
        Me.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Unit.Width = 85
        '
        'Category
        '
        Me.Category.Text = "Category"
        Me.Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Category.Width = 100
        '
        'Brand
        '
        Me.Brand.Text = "Brand"
        Me.Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Brand.Width = 100
        '
        'Id
        '
        Me.Id.Text = "Id"
        Me.Id.Width = 140
        '
        'LvProducts
        '
        Me.LvProducts.CheckBoxes = True
        Me.LvProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Name, Me.Brand, Me.Category, Me.Unit, Me.Size, Me.Color, Me.Price, Me.Expiration_Date, Me.Stock})
        Me.LvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvProducts.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvProducts.FullRowSelect = True
        Me.LvProducts.GridLines = True
        Me.LvProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LvProducts.HideSelection = False
        Me.LvProducts.Location = New System.Drawing.Point(0, 0)
        Me.LvProducts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LvProducts.Name = "LvProducts"
        Me.LvProducts.Size = New System.Drawing.Size(1239, 444)
        Me.LvProducts.TabIndex = 8
        Me.LvProducts.UseCompatibleStateImageBehavior = False
        Me.LvProducts.View = System.Windows.Forms.View.Details
        '
        'Name
        '
        Me.Name.Text = "Name"
        Me.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Name.Width = 150
        '
        'Expiration_Date
        '
        Me.Expiration_Date.Text = "Expiration Date"
        Me.Expiration_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Expiration_Date.Width = 120
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LvProducts)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 159)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1239, 444)
        Me.Panel3.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 159)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Archive Items"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.BtnFormInventoryRefresh)
        Me.Panel2.Controls.Add(Me.BtnFormInventorySearch)
        Me.Panel2.Controls.Add(Me.CbInventoryCats)
        Me.Panel2.Controls.Add(Me.TbProductSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(727, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(512, 159)
        Me.Panel2.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(16, 13)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 53)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Unmark All"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(340, 13)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 53)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Restore"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(177, 13)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(154, 53)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Mark All"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1239, 159)
        Me.Panel1.TabIndex = 8
        '
        'FormDeletedProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 603)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)

        Me.Text = "FormDeletedProducts"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Stock As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Color As ColumnHeader
    Friend WithEvents BtnFormInventoryRefresh As Button
    Friend WithEvents BtnFormInventorySearch As Button
    Friend WithEvents CbInventoryCats As ComboBox
    Friend WithEvents TbProductSearch As TextBox
    Friend WithEvents Size As ColumnHeader
    Friend WithEvents Unit As ColumnHeader
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents Brand As ColumnHeader
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents LvProducts As ListView
    Friend WithEvents Name As ColumnHeader
    Friend WithEvents Expiration_Date As ColumnHeader
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
End Class
