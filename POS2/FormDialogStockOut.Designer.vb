<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDialogStockOut
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnDialogStockOutExpired = New System.Windows.Forms.Button()
        Me.BtnDialogStockOutDamaged = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Stock-Out Type"
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(358, 2)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(63, 65)
        Me.BtnExit.TabIndex = 56
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnDialogStockOutExpired
        '
        Me.BtnDialogStockOutExpired.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnDialogStockOutExpired.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDialogStockOutExpired.FlatAppearance.BorderSize = 0
        Me.BtnDialogStockOutExpired.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDialogStockOutExpired.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDialogStockOutExpired.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDialogStockOutExpired.Location = New System.Drawing.Point(100, 120)
        Me.BtnDialogStockOutExpired.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnDialogStockOutExpired.Name = "BtnDialogStockOutExpired"
        Me.BtnDialogStockOutExpired.Size = New System.Drawing.Size(214, 55)
        Me.BtnDialogStockOutExpired.TabIndex = 59
        Me.BtnDialogStockOutExpired.Text = "Expired"
        Me.BtnDialogStockOutExpired.UseVisualStyleBackColor = False
        '
        'BtnDialogStockOutDamaged
        '
        Me.BtnDialogStockOutDamaged.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnDialogStockOutDamaged.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDialogStockOutDamaged.FlatAppearance.BorderSize = 0
        Me.BtnDialogStockOutDamaged.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDialogStockOutDamaged.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDialogStockOutDamaged.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDialogStockOutDamaged.Location = New System.Drawing.Point(100, 188)
        Me.BtnDialogStockOutDamaged.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnDialogStockOutDamaged.Name = "BtnDialogStockOutDamaged"
        Me.BtnDialogStockOutDamaged.Size = New System.Drawing.Size(214, 55)
        Me.BtnDialogStockOutDamaged.TabIndex = 58
        Me.BtnDialogStockOutDamaged.Text = "Damaged"
        Me.BtnDialogStockOutDamaged.UseVisualStyleBackColor = False
        '
        'FormDialogStockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(423, 331)
        Me.Controls.Add(Me.BtnDialogStockOutExpired)
        Me.Controls.Add(Me.BtnDialogStockOutDamaged)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormDialogStockOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDialogStockOut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnDialogStockOutExpired As Button
    Friend WithEvents BtnDialogStockOutDamaged As Button
End Class
