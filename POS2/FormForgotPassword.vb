Imports OracleInternal
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Imports System.IO
Imports System.Text.RegularExpressions
Imports iTextSharp.text.xml.simpleparser

Public Class FormForgotPassword

    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    Dim dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString


    Private Function CheckUser(username As String) As Boolean

        Dim user As User = dbHandler.GetEmployeeByUsername(username)

        If user IsNot Nothing Then
            If user.Role.ToString() = "admin" Then
                MsgBox("Cannot change admin Password!")
                Return False
            Else
                Return True
            End If

        Else
            MsgBox("No User Found!", MsgBoxStyle.Critical, "Error!")
            Return False
        End If


    End Function
    Public Sub PopulateQuestion()
        Dim securityQuestion As String
        Dim query As String = "SELECT * FROM users"
        Using connection As New SqlConnection(dbHandler.getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@name", tbSignupUsername.Text)
                Using adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim table As DataTable = New DataTable()
                    adapter.Fill(table)
                    For a As Integer = 0 To table.Rows.Count() - 1
                        securityQuestion = table.Rows(a).Item(4).ToString
                        If Not cbquestion.Items.Contains("-") Then
                            cbquestion.Items.Add("-")
                        End If
                        If Not CbQuestion.Items.Contains(table.Rows(a).Item(4).ToString) Then
                            CbQuestion.Items.Add(table.Rows(a).Item(4).ToString)
                        End If
                    Next

                End Using
            End Using
            connection.Close()
        End Using
    End Sub
    Private Function CheckSecretAnswer() As Boolean
        Dim securityQuestion As String
        Dim answer As String
        Dim query As String = "SELECT * FROM users WHERE username = @name"
        Using connection As New SqlConnection(dbHandler.getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@name", tbSignupUsername.Text)
                Using adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim table As DataTable = New DataTable()
                    Try
                        adapter.Fill(table)
                        securityQuestion = table.Rows(0).Item(4).ToString
                        answer = table.Rows(0).Item(5).ToString
                        If securityQuestion = CbQuestion.Text And answer = TxtAnswer.Text Then
                            Return True
                        Else
                            Return False
                        End If


                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
            connection.Close()
        End Using

    End Function

    Private Sub FormForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateQuestion()
    End Sub
    Public Sub RefreshUI()

    End Sub


    Private Sub changepass(username As String, secretquestion As String, answer As String)

        Dim user As User = dbHandler.GetaccountByUsername(username)

        If (user IsNot Nothing) Then
            If (String.Equals(user.Username, username, StringComparison.Ordinal)) AndAlso (String.Equals(user.Answer, answer, StringComparison.Ordinal)) AndAlso (String.Equals(user.Secretquestion, secretquestion, StringComparison.Ordinal)) Then
                ' Code to execute if the conditions are met

                BtnClearAllFields.Visible = False

                BtnCheck.Visible = True
                CbShowPassword.Visible = True
                TxtNPassword.Visible = True
                TxtCPassword.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                TxtAnswer.Enabled = False
                CbQuestion.Enabled = False
                tbSignupUsername.Enabled = False
            Else
                MsgBox("Invalid credentials")
            End If
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        If tbSignupUsername.TextLength = 0 Then
            MsgBox("Fill the Username textbox")
        Else
            If CheckUser(tbSignupUsername.Text) = True Then
                If CheckSecretAnswer() = True Then
                    MsgBox("Security Question and Answer Valid", MsgBoxStyle.Information, "Valid")
                    GroupBox2.Enabled = False
                    GroupBox1.Enabled = True
                    TxtAnswer.Enabled = True
                    cbquestion.Enabled = True
                    tbSignupUsername.Enabled = True
                Else
                    MsgBox("Wrong Security Question or Answer!", MsgBoxStyle.Critical, "Error!")
                End If
            End If
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Hide()
        FormLogin.Enabled = True
        FormLogin.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnClearAllFields_Click(sender As Object, e As EventArgs) Handles BtnClearAllFields.Click
        TxtNPassword.Clear()
        TxtCPassword.Clear()
    End Sub

    Private Sub CbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CbShowPassword.CheckedChanged
        If CbShowPassword.Checked = True Then
            CbShowPassword.BackgroundImage = My.Resources.eyecon

        Else
            CbShowPassword.BackgroundImage = My.Resources.eyecon1
        End If
        If CbShowPassword.CheckState = CheckState.Checked Then
            TxtNPassword.UseSystemPasswordChar = False
            TxtNPassword.Select()
            TxtCPassword.UseSystemPasswordChar = False
            TxtCPassword.Select()
        Else
            TxtNPassword.UseSystemPasswordChar = True
            TxtCPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        If Not String.IsNullOrEmpty(TxtNPassword.Text) And Not String.IsNullOrEmpty(TxtCPassword.Text) Then
            If TxtNPassword.Text = TxtCPassword.Text Then
                If TxtNPassword.Text.Length > 6 And TxtCPassword.Text.Length > 6 Then
                    ' Update the user's password in the database
                    Dim query As String = "UPDATE users SET password = @pass WHERE username = @user"
                    conn1.Open()
                    Using cmd As SqlCommand = New SqlCommand(query, conn1)
                        cmd.Parameters.AddWithValue("@user", tbSignupUsername.Text)
                        cmd.Parameters.AddWithValue("@pass", TxtNPassword.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                    conn1.Close()
                    MsgBox("Update sucessfully")

                    GroupBox1.Enabled = False
                    GroupBox2.Enabled = True
                    TxtAnswer.Clear()
                    cbquestion.SelectedIndex = 0
                    TxtNPassword.Clear()
                    TxtCPassword.Clear()
                    tbSignupUsername.Clear()
                Else
                    MsgBox("Password must be greater then 6 characters!", MsgBoxStyle.Critical, "Error!")
                End If
            Else
                MsgBox("New Password and Confirm Password are not the same!", MsgBoxStyle.Critical, "Error!")
            End If
        Else
            MsgBox("Input New Password!", MsgBoxStyle.Critical, "Error!")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


    Private Sub TxtAnswer_TextChanged(sender As Object, e As EventArgs) Handles TxtAnswer.TextChanged

    End Sub

    Private Sub cbquestion_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbquestion.SelectedIndexChanged
        PopulateQuestion()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class