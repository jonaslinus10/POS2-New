Imports System.Data.SqlClient
Public Class FormAddReturnList2
    ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Public returnIDList As String
    Public returnNameList As String
    Public returnQTYList As Integer
    Private Sub BtnAddItemBack_Click(sender As Object, e As EventArgs) Handles BtnAddItemBack.Click
        Me.Close()
    End Sub

    Private Sub FormAddItemOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblItemName.Text = returnNameList
        tbReturnQTY.Text = returnQTYList
    End Sub
    Private Sub BtnClear_Click_1(sender As Object, e As EventArgs) Handles BtnClear.Click
        tbReturnQTY.Clear()
    End Sub

    Private Sub BtnAddItemEnter_Click(sender As Object, e As EventArgs) Handles BtnAddQTYEnter.Click
        If (Not String.IsNullOrEmpty(tbReturnQTY.Text)) Then
            FormPOS.gcashRef = tbReturnQTY.Text
            FormAddReturnList.returnItemWithQTY(returnIDList, returnNameList, Convert.ToInt32(tbReturnQTY.Text), tbRemarks.Text)
            tbReturnQTY.Clear()
            Me.Close()
        Else
            MessageBox.Show("Please Reference Number.")
        End If

    End Sub

    Private Sub tbReturnQTY_TextChanged(sender As Object, e As EventArgs) Handles tbReturnQTY.TextChanged
        Try
            If Convert.ToInt64(tbReturnQTY.Text) > returnQTYList Then
                tbReturnQTY.Text = returnQTYList
            End If
        Catch
            tbReturnQTY.Text = 0
        End Try
    End Sub
    Private Sub TbReturnQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbReturnQTY.KeyPress
        ' Check if the pressed key is a digit or a control key (like backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not a digit and not a control key, suppress the key press
            e.Handled = True
        End If
    End Sub
End Class