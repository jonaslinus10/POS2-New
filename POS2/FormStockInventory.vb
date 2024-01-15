Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Nevron.Nov.DataStructures
Imports System.Windows.Forms
Imports iText.Commons.Actions
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Globalization
Imports System.Windows.Forms.ListViewItem

Public Class FormStockInventory
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Dim listProducts As New List(Of Product)
    Dim selectedProduct As Product
    Private products As List(Of Product)

    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"

    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FormStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshUI()

    End Sub

    Public Class ListViewColumnComparer
        Implements IComparer

        Private columnToSort As Integer

        Public Sub New(column As Integer)
            columnToSort = column
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim itemX As ListViewItem = DirectCast(x, ListViewItem)
            Dim itemY As ListViewItem = DirectCast(y, ListViewItem)

            ' Extract the text from the specified column for comparison
            Dim textX As String = itemX.SubItems(columnToSort).Text
            Dim textY As String = itemY.SubItems(columnToSort).Text

            ' Compare the values using String.Compare
            Return String.Compare(textX, textY)
        End Function
    End Class

    Public Function GetProducts() As List(Of Product)
        Return dbHandler.GetProducts
    End Function

    Public Sub PopulateCbCategories()
        On Error GoTo ErrorHandler
        CbInventoryCats.Items.Clear()
        Dim listCategory As List(Of Category)
        listCategory = dbHandler.GetCategories()

        For Each category As Category In listCategory
            If Not CbInventoryCats.Items.Contains(category.DisplayName) Then
                CbInventoryCats.Items.Add(category.DisplayName)
            End If
        Next
        Exit Sub

ErrorHandler:
        Me.Close()
        Me.Show()
        Me.Refresh()
    End Sub



    Private Sub PopulateListView(products As IEnumerable(Of Product))

        conn1.Open()
        Dim cmd As New SqlCommand("SELECT * FROM products WHERE available = 'true' ORDER BY category", conn1)
        Dim da As SqlDataReader = cmd.ExecuteReader()
        LvProducts.Items.Clear()
        Dim uniqueInvoices As New HashSet(Of String)()
        While da.Read()
            Dim invoiceNumber As String = da(1).ToString()

                If Not uniqueInvoices.Contains(invoiceNumber) Then
                    uniqueInvoices.Add(invoiceNumber)

                Dim item As New ListViewItem(invoiceNumber)
                item.SubItems.Add(da(4).ToString())
                item.SubItems.Add(da(2).ToString())
                item.SubItems.Add(da(13).ToString())
                item.SubItems.Add(da(3).ToString())
                item.SubItems.Add(da(6).ToString())
                item.SubItems.Add(da(7).ToString())

                Dim str As String = da(8).ToString()
                Dim floatValue As Single = ConvertStringToFloat(str)

                Dim amount As Decimal = floatValue
                Dim formattedAmount As String = FormatMoney(amount)

                item.SubItems.Add("₱ " + formattedAmount)
                item.SubItems.Add(da(11).ToString())
                item.SubItems.Add(da(5).ToString())
                item.SubItems.Add(da(9).ToString())
                item.SubItems.Add(da(10).ToString())
                item.SubItems.Add(da(16).ToString())
                LvProducts.Items.Add(item)
                End If

        End While

        da.Close()
        conn1.Close()

        '  LvProducts.ListViewItemSorter = New ListvViewItemComparer()
        LvProducts.Sort()
    End Sub

    Public Sub SearchListView(filtered As Boolean, searchByCategory As Boolean, query As String)
        LvProducts.Items.Clear()
        Dim filteredProducts As List(Of Product)
        If filtered Then
            If Not String.IsNullOrEmpty(query) Then
                If searchByCategory Then
                    filteredProducts = listProducts.Where(Function(s) s.Category = query).ToList()
                Else
                    filteredProducts = listProducts.Where(Function(s) s.Name.ToString().StartsWith(query, StringComparison.InvariantCultureIgnoreCase)).ToList()
                End If
                PopulateListView(filteredProducts)
            End If
        Else
            filteredProducts = listProducts
            PopulateListView(filteredProducts)
        End If
    End Sub
    Private Sub BtnAddProduct_Click(sender As Object, e As EventArgs) Handles BtnAddProduct.Click
        FormAddNewProduct.ShowDialog()
    End Sub

    Private Sub BtnAddCategory_Click(sender As Object, e As EventArgs)
        FormAddCategory.ShowDialog()
    End Sub

    Private Sub CbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbInventoryCats.SelectedIndexChanged
        conn1.Open()

        Dim cmd As New SqlCommand("SELECT * FROM products WHERE category = @ItemName AND available = 'true'", conn1)
        cmd.Parameters.AddWithValue("@ItemName", CbInventoryCats.Text)

        Dim da As SqlDataReader = cmd.ExecuteReader()
        LvProducts.Items.Clear()
        Dim uniqueInvoices As New HashSet(Of String)()

        While da.Read()
            Dim invoiceNumber As String = da(1).ToString()

            If Not uniqueInvoices.Contains(invoiceNumber) Then
                uniqueInvoices.Add(invoiceNumber)

                Dim item As New ListViewItem(invoiceNumber)
                item.SubItems.Add(da(4).ToString())
                item.SubItems.Add(da(2).ToString())
                item.SubItems.Add(da(13).ToString())
                item.SubItems.Add(da(3).ToString())
                item.SubItems.Add(da(6).ToString())
                item.SubItems.Add(da(7).ToString())

                Dim str As String = da(8).ToString()
                Dim floatValue As Single = ConvertStringToFloat(str)

                Dim amount As Decimal = floatValue
                Dim formattedAmount As String = FormatMoney(amount)

                item.SubItems.Add("₱ " + formattedAmount)
                item.SubItems.Add(da(11).ToString())
                item.SubItems.Add(da(5).ToString())
                item.SubItems.Add(da(9).ToString())
                item.SubItems.Add(da(10).ToString())
                item.SubItems.Add(da(16).ToString())
                LvProducts.Items.Add(item)
            End If
        End While

        da.Close()
        conn1.Close()

        ' LvProducts.ListViewItemSorter = New ListvViewItemComparer()
        LvProducts.Sort()

        colordata()
    End Sub

    Private Sub BtnProductsMarkAll_Click(sender As Object, e As EventArgs) Handles BtnProductsMarkAll.Click
        For Each item As ListViewItem In LvProducts.Items
            item.Checked = True
        Next
    End Sub

    Private Sub BtnProductsUnmarkAll_Click(sender As Object, e As EventArgs) Handles BtnProductsUnmarkAll.Click
        For Each item As ListViewItem In LvProducts.Items
            item.Checked = False
        Next
    End Sub

    Private Sub BtnFormInventorySearch_Click(sender As Object, e As EventArgs)
        conn1.Open()


        Dim cmd As New SqlCommand("SELECT * FROM products WHERE name = @ItemName", conn1)
        cmd.Parameters.AddWithValue("@ItemName", TbProductSearch.Text)

        Dim da As SqlDataReader = cmd.ExecuteReader()
        LvProducts.Items.Clear()
        Dim uniqueInvoices As New HashSet(Of String)()

        While da.Read()
            Dim invoiceNumber As String = da(1).ToString()

            If Not uniqueInvoices.Contains(invoiceNumber) Then
                uniqueInvoices.Add(invoiceNumber)

                Dim item As New ListViewItem(invoiceNumber)
                item.SubItems.Add(da(4).ToString())
                item.SubItems.Add(da(2).ToString())
                item.SubItems.Add(da(13).ToString())
                item.SubItems.Add(da(3).ToString())
                item.SubItems.Add(da(6).ToString())
                item.SubItems.Add(da(7).ToString())

                Dim str As String = da(8).ToString()
                Dim floatValue As Single = ConvertStringToFloat(str)

                Dim amount As Decimal = floatValue
                Dim formattedAmount As String = FormatMoney(amount)

                item.SubItems.Add("₱ " + formattedAmount)
                item.SubItems.Add(da(11).ToString())
                item.SubItems.Add(da(5).ToString())
                item.SubItems.Add(da(9).ToString())
                item.SubItems.Add(da(10).ToString())
                item.SubItems.Add(da(16).ToString())
                LvProducts.Items.Add(item)
            End If
        End While

        da.Close()
        conn1.Close()

        ' LvProducts.ListViewItemSorter = New ListvViewItemComparer()
        LvProducts.Sort()

        colordata()

    End Sub

    Private Sub BtnFormInventoryRefresh_Click(sender As Object, e As EventArgs) Handles BtnFormInventoryRefresh.Click
        RefreshUI()
    End Sub

    Public Sub RefreshUI()
        Try
            TbProductSearch.Clear()
            CbInventoryCats.Text = ""
            listProducts = GetProducts()
            SearchListView(False, False, Nothing)
            PopulateCbCategories()
            LvProducts.Columns(7).Text = "Price"
            LvProducts.ListViewItemSorter = New ListViewColumnComparer(3) ' Replace "2" with the index of the column you want to sort
            ' Call the Sort method to trigger the sorting
            LvProducts.Sort()
            colordata()
            Me.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BtnProductsDeleteMarked_Click(sender As Object, e As EventArgs) Handles BtnProductsDeleteMarked.Click
        Dim response As Integer
        response = MsgBox("Are you sure you want to archived?", vbYesNo, "Confirm")
        If response = vbYes Then
            For Each i As ListViewItem In LvProducts.CheckedItems
                If dbHandler.SetAvailableProduct(i.SubItems(0).Text, False) Then
                    LvProducts.Items.Remove(i)
                    FormDashboard.RefreshUI()
                    FormDeletedProducts.RefreshUI()
                End If
            Next
        End If
    End Sub
    Private Sub LvProducts_ItemActivate(sender As Object, e As EventArgs)
        Dim selectedItem As ListViewItem = LvProducts.SelectedItems(0)
        selectedProduct = CType(selectedItem.Tag, Product)
    End Sub

    Private Sub LvProducts_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LvProducts.MouseDoubleClick
        FormItemUpdate.ShowDialog()
    End Sub

    Private Sub LvProducts_MouseClick(sender As Object, e As MouseEventArgs) Handles LvProducts.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim selectedItem As ListViewItem = LvProducts.SelectedItems(0)
            selectedProduct = CType(selectedItem.Tag, Product)
            Dim formDialogUpdateOrStockInOrOut As FormDialogStockinOrStockOut
            formDialogUpdateOrStockInOrOut = New FormDialogStockinOrStockOut(selectedProduct)
            formDialogUpdateOrStockInOrOut.ShowDialog()
        End If
    End Sub

    Public Sub colordata()
        Dim yellowColor As Color = Color.FromArgb(255, 205, 75) ' RGB values for #   E9B824
        Dim daysBeforeExpiration As Integer = 3 ' Number of days before expiration to consider as "past few days"
        For Each item As ListViewItem In LvProducts.Items
            If item.SubItems.Count >= 11 Then
                Dim itemstock As Integer
                Dim itemcritstock As Integer
                Dim expirationDate As DateTime

                If Integer.TryParse(item.SubItems(8).Text.Trim(), itemstock) AndAlso
               Integer.TryParse(item.SubItems(11).Text.Trim(), itemcritstock) AndAlso
               DateTime.TryParse(item.SubItems(10).Text, expirationDate) Then
                    If itemstock <= 0 Then
                        item.ForeColor = Color.Red
                    ElseIf itemstock <= itemcritstock Then
                        item.ForeColor = yellowColor
                    ElseIf expirationDate <= DateTime.Now.AddDays(daysBeforeExpiration).Date Then
                        item.ForeColor = Color.Orange
                    End If
                End If
            End If
        Next

        For Each item As ListViewItem In LvProducts.Items
            If item.SubItems.Count >= 11 Then
                Dim itemstock As Integer
                Dim itemcritstock As Integer
                Dim expirationDate As DateTime

                If Integer.TryParse(item.SubItems(8).Text.Trim(), itemstock) AndAlso
               Integer.TryParse(item.SubItems(11).Text.Trim(), itemcritstock) Then
                    If itemstock <= 0 Then
                        item.ForeColor = Color.Red
                    ElseIf itemstock <= itemcritstock Then
                        item.ForeColor = yellowColor
                    End If
                End If
            End If
        Next

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
            Dim inventorylist As New Paragraph()
            Dim inventorylist1 As New Paragraph()
            Dim inventorylist2 As New Paragraph()
            Dim imagePath As String = "C:\Users\jobel\OneDrive\Desktop\6-24-2023\POS2.3\POS2\Resources\POSLOGO.PNG"


            If File.Exists(imagePath) Then
                Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imagePath)
                image.Alignment = iTextSharp.text.Image.ALIGN_CENTER ' Center-align the image
                image.ScalePercent(30) ' Adjust the scale of the image (50% in this case)
                doc.Add(image)
            End If

            Dim font As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)

            ' Create a new paragraph for the "INVENTORY LIST" text

            Dim font1 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            inventorylist1.Font = font
            inventorylist1.Alignment = Element.ALIGN_CENTER ' Center-align the "INVENTORY LIST" text
            inventorylist1.Add("Salcedo II, Noveleta, Cavite")
            ' Add the "INVENTORY LIST" text to the document
            doc.Add(inventorylist1)

            ' Create a new paragraph for the "inventorylist" text

            Dim font2 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            inventorylist2.Font = font
            inventorylist2.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM SALES REPORTS" text
            inventorylist2.Add("615-0798-321")
            ' Add the "inventorylist" text to the document
            doc.Add(inventorylist2)

            ' Create a new paragraph for the date text
            Dim dateParagraph As New Paragraph()
            Dim smallFont As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)
            dateParagraph.Font = smallFont
            dateParagraph.Alignment = Element.ALIGN_CENTER ' Center-align the date text
            dateParagraph.Add("Date: " & DateTime.Now.ToString("dd MMMM yyyy"))
            ' Add the date text to the document
            doc.Add(dateParagraph)

            ' Create a new paragraph for the "ITEM SALES REPORTS" text


            inventorylist.Font = font
            inventorylist.Alignment = Element.ALIGN_CENTER ' Center-align the "ITEM SALES REPORTS" text
            inventorylist.Add("INVENTORY LIST")
            ' Add the "ITEM SALES REPORTS" text to the document
            doc.Add(inventorylist)

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

    Private Sub BtnFormInvPrint_Click_1(sender As Object, e As EventArgs) Handles BtnFormInvPrint.Click
        FormPrintPreview.printType = "inventory"
        Try
            FormPrintPreview.Show()
        Catch

        End Try
        'PrintToPdf(LvProducts, "HCH_PRODUCTS")
    End Sub

    Private Sub TbProductSearch_TextChanged(sender As Object, e As EventArgs) Handles TbProductSearch.TextChanged
        If TbProductSearch.Text.Length > 0 Then
            conn1.Close()
            conn1.Open()
            Dim cmd As New SqlCommand("SELECT * FROM products WHERE name LIKE CONCAT('%', @name, '%') AND available = 'true'", conn1)
            cmd.Parameters.Add("name", TbProductSearch.Text)
            Dim da As SqlDataReader = cmd.ExecuteReader
            Dim uniqueInvoices As New HashSet(Of String)()
            LvProducts.Items.Clear()
            Do While da.Read = True
                Dim invoiceNumber As String = da(1).ToString()

                If Not uniqueInvoices.Contains(invoiceNumber) Then
                    uniqueInvoices.Add(invoiceNumber)

                    Dim item As New ListViewItem(invoiceNumber)
                    item.SubItems.Add(da(4).ToString())
                    item.SubItems.Add(da(2).ToString())
                    item.SubItems.Add(da(13).ToString())
                    item.SubItems.Add(da(3).ToString())
                    item.SubItems.Add(da(6).ToString())
                    item.SubItems.Add(da(7).ToString())

                    Dim str As String = da(8).ToString()
                    Dim floatValue As Single = ConvertStringToFloat(str)

                    Dim amount As Decimal = floatValue
                    Dim formattedAmount As String = FormatMoney(amount)

                    item.SubItems.Add("₱ " + formattedAmount)
                    item.SubItems.Add(da(11).ToString())
                    item.SubItems.Add(da(5).ToString())
                    item.SubItems.Add(da(9).ToString())
                    item.SubItems.Add(da(10).ToString())
                    item.SubItems.Add(da(16).ToString())
                    LvProducts.Items.Add(item)
                End If
            Loop
            colordata()
            conn1.Close()
        Else
            RefreshUI()
        End If
    End Sub

    Private Sub LvProducts_Click(sender As Object, e As EventArgs) Handles LvProducts.Click
        ToolTip1.SetToolTip(LvProducts, "")
        Dim listView As ListView = CType(sender, ListView)
        Dim mousePosition As Point = listView.PointToClient(Control.MousePosition)
        Dim item As ListViewItem = listView.GetItemAt(mousePosition.X, mousePosition.Y)

        If item IsNot Nothing Then
            ToolTip1.SetToolTip(listView, item.SubItems(5).Text) ' Set the tooltip text here
        Else
            ToolTip1.SetToolTip(listView, "") ' Hide the tooltip if no item is under the mouse pointer
        End If
    End Sub

    Private Sub LvProducts_MouseLeave(sender As Object, e As EventArgs) Handles LvProducts.MouseLeave
        ' Reset the tooltip when the mouse leaves the ListView
    End Sub

    Private Sub LvProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvProducts.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

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