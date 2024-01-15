Imports System.Globalization
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports iText.Kernel.Pdf.Annot

Public Class FormDelivery
    Private ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private ReadOnly product As New Product
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString

    Dim listSales As New List(Of Sale)
    Dim selectedSale As Sale
    Private Sub FormDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshUI()
    End Sub


    Public Sub RefreshUI()
        Try
            conn1.Close()
            conn1.Open()
            Dim cmd As New SqlCommand("SELECT * FROM sales WHERE order_type = 'Deliver' AND returned = 0", conn1)

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
                list1.SubItems.Add(origDT.Rows(a).Item(19).ToString)
                Dim status As String
                If Convert.ToBoolean(origDT.Rows(a).Item(18).ToString) = False Then
                    status = "DELIVERED"
                Else
                    status = "NOT DELIVERED"
                End If

                list1.SubItems.Add(status)
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
            Else
                'No filter applied
                filteredSales = listSales
            End If
            PopulateListView(filteredSales)
        Else
            'No filter applied
            filteredSales = listSales.Where(Function(s) s.Delivered).ToList()
            PopulateListView(filteredSales)
        End If
    End Sub

    Private Sub PopulateListView(sales As IEnumerable(Of Sale))
        LvReportsSale.BeginUpdate()
        Try
            Dim uniqueInvoices As New HashSet(Of Integer)()

            For Each s As Sale In sales
                If s.Delivered AndAlso Not s.Returned AndAlso Not uniqueInvoices.Contains(s.Invoice_Number) Then
                    uniqueInvoices.Add(s.Invoice_Number)

                    Dim _lvItem As New ListViewItem(s.Invoice_Number)
                    _lvItem.SubItems.Add(s.Customer_Name)
                    _lvItem.SubItems.Add(s.Product_Name)
                    _lvItem.SubItems.Add(s.Quantity)
                    _lvItem.SubItems.Add(String.Format("₱ {0}", s.Price))
                    _lvItem.SubItems.Add(s.Release_Date)
                    _lvItem.SubItems.Add(s.Release_Time)
                    If s.Pending Then
                        _lvItem.SubItems.Add("NOT DELIVERED")
                    Else
                        _lvItem.SubItems.Add("DELIVERED")
                    End If
                    _lvItem.Tag = s
                    LvReportsSale.Items.Add(_lvItem)
                End If
            Next

            LvReportsSale.Sort()
        Finally
            LvReportsSale.EndUpdate()
        End Try

    End Sub

    Private Function DeliveryStatus(sale As Sale) As String
        If (sale.Pending) Then
            Return "Pending"
        Else
            Return "Delivered"
        End If
    End Function

    Private Sub BtnFormSalesSearch_Click(sender As Object, e As EventArgs)
        SearchListView(True, False, False, TbFormSalesSearch.Text)
    End Sub

    Private Sub BtnFormSalesRefresh_Click(sender As Object, e As EventArgs)
        SearchListView(False, False, False, Nothing)
        TbFormSalesSearch.Clear()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'Dim dateString As String = DateTimePicker1.Value.ToString("MM-dd-yyyy")
        ' SearchListView(True, False, True, dateString)
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
            Dim itemDeliveryParagraph As New Paragraph()
            Dim itemDeliveryParagraph1 As New Paragraph()
            Dim itemDeliveryParagraph2 As New Paragraph()
            Dim imagePath As String = "C:\Users\jobel\OneDrive\Desktop\6-24-2023\POS2.3\POS2\Resources\POSLOGO.PNG"


            If File.Exists(imagePath) Then
                Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imagePath)
                image.Alignment = iTextSharp.text.Image.ALIGN_CENTER ' Center-align the image
                image.ScalePercent(30) ' Adjust the scale of the image (50% in this case)
                doc.Add(image)
            End If

            Dim font As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)

            ' Create a new paragraph for the "ITEM DELIVERY REPORTS" text

            Dim font1 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            itemDeliveryParagraph1.Font = font
            itemDeliveryParagraph1.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM SALES REPORTS" text
            itemDeliveryParagraph1.Add("Salcedo II, Noveleta, Cavite")
            ' Add the "ITEM RETURNS REPORTS" text to the document
            doc.Add(itemDeliveryParagraph1)

            ' Create a new paragraph for the "ITEM DELIVERY REPORTS" text

            Dim font2 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            itemDeliveryParagraph2.Font = font
            itemDeliveryParagraph2.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM DELIVERY REPORTS" text
            itemDeliveryParagraph2.Add("615-0798-321")
            ' Add the "ITEM DELIVERY REPORTS" text to the document
            doc.Add(itemDeliveryParagraph2)

            ' Create a new paragraph for the date text
            Dim dateParagraph As New Paragraph()
            Dim smallFont As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            dateParagraph.Font = smallFont
            dateParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the date text
            dateParagraph.Add("Date: " & DateTime.Now.ToString("dd MMMM yyyy"))
            ' Add the date text to the document
            doc.Add(dateParagraph)

            ' Create a new paragraph for the "ITEM DELIVERY REPORTS" text


            itemDeliveryParagraph.Font = font
            itemDeliveryParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM SALES REPORTS" text
            itemDeliveryParagraph.Add("ITEM DELIVERY REPORTS")
            ' Add the "ITEM DELIVERY REPORTS" text to the document
            doc.Add(itemDeliveryParagraph)

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

    Private Sub BtnFormDeliveryPrint_Click(sender As Object, e As EventArgs) Handles BtnFormDeliveryPrint.Click
        FormPrintPreview.printType = "deliver"
        Try
            FormPrintPreview.Show()
        Catch

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDeliveriesFilter.Click
        Dim previousDay As Date = DateTimePicker1.Value
        Dim formattedDate As String = previousDay.ToString("MM-dd-yyyy")
        conn1.Close()
        conn1.Open()
        System.Diagnostics.Debug.WriteLine(formattedDate)
        Dim cmd As New SqlCommand("SELECT * FROM sales WHERE release_date LIKE CONCAT('%', @date1, '%') AND order_type = 'Deliver'", conn1)
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
            list1.SubItems.Add(origDT.Rows(a).Item(19).ToString)
            Dim status As String
            If Convert.ToBoolean(origDT.Rows(a).Item(18).ToString) = False Then
                status = "DELIVERED"
            Else
                status = "NOT DELIVERED"
            End If

            list1.SubItems.Add(status)
            dt.Dispose()
        Next
        conn1.Close()

    End Sub

    Private Sub LvReportsSale_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

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
            Dim cmd As New SqlCommand("SELECT * FROM sales WHERE invoice_number LIKE CONCAT('%', @invoice, '%') AND order_type = 'Deliver'", conn1)
            cmd.Parameters.Add("invoice", Convert.ToInt32(TbFormSalesSearch.Text))
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
                list1.SubItems.Add(origDT.Rows(a).Item(19).ToString)
                Dim status As String
                If Convert.ToBoolean(origDT.Rows(a).Item(18).ToString) = False Then
                    status = "DELIVERED"
                Else
                    status = "NOT DELIVERED"
                End If

                list1.SubItems.Add(status)
                dt.Dispose()
            Next
        Else
            RefreshUI()
        End If
    End Sub

    Private Sub tbDelivered_Click(sender As Object, e As EventArgs) Handles tbDelivered.Click
        Dim previousDay As Date = DateTimePicker1.Value
        Dim formattedDate As String = previousDay.ToString("MM-dd-yyyy")
        conn1.Close()
        conn1.Open()
        System.Diagnostics.Debug.WriteLine(formattedDate)
        Dim cmd As New SqlCommand("SELECT * FROM sales WHERE pending= 'false' AND order_type = 'Deliver'", conn1)
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
            list1.SubItems.Add(origDT.Rows(a).Item(19).ToString)
            Dim status As String
            If Convert.ToBoolean(origDT.Rows(a).Item(18).ToString) = False Then
                status = "DELIVERED"
            Else
                status = "NOT DELIVERED"
            End If

            list1.SubItems.Add(status)
            dt.Dispose()
        Next
    End Sub

    Private Sub tbNotDelivered_Click(sender As Object, e As EventArgs) Handles tbNotDelivered.Click
        Dim previousDay As Date = DateTimePicker1.Value
        Dim formattedDate As String = previousDay.ToString("MM-dd-yyyy")
        conn1.Close()
        conn1.Open()
        System.Diagnostics.Debug.WriteLine(formattedDate)
        Dim cmd As New SqlCommand("SELECT * FROM sales WHERE pending = 'true' AND order_type = 'Deliver'", conn1)
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
            list1.SubItems.Add(origDT.Rows(a).Item(19).ToString)
            Dim status As String
            If Convert.ToBoolean(origDT.Rows(a).Item(18).ToString) = False Then
                status = "DELIVERED"
            Else
                status = "NOT DELIVERED"
            End If

            list1.SubItems.Add(status)
            dt.Dispose()
        Next
        conn1.Close()
    End Sub
    Public Function getCategoryETC(id As String) As DataTable
        Using connection As New SqlConnection(dbHandler.getConnectionString())
            connection.Open()
            Dim cmd As New SqlCommand("SELECT category, classification, brand, size, colors FROM dbo.products WHERE id= @id", connection)
            cmd.Parameters.Add("@id", id)
            Dim dataAdapter As New SqlDataAdapter(cmd)
            Dim tempDT As New DataTable
            dataAdapter.Fill(tempDT)
            connection.Close()
            Return tempDT
        End Using
    End Function
    Public Function getAll(id As String, name As String) As DataTable
        Using connection As New SqlConnection(dbHandler.getConnectionString())
            connection.Open()
            Dim cmd As New SqlCommand("SELECT * FROM sales WHERE invoice_number= @id", connection)
            cmd.Parameters.Add("@id", id)
            Dim dataAdapter As New SqlDataAdapter(cmd)
            Dim tempDT As New DataTable
            dataAdapter.Fill(tempDT)
            connection.Close()
            Return tempDT
        End Using
    End Function

    Private Sub LvReportsSale_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles LvReportsSale.SelectedIndexChanged

    End Sub
    Private Sub LvReportsSale_ItemActivate(sender As Object, e As EventArgs) Handles LvReportsSale.ItemActivate
        Dim selectedItem As ListViewItem = LvReportsSale.SelectedItems(0)
        selectedSale = CType(selectedItem.Tag, Sale)
    End Sub

    Private Sub LvReportsSale_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LvReportsSale.MouseDoubleClick

        Dim invoiceNum As String = LvReportsSale.SelectedItems(0).SubItems(0).Text
        Dim dt As DataTable = getAll(LvReportsSale.SelectedItems(0).SubItems(0).Text, LvReportsSale.SelectedItems(0).SubItems(3).Text)
        Dim productID As String = dt.Rows(0).Item(2).ToString()

        FormUpdateDeliveredProduct.newFillAllFields(invoiceNum, productID)
        FormUpdateDeliveredProduct.Show()
        dt.Dispose()
    End Sub

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