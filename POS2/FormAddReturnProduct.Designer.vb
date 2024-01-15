<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddReturnProduct
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
        Me.BtnSaveProduct = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.returnGraph = New System.Windows.Forms.ListView()
        Me.InvoiceNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sales_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSaveProduct
        '
        Me.BtnSaveProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveProduct.FlatAppearance.BorderSize = 0
        Me.BtnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveProduct.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveProduct.ForeColor = System.Drawing.Color.Black
        Me.BtnSaveProduct.Location = New System.Drawing.Point(111, 514)
        Me.BtnSaveProduct.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnSaveProduct.Name = "BtnSaveProduct"
        Me.BtnSaveProduct.Size = New System.Drawing.Size(190, 44)
        Me.BtnSaveProduct.TabIndex = 57
        Me.BtnSaveProduct.Text = "Proceed"
        Me.BtnSaveProduct.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 37)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Return Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Invoice Number"
        '
        'TbInvoiceNumber
        '
        Me.TbInvoiceNumber.BackColor = System.Drawing.Color.White
        Me.TbInvoiceNumber.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbInvoiceNumber.Location = New System.Drawing.Point(30, 94)
        Me.TbInvoiceNumber.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbInvoiceNumber.MaxLength = 9
        Me.TbInvoiceNumber.Name = "TbInvoiceNumber"
        Me.TbInvoiceNumber.Size = New System.Drawing.Size(358, 29)
        Me.TbInvoiceNumber.TabIndex = 59
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'returnGraph
        '
        Me.returnGraph.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.InvoiceNumber, Me.sales_date})
        Me.returnGraph.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnGraph.HideSelection = False
        Me.returnGraph.Location = New System.Drawing.Point(31, 133)
        Me.returnGraph.Name = "returnGraph"
        Me.returnGraph.Size = New System.Drawing.Size(357, 365)
        Me.returnGraph.TabIndex = 61
        Me.returnGraph.UseCompatibleStateImageBehavior = False
        Me.returnGraph.View = System.Windows.Forms.View.Details
        '
        'InvoiceNumber
        '
        Me.InvoiceNumber.Text = "Invoice Number"
        Me.InvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InvoiceNumber.Width = 200
        '
        'sales_date
        '
        Me.sales_date.Text = "Date"
        Me.sales_date.Width = 150
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(370, 2)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(56, 52)
        Me.BtnExit.TabIndex = 56
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FormAddReturnProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(427, 590)
        Me.Controls.Add(Me.returnGraph)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbInvoiceNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSaveProduct)
        Me.Controls.Add(Me.BtnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormAddReturnProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddReturnProduct"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSaveProduct As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbInvoiceNumber As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents returnGraph As ListView
    Friend WithEvents InvoiceNumber As ColumnHeader
    Friend WithEvents sales_date As ColumnHeader
End Class
