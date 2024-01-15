Imports iText.StyledXmlParser.Jsoup.Select.Evaluator
Imports Mysqlx
Imports OracleInternal
Imports System.Data.SqlClient

Public Class FormAddCategory
    Dim dbHandler As DatabaseHandler = MainPOS.GetDatabaseHandler
    Private Sub BtnAddCategoryExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnAddCategorySave_Click(sender As Object, e As EventArgs)
        SaveCategory()
    End Sub

    Private Function SaveCategory()
        Dim _category As Category
        Dim length1 As Boolean
        Dim height As Boolean
        Dim thickness As Boolean
        Dim weight As Boolean
        Dim electricity As Boolean
        Dim volume As Boolean
        Dim size As Boolean

        Dim textInfo As System.Globalization.TextInfo = New System.Globalization.CultureInfo("en-US", False).TextInfo

        If Length.Checked Then
            length1 = True
        Else
            length1 = False
        End If

        If CheckBox3.Checked Then
            height = True
        Else
            height = False
        End If
        If CheckBox4.Checked Then
            thickness = True
        Else
            thickness = False
        End If
        If CheckBox5.Checked Then
            weight = True
        Else
            weight = False
        End If
        If CheckBox6.Checked Then
            electricity = True
        Else
            electricity = False
        End If
        If CheckBox1.Checked Then
            volume = True
        Else
            volume = False
        End If
        If CheckBox2.Checked Then
            size = True
        Else
            size = False
        End If
        ' ...

        If (InfoValid()) Then
            _category = New Category With {
                .Id = textInfo.ToTitleCase(TextBox1.Text.ToLower()),
                .DisplayName = textInfo.ToTitleCase(TbAddCategoryName.Text.ToLower()),
                .categoryClass = textInfo.ToTitleCase(TextBox2.Text.ToLower()),
                .categoryBrand = textInfo.ToTitleCase(TbProdBrand.Text.ToLower()),
                .lengthWidth = length1,
                .height = height,
                .thickness = thickness,
                .weight = weight,
                .electricity = electricity,
                .volume = volume,
                .size = size
            }
            ' ...

            If (dbHandler.CategoryExist(_category.DisplayName, _category.categoryClass, _category.categoryBrand)) Then
                MessageBox.Show("Category already exist", "Category Exist")
            Else
                If dbHandler.AddNewCategory(_category) Then
                    If MsgBox("Category information saved.", vbOKOnly + vbInformation) = vbOK Then
                        FormStockInventory.PopulateCbCategories()
                        ClearAllFields()
                    End If
                Else
                    If MsgBox("Failed to save category information.", vbRetryCancel + vbQuestion) = vbRetry Then
                    End If
                End If
            End If
        End If
        idGenerator()
    End Function

    Private Sub ClearAllFields()
        TbAddCategoryName.Clear()
        TbProdBrand.Clear()
        TextBox2.Clear()
        TbAddCategoryName.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        Length.Checked = False
    End Sub

    Private Function InfoValid() As Boolean
        If TbAddCategoryName.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub FormAddCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idGenerator()
    End Sub

    Public Sub idGenerator()
        Try
            Using connection As New SqlConnection(dbHandler.getConnectionString)
                connection.Open()
                Dim isUnique As Boolean = False

                Do
                    ' Generate a new ID
                    TextBox1.Text = dbHandler.categoryGenerateId()

                    ' Check if the generated ID already exists in the database
                    Dim cmd As New SqlCommand With {
                .Connection = connection,
                .CommandText = "SELECT COUNT(*) FROM category1 WHERE id = @id"
            }
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text)

                    Dim result As Integer = CInt(cmd.ExecuteScalar())

                    ' If the result is 0, the ID is unique
                    isUnique = (result = 0)
                Loop While Not isUnique

                ' The unique ID is generated and can be used or processed as needed
                Console.WriteLine("Unique ID: " & TextBox1.Text)

                connection.Close()
            End Using
        Catch ex As Exception
            ' Handle the exception or rethrow it for higher-level error handling
            Throw ex

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveCategory()
    End Sub


End Class