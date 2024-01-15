Imports POS2

Public Class FormUpdateProduct
    Private ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private ReadOnly product As New Product
    '  Public Sub New(product As Product)
    '   InitializeComponent()
    '    Me.product = product
    '   PopulateCbCategories()
    '   FillAllFields(product)
    '   End Sub

    Private Sub FormUpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub TbProdPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbProdStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdStock.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnSaveProduct_Click(sender As Object, e As EventArgs) Handles BtnSaveProduct.Click

    End Sub
End Class