Public Class FormViewReturnedProduct
    Dim sale As Sale

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub FormViewReturnedProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbInvoiceNumber.Text = FormReturns.LvReportsReturns.SelectedItems(0).SubItems(0).Text
        TbCustomerName.Text = FormReturns.LvReportsReturns.SelectedItems(0).SubItems(1).Text
        TbProductName.Text = FormReturns.LvReportsReturns.SelectedItems(0).SubItems(2).Text
        TbQty.Text = FormReturns.LvReportsReturns.SelectedItems(0).SubItems(3).Text
        TbPrice.Text = FormReturns.LvReportsReturns.SelectedItems(0).SubItems(4).Text
        TbDateAndTime.Text = FormReturns.LvReportsReturns.SelectedItems(0).SubItems(5).Text
        TbRemarks.Text = FormReturns.LvReportsReturns.SelectedItems(0).SubItems(7).Text

    End Sub
End Class