Imports System.Data.SqlClient

Public Class FormUpdateAccount
    Public currentUser As User
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"

    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString

    Private Sub FormUpdateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateFields()
        TbUAPassword.UseSystemPasswordChar = True
        TbUAPassword.Select()
        tbNewPassword.UseSystemPasswordChar = True
        tbNewPassword.Select()
        tbConfirmPassword.UseSystemPasswordChar = True
        tbConfirmPassword.Select()
    End Sub

    Public Sub New(user As User)
        InitializeComponent()
        Me.currentUser = user
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub PopulateFields()
        TbUAUsername.Text = currentUser.Username
        TbUAPassword.Text = currentUser.Password
        CbUARole.Text = currentUser.Role
    End Sub

    Private Sub BtnFormUASave_Click(sender As Object, e As EventArgs) Handles BtnFormUASave.Click


        Dim username As String = TbUAUsername.Text.Trim()
        Dim password As String = TbUAPassword.Text.Trim()

        If AuthenticateUser(username, password) Then
            If tbNewPassword.Text <> tbConfirmPassword.Text Then
                MessageBox.Show("New Password Doesn't Match or Empty")
            Else
                Dim user As New User With {
              .Id = currentUser.Id,
              .Username = TbUAUsername.Text,
              .Password = tbNewPassword.Text,
              .Role = CbUARole.Text
          }
                If dbHandler.UpdateUser(user) Then
                    MessageBox.Show("User information updated.")
                    FormAccountSettings.PopulateListView()
                    Me.Close()
                End If
            End If

        Else
            MessageBox.Show("Wrong Old Password")
        End If



    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim isAuthenticated As Boolean = False

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim cmd As New SqlCommand With {
                .Connection = connection,
                .CommandText = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password"
            }
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            If dt.Rows.Count() > 0 Then
                isAuthenticated = True
            End If
        End Using

        Return isAuthenticated
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            TbUAPassword.UseSystemPasswordChar = False
            TbUAPassword.Select()
            tbNewPassword.UseSystemPasswordChar = False
            tbNewPassword.Select()
            tbConfirmPassword.UseSystemPasswordChar = False
            tbConfirmPassword.Select()
        Else
            TbUAPassword.UseSystemPasswordChar = True
            TbUAPassword.Select()
            tbNewPassword.UseSystemPasswordChar = True
            tbConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class