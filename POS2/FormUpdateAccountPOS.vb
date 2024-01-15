Imports System.Data.SqlClient

Public Class FormUpdateAccountPOS
    Public currentUser As User
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"

    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString

    Private Sub FormUpdateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbUAPassword.UseSystemPasswordChar = True
        TbUAPassword.Select()
        tbNewPassword.UseSystemPasswordChar = True
        tbNewPassword.Select()
        tbConfirmPassword.UseSystemPasswordChar = True
        tbConfirmPassword.Select()
        TbUAPassword.Clear()
        tbNewPassword.Clear()
        tbConfirmPassword.Clear()
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub BtnFormUASave_Click(sender As Object, e As EventArgs) Handles BtnFormUASave.Click

        Dim username As String = TbUAUsername.Text.Trim()
        Dim currentPassword As String = TbUAPassword.Text.Trim()
        Dim newPassword As String = tbNewPassword.Text.Trim()
        If tbNewPassword.Text = tbConfirmPassword.Text Then
            If UpdatePassword(username, currentPassword, newPassword) Then
                MessageBox.Show("Password updated successfully!")
                TbUAPassword.Clear()
                tbNewPassword.Clear()
                tbConfirmPassword.Clear()

            Else
                MessageBox.Show("Failed to update the password. Please check your credentials.")
                TbUAPassword.Clear()
                tbNewPassword.Clear()
                tbConfirmPassword.Clear()
            End If
        Else
            MessageBox.Show("Failed to update the password. Please check your credentials.")
            TbUAPassword.Clear()
            tbNewPassword.Clear()
            tbConfirmPassword.Clear()
        End If



    End Sub

    Private Function UpdatePassword(username As String, currentPassword As String, newPassword As String) As Boolean
        Dim isUpdated As Boolean = False

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "UPDATE users SET password = @NewPassword WHERE username = @Username AND password = @CurrentPassword"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@NewPassword", newPassword)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@CurrentPassword", currentPassword)

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                isUpdated = True
            End If
        End Using

        Return isUpdated
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
            tbNewPassword.UseSystemPasswordChar = True
            tbConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class