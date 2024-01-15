<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMaintenance
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnBackupAndRestore = New System.Windows.Forms.Button()
        Me.BtnDeletedProducts = New System.Windows.Forms.Button()
        Me.BtnLogs = New System.Windows.Forms.Button()
        Me.PnlForContents = New System.Windows.Forms.Panel()
        Me.PnlForMenuBtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlForMenuBtns
        '
        Me.PnlForMenuBtns.BackColor = System.Drawing.Color.Brown
        Me.PnlForMenuBtns.Controls.Add(Me.Button1)
        Me.PnlForMenuBtns.Controls.Add(Me.BtnBackupAndRestore)
        Me.PnlForMenuBtns.Controls.Add(Me.BtnDeletedProducts)
        Me.PnlForMenuBtns.Controls.Add(Me.BtnLogs)
        Me.PnlForMenuBtns.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlForMenuBtns.Location = New System.Drawing.Point(0, 0)
        Me.PnlForMenuBtns.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlForMenuBtns.Name = "PnlForMenuBtns"
        Me.PnlForMenuBtns.Size = New System.Drawing.Size(283, 594)
        Me.PnlForMenuBtns.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(0, 177)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.Button1.Size = New System.Drawing.Size(283, 59)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "System Variables"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnBackupAndRestore
        '
        Me.BtnBackupAndRestore.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBackupAndRestore.FlatAppearance.BorderSize = 0
        Me.BtnBackupAndRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackupAndRestore.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBackupAndRestore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBackupAndRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBackupAndRestore.Location = New System.Drawing.Point(0, 118)
        Me.BtnBackupAndRestore.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBackupAndRestore.Name = "BtnBackupAndRestore"
        Me.BtnBackupAndRestore.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.BtnBackupAndRestore.Size = New System.Drawing.Size(283, 59)
        Me.BtnBackupAndRestore.TabIndex = 12
        Me.BtnBackupAndRestore.Text = "BackUp and Restore"
        Me.BtnBackupAndRestore.UseVisualStyleBackColor = True
        '
        'BtnDeletedProducts
        '
        Me.BtnDeletedProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDeletedProducts.FlatAppearance.BorderSize = 0
        Me.BtnDeletedProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeletedProducts.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeletedProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnDeletedProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDeletedProducts.Location = New System.Drawing.Point(0, 59)
        Me.BtnDeletedProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDeletedProducts.Name = "BtnDeletedProducts"
        Me.BtnDeletedProducts.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.BtnDeletedProducts.Size = New System.Drawing.Size(283, 59)
        Me.BtnDeletedProducts.TabIndex = 3
        Me.BtnDeletedProducts.Text = "Archive "
        Me.BtnDeletedProducts.UseVisualStyleBackColor = True
        '
        'BtnLogs
        '
        Me.BtnLogs.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLogs.FlatAppearance.BorderSize = 0
        Me.BtnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogs.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogs.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogs.Location = New System.Drawing.Point(0, 0)
        Me.BtnLogs.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLogs.Name = "BtnLogs"
        Me.BtnLogs.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.BtnLogs.Size = New System.Drawing.Size(283, 59)
        Me.BtnLogs.TabIndex = 2
        Me.BtnLogs.Text = "Logs"
        Me.BtnLogs.UseVisualStyleBackColor = True
        '
        'PnlForContents
        '
        Me.PnlForContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlForContents.Location = New System.Drawing.Point(283, 0)
        Me.PnlForContents.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlForContents.Name = "PnlForContents"
        Me.PnlForContents.Size = New System.Drawing.Size(949, 594)
        Me.PnlForContents.TabIndex = 12
        '
        'FormMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1232, 594)
        Me.Controls.Add(Me.PnlForContents)
        Me.Controls.Add(Me.PnlForMenuBtns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMaintenance"
        Me.PnlForMenuBtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlForMenuBtns As Panel
    Public WithEvents BtnDeletedProducts As Button
    Public WithEvents BtnLogs As Button
    Friend WithEvents PnlForContents As Panel
    Public WithEvents BtnBackupAndRestore As Button
    Public WithEvents Button1 As Button
End Class
