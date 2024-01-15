Public Class FormDialogStockinOrStockOut
    ReadOnly product As Product

    Public Sub New(tempProduct As Product)
        ' This call is required by the designer.
        InitializeComponent()
        product = tempProduct

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnStockIn_Click(sender As Object, e As EventArgs) Handles BtnStockIn.Click

        FormStockIn.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BtnStockOut_Click(sender As Object, e As EventArgs) Handles BtnStockOut.Click
        Dim formAddDamagedProduct As New FormAddDamagedProduct(product)
        Me.Hide()
        formAddDamagedProduct.ShowDialog()
    End Sub

    Private Sub FormDialogStockinOrStockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormStockInventory.LvProducts.SelectedItems(0).SubItems(8).Text = 0 Then
            BtnStockOut.Enabled = False
        Else
            BtnStockOut.Enabled = True

        End If
    End Sub
End Class