Imports System.Data.SqlClient
Imports System.Globalization
Imports ServiceStack

Public Class FormUpdateDeliveredProduct
    Private ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"

    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString


    Private Sub FormUpdateDeliveredProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub newFillAllFields(id As String, proID As String)
        Using connection As New SqlConnection(dbHandler.getConnectionString())
            connection.Open()
            Dim tempcmd As New SqlCommand("SELECT * FROM sales WHERE invoice_number = @id AND product_id = @proID", conn1)
            tempcmd.Parameters.Add("@id", id)
            tempcmd.Parameters.Add("@proID", proID)
            Dim dataAdapter As New SqlDataAdapter(tempcmd)
            Dim tempDT As New DataTable
            dataAdapter.Fill(tempDT)

            TbProdInvoiceNo.Text = id
            TbProdName.Text = tempDT.Rows(0).Item(3).ToString
            TbProdCustomerName.Text = tempDT.Rows(0).Item(8).ToString
            TbProdQty.Text = tempDT.Rows(0).Item(4).ToString
            TbProdPrice.Text = tempDT.Rows(0).Item(5).ToString

            Dim pending1 As Boolean = Convert.ToBoolean(tempDT.Rows(0).Item(18))
            If pending1 Then
                ChkBoxDelivered.Checked = False
                ChkBoxDelivered.Enabled = True
                BtnSaveProduct.Enabled = True
            Else
                ChkBoxDelivered.Checked = True
                ChkBoxDelivered.Enabled = False
                BtnSaveProduct.Enabled = False
            End If
            connection.Close()
        End Using
        conn1.Close()
        conn1.Open()
        Dim sql As String = "SELECT release_date FROM sales WHERE invoice_number = @param"
        Dim cmd As New SqlCommand(sql, conn1)
        cmd.Parameters.AddWithValue("@param", TbProdInvoiceNo.Text)

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim releaseDateAsString As String = reader.GetString(0) ' Assuming the release_date is stored as a string in the database
            Dim inputFormat As String = "dd/MM/yyyy"
            Dim releaseDate As DateTime
            If DateTime.TryParseExact(releaseDateAsString, inputFormat, Nothing, DateTimeStyles.None, releaseDate) Then
                DtpExDate.Value = releaseDate
                ' Use the date value as needed
            End If
        End While
        reader.Close()
        conn1.Close()

        conn1.Open()
        Dim sql1 As String = "SELECT delivery_date FROM sales WHERE invoice_number = @param"
        Dim cmd1 As New SqlCommand(sql1, conn1)
        cmd1.Parameters.AddWithValue("@param", TbProdInvoiceNo.Text)

        Dim reader1 As SqlDataReader = cmd1.ExecuteReader()

        While reader1.Read()
            Dim releaseDateAsString As String = reader1.GetString(0) ' Assuming the release_date is stored as a string in the database
            Dim inputFormat As String = "dd/MM/yyyy"
            Dim releaseDate As DateTime
            If DateTime.TryParseExact(releaseDateAsString, inputFormat, Nothing, DateTimeStyles.None, releaseDate) Then
                DateTimePicker1.Value = releaseDate
                ' Use the date value as needed
            End If
        End While

        reader1.Close()
        conn1.Close()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnSaveProduct_Click(sender As Object, e As EventArgs) Handles BtnSaveProduct.Click
        If (ChkBoxDelivered.Checked) Then
            Dim invoiceNumber As String = TbProdInvoiceNo.Text

            If dbHandler.SetDeliveredSale(invoiceNumber, False) Then
                FormDelivery.RefreshUI()
                MessageBox.Show("The item has been delivered.", "Item Delivered")
                Me.Close()
            End If
        Else
            MessageBox.Show("Please check the set delivered checkbox.", "Notice")
        End If
    End Sub

    Private Sub ChkBoxDelivered_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxDelivered.CheckedChanged

    End Sub
End Class