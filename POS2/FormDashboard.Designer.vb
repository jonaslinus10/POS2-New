<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lnklblExpiring = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblExpiringItems = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.ChartMonthly = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lnllblCrit = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCritStocks = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTopSaleDate = New System.Windows.Forms.Label()
        Me.chartInventory = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbGraphMonth = New System.Windows.Forms.ComboBox()
        Me.cbGraphWeek = New System.Windows.Forms.ComboBox()
        Me.cbGraphYear = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LvPendingDeliveries = New System.Windows.Forms.ListView()
        Me.invoice_number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.delivery_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Customer_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.customer_address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.customer_contact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.ChartMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.chartInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.AutoSize = True
        Me.Panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 912)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1618, 0)
        Me.Panel8.TabIndex = 77
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 125)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1618, 912)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Controls.Add(Me.lnklblExpiring)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.lblExpiringItems)
        Me.Panel4.Location = New System.Drawing.Point(1321, 342)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(281, 301)
        Me.Panel4.TabIndex = 65
        '
        'lnklblExpiring
        '
        Me.lnklblExpiring.AutoSize = True
        Me.lnklblExpiring.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblExpiring.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lnklblExpiring.LinkColor = System.Drawing.Color.Black
        Me.lnklblExpiring.Location = New System.Drawing.Point(114, 246)
        Me.lnklblExpiring.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnklblExpiring.Name = "lnklblExpiring"
        Me.lnklblExpiring.Size = New System.Drawing.Size(65, 32)
        Me.lnklblExpiring.TabIndex = 68
        Me.lnklblExpiring.TabStop = True
        Me.lnklblExpiring.Text = "View"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 59)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Expiring Items"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpiringItems
        '
        Me.lblExpiringItems.BackColor = System.Drawing.Color.LightGray
        Me.lblExpiringItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExpiringItems.Font = New System.Drawing.Font("Nirmala UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiringItems.Location = New System.Drawing.Point(0, 0)
        Me.lblExpiringItems.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpiringItems.Name = "lblExpiringItems"
        Me.lblExpiringItems.Size = New System.Drawing.Size(281, 301)
        Me.lblExpiringItems.TabIndex = 71
        Me.lblExpiringItems.Text = "0"
        Me.lblExpiringItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel10.Controls.Add(Me.ChartMonthly)
        Me.Panel10.Controls.Add(Me.Label4)
        Me.Panel10.Location = New System.Drawing.Point(365, 342)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(947, 310)
        Me.Panel10.TabIndex = 90
        '
        'ChartMonthly
        '
        Me.ChartMonthly.BackColor = System.Drawing.Color.LightGray
        Me.ChartMonthly.BorderlineColor = System.Drawing.Color.Red
        ChartArea1.AxisX.Title = "Monthly Sales"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.DarkRed
        ChartArea1.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.CursorX.Interval = 7.0R
        ChartArea1.Name = "ChartArea1"
        Me.ChartMonthly.ChartAreas.Add(ChartArea1)
        Me.ChartMonthly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartMonthly.Location = New System.Drawing.Point(0, 0)
        Me.ChartMonthly.Margin = New System.Windows.Forms.Padding(16, 13, 16, 13)
        Me.ChartMonthly.Name = "ChartMonthly"
        Me.ChartMonthly.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.ChartMonthly.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.DarkRed}
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Series1"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Me.ChartMonthly.Series.Add(Series1)
        Me.ChartMonthly.Size = New System.Drawing.Size(947, 310)
        Me.ChartMonthly.TabIndex = 107
        Me.ChartMonthly.Text = "Chart1"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(947, 310)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "NO DATA AVAILABLE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel7.Controls.Add(Me.Panel3)
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.Location = New System.Drawing.Point(2, 650)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1626, 262)
        Me.Panel7.TabIndex = 89
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.lnllblCrit)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lblCritStocks)
        Me.Panel3.Location = New System.Drawing.Point(1319, 4)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(284, 253)
        Me.Panel3.TabIndex = 64
        '
        'lnllblCrit
        '
        Me.lnllblCrit.AutoSize = True
        Me.lnllblCrit.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnllblCrit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lnllblCrit.LinkColor = System.Drawing.Color.Black
        Me.lnllblCrit.Location = New System.Drawing.Point(114, 202)
        Me.lnllblCrit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnllblCrit.Name = "lnllblCrit"
        Me.lnllblCrit.Size = New System.Drawing.Size(65, 32)
        Me.lnllblCrit.TabIndex = 69
        Me.lnllblCrit.TabStop = True
        Me.lnllblCrit.Text = "View"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 2)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 65)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Critical Items"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCritStocks
        '
        Me.lblCritStocks.BackColor = System.Drawing.Color.LightGray
        Me.lblCritStocks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCritStocks.Font = New System.Drawing.Font("Nirmala UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCritStocks.Location = New System.Drawing.Point(0, 0)
        Me.lblCritStocks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCritStocks.Name = "lblCritStocks"
        Me.lblCritStocks.Size = New System.Drawing.Size(284, 253)
        Me.lblCritStocks.TabIndex = 76
        Me.lblCritStocks.Text = "0"
        Me.lblCritStocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.lblTopSaleDate)
        Me.Panel5.Controls.Add(Me.chartInventory)
        Me.Panel5.Location = New System.Drawing.Point(-2, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1312, 264)
        Me.Panel5.TabIndex = 66
        '
        'lblTopSaleDate
        '
        Me.lblTopSaleDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTopSaleDate.BackColor = System.Drawing.Color.White
        Me.lblTopSaleDate.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopSaleDate.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTopSaleDate.Location = New System.Drawing.Point(1114, 90)
        Me.lblTopSaleDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTopSaleDate.Name = "lblTopSaleDate"
        Me.lblTopSaleDate.Size = New System.Drawing.Size(182, 101)
        Me.lblTopSaleDate.TabIndex = 101
        Me.lblTopSaleDate.Text = "Pending Deliveries"
        Me.lblTopSaleDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chartInventory
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartInventory.ChartAreas.Add(ChartArea2)
        Me.chartInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chartInventory.Legends.Add(Legend1)
        Me.chartInventory.Location = New System.Drawing.Point(0, 0)
        Me.chartInventory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chartInventory.Name = "chartInventory"
        Me.chartInventory.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chartInventory.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.DarkRed}
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartInventory.Series.Add(Series2)
        Me.chartInventory.Size = New System.Drawing.Size(1312, 264)
        Me.chartInventory.TabIndex = 111
        Me.chartInventory.Text = "Chart1"
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Controls.Add(Me.cbGraphMonth)
        Me.Panel9.Controls.Add(Me.cbGraphWeek)
        Me.Panel9.Controls.Add(Me.cbGraphYear)
        Me.Panel9.Location = New System.Drawing.Point(0, 342)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(368, 310)
        Me.Panel9.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Brown
        Me.Label10.Location = New System.Drawing.Point(35, 198)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 40)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Month:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Brown
        Me.Label9.Location = New System.Drawing.Point(36, 162)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 28)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Week:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Brown
        Me.Label7.Location = New System.Drawing.Point(36, 125)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 29)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Year:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Brown
        Me.Label8.Location = New System.Drawing.Point(43, 49)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(307, 76)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Sales Graph"
        '
        'cbGraphMonth
        '
        Me.cbGraphMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGraphMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGraphMonth.FormattingEnabled = True
        Me.cbGraphMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbGraphMonth.Location = New System.Drawing.Point(138, 198)
        Me.cbGraphMonth.Margin = New System.Windows.Forms.Padding(2)
        Me.cbGraphMonth.Name = "cbGraphMonth"
        Me.cbGraphMonth.Size = New System.Drawing.Size(159, 28)
        Me.cbGraphMonth.TabIndex = 102
        '
        'cbGraphWeek
        '
        Me.cbGraphWeek.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGraphWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGraphWeek.FormattingEnabled = True
        Me.cbGraphWeek.Items.AddRange(New Object() {"Week 1", "Week 2", "Week 3", "Week 4", "Week 5"})
        Me.cbGraphWeek.Location = New System.Drawing.Point(138, 163)
        Me.cbGraphWeek.Margin = New System.Windows.Forms.Padding(2)
        Me.cbGraphWeek.Name = "cbGraphWeek"
        Me.cbGraphWeek.Size = New System.Drawing.Size(159, 28)
        Me.cbGraphWeek.TabIndex = 105
        '
        'cbGraphYear
        '
        Me.cbGraphYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGraphYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGraphYear.FormattingEnabled = True
        Me.cbGraphYear.Items.AddRange(New Object() {"Week 1", "Week 2", "Week 3", "Week 4"})
        Me.cbGraphYear.Location = New System.Drawing.Point(138, 127)
        Me.cbGraphYear.Margin = New System.Windows.Forms.Padding(2)
        Me.cbGraphYear.Name = "cbGraphYear"
        Me.cbGraphYear.Size = New System.Drawing.Size(159, 28)
        Me.cbGraphYear.TabIndex = 104
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.Controls.Add(Me.LvPendingDeliveries)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1618, 338)
        Me.Panel6.TabIndex = 65
        '
        'LvPendingDeliveries
        '
        Me.LvPendingDeliveries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LvPendingDeliveries.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.invoice_number, Me.delivery_date, Me.Customer_name, Me.customer_address, Me.customer_contact})
        Me.LvPendingDeliveries.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvPendingDeliveries.FullRowSelect = True
        Me.LvPendingDeliveries.GridLines = True
        Me.LvPendingDeliveries.HideSelection = False
        Me.LvPendingDeliveries.Location = New System.Drawing.Point(14, 54)
        Me.LvPendingDeliveries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LvPendingDeliveries.MultiSelect = False
        Me.LvPendingDeliveries.Name = "LvPendingDeliveries"
        Me.LvPendingDeliveries.Size = New System.Drawing.Size(1587, 279)
        Me.LvPendingDeliveries.TabIndex = 100
        Me.LvPendingDeliveries.UseCompatibleStateImageBehavior = False
        Me.LvPendingDeliveries.View = System.Windows.Forms.View.Details
        '
        'invoice_number
        '
        Me.invoice_number.Text = "Invoice"
        Me.invoice_number.Width = 150
        '
        'delivery_date
        '
        Me.delivery_date.Text = "Delivery Date"
        Me.delivery_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.delivery_date.Width = 173
        '
        'Customer_name
        '
        Me.Customer_name.Text = "Customer's Name"
        Me.Customer_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Customer_name.Width = 180
        '
        'customer_address
        '
        Me.customer_address.Text = "Customer's Address"
        Me.customer_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.customer_address.Width = 250
        '
        'customer_contact
        '
        Me.customer_contact.Text = "Contact Number"
        Me.customer_contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.customer_contact.Width = 200
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Brown
        Me.Label11.Location = New System.Drawing.Point(13, 7)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1589, 38)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Pending Deliveries"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1618, 125)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 101
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1618, 125)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Honest City Hardware"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1618, 1037)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormDashboard"
        Me.ShowInTaskbar = False
        Me.Text = "Dashboard"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        CType(Me.ChartMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.chartInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbGraphMonth As ComboBox
    Friend WithEvents cbGraphWeek As ComboBox
    Friend WithEvents cbGraphYear As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LvPendingDeliveries As ListView
    Friend WithEvents invoice_number As ColumnHeader
    Friend WithEvents delivery_date As ColumnHeader
    Friend WithEvents Customer_name As ColumnHeader
    Friend WithEvents customer_address As ColumnHeader
    Friend WithEvents customer_contact As ColumnHeader
    Friend WithEvents lnllblCrit As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents lnklblExpiring As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblExpiringItems As Label
    Friend WithEvents ChartMonthly As DataVisualization.Charting.Chart
    Friend WithEvents chartInventory As DataVisualization.Charting.Chart
    Friend WithEvents lblCritStocks As Label
    Friend WithEvents lblTopSaleDate As Label
End Class
