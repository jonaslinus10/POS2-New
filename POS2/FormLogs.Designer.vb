<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogs
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlForTopBar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CbInventoryCats = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlForSort = New System.Windows.Forms.Panel()
        Me.BtnPrintData = New System.Windows.Forms.Button()
        Me.BtnFormInventoryRefresh = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PnlForTopBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PnlForSort.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlForTopBar
        '
        Me.PnlForTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.PnlForTopBar.Controls.Add(Me.Label1)
        Me.PnlForTopBar.Controls.Add(Me.Panel1)
        Me.PnlForTopBar.Controls.Add(Me.PnlForSort)
        Me.PnlForTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlForTopBar.Location = New System.Drawing.Point(0, 0)
        Me.PnlForTopBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlForTopBar.Name = "PnlForTopBar"
        Me.PnlForTopBar.Size = New System.Drawing.Size(1270, 162)
        Me.PnlForTopBar.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(9, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(468, 65)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "User's Activity Logs"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CbInventoryCats)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(571, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 162)
        Me.Panel1.TabIndex = 14
        '
        'CbInventoryCats
        '
        Me.CbInventoryCats.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbInventoryCats.FormattingEnabled = True
        Me.CbInventoryCats.Items.AddRange(New Object() {"Sign In", "Sign Out"})
        Me.CbInventoryCats.Location = New System.Drawing.Point(28, 100)
        Me.CbInventoryCats.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CbInventoryCats.Name = "CbInventoryCats"
        Me.CbInventoryCats.Size = New System.Drawing.Size(436, 36)
        Me.CbInventoryCats.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 30)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Sort"
        '
        'PnlForSort
        '
        Me.PnlForSort.Controls.Add(Me.BtnPrintData)
        Me.PnlForSort.Controls.Add(Me.BtnFormInventoryRefresh)
        Me.PnlForSort.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlForSort.Location = New System.Drawing.Point(1045, 0)
        Me.PnlForSort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlForSort.Name = "PnlForSort"
        Me.PnlForSort.Size = New System.Drawing.Size(225, 162)
        Me.PnlForSort.TabIndex = 0
        '
        'BtnPrintData
        '
        Me.BtnPrintData.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnPrintData.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintData.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPrintData.Location = New System.Drawing.Point(29, 22)
        Me.BtnPrintData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPrintData.Name = "BtnPrintData"
        Me.BtnPrintData.Size = New System.Drawing.Size(165, 51)
        Me.BtnPrintData.TabIndex = 14
        Me.BtnPrintData.Text = "Print"
        Me.BtnPrintData.UseVisualStyleBackColor = False
        '
        'BtnFormInventoryRefresh
        '
        Me.BtnFormInventoryRefresh.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormInventoryRefresh.Location = New System.Drawing.Point(29, 94)
        Me.BtnFormInventoryRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnFormInventoryRefresh.Name = "BtnFormInventoryRefresh"
        Me.BtnFormInventoryRefresh.Size = New System.Drawing.Size(165, 51)
        Me.BtnFormInventoryRefresh.TabIndex = 10
        Me.BtnFormInventoryRefresh.Text = "Refresh"
        Me.BtnFormInventoryRefresh.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(-10, 156)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1286, 574)
        Me.DataGridView1.TabIndex = 12
        '
        'FormLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 726)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PnlForTopBar)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormLogs"
        Me.Text = "FormLogs"
        Me.PnlForTopBar.ResumeLayout(False)
        Me.PnlForTopBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnlForSort.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlForTopBar As Panel
    Friend WithEvents PnlForSort As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnFormInventoryRefresh As Button
    Friend WithEvents CbInventoryCats As ComboBox
    Friend WithEvents BtnPrintData As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
