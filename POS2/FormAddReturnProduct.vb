Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports Mysqlx
Imports POS2

Public Class FormAddReturnProduct
    Private ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private ReadOnly product As New Product
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString
    Public Shared returnID As String
    Dim listSales As New List(Of Sale)
    Dim filteredSales As List(Of Sale)
    Dim selectedSale As Sale


    Public Sub Refresher()
        conn1.Open()
        Dim cmd As New SqlCommand("select invoice_number, release_date from sales", conn1)

        Dim da As SqlDataReader = cmd.ExecuteReader
        returnGraph.Items.Clear()
        Dim da1 As String
        Do While da.Read = True
            If Not da(0) = da1 Then
                Dim list1 As New ListViewItem(da(0).ToString)
                list1.SubItems.Add(da(1))
                returnGraph.Items.Add(list1)
            End If
            da1 = da(0)
        Loop
        conn1.Close()
    End Sub
    Private Sub FormAddReturnProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listSales = dbHandler.GetSale()
        Refresher()

    End Sub


    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub


    'Private Sub PopulateCbProducts(filteredSales As List(Of Sale))
    '    CbProductList.Items.Clear()
    '    For Each sale As Sale In filteredSales
    '        CbProductList.Items.Add(sale.Product_Name)
    '    Next
    'End Sub

    'Private Sub CbProductList_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If CbProductList.SelectedText.Any Then
    '        BtnSaveProduct.Enabled = False
    '    Else
    '        BtnSaveProduct.Enabled = True
    '    End If

    '    For Each sale In filteredSales
    '        If CbProductList.Text = sale.Product_Name Then
    '            selectedSale = sale
    '            FillAllFields(selectedSale)
    '        End If
    '    Next
    'End Sub
    'Sub unlockbtn()
    '    BtnSaveProduct.Enabled = False ' Assume the button is disabled by default


    '    If TbInvoiceNumber.TextLength > 0 AndAlso
    ' TbCustomerName.TextLength > 0 AndAlso
    ' TbDateOfTransaction.TextLength > 0 AndAlso
    ' TbRemarks.TextLength > 0 Then

    '        BtnSaveProduct.Enabled = True ' Enable the button if all conditions are met
    '    End If
    'End Sub

    'Private Sub BtnSaveProduct_Click(sender As Object, e As EventArgs) Handles BtnSaveProduct.Click

    '    Dim conn1 As SqlConnection = New SqlConnection(connectionString)
    '    Dim command As SqlCommand = New SqlCommand()
    '    conn1.Close()
    '    conn1.Open()
    '    command.Connection = conn1

    '    Dim qtyholder As Integer = 0
    '    Dim priceholder As Integer = 0
    '    Dim dateholder As String = ""
    '    Dim timeholder As String = ""

    '    Dim command3 As New SqlCommand("SELECT item_quantity FROM sales WHERE invoice_number = @invoice AND item_name = @itemname", conn1)
    '    command3.Parameters.AddWithValue("@invoice", TbInvoiceNumber.Text)
    '    command3.Parameters.AddWithValue("@itemname", CbProductList.Text)

    '    ' Execute the query and retrieve the data
    '    Dim reader1 As SqlDataReader = command3.ExecuteReader()

    '    If reader1.HasRows Then
    '        reader1.Read()
    '        Dim value As Integer
    '        If Not reader1.IsDBNull(0) Then
    '            value = reader1.GetInt32(0)
    '            qtyholder = value
    '        End If
    '    End If
    '    reader1.Close()

    '    Dim itemprice1 As Decimal = 0

    '    Dim command4 As New SqlCommand("SELECT CAST(item_price AS decimal) FROM sales WHERE invoice_number = @invoice AND item_name = @itemname", conn1)
    '    command4.Parameters.AddWithValue("@invoice", TbInvoiceNumber.Text)
    '    command4.Parameters.AddWithValue("@itemname", CbProductList.Text)

    '    ' Execute the query and retrieve the data
    '    Dim reader2 As SqlDataReader = command4.ExecuteReader()
    '    If reader2.Read() Then
    '        If Not reader2.IsDBNull(0) Then
    '            itemprice1 = reader2.GetDecimal(0)
    '            priceholder = itemprice1
    '        End If
    '    End If
    '    reader2.Close()

    '    Dim itemdate1 As String = ""

    '    Dim command5 As New SqlCommand("SELECT release_date FROM sales WHERE invoice_number = @invoice AND item_name = @itemname", conn1)
    '    command5.Parameters.AddWithValue("@invoice", TbInvoiceNumber.Text)
    '    command5.Parameters.AddWithValue("@itemname", CbProductList.Text)

    '    ' Execute the query and retrieve the data
    '    Dim reader3 As SqlDataReader = command5.ExecuteReader()
    '    If reader3.HasRows Then
    '        reader3.Read()
    '        If Not reader3.IsDBNull(0) Then
    '            itemdate1 = reader3.GetString(0)
    '            dateholder = itemdate1
    '        End If
    '    End If
    '    reader3.Close()

    '    Dim itemtime As String = ""

    '    Dim command6 As New SqlCommand("SELECT release_time FROM sales WHERE invoice_number = @invoice AND item_name = @itemname", conn1)
    '    command6.Parameters.AddWithValue("@invoice", TbInvoiceNumber.Text)
    '    command6.Parameters.AddWithValue("@itemname", CbProductList.Text)

    '    ' Execute the query and retrieve the data
    '    Dim reader4 As SqlDataReader = command6.ExecuteReader()
    '    If reader4.HasRows Then
    '        reader4.Read()
    '        If Not reader4.IsDBNull(0) Then
    '            itemtime = reader4.GetString(0)
    '            timeholder = itemtime
    '        End If
    '    End If
    '    reader4.Close()

    '    ' Close the reader and connection
    '    conn1.Close()
    '    conn1.Open()

    '    If Val(TextBox1.Text) > Val(qtyholder) Then
    '        MessageBox.Show("The Quantity you want to return is greater than the Stored Quantity")
    '        TextBox1.Clear()
    '        Exit Sub
    '    End If

    '    ' Specify the SQL update query
    '    command.CommandText = "UPDATE sales SET item_quantity = @itemqty, returned = @retitem WHERE invoice_number = @invoice AND item_name = @itemname"
    '    ' Replace 'YourTable' with the actual table name
    '    ' Replace 'Column1', 'Column2', and 'Id' with the actual column names

    '    ' Add parameters to the command
    '    Dim totalqty As Integer = Val(qtyholder) - Val(TextBox1.Text)
    '    command.Parameters.AddWithValue("@itemqty", totalqty)
    '    command.Parameters.AddWithValue("@retitem", True)
    '    command.Parameters.AddWithValue("@invoice", TbInvoiceNumber.Text)
    '    command.Parameters.AddWithValue("@itemname", CbProductList.Text)

    '    ' Execute the update query
    '    Dim rowsAffected As Integer = command.ExecuteNonQuery()

    '    ' Check the number of rows affected
    '    If rowsAffected > 0 Then

    '        Dim sql As String = "INSERT INTO returned_items (id,invoice_number, customer_name, item_name, item_quantity, item_price, item_date, item_time,item_remarks) VALUES (@id123,@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8)"

    '        Dim command1 As New SqlCommand(sql, conn1)
    '        command1.Parameters.AddWithValue("@id123", dbHandler.GenerateId)
    '        command1.Parameters.AddWithValue("@Value1", TbInvoiceNumber.Text)
    '        command1.Parameters.AddWithValue("@Value2", TbCustomerName.Text)
    '        command1.Parameters.AddWithValue("@Value3", CbProductList.Text)
    '        command1.Parameters.AddWithValue("@Value4", TextBox1.Text)
    '        command1.Parameters.AddWithValue("@Value5", priceholder)
    '        command1.Parameters.AddWithValue("@Value6", dateholder)
    '        command1.Parameters.AddWithValue("@Value7", timeholder)
    '        command1.Parameters.AddWithValue("@Value8", TbRemarks.Text)
    '        command1.ExecuteNonQuery()




    '        MessageBox.Show("Update successful!")

    '        TbInvoiceNumber.Clear()
    '        TbCustomerName.Clear()
    '        CbProductList.Items.Clear()
    '        TextBox1.Clear()
    '        TbDateOfTransaction.Clear()
    '        TbRemarks.Clear()
    '        conn1.Close()

    '    Else
    '        MessageBox.Show("No rows were updated.")
    '        conn1.Close()
    '    End If
    '    deleteif0qty()
    'End Sub


    Private Sub TbInvoiceNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbInvoiceNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub




    Private Sub deleteif0qty()


        conn1.Open()
        Dim selectQuery As String = "SELECT * FROM sales WHERE item_quantity = 0"
        Dim selectCommand As New SqlCommand(selectQuery, conn1)
        Dim reader321 As SqlDataReader = selectCommand.ExecuteReader()

        ' Create a new connection and command for delete operation
        Dim conn2 As New SqlConnection(connectionString)
        conn2.Open()
        Dim deleteCommand As New SqlCommand("DELETE FROM sales WHERE id = @PrimaryKeyValue", conn2)
        deleteCommand.Parameters.Add("@PrimaryKeyValue", SqlDbType.Int)

        ' Iterate over the result set
        While reader321.Read()
            ' Retrieve the primary key value for the record
            Dim primaryKeyValue As Integer = CInt(reader321("id"))

            ' Set the parameter value and execute the delete command
            deleteCommand.Parameters("@PrimaryKeyValue").Value = primaryKeyValue
            deleteCommand.ExecuteNonQuery()
        End While

        ' Close the reader and connection
        reader321.Close()
        conn2.Close()
        conn1.Close()

    End Sub

    Private Sub returnGraph_SelectedIndexChanged(sender As Object, e As EventArgs) Handles returnGraph.SelectedIndexChanged
        'Dim item As New ListViewItem(invoiceNumber)
        'item.SubItems.Add(da(4).ToString())
        'item.SubItems.Add(da(2).ToString())
        'item.SubItems.Add(da(3).ToString())
        'item.SubItems.Add("₱ " + da(8).ToString())
        'item.SubItems.Add(da(11).ToString())
        'item.SubItems.Add(da(5).ToString())
        'item.SubItems.Add(da(9).ToString())

        'LvLowStock.Items.Add(item)
    End Sub

    Private Sub BtnSaveProduct_Click(sender As Object, e As EventArgs) Handles BtnSaveProduct.Click
        If (returnGraph.SelectedItems.Count > 0) Then
            returnID = returnGraph.SelectedItems(0).SubItems(0).Text
            FormAddReturnList.Show()
        End If
    End Sub

    Private Sub TbInvoiceNumber_TextChanged(sender As Object, e As EventArgs) Handles TbInvoiceNumber.TextChanged
        Try
            conn1.Open()
            Dim cmd As New SqlCommand("select invoice_number, release_date from sales WHERE invoice_number LIKE CONCAT('%', @invoice, '%')", conn1)
            cmd.Parameters.AddWithValue("@invoice", TbInvoiceNumber.Text)
            Dim da As SqlDataReader = cmd.ExecuteReader
            returnGraph.Items.Clear()
            Dim da1 As String
            Do While da.Read = True
                If Not da(0) = da1 Then
                    Dim list1 As New ListViewItem(da(0).ToString)
                    list1.SubItems.Add(da(1))
                    returnGraph.Items.Add(list1)
                End If
                da1 = da(0)
            Loop
            conn1.Close()
        Catch

        End Try

    End Sub
End Class