Imports Mysqlx
Imports ServiceStack
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormSignup
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler

    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Hide()
    End Sub

    Private Sub BtnClearAllFields_Click(sender As Object, e As EventArgs) Handles BtnClearAllFields.Click
        ClearAllFields()
    End Sub

    Private Sub BtnSignup_Click(sender As Object, e As EventArgs) Handles BtnSignup.Click
        Signup()
        FormAccountSettings.RefreshUI()
    End Sub

    Private Sub ClearAllFields()
        cbSignupAccountType.Text = "Cashier"
        tbSignupUsername.Text = ""
        tbSignupPassword.Text = ""
        tbSignupConfirmPassword.Text = ""
    End Sub
    Private Function InfoValid() As Boolean
        Dim _utilities As Utitilies = New Utitilies
        'If (cbSignupAccountType.Text IsNot "Admin") Then
        'MessageBox.Show("Role does not exist", "Warning")
        'cbSignupAccountType.BackColor = Color.IndianRed
        'cbSignupAccountType.ForeColor = Color.White
        'Return False
        'ElseIf (cbSignupAccountType.Text IsNot "Cashier") Then
        'MessageBox.Show("Role does not exist", "Warning")
        'cbSignupAccountType.BackColor = Color.IndianRed
        'cbSignupAccountType.ForeColor = Color.White
        'Return False
        If (String.IsNullOrEmpty(tbSignupUsername.Text)) Then
            MessageBox.Show("Fields must not be null!", "Warning")
            tbSignupUsername.BackColor = Color.IndianRed
            Return False
        ElseIf (String.IsNullOrEmpty(tbSignupPassword.Text)) Then
            MessageBox.Show("Fields must not be null!", "Warning")
            tbSignupPassword.BackColor = Color.IndianRed
            Return False
        ElseIf (String.IsNullOrEmpty(tbSignupConfirmPassword.Text)) Then
            MessageBox.Show("Fields must not be null!", "Warning")
            tbSignupConfirmPassword.BackColor = Color.IndianRed
            Return False
            'ElseIf UserSession.SignedInUser.Role IsNot "admin" Then
            '   MessageBox.Show("Only admin can do this activity!", "Warning")
            '  Return False
        ElseIf (tbSignupUsername.Text.Length < 4) Then
            MessageBox.Show("Username too short!", "Warning")
            tbSignupUsername.BackColor = Color.OrangeRed
            Return False
        ElseIf (tbSignupPassword.Text.Length < 8) Then
            MessageBox.Show("Password too short!", "Warning")
            tbSignupPassword.BackColor = Color.OrangeRed
            tbSignupPassword.ForeColor = Color.White
            Return False
        ElseIf (tbSignupConfirmPassword.Text.Length < 8) Then
            MessageBox.Show("Password too short!", "Warning")
            tbSignupConfirmPassword.BackColor = Color.OrangeRed
            tbSignupConfirmPassword.ForeColor = Color.White
            Return False
        ElseIf (Not tbSignupPassword.Text = tbSignupConfirmPassword.Text) Then
            MessageBox.Show("Password do not match!", "Warning")
            tbSignupPassword.BackColor = Color.OrangeRed
            tbSignupPassword.ForeColor = Color.White
            tbSignupConfirmPassword.BackColor = Color.OrangeRed
            tbSignupConfirmPassword.ForeColor = Color.White
            Return False
        Else
            Return True
        End If
    End Function
    Public Function userIDGenerator() As String
        Using connection As New SqlConnection(dbHandler.getConnectionString)
            connection.Open()
            Dim cmd As New SqlCommand With {
            .Connection = connection,
            .CommandText = "SELECT * FROM users"
        }
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            Dim countSTR As String = "00" & (dt.Rows.Count() + 1)
            Dim myString As String = tbSignupUsername.Text
            Dim firstChar As Char
            Dim lastChar As Char
            If Not String.IsNullOrEmpty(myString) Then
                ' Get the first character
                firstChar = myString(0)
                ' Get the last character
                lastChar = myString(myString.Length - 1)
            End If
            Dim tempcbRoleString As String = cbSignupAccountType.Text
            Dim cbRoleString As String
            If tempcbRoleString = "Cashier" Then
                cbRoleString = "cas"
            Else
                cbRoleString = "adm"
            End If

            Dim finalstring As String = countSTR & firstChar & lastChar & cbRoleString

            Return finalstring
            connection.Close()
        End Using
    End Function
    Private Sub Signup()
        Dim _user As User

        If (InfoValid()) Then
            _user = New User With {
                .Id = userIDGenerator(),
                .Username = tbSignupUsername.Text,
                .Password = tbSignupPassword.Text,
                .Role = cbSignupAccountType.Text.ToLower,
                .Secretquestion = Question.Text,
                .Answer = TextBox1.Text
            }

            If (dbHandler.EmployeeExists(_user.Username)) Then
                MessageBox.Show("User already exist", "User Exist")
            Else
                If dbHandler.AddNewEmployee(_user) Then
                    If MsgBox("User information saved.", vbOKOnly + vbInformation) = vbOK Then
                        ClearAllFields()
                    End If
                Else
                    If MsgBox("Failed to save user information.", vbRetryCancel + vbQuestion) = vbRetry Then
                        Signup()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CbSignupAccountType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSignupAccountType.KeyPress
        If (e.KeyChar = Chr(13)) Then
            tbSignupUsername.Select()
        End If
    End Sub

    Private Sub TbSignupUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSignupUsername.KeyPress
        If (e.KeyChar = Chr(13)) Then
            tbSignupPassword.Select()
        End If
    End Sub

    Private Sub TbSignupPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSignupPassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            tbSignupConfirmPassword.Select()
        End If
    End Sub

    Private Sub TbSignupConfirmPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSignupConfirmPassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
        End If
    End Sub

    Private Sub TbSignupSecurityCode_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar = Chr(13)) Then
        End If
    End Sub

    Private Sub TbSignupUsername_TextChanged(sender As Object, e As EventArgs) Handles tbSignupUsername.TextChanged
        tbSignupUsername.BackColor = Color.White
    End Sub

    Private Sub TbSignupPassword_TextChanged(sender As Object, e As EventArgs) Handles tbSignupPassword.TextChanged
        tbSignupPassword.BackColor = Color.White
        tbSignupPassword.ForeColor = Color.Black
        tbSignupConfirmPassword.BackColor = Color.White
        tbSignupConfirmPassword.ForeColor = Color.Black
    End Sub

    Private Sub TbSignupConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles tbSignupConfirmPassword.TextChanged
        tbSignupConfirmPassword.BackColor = Color.White
        tbSignupConfirmPassword.ForeColor = Color.Black
        tbSignupPassword.BackColor = Color.White
        tbSignupPassword.ForeColor = Color.Black
    End Sub

    Private Sub CbSignupAccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSignupAccountType.SelectedIndexChanged
        cbSignupAccountType.BackColor = Color.White
    End Sub

    Private Sub CbSignupAccountType_TextUpdate(sender As Object, e As EventArgs) Handles cbSignupAccountType.TextUpdate
        cbSignupAccountType.BackColor = Color.White
        cbSignupAccountType.ForeColor = Color.Black
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbSignupPassword.UseSystemPasswordChar = True
        tbSignupPassword.Select()
        tbSignupConfirmPassword.UseSystemPasswordChar = True
        tbSignupConfirmPassword.Select()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = CheckState.Checked Then
            tbSignupPassword.UseSystemPasswordChar = False
            tbSignupPassword.Select()
            tbSignupConfirmPassword.UseSystemPasswordChar = False
            tbSignupConfirmPassword.Select()
        Else
            tbSignupPassword.UseSystemPasswordChar = True
            tbSignupConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class