Imports System.Data.SqlClient
Imports GemBox.Spreadsheet
Imports System.IO
Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports GemBox.Spreadsheet.WinFormsUtilities
Imports System.Reflection

Public Class FormPrintPreview
    Public currentUser As User
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    ReadOnly dbPath As String = System.Windows.Forms.Application.StartupPath.Substring(0, (System.Windows.Forms.Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"

    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString
    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim workbook As ExcelFile
    Public printType As String

    Public Sub New()
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY")
        InitializeComponent()

    End Sub

    Private Sub FormPrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InsertItemsPrint(printType)
        ShowPrintPreview()
        Me.TopMost = True
    End Sub

    Private Function ExcelFileToByteArray(excelFile As ExcelFile) As Byte()
        Using memoryStream As New MemoryStream()
            excelFile.Save(memoryStream, SaveOptions.XlsxDefault)
            Return memoryStream.ToArray()
        End Using
    End Function


    Private Sub ShowPrintPreview()

        ' Create image for each Excel workbook's page.
        Dim images As Image() = Me.CreatePrintPreviewImages()
        Dim imageIndex As Integer = 0

        ' Draw each page's image on PrintDocument for print preview.
        Dim printDocument = New PrintDocument()
        AddHandler printDocument.PrintPage,
          Sub(sender, e)
              Using image As Image = images(imageIndex)
                  Dim graphics = e.Graphics
                  Dim region = graphics.VisibleClipBounds

                  ' Rotate image if it has landscape orientation.
                  If image.Width > image.Height Then image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                  graphics.DrawImage(image, 0, 0, region.Width, region.Height)

              End Using

              imageIndex += 1
              e.HasMorePages = imageIndex < images.Length
          End Sub

        Me.PageUpDown.Value = 1
        If Not images Is Nothing Then
            Me.PageUpDown.Maximum = images.Length
            Me.printPreviewControl.Document = printDocument
        Else
            MsgBox("Closing Print Preview!")
            Me.Close()
        End If


    End Sub
    Private Function CreatePrintPreviewImages() As Image()
        Dim paginatorOptions As New PaginatorOptions With {.SelectionType = SelectionType.EntireFile}
        If Not workbook Is Nothing Then
            Dim pages = Me.workbook.GetPaginator(paginatorOptions).Pages

            Dim images = New Image(pages.Count - 1) {}
            Dim imageOptions As New ImageSaveOptions()

            For pageIndex As Integer = 0 To pages.Count - 1
                Dim imageStream = New MemoryStream()
                pages(pageIndex).Save(imageStream, imageOptions)
                images(pageIndex) = Image.FromStream(imageStream)
            Next
            Return images
        Else
            MsgBox("No Pages to Print!")
        End If


    End Function

    Public Sub salesPrint()
        Dim stream As New IO.MemoryStream(My.Resources.Format_Sales)
        Dim workbook1 = ExcelFile.Load(stream)
        Dim numberOfItems As Integer = FormSales.LvReportsSale.Items.Count
        Dim startDate = DateTime.Today.AddDays(-numberOfItems)
        Dim endDate = DateTime.Today

        ' Get template sheet.
        Dim worksheet = workbook1.Worksheets(0)

        ' Find cells with placeholder text and set their values.
        Dim row As Integer, column As Integer
        If worksheet.Cells.FindText("[Date]", row, column) Then
            Dim currentDate As Date = DateTime.Now
            Dim formattedDate As String = currentDate.ToString("MMMM dd, yyyy")

            worksheet.Cells(row, column).Value = formattedDate

        End If
        ' Copy template row.
        row = 17
        worksheet.Rows.InsertCopy(row + 1, numberOfItems - 1, worksheet.Rows(row))
        Dim currentRow As ExcelRow
        Dim random As New Random()
        For i As Integer = 0 To numberOfItems - 1
            ' Check if the index is within the range of items
            If i < FormSales.LvReportsSale.Items.Count Then
                Dim list = FormSales.LvReportsSale.Items(i)

                ' Assuming worksheet is an instance of the ExcelWorksheet class
                ' Make sure that 'row + i' is a valid row index for the worksheet
                currentRow = worksheet.Rows(row + i)
                ' Make sure that the column indices are valid for your Excel worksheet
                currentRow.Cells(1).Value = list.SubItems(0).Text
                currentRow.Cells(2).Value = list.SubItems(1).Text
                currentRow.Cells(3).Value = list.SubItems(2).Text
                currentRow.Cells(4).Value = list.SubItems(3).Text
                currentRow.Cells(5).Value = list.SubItems(4).Text
                currentRow.Cells(6).Value = list.SubItems(5).Text
                currentRow.Cells(7).Value = list.SubItems(6).Text
                currentRow.Cells(8).Value = list.SubItems(7).Text
                currentRow.Cells(9).Value = list.SubItems(8).Text
                currentRow.Cells(10).Value = list.SubItems(9).Text
                currentRow.Cells(11).Value = list.SubItems(10).Text
                currentRow.Cells(12).Value = list.SubItems(11).Text
            Else
                ' Handle the case where the index is out of range
                ' (Optional depending on your requirements)
                Console.WriteLine($"Index {i} is out of range.")
            End If
        Next
        Me.workbook = workbook1
    End Sub

    Public Sub returnsPrint()
        Dim stream As New IO.MemoryStream(My.Resources.Format_Returns)
        Dim workbook1 = ExcelFile.Load(stream)
        Dim numberOfItems As Integer = FormReturns.LvReportsReturns.Items.Count
        Dim startDate = DateTime.Today.AddDays(-numberOfItems)
        Dim endDate = DateTime.Today

        ' Get template sheet.
        Dim worksheet = workbook1.Worksheets(0)

        ' Find cells with placeholder text and set their values.
        Dim row As Integer, column As Integer
        If worksheet.Cells.FindText("[Date]", row, column) Then
            Dim currentDate As Date = DateTime.Now
            Dim formattedDate As String = currentDate.ToString("MMMM dd, yyyy")

            worksheet.Cells(row, column).Value = formattedDate

        End If


        ' Copy template row.
        row = 17
        worksheet.Rows.InsertCopy(row + 1, numberOfItems - 1, worksheet.Rows(row))
        Dim currentRow As ExcelRow
        Dim random As New Random()
        For i As Integer = 0 To numberOfItems - 1
            ' Check if the index is within the range of items
            If i < FormReturns.LvReportsReturns.Items.Count Then
                Dim list = FormReturns.LvReportsReturns.Items(i)

                ' Assuming worksheet is an instance of the ExcelWorksheet class
                ' Make sure that 'row + i' is a valid row index for the worksheet
                currentRow = worksheet.Rows(row + i)
                ' Make sure that the column indices are valid for your Excel worksheet
                currentRow.Cells(1).Value = list.SubItems(0).Text
                currentRow.Cells(2).Value = list.SubItems(1).Text
                currentRow.Cells(3).Value = list.SubItems(2).Text
                currentRow.Cells(4).Value = list.SubItems(3).Text
                currentRow.Cells(5).Value = list.SubItems(4).Text
                currentRow.Cells(6).Value = list.SubItems(5).Text
                currentRow.Cells(7).Value = list.SubItems(6).Text
                currentRow.Cells(8).Value = list.SubItems(7).Text
                currentRow.Cells(9).Value = list.SubItems(8).Text
                currentRow.Cells(10).Value = list.SubItems(9).Text
                currentRow.Cells(11).Value = list.SubItems(10).Text
                currentRow.Cells(12).Value = list.SubItems(11).Text
                currentRow.Cells(13).Value = list.SubItems(12).Text


            Else
                ' Handle the case where the index is out of range
                ' (Optional depending on your requirements)
                Console.WriteLine($"Index {i} is out of range.")
            End If
        Next
        Me.workbook = workbook1
    End Sub

    Public Sub deliverPrint()
        Dim stream As New IO.MemoryStream(My.Resources.Format_Delivers)
        Dim workbook1 = ExcelFile.Load(stream)
        Dim numberOfItems As Integer = FormDelivery.LvReportsSale.Items.Count
        Dim startDate = DateTime.Today.AddDays(-numberOfItems)
        Dim endDate = DateTime.Today

        ' Get template sheet.
        Dim worksheet = workbook1.Worksheets(0)

        ' Find cells with placeholder text and set their values.
        Dim row As Integer, column As Integer
        If worksheet.Cells.FindText("[Date]", row, column) Then
            Dim currentDate As Date = DateTime.Now
            Dim formattedDate As String = currentDate.ToString("MMMM dd, yyyy")

            worksheet.Cells(row, column).Value = formattedDate

        End If


        ' Copy template row.
        row = 17
        worksheet.Rows.InsertCopy(row + 1, numberOfItems - 1, worksheet.Rows(row))
        Dim currentRow As ExcelRow
        Dim random As New Random()
        For i As Integer = 0 To numberOfItems - 1
            ' Check if the index is within the range of items
            If i < FormDelivery.LvReportsSale.Items.Count Then
                Dim list = FormDelivery.LvReportsSale.Items(i)

                ' Assuming worksheet is an instance of the ExcelWorksheet class
                ' Make sure that 'row + i' is a valid row index for the worksheet
                currentRow = worksheet.Rows(row + i)
                ' Make sure that the column indices are valid for your Excel worksheet
                currentRow.Cells(1).Value = list.SubItems(0).Text
                currentRow.Cells(2).Value = list.SubItems(1).Text
                currentRow.Cells(3).Value = list.SubItems(2).Text
                currentRow.Cells(4).Value = list.SubItems(3).Text
                currentRow.Cells(5).Value = list.SubItems(4).Text
                currentRow.Cells(6).Value = list.SubItems(5).Text
                currentRow.Cells(7).Value = list.SubItems(6).Text
                currentRow.Cells(8).Value = list.SubItems(7).Text
                currentRow.Cells(9).Value = list.SubItems(8).Text
                currentRow.Cells(10).Value = list.SubItems(9).Text
                currentRow.Cells(11).Value = list.SubItems(10).Text
                currentRow.Cells(12).Value = list.SubItems(11).Text
                currentRow.Cells(13).Value = list.SubItems(12).Text
                currentRow.Cells(14).Value = list.SubItems(13).Text

            Else
                ' Handle the case where the index is out of range
                ' (Optional depending on your requirements)
                Console.WriteLine($"Index {i} is out of range.")
            End If
        Next
        Me.workbook = workbook1
    End Sub
    Public Sub expiredPrint()
        Dim stream As New IO.MemoryStream(My.Resources.Format_Expired)
        Dim workbook1 = ExcelFile.Load(stream)
        Dim numberOfItems As Integer = FormExpiredProducts.LvReportsExpirees.Items.Count
        Dim startDate = DateTime.Today.AddDays(-numberOfItems)
        Dim endDate = DateTime.Today

        ' Get template sheet.
        Dim worksheet = workbook1.Worksheets(0)

        ' Find cells with placeholder text and set their values.
        Dim row As Integer, column As Integer
        If worksheet.Cells.FindText("[Date]", row, column) Then
            Dim currentDate As Date = DateTime.Now
            Dim formattedDate As String = currentDate.ToString("MMMM dd, yyyy")

            worksheet.Cells(row, column).Value = formattedDate

        End If


        ' Copy template row.
        row = 17
        worksheet.Rows.InsertCopy(row + 1, numberOfItems - 1, worksheet.Rows(row))
        Dim currentRow As ExcelRow
        Dim random As New Random()
        For i As Integer = 0 To numberOfItems - 1
            ' Check if the index is within the range of items
            If i < FormExpiredProducts.LvReportsExpirees.Items.Count Then
                Dim list = FormExpiredProducts.LvReportsExpirees.Items(i)

                ' Assuming worksheet is an instance of the ExcelWorksheet class
                ' Make sure that 'row + i' is a valid row index for the worksheet
                currentRow = worksheet.Rows(row + i)
                ' Make sure that the column indices are valid for your Excel worksheet
                currentRow.Cells(1).Value = list.SubItems(0).Text
                currentRow.Cells(2).Value = list.SubItems(1).Text
                currentRow.Cells(3).Value = list.SubItems(2).Text
                currentRow.Cells(4).Value = list.SubItems(3).Text
                currentRow.Cells(5).Value = list.SubItems(4).Text
                currentRow.Cells(6).Value = list.SubItems(5).Text
                currentRow.Cells(7).Value = list.SubItems(6).Text
                currentRow.Cells(8).Value = list.SubItems(7).Text
                currentRow.Cells(9).Value = list.SubItems(8).Text
            Else
                ' Handle the case where the index is out of range
                ' (Optional depending on your requirements)
                Console.WriteLine($"Index {i} is out of range.")
            End If
        Next
        Me.workbook = workbook1
    End Sub
    Public Sub damagedPrint()
        Dim stream As New IO.MemoryStream(My.Resources.Format_Damaged)
        Dim workbook1 = ExcelFile.Load(stream)
        Dim numberOfItems As Integer = FormDamages.LvReportsDamages.Items.Count
        Dim startDate = DateTime.Today.AddDays(-numberOfItems)
        Dim endDate = DateTime.Today

        ' Get template sheet.
        Dim worksheet = workbook1.Worksheets(0)

        ' Find cells with placeholder text and set their values.
        Dim row As Integer, column As Integer
        If worksheet.Cells.FindText("[Date]", row, column) Then
            Dim currentDate As Date = DateTime.Now
            Dim formattedDate As String = currentDate.ToString("MMMM dd, yyyy")

            worksheet.Cells(row, column).Value = formattedDate

        End If


        ' Copy template row.
        row = 17
        worksheet.Rows.InsertCopy(row + 1, numberOfItems - 1, worksheet.Rows(row))
        Dim currentRow As ExcelRow
        Dim random As New Random()
        For i As Integer = 0 To numberOfItems - 1
            ' Check if the index is within the range of items
            If i < FormDamages.LvReportsDamages.Items.Count Then
                Dim list = FormDamages.LvReportsDamages.Items(i)

                ' Assuming worksheet is an instance of the ExcelWorksheet class
                ' Make sure that 'row + i' is a valid row index for the worksheet
                currentRow = worksheet.Rows(row + i)
                ' Make sure that the column indices are valid for your Excel worksheet
                currentRow.Cells(1).Value = list.SubItems(0).Text
                currentRow.Cells(2).Value = list.SubItems(1).Text
                currentRow.Cells(3).Value = list.SubItems(2).Text
                currentRow.Cells(4).Value = list.SubItems(3).Text
                currentRow.Cells(5).Value = list.SubItems(4).Text
                currentRow.Cells(6).Value = list.SubItems(5).Text
                currentRow.Cells(7).Value = list.SubItems(6).Text
                currentRow.Cells(8).Value = list.SubItems(7).Text
                currentRow.Cells(9).Value = list.SubItems(8).Text
                currentRow.Cells(10).Value = list.SubItems(9).Text
            Else
                ' Handle the case where the index is out of range
                ' (Optional depending on your requirements)
                Console.WriteLine($"Index {i} is out of range.")
            End If
        Next
        Me.workbook = workbook1
    End Sub
    Public Sub inventoryPrint()
        Dim stream As New IO.MemoryStream(My.Resources.Format_Inventory)
        Dim workbook1 = ExcelFile.Load(stream)
        Dim numberOfItems As Integer = FormStockInventory.LvProducts.Items.Count
        Dim startDate = DateTime.Today.AddDays(-numberOfItems)
        Dim endDate = DateTime.Today

        ' Get template sheet.
        Dim worksheet = workbook1.Worksheets(0)
        ' Find cells with placeholder text and set their values.
        Dim row As Integer, column As Integer
        If worksheet.Cells.FindText("[Date]", row, column) Then
            Dim currentDate As Date = DateTime.Now
            Dim formattedDate As String = currentDate.ToString("MMMM dd, yyyy")

            worksheet.Cells(row, column).Value = formattedDate

        End If


        ' Copy template row.
        row = 17
        worksheet.Rows.InsertCopy(row + 1, numberOfItems - 1, worksheet.Rows(row))
        Dim currentRow As ExcelRow
        Dim random As New Random()
        For i As Integer = 0 To numberOfItems - 1
            ' Check if the index is within the range of items
            If i < FormStockInventory.LvProducts.Items.Count Then
                Dim list = FormStockInventory.LvProducts.Items(i)

                ' Assuming worksheet is an instance of the ExcelWorksheet class
                ' Make sure that 'row + i' is a valid row index for the worksheet
                currentRow = worksheet.Rows(row + i)
                ' Make sure that the column indices are valid for your Excel worksheet
                currentRow.Cells(1).Value = list.SubItems(0).Text
                currentRow.Cells(2).Value = list.SubItems(1).Text
                currentRow.Cells(3).Value = list.SubItems(2).Text
                currentRow.Cells(4).Value = list.SubItems(3).Text
                currentRow.Cells(5).Value = list.SubItems(4).Text
                currentRow.Cells(6).Value = list.SubItems(5).Text
                currentRow.Cells(7).Value = list.SubItems(6).Text
                currentRow.Cells(8).Value = list.SubItems(7).Text
                currentRow.Cells(9).Value = list.SubItems(8).Text
                currentRow.Cells(10).Value = list.SubItems(9).Text
                currentRow.Cells(11).Value = list.SubItems(10).Text
            Else
                ' Handle the case where the index is out of range
                ' (Optional depending on your requirements)
                Console.WriteLine($"Index {i} is out of range.")
            End If
        Next
        Me.workbook = workbook1
    End Sub
    Public Sub logsPrint()
        Dim stream As New IO.MemoryStream(My.Resources.Format_Logs)
        Dim workbook1 = ExcelFile.Load(stream)
        Dim numberOfItems As Integer = FormLogs.DataGridView1.Rows.Count
        If numberOfItems > 140 Then
            numberOfItems = 140
        End If
        Dim startDate = DateTime.Today.AddDays(-numberOfItems)
        Dim endDate = DateTime.Today

        ' Get template sheet.
        Dim worksheet = workbook1.Worksheets(0)

        ' Find cells with placeholder text and set their values.
        Dim row As Integer, column As Integer
        If worksheet.Cells.FindText("[Date]", row, column) Then
            Dim currentDate As Date = DateTime.Now
            Dim formattedDate As String = currentDate.ToString("MMMM dd, yyyy")

            worksheet.Cells(row, column).Value = formattedDate

        End If


        ' Copy template row.
        row = 17
        worksheet.Rows.InsertCopy(row + 1, numberOfItems - 1, worksheet.Rows(row))
        Dim currentRow As ExcelRow
        Dim random As New Random()
        For i As Integer = 0 To numberOfItems - 1
            ' Check if the index is within the range of items
            If i < FormLogs.DataGridView1.Rows.Count Then
                Dim list = FormLogs.DataGridView1.Rows(i)

                ' Assuming worksheet is an instance of the ExcelWorksheet class
                ' Make sure that 'row + i' is a valid row index for the worksheet
                currentRow = worksheet.Rows(row + i)
                ' Make sure that the column indices are valid for your Excel worksheet
                currentRow.Cells(1).Value = list.Cells(0).Value
                currentRow.Cells(2).Value = list.Cells(1).Value
                currentRow.Cells(3).Value = list.Cells(2).Value
                currentRow.Cells(4).Value = list.Cells(3).Value
                currentRow.Cells(5).Value = list.Cells(4).Value
            Else
                ' Handle the case where the index is out of range
                ' (Optional depending on your requirements)
                Console.WriteLine($"Index {i} is out of range.")
            End If
        Next
        Me.workbook = workbook1
    End Sub
    Public Sub InsertItemsPrint(receivedValue As String)
        Try
            If receivedValue = "sales" Then
                salesPrint()
            ElseIf receivedValue = "returns" Then
                returnsPrint()
            ElseIf receivedValue = "deliver" Then
                deliverPrint()
            ElseIf receivedValue = "inventory" Then
                inventoryPrint()
            ElseIf receivedValue = "expired" Then
                expiredPrint()
            ElseIf receivedValue = "damaged" Then
                damagedPrint()
            ElseIf receivedValue = "logs" Then
                logsPrint()
            End If
        Catch

        End try

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnExit_Click_1(sender As Object, e As EventArgs) Handles BtnExit.Click

        Me.Close()
    End Sub

    Private Sub printPreviewControl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnZoomIn_Click(sender As Object, e As EventArgs) Handles btnZoomIn.Click
        If printPreviewControl.Zoom >= 2 Then
            btnZoomIn.Enabled = False
        Else
            printPreviewControl.Zoom = printPreviewControl.Zoom + 0.2
            btnZoomOut.Enabled = True
            If printPreviewControl.Zoom >= 2 Then
                btnZoomIn.Enabled = False
            End If
        End If

    End Sub

    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) Handles btnZoomOut.Click
        If printPreviewControl.Zoom <= 0.4 Then
            btnZoomOut.Enabled = False
        Else
            printPreviewControl.Zoom = printPreviewControl.Zoom - 0.2
            btnZoomIn.Enabled = True
            If printPreviewControl.Zoom <= 0.4 Then
                btnZoomOut.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtPDF_Click(sender As Object, e As EventArgs) Handles txtPDF.Click
        'Dim dateYear As String = MainMenu.dateToday.Chars(3) & MainMenu.dateToday.Chars(4) & "20" & MainMenu.dateToday.Chars(8) & MainMenu.dateToday.Chars(9)
        Dim currentDate As DateTime = DateTime.Now
        Dim numericDateString As String = currentDate.ToString("yyyyMMdd")
        Dim numericDateStringYear As String = currentDate.ToString("MMMMyyyy")
        Dim finalLocation As String = path + "\Inventory Output Folder\Files\" & printType & "\" & numericDateStringYear
        If Not System.IO.Directory.Exists(finalLocation) Then
            System.IO.Directory.CreateDirectory(finalLocation)
        End If

        If MsgBox("Do you want to download this Record?", MsgBoxStyle.YesNo, "Edit Record") = vbYes Then
            Try

                Dim files As String() = Directory.GetFiles(finalLocation)
                Dim fileCount As Integer = 0 + files.Length + 1
                Me.workbook.Save(finalLocation & "\" & numericDateString & "-" & fileCount & ".pdf")
                MsgBox("Saved as PDF! Location: " & finalLocation & vbNewLine & "Entry Saved to Database!", MsgBoxStyle.Information, "Success!")
            Catch
                MsgBox("Close the 'Output' file before saving!", MsgBoxStyle.Exclamation, "Error")
            End Try


        Else
            MsgBox("Aborted!")
        End If
    End Sub

    Private Sub PrintFileMenuItem_Click(sender As Object, e As EventArgs) Handles PrintFileMenuItem.Click
        If Me.workbook Is Nothing Then Return

        Dim printDialog As New PrintDialog() With {.AllowSomePages = True}
        If (printDialog.ShowDialog() = DialogResult.OK) Then
            If MsgBox("Do you want to download this Record?", MsgBoxStyle.YesNo, "Edit Record") = vbYes Then

                Dim printerSettings As PrinterSettings = printDialog.PrinterSettings
                Dim printOptions As New PrintOptions() With {.SelectionType = SelectionType.EntireFile}

                ' Set PrintOptions properties based on PrinterSettings properties.
                printOptions.CopyCount = printerSettings.Copies
                printOptions.FromPage = If(printerSettings.FromPage = 0, 0, printerSettings.FromPage - 1)
                printOptions.ToPage = If(printerSettings.ToPage = 0, Integer.MaxValue, printerSettings.ToPage - 1)

                Me.workbook.Print(printerSettings.PrinterName, printOptions)
                MsgBox("Printing Accepted" & vbNewLine & "Entry Saved to Database!", MsgBoxStyle.Information, "Success!")
            Else
                MsgBox("Aborted!")
            End If
        End If
    End Sub

    Private Sub PageUpDown_ValueChanged(sender As Object, e As EventArgs) Handles PageUpDown.ValueChanged
        Try
            Me.printPreviewControl.StartPage = Me.PageUpDown.Value - 1
        Catch
            Me.printPreviewControl.StartPage = 1
        End Try
    End Sub
End Class