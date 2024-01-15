Imports System.Data.SqlClient

Public Class FormAddExpiredProduct
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
    Sub unlockbtn()
        BtnSave.Enabled = False ' Assume the button is disabled by default

        If TbQty.TextLength > 0 Then
            BtnSave.Enabled = True ' Enable the button if all conditions are met
        End If
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If Val(Label4.Text) - Val(TbQty.Text) <= -1 Then
            MessageBox.Show("Failed to decrease stock.", "Failed")
            TbQty.Clear()
        Else
            SaveExpiredProduct()
            conn1.Open()
            Dim query As String = "INSERT INTO Logs ([Part], [Action], [Users], [Date], [Time]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"
            Dim command As New SqlCommand(query, conn1)
            command.Parameters.AddWithValue("@Value1", "Admin")
            command.Parameters.AddWithValue("@Value2", "Stock Out " + LblProdName.Text + " Quantity " + TbQty.Text)
            command.Parameters.AddWithValue("@Value3", FormLogin.TbUsername.Text)
            command.Parameters.AddWithValue("@Value4", FormLogin.ToolStripStatusLabel5.Text)
            command.Parameters.AddWithValue("@Value5", FormLogin.ToolStripStatusLabel2.Text)
            command.ExecuteNonQuery()
            conn1.Close()
            Me.Hide()
        End If

    End Sub
    Private Sub SaveExpiredProduct()
        Dim dateString As String = DtpDate.Value.ToString("MM-dd-yyyy")
        Dim timeString As String = DtpDate.Value.ToString("hh:mm:ss tt")
        Dim intQty As Integer = Integer.Parse(TbQty.Text)
        Dim prodid123 As String = FormStockInventory.LvProducts.SelectedItems(0).SubItems(0).Text
        Dim expdate As String = FormStockInventory.LvProducts.SelectedItems(0).SubItems(10).Text
        Using connection As New SqlConnection(connectionString)
            ' Open the connection
            conn1.Open()

            ' Create a SQL query for the insert statement
            Dim query As String = "INSERT INTO expired (id, product_id, date, quantity, expname, name) VALUES (@id, @prodid, @date, @quan, @exp, @name)"

            ' Create a SqlCommand object with the query and connection
            Using command As New SqlCommand(query, conn1)
                ' Add parameters to the query
                command.Parameters.AddWithValue("@id", dbHandler.GenerateId)
                command.Parameters.AddWithValue("@prodid", prodid123)
                command.Parameters.AddWithValue("@date", dateString)
                command.Parameters.AddWithValue("@quan", TbQty.Text)
                command.Parameters.AddWithValue("@exp", expdate)
                command.Parameters.AddWithValue("@name", LblProdName.Text)
                ' Execute the query
                command.ExecuteNonQuery()

                MsgBox("Expired Item Added")
            End Using

            connection.Open()

            ' Create a SQL query for the update statement
            Dim query1 As String = "UPDATE products SET stock = @stock WHERE id = @id"

            ' Create a SqlCommand object with the query and connection
            Using command1 As New SqlCommand(query1, conn1)
                Dim holderforstock As String = Val(TbQty.Text) - Val(Label4.Text)
                command1.Parameters.AddWithValue("@stock", holderforstock)
                command1.Parameters.AddWithValue("@id", prodid123)
                command1.ExecuteNonQuery()
                conn1.Close()
            End Using

        End Using
        FormStockInventory.RefreshUI()

    End Sub

    Private Sub FormAddExpiredProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = FormStockInventory.LvProducts.SelectedItems(0).SubItems(8).Text
        unlockbtn()

    End Sub

    Private Sub TbQty_TextChanged(sender As Object, e As EventArgs) Handles TbQty.TextChanged
        unlockbtn()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class