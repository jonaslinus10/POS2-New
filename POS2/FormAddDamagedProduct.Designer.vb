<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddDamagedProduct
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblProdName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbRemarks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(424, 2)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(63, 65)
        Me.BtnExit.TabIndex = 78
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(123, 174)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 28)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Date"
        '
        'DtpDate
        '
        Me.DtpDate.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDate.Location = New System.Drawing.Point(122, 208)
        Me.DtpDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(348, 34)
        Me.DtpDate.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 45)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Stock-Out Item"
        '
        'LblProdName
        '
        Me.LblProdName.AutoSize = True
        Me.LblProdName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblProdName.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProdName.ForeColor = System.Drawing.Color.Sienna
        Me.LblProdName.Location = New System.Drawing.Point(38, 130)
        Me.LblProdName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProdName.Name = "LblProdName"
        Me.LblProdName.Size = New System.Drawing.Size(81, 32)
        Me.LblProdName.TabIndex = 84
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
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Item Name"
        '
        'TbQty
        '
        Me.TbQty.BackColor = System.Drawing.Color.White
        Me.TbQty.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbQty.Location = New System.Drawing.Point(27, 208)
        Me.TbQty.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbQty.Name = "TbQty"
        Me.TbQty.Size = New System.Drawing.Size(84, 33)
        Me.TbQty.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 174)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 28)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Quantity"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSave.Location = New System.Drawing.Point(142, 400)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(214, 55)
        Me.BtnSave.TabIndex = 87
        Me.BtnSave.Text = "Proceed"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 250)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 28)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Remarks"
        '
        'TbRemarks
        '
        Me.TbRemarks.BackColor = System.Drawing.Color.White
        Me.TbRemarks.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbRemarks.Location = New System.Drawing.Point(18, 282)
        Me.TbRemarks.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TbRemarks.Multiline = True
        Me.TbRemarks.Name = "TbRemarks"
        Me.TbRemarks.Size = New System.Drawing.Size(451, 87)
        Me.TbRemarks.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Sienna
        Me.Label5.Location = New System.Drawing.Point(381, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 32)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(332, 98)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 28)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Item Quantity"
        '
        'FormAddDamagedProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(489, 466)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbRemarks)
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
        Me.Name = "FormAddDamagedProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddDamagedProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents LblProdName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbQty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TbRemarks As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
