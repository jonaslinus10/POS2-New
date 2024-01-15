<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReports
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
        Me.PnlForMenuBtns = New System.Windows.Forms.Panel()
        Me.BtnDelivered = New System.Windows.Forms.Button()
        Me.BtnReturns = New System.Windows.Forms.Button()
        Me.BtnSales = New System.Windows.Forms.Button()
        Me.reportsPnlLoader = New System.Windows.Forms.Panel()
        Me.BtnGotoDamagedProducts = New System.Windows.Forms.Button()
        Me.BtnGotoExpiredProducts = New System.Windows.Forms.Button()
        Me.PnlForMenuBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlForMenuBtns
        '
        Me.PnlForMenuBtns.BackColor = System.Drawing.Color.Brown
        Me.PnlForMenuBtns.Controls.Add(Me.BtnGotoDamagedProducts)
        Me.PnlForMenuBtns.Controls.Add(Me.BtnGotoExpiredProducts)
        Me.PnlForMenuBtns.Controls.Add(Me.BtnDelivered)
        Me.PnlForMenuBtns.Controls.Add(Me.BtnReturns)
        Me.PnlForMenuBtns.Controls.Add(Me.BtnSales)
        Me.PnlForMenuBtns.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlForMenuBtns.Location = New System.Drawing.Point(0, 0)
        Me.PnlForMenuBtns.Name = "PnlForMenuBtns"
        Me.PnlForMenuBtns.Size = New System.Drawing.Size(232, 487)
        Me.PnlForMenuBtns.TabIndex = 2
        '
        'BtnDelivered
        '
        Me.BtnDelivered.BackColor = System.Drawing.Color.Brown
        Me.BtnDelivered.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDelivered.FlatAppearance.BorderSize = 0
        Me.BtnDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelivered.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelivered.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnDelivered.Image = Global.POS2.My.Resources.Resources.delivery
        Me.BtnDelivered.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelivered.Location = New System.Drawing.Point(0, 96)
        Me.BtnDelivered.Name = "BtnDelivered"
        Me.BtnDelivered.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.BtnDelivered.Size = New System.Drawing.Size(232, 48)
        Me.BtnDelivered.TabIndex = 9
        Me.BtnDelivered.Text = "Deliveries"
        Me.BtnDelivered.UseVisualStyleBackColor = False
        '
        'BtnReturns
        '
        Me.BtnReturns.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReturns.FlatAppearance.BorderSize = 0
        Me.BtnReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturns.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturns.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnReturns.Image = Global.POS2.My.Resources.Resources._return
        Me.BtnReturns.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReturns.Location = New System.Drawing.Point(0, 48)
        Me.BtnReturns.Name = "BtnReturns"
        Me.BtnReturns.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.BtnReturns.Size = New System.Drawing.Size(232, 48)
        Me.BtnReturns.TabIndex = 3
        Me.BtnReturns.Text = "Returns"
        Me.BtnReturns.UseVisualStyleBackColor = True
        '
        'BtnSales
        '
        Me.BtnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSales.FlatAppearance.BorderSize = 0
        Me.BtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSales.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSales.Image = Global.POS2.My.Resources.Resources.sales
        Me.BtnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSales.Location = New System.Drawing.Point(0, 0)
        Me.BtnSales.Name = "BtnSales"
        Me.BtnSales.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.BtnSales.Size = New System.Drawing.Size(232, 48)
        Me.BtnSales.TabIndex = 1
        Me.BtnSales.Text = "Sales"
        Me.BtnSales.UseVisualStyleBackColor = True
        '
        'reportsPnlLoader
        '
        Me.reportsPnlLoader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportsPnlLoader.Location = New System.Drawing.Point(232, 0)
        Me.reportsPnlLoader.Name = "reportsPnlLoader"
        Me.reportsPnlLoader.Size = New System.Drawing.Size(596, 487)
        Me.reportsPnlLoader.TabIndex = 3
        '
        'BtnGotoDamagedProducts
        '
        Me.BtnGotoDamagedProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGotoDamagedProducts.FlatAppearance.BorderSize = 0
        Me.BtnGotoDamagedProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGotoDamagedProducts.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGotoDamagedProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGotoDamagedProducts.Image = Global.POS2.My.Resources.Resources.damaged
        Me.BtnGotoDamagedProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGotoDamagedProducts.Location = New System.Drawing.Point(0, 192)
        Me.BtnGotoDamagedProducts.Name = "BtnGotoDamagedProducts"
        Me.BtnGotoDamagedProducts.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.BtnGotoDamagedProducts.Size = New System.Drawing.Size(232, 48)
        Me.BtnGotoDamagedProducts.TabIndex = 13
        Me.BtnGotoDamagedProducts.Text = "Damaged Items"
        Me.BtnGotoDamagedProducts.UseVisualStyleBackColor = True
        '
        'BtnGotoExpiredProducts
        '
        Me.BtnGotoExpiredProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGotoExpiredProducts.FlatAppearance.BorderSize = 0
        Me.BtnGotoExpiredProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGotoExpiredProducts.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGotoExpiredProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGotoExpiredProducts.Image = Global.POS2.My.Resources.Resources.damaged
        Me.BtnGotoExpiredProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGotoExpiredProducts.Location = New System.Drawing.Point(0, 144)
        Me.BtnGotoExpiredProducts.Name = "BtnGotoExpiredProducts"
        Me.BtnGotoExpiredProducts.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.BtnGotoExpiredProducts.Size = New System.Drawing.Size(232, 48)
        Me.BtnGotoExpiredProducts.TabIndex = 12
        Me.BtnGotoExpiredProducts.Text = "Expired Items"
        Me.BtnGotoExpiredProducts.UseVisualStyleBackColor = True
        '
        'FormReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 487)
        Me.Controls.Add(Me.reportsPnlLoader)
        Me.Controls.Add(Me.PnlForMenuBtns)
        Me.Name = "FormReports"
        Me.Text = "FormSalesReport"
        Me.PnlForMenuBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlForMenuBtns As Panel
    Friend WithEvents BtnReturns As Button
    Friend WithEvents reportsPnlLoader As Panel
    Public WithEvents BtnSales As Button
    Friend WithEvents BtnDelivered As Button
    Friend WithEvents BtnGotoDamagedProducts As Button
    Friend WithEvents BtnGotoExpiredProducts As Button
End Class
