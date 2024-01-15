Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports iText.Forms.Util.DrawingUtil
Imports System.Drawing.Printing
Imports ServiceStack.Text.Common
Imports Google.Protobuf.Collections

Imports System.Drawing.Imaging

Imports System.Globalization

Public Class FormReturns
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString
    Dim listSales As New List(Of Sale)
    Private Sub FormReturns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  listSales = dbHandler.GetSale()
        ' SearchListView(False, False, Nothing)
        newviewforreturned()
    End Sub
    Public Sub newviewforreturned()
        Try
            conn1.Close()
            conn1.Open()
            Dim cmd As New SqlCommand("SELECT * FROM returned_items", conn1)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim origDT As New DataTable
            adapter.Fill(origDT)
            adapter.Dispose()
            LvReportsReturns.Items.Clear()
            For a As Integer = 0 To origDT.Rows.Count - 1
                Dim list1 = LvReportsReturns.Items.Add(origDT.Rows(a).Item(1).ToString)
                Dim dt As DataTable = getCategoryETC(origDT.Rows(a).Item(2).ToString)
                list1.SubItems.Add(origDT.Rows(0).Item(3).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(0).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(4).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(1).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(2).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(3).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(4).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(5).ToString)

                Dim str As String = origDT.Rows(a).Item(6).ToString
                Dim floatValue As Single = ConvertStringToFloat(str)

                Dim amount As Decimal = floatValue
                Dim formattedAmount As String = FormatMoney(amount)



                list1.SubItems.Add("₱ " + formattedAmount)
                list1.SubItems.Add(origDT.Rows(a).Item(7).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(8).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(9).ToString)
                dt.Dispose()
            Next
            conn1.Close()
        Catch
        End Try
    End Sub
    Private Sub SearchListView(filtered As Boolean, searchByDate As Boolean, query As String)
        listSales = dbHandler.GetSale()
        LvReportsReturns.Items.Clear()
        Dim filteredSales As List(Of Sale)
        If filtered Then
            If Not String.IsNullOrEmpty(query) Then
                If searchByDate Then
                    filteredSales = listSales.Where(Function(s) s.Release_Date = query).ToList()
                    LvReportsReturns.Columns(7).Width = 0
                Else
                    filteredSales = listSales.Where(Function(s) s.Invoice_Number.Equals(Integer.Parse(query))).ToList()
                    '.ToString().StartsWith(query, StringComparison.InvariantCultureIgnoreCase)).ToList()
                    LvReportsReturns.Columns(7).Width = 0
                End If
                PopulateListView(filteredSales)
            End If
        Else
            filteredSales = listSales
            PopulateListView(filteredSales)
            LvReportsReturns.Columns(7).Width = 0
        End If
    End Sub

    Private Sub PopulateListView(sales As IEnumerable(Of Sale))
        LvReportsReturns.BeginUpdate()
        Try
            For Each s As Sale In sales
                If s.Returned Then
                    Dim _lvItem As New ListViewItem(s.Invoice_Number)
                    _lvItem.SubItems.Add(s.Customer_Name)
                    _lvItem.SubItems.Add(s.Product_Name)
                    _lvItem.SubItems.Add(s.Quantity)
                    _lvItem.SubItems.Add(s.Price)
                    _lvItem.SubItems.Add(s.Release_Date)
                    _lvItem.SubItems.Add(s.Release_Time)
                    _lvItem.SubItems.Add(s.Returned)
                    LvReportsReturns.Items.Add(_lvItem)
                End If
            Next
            LvReportsReturns.Columns(7).Width = 0
        Finally
            LvReportsReturns.EndUpdate()
        End Try
    End Sub

    Private Sub LvReportsReturns_ItemActivate(sender As Object, e As EventArgs) Handles LvReportsReturns.ItemActivate
        FormViewReturnedProduct.ShowDialog()
    End Sub

    Private Sub BtnFormSalesRefresh_Click(sender As Object, e As EventArgs)
        newviewforreturned()
        TbFormSalesSearch.Clear()
        DateTimePicker1.ResetText()
    End Sub

    Private Sub BtnFormSalesSearch_Click(sender As Object, e As EventArgs)
        Dim invoiceNumber As String = TbFormSalesSearch.Text
        conn1.Open()
        Dim cmd As New SqlCommand("SELECT * FROM returned_items WHERE invoice_number = @invoiceNumber", conn1)
        cmd.Parameters.Add("invoiceNumber", SqlDbType.VarChar).Value = invoiceNumber
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        ' Clear existing items in the ListView (optional)
        LvReportsReturns.Items.Clear()

        ' Iterate through the data and populate the ListView
        While reader.Read()
            ' Create a new ListViewItem to represent a row of data
            Dim item As New ListViewItem(reader.GetString(1)) ' Assuming Column1 is of type String
            item.SubItems.Add(reader.GetString(2)) ' Assuming Column2 is of type Integer
            item.SubItems.Add(reader.GetString(3)) ' Assuming Column3 is of type String
            item.SubItems.Add(reader.GetInt32(4).ToString())
            item.SubItems.Add("₱ " + reader.GetString(5).ToString())
            item.SubItems.Add(reader.GetString(6))
            item.SubItems.Add(reader.GetString(7))
            If reader.IsDBNull(8) Then
                item.SubItems.Add("") ' If null, add an empty string as the subitem
            Else
                item.SubItems.Add(reader.GetString(8)) ' Assuming Column8 is of type String
            End If

            ' Add the ListViewItem to the ListView
            LvReportsReturns.Items.Add(item)
        End While

        ' Close the reader and the connection
        reader.Close()
        conn1.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        '    SearchListView(True, True, DateTimePicker1.Value.ToString("MM-dd-yyyy"))
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnReturnFilter.Click
        Dim previousDay As Date = DateTimePicker1.Value
        Dim formattedDate As String = previousDay.ToString("MM-dd-yyyy")
        conn1.Close()
        conn1.Open()
        System.Diagnostics.Debug.WriteLine(formattedDate)
        Dim cmd As New SqlCommand("SELECT * FROM returned_items WHERE item_date LIKE CONCAT('%', @date1, '%')", conn1)
        cmd.Parameters.Add("date1", formattedDate)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim origDT As New DataTable
        adapter.Fill(origDT)
        adapter.Dispose()
        LvReportsReturns.Items.Clear()
        For a As Integer = 0 To origDT.Rows.Count - 1
            Dim list1 = LvReportsReturns.Items.Add(origDT.Rows(a).Item(1).ToString)
            Dim dt As DataTable = getCategoryETC(origDT.Rows(a).Item(2).ToString)
            list1.SubItems.Add(origDT.Rows(0).Item(3).ToString)
            list1.SubItems.Add(dt.Rows(0).Item(0).ToString)
            list1.SubItems.Add(origDT.Rows(a).Item(4).ToString)
            list1.SubItems.Add(dt.Rows(0).Item(1).ToString)
            list1.SubItems.Add(dt.Rows(0).Item(2).ToString)
            list1.SubItems.Add(dt.Rows(0).Item(3).ToString)
            list1.SubItems.Add(dt.Rows(0).Item(4).ToString)
            list1.SubItems.Add(origDT.Rows(a).Item(5).ToString)

            Dim str As String = origDT.Rows(a).Item(6).ToString
            Dim floatValue As Single = ConvertStringToFloat(str)

            Dim amount As Decimal = floatValue
            Dim formattedAmount As String = FormatMoney(amount)



            list1.SubItems.Add("₱ " + formattedAmount)
            list1.SubItems.Add(origDT.Rows(a).Item(7).ToString)
            list1.SubItems.Add(origDT.Rows(a).Item(8).ToString)
            list1.SubItems.Add(origDT.Rows(a).Item(9).ToString)
            dt.Dispose()
        Next
        conn1.Close()


    End Sub

    Private Sub BtnReturnPrint_Click(sender As Object, e As EventArgs) Handles BtnReturnPrint.Click
        FormPrintPreview.printType = "returns"
        Try
            FormPrintPreview.Show()
        Catch

        End Try
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
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(fileName, FileMode.Create))

            ' Open the document for writing
            doc.Open()
            Dim itemReportsParagraph As New Paragraph()
            Dim itemReportsParagraph1 As New Paragraph()
            Dim itemReportsParagraph2 As New Paragraph()
            Dim imagePath As String = "C:\Users\jobel\OneDrive\Desktop\6-24-2023\POS2.3\POS2\Resources\POSLOGO.PNG"


            If File.Exists(imagePath) Then
                Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imagePath)
                image.Alignment = iTextSharp.text.Image.ALIGN_CENTER ' Center-align the image
                image.ScalePercent(30) ' Adjust the scale of the image (50% in this case)
                doc.Add(image)
            End If

            Dim font As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)

            ' Create a new paragraph for the "ITEM RETURNS REPORTS" text

            Dim font1 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            itemReportsParagraph1.Font = font
            itemReportsParagraph1.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM RETURNS REPORTS" text
            itemReportsParagraph1.Add("Salcedo II, Noveleta, Cavite")
            ' Add the "ITEM RETURNS REPORTS" text to the document
            doc.Add(itemReportsParagraph1)

            ' Create a new paragraph for the "ITEM RETURNS REPORTS" text

            Dim font2 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            itemReportsParagraph2.Font = font
            itemReportsParagraph2.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM RETURNS REPORTS" text
            itemReportsParagraph2.Add("615-0798-321")
            ' Add the "ITEM RETURNS REPORTS" text to the document
            doc.Add(itemReportsParagraph2)

            ' Create a new paragraph for the date text
            Dim dateParagraph As New Paragraph()
            Dim smallFont As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            dateParagraph.Font = smallFont
            dateParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the date text
            dateParagraph.Add("Date: " & DateTime.Now.ToString("dd MMMM yyyy"))
            ' Add the date text to the document
            doc.Add(dateParagraph)

            ' Create a new paragraph for the "ITEM RETURNS REPORTS" text


            itemReportsParagraph.Font = font
            itemReportsParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM RETURNS REPORTS" text
            itemReportsParagraph.Add("ITEM RETURNS REPORTS")
            ' Add the "ITEM RETURNS REPORTS" text to the document
            doc.Add(itemReportsParagraph)

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


            ' Show a message box to indicate success
            'MessageBox.Show("PDF file created successfully and saved to " & fileName & ".")
            Process.Start(fileName)
        End If

    End Sub

    Private Sub LvReportsReturns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvReportsReturns.SelectedIndexChanged

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

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
            Dim cmd As New SqlCommand("SELECT * FROM returned_items WHERE invoice_number LIKE CONCAT('%', @invoice, '%')", conn1)
            cmd.Parameters.Add("invoice", TbFormSalesSearch.Text)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim origDT As New DataTable
            adapter.Fill(origDT)
            adapter.Dispose()
            LvReportsReturns.Items.Clear()
            For a As Integer = 0 To origDT.Rows.Count - 1
                Dim list1 = LvReportsReturns.Items.Add(origDT.Rows(a).Item(1).ToString)
                Dim dt As DataTable = getCategoryETC(origDT.Rows(a).Item(2).ToString)
                list1.SubItems.Add(origDT.Rows(0).Item(3).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(0).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(4).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(1).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(2).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(3).ToString)
                list1.SubItems.Add(dt.Rows(0).Item(4).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(5).ToString)

                Dim str As String = origDT.Rows(a).Item(6).ToString
                Dim floatValue As Single = ConvertStringToFloat(str)

                Dim amount As Decimal = floatValue
                Dim formattedAmount As String = FormatMoney(amount)



                list1.SubItems.Add("₱ " + formattedAmount)
                list1.SubItems.Add(origDT.Rows(a).Item(7).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(8).ToString)
                list1.SubItems.Add(origDT.Rows(a).Item(9).ToString)
                dt.Dispose()
            Next
            conn1.Close()
        Else
            newviewforreturned()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

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