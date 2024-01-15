Public Class FormDialogStockOut
    Private ReadOnly product As New Product
    Public Sub New(product As Product)
        InitializeComponent()
        Me.product = product
    End Sub
    Private Sub FormDialogStockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If FormStockInventory.LvProducts.SelectedItems(0).SubItems(8).Text = 0 Then
            BtnDialogStockOutExpired.Enabled = False
            BtnDialogStockOutDamaged.Enabled = False
        Else
            BtnDialogStockOutExpired.Enabled = True
            BtnDialogStockOutDamaged.Enabled = True

        End If

    End Sub

    Public Sub RefreshUi()

    End Sub

    Private Sub BtnDialogStockOutExpired_Click(sender As Object, e As EventArgs) Handles BtnDialogStockOutExpired.Click
        Dim formAddExpiredProduct As New FormAddExpiredProduct(product)
        Me.Hide()
        formAddExpiredProduct.ShowDialog()
    End Sub
    Private Sub BtnDialogStockOutDamaged_Click(sender As Object, e As EventArgs) Handles BtnDialogStockOutDamaged.Click
        Dim formAddDamagedProduct As New FormAddDamagedProduct(product)
        Me.Hide()
        formAddDamagedProduct.ShowDialog()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class