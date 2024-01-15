Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FormMaintenance
    Dim currentFormNumber As Integer
    Private Sub FormMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentFormNumber = 0
        GotoForm(1, BtnLogs)
    End Sub

    Public Sub GotoForm(formNumber As Integer, button As Button)
        If currentFormNumber <> formNumber Then
            PnlForContents.Controls.Clear()
            Select Case formNumber
                Case 1
                    With FormLogs
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        PnlForContents.Controls.Add(FormLogs)
                        .BringToFront()
                        .Show()
                    End With
                Case 2
                    With FormDeletedProducts
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        PnlForContents.Controls.Add(FormDeletedProducts)
                        .BringToFront()
                        .Show()
                    End With
                Case 3
                    With FormBackupAndRestore
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        PnlForContents.Controls.Add(FormBackupAndRestore)
                        .BringToFront()
                        .Show()
                    End With
                Case 4
                    With FormAddCategory
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        PnlForContents.Controls.Add(FormAddCategory)
                        .BringToFront()
                        .Show()
                    End With
            End Select
            currentFormNumber = formNumber
        End If

    End Sub

    Private Sub BtnLogs_Click(sender As Object, e As EventArgs) Handles BtnLogs.Click
        GotoForm(1, BtnLogs)
        If BtnLogs.BackColor = Color.Firebrick Then
            BtnLogs.BackColor = Color.Maroon
            BtnDeletedProducts.BackColor = Color.Firebrick
            BtnBackupAndRestore.BackColor = Color.Firebrick
            Button1.BackColor = Color.Firebrick
        Else
            BtnLogs.BackColor = Color.Firebrick
            BtnDeletedProducts.BackColor = Color.Firebrick
            BtnBackupAndRestore.BackColor = Color.Firebrick
            Button1.BackColor = Color.Firebrick
        End If
    End Sub

    Private Sub BtnDeletedProducts_Click(sender As Object, e As EventArgs) Handles BtnDeletedProducts.Click
        GotoForm(2, BtnDeletedProducts)
        If BtnDeletedProducts.BackColor = Color.Firebrick Then
            BtnLogs.BackColor = Color.Firebrick
            BtnDeletedProducts.BackColor = Color.Maroon
            BtnBackupAndRestore.BackColor = Color.Firebrick
            Button1.BackColor = Color.Firebrick
        Else
            BtnLogs.BackColor = Color.Firebrick
            BtnDeletedProducts.BackColor = Color.Firebrick
            BtnBackupAndRestore.BackColor = Color.Firebrick
            Button1.BackColor = Color.Firebrick
        End If
    End Sub

    Private Sub BtnBackupAndRestore_Click(sender As Object, e As EventArgs) Handles BtnBackupAndRestore.Click
        GotoForm(3, BtnBackupAndRestore)
        If BtnBackupAndRestore.BackColor = Color.Firebrick Then
            BtnLogs.BackColor = Color.Firebrick
            BtnDeletedProducts.BackColor = Color.Firebrick
            BtnBackupAndRestore.BackColor = Color.Maroon
            Button1.BackColor = Color.Firebrick
        Else
            BtnLogs.BackColor = Color.Firebrick
            BtnDeletedProducts.BackColor = Color.Firebrick
            BtnBackupAndRestore.BackColor = Color.Firebrick
            Button1.BackColor = Color.Firebrick
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        BtnLogs.Visible = False
        BtnDeletedProducts.Visible = False
        BtnBackupAndRestore.Visible = False
        PnlForMenuBtns.Visible = False
    End Sub

    Private Sub PnlForMenuBtns_Paint(sender As Object, e As PaintEventArgs) Handles PnlForMenuBtns.Paint

    End Sub

    Private Sub PnlForContents_Paint(sender As Object, e As PaintEventArgs) Handles PnlForContents.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GotoForm(4, Button1)
        If Button1.BackColor = Color.Firebrick Then
            BtnLogs.BackColor = Color.Firebrick
            BtnDeletedProducts.BackColor = Color.Firebrick
            BtnBackupAndRestore.BackColor = Color.Firebrick
            Button1.BackColor = Color.Maroon
        Else
            BtnLogs.BackColor = Color.Firebrick
            BtnDeletedProducts.BackColor = Color.Firebrick
            BtnBackupAndRestore.BackColor = Color.Firebrick
            Button1.BackColor = Color.Firebrick
        End If
    End Sub
End Class