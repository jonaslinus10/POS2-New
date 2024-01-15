<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStockInventory
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
        Me.BtnProductsDeleteMarked = New System.Windows.Forms.Button()
        Me.BtnProductsUnmarkAll = New System.Windows.Forms.Button()
        Me.BtnAddProduct = New System.Windows.Forms.Button()
        Me.BtnProductsMarkAll = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LvProducts = New System.Windows.Forms.ListView()
        Me.itemid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Classification = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sizes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Colors = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Stockunit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnFormInvPrint = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnFormInventoryRefresh = New System.Windows.Forms.Button()
        Me.CbInventoryCats = New System.Windows.Forms.ComboBox()
        Me.TbProductSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnProductsDeleteMarked
        '
        Me.BtnProductsDeleteMarked.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnProductsDeleteMarked.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductsDeleteMarked.Location = New System.Drawing.Point(351, 64)
        Me.BtnProductsDeleteMarked.Name = "BtnProductsDeleteMarked"
        Me.BtnProductsDeleteMarked.Size = New System.Drawing.Size(143, 37)
        Me.BtnProductsDeleteMarked.TabIndex = 8
        Me.BtnProductsDeleteMarked.Text = "Archived Marked"
        Me.BtnProductsDeleteMarked.UseVisualStyleBackColor = False
        '
        'BtnProductsUnmarkAll
        '
        Me.BtnProductsUnmarkAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BtnProductsUnmarkAll.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductsUnmarkAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnProductsUnmarkAll.Location = New System.Drawing.Point(16, 63)
        Me.BtnProductsUnmarkAll.Name = "BtnProductsUnmarkAll"
        Me.BtnProductsUnmarkAll.Size = New System.Drawing.Size(143, 37)
        Me.BtnProductsUnmarkAll.TabIndex = 7
        Me.BtnProductsUnmarkAll.Text = "Unmark All"
        Me.BtnProductsUnmarkAll.UseVisualStyleBackColor = False
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnAddProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAddProduct.Image = Global.POS2.My.Resources.Resources.ic_add
        Me.BtnAddProduct.Location = New System.Drawing.Point(665, 39)
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(117, 64)
        Me.BtnAddProduct.TabIndex = 4
        Me.BtnAddProduct.Text = "Add Item"
        Me.BtnAddProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnAddProduct.UseVisualStyleBackColor = False
        '
        'BtnProductsMarkAll
        '
        Me.BtnProductsMarkAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnProductsMarkAll.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductsMarkAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnProductsMarkAll.Location = New System.Drawing.Point(183, 64)
        Me.BtnProductsMarkAll.Name = "BtnProductsMarkAll"
        Me.BtnProductsMarkAll.Size = New System.Drawing.Size(143, 37)
        Me.BtnProductsMarkAll.TabIndex = 2
        Me.BtnProductsMarkAll.Text = "Mark All"
        Me.BtnProductsMarkAll.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LvProducts)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(913, 491)
        Me.Panel3.TabIndex = 7
        '
        'LvProducts
        '
        Me.LvProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LvProducts.CheckBoxes = True
        Me.LvProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.itemid, Me.category, Me.ItemName, Me.Classification, Me.Brand, Me.Sizes, Me.Colors, Me.Price1, Me.Stockunit, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvProducts.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvProducts.FullRowSelect = True
        Me.LvProducts.GridLines = True
        Me.LvProducts.HideSelection = False
        Me.LvProducts.Location = New System.Drawing.Point(0, 0)
        Me.LvProducts.MultiSelect = False
        Me.LvProducts.Name = "LvProducts"
        Me.LvProducts.Size = New System.Drawing.Size(913, 491)
        Me.LvProducts.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.LvProducts.TabIndex = 8
        Me.LvProducts.UseCompatibleStateImageBehavior = False
        Me.LvProducts.View = System.Windows.Forms.View.Details
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
        'Price1
        '
        Me.Price1.Text = "Price"
        Me.Price1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Price1.Width = 101
        '
        'Stockunit
        '
        Me.Stockunit.Text = "Stock"
        Me.Stockunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Stockunit.Width = 95
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Unit"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 105
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Expiration Date"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 105
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Critical Stock"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 85
        '
        'BtnFormInvPrint
        '
        Me.BtnFormInvPrint.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnFormInvPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnFormInvPrint.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormInvPrint.Location = New System.Drawing.Point(789, 39)
        Me.BtnFormInvPrint.Name = "BtnFormInvPrint"
        Me.BtnFormInvPrint.Size = New System.Drawing.Size(115, 64)
        Me.BtnFormInvPrint.TabIndex = 15
        Me.BtnFormInvPrint.Text = "Print"
        Me.BtnFormInvPrint.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(459, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Zero Stock Warning"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(428, 17)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 20)
        Me.Button3.TabIndex = 13
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Critical Stock Warning"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(225, 17)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 20)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Expired Item Warning"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(19, 17)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 20)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.BtnFormInventoryRefresh)
        Me.Panel2.Controls.Add(Me.CbInventoryCats)
        Me.Panel2.Controls.Add(Me.TbProductSearch)
        Me.Panel2.Location = New System.Drawing.Point(205, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(874, 101)
        Me.Panel2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(339, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Sort Categories"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(111, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Search by Item Name"
        '
        'BtnFormInventoryRefresh
        '
        Me.BtnFormInventoryRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnFormInventoryRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BtnFormInventoryRefresh.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormInventoryRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFormInventoryRefresh.Location = New System.Drawing.Point(575, 64)
        Me.BtnFormInventoryRefresh.Name = "BtnFormInventoryRefresh"
        Me.BtnFormInventoryRefresh.Size = New System.Drawing.Size(129, 25)
        Me.BtnFormInventoryRefresh.TabIndex = 10
        Me.BtnFormInventoryRefresh.Text = "Clear"
        Me.BtnFormInventoryRefresh.UseVisualStyleBackColor = False
        '
        'CbInventoryCats
        '
        Me.CbInventoryCats.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CbInventoryCats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbInventoryCats.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbInventoryCats.FormattingEnabled = True
        Me.CbInventoryCats.Location = New System.Drawing.Point(342, 64)
        Me.CbInventoryCats.Name = "CbInventoryCats"
        Me.CbInventoryCats.Size = New System.Drawing.Size(228, 23)
        Me.CbInventoryCats.TabIndex = 11
        '
        'TbProductSearch
        '
        Me.TbProductSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TbProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbProductSearch.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProductSearch.Location = New System.Drawing.Point(109, 64)
        Me.TbProductSearch.Name = "TbProductSearch"
        Me.TbProductSearch.Size = New System.Drawing.Size(227, 23)
        Me.TbProductSearch.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 104)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Items"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BtnFormInvPrint)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.BtnAddProduct)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.BtnProductsMarkAll)
        Me.Panel4.Controls.Add(Me.BtnProductsUnmarkAll)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.BtnProductsDeleteMarked)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 366)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(913, 113)
        Me.Panel4.TabIndex = 8
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'FormStockInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(913, 479)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormStockInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnProductsDeleteMarked As Button
    Friend WithEvents BtnProductsUnmarkAll As Button
    Friend WithEvents BtnAddProduct As Button
    Friend WithEvents BtnProductsMarkAll As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LvProducts As ListView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnFormInventoryRefresh As Button
    Friend WithEvents CbInventoryCats As ComboBox
    Friend WithEvents TbProductSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnFormInvPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents itemid As ColumnHeader
    Friend WithEvents category As ColumnHeader
    Friend WithEvents ItemName As ColumnHeader
    Friend WithEvents Classification As ColumnHeader
    Friend WithEvents Brand As ColumnHeader
    Friend WithEvents Sizes As ColumnHeader
    Friend WithEvents Colors As ColumnHeader
    Friend WithEvents Price1 As ColumnHeader
    Friend WithEvents Stockunit As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
