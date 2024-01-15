Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormAddDamagedProduct
    Private ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private ReadOnly product As New Product
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString
    Public Sub New(product As Product)
        InitializeComponent()
        Me.product = product
        FillAllFields()
    End Sub

    Private Sub FillAllFields()
        LblProdName.Text = FormStockInventory.LvProducts.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Val(TbQty.Text) > 0 Then
            If Val(Label5.Text) - Val(TbQty.Text) <= -1 Then
                MessageBox.Show("000Failed to decrease stock.", "Failed")
                TbQty.Clear()
            Else

                Dim sql As String = "INSERT INTO [dbo].[damages]
                                   ([id]
                                   ,[product_id]
                                   ,[category]
                                   ,[name]
                                   ,[classification]
                                   ,[brand]
                                   ,[size]
                                   ,[color]
                                   ,[quantity]
                                   ,[remarks]
                                   ,[date])
                             VALUES
                                   (@id
                                   ,@productid
                                   ,@category
                                   ,@name
                                   ,@classification
                                   ,@brand
                                   ,@size
                                   ,@color
                                   ,@QTY
                                   ,@remarks
                                   ,@date)"

                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim dateString As String = DtpDate.Value.ToString("MM-dd-yyyy")
                    Dim prodid As String = FormStockInventory.LvProducts.SelectedItems(0).SubItems(0).Text
                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.AddWithValue("@id", dbHandler.GenerateId)
                        command.Parameters.AddWithValue("@productid", prodid)
                        command.Parameters.AddWithValue("@category", FormStockInventory.LvProducts.SelectedItems(0).SubItems(1).Text)
                        command.Parameters.AddWithValue("@name", FormStockInventory.LvProducts.SelectedItems(0).SubItems(2).Text)
                        command.Parameters.AddWithValue("@classification", FormStockInventory.LvProducts.SelectedItems(0).SubItems(3).Text)
                        command.Parameters.AddWithValue("@brand", FormStockInventory.LvProducts.SelectedItems(0).SubItems(4).Text)
                        command.Parameters.AddWithValue("@size", FormStockInventory.LvProducts.SelectedItems(0).SubItems(5).Text)
                        command.Parameters.AddWithValue("@color", FormStockInventory.LvProducts.SelectedItems(0).SubItems(6).Text)
                        command.Parameters.AddWithValue("@QTY", Convert.ToInt32(TbQty.Text))
                        command.Parameters.AddWithValue("@remarks", TbRemarks.Text)
                        command.Parameters.AddWithValue("@date", dateString)
                        command.ExecuteNonQuery()
                    End Using
                End Using


                Dim prodid1 As String = FormStockInventory.LvProducts.SelectedItems(0).SubItems(0).Text
                Dim sql1 As String = "UPDATE products SET stock = @Value1 WHERE id = @ProdID"

                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim newstock As String = Val(Label5.Text) - Val(TbQty.Text)
                    Using command1 As New SqlCommand(sql1, connection)
                        command1.Parameters.AddWithValue("@Value1", newstock)
                        command1.Parameters.AddWithValue("@ProdID", prodid1)
                        command1.ExecuteNonQuery()
                    End Using
                End Using

                MsgBox("Process Successful")
            End If
        Else
            MsgBox("QTY must not be 0")
        End If


        conn1.Close()

        FormStockInventory.RefreshUI()
        Me.Close()


    End Sub
    Sub unlockbtn()
        BtnSave.Enabled = False ' Assume the button is disabled by default

        If TbQty.TextLength > 0 AndAlso
         TbRemarks.TextLength > 0 Then

            BtnSave.Enabled = True ' Enable the button if all conditions are met
        End If
    End Sub
    Private Sub SaveDamagedProduct()

        Dim timeString As String = DtpDate.Value.ToString("hh:mm:ss tt")
        Dim intQty As Integer = Integer.Parse(TbQty.Text)
        Dim strRemarks As String = TbRemarks.Text



        If (Not String.IsNullOrEmpty(strRemarks)) And (intQty > 0) Then
            Dim dmgdProd As New Damage With {
                    .Id = dbHandler.GenerateId,
                    .Product_Id = product.Id,
                    .Quantity = Val(TbQty.Text),
                    .DamagesDate = dateString,
                    .Remarks = strRemarks
                }
            If dbHandler.AddDamagedProduct(dmgdProd) Then
                    If dbHandler.DecreaseProductStock(product.Batch_Id, dmgdProd.Quantity) Then
                        FormStockInventory.RefreshUI()
                        FormDashboard.RefreshUI()
                        MessageBox.Show("Damaged item successfully added", "Success")
                        LoadListViewWithNewestRecords()
                        Me.Close()

                    Else
                    MessageBox.Show("1111Failed to decrease stock.", "Failed")
                End If
                Else
                MessageBox.Show("2222Failed to add damaged item.", "Failed")
            End If
            End If



    End Sub

    Private Sub LoadListViewWithNewestRecords()
        '    ' Clear the existing items in the ListView
        '    FormStockInventory.LvProducts.Items.Clear()

        '    ' Connect to the database and retrieve the newest records
        '    Dim connectionString As String = "YourConnectionString"
        '    Dim query As String = "SELECT * FROM YourTableName ORDER BY DateColumn DESC" ' Replace "YourTableName" and "DateColumn" with your actual table and column names
        '
        '   Using connection As New SqlConnection(connectionString)
        ' Using command As New SqlCommand(query, connection)
        ' connection.Open()
        '
        '    Dim reader As SqlDataReader = command.ExecuteReader()

        ' Iterate through the retrieved records and add them to the ListView
        '  While reader.Read()
        'Dim item As New ListViewItem(reader("category").ToString()) ' Replace "Column1" with the actual column name you want to display

        ' ...
        '
        '     FormStockInventory.LvProducts.Items.Add(item)
        '    End While
        '
        ' reader.Close()
        '   End Using
        '   End Using
    End Sub

    Private Sub TbQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbQty.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FormAddDamagedProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = Integer.Parse(FormStockInventory.LvProducts.SelectedItems(0).SubItems(8).Text)
        Me.BringToFront()
        unlockbtn()
    End Sub

    Private Sub TbQty_TextChanged(sender As Object, e As EventArgs) Handles TbQty.TextChanged

        unlockbtn()


    End Sub

    Private Sub TbRemarks_TextChanged(sender As Object, e As EventArgs) Handles TbRemarks.TextChanged
        unlockbtn()
    End Sub
End Class