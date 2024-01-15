<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInventory
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
        Me.InventoryPanelLoader = New System.Windows.Forms.Panel()
        Me.PnlForMenuBtns = New System.Windows.Forms.Panel()
        Me.BtnGotoProducts = New System.Windows.Forms.Button()
        Me.PnlForMenuBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'InventoryPanelLoader
        '
        Me.InventoryPanelLoader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InventoryPanelLoader.Location = New System.Drawing.Point(232, 0)
        Me.InventoryPanelLoader.Name = "InventoryPanelLoader"
        Me.InventoryPanelLoader.Size = New System.Drawing.Size(630, 487)
        Me.InventoryPanelLoader.TabIndex = 5
        '
        'PnlForMenuBtns
        '
        Me.PnlForMenuBtns.BackColor = System.Drawing.Color.Brown
        Me.PnlForMenuBtns.Controls.Add(Me.BtnGotoProducts)
        Me.PnlForMenuBtns.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlForMenuBtns.Location = New System.Drawing.Point(0, 0)
        Me.PnlForMenuBtns.Name = "PnlForMenuBtns"
        Me.PnlForMenuBtns.Size = New System.Drawing.Size(232, 487)
        Me.PnlForMenuBtns.TabIndex = 4
        '
        'BtnGotoProducts
        '
        Me.BtnGotoProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGotoProducts.FlatAppearance.BorderSize = 0
        Me.BtnGotoProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGotoProducts.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGotoProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGotoProducts.Image = Global.POS2.My.Resources.Resources.sales
        Me.BtnGotoProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGotoProducts.Location = New System.Drawing.Point(0, 0)
        Me.BtnGotoProducts.Name = "BtnGotoProducts"
        Me.BtnGotoProducts.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.BtnGotoProducts.Size = New System.Drawing.Size(232, 48)
        Me.BtnGotoProducts.TabIndex = 1
        Me.BtnGotoProducts.Text = "Items"
        Me.BtnGotoProducts.UseVisualStyleBackColor = True
        '
        'FormInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 487)
        Me.Controls.Add(Me.InventoryPanelLoader)
        Me.Controls.Add(Me.PnlForMenuBtns)
        Me.Name = "FormInventory"
        Me.Text = "FormInventory"
        Me.PnlForMenuBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InventoryPanelLoader As Panel
    Friend WithEvents PnlForMenuBtns As Panel
    Public WithEvents BtnGotoProducts As Button
End Class
