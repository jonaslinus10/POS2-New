Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports Nevron.Nov.UI
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Globalization
Imports ServiceStack
Imports System.Reflection.Emit
Imports ServiceStack.OrmLite.Converters
Imports System.Security.Policy

Public Class FormPOS
    Dim dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"

    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString

    Dim listProducts As New List(Of Product)
    Dim listCartProducts As New List(Of Product)
    Public Shared _intentItemId As String
    Dim _totalCash As Double
    Dim _totalPayment As Double
    Dim _totalDiscount As Double
    Dim _totalChange As Double
    Private ReadOnly _user As User
    Dim imageholder As String
    Public gcashRef As String
    Dim PPD As New PrintPreviewDialog
    Public remainingBalance As Double
    Public finalCash As Double

    Public Sub checkTotalPrice()
        Dim totalPrice As Double = 0
        For a As Integer = 0 To LvPosOrders.Items.Count - 1



            'Dim value1 = Convert.ToInt64(LvPosOrders.Items(a).SubItems(4).Text)
            'totalPrice = totalPrice + value1
            'LblPosItemsTotalPrice.Text = "₱ " & totalPrice.ToString

            Dim value1 = LvPosOrders.Items(a).SubItems(4).Text
            Dim originalString As String = value1
            Dim newString As String = RemoveFirstTwoChars(originalString)

            Dim str As String = newString
            Dim floatValue As Single = ConvertStringToFloat(str)

            totalPrice = totalPrice + floatValue

            Dim amount As Decimal = totalPrice
            Dim formattedAmount As String = FormatMoney(amount)

            LblPosItemsTotalPrice.Text = "₱ " + formattedAmount



        Next
    End Sub
    Private Sub FormPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblDate.Text = DateTime.Now.ToString("D")
        listProducts = GetProducts()
        PopulateCbCategories()
        SearchListView(False, False, Nothing)
        lblCurrentUser.Text = UserSession.SignedInUser.Username
        If UserSession.SignedInUser.Role = "admin" Then
            BackToolStripMenuItem.Visible = True
            MenuToolStripMenuItem.Visible = False
        Else
            BackToolStripMenuItem.Visible = False
            MenuToolStripMenuItem.Visible = True
        End If
        RefreshUi()
        ResetUi()

    End Sub

    Public Function GetProducts() As List(Of Product)
        Return dbHandler.GetProducts
    End Function



    Private Sub PopulateListView(products As IEnumerable(Of Product))
        LvPosProducts.BeginUpdate()
        Try
            For Each product As Product In products
                If product.Available And product.Stock > 0 Then
                    Dim _lvItem As New ListViewItem(product.Id)
                    _lvItem.SubItems.Add(product.Category)
                    _lvItem.SubItems.Add(product.Name)
                    _lvItem.SubItems.Add(product.Classification)
                    _lvItem.SubItems.Add(product.Brand)
                    _lvItem.SubItems.Add(product.Size & " " & product.Unit)
                    _lvItem.SubItems.Add(product.Colors)
                    Dim str As String = product.Price
                    Dim floatValue As Single = ConvertStringToFloat(str)

                    Dim amount As Decimal = floatValue
                    Dim formattedAmount As String = FormatMoney(amount)

                    _lvItem.SubItems.Add("₱ " + formattedAmount)
                    _lvItem.SubItems.Add(product.Stock)
                    LvPosProducts.Items.Add(_lvItem)
                End If
            Next
        Finally
            LvPosProducts.EndUpdate()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Public Sub SearchListView(filtered As Boolean, searchByCategory As Boolean, query As String)
        LvPosProducts.Items.Clear()
        Dim filteredProducts As List(Of Product)
        If filtered Then
            If Not String.IsNullOrEmpty(query) Then
                If searchByCategory Then
                    filteredProducts = listProducts.Where(Function(s) s.Category = query).ToList()
                Else
                    filteredProducts = listProducts.Where(Function(s) s.Name.StartsWith(query, StringComparison.InvariantCultureIgnoreCase)).ToList()
                End If
                PopulateListView(filteredProducts)
            End If
        Else
            filteredProducts = GetProducts()
            PopulateListView(filteredProducts)
        End If
    End Sub
    Private Sub LvPosProducts_MouseDoubleClick(sender As Object, e As EventArgs) Handles LvPosProducts.MouseDoubleClick
        If (LvPosProducts.SelectedItems.Count > 0) Then
            _intentItemId = LvPosProducts.SelectedItems(0).SubItems(0).Text
            FormAddItemOrder.Label1.Text = LvPosProducts.SelectedItems(0).SubItems(8).Text
            FormAddItemOrder.ShowDialog()
        End If

    End Sub

    'ADD ORDER
    Public Sub AddOrder(ByVal _itemId As String, ByVal _itemQuantity As Integer)
        ' Check if the item already exists in LvPosOrders

        Dim existingItem = LvPosOrders.Items.Cast(Of ListViewItem)().FirstOrDefault(Function(item) item.Text = _itemId)

        ' If the item already exists, you can update its quantity and price
        If existingItem IsNot Nothing Then
            Dim currentQuantity = Integer.Parse(existingItem.SubItems(3).Text)
            Dim newQuantity = currentQuantity + _itemQuantity
            'If newQuantity >= LvPosProducts.SelectedItems(0).SubItems(8).Text Then
            '    MsgBox("The Item Quantity Has Been Max Out")
            '    Exit Sub
            'End If
            existingItem.SubItems(3).Text = newQuantity.ToString()
            checkTotalPrice()
            Dim product = listProducts.FirstOrDefault(Function(p) p.Id = _itemId)
            If product IsNot Nothing Then
                Dim lbProductsQTY As Integer = Convert.ToInt32(LvPosProducts.SelectedItems(0).SubItems(8).Text)
                Dim lbOrderQTY As Integer = Convert.ToInt32(FormAddItemOrder.TbItemQty.Text)
                Dim finalQTY As Integer = lbProductsQTY - lbOrderQTY
                Dim existingItem1 = LvPosProducts.Items.Cast(Of ListViewItem)().FirstOrDefault(Function(item) item.Text = _itemId)
                Dim newPrice = product.Price * newQuantity
                existingItem1.SubItems(8).Text = finalQTY
                existingItem.SubItems(4).Text = newPrice
                checkTotalPrice()
            End If
            checkTotalPrice()
        Else
            ' If the item doesn't exist, add a new item
            Dim listCartProducts = listProducts.Where(Function(s) s.Id = _itemId).ToList()
            Dim lbProductsQTY As Integer = Convert.ToInt32(LvPosProducts.SelectedItems(0).SubItems(8).Text)
            Dim lbOrderQTY As Integer = Convert.ToInt32(FormAddItemOrder.TbItemQty.Text)
            Dim finalQTY As Integer = lbProductsQTY - lbOrderQTY
            For Each product As Product In listCartProducts
                If (product.Id.Equals(_itemId)) Then
                    Dim tempPrice = product.Price * _itemQuantity
                    Dim _lvItem = New ListViewItem(product.Id)
                    _lvItem.SubItems.Add(product.Name)
                    _lvItem.SubItems.Add(product.Price)
                    _lvItem.SubItems.Add(_itemQuantity)
                    Dim str As String = tempPrice
                    Dim floatValue As Single = ConvertStringToFloat(str)

                    Dim amount As Decimal = floatValue
                    Dim formattedAmount As String = FormatMoney(amount)
                    _lvItem.SubItems.Add("₱ " + formattedAmount)
                    LvPosOrders.Items.Add(_lvItem)
                    checkTotalPrice()
                    Exit For
                End If
            Next
            checkTotalPrice()
            LvPosProducts.SelectedItems(0).SubItems(8).Text = finalQTY

        End If
    End Sub
    'CALCULATE TOTAL
    Public Function CalculateTotalUnitPrice() As Double
        Dim totalPrice As Double = 0.0

        For Each row As ListViewItem In LvPosOrders.Items
            Dim unitPrice As Double = CDbl(row.SubItems(4).Text)
            totalPrice += unitPrice
        Next
        Return totalPrice.ToString("C")
    End Function

    Private Sub BtnDeleteItem_Click(sender As Object, e As EventArgs)
        Dim response As Integer

        For Each i As ListViewItem In LvPosOrders.CheckedItems
            response = MsgBox("Are you sure you want to delete?", vbYesNo, "Confirm Delete")
            If response = vbYes Then
                LvPosOrders.Items.Remove(i)
                LblPosItemsTotalPrice.Text = "0.00"
            End If
        Next
    End Sub
    Private Sub BtnPosOrdersClear_Click(sender As Object, e As EventArgs)
        Dim response As Integer

        response = MsgBox("Are you sure you want to delete all items?", vbYesNo, "Confirm Delete")
        If response = vbYes Then
            LvPosOrders.Items.Clear()
            LblPosItemsTotalPrice.Text = "0.00"
        End If
    End Sub

    Private Sub BtnPosClearCustomerInfo_Click(sender As Object, e As EventArgs) Handles BtnPosClearCustomerInfo.Click
        ResetUi()
    End Sub

    Private Sub TbPosCustomerTotalCash_TextChanged(sender As Object, e As EventArgs) Handles TbPosCustomerTotalCash.TextChanged
        If (Not String.IsNullOrEmpty(TbPosCustomerTotalCash.Text)) Then
            If CbPosPaymentMethod.Text = "Two-Payment Method" Then
                If Convert.ToInt64(TbPosCustomerTotalCash.Text) >= CalculateTotalUnitPrice() Then
                    TbPosCustomerTotalCash.Text = CalculateTotalUnitPrice() - 1
                End If
            End If
            _totalCash = Double.Parse(TbPosCustomerTotalCash.Text)
            UpdateTotalPayment()
        Else
            TbPosCustomerTotalCash.Text = 0.00
        End If
    End Sub

    'UPDATE PAYMENT
    Private Sub UpdateTotalPayment()
        Dim strAmountPaid As String = TbPosCustomerTotalCash.Text

        Dim numFromAmountPaid As String = System.Text.RegularExpressions.Regex.Replace(strAmountPaid, "[^0-9\.]", "")
        Dim totalAmountPaid As Double = 0

        Double.TryParse(numFromAmountPaid, totalAmountPaid)
        If CbPosPaymentMethod.Text = "Two-Payment Method" Then
            _totalChange = 0
        Else
            _totalChange = CalculateChange(totalAmountPaid, CalculateTotalUnitPrice)

            If (_totalChange <= 0) Then
                TbPosChange.Text = 0.00
            Else
                TbPosChange.Text = _totalChange
            End If
        End If

        LblPosItemsTotalPrice.Text = "₱" & CalculateTotalUnitPrice().ToString

    End Sub

    Private Sub CbSortPOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPosSortProducts.SelectedIndexChanged
        SearchListView(True, True, CbPosSortProducts.Text)
    End Sub

    Public Sub PopulateCbCategories()
        CbPosSortProducts.Items.Clear()
        Dim listCategory As List(Of Category)

        listCategory = dbHandler.GetCategories()

        For Each category As Category In listCategory
            If Not CbPosSortProducts.Items.Contains(category.DisplayName) Then
                CbPosSortProducts.Items.Add(category.DisplayName)
            End If
        Next
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        finalCash = Convert.ToInt64(TbPosCustomerTotalCash.Text) + FormGcashTwoPayment.gcTWBalance
        remainingBalance = CalculateTotalUnitPrice()
        UpdateTotalPayment()
        If CbPosPaymentMethod.Text = "G-Cash" And gcashRef = Nothing Then
            FormGcashCheck.Show()
        ElseIf CbPosPaymentMethod.Text = "Two-Payment Method" And CbPosOrderType.Text = "Walk-in" And gcashRef = Nothing Then

            If Convert.ToInt64(TbPosCustomerTotalCash.Text) >= CalculateTotalUnitPrice() Then
                TbPosCustomerTotalCash.Text = CalculateTotalUnitPrice() - 1
            End If

            remainingBalance = Convert.ToInt64(TbPosCustomerTotalCash.Text) - remainingBalance
            FormGcashTwoPayment.gcTWBalance = remainingBalance
            FormGcashTwoPayment.Show()
        Else
            Dim result As DialogResult = MessageBox.Show("Confirm current order and proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If CustomerInfoValid() Then
                If result = DialogResult.Yes Then
                    PPD.Document = PrintReceiptDocument
                    PPD.WindowState = FormWindowState.Maximized
                    PPD.ShowDialog()
                    gcashRef = ""
                    finalCash = 0
                ElseIf result = DialogResult.No Then
                    gcashRef = ""
                    finalCash = 0
                End If
            End If
        End If
    End Sub

    Private Function CustomerInfoValid() As Boolean


        If IsDelivered() Then
            If String.IsNullOrEmpty(TbPosCustomerAddress.Text) Then
                MessageBox.Show("Customer address must be filled in.")
                Return False
            End If
            If String.IsNullOrEmpty(TbPosCustomerContactNo.Text) Then
                MessageBox.Show("Customer contact number must be filled in.")
                Return False
            End If
            If String.IsNullOrEmpty(TbPosCustomerName.Text) Then
                MessageBox.Show("Customer name must be filled in.")
                Return False
            End If
        End If

        If finalCash <= 0 Then
            MessageBox.Show("Total cash can not be less than or equal to zero.")
            Return False
        End If
        If finalCash < CalculateTotalUnitPrice() Then

            MsgBox("Payment is smaller than the total price of the items.")
            Return False

        End If
        If LvPosOrders.Items.Count = 0 Then
            MessageBox.Show("Select Items to order first.")
            Return False
        End If
        If String.IsNullOrEmpty(CbPosOrderType.Text) Then
            MessageBox.Show("Select order type.")
            Return False
        End If
        If String.IsNullOrEmpty(CbPosPaymentMethod.Text) Then
            MessageBox.Show("Select payment method.")
            Return False
        End If
        If String.IsNullOrEmpty(TbPosCustomerTotalCash.Text) Then
            Return False
        End If

        Return True
    End Function

    Private Function ProductAvailable(name As String) As Boolean
        If dbHandler.GetAvailableStock(name) > 1 Then
            Return True
        Else
            MessageBox.Show(name & " is low on stock.")
            Return False
        End If
    End Function

    Private Sub PrintReceiptDocument_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintReceiptDocument.BeginPrint
        Dim pagesetup As New PageSettings With {
            .PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        }
        PrintReceiptDocument.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PrintReceiptDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintReceiptDocument.PrintPage
        Dim tempInvoiceNumber As Integer = GenerateId()

        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PrintReceiptDocument.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PrintReceiptDocument.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PrintReceiptDocument.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim height2 As Integer
        height2 = 145 + Height

        Dim line As String

        Dim currentLine As Integer
        currentLine = 30

        line = "****************************************************************"

        e.Graphics.DrawString("Honest City Hardware", f10, Brushes.Black, centermargin, currentLine + 10, center)
        currentLine += 10
        e.Graphics.DrawString("Salcedo II Noveleta, Cavite", f10, Brushes.Black, centermargin, currentLine + 10, center)
        currentLine += 10
        e.Graphics.DrawString("Contact: 09987654321", f10, Brushes.Black, centermargin, currentLine + 10, center)
        currentLine += 10
        e.Graphics.DrawString("Sales Invoice", f10, Brushes.Black, centermargin, currentLine + 10, center)
        currentLine += 20
        e.Graphics.DrawString("  Invoice No.", f8, Brushes.Black, 0, currentLine + 10)
        e.Graphics.DrawString(":", f8, Brushes.Black, 80, currentLine + 10)
        e.Graphics.DrawString(tempInvoiceNumber, f8, Brushes.Black, 90, currentLine + 10)
        currentLine += 10
        e.Graphics.DrawString("  Cashier", f8, Brushes.Black, 0, currentLine + 10)
        e.Graphics.DrawString(": ", f8, Brushes.Black, 80, currentLine + 10)
        e.Graphics.DrawString(UserSession.SignedInUser.Username, f8, Brushes.Black, 90, currentLine + 10)
        currentLine += 10
        Dim currentDate As DateTime = DateTime.Now
        Dim dateString As String = currentDate.ToString("MM-dd-yyyy")
        Dim timeString As String = currentDate.ToString("hh:mm:ss tt")

        e.Graphics.DrawString("  Release Date", f8, Brushes.Black, 0, currentLine + 10)
        e.Graphics.DrawString(": ", f8, Brushes.Black, 80, currentLine + 10)
        e.Graphics.DrawString(dateString & " " & timeString, f8, Brushes.Black, 90, currentLine + 10)
        currentLine += 20
        e.Graphics.DrawString("  Recipient", f8, Brushes.Black, 0, currentLine + 10)
        e.Graphics.DrawString(":", f8, Brushes.Black, 80, currentLine + 10)
        e.Graphics.DrawString(TbPosCustomerName.Text, f8, Brushes.Black, 90, currentLine + 10)
        currentLine += 10
        e.Graphics.DrawString("  Address", f8, Brushes.Black, 0, currentLine + 10)
        e.Graphics.DrawString(":", f8, Brushes.Black, 80, currentLine + 10)
        If IsDelivered() Then
            e.Graphics.DrawString(TbPosCustomerAddress.Text, f8, Brushes.Black, 90, currentLine + 10)
        Else
            e.Graphics.DrawString("", f8, Brushes.Black, 90, currentLine + 10)
        End If
        currentLine += 10
        e.Graphics.DrawString("  Contact", f8, Brushes.Black, 0, currentLine + 10)
        e.Graphics.DrawString(":", f8, Brushes.Black, 80, currentLine + 10)
        If IsDelivered() Then
            e.Graphics.DrawString(TbPosCustomerContactNo.Text, f8, Brushes.Black, 90, currentLine + 10)
        Else
            e.Graphics.DrawString("", f8, Brushes.Black, 90, currentLine + 10)
        End If
        currentLine += 20
        e.Graphics.DrawString("  Order Type", f8, Brushes.Black, 0, currentLine + 10)
        e.Graphics.DrawString(":", f8, Brushes.Black, 100, currentLine + 10)
        e.Graphics.DrawString(CbPosOrderType.Text, f8, Brushes.Black, 120, currentLine + 10)
        currentLine += 10
        e.Graphics.DrawString("  Method of Payment", f8, Brushes.Black, 0, currentLine + 10)
        e.Graphics.DrawString(":", f8, Brushes.Black, 100, currentLine + 10)
        e.Graphics.DrawString(CbPosPaymentMethod.Text, f8, Brushes.Black, 120, currentLine + 10)
        If CbPosPaymentMethod.Text = "G-Cash" Then
            currentLine += 10
            e.Graphics.DrawString("  Gcash Refrence No.", f8, Brushes.Black, 0, currentLine + 10)
            e.Graphics.DrawString(":", f8, Brushes.Black, 100, currentLine + 10)
            e.Graphics.DrawString(gcashRef, f8, Brushes.Black, 120, currentLine + 10)
        End If
        currentLine += 20
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 0, currentLine + 10)
        e.Graphics.DrawString("Item", f8, Brushes.Black, 25, currentLine + 10)
        e.Graphics.DrawString("Unit Price", f8, Brushes.Black, 180, currentLine + 10, right)
        e.Graphics.DrawString("Total Price", f8, Brushes.Black, rightmargin, currentLine + 10, right)
        currentLine += 10
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, currentLine + 10)
        currentLine += 10

        For Each item As ListViewItem In LvPosOrders.Items
            Dim totalPerItem As Integer
            e.Graphics.DrawString(item.SubItems(3).Text, f8, Brushes.Black, 0, currentLine + 10)
            e.Graphics.DrawString(item.SubItems(1).Text, f8, Brushes.Black, 25, currentLine + 10)


            e.Graphics.DrawString("₱ " & item.SubItems(2).Text, f8, Brushes.Black, 180, currentLine + 10, right)
            e.Graphics.DrawString("₱ " & formattingSomething(item.SubItems(4).Text), f8, Brushes.Black, rightmargin, currentLine + 10, right)
            currentLine += 10
        Next
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, currentLine + 10)
        currentLine += 10
        e.Graphics.DrawString("Payment: " & "₱ " & finalCash, f8, Brushes.Black, rightmargin, currentLine + 10, right)
        currentLine += 10
        e.Graphics.DrawString("Total Payment: " & "₱ " & CalculateTotalUnitPrice(), f8, Brushes.Black, rightmargin, currentLine + 10, right)
        'If ChkBDiscounted.Checked Then
        '    currentLine += 10
        '    Dim selectedText As String = ComboBox1.SelectedItem.ToString()
        '    e.Graphics.DrawString("Discounted: " & selectedText, f8, Brushes.Black, rightmargin, currentLine + 10, right)
        'End If


        currentLine += 10
        e.Graphics.DrawString("Total Change: " & "₱" & _totalChange, f8, Brushes.Black, rightmargin, currentLine + 10, right)

        currentLine += 50
        e.Graphics.DrawString("~ Thanks for shopping ~", f10, Brushes.Black, centermargin, currentLine + 10, center)
        currentLine += 10
        e.Graphics.DrawString("~ Honest City Hardware ~", f10, Brushes.Black, centermargin, currentLine + 10, center)


        Dim bitmap As New Bitmap(e.PageBounds.Width, e.PageBounds.Height)

        ' Draw the content onto the bitmap
        Dim graphics As Graphics = Graphics.FromImage(bitmap)
        graphics.Clear(Color.White) ' Set the background color
        graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        graphics.DrawString("Honest City Hardware", f10, Brushes.Black, centermargin, currentLine + 10, center)
        ' ...


        ConfirmOrder(tempInvoiceNumber)
        ' Dispose of the bitmap and graphics objects
        bitmap.Dispose()
        graphics.Dispose()



    End Sub

    Private Sub ConfirmOrder(tempInvoice As Integer)
        Dim NowDateString As String = Date.Now.ToString("MM-dd-yyyy")
        Dim DeliveryDateString As String = DateTimePickerDeliveryDate.Value.ToString("MM-dd-yyyy")
        'NEEDS REVISION
        For Each item As ListViewItem In LvPosOrders.Items
            Dim totalPrice As Double = Double.Parse(item.SubItems(2).Text) * Double.Parse(item.SubItems(3).Text)
            Dim customerName As String = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TbPosCustomerName.Text)
            Dim customerAddress As String = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TbPosCustomerAddress.Text)

            Dim sale As New Sale With {
                .Invoice_Number = tempInvoice,
                .Product_Id = item.SubItems(0).Text,
                .Product_Name = item.SubItems(1).Text,
                .Quantity = item.SubItems(3).Text,
                .Price = item.SubItems(2).Text,
                .Total_Price = totalPrice,
                .Total_Payment = finalCash,
                .Customer_Name = customerName,
                .Customer_Address = customerAddress,
                .Customer_Contact = TbPosCustomerContactNo.Text,
                .Release_Date = NowDateString,
                .Release_Time = TimeString,
                .Payment_Method = CbPosPaymentMethod.Text,
                .Order_Type = CbPosOrderType.Text,
                .Returned = 0,
                .Delivered = IsDelivered(),
                .Pending = True,
                .DeliveryDate = DeliveryDateString,
                .Reciept = imageholder
            }
            dbHandler.AddSale(sale)
            dbHandler.DecreaseProductStock(sale.Product_Id, Integer.Parse(item.SubItems(3).Text))
        Next
        ResetUi()
        RefreshUi()
        FormDashboard.RefreshUI()
        FormStockInventory.RefreshUI()
        FormDelivery.RefreshUI()
        FormSales.RefreshUI()

    End Sub

    Public Sub ResetUi()
        Timer1.Start()
        LvPosOrders.Items.Clear()
        LblPosItemsTotalPrice.Text = 0.00
        TbPosCustomerName.Clear()
        TbPosCustomerContactNo.Clear()
        TbPosCustomerAddress.Clear()
        CbPosOrderType.SelectedIndex = 1
        CbPosPaymentMethod.SelectedIndex = 0
        TbPosCustomerName.Clear()
        TbPosCustomerAddress.Clear()
        TbPosCustomerContactNo.Clear()
        TbPosCustomerTotalCash.Text = 0.00
        TbPosChange.Text = 0.00
    End Sub

    Private Function IsDelivered() As Boolean
        If CbPosOrderType.SelectedIndex = 0 OrElse CbPosOrderType.SelectedItem.ToString().ToLower = "Deliver" Then
            DateTimePickerDeliveryDate.Enabled = True
            TbPosCustomerName.Enabled = True
            Return True
        Else
            DateTimePickerDeliveryDate.Enabled = False
            TbPosCustomerName.Enabled = False
            Return False
        End If
    End Function

    Public Function GenerateId() As Integer
        Dim Min As Integer = 100000000
        Dim Max As Integer = 999999999
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub TbPosCustomerName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPosCustomerName.KeyPress
        If (e.KeyChar = Chr(13)) Then
            TbPosCustomerAddress.Select()
        End If
    End Sub

    Private Sub TbPosCustomerAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPosCustomerAddress.KeyPress
        If (e.KeyChar = Chr(13)) Then
            TbPosCustomerContactNo.Select()
        End If
    End Sub

    Private Sub TbPosCustomerContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPosCustomerContactNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            If (e.KeyChar = Chr(13)) Then
                TbPosCustomerTotalCash.Select()
            End If
        End If
    End Sub

    Private Sub TbPosCustomerTotalCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPosCustomerTotalCash.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            If (e.KeyChar = Chr(13)) Then

            End If
        End If
    End Sub

    'Private Sub ChkBDiscounted_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        If (ChkBDiscounted.Checked) Then

    '        End If
    '    End If
    'End Sub

    'CALCULATE CHANGE
    Function CalculateChange(ByVal cash As Double, ByVal total As Double) As Double
        Dim change As Double = cash - total
        Dim holderforcombobox1 As String

        Dim discountholder As String = "0." + holderforcombobox1
        Dim discount As Double = total * discountholder
        Dim finalResult As Double = change + discount
        Return change

    End Function

    Private Sub Tsxtbox_Search_TextChanged(sender As Object, e As EventArgs) Handles TbPosSearchProduct.TextChanged
        Dim query = TbPosSearchProduct.Text
        If query = Nothing Then
            SearchListView(False, False, Nothing)
        Else
            SearchListView(True, False, TbPosSearchProduct.Text)
        End If
    End Sub

    Private Sub TbPosCustomerContactNo_TextChanged(sender As Object, e As EventArgs) Handles TbPosCustomerContactNo.TextChanged
        If String.IsNullOrEmpty(TbPosCustomerContactNo.Text) Then
            TbPosCustomerContactNo.Text = "09"
        End If
    End Sub

    Private Sub BtnReturnProduct_Click(sender As Object, e As EventArgs) Handles BtnReturnProduct.Click
        FormAddReturnProduct.ShowDialog()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        RefreshUi()
    End Sub

    Public Sub RefreshUi()
        TbPosSearchProduct.Clear()
        PopulateCbCategories()
        listProducts = GetProducts()
        SearchListView(False, False, Nothing)
        'For Each lvi In LvPosProducts.Items
        '    lvi.Font = New Font(New FontFamily("Arial"), 12, FontStyle.Bold)
        'Next
    End Sub

    Private Sub TbPosCustomerDiscount_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CbPosOrderType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPosOrderType.SelectedIndexChanged
        If CbPosOrderType.Text = "Walk-in" Then
            TbPosCustomerAddress.Clear()
            TbPosCustomerAddress.Enabled = False
            TbPosCustomerContactNo.Clear()
            TbPosCustomerContactNo.Enabled = False
            DateTimePickerDeliveryDate.Enabled = False
            TbPosCustomerName.Enabled = False
            If Not CbPosPaymentMethod.Items.Contains("Cash On Hand") Then
                CbPosPaymentMethod.Items.Add("Cash On Hand")
            End If
            If Not CbPosPaymentMethod.Items.Contains("Two-Payment Method") Then
                CbPosPaymentMethod.Items.Add("Two-Payment Method")
            End If
            CbPosPaymentMethod.Items.Remove("Cash On Delivery")

        Else
            CbPosPaymentMethod.Items.Remove("Cash On Hand")
            CbPosPaymentMethod.Items.Remove("Two-Payment Method")
            If Not CbPosPaymentMethod.Items.Contains("Cash On Delivery") Then
                CbPosPaymentMethod.Items.Add("Cash On Delivery")
            End If
            TbPosCustomerName.Enabled = True
            TbPosCustomerAddress.Enabled = True
            TbPosCustomerContactNo.Enabled = True
            DateTimePickerDeliveryDate.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FormMain.BtnDashBoard.PerformClick()
        FormMain.Show()

    End Sub

    Private Sub DateTimePickerDeliveryDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerDeliveryDate.ValueChanged
        If CbPosOrderType.Text = "Walk-in" Then
            DateTimePickerDeliveryDate.Enabled = False
        Else
            DateTimePickerDeliveryDate.Enabled = True
        End If
    End Sub

    Private Sub CbPosOrderType_Click(sender As Object, e As EventArgs) Handles CbPosOrderType.Click
        If CbPosOrderType.Text = "Walk-in" Then
            TbPosCustomerAddress.Clear()
            TbPosCustomerAddress.Enabled = False
            TbPosCustomerContactNo.Clear()
            TbPosCustomerContactNo.Enabled = False
            DateTimePickerDeliveryDate.Enabled = False
        Else
            TbPosCustomerAddress.Enabled = True
            TbPosCustomerContactNo.Enabled = True
            DateTimePickerDeliveryDate.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = FormDialogExit.ShowDialog
        If result = DialogResult.Yes Then
            UserSession.SignedInUser = Nothing
            FormLogin.Show()
            Me.Close()

            conn1.Open()

            ' SQL query to insert data into the table
            Dim query As String = "INSERT INTO Logs ([Part], [Action], [Users], [Date], [Time]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"

            ' Create a SqlCommand object
            Dim command As New SqlCommand(query, conn1)

            ' Bind parameters with textbox values
            command.Parameters.AddWithValue("@Value1", "MALAMAN PA")
            command.Parameters.AddWithValue("@Value2", "Login")
            command.Parameters.AddWithValue("@Value3", FormLogin.TbUsername.Text)
            command.Parameters.AddWithValue("@Value4", FormLogin.ToolStripStatusLabel5.Text)
            command.Parameters.AddWithValue("@Value5", FormLogin.ToolStripStatusLabel2.Text)
            command.ExecuteNonQuery()


            conn1.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FormUpdateAccountPOS.TbUAUsername.Text = lblCurrentUser.Text
        FormUpdateAccountPOS.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        UpdateTotalPayment()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblTime_Click(sender As Object, e As EventArgs) Handles LblTime.Click

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub LvPosOrders_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        FormUpdateAccountPOS.TbUAUsername.Text = lblCurrentUser.Text
        FormUpdateAccountPOS.ShowDialog()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim result As DialogResult = FormDialogExit.ShowDialog
        If result = DialogResult.Yes Then
            UserSession.SignedInUser = Nothing
            FormLogin.Show()
            Me.Close()

            conn1.Open()

            ' SQL query to insert data into the table
            Dim query As String = "INSERT INTO Logs ([Part], [Action], [Users], [Date], [Time]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"

            ' Create a SqlCommand object
            Dim command As New SqlCommand(query, conn1)

            ' Bind parameters with textbox values
            command.Parameters.AddWithValue("@Value1", "MALAMAN PA")
            command.Parameters.AddWithValue("@Value2", "Login")
            command.Parameters.AddWithValue("@Value3", FormLogin.TbUsername.Text)
            command.Parameters.AddWithValue("@Value4", FormLogin.ToolStripStatusLabel5.Text)
            command.Parameters.AddWithValue("@Value5", FormLogin.ToolStripStatusLabel2.Text)
            command.ExecuteNonQuery()


            conn1.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        FormMain.BtnDashBoard.PerformClick()
        FormMain.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnPosOrdersClear_Click_1(sender As Object, e As EventArgs) Handles BtnPosOrdersClear.Click
        Dim response As Integer

        response = MsgBox("Are you sure you want to delete all items?", vbYesNo, "Confirm Delete")
        If response = vbYes Then
            LvPosOrders.Items.Clear()
            LblPosItemsTotalPrice.Text = "0.00"
            RefreshUi()
            ResetUi()
            checkTotalPrice()
        End If
    End Sub

    Private Sub BtnDeleteItem_Click_1(sender As Object, e As EventArgs) Handles BtnDeleteItem.Click
        Dim response As Integer

        If LvPosOrders.CheckBoxes = True Then
            ' Confirm deletion once for all selected items
            response = MsgBox("Are you sure you want to delete selected items?", vbYesNo, "Confirm Delete")
            If response = vbYes Then
                ' Iterate through checked items
                For Each i As ListViewItem In LvPosOrders.Items
                    ' Find items in both LvPosOrders and LvPosProducts
                    Dim existingItem1 = LvPosOrders.Items.Cast(Of ListViewItem)().FirstOrDefault(Function(item) item.Text = i.SubItems(0).Text)
                    Dim existingItem = LvPosProducts.Items.Cast(Of ListViewItem)().FirstOrDefault(Function(item) item.Text = i.SubItems(0).Text)

                    If existingItem IsNot Nothing Then
                        ' Database operations

                        If i.Checked = True Then
                            Dim query As String = "SELECT stock FROM products WHERE id = @id"
                            Using connection As New SqlConnection(dbHandler.getConnectionString)
                                connection.Open()
                                Dim cmd As SqlCommand = New SqlCommand(query, connection)
                                cmd.Parameters.AddWithValue("@id", existingItem1.SubItems(0).Text)
                                Dim dbStock As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                                existingItem.SubItems(8).Text = dbStock.ToString()
                                LvPosOrders.Items.RemoveAt(i.Index)
                                LblPosItemsTotalPrice.Text = "0.00"
                            End Using
                        End If

                    End If
                Next
                checkTotalPrice()
            End If
        Else
            MsgBox("Select an Item", MsgBoxStyle.Critical, "Inventory")
        End If



        'Dim response As Integer
        'If LvPosOrders.CheckBoxes = True Then
        '    For Each i As ListViewItem In LvPosOrders.CheckedItems
        '        response = MsgBox("Are you sure you want to delete?", vbYesNo, "Confirm Delete")
        '        If response = vbYes Then
        '            Dim existingItem1 = LvPosOrders.Items.Cast(Of ListViewItem)().FirstOrDefault(Function(item) item.Text = i.SubItems(0).Text)
        '            Dim existingItem = LvPosProducts.Items.Cast(Of ListViewItem)().FirstOrDefault(Function(item) item.Text = i.SubItems(0).Text)

        '            Dim query As String = "SELECT stock FROM products WHERE id = @id"
        '            Using connection As New SqlConnection(dbHandler.getConnectionString)
        '                connection.Open()
        '                Dim cmd As SqlCommand = New SqlCommand(query, connection)
        '                cmd.Parameters.AddWithValue("@id", existingItem1.SubItems(0).Text)
        '                Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
        '                Dim dt As DataTable = New DataTable
        '                adapter.Fill(dt)
        '                Try
        '                    Dim dbStock As Integer = Convert.ToInt32(dt.Rows(0).Item(0))
        '                    existingItem.SubItems(8).Text = dbStock
        '                    LvPosOrders.Items.Remove(i)
        '                    LblPosItemsTotalPrice.Text = "0.00"
        '                Catch ex As Exception
        '                    Throw ex
        '                End Try

        '                cmd.Dispose()
        '                connection.Close()
        '            End Using
        '        End If
        '    Next
        'Else
        '    MsgBox("Select an Item", MsgBoxStyle.Critical, "Inventory")
        'End If
        'ResetUi()
        'checkTotalPrice()
    End Sub
    Private Sub LvPosOrders_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LvPosOrders.MouseDoubleClick

    End Sub

    Private Sub LvPosOrders_MouseDoubleClick(sender As Object, e As EventArgs) Handles LvPosOrders.MouseDoubleClick
        If (LvPosOrders.SelectedItems.Count > 0) Then
            _intentItemId = LvPosOrders.SelectedItems(0).SubItems(0).Text
            FormEditItemOrder.Label1.Text = LvPosOrders.SelectedItems(0).SubItems(3).Text
            FormEditItemOrder.ShowDialog()
        End If
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub LvPosOrders_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles LvPosOrders.SelectedIndexChanged

    End Sub

    Private Sub CbPosPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPosPaymentMethod.SelectedIndexChanged
        readOnlyGcashValue()
    End Sub

    Public Sub readOnlyGcashValue()
        Try
            If CbPosPaymentMethod.Text IsNot Nothing Then
                If CbPosPaymentMethod.Text = "G-Cash" Then
                    TbPosCustomerTotalCash.ReadOnly = True
                    TbPosCustomerTotalCash.Text = Convert.ToInt64(CalculateTotalUnitPrice().ToString)
                Else
                    TbPosCustomerTotalCash.ReadOnly = False
                    TbPosCustomerTotalCash.Text = Convert.ToInt64("0.00")
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub LvPosProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvPosProducts.SelectedIndexChanged

    End Sub



    Public Function FormatMoney(ByVal amount As Double) As String
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
    Public Function RemoveFirstTwoChars(ByVal str As String) As String
        If str.Length > 2 Then
            Return str.Remove(0, 2)
        Else
            Return ""
        End If
    End Function

    Public Function formattingSomething(yawa As String) As String
        Dim value1 = yawa
        Dim originalString As String = value1
        Dim newString As String = RemoveFirstTwoChars(originalString)

        Dim str As String = newString
        Dim floatValue As Single = ConvertStringToFloat(str)

        Dim totalPerItem = floatValue

        Dim amount As Double = totalPerItem
        Dim formattedAmount As String = FormatMoney(amount)

        Return formattedAmount
    End Function

    Private Sub LblPosItemsTotalPrice_Click(sender As Object, e As EventArgs) Handles LblPosItemsTotalPrice.Click

    End Sub
End Class