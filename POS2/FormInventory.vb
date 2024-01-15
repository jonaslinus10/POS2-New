Imports iTextSharp.text.xml.simpleparser

Public Class FormInventory
    Dim currentFormNumber As Integer
    Private animateIndicator As Boolean = False
    Private targetTop As Integer
    Private ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentFormNumber = 0
        GotoForm(1, BtnGotoProducts)
    End Sub

    Public Sub GotoForm(formNumber As Integer, ByVal button As Button)
        If currentFormNumber <> formNumber Then
            InventoryPanelLoader.Controls.Clear()
            Select Case formNumber
                Case 1
                    With FormStockInventory
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        InventoryPanelLoader.Controls.Add(FormStockInventory)
                        .BringToFront()
                        .Show()
                    End With
                Case 2
                    With FormExpiredProducts
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        InventoryPanelLoader.Controls.Add(FormExpiredProducts)
                        .BringToFront()
                        .Show()
                    End With
                Case 3
                    With FormDamages
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        InventoryPanelLoader.Controls.Add(FormDamages)
                        .BringToFront()
                        .Show()
                    End With
            End Select
        End If
    End Sub

    Private Sub BtnGotoProducts_Click(sender As Object, e As EventArgs) Handles BtnGotoProducts.Click
        GotoForm(1, BtnGotoProducts)
        If BtnGotoProducts.BackColor = Color.Firebrick Then
            BtnGotoProducts.BackColor = Color.Maroon
        Else
            BtnGotoProducts.BackColor = Color.Firebrick

        End If
        dbHandler.CheckExpires()
        FormStockInventory.RefreshUI()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
        BtnGotoProducts.Visible = False
        PnlForMenuBtns.Visible = False
    End Sub

    Private Sub PnlForMenuBtns_Paint(sender As Object, e As PaintEventArgs) Handles PnlForMenuBtns.Paint

    End Sub

    Private Sub InventoryPanelLoader_Paint(sender As Object, e As PaintEventArgs) Handles InventoryPanelLoader.Paint

    End Sub
End Class