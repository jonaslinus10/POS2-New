Imports OracleInternal
Imports System.Data.SqlClient

Public Class FormDeletedProducts
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Dim listProducts As New List(Of Product)

    Private Sub FormDeletedProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshUI()
    End Sub

    Public Function GetProducts() As List(Of Product)
        Return dbHandler.GetProducts
    End Function

    Public Sub PopulateCbCategories()
        CbInventoryCats.Items.Clear()
        Dim listCategory As List(Of Category)
        listCategory = dbHandler.GetCategories()

        For Each category As Category In listCategory
            CbInventoryCats.Items.Add(category.DisplayName)
        Next
    End Sub

    Private Sub PopulateListView(products As IEnumerable(Of Product))
        LvProducts.Items.Clear()
        For Each product As Product In products
            If Not product.Available Then
                Dim _lvItem As New ListViewItem(product.Id.ToString())
                _lvItem.SubItems.Add(product.Name)
                _lvItem.SubItems.Add(product.Brand)
                _lvItem.SubItems.Add(product.Category)
                _lvItem.SubItems.Add(product.Unit)
                _lvItem.SubItems.Add(product.Size)
                _lvItem.SubItems.Add(product.Colors)
                _lvItem.SubItems.Add(product.Price)
                _lvItem.SubItems.Add(product.Expiration_Date)
                _lvItem.SubItems.Add(product.Stock)
                LvProducts.Items.Add(_lvItem)
            End If
        Next
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

    Public Sub RefreshUI()
        TbProductSearch.Clear()
        CbInventoryCats.Text = ""
        listProducts = GetProducts()
        SearchListView(False, False, Nothing)
        PopulateCbCategories()
    End Sub

    Private Sub BtnFormInventoryRefresh_Click(sender As Object, e As EventArgs) Handles BtnFormInventoryRefresh.Click
        RefreshUI()
    End Sub

    Private Sub CbInventoryCats_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbInventoryCats.SelectedIndexChanged
        SearchListView(True, True, CbInventoryCats.Text.ToLower)
        TbProductSearch.Clear()
    End Sub

    Private Sub BtnProductsMarkAll_Click(sender As Object, e As EventArgs)
        For Each item As ListViewItem In LvProducts.Items
            item.Checked = True
        Next
    End Sub

    Private Sub BtnProductsUnmarkAll_Click(sender As Object, e As EventArgs)
        For Each item As ListViewItem In LvProducts.Items
            item.Checked = False
        Next
    End Sub

    Private Sub BtnFormInventorySearch_Click(sender As Object, e As EventArgs) Handles BtnFormInventorySearch.Click
        SearchListView(True, False, TbProductSearch.Text)
    End Sub

    Private Sub BtnProductsDeleteMarked_Click(sender As Object, e As EventArgs)
        Dim response As Integer
        response = MsgBox("Are you sure you want to delete?", vbYesNo, "Confirm Delete")
        If response = vbYes Then
            For Each i As ListViewItem In LvProducts.CheckedItems
                dbHandler.DeleteProduct(i.SubItems(0).Text)
                LvProducts.Items.Remove(i)
            Next
        End If
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response As Integer
        response = MsgBox("Are you sure you want to restore selected item?", vbYesNo, "Restore Item")
        If response = vbYes Then
            For Each i As ListViewItem In LvProducts.CheckedItems
                If dbHandler.SetAvailableProduct(i.SubItems(0).Text, True) Then
                    LvProducts.Items.Remove(i)
                    FormStockInventory.RefreshUI()
                End If
            Next
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LvProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvProducts.SelectedIndexChanged

    End Sub
End Class