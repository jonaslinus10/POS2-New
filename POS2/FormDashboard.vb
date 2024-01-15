Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports iText.Kernel.Pdf.Annot
Imports Mysqlx
Imports Nevron.Nov.Chart
Imports Nevron.Nov.UI
Imports OracleInternal

Public Class FormDashboard
    ReadOnly currentDate As DateTime = DateTime.Now
    ReadOnly dateString As String = currentDate.ToString("MM-dd-yyyy")

    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler

    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString


    Dim listProducts As List(Of Product)
    Dim totalSales As List(Of Sale)
    Dim totalSalesToday As List(Of Sale)
    Dim totalDamagesToday As List(Of Damage)
    Dim totalReturnedToday As List(Of Sale)
    Dim weeklySale As List(Of Sale)
    Dim monthlySale As List(Of Sale)
    Dim cbMonth As Integer
    Dim cbYear As Integer
    Dim cbWeek As Integer
    Dim totalToBeExpired As Integer

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshUI()

    End Sub
    Public Sub RefreshUI()
        listProducts = dbHandler.GetProducts
        totalSales = dbHandler.GetSale()
        monthlySale = dbHandler.GetSalesMonthly()

        totalSalesToday = New List(Of Sale)
        totalReturnedToday = New List(Of Sale)
        For Each sale In totalSales
            If (sale.Release_Date = dateString) Then
                If Not sale.Returned Then
                    totalSalesToday.Add(sale)
                End If
                If sale.Returned Then
                    totalReturnedToday.Add(sale)
                End If
            End If
        Next
        addItemsComboBox()
        UpdateItemSoldToday()
        'UpdateItemReturnedToday()
        'UpdateItemDamagedToday()
        PopulateMonthlyChart(monthlySale)
        PopulatePendingDeliveries()
        productscounter()


        dbHandler.CheckExpires()
        totalToBeExpired = dbHandler.checkToBeExpired()
        lblExpiringItems.Text = totalToBeExpired.ToString
        lblCritStocks.Text = critstocview.ToString
        chartInventoryLoader()
    End Sub
    Private Sub createCalendarArray()

    End Sub
    Private Sub addItemsComboBox()
        Dim startingYear As Integer = 2023
        Dim currentYear As Integer = DateTime.Now.Year
        Dim addingYear As Integer = 1
        Dim maxYear As Integer = currentYear + addingYear
        cbGraphYear.Items.Clear()

        For year As Integer = startingYear To maxYear
            cbGraphYear.Items.Add(year)
        Next

        'Week Generator'

        Dim today As DateTime = DateTime.Now
        Dim firstDayOfMonth As New DateTime(today.Year, today.Month, 1)
        Dim dayOfWeek As Integer = firstDayOfMonth.DayOfWeek

        ' Calculate the week of the month
        Dim weekOfMonth As Integer = (today.Day + dayOfWeek - 1) \ 7 + 1
        Dim nameOfMonth As String = New DateTimeFormatInfo().GetMonthName(DateTime.Now.Month)


        cbMonth = today.Month
        cbYear = currentYear
        cbWeek = weekOfMonth
        cbGraphMonth.SelectedIndex = cbMonth - 1
        cbGraphYear.SelectedItem = cbYear
        cbGraphWeek.SelectedIndex = cbWeek - 1
    End Sub
    'Private Sub UpdateItemDamagedToday()
    '    Dim dailyDamages As Integer = 0
    '    For Each product In totalDamagesToday
    '        If (product.DamagesDate = dateString) Then
    '            dailyDamages += 1
    '        End If
    '    Next
    '    If dailyDamages <= 0 Then
    '        LblPosItemDamagedToday.Text = 0
    '    Else
    '        LblPosItemDamagedToday.Text = dailyDamages
    '    End If
    'End Sub

    Public Function critstocview() As Integer
        Dim dt As DataTable = New DataTable()
        Try
            conn1.Open()
            Dim cmd As New SqlCommand("SELECT * FROM products WHERE stock <= critical_stock_limit AND available = 'true'", conn1)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)

            sda.Fill(dt)

        Catch

        End Try
        Return dt.Rows.Count
        conn1.Close()
    End Function


    Private Sub PopulateMonthlyChart(sales As List(Of Sale))
        ' Set up the chart
        Try
            createCalendarArray()
            ChartMonthly.Series.Clear()
            ChartMonthly.Series.Add("Sales_Current_Month")
            ChartMonthly.Series("Sales_Current_Month").ChartType = SeriesChartType.Column
            ChartMonthly.Series("Sales_Current_Month").XValueType = ChartValueType.Date

            ChartMonthly.Series.Add("Sales_Last_Month")
            ChartMonthly.Series("Sales_Last_Month").ChartType = SeriesChartType.Column
            ChartMonthly.Series("Sales_Last_Month").XValueType = ChartValueType.Date


            Dim today As Date = "1/" & cbMonth & "/" & cbYear & " 09:45:30 AM"

            Dim firstDayOfMonth As Date = New DateTime(today.Year, today.Month, 1)
            Dim lastDayOfMonth As Date = firstDayOfMonth.AddMonths(1).AddDays(-1)
            Dim currentDate As New DateTime(today.Year, today.Month, 1)
            Dim dateArray(30) As String

            ' Define the number of rows and columns for the array
            Dim rows As Integer = 5 ' Number of days in November 2023
            Dim columns As Integer = 7 ' Days of the week (Sunday to Saturday)

            ' Create a 2D array to store the dates
            Dim november2023Dates(rows - 1, columns - 1) As DateTime

            ' Specify the start date (November 1, 2023)
            Dim startDate As New DateTime(cbYear, cbMonth, 1)

            ' Populate the array with dates
            For row As Integer = 0 To rows - 1
                For col As Integer = 0 To columns - 1
                    november2023Dates(row, col) = startDate
                    startDate = startDate.AddDays(1) ' Increment the date by one day
                Next
            Next
            Dim indexDate As Integer = 0
            ' Display the array
            For row As Integer = 0 To rows - 1
                For col As Integer = 0 To columns - 1
                    If november2023Dates(row, col).Month = today.Month Then
                        dateArray(indexDate) = november2023Dates(row, col).ToString("dd-MM-yyyy")
                        Console.WriteLine(dateArray(indexDate))
                        indexDate += 1
                    End If
                Next

                'Console.Write("-----------------------------------")
                'Console.WriteLine()
            Next


            For Each sale As Sale In sales
                Dim releaseDate As Date = DateTime.ParseExact(sale.Release_Date, "MM-dd-yyyy", CultureInfo.InvariantCulture)
                Dim currentDateTimeString As String = releaseDate.ToString("MM-dd-yyyy")
                If releaseDate >= firstDayOfMonth And releaseDate <= lastDayOfMonth Then
                    ChartMonthly.Series("Sales_Current_Month").Points.AddXY(releaseDate, getCountForChartMonthly(currentDateTimeString))
                    ChartMonthly.Series("Sales_Current_Month").IsValueShownAsLabel = True
                    'System.Diagnostics.Debug.WriteLine(firstDayOfMonth)
                    'System.Diagnostics.Debug.WriteLine(lastDayOfMonth)
                    'System.Diagnostics.Debug.WriteLine(startDateCurrent)
                    'System.Diagnostics.Debug.WriteLine(endDateCurrent)
                    'System.Diagnostics.Debug.WriteLine(releaseDate)
                    'System.Diagnostics.Debug.WriteLine(sale.Total_Price)
                End If
            Next

            If ChartMonthly.Series("Sales_Current_Month").Points.Count > 0 Then
                ChartMonthly.Show()
            Else
                ChartMonthly.Hide()
            End If

            Dim dateStrings() As String = dateArray
            Dim random As New Random()
            Dim cbIndex As Integer = cbGraphWeek.SelectedIndex
            Dim finalDate(dateArray.Count() - 1) As Double
            Dim finalDateIndex As Integer

            For Each dateString As String In dateStrings
                Dim dateValue As DateTime
                If DateTime.TryParseExact(dateString, "dd-MM-yyyy", Nothing, Globalization.DateTimeStyles.None, dateValue) Then
                    finalDate(finalDateIndex) = dateValue.ToOADate
                    finalDateIndex += 1
                End If
            Next
            If cbIndex = 0 Then
                ChartMonthly.ChartAreas(0).AxisX.Minimum = finalDate(0)
                ChartMonthly.ChartAreas(0).AxisX.Maximum = finalDate(6)
            ElseIf cbIndex = 1 Then
                ChartMonthly.ChartAreas(0).AxisX.Minimum = finalDate(7)
                ChartMonthly.ChartAreas(0).AxisX.Maximum = finalDate(13)
            ElseIf cbIndex = 2 Then
                ChartMonthly.ChartAreas(0).AxisX.Minimum = finalDate(14)
                ChartMonthly.ChartAreas(0).AxisX.Maximum = finalDate(20)
            ElseIf cbIndex = 3 Then
                ChartMonthly.ChartAreas(0).AxisX.Minimum = finalDate(21)
                ChartMonthly.ChartAreas(0).AxisX.Maximum = finalDate(27)
            ElseIf cbIndex = 4 Then
                ChartMonthly.ChartAreas(0).AxisX.Minimum = finalDate(28)
                ChartMonthly.ChartAreas(0).AxisX.Maximum = lastDayOfMonth.ToOADate
            End If
        Catch

        End Try
    End Sub


    'Private Sub UpdateItemReturnedToday()
    '    Dim count As Integer = totalReturnedToday.Count
    '    If count <= 0 Then
    '        LblPosItemReturnedToday.Text = 0
    '    Else
    '        LblPosItemReturnedToday.Text = count
    '    End If
    'End Sub
    Private Sub productscounter()
        Try
            conn1.Open()

            Dim query As String = "SELECT COUNT(*) FROM products where available = 'true'" ' Replace "products" with the actual table name
            Dim cmd As New SqlCommand(query, conn1)
            Dim count1 As Integer = CInt(cmd.ExecuteScalar())
            lblCritStocks.Text = count1
        Catch
            conn1.Close()
            productscounter()
        End Try
        conn1.Close()
    End Sub

    Private Sub UpdateItemSoldToday()
        'Dim count As Integer = totalSalesToday.Count
        'If count <= 0 Then
        '    lblExpiringItems.Text = 0
        'Else
        '    lblExpiringItems.Text = count
        'End If

    End Sub



    Public Sub PopulatePendingDeliveries()
        Try
            conn1.Open()
            Dim cmd As New SqlCommand("SELECT * FROM sales WHERE [pending] = 1 AND [order_type] = 'Deliver' ORDER BY [release_date] ASC", conn1)
            cmd.Parameters.AddWithValue("@type", "Deliver")
            Dim da As SqlDataReader = cmd.ExecuteReader()
            LvPendingDeliveries.Items.Clear()


            While da.Read()
                Dim invoiceNumber As String = da(1).ToString() ' Assuming the first column is the invoice number

                'MsgBox(da(19).ToString() & " " & da(8).ToString() & " " & da(9).ToString() & " " & da(10).ToString())
                Dim item As New ListViewItem(invoiceNumber)
                item.SubItems.Add(da(19).ToString())
                item.SubItems.Add(da(8).ToString())
                item.SubItems.Add(da(9).ToString())
                item.SubItems.Add(da(10).ToString())
                LvPendingDeliveries.Items.Add(item)

            End While
            conn1.Close()
            da.Close()

        Catch
            conn1.Close()
            PopulatePendingDeliveries()
        End Try
    End Sub


    Private Sub LvPendingDeliveries_SizeChanged(sender As Object, e As EventArgs)
    End Sub
    Private Sub cbGraphYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGraphYear.SelectedIndexChanged
        cbYear = Convert.ToInt32(cbGraphYear.SelectedItem)
        PopulateMonthlyChart(monthlySale)
    End Sub

    Private Sub cbGraphWeek_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGraphWeek.SelectedIndexChanged
        cbWeek = cbGraphWeek.SelectedIndex + 1
        PopulateMonthlyChart(monthlySale)
    End Sub

    Private Sub cbGraphMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGraphMonth.SelectedIndexChanged
        Dim getIndexMonth As Integer = cbGraphMonth.SelectedIndex
        cbMonth = getIndexMonth + 1
        PopulateMonthlyChart(monthlySale)
    End Sub
    Private Sub LvPendingDeliveries_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles LvPendingDeliveries.SelectedIndexChanged
        If LvPendingDeliveries.SelectedItems.Count > 0 Then
            Dim dates As String = LvPendingDeliveries.SelectedItems(0).Text
            Dim name As String = LvPendingDeliveries.SelectedItems(0).SubItems(1).Text
            Dim id1 As String = LvPendingDeliveries.SelectedItems(0).SubItems(2).Text
            ' Do something with the selected data
            FormItemToDelivery.Label2.Text = id1
            FormItemToDelivery.Label3.Text = name
            FormItemToDelivery.TextBox1.Text = dates
            FormItemToDelivery.ShowDialog()

        End If
    End Sub


    Public Sub chartInventoryLoader()
        chartInventory.Series.Clear()
        Dim now As DateTime = DateTime.Now
        Dim currentDateTimeString As String = now.ToString("MM-dd-yyyy")
        lblTopSaleDate.Text = "As of: " & currentDateTimeString
        Dim adapter As SqlDataAdapter = Nothing
        Try
            Dim connection As New SqlConnection(dbHandler.getConnectionString)
            Dim dt As New DataTable()
            connection.Open()

            Dim cmd As New SqlCommand("SELECT * FROM sales WHERE release_date = @date", connection)
            cmd.Parameters.AddWithValue("@date", currentDateTimeString)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dt)
            Dim newDT As New DataTable
            newDT.Columns.Add("item_name", GetType(String))
            newDT.Columns.Add("totalCount", GetType(Integer))
            If dt.Rows.Count > 0 Then

                For a As Integer = 0 To dt.Rows.Count - 1
                    Dim dr As DataRow = newDT.NewRow
                    ' Check if item name already exists
                    If Not newDT.AsEnumerable().Any(Function(row) row.Field(Of String)("item_name") = dt.Rows(a).Item(3).ToString) Then
                        dr("item_name") = dt.Rows(a).Item(3).ToString
                        dr("totalCount") = getCountForChart(dt.Rows(a).Item(3).ToString)
                        newDT.Rows.Add(dr)
                    End If
                Next
                chartInventory.DataSource = newDT
                chartInventory.Series.Add("Series1")
                Dim series1 As Series = chartInventory.Series("Series1")
                series1.ChartType = SeriesChartType.Bar
                series1.Name = "Sales"

                With chartInventory
                    '.Series(0)("PieLabelStyle") = "Outside"
                    '.Series(0).BorderWidth = 1
                    '.Series(0).BorderColor = System.Drawing.Color.FromArgb(68, 45, 9)
                    .Series(series1.Name).XValueMember = "item_name"
                    .Series(series1.Name).YValueMembers = "totalCount"
                    .Series(0).LabelFormat = "{#,##0}"
                    .ChartAreas(0).Area3DStyle.Enable3D = False
                    .Series(0).IsValueShownAsLabel = True
                    .Series(series1.Name).Points(0).Color = Color.Red
                    .Series(series1.Name).IsValueShownAsLabel = True
                End With
                connection.Close()
            End If

        Catch

        Finally
            adapter?.Dispose()
        End Try




    End Sub
    Public Function getCountForChartMonthly(release_date As String) As Integer
        Dim now As DateTime = DateTime.Now
        Dim currentDateTimeString As String = now.ToString("MM-dd-yyyy")
        Dim connection As New SqlConnection(dbHandler.getConnectionString)
        Dim cmd As SqlCommand = Nothing
        Dim tempDT As New DataTable
        Dim count As Integer
        Try
            Using connection1 As New SqlConnection(dbHandler.getConnectionString)
                Dim cmd1 As New SqlCommand With {
                .Connection = connection1,
                .CommandText = "SELECT SUM(item_total_price) FROM sales where release_date = @release_date"
                }
                cmd1.Parameters.AddWithValue("@release_date", release_date)
                Dim tempAdapter As New SqlDataAdapter(cmd1)
                tempAdapter.Fill(tempDT)

                For a As Integer = 0 To tempDT.Rows.Count - 1
                    count += Convert.ToInt32(tempDT.Rows(a).Item(0))
                Next
                connection1.Close()
            End Using
        Catch
        End Try

        Return count
    End Function

    Public Function getCountForChart(item_name As String) As Integer
        Dim now As DateTime = DateTime.Now
        Dim currentDateTimeString As String = now.ToString("MM-dd-yyyy")
        Dim connection As New SqlConnection(dbHandler.getConnectionString)
        Dim cmd As SqlCommand = Nothing
        Dim tempDT As New DataTable
        Dim count As Integer
        Try
            Using connection1 As New SqlConnection(dbHandler.getConnectionString)
                Dim cmd1 As New SqlCommand With {
                .Connection = connection1,
                .CommandText = "SELECT item_quantity FROM sales where item_name = @item_name AND release_date = @date"
                }
                cmd1.Parameters.AddWithValue("@item_name", item_name)
                cmd1.Parameters.AddWithValue("@date", currentDateTimeString)
                Dim tempAdapter As New SqlDataAdapter(cmd1)
                tempAdapter.Fill(tempDT)

                For a As Integer = 0 To tempDT.Rows.Count - 1
                    count += Convert.ToInt32(tempDT.Rows(a).Item(0))
                Next
                connection1.Close()
            End Using
        Catch
        End Try

        Return count
    End Function

    Private Sub lnklblExpiring_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblExpiring.LinkClicked
        FormMain.BtnSalesReport.PerformClick()

        FormInventory.BtnGotoProducts.Visible = True
        FormReports.BtnGotoExpiredProducts.Visible = True
        FormReports.BtnGotoDamagedProducts.Visible = True
        FormReports.PnlForMenuBtns.Visible = True

        FormReports.BtnGotoExpiredProducts.PerformClick()


    End Sub

    Private Sub lnllblCrit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnllblCrit.LinkClicked
        FormMain.BtnStocks.PerformClick()
    End Sub


End Class