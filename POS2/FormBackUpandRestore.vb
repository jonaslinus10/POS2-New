Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.IO
Imports iText.IO
Imports iText.Kernel.Pdf.Colorspace.PdfPattern.Tiling
Imports Nevron.Nov.UI

Public Class FormBackupAndRestore
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    Dim conn As New SqlConnection(dbHandler.getConnectionString())
    ReadOnly dbPath1 As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    Dim dbName1 As String = ""
    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)


    Public Sub New()
        InitializeComponent()
        ' Initialize the initial database connection
        ChangeDatabase("initial_database.mdf")
    End Sub

    Public Sub ChangeDatabase(databaseName As String)
        ' Update the database file name and connection string
        dbName1 = databaseName

    End Sub

    Private Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles BtnRestore.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "SQL Backup Files (*.mdf)|*.mdf|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        Dim currentDate As DateTime = DateTime.Now
        Dim numericDateString As String = currentDate.ToString("yyyyMMdd")
        Dim numericDateStringYear As String = currentDate.ToString("MMMMyyyy")

        Dim backupFilePath As String = path + "\Inventory Output Folder\Files\Backups\" & numericDateStringYear
        If Not System.IO.Directory.Exists(backupFilePath) Then
            System.IO.Directory.CreateDirectory(backupFilePath)
        End If
        openFileDialog1.InitialDirectory = backupFilePath

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog1.FileName
            Dim fileName As String = System.IO.Path.GetFileName(openFileDialog1.FileName)
            Try

                Dim connectionString As String = "Data Source= MIKAYSSII\SQLEXPRESS;USER= admin;PASSWORD= hardware12345;"
                Dim conn1 As New SqlConnection(connectionString)
                conn1.Open()

                ' Perform any necessary restore operations using the connection
                ' Set database to offline mode
                Dim setDatabaseOfflineCommand As String = "USE master; ALTER DATABASE [HONEST_CITY_HARDWARE_DATA.MDF] SET SINGLE_USER WITH ROLLBACK IMMEDIATE"
                Dim sqlCommand As New SqlCommand(setDatabaseOfflineCommand, conn1)
                sqlCommand.ExecuteNonQuery() ' For example, you might want to execute a SQL restore command


                'Dim detachDatabaseCommand As String = String.Format("EXEC sp_detach_db @dbname = N'" & fileName & "'")
                'Dim cmd1 As New SqlCommand(detachDatabaseCommand, conn1)
                'cmd1.ExecuteNonQuery()

                conn1.Close()
                MessageBox.Show("Restoring Database....")
                Try
                    conn1.Close()
                    conn1.Open()
                    Dim attachDatabaseCommand As String = String.Format("USE [master]; RESTORE DATABASE [HONEST_CITY_HARDWARE_DATA.MDF] FROM  DISK = N'" & filePath & "' WITH  FILE = 1,  NOUNLOAD,  STATS = 5")
                    '"BACKUP DATABASE [" & ComboBox1.Text & "] TO DISK='" & backupFilePath & "'", conn
                    '"USE master; CREATE DATABASE [" & filePath & "] ON ( FILENAME = N'" & filePath & "' ) FOR ATTACH"
                    Dim sqlCommand1 = New SqlCommand(attachDatabaseCommand, conn1)
                    sqlCommand1.ExecuteNonQuery()


                    'conn1.Open()

                    '' Perform any necessary restore operations using the connection
                    '' For example, you might want to execute a SQL restore command
                    'Dim cmd2 As New SqlCommand("RESTORE DATABASE [" & fileName & "] FROM DISK='" & filePath & "'", conn)
                    'cmd2.ExecuteNonQuery()
                    MessageBox.Show("Database restored.")
                    conn1.Close()
                Catch ex As Exception
                    MsgBox("Error occurred during database restore1: " & ex.Message, MsgBoxStyle.Exclamation, "Supply Management System")
                Finally
                    conn1.Close()
                End Try
            Catch ex As Exception
                MsgBox("Error occurred during database restore2: " & ex.Message, MsgBoxStyle.Exclamation, "Supply Management System")
            Finally

            End Try
        End If

    End Sub

    Private Sub BtnBackUp_Click(sender As Object, e As EventArgs) Handles BtnBackUp.Click
        If ComboBox1.Text = "Select database" Then
            MessageBox.Show("Please select a database.")
            Return
        End If

        SaveFileDialog1.FileName = ComboBox1.SelectedItem.ToString()
        SaveFileDialog1.Filter = "Backup Files (*.mdf)|*.mdf|All Files (*.*)|*.*"
        Dim currentDate As DateTime = DateTime.Now
        Dim numericDateString As String = currentDate.ToString("yyyyMMdd")
        Dim numericDateStringYear As String = currentDate.ToString("MMMMyyyy")

        Dim backupFilePath As String = path + "\Inventory Output Folder\Files\Backups\" & numericDateStringYear
        If Not System.IO.Directory.Exists(backupFilePath) Then
            System.IO.Directory.CreateDirectory(backupFilePath)
        End If
        SaveFileDialog1.InitialDirectory = backupFilePath

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            backupFilePath = SaveFileDialog1.FileName
            MsgBox(backupFilePath)
            'Check If the backup file already exists
            If File.Exists(backupFilePath) Then
                If MessageBox.Show("The backup file already exists. Do you want to overwrite it?", "Backup File Exists", MessageBoxButtons.YesNo) = DialogResult.No Then
                    Return
                End If
            End If

            ' Perform the database backup
            Dim cmd2 As New SqlCommand("BACKUP DATABASE [" & ComboBox1.Text & "] TO DISK='" & backupFilePath & "'", conn)
            Try
                conn.Open()
                cmd2.ExecuteNonQuery()
                MessageBox.Show("Database backed up successfully.")
            Catch ex As Exception
                MessageBox.Show("Error occurred during backup: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub databases()
        ComboBox1.Items.Clear()

        Try
            conn.Open()
            Dim cmd1 As New SqlCommand("SELECT * FROM sys.databases ORDER BY name", conn)
            Dim myreader As SqlDataReader = cmd1.ExecuteReader()
            While myreader.Read
                ComboBox1.Items.Add(myreader("name").ToString())
            End While
            ComboBox1.Text = "Select database"
        Catch ex As Exception
            MessageBox.Show("Error occurred while retrieving databases: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub FormBackupAndRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databases()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> -1 AndAlso ComboBox1.SelectedItem.ToString() <> "Select database" Then
            BtnBackUp.Enabled = True
        Else
            BtnBackUp.Enabled = False
        End If
    End Sub
End Class
