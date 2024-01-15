Imports System.Data.SqlClient
Public Class FormAddItemOrder
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private Sub BtnAddItemBack_Click(sender As Object, e As EventArgs) Handles BtnAddItemBack.Click
        Me.Close()
    End Sub

    Private Sub FormAddItemOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddOrder(FormPOS._intentItemId)
    End Sub

    Private Sub AddOrder(ByVal _itemId As String)
        Dim dt As DataTable = dbHandler.GetProductsTable()

        If dt IsNot Nothing Then
            For Each row As DataRow In dt.Rows
                If ((row("id").ToString()) = _itemId) Then
                    LblItemName.Text = row("name").ToString()
                    LblItemUnit.Text = row("size").ToString() & " " & row("unit").ToString()
                    Exit For
                End If
            Next
        Else
            ' Handle the case where dt is Nothing
            ' For example, display an error message or log the error.
        End If
    End Sub
    Private Sub TbItemQty_TextChanged(sender As Object, e As EventArgs) Handles TbItemQty.TextChanged
        If TbItemQty.TextLength = 0 Then
        Else
            Dim qty As Integer = Label1.Text
            Dim orderwty As Integer = TbItemQty.Text
            If qty < orderwty Then
                MsgBox("Unsufficient Stock")
                TbItemQty.Clear()

            End If
        End If
    End Sub
    Private Sub TbItemQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbItemQty.KeyPress
        ' Check if the pressed key is a digit or a control key (like backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not a digit and not a control key, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub BtnClear_Click_1(sender As Object, e As EventArgs) Handles BtnClear.Click
        TbItemQty.Clear()
    End Sub

    Private Sub BtnAddItemEnter_Click(sender As Object, e As EventArgs) Handles BtnAddItemEnter.Click
        Try
            If Convert.ToInt32(TbItemQty.Text) > 0 Then
                If (Not String.IsNullOrEmpty(TbItemQty.Text)) Then
                    Dim _itemQty = Val(TbItemQty.Text)

                    If (_itemQty <= 0) Then
                        MessageBox.Show("Item quantity must be greater than or equal to one.")
                    Else
                        FormPOS.AddOrder(FormPOS._intentItemId, _itemQty)
                        FormPOS.checkTotalPrice()
                        FormPOS.readOnlyGcashValue()
                        'FormPOS.RefreshUi()
                        Me.Hide()
                    End If
                Else
                    MessageBox.Show("Please add quantity.")
                End If
                FormPOS.checkTotalPrice()
                TbItemQty.Clear()

            Else

                MsgBox("QTY must not be 0")
            End If
        Catch
        End Try

    End Sub
End Class