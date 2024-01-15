Imports System.Data.SqlClient
Imports Mysqlx
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormLogin
    Dim dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"

    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString

  
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbPassword.UseSystemPasswordChar = True
        TbUsername.Select()

        Timer1.Start()
        Me.ToolStripStatusLabel2.Text = DateTime.Now.ToString("D")
        Me.ToolStripStatusLabel5.Text = DateTime.Now.ToString("hh:mm:ss tt")
        If CbShowPassword.Checked = True Then
            CbShowPassword.BackgroundImage = My.Resources.eyecon

        Else
            CbShowPassword.BackgroundImage = My.Resources.eyecon1
        End If
    End Sub


    'My.Computer.FileSystem.CopyFile("C:\Users\Home\source\repos\POS2\POS2\Resources\bg.jpg", "C:\Users\Home\source\repos\bg.jpg",
    '    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

    Private Sub Signin(username As String, password As String)
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter a valid username and password.")
            Return
        End If

        Dim user As User = dbHandler.GetEmployeeByUsername(username)

        If (user IsNot Nothing) Then
            If (String.Equals(user.Password, password, StringComparison.Ordinal)) AndAlso (String.Equals(user.Username, username, StringComparison.Ordinal)) Then
                UserSession.SignedInUser = user
                If dbHandler.IsAdmin(user.Role) Then
                    FormPOS.lblCurrentUser.Text = ""
                    FormPOS.lblCurrentUser.Text = TbUsername.Text
                    FormMain.Show()
                    Me.Hide()
                    conn1.Open()

                    ' SQL query to insert data into the table
                    Dim query As String = "INSERT INTO Logs ([Part], [Action], [Users], [Date], [Time]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"

                    ' Create a SqlCommand object
                    Dim command As New SqlCommand(query, conn1)

                    ' Bind parameters with textbox values
                    command.Parameters.AddWithValue("@Value1", "Admin")
                    command.Parameters.AddWithValue("@Value2", "Login")
                    command.Parameters.AddWithValue("@Value3", TbUsername.Text)
                    command.Parameters.AddWithValue("@Value4", ToolStripStatusLabel5.Text)
                    command.Parameters.AddWithValue("@Value5", ToolStripStatusLabel2.Text)
                    command.ExecuteNonQuery()



                    conn1.Close()
                Else
                    FormPOS.lblCurrentUser.Text = ""
                    FormPOS.lblCurrentUser.Text = TbUsername.Text
                    FormPOS.Show()
                    Me.Hide()
                    conn1.Open()

                    ' SQL query to insert data into the table
                    Dim query As String = "INSERT INTO Logs ([Part], [Action], [Users], [Date], [Time]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"

                    ' Create a SqlCommand object
                    Dim command As New SqlCommand(query, conn1)

                    ' Bind parameters with textbox values
                    command.Parameters.AddWithValue("@Value1", "User")
                    command.Parameters.AddWithValue("@Value2", "Login")
                    command.Parameters.AddWithValue("@Value3", TbUsername.Text)
                    command.Parameters.AddWithValue("@Value4", ToolStripStatusLabel5.Text)
                    command.Parameters.AddWithValue("@Value5", ToolStripStatusLabel2.Text)
                    command.ExecuteNonQuery()


                    conn1.Close()
                End If

                TbPassword.Text = ""
                dbHandler.AddLog(True, user)
            Else
                MessageBox.Show("Incorrect username or password.")
                TbPassword.Clear()
                conn1.Open()

                ' SQL query to insert data into the table
                Dim query As String = "INSERT INTO Logs ([Part], [Action], [Users], [Date], [Time]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"

                ' Create a SqlCommand object
                Dim command As New SqlCommand(query, conn1)

                ' Bind parameters with textbox values
                command.Parameters.AddWithValue("@Value1", "N/A")
                command.Parameters.AddWithValue("@Value2", "Login Error")
                command.Parameters.AddWithValue("@Value3", TbUsername.Text)
                command.Parameters.AddWithValue("@Value4", ToolStripStatusLabel5.Text)
                command.Parameters.AddWithValue("@Value5", ToolStripStatusLabel2.Text)
                command.ExecuteNonQuery()


                ' Execute the query

                conn1.Close()
            End If
        Else
            conn1.Open()

            ' SQL query to insert data into the table
            Dim query As String = "INSERT INTO Logs ([Part], [Action], [Users], [Date], [Time]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)"

            ' Create a SqlCommand object
            Dim command As New SqlCommand(query, conn1)

            ' Bind parameters with textbox values
            command.Parameters.AddWithValue("@Value1", "N/A")
            command.Parameters.AddWithValue("@Value2", "Invalid User")
            command.Parameters.AddWithValue("@Value3", TbUsername.Text)
            command.Parameters.AddWithValue("@Value4", ToolStripStatusLabel5.Text)
            command.Parameters.AddWithValue("@Value5", ToolStripStatusLabel2.Text)
            command.ExecuteNonQuery()

            ' Execute the query
            command.ExecuteNonQuery()
            MessageBox.Show("User not found.")
            TbPassword.Clear()

            conn1.Close()
        End If

    End Sub

    Private Sub TbUsername_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar = Chr(13)) Then
            TbPassword.Select()
        End If
    End Sub

    Private Sub TbPassword_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar = Chr(13)) Then
            Signin(TbUsername.Text, TbPassword.Text)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Enabled = False
        FormForgotPassword.Show()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = DateTime.Now.ToString("D")
        ToolStripStatusLabel5.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub BtnSignin_Click_1(sender As Object, e As EventArgs) Handles BtnSignin.Click
        Signin(TbUsername.Text, TbPassword.Text)
    End Sub

    Private Sub TbPassword_TextChanged(sender As Object, e As EventArgs) Handles TbPassword.TextChanged

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormForgotPassword.Show()
    End Sub

    Private Sub CbShowPassword_CheckedChanged_1(sender As Object, e As EventArgs) Handles CbShowPassword.CheckedChanged
        If CbShowPassword.Checked = True Then
            CbShowPassword.BackgroundImage = My.Resources.eyecon

        Else
            CbShowPassword.BackgroundImage = My.Resources.eyecon1
        End If
        If CbShowPassword.CheckState = CheckState.Checked Then
            TbPassword.UseSystemPasswordChar = False
            TbPassword.Select()
        Else
            TbPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
