Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FormSales
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler

    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"

    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString
    Dim listSales As New List(Of Sale)
    Dim selectedSale As Sale

    Dim PPD As New PrintPreviewDialog
    Private Sub FormSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshUI()

    End Sub

    Public Sub RefreshUI()
        Try
            conn1.Close()
            conn1.Open()
            Dim cmd As New SqlCommand("SELECT * FROM sales WHERE delivered = 1 AND pending = 0 AND returned = 0 OR delivered = 0 AND pending = 1 AND returned = 0", conn1)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim origDT As New DataTable
            adapter.Fill(origDT)
            adapter.Dispose()
            LvReportsSale.Items.Clear()
            For a As Integer = 0 To origDT.Rows.Count - 1
                Dim list1 = LvReportsSale.Items.Add(origDT.Rows(a).Item(1).ToString)
                Dim dt As DataTable = getCategoryETC(origDT.Rows(a).Item(2).ToString)
                list1.SubItems.Add(origDT.Rows(0).Item(8).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(0).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(3).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(1).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(2).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(3).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(4).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(4).ToString)

                Dim str As String = origDT.Rows(a).Item(6).ToString
                Dim floatValue As Single = ConvertStringToFloat(str)

                Dim amount As Decimal = floatValue
                Dim formattedAmount As String = FormatMoney(amount)

                list1.SubItems.Add("₱ " + formattedAmount)
                list1.SubItems.Add(origDT.Rows(a).Item(11).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(12).ToString)
                dt.Dispose()
            Next
            conn1.Close()
        Catch
        End Try
    End Sub
    Private Sub SearchListView(filtered As Boolean, searchByType As Boolean, searchByDate As Boolean, query As String)
        listSales = dbHandler.GetSale()
        LvReportsSale.Items.Clear()
        Dim filteredSales As List(Of Sale)
        If filtered Then
            If searchByDate And Not searchByType Then
                'Filter by release date
                filteredSales = listSales.Where(Function(s) s.Release_Date = DateTimePicker1.Value.ToString("MM-dd-yyyy")).OrderBy(Function(s) DateTime.ParseExact(s.Release_Date, "MM-dd-yyyy", CultureInfo.InvariantCulture).Day).ToList()
            ElseIf Not String.IsNullOrEmpty(query) Then
                'Filter by invoice number
                filteredSales = listSales.Where(Function(s) s.Invoice_Number.StartsWith(query, StringComparison.InvariantCultureIgnoreCase)).ToList()
            ElseIf searchByType And Not searchByDate Then
                filteredSales = listSales.Where(Function(s) s.Delivered.ToString().ToLower().StartsWith(query, StringComparison.InvariantCultureIgnoreCase)).ToList()
            Else
                'No filter applied
                filteredSales = listSales
            End If
            PopulateListView(filteredSales)
        Else
            'No filter applied
            filteredSales = listSales
            PopulateListView(filteredSales)
        End If
    End Sub

    Private Sub SearchListViews(filtered As Boolean, searchByType As Boolean, searchByDate As Boolean, query As String)
        listSales = dbHandler.GetSale()
        LvReportsSale.Items.Clear()
        Dim filteredSales As List(Of Sale)
        If filtered Then
            If Not String.IsNullOrEmpty(query) Then
                If searchByDate Then
                    filteredSales = listSales.Where(Function(s) s.Release_Date = query).ToList()
                Else
                    filteredSales = listSales.Where(Function(s) s.Invoice_Number.StartsWith(query, StringComparison.InvariantCultureIgnoreCase)).ToList()
                End If
                If searchByType Then
                    filteredSales = listSales.Where(Function(s) s.Delivered.ToString().StartsWith(query, StringComparison.InvariantCultureIgnoreCase)).ToList()
                End If
                PopulateListView(filteredSales)
            End If
        Else
            filteredSales = listSales
            PopulateListView(filteredSales)
        End If
    End Sub

    Private Sub PopulateListView(sales As IEnumerable(Of Sale))
        LvReportsSale.BeginUpdate()
        Try
            For Each s As Sale In sales
                If Not s.Returned Then
                    Dim _lvItem As New ListViewItem(s.Invoice_Number)
                    _lvItem.SubItems.Add(s.Customer_Name)
                    _lvItem.SubItems.Add(s.Product_Name)
                    _lvItem.SubItems.Add(s.Quantity)
                    _lvItem.SubItems.Add(s.Price)
                    _lvItem.SubItems.Add(s.Release_Date)
                    _lvItem.SubItems.Add(s.Release_Time)
                    _lvItem.Tag = s
                    LvReportsSale.Items.Add(_lvItem)
                End If
            Next
            '       LvReportsSale.ListViewItemSorter = New ListvViewItemComparer()
            LvReportsSale.Sort()
        Finally
            LvReportsSale.EndUpdate()
        End Try
    End Sub

    Private Function IsDelivered(value As String) As Integer
        If value = "Deliver" Then
            Return 1
        ElseIf value = "Pick Up" Then
            Return 0
        End If
        Return 0
    End Function

    Private Sub BtnFormSalesSearch_Click(sender As Object, e As EventArgs)
        conn1.Open()

        Dim cmd As New SqlCommand("SELECT * FROM sales WHERE invoice_number = @InvoiceNumber", conn1)
        cmd.Parameters.AddWithValue("@InvoiceNumber", TbFormSalesSearch.Text)

        Dim da As SqlDataReader = cmd.ExecuteReader
        LvReportsSale.Items.Clear()
        Do While da.Read = True
            Dim list1 = LvReportsSale.Items.Add(da(1))
            list1.SubItems.Add(da(8))
            list1.SubItems.Add(da(3))
            list1.SubItems.add(da(4))
            list1.SubItems.Add("₱ " + da(5).ToString())
            list1.SubItems.Add(da(11))
            list1.SubItems.Add(da(12))
        Loop

        conn1.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        '   Dim dateString As String = DateTimePicker1.Value.ToString("MM-dd-yyyy")
        '   SearchListView(True, False, True, dateString)
    End Sub

    Private Sub BtnFormSalesRefresh_Click(sender As Object, e As EventArgs)
        conn1.Open()
        Dim cmd As New SqlCommand("select * from sales", conn1)

        Dim da As SqlDataReader = cmd.ExecuteReader
        LvReportsSale.Items.Clear()
        Do While da.Read = True
            Dim list1 = LvReportsSale.Items.Add(da(1))
            list1.SubItems.add(da(8))
            list1.SubItems.add(da(3))
            list1.SubItems.add(da(4))
            list1.SubItems.add("₱ " + da(5).ToString())
            list1.SubItems.add(da(11))
            list1.SubItems.add(da(12))

        Loop
        conn1.Close()
        TbFormSalesSearch.Clear()
    End Sub
    Private Sub LvReportsSale_ItemActivate(sender As Object, e As EventArgs) Handles LvReportsSale.ItemActivate
        Dim selectedItem As ListViewItem = LvReportsSale.SelectedItems(0)
        selectedSale = CType(selectedItem.Tag, Sale)
    End Sub

    Private Sub BtnFormSalesPrint_Click(sender As Object, e As EventArgs) Handles BtnFormSalesPrint.Click
        FormPrintPreview.printType = "sales"
        Try
            FormPrintPreview.Show()
        Catch

        End Try
        'PrintToPdf(LvReportsSale, "HCH_SALES")
    End Sub

    Private Sub PrintToPdf(listView As ListView, fileName As String)
        ' Create a new PDF document
        Dim doc As New Document()

        ' Show a dialog box to allow the user to choose the save location and filename
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
        saveFileDialog.Title = "Save PDF File"
        saveFileDialog.ShowDialog()

        ' If the user clicked the OK button, proceed with saving the PDF file
        If saveFileDialog.FileName <> "" Then
            fileName = saveFileDialog.FileName

            ' Create a new PDF writer that will write to the file stream

            ' Open the document for writing
            doc.Open()
            Dim itemSalesParagraph As New Paragraph()
            Dim itemSalesParagraph1 As New Paragraph()
            Dim itemSalesParagraph2 As New Paragraph()
            Dim imagePath As String = "C:\Users\Tidus\Documents\POS & INVENTORY SYSTEM\POS2.3\POS2\Resources\Hardware.PNG"


            If File.Exists(imagePath) Then
                Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imagePath)
                image.Alignment = iTextSharp.text.Image.ALIGN_CENTER ' Center-align the image
                image.ScalePercent(30) ' Adjust the scale of the image (50% in this case)
                doc.Add(image)
            End If

            Dim font As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)

            ' Create a new paragraph for the "ITEM RETURNS REPORTS" text

            Dim font1 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            itemSalesParagraph1.Font = font
            itemSalesParagraph1.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM SALES REPORTS" text
            itemSalesParagraph1.Add("Salcedo II, Noveleta, Cavite")
            ' Add the "ITEM RETURNS REPORTS" text to the document
            doc.Add(itemSalesParagraph1)

            ' Create a new paragraph for the "ITEM SALES REPORTS" text

            Dim font2 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            itemSalesParagraph2.Font = font
            itemSalesParagraph2.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM SALES REPORTS" text
            itemSalesParagraph2.Add("615-0798-321")
            ' Add the "ITEM RETURNS REPORTS" text to the document
            doc.Add(itemSalesParagraph2)

            ' Create a new paragraph for the date text
            Dim dateParagraph As New Paragraph()
            Dim smallFont As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            dateParagraph.Font = smallFont
            dateParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the date text
            dateParagraph.Add("Date: " & DateTime.Now.ToString("dd MMMM yyyy"))
            ' Add the date text to the document
            doc.Add(dateParagraph)

            ' Create a new paragraph for the "ITEM SALES REPORTS" text


            itemSalesParagraph.Font = font
            itemSalesParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM SALES REPORTS" text
            itemSalesParagraph.Add("ITEM SALES REPORTS")
            ' Add the "ITEM SALES REPORTS" text to the document
            doc.Add(itemSalesParagraph)

            ' Add some space between the date text and the table
            doc.Add(New Paragraph(" "))

            ' Add a new table to the document
            Dim table As New PdfPTable(listView.Columns.Count)

            ' Add the column headers to the table with the small font
            For Each column As ColumnHeader In listView.Columns
                Dim cell As New PdfPCell(New Phrase(column.Text, smallFont))
                cell.HorizontalAlignment = Element.ALIGN_CENTER ' Set the horizontal alignment to center
                table.AddCell(cell)
            Next

            ' Add the data rows to the table with centered alignment
            For Each item As ListViewItem In listView.Items
                For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                    Dim cell As New PdfPCell(New Phrase(subItem.Text, smallFont))
                    cell.HorizontalAlignment = Element.ALIGN_CENTER ' Set the horizontal alignment to center
                    table.AddCell(cell)
                Next
            Next

            ' Add the table to the document
            doc.Add(table)

            ' Close the document
            doc.Close()

            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(fileName, FileMode.Create))
            ' Show a message box to indicate success
            'MessageBox.Show("PDF file created successfully and saved to " & fileName & ".")
            Process.Start(fileName)

        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalesFilter.Click
        Dim previousDay As Date = DateTimePicker1.Value
        Dim formattedDate As String = previousDay.ToString("MM-dd-yyyy")
        conn1.Close()
        conn1.Open()
        System.Diagnostics.Debug.WriteLine(formattedDate)
        Dim cmd As New SqlCommand("SELECT * FROM sales WHERE release_date LIKE CONCAT('%', @date1, '%') AND delivered = 1 AND pending = 0 AND returned = 0 OR release_date LIKE CONCAT('%', @date1, '%') AND delivered = 0 AND pending = 1 AND returned = 0", conn1)
        cmd.Parameters.Add("date1", formattedDate)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim origDT As New DataTable
        adapter.Fill(origDT)
        adapter.Dispose()
        LvReportsSale.Items.Clear()
        For a As Integer = 0 To origDT.Rows.Count - 1
            Dim list1 = LvReportsSale.Items.Add(origDT.Rows(a).Item(1).ToString)
            Dim dt As DataTable = getCategoryETC(origDT.Rows(a).Item(2).ToString)
            list1.SubItems.Add(origDT.Rows(0).Item(8).ToString)
            list1.SubItems.Add(dt.Rows(0).Item(0).ToString)
            list1.SubItems.Add(origDT.Rows(a).Item(3).ToString)
            list1.SubItems.Add(dt.Rows(0).Item(1).ToString)
            list1.SubItems.Add(dt.Rows(0).Item(2).ToString)
            list1.SubItems.Add(dt.Rows(0).Item(3).ToString)
            list1.SubItems.Add(dt.Rows(0).Item(4).ToString)
            list1.SubItems.Add(origDT.Rows(a).Item(4).ToString)

            Dim str As String = origDT.Rows(a).Item(6).ToString
            Dim floatValue As Single = ConvertStringToFloat(str)

            Dim amount As Decimal = floatValue
            Dim formattedAmount As String = FormatMoney(amount)

            list1.SubItems.Add("₱ " + formattedAmount)
            list1.SubItems.Add(origDT.Rows(a).Item(11).ToString)
            list1.SubItems.Add(origDT.Rows(a).Item(12).ToString)
            dt.Dispose()
        Next
        conn1.Close()

    End Sub

    Private Sub LvReportsSale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvReportsSale.SelectedIndexChanged

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub TbFormSalesSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbFormSalesSearch.KeyDown
        If Not ((e.KeyCode <= Keys.NumPad9 AndAlso e.KeyCode >= Keys.NumPad0) _
         OrElse (e.KeyCode >= Keys.D0 AndAlso e.KeyCode <= Keys.D9) _
            OrElse e.KeyCode = Keys.Back) Then
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub TbFormSalesSearch_TextChanged(sender As Object, e As EventArgs) Handles TbFormSalesSearch.TextChanged
        If TbFormSalesSearch.Text.Length > 0 Then
            conn1.Close()
            conn1.Open()
            Dim cmd As New SqlCommand("SELECT * FROM sales WHERE invoice_number LIKE CONCAT('%', @invoice, '%') AND delivered = 1 AND pending = 0 AND returned = 0 OR invoice_number LIKE CONCAT('%', @invoice, '%') AND delivered = 0 AND pending = 1 AND returned = 0", conn1)
            cmd.Parameters.Add("invoice", Convert.ToInt64(TbFormSalesSearch.Text))
            Dim adapter As New SqlDataAdapter(cmd)
            Dim origDT As New DataTable
            adapter.Fill(origDT)
            adapter.Dispose()
            LvReportsSale.Items.Clear()
            For a As Integer = 0 To origDT.Rows.Count - 1
                Dim list1 = LvReportsSale.Items.Add(origDT.Rows(a).Item(1).ToString)
                Dim dt As DataTable = getCategoryETC(origDT.Rows(a).Item(2).ToString)
                list1.SubItems.Add(origDT.Rows(0).Item(8).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(0).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(3).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(1).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(2).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(3).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(4).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(4).ToString)

                Dim str As String = origDT.Rows(a).Item(6).ToString
                Dim floatValue As Single = ConvertStringToFloat(str)

                Dim amount As Decimal = floatValue
                Dim formattedAmount As String = FormatMoney(amount)

                list1.SubItems.Add("₱ " + formattedAmount)
                list1.SubItems.Add(origDT.Rows(a).Item(11).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(12).ToString)
                dt.Dispose()
            Next
            conn1.Close()
        Else
            RefreshUI()
        End If

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Public Function getCategoryETC(id As String) As DataTable
        Using connection As New SqlConnection(dbHandler.getConnectionString())
            connection.Open()
            Dim cmd As New SqlCommand("SELECT category, classification, brand, size, colors FROM dbo.products WHERE id= @id", conn1)
            cmd.Parameters.Add("@id", id)
            Dim dataAdapter As New SqlDataAdapter(cmd)
            Dim tempDT As New DataTable
            dataAdapter.Fill(tempDT)
            connection.Close()
            Return tempDT
        End Using
    End Function



    Public Function FormatMoney(ByVal amount As Decimal) As String
        Dim str As String = String.Format("{0:N}", amount)
        Dim count As Integer = 0
        Dim startIndex As Integer = 0

        ' If there are digits after the decimal point
        If str.Contains(".") Then
            ' Calculate the number of digits after the decimal point
            count = str.Length - str.IndexOf(".") - 1
        End If

        If count > 3 Then
            startIndex = count Mod 3
            If startIndex <> 0 Then
                startIndex -= 3
            End If
            For i As Integer = str.Length - 1 To 0 Step -1
                If (i - startIndex) Mod 3 = 0 AndAlso i <> str.Length - 1 Then
                    str = str.Insert(i, ",")
                End If
            Next
        End If

        Return str
    End Function


    Public Function ConvertStringToFloat(ByVal str As String) As Single
        Dim floatValue As Single
        If Single.TryParse(str, floatValue) Then
            Return floatValue
        Else
            Return Single.NaN ' or throw an exception
        End If
    End Function



End Class