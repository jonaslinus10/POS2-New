<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditItemOrder
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAddItemBack = New System.Windows.Forms.Button()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbItemQty = New System.Windows.Forms.TextBox()
        Me.LblItemUnit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAddItemEnter = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(26, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(239, 37)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Edit Items in Cart"
        '
        'BtnAddItemBack
        '
        Me.BtnAddItemBack.FlatAppearance.BorderSize = 0
        Me.BtnAddItemBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItemBack.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnAddItemBack.Location = New System.Drawing.Point(313, 7)
        Me.BtnAddItemBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAddItemBack.Name = "BtnAddItemBack"
        Me.BtnAddItemBack.Size = New System.Drawing.Size(64, 59)
        Me.BtnAddItemBack.TabIndex = 51
        Me.BtnAddItemBack.UseVisualStyleBackColor = True
        '
        'LblItemName
        '
        Me.LblItemName.Font = New System.Drawing.Font("Nirmala UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.LblItemName.Location = New System.Drawing.Point(32, 64)
        Me.LblItemName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(327, 38)
        Me.LblItemName.TabIndex = 52
        Me.LblItemName.Text = "Item Name"
        Me.LblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 39)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Stocks:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbItemQty
        '
        Me.TbItemQty.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbItemQty.Location = New System.Drawing.Point(106, 233)
        Me.TbItemQty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbItemQty.Name = "TbItemQty"
        Me.TbItemQty.Size = New System.Drawing.Size(201, 39)
        Me.TbItemQty.TabIndex = 66
        '
        'LblItemUnit
        '
        Me.LblItemUnit.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemUnit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.LblItemUnit.Location = New System.Drawing.Point(132, 123)
        Me.LblItemUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblItemUnit.Name = "LblItemUnit"
        Me.LblItemUnit.Size = New System.Drawing.Size(130, 39)
        Me.LblItemUnit.TabIndex = 78
        Me.LblItemUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(146, 158)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 39)
        Me.Label1.TabIndex = 79
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Input the QTY:"
        '
        'BtnAddItemEnter
        '
        Me.BtnAddItemEnter.BackColor = System.Drawing.Color.DarkRed
        Me.BtnAddItemEnter.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItemEnter.ForeColor = System.Drawing.Color.Transparent
        Me.BtnAddItemEnter.Location = New System.Drawing.Point(101, 275)
        Me.BtnAddItemEnter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddItemEnter.Name = "BtnAddItemEnter"
        Me.BtnAddItemEnter.Size = New System.Drawing.Size(92, 48)
        Me.BtnAddItemEnter.TabIndex = 81
        Me.BtnAddItemEnter.Text = "Enter"
        Me.BtnAddItemEnter.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnClear.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(211, 275)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(92, 48)
        Me.BtnClear.TabIndex = 82
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'FormEditItemOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(380, 343)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnAddItemEnter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbItemQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblItemUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblItemName)
        Me.Controls.Add(Me.BtnAddItemBack)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormEditItemOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddItemOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAddItemBack As Button
    Friend WithEvents LblItemName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbItemQty As TextBox
    Friend WithEvents LblItemUnit As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAddItemEnter As Button
    Friend WithEvents BtnClear As Button
End Class
