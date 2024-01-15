Imports iTextSharp.text.xml.simpleparser
Imports POS2
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class FormStockIn
    Private ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private ReadOnly product As New Product

    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"

    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString


    '   Private ReadOnly product As New Product



    ' Public Sub New(Optional dbHandler As DatabaseHandler = Nothing, Optional product As Product = Nothing)
    '  InitializeComponent()
    'Me.dbHandler = dbHandler
    'Me.product = product
    'If dbHandler IsNot Nothing AndAlso product IsNot Nothing Then
    '       PopulateCbCategories()
    '      FillAllFields(product)
    'End If
    'End Sub

    Private Sub FormUpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        checkeritemsforexpdate()
        PopulateCbCategories()
        FillAllFields(product)
    End Sub
    Private Sub checkeritemsforexpdate()
        If FormStockInventory.LvProducts.SelectedItems(0).SubItems(8).Text = "NO EXPIRATION" Then
            DtpExDate.Visible = False
            Label6.Visible = False
        Else
            DtpExDate.Visible = True
            Label6.Visible = True
        End If
    End Sub
    Public Sub FillAllFields(product As Product)
        product.Id = FormStockInventory.LvProducts.SelectedItems(0).SubItems(0).Text
        product.Name = FormStockInventory.LvProducts.SelectedItems(0).SubItems(2).Text
        product.Brand = FormStockInventory.LvProducts.SelectedItems(0).SubItems(4).Text
        product.Category = FormStockInventory.LvProducts.SelectedItems(0).SubItems(1).Text
        product.Unit = FormStockInventory.LvProducts.SelectedItems(0).SubItems(9).Text
        product.Size = (FormStockInventory.LvProducts.SelectedItems(0).SubItems(5).Text)
        product.Colors = FormStockInventory.LvProducts.SelectedItems(0).SubItems(6).Text
        product.Price = FormStockInventory.LvProducts.SelectedItems(0).SubItems(7).Text
        product.Expiration_Date = FormStockInventory.LvProducts.SelectedItems(0).SubItems(10).Text
        product.Stock = Integer.Parse(FormStockInventory.LvProducts.SelectedItems(0).SubItems(8).Text)




        TbProdName.Text = product.Name
        TbProdBrand.Text = product.Brand
        CbProdType.Text = product.Category
        CbProdUnit.Text = product.Unit
        TbProdSize.Text = product.Size
        TbProdStock.Text = product.Stock
        TbProdColor.Text = product.Colors
        TbProdPrice.Text = product.Price
    End Sub

    Public Sub PopulateCbCategories()
        CbProdType.Items.Clear()
        Dim listCategory As List(Of Category)
        listCategory = dbHandler.GetCategories()

        For Each category As Category In listCategory
            CbProdType.Items.Add(category.DisplayName)
        Next
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnSaveProduct_Click(sender As Object, e As EventArgs) Handles BtnSaveProduct.Click
        Dim prodPriceText As String = TbProdPrice.Text
        prodPriceText = prodPriceText.Replace("₱", "").Trim()
        product.Price = prodPriceText
        Dim a, b, totalstock As Double
        a = TbProdStock.Text
        b = TbProdStockIn.Text
        totalstock = a + b
        Dim tempProduct As New Product With {
            .Id = product.Id,
            .Name = TbProdName.Text,
            .Brand = TbProdBrand.Text,
            .Category = CbProdType.Text,
            .Unit = CbProdUnit.Text,
            .Size = (TbProdSize.Text),
            .Colors = TbProdColor.Text,
            .Stock = Integer.Parse(totalstock),
            .Price = prodPriceText
        }

        conn1.Open()
        Dim query As String = "INSERT INTO Logs ([Part], [Action], [Users], [Date], [Time]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
        Dim command As New SqlCommand(query, conn1)
        command.Parameters.AddWithValue("@Value1", "MALAMAN PA")
        command.Parameters.AddWithValue("@Value2", "Stockin " + TbProdName.Text + " Quantity " + TbProdStockIn.Text)
        command.Parameters.AddWithValue("@Value3", FormLogin.TbUsername.Text)
        command.Parameters.AddWithValue("@Value4", FormLogin.ToolStripStatusLabel5.Text)
        command.Parameters.AddWithValue("@Value5", FormLogin.ToolStripStatusLabel2.Text)
        command.ExecuteNonQuery()
        conn1.Close()
        If (TbProdStockIn.Text < 1) Then
            MessageBox.Show("Item quantity must be greater than or equal to one.")
        Else
            If dbHandler.UpdateProduct(tempProduct) Then
            MessageBox.Show("Item information updated.")
            FormStockInventory.RefreshUI()
            FormDashboard.RefreshUI()
                Me.Close()
            End If

        End If
    End Sub



    Private Sub TbProdPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TbProdStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdStock.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CbProdUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProdUnit.SelectedIndexChanged

    End Sub

    Private Sub TbProdStockIn_TextChanged(sender As Object, e As EventArgs) Handles TbProdStockIn.TextChanged

    End Sub

    Private Sub TbProdStockIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdStockIn.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore the input
        End If
    End Sub
End Class