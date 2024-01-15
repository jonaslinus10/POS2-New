<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrintPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrintPreview))
        Me.txtPDF = New System.Windows.Forms.Button()
        Me.PrintFileMenuItem = New System.Windows.Forms.Button()
        Me.PageUpDown = New System.Windows.Forms.NumericUpDown()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.printPreviewControl = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnZoomIn = New System.Windows.Forms.Button()
        Me.btnZoomOut = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.PageUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPDF
        '
        Me.txtPDF.Location = New System.Drawing.Point(415, 66)
        Me.txtPDF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPDF.Name = "txtPDF"
        Me.txtPDF.Size = New System.Drawing.Size(175, 28)
        Me.txtPDF.TabIndex = 94
        Me.txtPDF.Text = "Download as PDF"
        Me.txtPDF.UseVisualStyleBackColor = True
        '
        'PrintFileMenuItem
        '
        Me.PrintFileMenuItem.Location = New System.Drawing.Point(598, 65)
        Me.PrintFileMenuItem.Margin = New System.Windows.Forms.Padding(4)
        Me.PrintFileMenuItem.Name = "PrintFileMenuItem"
        Me.PrintFileMenuItem.Size = New System.Drawing.Size(100, 28)
        Me.PrintFileMenuItem.TabIndex = 93
        Me.PrintFileMenuItem.Text = "Print"
        Me.PrintFileMenuItem.UseVisualStyleBackColor = True
        '
        'PageUpDown
        '
        Me.PageUpDown.Location = New System.Drawing.Point(43, 68)
        Me.PageUpDown.Margin = New System.Windows.Forms.Padding(4)
        Me.PageUpDown.Name = "PageUpDown"
        Me.PageUpDown.Size = New System.Drawing.Size(71, 24)
        Me.PageUpDown.TabIndex = 92
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'printPreviewControl
        '
        Me.printPreviewControl.AutoZoom = False
        Me.printPreviewControl.Location = New System.Drawing.Point(40, 102)
        Me.printPreviewControl.Margin = New System.Windows.Forms.Padding(4)
        Me.printPreviewControl.Name = "printPreviewControl"
        Me.printPreviewControl.Size = New System.Drawing.Size(658, 562)
        Me.printPreviewControl.TabIndex = 97
        Me.printPreviewControl.Zoom = 0.4R
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnZoomIn
        '
        Me.btnZoomIn.Location = New System.Drawing.Point(488, 603)
        Me.btnZoomIn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(87, 28)
        Me.btnZoomIn.TabIndex = 99
        Me.btnZoomIn.Text = "Zoom In"
        Me.btnZoomIn.UseVisualStyleBackColor = True
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Enabled = False
        Me.btnZoomOut.Location = New System.Drawing.Point(582, 603)
        Me.btnZoomOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(87, 28)
        Me.btnZoomOut.TabIndex = 98
        Me.btnZoomOut.Text = "Zoom Out"
        Me.btnZoomOut.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = Global.POS2.My.Resources.Resources.ic_exit
        Me.BtnExit.Location = New System.Drawing.Point(686, 2)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(43, 43)
        Me.BtnExit.TabIndex = 96
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FormPrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(732, 700)
        Me.Controls.Add(Me.btnZoomIn)
        Me.Controls.Add(Me.btnZoomOut)
        Me.Controls.Add(Me.printPreviewControl)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.txtPDF)
        Me.Controls.Add(Me.PrintFileMenuItem)
        Me.Controls.Add(Me.PageUpDown)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrintPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Account"
        CType(Me.PageUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPDF As Button
    Friend WithEvents PrintFileMenuItem As Button
    Friend WithEvents PageUpDown As NumericUpDown
    Friend WithEvents BtnExit As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents printPreviewControl As PrintPreviewControl
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnZoomIn As Button
    Friend WithEvents btnZoomOut As Button
End Class
