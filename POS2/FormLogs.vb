Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Data.SqlClient

Public Class FormLogs
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Dim dataTable As DataTable

    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString
    Private Sub FormLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        logs123()
    End Sub
    Sub logs123()

        Try
            conn1.Open()
            Dim query As String = "SELECT * FROM Logs"
            Dim adapter As New SqlDataAdapter(query, conn1)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn1.Close()
        End Try
    End Sub



    Private Sub BtnFormInventoryRefresh_Click(sender As Object, e As EventArgs) Handles BtnFormInventoryRefresh.Click
        logs123()
    End Sub

    Private Sub PrintToPdf(dataTable As DataTable, fileName As String)
        ' Create a new PDF document
        Dim doc As New Document()

        ' Show a dialog box to allow the user to choose the save location and filename
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
        saveFileDialog.Title = "Save PDF File"
        saveFileDialog.ShowDialog()

        ' If the user clicked the OK button, proceed with saving the PDF file
        If saveFileDialog.FileName <> "" Then
            fileName = saveFileDialog.FileName

            ' Create a new PDF writer that will write to the file stream
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(fileName, FileMode.Create))

            ' Open the document for writing
            doc.Open()

            ' Add a new table to the document
            Dim table As New PdfPTable(dataTable.Columns.Count)

            ' Add the column headers to the table
            For Each column As DataColumn In dataTable.Columns
                table.AddCell(column.ColumnName)
            Next

            ' Add the data rows to the table
            For Each row As DataRow In dataTable.Rows
                For i As Integer = 0 To dataTable.Columns.Count - 1
                    table.AddCell(row(i).ToString())
                Next
            Next

            ' Add the table to the document
            doc.Add(table)

            ' Close the document
            doc.Close()

            ' Show a message box to indicate success
            MessageBox.Show("PDF file created successfully and saved to " & fileName & ".")
        End If
    End Sub

    Private Sub BtnLogsPrintData_Click(sender As Object, e As EventArgs) Handles BtnPrintData.Click
        FormPrintPreview.printType = "logs"
        Try
            FormPrintPreview.Show()
        Catch

        End Try
    End Sub


End Class