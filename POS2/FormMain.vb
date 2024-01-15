Imports iTextSharp.text.xml.simpleparser
Imports Nevron.Nov.Chart

Public Class FormMain
    Dim currentFormNumber As Integer
    Private animateIndicator As Boolean = False ' flag to indicate if animation is in progress
    Private targetTop As Integer ' target top position of the indicator control
    Private ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentFormNumber = 0
        GotoForm(1, BtnDashBoard)
        LblAdminUserName.Text = UserSession.SignedInUser.Username
        BtnDashBoard.BackColor = Color.Maroon
    End Sub

    Public Sub GotoForm(formNumber As Integer, ByVal button As Button)
        If currentFormNumber <> formNumber Then
            pnlLoader.Controls.Clear()
            Select Case formNumber
                Case 1
                    With FormDashboard
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        pnlLoader.Controls.Add(FormDashboard)
                        .BringToFront()
                        .Show()
                    End With
                Case 2
                    With FormInventory
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        pnlLoader.Controls.Add(FormInventory)
                        .BringToFront()
                        .Show()
                    End With
                Case 3
                    With FormReports
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        pnlLoader.Controls.Add(FormReports)
                        .BringToFront()
                        .Show()
                    End With
                Case 4
                    With FormMaintenance
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        pnlLoader.Controls.Add(FormMaintenance)
                        .BringToFront()
                        .Show()
                    End With
                Case 5
                    With FormAccountSettings
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        pnlLoader.Controls.Add(FormAccountSettings)
                        .BringToFront()
                        .Show()
                    End With
            End Select
            'pnlIndicator.Top = button.Top
            'pnlIndicator.Left = button.Left
            currentFormNumber = formNumber
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        FormDialogExit.ShowDialog()
    End Sub

    Private Sub BtnDashBoard_Click(sender As Object, e As EventArgs) Handles BtnDashBoard.Click
        FormDashboard.RefreshUI()
        'FormDashboard.PopulatePendingDeliveries()

        GotoForm(1, BtnDashBoard)
        If BtnAccountSettings.BackColor = Color.Firebrick Then
            BtnAccountSettings.BackColor = Color.Firebrick
            BtnStocks.BackColor = Color.Firebrick
            BtnMaintenance.BackColor = Color.Firebrick
            BtnSalesReport.BackColor = Color.Firebrick
            BtnDashBoard.BackColor = Color.Maroon
        Else
            BtnStocks.BackColor = Color.Firebrick
            BtnMaintenance.BackColor = Color.Firebrick
            BtnSalesReport.BackColor = Color.Firebrick
            BtnAccountSettings.BackColor = Color.Firebrick
            BtnDashBoard.BackColor = Color.Firebrick
        End If
    End Sub
    Private Sub BtnStocks_Click(sender As Object, e As EventArgs) Handles BtnStocks.Click
        If BtnStocks.BackColor = Color.Firebrick Then
            BtnStocks.BackColor = Color.Maroon
            BtnMaintenance.BackColor = Color.Firebrick
            BtnSalesReport.BackColor = Color.Firebrick
            BtnAccountSettings.BackColor = Color.Firebrick
            BtnDashBoard.BackColor = Color.Firebrick
            FormInventory.BtnGotoProducts.Visible = True
            FormReports.BtnGotoExpiredProducts.Visible = True
            FormReports.BtnGotoDamagedProducts.Visible = True
            FormInventory.PnlForMenuBtns.Visible = True
        Else
            BtnStocks.BackColor = Color.Firebrick
            BtnMaintenance.BackColor = Color.Firebrick
            BtnSalesReport.BackColor = Color.Firebrick
            BtnAccountSettings.BackColor = Color.Firebrick
            BtnDashBoard.BackColor = Color.Firebrick
            FormInventory.BtnGotoProducts.Visible = False
            FormReports.BtnGotoExpiredProducts.Visible = False
            FormReports.BtnGotoDamagedProducts.Visible = False
            FormInventory.PnlForMenuBtns.Visible = False
        End If

        GotoForm(2, BtnStocks)
        dbHandler.CheckExpires()
        FormStockInventory.RefreshUI()
        FormDamages.RefreshUI()
        FormExpiredProducts.RefreshUI()

    End Sub

    Private Sub BtnSalesReport_Click(sender As Object, e As EventArgs) Handles BtnSalesReport.Click
        GotoForm(3, BtnSalesReport)

        If BtnSalesReport.BackColor = Color.Firebrick Then
            BtnStocks.BackColor = Color.Firebrick
            BtnMaintenance.BackColor = Color.Firebrick
            BtnSalesReport.BackColor = Color.Maroon
            BtnAccountSettings.BackColor = Color.Firebrick
            BtnDashBoard.BackColor = Color.Firebrick
            FormReports.BtnSales.Visible = True
            FormReports.BtnReturns.Visible = True
            FormReports.BtnDelivered.Visible = True
            FormReports.PnlForMenuBtns.Visible = True
        Else
            BtnStocks.BackColor = Color.Firebrick
            BtnMaintenance.BackColor = Color.Firebrick
            BtnSalesReport.BackColor = Color.Firebrick
            BtnAccountSettings.BackColor = Color.Firebrick
            BtnDashBoard.BackColor = Color.Firebrick
            FormReports.BtnSales.Visible = False
            FormReports.BtnReturns.Visible = False
            FormReports.BtnDelivered.Visible = False
            FormReports.PnlForMenuBtns.Visible = False
        End If
    End Sub
    Private Sub BtnMaintenance_Click(sender As Object, e As EventArgs) Handles BtnMaintenance.Click
        GotoForm(4, BtnMaintenance)
        If BtnMaintenance.BackColor = Color.Firebrick Then
            BtnStocks.BackColor = Color.Firebrick
            BtnMaintenance.BackColor = Color.Maroon
            BtnSalesReport.BackColor = Color.Firebrick
            BtnAccountSettings.BackColor = Color.Firebrick
            BtnDashBoard.BackColor = Color.Firebrick
            FormMaintenance.BtnLogs.Visible = True
            FormMaintenance.BtnDeletedProducts.Visible = True
            FormMaintenance.BtnBackupAndRestore.Visible = True
            FormMaintenance.PnlForMenuBtns.Visible = True
        Else
            BtnStocks.BackColor = Color.Firebrick
            BtnMaintenance.BackColor = Color.Firebrick
            BtnSalesReport.BackColor = Color.Firebrick
            BtnAccountSettings.BackColor = Color.Firebrick
            BtnDashBoard.BackColor = Color.Firebrick
            FormMaintenance.BtnLogs.Visible = False
            FormMaintenance.BtnDeletedProducts.Visible = False
            FormMaintenance.BtnBackupAndRestore.Visible = False
            FormMaintenance.PnlForMenuBtns.Visible = False
        End If
    End Sub

    Private Sub BtnAccountSettings_Click(sender As Object, e As EventArgs) Handles BtnAccountSettings.Click
        GotoForm(5, BtnAccountSettings)
        If BtnAccountSettings.BackColor = Color.Firebrick Then
            BtnAccountSettings.BackColor = Color.Maroon
            BtnStocks.BackColor = Color.Firebrick
            BtnMaintenance.BackColor = Color.Firebrick
            BtnSalesReport.BackColor = Color.Firebrick
            BtnDashBoard.BackColor = Color.Firebrick
        Else
            BtnStocks.BackColor = Color.Firebrick
            BtnMaintenance.BackColor = Color.Firebrick
            BtnSalesReport.BackColor = Color.Firebrick
            BtnAccountSettings.BackColor = Color.Firebrick
            BtnDashBoard.BackColor = Color.Firebrick
        End If
        FormAccountSettings.RefreshUI()
    End Sub

    Private Sub BtnSalesReport_Enter(sender As Object, e As EventArgs)
        FormReports.GotoForm(1, FormReports.GetBtnSale)
    End Sub

    Private Sub BtnGotoPos_Click(sender As Object, e As EventArgs) Handles BtnGotoPos.Click
        FormPOS.RefreshUi()

        FormPOS.Show()
        Me.Close()
    End Sub

    Private Sub pnlLoader_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub pnlLoader_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlLoader.Paint

    End Sub
End Class