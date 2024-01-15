Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Data.SqlClient
Imports System.IO

Public Class FormExpiredProducts
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString
    Dim listExpired As New List(Of Expired)
    Dim listProducts As New List(Of Product)

    Private Sub FormExpiredProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshUI()
    End Sub
    Public Sub RefreshUI()
        TbFormExpiredSearch.Clear()
        listProducts = dbHandler.GetProducts

        conn1.Close()
        conn1.Open()
        Dim cmd As New SqlCommand("SELECT * FROM expired ORDER BY expdate ASC", conn1)
        Dim da As SqlDataReader = cmd.ExecuteReader
        LvReportsExpirees.Items.Clear()
        Do While da.Read = True
            Dim list1 = LvReportsExpirees.Items.Add(da(1))
            list1.SubItems.add(da(2))
            list1.SubItems.add(da(3))
            list1.SubItems.add(da(4))
            list1.SubItems.add(da(5))
            list1.SubItems.add(da(6))
            list1.SubItems.add(da(7))
            list1.SubItems.add(da.GetInt32(8))
            list1.SubItems.add(da(9))

        Loop
        conn1.Close()


    End Sub

    Public Sub SearchListView(filtered As Boolean, searchByDate As Boolean, query As String)
        Dim filteredProducts As List(Of Expired)
        If filtered = True Then
            If Not String.IsNullOrEmpty(query) Then
                If searchByDate = True Then
                    filteredProducts = listExpired.Where(Function(s) s.ExpiredDate = query).ToList()
                Else
                    filteredProducts = listExpired.Where(Function(s) s.Product_Id.ToString().StartsWith(query, StringComparison.InvariantCultureIgnoreCase)).ToList()
                End If
                PopulateListView(filteredProducts)
            End If
        Else
            filteredProducts = listExpired
            PopulateListView(filteredProducts)
        End If
    End Sub
    Public Function GetProductName(id As String) As String
        For Each product In listProducts
            If product.Id = id Then
                Return product.Name
            End If
        Next
        Return ""
    End Function
    Private Sub PopulateListView(expires As IEnumerable(Of Expired))
        LvReportsExpirees.Items.Clear()
        For Each expiredProduct As Expired In expires
            Dim _lvItem As New ListViewItem(expiredProduct.Product_Id.ToString())
            _lvItem.SubItems.Add(GetProductName(expiredProduct.Product_Id))
            _lvItem.SubItems.Add(expiredProduct.Quantity)
            _lvItem.SubItems.Add(expiredProduct.ExpiredDate)
            LvReportsExpirees.Items.Add(_lvItem)
        Next
    End Sub

    Private Sub BtnFormDamagesRefresh_Click(sender As Object, e As EventArgs)
        RefreshUI()
    End Sub

    Private Sub BtnFormExpiredSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DtpExpired_ValueChanged(sender As Object, e As EventArgs)
        Dim dateString As String = DtpExpired.Value.ToString("MM-dd-yyyy")
        SearchListView(True, True, dateString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim selectedDate As DateTime = DtpExpired.Value
        Dim previousDay As DateTime = selectedDate.AddDays(-1)
        conn1.Open()
        Dim cmd As New SqlCommand("select * from expired Where date between @date1 and @date2", conn1)
        cmd.Parameters.Add("date1", SqlDbType.DateTime).Value = previousDay
        Dim da As SqlDataReader = cmd.ExecuteReader
        LvReportsExpirees.Items.Clear()
        Do While da.Read = True
            Dim list1 = LvReportsExpirees.Items.Add(da(1))

            list1.SubItems.add(da(3))
            list1.SubItems.add(da(2))



        Loop
        conn1.Close()
    End Sub

    Private Sub BtnExpiredPrint_Click(sender As Object, e As EventArgs) Handles BtnExpiredPrint.Click
        FormPrintPreview.printType = "expired"
        Try
            FormPrintPreview.Show()
        Catch

        End Try
        'PrintToPdf(LvReportsExpirees, "HCH_SALES")
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
            Dim itemExpiredParagraph As New Paragraph()
            Dim itemExpiredParagraph1 As New Paragraph()
            Dim itemExpiredParagraph2 As New Paragraph()
            Dim imagePath As String = "C:\Users\jobel\OneDrive\Desktop\6-24-2023\POS2.3\POS2\Resources\POSLOGO.PNG"


            If File.Exists(imagePath) Then
                Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imagePath)
                image.Alignment = iTextSharp.text.Image.ALIGN_CENTER ' Center-align the image
                image.ScalePercent(30) ' Adjust the scale of the image (50% in this case)
                doc.Add(image)
            End If

            Dim font As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)

            ' Create a new paragraph for the "ITEM EXPIRED REPORTS" text

            Dim font1 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            itemExpiredParagraph1.Font = font
            itemExpiredParagraph1.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM EXPIRED REPORTS" text
            itemExpiredParagraph1.Add("Salcedo II, Noveleta, Cavite")
            ' Add the "ITEM EXPIRED REPORTS" text to the document
            doc.Add(itemExpiredParagraph1)

            ' Create a new paragraph for the "ITEM EXPIRED REPORTS" text

            Dim font2 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            itemExpiredParagraph2.Font = font
            itemExpiredParagraph2.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM EXPIRED REPORTS" text
            itemExpiredParagraph2.Add("615-0798-321")
            ' Add the "ITEM EXPIRED REPORTS" text to the document
            doc.Add(itemExpiredParagraph2)

            ' Create a new paragraph for the date text
            Dim dateParagraph As New Paragraph()
            Dim smallFont As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            dateParagraph.Font = smallFont
            dateParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the date text
            dateParagraph.Add("Date: " & DateTime.Now.ToString("dd MMMM yyyy"))
            ' Add the date text to the document
            doc.Add(dateParagraph)

            ' Create a new paragraph for the "ITEM SALES REPORTS" text


            itemExpiredParagraph.Font = font
            itemExpiredParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM EXPIRED REPORTS" text
            itemExpiredParagraph.Add("ITEM EXPIRED REPORTS")
            ' Add the "ITEM EXPIRED REPORTS" text to the document
            doc.Add(itemExpiredParagraph)

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

    Private Sub DtpExpired_ValueChanged_1(sender As Object, e As EventArgs) Handles DtpExpired.ValueChanged
        Dim dateString As String = DtpExpired.Value.ToString("MM-dd-yyyy")
        Dim previousDay As Date = DtpExpired.Value
        Dim formattedDate As String = previousDay.ToString("MM-dd-yyyy")
        conn1.Close()
        conn1.Open()
        System.Diagnostics.Debug.WriteLine(formattedDate)
        Dim cmd As New SqlCommand("SELECT * FROM expired WHERE expdate LIKE CONCAT('%', @date1, '%')", conn1)
        cmd.Parameters.Add("date1", formattedDate)

        Dim da As SqlDataReader = cmd.ExecuteReader
        LvReportsExpirees.Items.Clear()
        Do While da.Read = True
            Dim list1 = LvReportsExpirees.Items.Add(da(1))
            list1.SubItems.Add(da.GetString(2)) ' Assuming Column2 is of type Integer
            list1.SubItems.Add(da.GetString(3)) ' Assuming Column3 is of type String
            list1.SubItems.Add(da.GetInt32(4).ToString())
            list1.SubItems.Add("₱ " + da.GetString(5).ToString())
            list1.SubItems.Add(da.GetString(6))
            list1.SubItems.Add(da.GetString(7))
            list1.SubItems.Add(da.GetString(8))
        Loop
        conn1.Close()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub TbFormExpiredSearch_TextChanged(sender As Object, e As EventArgs) Handles TbFormExpiredSearch.TextChanged
        If TbFormExpiredSearch.Text.Length > 0 Then
            conn1.Close()
            conn1.Open()
            Dim cmd As New SqlCommand("SELECT * FROM expired WHERE product_id LIKE CONCAT('%', @productid, '%') ORDER BY expdate ASC", conn1)
            cmd.Parameters.Add("productid", TbFormExpiredSearch.Text)
            Dim da As SqlDataReader = cmd.ExecuteReader
            LvReportsExpirees.Items.Clear()
            Do While da.Read = True
                Dim list1 = LvReportsExpirees.Items.Add(da(1))
                list1.SubItems.add(da(2))
                list1.SubItems.add(da(3))
                list1.SubItems.add(da(4))
                list1.SubItems.add(da(5))
                list1.SubItems.add(da(6))
                list1.SubItems.add(da(7))
                list1.SubItems.add(da.GetInt32(8))
                list1.SubItems.add(da(9))

            Loop
            conn1.Close()
        Else
            RefreshUI()
        End If
    End Sub

    Private Sub LvReportsExpirees_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub LvReportsExpirees_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles LvReportsExpirees.SelectedIndexChanged

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