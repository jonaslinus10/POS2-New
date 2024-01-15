<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddExpiredProduct
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbQty = New System.Windows.Forms.TextBox()
        Me.LblProdName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSave.Location = New System.Drawing.Point(134, 366)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(214, 55)
        Me.BtnSave.TabIndex = 98
        Me.BtnSave.Text = "Proceed"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 28)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Quantity"
        '
        'TbQty
        '
        Me.TbQty.BackColor = System.Drawing.Color.White
        Me.TbQty.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbQty.Location = New System.Drawing.Point(27, 206)
        Me.TbQty.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbQty.Name = "TbQty"
        Me.TbQty.Size = New System.Drawing.Size(100, 34)
        Me.TbQty.TabIndex = 96
        '
        'LblProdName
        '
        Me.LblProdName.AutoSize = True
        Me.LblProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProdName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblProdName.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProdName.ForeColor = System.Drawing.Color.Sienna
        Me.LblProdName.Location = New System.Drawing.Point(42, 130)
        Me.LblProdName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProdName.Name = "LblProdName"
        Me.LblProdName.Size = New System.Drawing.Size(83, 34)
        Me.LblProdName.TabIndex = 95
        Me.LblProdName.Text = "Name"
        Me.LblProdName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 28)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 45)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Add Expired Item"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(22, 248)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 28)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Date"
        '
        'DtpDate
        '
        Me.DtpDate.Enabled = False
        Me.DtpDate.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDate.Location = New System.Drawing.Point(28, 282)
        Me.DtpDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(407, 34)
        Me.DtpDate.TabIndex = 91
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(422, 2)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(63, 65)
        Me.BtnExit.TabIndex = 90
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Sienna
        Me.Label4.Location = New System.Drawing.Point(370, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 34)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(332, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 28)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Item Quantity"
        '
        'FormAddExpiredProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(489, 466)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbQty)
        Me.Controls.Add(Me.LblProdName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtpDate)
        Me.Controls.Add(Me.BtnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormAddExpiredProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddExpiredProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TbQty As TextBox
    Friend WithEvents LblProdName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
