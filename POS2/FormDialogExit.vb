Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class FormDialogExit
    Dim user As User
    Dim dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    'Dim connectionString As String = "Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = " + dbPath + "\database\" + dbName + "; Integrated Security=True; Connect Timeout = 30"
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Private Sub FormDialogExit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user = UserSession.SignedInUser
    End Sub
    Private Sub BtnExitDialogCancel_Click(sender As Object, e As EventArgs) Handles BtnExitDialogCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnExitDialogConfirm_Click(sender As Object, e As EventArgs) Handles BtnExitDialogConfirm.Click
        If dbHandler.AddLog(False, user) Then
            UserSession.SignedInUser = Nothing
            Me.Close()
            Me.Dispose()
            FormPOS.Close()
            FormMain.Close()
            conn1.Open()

            ' SQL query to insert data into the table
            Dim query As String = "INSERT INTO Logs ([Part], [Action], [Users], [Date], [Time]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"

            ' Create a SqlCommand object
            Dim command As New SqlCommand(query, conn1)

            ' Bind parameters with textbox values
            command.Parameters.AddWithValue("@Value1", "Admin")
            command.Parameters.AddWithValue("@Value2", "Logout")
            command.Parameters.AddWithValue("@Value3", FormLogin.TbUsername.Text)
            command.Parameters.AddWithValue("@Value4", FormLogin.ToolStripStatusLabel5.Text)
            command.Parameters.AddWithValue("@Value5", FormLogin.ToolStripStatusLabel2.Text)
            command.ExecuteNonQuery()


            conn1.Close()
            FormLogin.Show()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class