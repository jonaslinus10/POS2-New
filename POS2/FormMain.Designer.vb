<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnAccountSettings = New System.Windows.Forms.Button()
        Me.BtnMaintenance = New System.Windows.Forms.Button()
        Me.BtnSalesReport = New System.Windows.Forms.Button()
        Me.BtnStocks = New System.Windows.Forms.Button()
        Me.BtnDashBoard = New System.Windows.Forms.Button()
        Me.BtnGotoPos = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblAdminUserName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlLoader = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 798)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnAccountSettings)
        Me.Panel3.Controls.Add(Me.BtnMaintenance)
        Me.Panel3.Controls.Add(Me.BtnSalesReport)
        Me.Panel3.Controls.Add(Me.BtnStocks)
        Me.Panel3.Controls.Add(Me.BtnDashBoard)
        Me.Panel3.Controls.Add(Me.BtnGotoPos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 261)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 16, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(309, 390)
        Me.Panel3.TabIndex = 0
        '
        'BtnAccountSettings
        '
        Me.BtnAccountSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAccountSettings.FlatAppearance.BorderSize = 0
        Me.BtnAccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAccountSettings.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccountSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnAccountSettings.Image = Global.POS2.My.Resources.Resources.user_avatar
        Me.BtnAccountSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAccountSettings.Location = New System.Drawing.Point(0, 295)
        Me.BtnAccountSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAccountSettings.Name = "BtnAccountSettings"
        Me.BtnAccountSettings.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.BtnAccountSettings.Size = New System.Drawing.Size(309, 59)
        Me.BtnAccountSettings.TabIndex = 12
        Me.BtnAccountSettings.Text = "Account Management"
        Me.BtnAccountSettings.UseVisualStyleBackColor = True
        '
        'BtnMaintenance
        '
        Me.BtnMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMaintenance.FlatAppearance.BorderSize = 0
        Me.BtnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaintenance.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMaintenance.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnMaintenance.Image = Global.POS2.My.Resources.Resources.maintenance
        Me.BtnMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMaintenance.Location = New System.Drawing.Point(0, 236)
        Me.BtnMaintenance.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMaintenance.Name = "BtnMaintenance"
        Me.BtnMaintenance.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.BtnMaintenance.Size = New System.Drawing.Size(309, 59)
        Me.BtnMaintenance.TabIndex = 11
        Me.BtnMaintenance.Text = "Maintenance"
        Me.BtnMaintenance.UseVisualStyleBackColor = True
        '
        'BtnSalesReport
        '
        Me.BtnSalesReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSalesReport.FlatAppearance.BorderSize = 0
        Me.BtnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalesReport.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalesReport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSalesReport.Image = Global.POS2.My.Resources.Resources.sales
        Me.BtnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalesReport.Location = New System.Drawing.Point(0, 177)
        Me.BtnSalesReport.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalesReport.Name = "BtnSalesReport"
        Me.BtnSalesReport.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.BtnSalesReport.Size = New System.Drawing.Size(309, 59)
        Me.BtnSalesReport.TabIndex = 10
        Me.BtnSalesReport.Text = "Reports"
        Me.BtnSalesReport.UseVisualStyleBackColor = True
        '
        'BtnStocks
        '
        Me.BtnStocks.BackColor = System.Drawing.Color.Firebrick
        Me.BtnStocks.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnStocks.FlatAppearance.BorderSize = 0
        Me.BtnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStocks.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStocks.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnStocks.Image = Global.POS2.My.Resources.Resources.ic_stack
        Me.BtnStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnStocks.Location = New System.Drawing.Point(0, 118)
        Me.BtnStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStocks.Name = "BtnStocks"
        Me.BtnStocks.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.BtnStocks.Size = New System.Drawing.Size(309, 59)
        Me.BtnStocks.TabIndex = 9
        Me.BtnStocks.Text = "Inventory"
        Me.BtnStocks.UseVisualStyleBackColor = False
        '
        'BtnDashBoard
        '
        Me.BtnDashBoard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashBoard.FlatAppearance.BorderSize = 0
        Me.BtnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashBoard.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnDashBoard.Image = Global.POS2.My.Resources.Resources.dashboards
        Me.BtnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDashBoard.Location = New System.Drawing.Point(0, 59)
        Me.BtnDashBoard.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDashBoard.Name = "BtnDashBoard"
        Me.BtnDashBoard.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.BtnDashBoard.Size = New System.Drawing.Size(309, 59)
        Me.BtnDashBoard.TabIndex = 8
        Me.BtnDashBoard.Text = "Dashboard"
        Me.BtnDashBoard.UseVisualStyleBackColor = True
        '
        'BtnGotoPos
        '
        Me.BtnGotoPos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGotoPos.FlatAppearance.BorderSize = 0
        Me.BtnGotoPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGotoPos.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGotoPos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGotoPos.Image = Global.POS2.My.Resources.Resources.point_of_sale
        Me.BtnGotoPos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGotoPos.Location = New System.Drawing.Point(0, 0)
        Me.BtnGotoPos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGotoPos.Name = "BtnGotoPos"
        Me.BtnGotoPos.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.BtnGotoPos.Size = New System.Drawing.Size(309, 59)
        Me.BtnGotoPos.TabIndex = 2
        Me.BtnGotoPos.Text = "POS"
        Me.BtnGotoPos.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLogout.Image = Global.POS2.My.Resources.Resources.log_out
        Me.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogout.Location = New System.Drawing.Point(0, 739)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.BtnLogout.Size = New System.Drawing.Size(309, 59)
        Me.BtnLogout.TabIndex = 8
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblAdminUserName)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(309, 261)
        Me.Panel2.TabIndex = 0
        '
        'LblAdminUserName
        '
        Me.LblAdminUserName.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminUserName.Location = New System.Drawing.Point(4, 210)
        Me.LblAdminUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAdminUserName.Name = "LblAdminUserName"
        Me.LblAdminUserName.Size = New System.Drawing.Size(297, 48)
        Me.LblAdminUserName.TabIndex = 1
        Me.LblAdminUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS2.My.Resources.Resources.ic_admin
        Me.PictureBox1.Location = New System.Drawing.Point(67, 48)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlLoader
        '
        Me.pnlLoader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoader.Location = New System.Drawing.Point(309, 0)
        Me.pnlLoader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLoader.Name = "pnlLoader"
        Me.pnlLoader.Size = New System.Drawing.Size(942, 798)
        Me.pnlLoader.TabIndex = 2
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1251, 798)
        Me.Controls.Add(Me.pnlLoader)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblAdminUserName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnAccountSettings As Button
    Friend WithEvents BtnMaintenance As Button
    Friend WithEvents BtnSalesReport As Button
    Friend WithEvents BtnStocks As Button
    Friend WithEvents BtnDashBoard As Button
    Friend WithEvents BtnGotoPos As Button
    Friend WithEvents pnlLoader As Panel
End Class
