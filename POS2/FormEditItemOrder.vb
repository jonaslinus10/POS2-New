Imports System.Data.SqlClient
Public Class FormEditItemOrder
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private Sub BtnAddItemBack_Click(sender As Object, e As EventArgs) Handles BtnAddItemBack.Click
        Me.Close()
    End Sub

    Private Sub FormEditItemOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim query As String = "SELECT stock FROM products WHERE id = @id"
            Using connection As New SqlConnection(dbHandler.getConnectionString)
                connection.Open()
                Dim cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@id", FormPOS._intentItemId)
                Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                adapter.Fill(dt)
                Try
                    Dim dbStock As Integer = Convert.ToInt32(dt.Rows(0).Item(0))
                    Dim qty As Integer = Label1.Text
                    Dim orderwty As Integer = TbItemQty.Text
                    If dbStock < orderwty Then
                        MsgBox("Unsufficient Stock")
                        TbItemQty.Clear()
                    End If
                Catch
                End Try

                cmd.Dispose()
                connection.Close()
            End Using



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
        Dim dbStock As Integer
        If Val(TbItemQty.Text) > 0 Then
            If (Not String.IsNullOrEmpty(TbItemQty.Text)) Then
                Dim _itemQty = Val(TbItemQty.Text)

                If (_itemQty < 0) Then
                    MessageBox.Show("Item quantity must be greater than or equal to one.")
                Else
                    Dim existingItem1 = FormPOS.LvPosProducts.Items.Cast(Of ListViewItem)().FirstOrDefault(Function(item) item.Text = FormPOS.LvPosOrders.SelectedItems(0).SubItems(0).Text)
                    Dim lbProductsQTY As Integer = Convert.ToInt32(existingItem1.SubItems(8).Text)
                    Dim lbOrderQTY As Integer = Convert.ToInt32(FormPOS.LvPosOrders.SelectedItems(0).SubItems(3).Text)

                    Dim query As String = "SELECT stock FROM products WHERE id = @id"
                    Using connection As New SqlConnection(dbHandler.getConnectionString)
                        connection.Open()
                        Dim cmd As SqlCommand = New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@id", FormPOS._intentItemId)
                        Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                        Dim dt As DataTable = New DataTable
                        adapter.Fill(dt)
                        Try
                            dbStock = Convert.ToInt32(dt.Rows(0).Item(0))
                        Catch
                        End Try

                        cmd.Dispose()
                        connection.Close()
                    End Using
                    'MsgBox(lbProductsQTY & " " & lbOrderQTY & " " & dbStock)
                    Dim finalQTY As Integer
                    If lbProductsQTY = 0 Or Convert.ToInt32(TbItemQty.Text) = 0 Then
                        finalQTY = dbStock - Convert.ToInt32(TbItemQty.Text)
                    ElseIf lbProductsQTY < lbOrderQTY Then
                        finalQTY = dbStock - Convert.ToInt32(TbItemQty.Text)
                        'MsgBox("Second")
                    ElseIf lbProductsQTY > lbOrderQTY Then
                        finalQTY = dbStock - Convert.ToInt32(TbItemQty.Text)
                        'MsgBox("Third")
                    End If

                    'MsgBox(finalQTY)
                    existingItem1.SubItems(8).Text = finalQTY


                    FormPOS.LvPosOrders.SelectedItems(0).SubItems(3).Text = Convert.ToInt32(TbItemQty.Text)
                    Dim tempPrice = Convert.ToInt64(FormPOS.LvPosOrders.SelectedItems(0).SubItems(2).Text) * Convert.ToInt64(FormPOS.LvPosOrders.SelectedItems(0).SubItems(3).Text)
                    FormPOS.LvPosOrders.SelectedItems(0).SubItems(4).Text = Convert.ToInt64(tempPrice)


                    'FormPOS.RefreshUi()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Please add quantity.")
            End If
            FormPOS.readOnlyGcashValue()
        Else
            MsgBox("QTY must not be 0")
        End If
        FormPOS.checkTotalPrice()
        TbItemQty.Clear()
    End Sub
End Class