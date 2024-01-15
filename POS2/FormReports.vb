Public Class FormReports
    Dim currentFormNumber As Integer
    Private Sub FormReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentFormNumber = 0
        GotoForm(1, BtnSales)
    End Sub

    Public Function GetBtnSale() As Button
        Return BtnSales
    End Function

    Public Sub GotoForm(formNumber As Integer, button As Button)
        If currentFormNumber <> formNumber Then
            reportsPnlLoader.Controls.Clear()
            Select Case formNumber
                Case 1
                    With FormSales
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        reportsPnlLoader.Controls.Add(FormSales)
                        .BringToFront()
                        .Show()
                    End With
                Case 2
                    With FormReturns
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        reportsPnlLoader.Controls.Add(FormReturns)
                        .BringToFront()
                        .Show()
                    End With
                Case 3
                    With FormDelivery
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        reportsPnlLoader.Controls.Add(FormDelivery)
                        .BringToFront()
                        .Show()
                    End With
                Case 4
                    With FormExpiredProducts
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        reportsPnlLoader.Controls.Add(FormExpiredProducts)
                        .BringToFront()
                        .Show()
                    End With
                Case 5
                    With FormDamages
                        .TopLevel = False
                        .TopMost = True
                        .Dock = DockStyle.Fill
                        .FormBorderStyle = FormBorderStyle.None
                        reportsPnlLoader.Controls.Add(FormDamages)
                        .BringToFront()
                        .Show()
                    End With


            End Select
            currentFormNumber = formNumber

        End If
    End Sub

    Private Sub BtnSales_Click(sender As Object, e As EventArgs) Handles BtnSales.Click
        GotoForm(1, BtnSales)
        FormSales.RefreshUI()
        If BtnSales.BackColor = Color.Firebrick Then
            BtnSales.BackColor = Color.Maroon
            BtnReturns.BackColor = Color.Firebrick
            BtnDelivered.BackColor = Color.Firebrick
            BtnGotoDamagedProducts.BackColor = Color.Firebrick
            BtnGotoExpiredProducts.BackColor = Color.Firebrick
        Else
            BtnSales.BackColor = Color.Firebrick
            BtnReturns.BackColor = Color.Firebrick
            BtnDelivered.BackColor = Color.Firebrick
            BtnGotoDamagedProducts.BackColor = Color.Firebrick
            BtnGotoExpiredProducts.BackColor = Color.Firebrick
        End If
    End Sub

    Private Sub BtnReturns_Click(sender As Object, e As EventArgs) Handles BtnReturns.Click
        GotoForm(2, BtnReturns)
        FormReturns.newviewforreturned()
        If BtnReturns.BackColor = Color.Firebrick Then
            BtnSales.BackColor = Color.Firebrick
            BtnReturns.BackColor = Color.Maroon
            BtnDelivered.BackColor = Color.Firebrick
            BtnGotoDamagedProducts.BackColor = Color.Firebrick
            BtnGotoExpiredProducts.BackColor = Color.Firebrick
        Else
            BtnSales.BackColor = Color.Firebrick
            BtnReturns.BackColor = Color.Firebrick
            BtnDelivered.BackColor = Color.Firebrick
            BtnGotoDamagedProducts.BackColor = Color.Firebrick
            BtnGotoExpiredProducts.BackColor = Color.Firebrick
        End If
    End Sub
    Private Sub BtnDelivered_Click(sender As Object, e As EventArgs) Handles BtnDelivered.Click
        GotoForm(3, BtnDelivered)
        FormDelivery.RefreshUI()
        If BtnDelivered.BackColor = Color.Firebrick Then
            BtnSales.BackColor = Color.Firebrick
            BtnReturns.BackColor = Color.Firebrick
            BtnDelivered.BackColor = Color.Maroon
            BtnGotoDamagedProducts.BackColor = Color.Firebrick
            BtnGotoExpiredProducts.BackColor = Color.Firebrick
        Else
            BtnSales.BackColor = Color.Firebrick
            BtnReturns.BackColor = Color.Firebrick
            BtnDelivered.BackColor = Color.Firebrick
            BtnGotoDamagedProducts.BackColor = Color.Firebrick
            BtnGotoExpiredProducts.BackColor = Color.Firebrick
        End If
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub reportsPnlLoader_Paint(sender As Object, e As PaintEventArgs) Handles reportsPnlLoader.Paint

    End Sub

    Private Sub PnlForMenuBtns_Paint(sender As Object, e As PaintEventArgs) Handles PnlForMenuBtns.Paint

    End Sub

    Private Sub BtnGotoExpiredProducts_Click(sender As Object, e As EventArgs) Handles BtnGotoExpiredProducts.Click
        GotoForm(4, BtnGotoExpiredProducts)
        FormDelivery.RefreshUI()
        If BtnGotoExpiredProducts.BackColor = Color.Firebrick Then
            BtnSales.BackColor = Color.Firebrick
            BtnReturns.BackColor = Color.Firebrick
            BtnDelivered.BackColor = Color.Firebrick
            BtnGotoDamagedProducts.BackColor = Color.Firebrick
            BtnGotoExpiredProducts.BackColor = Color.Maroon
        Else
            BtnSales.BackColor = Color.Firebrick
            BtnReturns.BackColor = Color.Firebrick
            BtnDelivered.BackColor = Color.Firebrick
            BtnGotoDamagedProducts.BackColor = Color.Firebrick
            BtnGotoExpiredProducts.BackColor = Color.Firebrick
        End If
    End Sub

    Private Sub BtnGotoDamagedProducts_Click(sender As Object, e As EventArgs) Handles BtnGotoDamagedProducts.Click
        GotoForm(5, BtnGotoDamagedProducts)
        FormDelivery.RefreshUI()
        If BtnGotoDamagedProducts.BackColor = Color.Firebrick Then
            BtnSales.BackColor = Color.Firebrick
            BtnReturns.BackColor = Color.Firebrick
            BtnDelivered.BackColor = Color.Firebrick
            BtnGotoDamagedProducts.BackColor = Color.Maroon
            BtnGotoExpiredProducts.BackColor = Color.Firebrick
        Else
            BtnSales.BackColor = Color.Firebrick
            BtnReturns.BackColor = Color.Firebrick
            BtnDelivered.BackColor = Color.Firebrick
            BtnGotoDamagedProducts.BackColor = Color.Firebrick
            BtnGotoExpiredProducts.BackColor = Color.Firebrick
        End If
    End Sub
End Class