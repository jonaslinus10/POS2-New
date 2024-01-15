Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Globalization
Imports iText.StyledXmlParser.Jsoup.Select.Evaluator
Imports iTextSharp.text.xml.simpleparser
Imports ServiceStack
Imports ServiceStack.Script

Public Class FormItemUpdate
    Dim dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private ReadOnly product As New Product
    ReadOnly dbPath As String = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "honest_city_hardware_data.mdf"
    Dim connectionString As String = dbHandler.getConnectionString()
    Dim conn1 As New SqlConnection(connectionString)
    Dim dateholder As String

    Private Sub ClearAllFields()
        txtLength.Clear()
        txtWidth.Clear()
        txtHeight.Clear()
        txtThick.Clear()
        txtWeight.Clear()
        txtElectricity.Clear()
        txtVolume.Clear()
        cbLengthWidth.SelectedIndex = -1
        cbHeight.SelectedIndex = -1
        cbThick.SelectedIndex = -1
        cbWeight.SelectedIndex = -1
        cbElectricity.SelectedIndex = -1
        cbVolume.SelectedIndex = -1
        cbSize.SelectedIndex = -1
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        TbProdName.Clear()
        TbProdBrand.Clear()


        TbProdColor.Clear()
        TbProdPrice.Clear()
        TbProdCriticalStockLimit.Clear()

        TextBox1.Text = FormStockInventory.LvProducts.SelectedItems(0).SubItems(0).Text
        TbProdName.Text = FormStockInventory.LvProducts.SelectedItems(0).SubItems(2).Text
        TbProdBrand.Text = FormStockInventory.LvProducts.SelectedItems(0).SubItems(4).Text
        TbClassification.Text = FormStockInventory.LvProducts.SelectedItems(0).SubItems(3).Text
        ComboBox5.SelectedValue = FormStockInventory.LvProducts.SelectedItems(0).SubItems(4).Text
        txtItemDescription.Text = FormStockInventory.LvProducts.SelectedItems(0).SubItems(12).Text

        TbProdColor.Text = FormStockInventory.LvProducts.SelectedItems(0).SubItems(6).Text
        Dim mergedText As String
        Dim itemidHolder As String = TextBox1.Text
        Dim mergerHold As String

        Dim sizeValue As String = "length"
        Dim sizeUnitValue As String = "lengthUnit"

        If insertSize(itemidHolder, sizeValue, sizeUnitValue).Rows.Count > 0 Then
            Dim dt As DataTable = insertSize(itemidHolder, "length", "lengthUnit")
            Length.Checked = True
                txtLength.Text = dt.Rows(0).Item(0).ToString()
                If cbLengthWidth.Items.Contains(dt.Rows(0).Item(1)) Then
                    cbLengthWidth.SelectedItem = dt.Rows(0).Item(1).ToString
                End If
            dt.Dispose()
        End If

            sizeValue = "width"
        sizeUnitValue = "widthUnit"

        If insertSize(itemidHolder, sizeValue, sizeUnitValue).Rows.Count > 0 Then
            Dim dt As DataTable = insertSize(itemidHolder, "width", "widthUnit")

            Length.Checked = True
                txtWidth.Text = dt.Rows(0).Item(0).ToString()
                If cbLengthWidth.Items.Contains(dt.Rows(0).Item(1)) Then
                    cbLengthWidth.SelectedItem = dt.Rows(0).Item(1).ToString
                End If
                dt.Dispose()

        End If

            sizeValue = "height"
        sizeUnitValue = "heightUnit"

        If insertSize(itemidHolder, sizeValue, sizeUnitValue).Rows.Count > 0 Then
            Dim dt As DataTable = insertSize(itemidHolder, "height", "heightUnit")

            CheckBox3.Checked = True
                txtHeight.Text = dt.Rows(0).Item(0).ToString()
                If cbHeight.Items.Contains(dt.Rows(0).Item(1)) Then
                    cbHeight.SelectedItem = dt.Rows(0).Item(1).ToString
                End If
                dt.Dispose()

        End If

            sizeValue = "thickness"
        sizeUnitValue = "thicknessUnit"

        If insertSize(itemidHolder, sizeValue, sizeUnitValue).Rows.Count > 0 Then
            Dim dt As DataTable = insertSize(itemidHolder, "thickness", "thicknessUnit")
            CheckBox4.Checked = True
            txtThick.Text = dt.Rows(0).Item(0).ToString()
            If cbThick.Items.Contains(dt.Rows(0).Item(1)) Then
                    cbThick.SelectedItem = dt.Rows(0).Item(1).ToString
                End If
            dt.Dispose()
        End If


            sizeValue = "weight"
        sizeUnitValue = "weightUnit"

        If insertSize(itemidHolder, sizeValue, sizeUnitValue).Rows.Count > 0 Then
            Dim dt As DataTable = insertSize(itemidHolder, "weight", "weightUnit")
            CheckBox5.Checked = True
                txtWeight.Text = dt.Rows(0).Item(0).ToString()
                If cbWeight.Items.Contains(dt.Rows(0).Item(1)) Then
                    cbWeight.SelectedItem = dt.Rows(0).Item(1).ToString
                End If
            dt.Dispose()
        End If

            sizeValue = "electricity"
        sizeUnitValue = "electricityUnit"

        If insertSize(itemidHolder, sizeValue, sizeUnitValue).Rows.Count > 0 Then
            Dim dt As DataTable = insertSize(itemidHolder, "electricity", "electricityUnit")
            CheckBox6.Checked = True
                txtElectricity.Text = dt.Rows(0).Item(0).ToString()
                If cbElectricity.Items.Contains(dt.Rows(0).Item(1)) Then
                    cbElectricity.SelectedItem = dt.Rows(0).Item(1).ToString
                End If
                dt.Dispose()

        End If

            sizeValue = "volume"
        sizeUnitValue = "volumeUnit"

        If insertSize(itemidHolder, sizeValue, sizeUnitValue).Rows.Count > 0 Then
            Dim dt As DataTable = insertSize(itemidHolder, "volume", "volumeUnit")
            CheckBox1.Checked = True
                txtVolume.Text = dt.Rows(0).Item(0).ToString()
                If cbVolume.Items.Contains(dt.Rows(0).Item(1)) Then
                    cbVolume.SelectedItem = dt.Rows(0).Item(1).ToString
                End If
                dt.Dispose()

        End If


            sizeValue = "Size"
        sizeUnitValue = ""

        If insertSize(itemidHolder, sizeValue, sizeUnitValue).Rows.Count > 0 Then
            Dim dt As DataTable = insertSize(itemidHolder, "Size", "")
            CheckBox2.Checked = True
            If cbSize.Items.Contains(dt.Rows(0).Item(0)) Then
                    cbSize.SelectedItem = dt.Rows(0).Item(0).ToString
                End If
            dt.Dispose()
        End If


            Dim prodPriceText As String = FormStockInventory.LvProducts.SelectedItems(0).SubItems(7).Text
        Dim prodPrice As String
        prodPriceText = prodPriceText.Replace("₱", "")
        prodPrice = prodPriceText.Trim()
        TbProdPrice.Text = prodPrice
        Dim dateString As String = FormStockInventory.LvProducts.SelectedItems(0).SubItems(10).Text
        Dim selectedDate As DateTime
        FillAllFields(product)
        If DateTime.TryParse(dateString, selectedDate) Then
            DtpExDate.Value = dateString
            DtpExDate.Visible = True
            Label6.Visible = True
        Else
            DtpExDate.Visible = False
            Label6.Visible = False

        End If
        TbProdCriticalStockLimit.Text = Integer.Parse(FormStockInventory.LvProducts.SelectedItems(0).SubItems(11).Text)
        PopulateCbCategories()
        FillAllFields(product)
    End Sub
    Public Function insertSize(product_id As String, size As String, sizeUnit As String) As DataTable
        Using connection As New SqlConnection(dbHandler.getConnectionString)
            connection.Open()
            Dim sqlString As String
            If sizeUnit = "" Then
                sqlString = "Select [" & size & "] From [dbo].[sizes] WHERE [product_id] = '" & product_id & "' AND [" & size & "] Is Not Null "
            Else
                sqlString = "Select [" & size & "], [" & sizeUnit & "] From [dbo].[sizes] WHERE [product_id] = '" & product_id & "' AND [" & size & "] Is Not Null AND [" & sizeUnit & "] Is Not Null "
            End If
            Dim cmd As New SqlCommand(sqlString, connection)
            Dim dataAdapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            dataAdapter.Fill(dt)

            dataAdapter.Dispose()
            connection.Close()
            Return dt
            dt.Dispose()
            cmd.Dispose()
        End Using
    End Function

    Public Sub FillAllFields(product As Product)

        product.Category = FormStockInventory.LvProducts.SelectedItems(0).SubItems(1).Text
        product.Unit = FormStockInventory.LvProducts.SelectedItems(0).SubItems(9).Text

        CbProdType.Text = product.Category
        ComboBox5.Text = product.Unit

    End Sub
    Public Sub PopulateCbCategories()
        CbProdType.Items.Clear()
        Dim listCategory As List(Of Category)
        listCategory = dbHandler.GetCategories()

        For Each category As Category In listCategory
            CbProdType.Items.Add(category.DisplayName)
        Next
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ClearAllFields()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TbProdPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbProdStock_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TbProdCriticalStockLimit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdCriticalStockLimit.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub BtnSaveProduct_Click(sender As Object, e As EventArgs) Handles BtnSaveProduct.Click
        Dim mergerhold As String
        Dim mergedText As String = ""
        Dim itemidHolder As String = TextBox1.Text


        If Not String.IsNullOrEmpty(txtLength.Text) Then
            mergedText += txtLength.Text + "x"
            newSize(itemidHolder, "length", "lengthUnit", txtLength.Text, cbLengthWidth.Text)
        End If

        If Not String.IsNullOrEmpty(txtWidth.Text) Then
            If Not String.IsNullOrEmpty(mergedText) Then
                mergedText += ""
            End If
            mergedText += txtWidth.Text + "x"
            newSize(itemidHolder, "width", "widthUnit", txtWidth.Text, cbLengthWidth.Text)
        End If

        If Not String.IsNullOrEmpty(txtHeight.Text) Then
            If Not String.IsNullOrEmpty(mergedText) Then
                mergedText += ""
            End If
            mergedText += txtHeight.Text + "x"
            newSize(itemidHolder, "height", "heightUnit", txtHeight.Text, cbHeight.Text)
        End If

        If Not String.IsNullOrEmpty(txtThick.Text) Then
            If Not String.IsNullOrEmpty(mergedText) Then
                mergedText += ""
            End If
            mergedText += txtThick.Text + cbThick.Text
            newSize(itemidHolder, "thickness", "thicknessUnit", txtThick.Text, cbThick.Text)
        End If

        If Not String.IsNullOrEmpty(txtWeight.Text) Then
            If Not String.IsNullOrEmpty(mergedText) Then
                mergedText += ""
            End If
            mergedText += txtWeight.Text + cbWeight.Text
            newSize(itemidHolder, "weight", "weightUnit", txtWeight.Text, cbWeight.Text)

        End If

        If Not String.IsNullOrEmpty(txtElectricity.Text) Then
            If Not String.IsNullOrEmpty(mergedText) Then
                mergedText += ""
            End If
            mergedText += txtElectricity.Text + cbElectricity.Text
            newSize(itemidHolder, "electricity", "electricityUnit", txtElectricity.Text, cbElectricity.Text)
        End If

        If Not String.IsNullOrEmpty(txtVolume.Text) Then
            mergedText += txtVolume.Text
            newSize(itemidHolder, "volume", "volumeUnit", txtVolume.Text, cbVolume.Text)
        End If


        ' Remove the trailing "X" if no subsequent input is found
        If mergedText.EndsWith("x") AndAlso mergedText.IndexOf(" ", StringComparison.OrdinalIgnoreCase) = -1 Then
            mergedText = mergedText.TrimEnd("x"c)
        End If

        ' Remove the trailing "X" if it is the last character
        If mergedText.EndsWith("x") Then
            mergedText = mergedText.TrimEnd("x"c)
        End If

        If Length.Checked = True Then
            mergerhold = mergedText + " " + cbLengthWidth.Text
        Else
            mergerhold = mergedText
        End If

        If CheckBox2.Checked = True Then
            If cbSize.Text = "" Then
                MsgBox("Indicate Size!")
            Else
                mergedText = cbSize.Text
                newSize(itemidHolder, "size", "", cbSize.Text, "")
            End If
        End If



        Using connection As New SqlConnection(connectionString)
            ' Create a SQL command
            Dim command As New SqlCommand()

            ' Set the connection for the command
            command.Connection = connection

            ' Set the SQL query for updating the data
            command.CommandText = "UPDATE [dbo].[products]
                                   SET [name] = @NewName
                                      ,[brand] = @newbrand
                                      ,[category] = @newcategory
                                      ,[unit] = @newunit
                                      ,[size] = @newsize
                                      ,[colors] = @newcolor
                                      ,[price] = @newprice
                                      ,[critical_stock_limit] = @newcrit
                                      ,[classification] = @newclassification
                                      ,[item_description] = @item_description
                                        WHERE id = @ID"

            ' Add parameters to the command with title case values
            command.Parameters.AddWithValue("@NewName", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TbProdName.Text))
            command.Parameters.AddWithValue("@newbrand", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TbProdBrand.Text))
            command.Parameters.AddWithValue("@newcategory", CbProdType.Text)
            command.Parameters.AddWithValue("@newclassification", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TbClassification.Text))
            command.Parameters.AddWithValue("@newunit", ComboBox5.Text)
            command.Parameters.AddWithValue("@newcolor", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TbProdColor.Text))
            command.Parameters.AddWithValue("@newprice", TbProdPrice.Text)
            command.Parameters.AddWithValue("@newcrit", Convert.ToInt32(TbProdCriticalStockLimit.Text))
            command.Parameters.AddWithValue("@ID", TextBox1.Text)
            command.Parameters.AddWithValue("@newsize", mergedText)
            command.Parameters.AddWithValue("@item_description", txtItemDescription.Text)
            ' Open the connection
            connection.Open()

            ' Execute the update command
            command.ExecuteNonQuery()

            If DtpExDate.Visible = True Then
                command.CommandText = "UPDATE products SET expiration_date = @exp WHERE id = @ID"
                Dim expdate As String = DtpExDate.Value.ToString("MM-dd-yyyy")
                command.Parameters.AddWithValue("@exp", expdate)
                command.ExecuteNonQuery()
            End If


            ' Data updated successfully
            MsgBox("Data updated successfully.")
            connection.Close()
            FormStockInventory.RefreshUI()
            Me.Hide()

        End Using
    End Sub


    Public Function newSize(product_id As String, size As String, sizeUnit As String, sizeValue As String, sizeUnitValue As String)
        Using connection As New SqlConnection(dbHandler.getConnectionString)
            connection.Open()
            Dim sqlString As String
            If sizeUnit = "" Then
                sqlString = "UPDATE [dbo].[sizes]
                             SET [" & size & "] = '" & sizeValue & "'
                             WHERE [product_id] = '" & product_id & "'"
            Else
                sqlString = "UPDATE [dbo].[sizes]
                             SET [" & size & "] = '" & sizeValue & "'
                             ,[" & sizeUnit & "] = '" & sizeUnitValue & "'
                             WHERE [product_id] = '" & product_id & "'"
            End If
            Dim cmd As New SqlCommand(sqlString, connection)
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using
    End Function

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TbClassification.TextChanged

    End Sub

    Private Sub Length_CheckedChanged(sender As Object, e As EventArgs) Handles Length.CheckedChanged
        If Length.Checked = True Then
            txtWidth.Enabled = True
            txtLength.Enabled = True
            cbLengthWidth.Enabled = True
        Else
            txtWidth.Enabled = False
            txtLength.Enabled = False
            txtWidth.Clear()
            txtLength.Clear()
            cbLengthWidth.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            txtHeight.Enabled = True
            cbHeight.Enabled = True
        Else
            txtHeight.Enabled = False
            cbHeight.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            txtThick.Enabled = True
            cbThick.Enabled = True
        Else
            txtThick.Enabled = False
            cbThick.Enabled = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            txtWeight.Enabled = True
            cbWeight.Enabled = True
        Else
            txtWeight.Enabled = False
            cbWeight.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            txtElectricity.Enabled = True
            cbElectricity.Enabled = True
        Else
            txtElectricity.Enabled = False
            cbElectricity.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtVolume.Enabled = True
            cbVolume.Enabled = True
        Else
            txtVolume.Enabled = False
            cbVolume.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            cbSize.Enabled = True
        Else
            cbSize.Enabled = False
        End If
    End Sub

    Private Sub DtpExDate_ValueChanged(sender As Object, e As EventArgs) Handles DtpExDate.ValueChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class