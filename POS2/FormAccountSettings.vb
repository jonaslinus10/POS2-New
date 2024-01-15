Public Class FormAccountSettings
    Dim dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private Sub FormAccountSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateListView()
    End Sub
    Public Sub RefreshUI()
        PopulateListView()
    End Sub
    Public Function PopulateListView() As Boolean
        Dim _lvItem As ListViewItem
        LvUsers.Items.Clear()

        Dim sqlDT As DataTable
        sqlDT = dbHandler.GetAllEmployees()

        For Each dr As DataRow In sqlDT.Rows
            _lvItem = New ListViewItem(CStr(dr("id")))
            _lvItem.SubItems.Add(CStr(dr("username")))
            _lvItem.SubItems.Add(CStr(dr("role")))
            LvUsers.Items.Add(_lvItem)
        Next
        Return True
    End Function

    Private Sub BtnMarkAll_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each item As ListViewItem In LvUsers.Items
            item.Checked = True
        Next
    End Sub

    Private Sub BtnUnmarkAll_Click(sender As Object, e As EventArgs) Handles BtnUnmarkAll.Click
        For Each item As ListViewItem In LvUsers.Items
            item.Checked = False
        Next
    End Sub
    Private Sub BtnDeleteMarked_Click(sender As Object, e As EventArgs) Handles BtnDeleteMarked.Click
        If UserSession.SignedInUser.Role = "admin" Then
            If LvUsers.CheckedItems.Count > 0 Then
                For Each user As ListViewItem In LvUsers.CheckedItems
                    Dim selectedUserId As String = user.SubItems(0).Text
                    Dim selectedUserRole As String = user.SubItems(2).Text
                    If selectedUserRole = "admin" Then
                        MsgBox("Cannot Delete Admin!")
                    Else
                        If dbHandler.DeleteEmployee(selectedUserId) Then
                            PopulateListView()
                            MessageBox.Show("User account has been deleted.")
                        End If
                    End If
                Next

            Else
                MessageBox.Show("No account selected.")
            End If
        End If
        RefreshUI()
    End Sub

    Private Sub BtnFormAccSettAddUser_Click(sender As Object, e As EventArgs) Handles BtnFormAccSettAddUser.Click
        FormSignup.ShowDialog()
    End Sub

    Private Sub LvUsers_ItemActivate(sender As Object, e As EventArgs) Handles LvUsers.ItemActivate
        Dim formUpdateAccount As FormUpdateAccount
        Dim user As User
        user = New User With {
            .Id = LvUsers.SelectedItems(0).SubItems(0).Text,
            .Username = LvUsers.SelectedItems(0).SubItems(1).Text,
            .Role = LvUsers.SelectedItems(0).SubItems(2).Text
        }
        formUpdateAccount = New FormUpdateAccount(user)
        formUpdateAccount.ShowDialog()
    End Sub

    Private Sub BtnFormAccSettRefresh_Click(sender As Object, e As EventArgs) Handles BtnFormAccSettRefresh.Click
        PopulateListView()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub LvUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvUsers.SelectedIndexChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class