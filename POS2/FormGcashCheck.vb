Imports System.Data.SqlClient
Public Class FormGcashCheck
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private Sub BtnAddItemBack_Click(sender As Object, e As EventArgs) Handles BtnAddItemBack.Click
        Me.Close()
    End Sub

    Private Sub FormAddItemOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnClear_Click_1(sender As Object, e As EventArgs) Handles BtnClear.Click
        tbGcashRef.Clear()
    End Sub

    Private Sub BtnAddItemEnter_Click(sender As Object, e As EventArgs) Handles BtnAddItemEnter.Click
        If (Not String.IsNullOrEmpty(tbGcashRef.Text)) Then
            FormPOS.gcashRef = tbGcashRef.Text
            FormPOS.BtnPrint.PerformClick()
            tbGcashRef.Clear()
            Me.Close()
        Else
            MessageBox.Show("Please Reference Number.")
        End If

    End Sub
End Class