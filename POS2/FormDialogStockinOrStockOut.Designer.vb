<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDialogStockinOrStockOut
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
        Me.BtnStockOut = New System.Windows.Forms.Button()
        Me.BtnStockIn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 45)
        Me.Label1.TabIndex = 54
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(357, 2)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(63, 65)
        Me.BtnExit.TabIndex = 55
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnStockOut
        '
        Me.BtnStockOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnStockOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStockOut.FlatAppearance.BorderSize = 0
        Me.BtnStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStockOut.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnStockOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnStockOut.Location = New System.Drawing.Point(108, 184)
        Me.BtnStockOut.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnStockOut.Name = "BtnStockOut"
        Me.BtnStockOut.Size = New System.Drawing.Size(214, 55)
        Me.BtnStockOut.TabIndex = 56
        Me.BtnStockOut.Text = "Stock-Out"
        Me.BtnStockOut.UseVisualStyleBackColor = False
        '
        'BtnStockIn
        '
        Me.BtnStockIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnStockIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStockIn.FlatAppearance.BorderSize = 0
        Me.BtnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStockIn.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStockIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnStockIn.Location = New System.Drawing.Point(108, 113)
        Me.BtnStockIn.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BtnStockIn.Name = "BtnStockIn"
        Me.BtnStockIn.Size = New System.Drawing.Size(214, 55)
        Me.BtnStockIn.TabIndex = 57
        Me.BtnStockIn.Text = "Stock-In"
        Me.BtnStockIn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(18, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 45)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Stock-In/Stock-Out"
        '
        'FormDialogStockinOrStockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(422, 331)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnStockIn)
        Me.Controls.Add(Me.BtnStockOut)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormDialogStockinOrStockOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDialogStockinOrUpdateProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnStockOut As Button
    Friend WithEvents BtnStockIn As Button
    Friend WithEvents Label2 As Label
End Class
