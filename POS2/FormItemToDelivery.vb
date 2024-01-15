Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports iTextSharp.text.xml.simpleparser

Public Class FormItemToDelivery
    Private ReadOnly _connectionPool As ConnectionPool
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    Dim dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString
    Dim filterValue As String

    Private Sub FormItemToDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        asd()
    End Sub

    Private Sub asd()
        conn1.Open()

        ' Step 2: Create a SqlCommand object with the parameterized SQL query
        Dim query As String = "SELECT item_name, item_quantity FROM sales WHERE invoice_number LIKE @Filter"
        Dim cmd As New SqlCommand(query, conn1)

        ' Step 3: Set the parameter value based on TextBox1
        cmd.Parameters.AddWithValue("@Filter", "%" & TextBox1.Text & "%")

        ' Step 4: Execute the SQL query and retrieve data into a SqlDataReader
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        ' Step 5: Create a new DataTable to hold the data
        Dim dataTable As New DataTable()

        ' Step 6: Load the data from the SqlDataReader into the DataTable
        dataTable.Load(reader)

        ' Step 7: Close the SqlDataReader and SqlConnection
        reader.Close()
        conn1.Close()

        ' Step 8: Assign the DataTable as the data source for the DataGridView
        DataGridView1.DataSource = dataTable

        ' Step 9: Set the column AutoSizeMode to Fill
        DataGridView1.Columns("item_name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("item_quantity").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        ' Step 10: Set the cell border style to include a 3px border
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single
        DataGridView1.GridColor = Color.Black
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single
        DataGridView1.Columns("item_name").HeaderText = "Item Name"
        DataGridView1.Columns("item_quantity").HeaderText = "Quantity"
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView1.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold)
    End Sub


    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class