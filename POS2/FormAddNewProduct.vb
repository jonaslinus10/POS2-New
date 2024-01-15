Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ServiceStack
Imports Microsoft.VisualBasic
Imports System.Globalization
Imports iTextSharp.text
Imports System.Windows

Public Class FormAddNewProduct
    Private ReadOnly dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private ReadOnly product As New Product
    Dim conn1 As New SqlConnection(dbHandler.getConnectionString)
    Dim connectionString As String = dbHandler.getConnectionString
    Dim firstLetter As Char
    Dim itemidholder As String = ""

    Private Sub FormAddNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCbCategories()
        checkerCategory()
        unlockbtn()

    End Sub

    Sub unlockbtn()
        BtnSaveProduct.Enabled = False ' Assume the button is disabled by default

        If TbProdName.TextLength > 0 AndAlso
   TbProdColor.TextLength > 0 AndAlso
   TbProdPrice.TextLength > 0 AndAlso
   TbProdStock.TextLength > 0 AndAlso
   TbProdCritStockLimit.TextLength > 0 Then

            BtnSaveProduct.Enabled = True ' Enable the button if all conditions are met
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BtnSaveProduct_Click(sender As Object, e As EventArgs) Handles BtnSaveProduct.Click
        If CbProdType.Text = "" Then
            MsgBox("Input Fields!")
        Else
            TextBox1.Text = TbProdPrice.Text
            Dim value As String = TextBox1.Text.Trim()
            Dim result As Decimal
            If Decimal.TryParse(value, result) Then
                TextBox1.Text = result.ToString("0.00")
            End If
            unlockbtn()
            SaveProduct()
            ClearAllCheckBox()
        End If


    End Sub

    Public Sub PopulateCbCategories()
        Dim listCategory As List(Of Category)
        listCategory = dbHandler.GetCategories()

        For Each category As Category In listCategory
            If Not CbProdType.Items.Contains(category.DisplayName) Then
                CbProdType.Items.Add(category.DisplayName)
            End If
        Next
    End Sub
    Public Sub checkerCategory()
        Dim listCategory As List(Of Category)
        listCategory = dbHandler.GetCategories()
        TextBox2.Items.Clear()
        TbProdBrand.Items.Clear()
        For Each category As Category In listCategory
            If CbProdType.Text = category.DisplayName Then
                If Not TbProdBrand.Items.Contains("None") Then
                    TbProdBrand.Items.Add("None")
                End If
                If Not TextBox2.Items.Contains("None") Then
                    TextBox2.Items.Add("None")
                End If
                If Not TextBox2.Items.Contains(category.categoryClass) Then
                    TextBox2.Items.Add(category.categoryClass)
                End If
                If Not TbProdBrand.Items.Contains(category.categoryBrand) Then
                    TbProdBrand.Items.Add(category.categoryBrand)
                End If
                If category.lengthWidth = True Then
                    Length.Checked = True
                Else
                    Length.Checked = False
                End If

                If category.height = True Then
                    CheckBox3.Checked = True
                Else
                    CheckBox3.Checked = False
                End If
                If category.thickness = True Then
                    CheckBox4.Checked = True
                Else
                    CheckBox4.Checked = False
                End If
                If category.weight = True Then
                    CheckBox5.Checked = True
                Else
                    CheckBox5.Checked = False
                End If

                If category.electricity = True Then
                    CheckBox6.Checked = True
                Else
                    CheckBox6.Checked = False
                End If

                If category.volume = True Then
                    CheckBox1.Checked = True
                Else
                    CheckBox1.Checked = False
                End If
                If category.size = True Then
                    CheckBox2.Checked = True
                Else
                    CheckBox2.Checked = False
                End If
            End If


            ' ...
        Next

    End Sub


    Private Sub SaveProduct()
        Dim _product As Product
        If CbProdType.SelectedItem Is Nothing Then
            ErrorProvider1.SetError(CbProdType, "Please select a value for Item Type.")
            Exit Sub
        Else
            ErrorProvider1.SetError(CbProdType, "") ' Clear the error indicator if the ComboBox has a value
        End If

        Dim expdate As String
        If CheckBoxDoesExpire.Checked = False Then
            expdate = "NO EXPIRATION"
        Else
            expdate = DtpExDate.Value.ToString("MM-dd-yyyy")
        End If

        Dim textInfo As System.Globalization.TextInfo = New System.Globalization.CultureInfo("en-US", False).TextInfo
        Dim itemidholder As String

        Dim selectedText As String = CbProdType.SelectedItem.ToString()
        Dim selectedText1 As String = TbProdName.Text.ToString()
        Dim initials As String = GetInitials(selectedText)
        Dim initials1 As String = GetInitials(selectedText1)
        Dim firstLetter As String = TbProdBrand.Text.Substring(0, 1)
        Dim counterforname As String
        conn1.Open()

        Dim query As String = "SELECT COUNT(*) FROM products"
        Dim cmd As New SqlCommand(query, conn1)
        Dim count1 As Integer = CInt(cmd.ExecuteScalar())
        counterforname = count1.ToString("D3")

        Dim batch_idFinal As String = dbHandler.GenerateId


        itemidholder = initials & initials1 & firstLetter & counterforname
        Dim mergerhold As String
        Dim mergedText As String = ""

        If Not String.IsNullOrEmpty(txtLength.Text) Then
            mergedText += txtLength.Text + "x"
            insertSize(batch_idFinal, itemidholder, "length", "lengthUnit", txtLength.Text, cblengthWidth.Text)
        End If

        If Not String.IsNullOrEmpty(txtWidth.Text) Then
            If Not String.IsNullOrEmpty(mergedText) Then
                mergedText += ""
            End If
            mergedText += txtWidth.Text + "x"
            insertSize(batch_idFinal, itemidholder, "width", "widthUnit", txtWidth.Text, cblengthWidth.Text)
        End If

        If Not String.IsNullOrEmpty(txtHeight.Text) Then
            If Not String.IsNullOrEmpty(mergedText) Then
                mergedText += ""
            End If
            mergedText += txtHeight.Text + "x"
            insertSize(batch_idFinal, itemidholder, "height", "heightUnit", txtHeight.Text, cbHeight.Text)
        End If

        If Not String.IsNullOrEmpty(txtThick.Text) Then
            If Not String.IsNullOrEmpty(mergedText) Then
                mergedText += ""
            End If
            mergedText += txtThick.Text + cbThick.Text
            insertSize(batch_idFinal, itemidholder, "thickness", "thicknessUnit", txtThick.Text, cbThick.Text)
        End If

        If Not String.IsNullOrEmpty(txtWeight.Text) Then
            If Not String.IsNullOrEmpty(mergedText) Then
                mergedText += ""
            End If
            mergedText += txtWeight.Text + cbWeight.Text
            insertSize(batch_idFinal, itemidholder, "weight", "weightUnit", txtWeight.Text, cbWeight.Text)

        End If

        If Not String.IsNullOrEmpty(txtElectricity.Text) Then
            If Not String.IsNullOrEmpty(mergedText) Then
                mergedText += ""
            End If
            mergedText += txtElectricity.Text + cbElectricity.Text
            insertSize(batch_idFinal, itemidholder, "electricity", "electricityUnit", txtElectricity.Text, cbElectricity.Text)
        End If

        If Not String.IsNullOrEmpty(txtVolume.Text) Then
            mergedText += txtVolume.Text
            insertSize(batch_idFinal, itemidholder, "volume", "volumeUnit", txtVolume.Text, cbVolume.Text)
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
            mergerhold = mergedText + " " + cblengthWidth.Text
        Else
            mergerhold = mergedText
        End If

        If CheckBox2.Checked = True Then
            If cbSize.Text = "" Then
                MsgBox("Indicate Size!")
            Else
                mergedText = cbSize.Text
                insertSize(batch_idFinal, itemidholder, "size", "", cbSize.Text, "")
            End If
        End If

        If (InfoValid()) Then
            If checkerItemExists(itemidholder, TbProdName.Text, TbProdBrand.Text, CbProdType.Text, TextBox2.Text, TbProdColor.Text) Then
                Dim priceInput = TbProdPrice.Text.Trim()
                Dim priceValue As Decimal

                If Decimal.TryParse(priceInput, priceValue) Then
                    _product = New Product With {
                    .Batch_Id = batch_idFinal,
                    .Id = textInfo.ToTitleCase(itemidholder),
                    .Name = textInfo.ToTitleCase(TbProdName.Text),
                    .Brand = textInfo.ToTitleCase(TbProdBrand.Text),
                    .Classification = textInfo.ToTitleCase(TextBox2.Text),
                    .Category = textInfo.ToTitleCase(CbProdType.Text),
                    .Unit = ComboBox5.Text,
                    .Size = textInfo.ToTitleCase(mergedText),
                    .Colors = textInfo.ToTitleCase(TbProdColor.Text),
                    .Price = TextBox1.Text,
                    .Expiration_Date = expdate,
                    .Critical_Stock_Limit = TbProdCritStockLimit.Text,
                    .Stock = "0",
                    .Available = True,
                    .Expires = CheckBoxDoesExpire.Checked,
                     .Item_Description = txtItemDescription.Text
                }
                End If
                If dbHandler.AddNewProduct(_product) Then
                    If MsgBox("Item information saved.", vbOKOnly + vbInformation) = vbOK Then
                        ClearAllFields()
                        FormStockInventory.RefreshUI()
                    End If
                Else
                    If MsgBox("Failed to save item information.", vbRetryCancel + vbQuestion) = vbRetry Then
                        ' Retry logic or additional error handling
                    End If
                End If
            Else
                ' Handle invalid price input
                ' Show an error message or take appropriate action
                MsgBox("Item Already Existing", vbRetryCancel + vbQuestion)
            End If
        Else
            MsgBox("Invalid format in price", vbRetryCancel + vbQuestion)
        End If




        conn1.Close()
    End Sub
    Public Function insertSize(batch_id As String, product_id As String, size As String, sizeUnit As String, sizeValue As String, sizeUnitValue As String)
        Using connection As New SqlConnection(dbHandler.getConnectionString)
            connection.Open()
            Dim sqlString As String
            If sizeUnit = "" Then
                sqlString = "INSERT INTO [dbo].[sizes]
                                       ([id]
                                       ,[product_id]
                                       ,[" & size & "])
                                 VALUES
                                       ('" & batch_id & "'
                                       ,'" & product_id & "'
                                       ,'" & sizeValue & "')"
            Else
                sqlString = "INSERT INTO [dbo].[sizes]
                                       ([id]
                                       ,[product_id]
                                       ,[" & size & "]
                                       ,[" & sizeUnit & "]
                                       )
                                 VALUES
                                       ('" & batch_id & "'
                                       ,'" & product_id & "'
                                       ,'" & sizeValue & "'
                                       ,'" & sizeUnitValue & "')"
            End If

            Dim cmd As New SqlCommand(sqlString, connection)
            cmd.ExecuteNonQuery()
            connection.Close()
        End Using
    End Function
    Public Function checkerItemExists(id As String, name As String, brand As String, category As String, classi As String, colors As String) As Boolean
        Using connection As New SqlConnection(dbHandler.getConnectionString)
            connection.Open()
            Dim sqlString As String
            sqlString = "Select * From Products Where [name] = @name AND [brand] = @brand AND [category] = @category AND [classification] = @classi AND [colors] = @colors"
            Dim cmd As New SqlCommand(sqlString, connection)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@brand", brand)
            cmd.Parameters.AddWithValue("@category", category)
            cmd.Parameters.AddWithValue("@classi", classi)
            cmd.Parameters.AddWithValue("@colors", colors)
            Dim sqlDataAdapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sqlDataAdapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If
            sqlDataAdapter.Dispose()
            dt.Dispose()
            connection.Close()
        End Using
    End Function


    Public Function GetInitials(ByVal input As String) As String
        Dim words() As String = input.Split(" "c)
        Dim initials As String = ""

        For Each word As String In words
            If word.Length > 0 Then
                initials &= word.Substring(0, 1)
            End If
        Next

        Return initials.ToUpper()



        Dim words1() As String = input.Split(" "c)
        Dim initials1 As String = ""

        For Each word As String In words1
            If word.Length > 0 Then
                initials1 &= word.Substring(0, 1)
            End If
        Next

        Return initials1.ToUpper()




    End Function



    Private Sub ClearAllCheckBox()
        txtLength.Clear()
        txtWidth.Clear()
        txtHeight.Clear()
        txtThick.Clear()
        txtWeight.Clear()
        txtElectricity.Clear()
        txtVolume.Clear()
        cblengthWidth.SelectedIndex = -1
        cbHeight.SelectedIndex = -1
        cbThick.SelectedIndex = -1
        cbWeight.SelectedIndex = -1
        cbElectricity.SelectedIndex = -1
        cbVolume.SelectedIndex = -1
        cbSize.SelectedIndex = -1
    End Sub
    Private Sub ClearAllFields()
        TbProdName.Clear()
        TbProdBrand.Items.Clear()
        CbProdType.Text = ""
        CbProdType.SelectedIndex = -1
        TbProdStock.Clear()
        TbProdColor.Clear()
        TbProdPrice.Clear()
        txtItemDescription.Clear()

        CheckBoxDoesExpire.Checked = False
        ComboBox5.SelectedIndex = -1
        TbProdCritStockLimit.Clear()
    End Sub

    Private Function InfoValid() As Boolean
        If (TbProdName.Text = "") Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub TbProdPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdPrice.KeyPress
        If TbProdPrice.Text.Length >= 6 AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the length is already 6 and it's not a control key, suppress the key press
            e.Handled = True
        End If
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ".") AndAlso (e.KeyChar <> ChrW(Keys.Back)) Then
            ' If the input character is not a digit, decimal point, or backspace, suppress the key press event
            e.Handled = True
        End If
    End Sub

    Private Sub TbProdStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdStock.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CheckBoxDoesExpire_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDoesExpire.CheckedChanged
        DtpExDate.Enabled = CheckBoxDoesExpire.Checked
    End Sub

    Private Sub TbProdName_TextChanged(sender As Object, e As EventArgs) Handles TbProdName.TextChanged
        unlockbtn()
    End Sub

    Private Sub TbProdBrand_TextChanged(sender As Object, e As EventArgs)
        unlockbtn()
    End Sub

    Private Sub TbProdColor_TextChanged(sender As Object, e As EventArgs) Handles TbProdColor.TextChanged
        unlockbtn()
    End Sub



    Private Sub TbProdColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdColor.KeyPress
        ' Check if the pressed key is an alphabet character
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not an alphabet character and not a control key (like backspace), suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TbProdPrice_TextChanged(sender As Object, e As EventArgs) Handles TbProdPrice.TextChanged

        unlockbtn()

    End Sub



    Private Sub TbProdStock_TextChanged(sender As Object, e As EventArgs) Handles TbProdStock.TextChanged
        unlockbtn()
    End Sub

    Private Sub TbProdSize_TextChanged(sender As Object, e As EventArgs)
        unlockbtn()
    End Sub

    Private Sub TbProdCritStockLimit_TextChanged(sender As Object, e As EventArgs) Handles TbProdCritStockLimit.TextChanged


        unlockbtn()
    End Sub

    Private Sub CbProdType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProdType.SelectedIndexChanged
        ClearAllCheckBox()
        checkerCategory()
        If CbProdType.SelectedText.Any Then
            BtnSaveProduct.Enabled = False
        Else
            BtnSaveProduct.Enabled = True
        End If
    End Sub

    Private Sub TbProdPrice_Click(sender As Object, e As EventArgs) Handles TbProdPrice.Click
        TbProdPrice.Clear()

    End Sub

    Private Sub Length_CheckedChanged(sender As Object, e As EventArgs) Handles Length.CheckedChanged
        If Length.Checked = True Then
            txtWidth.Enabled = True
            txtLength.Enabled = True
            cblengthWidth.Enabled = True
        Else
            txtWidth.Enabled = False
            txtLength.Enabled = False
            cblengthWidth.Enabled = False
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

    Private Sub TbProdStock_Click(sender As Object, e As EventArgs) Handles TbProdStock.Click
        TbProdStock.Clear()
    End Sub

    Private Sub TbProdCritStockLimit_Click(sender As Object, e As EventArgs) Handles TbProdCritStockLimit.Click
        TbProdCritStockLimit.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cblengthWidth.SelectedIndexChanged

    End Sub

    Private Sub TbProdCritStockLimit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProdCritStockLimit.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ".") AndAlso (e.KeyChar <> ChrW(Keys.Back)) Then
            ' If the input character is not a digit, decimal point, or backspace, suppress the key press event
            e.Handled = True
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

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtItemDescription.TextChanged

    End Sub
End Class