Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Data.SqlClient
Imports System.IO

Public Class FormDamages
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Dim listDamages As New List(Of Damage)
    Dim listProducts As New List(Of Product)

    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString

    Private Sub FormDamages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshUI()
    End Sub

    Public Function GetProducts() As List(Of Product)
        Return dbHandler.GetProducts
    End Function
    Public Function GetDamages() As List(Of Damage)
        Return dbHandler.GetDamages
    End Function

    Public Function GetProductName(id As String) As String
        For Each product In listProducts
            If product.Id = id Then
                Return product.Name
            End If
        Next
        Return ""
    End Function

    Public Sub SearchListView(filtered As Boolean, searchByDate As Boolean, query As String)
        Dim filteredProducts As List(Of Damage)
        If filtered Then
            If Not String.IsNullOrEmpty(query) Then
                If searchByDate Then
                    filteredProducts = listDamages.Where(Function(s) s.DamagesDate = query).ToList()
                Else
                    filteredProducts = listDamages.Where(Function(s) s.Product_Id.ToString().StartsWith(query, StringComparison.InvariantCultureIgnoreCase)).ToList()
                End If
                PopulateListView(filteredProducts)
            End If
        Else
            filteredProducts = listDamages
            PopulateListView(filteredProducts)
        End If
    End Sub

    Private Sub PopulateListView(damages As IEnumerable(Of Damage))
        LvReportsDamages.Items.Clear()
        For Each damage As Damage In damages
            Dim _lvItem As New ListViewItem(damage.Product_Id.ToString())
            _lvItem.SubItems.Add(GetProductName(damage.Product_Id))
            _lvItem.SubItems.Add(damage.Quantity)
            _lvItem.SubItems.Add(damage.DamagesDate)
            _lvItem.SubItems.Add(damage.Remarks)
            LvReportsDamages.Items.Add(_lvItem)
        Next
    End Sub

    Public Sub RefreshUI()
        TbFormDamagesSearch.Clear()

        conn1.Close()
        conn1.Open()
        Dim cmd As New SqlCommand("SELECT * FROM damages ORDER BY date ASC", conn1)
        Dim da As SqlDataReader = cmd.ExecuteReader
        LvReportsDamages.Items.Clear()
        Do While da.Read = True
            Dim list1 = LvReportsDamages.Items.Add(da(1))
            list1.SubItems.add(da(2))
            list1.SubItems.add(da(3))
            list1.SubItems.add(da(4))
            list1.SubItems.add(da(5))
            list1.SubItems.add(da(6))
            list1.SubItems.add(da(7))
            list1.SubItems.add(da.GetInt32(8))
            list1.SubItems.add(da(9))
            list1.SubItems.add(da(10))
        Loop
        conn1.Close()





        'listProducts = GetProducts()
        'listDamages = GetDamages()
        'SearchListView(False, False, Nothing)
    End Sub

    Private Sub BtnFormDamagesSearch_Click(sender As Object, e As EventArgs)
        SearchListView(True, False, TbFormDamagesSearch.Text)
    End Sub

    Private Sub BtnFormDamagesRefresh_Click(sender As Object, e As EventArgs)
        RefreshUI()
    End Sub

    Private Sub DtpDamages_ValueChanged(sender As Object, e As EventArgs)
        Dim dateString As String = DtpDamages.Value.ToString("MM-dd-yyyy")
        SearchListView(True, True, dateString)
    End Sub

    Private Sub BtnDamagePrint_Click(sender As Object, e As EventArgs) Handles BtnDamagePrint.Click
        FormPrintPreview.printType = "damaged"
        Try
            FormPrintPreview.Show()
        Catch

        End Try
        'PrintToPdf(LvReportsDamages, "HCH_SALES")
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
            Dim itemDamagesParagraph As New Paragraph()
            Dim itemDamagesParagraph1 As New Paragraph()
            Dim itemDamagesParagraph2 As New Paragraph()
            Dim imagePath As String = "C:\Users\jobel\OneDrive\Desktop\6-24-2023\POS2.3\POS2\Resources\POSLOGO.PNG"


            If File.Exists(imagePath) Then
                Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imagePath)
                image.Alignment = iTextSharp.text.Image.ALIGN_CENTER ' Center-align the image
                image.ScalePercent(30) ' Adjust the scale of the image (50% in this case)
                doc.Add(image)
            End If

            Dim font As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)

            ' Create a new paragraph for the "ITEM DAMAGES REPORT" text

            Dim font1 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            itemDamagesParagraph1.Font = font
            itemDamagesParagraph1.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM SALES REPORTS" text
            itemDamagesParagraph1.Add("Salcedo II, Noveleta, Cavite")
            ' Add the "ITEM DAMAGES REPORTS" text to the document
            doc.Add(itemDamagesParagraph1)

            ' Create a new paragraph for the "ITEM DAMAGES REPORTS" text

            Dim font2 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            itemDamagesParagraph2.Font = font
            itemDamagesParagraph2.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM DAMAGES REPORTS" text
            itemDamagesParagraph2.Add("615-0798-321")
            ' Add the "ITEM DAMAGES REPORTS" text to the document
            doc.Add(itemDamagesParagraph2)

            ' Create a new paragraph for the date text
            Dim dateParagraph As New Paragraph()
            Dim smallFont As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            dateParagraph.Font = smallFont
            dateParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the date text
            dateParagraph.Add("Date: " & DateTime.Now.ToString("dd MMMM yyyy"))
            ' Add the date text to the document
            doc.Add(dateParagraph)

            ' Create a new paragraph for the "ITEM DAMAGES REPORTS" text


            itemDamagesParagraph.Font = font
            itemDamagesParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM SALES REPORTS" text
            itemDamagesParagraph.Add("ITEM DAMAGED REPORTS")
            ' Add the "ITEM DAMAGES REPORTS" text to the document
            doc.Add(itemDamagesParagraph)

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

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DtpDamages_ValueChanged_1(sender As Object, e As EventArgs) Handles DtpDamages.ValueChanged
        Dim dateString As String = DtpDamages.Value.ToString("MM-dd-yyyy")
        Dim previousDay As Date = DtpDamages.Value
        Dim formattedDate As String = previousDay.ToString("MM-dd-yyyy")
        conn1.Close()
        conn1.Open()
        System.Diagnostics.Debug.WriteLine(formattedDate)
        Dim cmd As New SqlCommand("SELECT * FROM damages WHERE date LIKE CONCAT('%', @date1, '%')", conn1)
        cmd.Parameters.Add("date1", formattedDate)

        Dim da As SqlDataReader = cmd.ExecuteReader
        LvReportsDamages.Items.Clear()
        Do While da.Read = True
            Dim list1 = LvReportsDamages.Items.Add(da(1))
            list1.SubItems.add(da(2))
            list1.SubItems.add(da(3))
            list1.SubItems.add(da(4))
            list1.SubItems.add(da(5))
            list1.SubItems.add(da(6))
            list1.SubItems.add(da(7))
            list1.SubItems.add(da.GetInt32(8))
            list1.SubItems.add(da(9))
            list1.SubItems.add(da(10))
        Loop
        conn1.Close()
    End Sub

    Private Sub LvReportsDamages_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub TbFormDamagesSearch_TextChanged(sender As Object, e As EventArgs) Handles TbFormDamagesSearch.TextChanged
        If TbFormDamagesSearch.Text.Length > 0 Then
            conn1.Close()
            conn1.Open()
            Dim cmd As New SqlCommand("SELECT * FROM damages WHERE product_id LIKE CONCAT('%', @productid, '%') ORDER BY date ASC", conn1)
            cmd.Parameters.Add("productid", TbFormDamagesSearch.Text)
            Dim da As SqlDataReader = cmd.ExecuteReader
            LvReportsDamages.Items.Clear()
            Do While da.Read = True
                Dim list1 = LvReportsDamages.Items.Add(da(1))
                list1.SubItems.add(da(2))
                list1.SubItems.add(da(3))
                list1.SubItems.add(da(4))
                list1.SubItems.add(da(5))
                list1.SubItems.add(da(6))
                list1.SubItems.add(da(7))
                list1.SubItems.add(da.GetInt32(8))
                list1.SubItems.add(da(9))
                list1.SubItems.add(da(10))

            Loop
            conn1.Close()
        Else
            RefreshUI()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class