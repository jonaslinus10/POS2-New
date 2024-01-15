Imports System.Data.SqlClient
Public Class FormGcashTwoPayment
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Public gcTWBalance As Double
    Private Sub BtnAddItemBack_Click(sender As Object, e As EventArgs) Handles BtnAddItemBack.Click
        Me.Close()
    End Sub

    Private Sub FormAddItemOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcTWBalance = (gcTWBalance) * -1
        tbRemaingBalance.Text = gcTWBalance
    End Sub
    Private Sub BtnClear_Click_1(sender As Object, e As EventArgs) Handles BtnClear.Click
        tbGcashRef.Clear()
    End Sub

    Private Sub BtnAddItemEnter_Click(sender As Object, e As EventArgs) Handles BtnAddItemEnter.Click
        If (Not String.IsNullOrEmpty(tbGcashRef.Text)) Then
            FormPOS.gcashRef = tbGcashRef.Text
            FormPOS.remainingBalance = Convert.ToInt64(tbRemaingBalance.Text) - FormPOS.remainingBalance
            FormPOS.BtnPrint.PerformClick()
            tbGcashRef.Clear()
            gcTWBalance = 0
            Me.Close()
        Else
            MessageBox.Show("Please Reference Number.")
        End If

    End Sub

    Private Sub tbRemaingBalance_TextChanged(sender As Object, e As EventArgs) Handles tbRemaingBalance.TextChanged

    End Sub
End Class