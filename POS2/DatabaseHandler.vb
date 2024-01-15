Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows
Imports iText.StyledXmlParser.Jsoup.Select.Evaluator
Imports iTextSharp.text.xml.simpleparser
Imports Mysqlx
Imports OracleInternal

Public Class DatabaseHandler
    ReadOnly dbPath As String = System.Windows.Forms.Application.StartupPath.Substring(0, (System.Windows.Forms.Application.StartupPath.Length - 10))
    ReadOnly dbName As String = "HONEST_CITY_HARDWARE_DATA.MDF"


    Public Function getConnectionString() As String
        Dim connectionString As String = "Data Source= LINUSPC\SQLEXPRESS; Database= " & dbName & ";USER= admin;PASSWORD= jonas12345;"
        '192.168.1.117,49172'
        'MIKAYSSII\SQLEXPRESS
        Return connectionString
    End Function

    Public Sub New()
        'Dim connectionString As String = "Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = " + dbPath + "\database\" + dbName + "; Integrated Security=True; Connect Timeout = 30"
        Dim conn1 As New SqlConnection(getConnectionString)
    End Sub

    Public Function GetLogs() As DataTable
        Dim query As String = "SELECT * FROM signin_logs"
        Dim cmdSelect As SqlCommand = Nothing
        Dim adapter As SqlDataAdapter = Nothing
        Dim dataTable As New DataTable()
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim isUnique As Boolean = False
                cmdSelect = New SqlCommand(query, connection)
                adapter = New SqlDataAdapter(cmdSelect)

                adapter.Fill(dataTable)
                connection.Close()
            End Using
            Return dataTable
        Catch ex As Exception
            Return Nothing
        Finally
            If adapter IsNot Nothing Then
                adapter.Dispose()
            End If

            If cmdSelect IsNot Nothing Then
                cmdSelect.Dispose()
            End If
        End Try
    End Function

    'GENERATE ID
    Private Function GenerateIds() As Integer
        Dim id As Integer = 0
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim cmd As New SqlCommand With {
                .Connection = connection,
                .CommandText = "SELECT MAX(id) FROM sales"
            }
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    id = Convert.ToInt32(result) + 1
                End If
                connection.Close()
            End Using
        Catch
        End Try
        Return id
    End Function
    'ADD LOGS
    Public Function AddLog(isSignIn As Boolean, user As User) As Boolean
        Dim now As DateTime = DateTime.Now
        Dim currentDateTimeString As String = now.ToString("MM-dd-yyyy h:mm: tt")
        Dim query As String = "insert into signin_logs ([id], [data], [signin]) values (@id, @data, @signin)"
        Dim cmdAdd As SqlCommand = Nothing
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                cmdAdd = New SqlCommand(query, connection)
                If isSignIn Then
                    cmdAdd.Parameters.AddWithValue("@id", GenerateId)
                    cmdAdd.Parameters.AddWithValue("@data", user.Username & " signed in on " & currentDateTimeString)
                    cmdAdd.Parameters.AddWithValue("@signin", isSignIn)
                Else
                    cmdAdd.Parameters.AddWithValue("@id", GenerateId)
                    cmdAdd.Parameters.AddWithValue("@data", user.Username & " signed out on " & currentDateTimeString)
                    cmdAdd.Parameters.AddWithValue("@signin", isSignIn)
                End If

                cmdAdd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            Return True
        Finally
            If cmdAdd IsNot Nothing Then
                cmdAdd.Dispose()
            End If
        End Try
    End Function
    'GENERATE ID
    Public Sub CheckExpires()
        Dim currentDate As DateTime = DateTime.Now
        Dim formattedDate As String = currentDate.ToString("MM-dd-yyyy")
        Dim dateFormat As String = "MM-dd-yyyy"
        Dim currentFormattedDate As DateTime = DateTime.ParseExact(formattedDate, dateFormat, Nothing)

        Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim cmd As New SqlCommand With {
                .Connection = connection,
                .CommandText = "SELECT * FROM products where available = 'true'"
            }
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                For i As Integer = 0 To dt.Rows.Count() - 1
                    If Not dt.Rows(i).Item(9).ToString = "NO EXPIRATION" Then
                        'MsgBox(dt.Rows(i).Item(0))
                        Dim parsedDate As DateTime = DateTime.ParseExact(dt.Rows(i).Item(9).ToString, dateFormat, Nothing)
                        If (IsItemExpired(parsedDate, currentFormattedDate)) Then
                            'MsgBox(dt.Rows(i).Item(0) & " is expired")
                            Dim cmd2 As New SqlCommand With {
                                   .Connection = connection,
                                   .CommandText = "DELETE FROM products
                                                    WHERE batch_id = @id"
                                }
                            cmd2.Parameters.AddWithValue("@id", Convert.ToInt32(dt.Rows(i).Item(0)))
                            cmd2.ExecuteNonQuery()
                            Dim cmd1 As New SqlCommand With {
                                    .Connection = connection,
                                    .CommandText = "INSERT INTO expired
                                                   ([id]
                                                   ,[product_id]
                                                   ,[category]
                                                   ,[name]
                                                   ,[classification]
                                                   ,[brand]
                                                   ,[size]
                                                   ,[color]
                                                   ,[quantity]
                                                   ,[expdate])
                                             VALUES
                                                   (@id
                                                   ,@product_id
                                                   ,@category
                                                   ,@name
                                                   ,@classification
                                                   ,@brand
                                                   ,@size
                                                   ,@color
                                                   ,@quantity
                                                   ,@expdate)"
                                }
                            cmd1.Parameters.AddWithValue("@id", Convert.ToInt32(dt.Rows(i).Item(0)))
                            cmd1.Parameters.AddWithValue("@product_id", dt.Rows(i).Item(1).ToString)
                            cmd1.Parameters.AddWithValue("@category", dt.Rows(i).Item(4).ToString)
                            cmd1.Parameters.AddWithValue("@name", dt.Rows(i).Item(2).ToString)
                            cmd1.Parameters.AddWithValue("@classification", dt.Rows(i).Item(13).ToString)
                            cmd1.Parameters.AddWithValue("@brand", dt.Rows(i).Item(3).ToString)
                            cmd1.Parameters.AddWithValue("@size", dt.Rows(i).Item(6).ToString)
                            cmd1.Parameters.AddWithValue("@color", dt.Rows(i).Item(7).ToString)
                            cmd1.Parameters.AddWithValue("@quantity", Convert.ToInt32(dt.Rows(i).Item(11)))
                            cmd1.Parameters.AddWithValue("@expdate", dt.Rows(i).Item(9).ToString)
                            cmd1.ExecuteNonQuery()
                            'MsgBox(Convert.ToInt32(dt.Rows(i).Item(0)) & " pass")

                        End If
                    End If
                Next
                connection.Close()
            End Using

    End Sub


    Public Function checkToBeExpired() As Integer
        Dim currentDate As DateTime = DateTime.Now
        Dim formattedDate As String = currentDate.ToString("MM-dd-yyyy")
        Dim dateFormat As String = "MM-dd-yyyy"
        Dim currentFormattedDate As DateTime = DateTime.ParseExact(formattedDate, dateFormat, Nothing)
        Dim countExpire As Integer = 0
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim cmd As New SqlCommand With {
                .Connection = connection,
                .CommandText = "SELECT * FROM products where available = 'true'"
            }
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)

                For i As Integer = 0 To dt.Rows.Count() - 1
                    If Not dt.Rows(i).Item(9).ToString = "NO EXPIRATION" Then
                        'MsgBox(dt.Rows(i).Item(0))
                        Dim parsedDate As DateTime = DateTime.ParseExact(dt.Rows(i).Item(9).ToString, dateFormat, Nothing)
                        If parsedDate <= DateTime.Now.AddDays(5).Date Then
                            countExpire = countExpire + 1
                        End If
                    End If
                Next
                connection.Close()
            End Using
        Catch
            checkToBeExpired()
        End Try

        Return countExpire
    End Function

    Function IsItemExpired(ByVal expirationDate As DateTime, ByVal currentDate As DateTime) As Boolean
        If (expirationDate <= currentDate) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function categoryGenerateId() As String
        ' Specify the maximum count per alphabet
        Dim maxCount As Integer = 50
        Dim id As String = ""
        ' Specify the number of alphabets
        Dim numberOfAlphabets As Integer = Asc("Z") - Asc("A") + 1

        ' Create a Random object
        Dim rand As New Random()

        ' Generate random IDs
        For count As Integer = 1 To maxCount
            ' Get a random alphabet index
            Dim alphabetIndex As Integer = rand.Next(0, numberOfAlphabets)
            Dim randomNumber As Integer = rand.Next(0, maxCount)

            ' Convert the random index to an alphabet character
            Dim randomAlphabet As Char = Chr(Asc("A") + alphabetIndex)

            ' Generate the random ID
            Dim generatedID As String = $"{randomAlphabet}{randomNumber}"
            id = generatedID
        Next
        Return id
    End Function
    Public Function GenerateId() As String
        Dim Min As Integer = 100000000
        Dim Max As Integer = 999999999
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    'SIGN IN
    Public Function Signin(ByVal username As String, ByVal password As String) As Boolean
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = New SqlCommand("select * from users where username = @username and password = @password", connection)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            If (dt.Rows.Count > 0) Then
                Return True
            Else
                Return False
            End If
            connection.Close()
        End Using
    End Function

    'change pass
    Public Function Changepassword(ByVal username As String, ByVal password As String) As Boolean
        ' Update the user's password in the database
        Dim query As String = "UPDATE users SET password = @pass WHERE username = @user"

        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", password)

                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using

        Return True
    End Function
    'FORGOT PASSWORD
    Public Function ForgotPassword(ByVal username As String, ByVal Secretquestion As String, ByVal Answer As String) As Boolean
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = New SqlCommand("select * from users where username = @username and secretquestion = @quest and answer = @ans", connection)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@quest", Secretquestion)
            cmd.Parameters.AddWithValue("@ans", Answer)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)

            If (dt.Rows.Count > 0) Then
                Return True
            Else
                Return False
            End If
            connection.Close()
        End Using
    End Function
    'ADD EMPLOYEE
    Public Function AddNewEmployee(user As User) As Boolean
        Dim query As String = "insert into users ([id], [username], [password], [role], [secretquestion], [answer]) values (@id, @username, @password, @role, @quest, @ans)"
        Dim cmdAdd As SqlCommand = Nothing


        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            cmdAdd = New SqlCommand(query, connection)
            cmdAdd.Parameters.AddWithValue("@id", user.Id)
            cmdAdd.Parameters.AddWithValue("@username", user.Username)
            cmdAdd.Parameters.AddWithValue("@password", user.Password)
            cmdAdd.Parameters.AddWithValue("@role", user.Role)
            cmdAdd.Parameters.AddWithValue("@quest", user.Secretquestion)
            cmdAdd.Parameters.AddWithValue("@ans", user.Answer)

            cmdAdd.ExecuteNonQuery()
            Return True
            connection.Close()
        End Using

        If cmdAdd IsNot Nothing Then
            cmdAdd.Dispose()
        End If

    End Function
    'ADD CATEGORY
    Public Function AddNewCategory(_category As Category) As Boolean
        Dim query As String = "INSERT INTO category1
           ([id]
           ,[categoryName]
           ,[categoryClass]
           ,[categoryBrand]
           ,[lengthWidth]
           ,[height]
           ,[thickness]
           ,[weight]
           ,[electricity]
           ,[volume]
           ,[size])
     VALUES
           (@id, 
            @display_name, 
            @categoryClass,
            @categoryBrand,
            @lengthWidth,
            @height,
            @thickness,
            @weight,
            @electricity,
            @volume,
            @size)"
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim cmdAdd As SqlCommand = New SqlCommand(query, connection)
                cmdAdd.Parameters.AddWithValue("@id", _category.Id())
                cmdAdd.Parameters.AddWithValue("@display_name", _category.DisplayName)
                cmdAdd.Parameters.AddWithValue("@categoryClass", _category.categoryClass)
                cmdAdd.Parameters.AddWithValue("@categoryBrand", _category.categoryBrand)
                cmdAdd.Parameters.AddWithValue("@lengthWidth", _category.lengthWidth)
                cmdAdd.Parameters.AddWithValue("@height", _category.height)
                cmdAdd.Parameters.AddWithValue("@thickness", _category.thickness)
                cmdAdd.Parameters.AddWithValue("@weight", _category.weight)
                cmdAdd.Parameters.AddWithValue("@electricity", _category.electricity)
                cmdAdd.Parameters.AddWithValue("@volume", _category.volume)
                cmdAdd.Parameters.AddWithValue("@size", _category.size)
                cmdAdd.ExecuteNonQuery()
                connection.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    'ADD PRODUCT
    Public Function AddNewProduct(_product As Product) As Boolean
        Dim query As String = "insert into products ([batch_id],[id], [name], [brand], [category], [unit], [size], [colors], [price], [expiration_date], [stock], [critical_stock_limit], [available], [expires], [classification], [item_description]) values (@batch_id, @id,  @name, @brand, @category, @unit, @size, @color, @price, @expiration_date, @stock, @critical_stock_limit, @available, @expires, @classification, @item_description)"

        Dim cmdAdd As SqlCommand = Nothing
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                cmdAdd = New SqlCommand(query, connection)
                cmdAdd.Parameters.AddWithValue("@batch_id", _product.Batch_Id)
                cmdAdd.Parameters.AddWithValue("@id", _product.Id)
                cmdAdd.Parameters.AddWithValue("@name", _product.Name)
                cmdAdd.Parameters.AddWithValue("@classification", _product.Classification)
                cmdAdd.Parameters.AddWithValue("@brand", _product.Brand)
                cmdAdd.Parameters.AddWithValue("@category", _product.Category)
                cmdAdd.Parameters.AddWithValue("@unit", _product.Unit.ToLower)
                cmdAdd.Parameters.AddWithValue("@size", _product.Size)
                cmdAdd.Parameters.AddWithValue("@color", _product.Colors)
                cmdAdd.Parameters.AddWithValue("@price", _product.Price)
                cmdAdd.Parameters.AddWithValue("@expiration_date", _product.Expiration_Date)
                cmdAdd.Parameters.AddWithValue("@stock", _product.Stock)
                cmdAdd.Parameters.AddWithValue("@critical_stock_limit", _product.Critical_Stock_Limit)
                cmdAdd.Parameters.AddWithValue("@available", _product.Available)
                cmdAdd.Parameters.AddWithValue("@expires", _product.Expires)
                cmdAdd.Parameters.AddWithValue("@item_description", _product.Item_Description)
                cmdAdd.ExecuteNonQuery()
                connection.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        Finally
            If cmdAdd IsNot Nothing Then
                cmdAdd.Dispose()
            End If
        End Try
    End Function
    'ADD DAMAGED PRODCUCT
    Public Function AddDamagedProduct(_product As Damage) As Boolean
        Dim query As String = "insert into damages ([id], [product_id], [date], [quantity], [remarks]) values (@id, @product_id, @date, @quantity, @remarks)"

        Dim cmdAdd As SqlCommand = Nothing
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                cmdAdd = New SqlCommand(query, connection)
                cmdAdd.Parameters.AddWithValue("@id", _product.Id)
                cmdAdd.Parameters.AddWithValue("@product_id", _product.Product_Id)
                cmdAdd.Parameters.AddWithValue("@date", _product.DamagesDate)
                cmdAdd.Parameters.AddWithValue("@quantity", _product.Quantity)
                cmdAdd.Parameters.AddWithValue("@remarks", _product.Remarks)

                cmdAdd.ExecuteNonQuery()
                connection.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        Finally
            If cmdAdd IsNot Nothing Then
                cmdAdd.Dispose()
            End If
        End Try
    End Function

    'ADD EXPIRED PRODUCT
    Public Function AddExpiredProduct(_product As Expired) As Boolean
        Dim query As String = "insert into expired ([id], [product_id], [date], [quantity], [name]) values (@id, @product_id, @date, @quantity, @name)"

        Dim cmdAdd As SqlCommand = Nothing

        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                cmdAdd = New SqlCommand(query, connection)
                cmdAdd.Parameters.AddWithValue("@id", _product.Id)
                cmdAdd.Parameters.AddWithValue("@product_id", _product.Product_Id)
                cmdAdd.Parameters.AddWithValue("@date", _product.ExpiredDate)
                cmdAdd.Parameters.AddWithValue("@quantity", _product.Quantity)
                cmdAdd.Parameters.AddWithValue("@quantity", _product.Name)

                cmdAdd.ExecuteNonQuery()
                connection.Close()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show($"Failed to add expired product. Error: {ex.Message}", "Failed")

            Return False
        Finally
            If cmdAdd IsNot Nothing Then
                cmdAdd.Dispose()
            End If
        End Try
    End Function

    'Public Function GetExpired() As List(Of Expired)

    '    Dim cmd As SqlCommand = Nothing
    '    Dim adapter As SqlDataAdapter = Nothing
    '    Dim productList As New List(Of Expired)

    '    Try
    '        Using connection As New SqlConnection(getConnectionString)
    '            connection.Open()
    '            Dim sql As String = "SELECT * FROM expired"
    '            cmd = New SqlCommand(sql, connection)
    '            adapter = New SqlDataAdapter(cmd)
    '            Dim dt As New DataTable()
    '            adapter.Fill(dt)

    '            For Each row As DataRow In dt.Rows
    '                Dim product As New Expired With {
    '                    .Id = Convert.ToInt32(row("id")),
    '                    .Product_Id = Convert.ToString(row("product_id")),
    '                    .Quantity = Convert.ToString(row("quantity")),
    '                    .ExpiredDate = Convert.ToString(row("date"))
    '                }
    '                productList.Add(product)
    '            Next
    '            Return productList
    '            connection.Close()
    '        End Using
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        adapter?.Dispose()
    '        cmd?.Dispose()
    '    End Try
    'End Function

    'GET ALL EMPLOYEES
    Public Function GetAllEmployees() As DataTable
        Dim cmd As SqlCommand = Nothing
        Dim sqlDa As SqlDataAdapter = Nothing
        Dim dTable As DataTable = Nothing
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                cmd = New SqlCommand("select * from users", connection)
                sqlDa = New SqlDataAdapter(cmd)
                dTable = New DataTable()
                sqlDa.Fill(dTable)
                connection.Close()
            End Using
        Catch ex As Exception
            ' Handle the exception here as per your requirement '
        Finally
            If sqlDa IsNot Nothing Then sqlDa.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
        Return dTable
    End Function
    'UPDATE SALE
    Public Function UpdateSale(sale As Sale) As Boolean
        ' Update the user's password in the database
        Dim query As String = "UPDATE sales SET returned = @returned, remarks = @remarks WHERE id = @id"

        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@id", sale.Id)
                cmd.Parameters.AddWithValue("@returned", sale.Returned)
                cmd.Parameters.AddWithValue("@remarks", sale.Remarks)
                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using

        Return True
    End Function
    'ADD SALE
    Public Function AddSale(ByVal sale As Sale) As Boolean
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim cmd As SqlCommand = New SqlCommand("INSERT INTO sales (invoice_number, product_id, item_name, item_quantity, item_price, item_total_price, total_payment, customer_name, customer_address, customer_contact, release_date, release_time, payment_method, order_type, returned, remarks, delivered, pending, delivery_date) VALUES (@invoice_number, @product_id, @item_name, @item_quantity, @item_price, @item_total_price, @total_payment, @customer_name, @customer_address, @customer_contact, @release_date, @release_time, @payment_method, @order_type, @returned, @remarks, @delivered, @pending, @delivery_date)", connection)

                cmd.Parameters.AddWithValue("@invoice_number", sale.Invoice_Number)
                cmd.Parameters.AddWithValue("@product_id", sale.Product_Id)
                cmd.Parameters.AddWithValue("@item_name", sale.Product_Name)
                cmd.Parameters.AddWithValue("@item_quantity", sale.Quantity)
                cmd.Parameters.AddWithValue("@item_price", sale.Price)
                cmd.Parameters.AddWithValue("@item_total_price", sale.Total_Price)
                cmd.Parameters.AddWithValue("@total_payment", sale.Total_Payment)
                cmd.Parameters.AddWithValue("@customer_name", sale.Customer_Name)
                cmd.Parameters.AddWithValue("@customer_address", sale.Customer_Address)
                cmd.Parameters.AddWithValue("@customer_contact", sale.Customer_Contact)
                cmd.Parameters.AddWithValue("@release_date", sale.Release_Date)
                cmd.Parameters.AddWithValue("@release_time", sale.Release_Time)
                cmd.Parameters.AddWithValue("@payment_method", sale.Payment_Method)
                cmd.Parameters.AddWithValue("@order_type", sale.Order_Type)
                cmd.Parameters.AddWithValue("@returned", sale.Returned)
                cmd.Parameters.AddWithValue("@remarks", sale.Remarks)
                cmd.Parameters.AddWithValue("@delivered", sale.Delivered)
                cmd.Parameters.AddWithValue("@pending", sale.Pending)
                cmd.Parameters.AddWithValue("@delivery_date", sale.DeliveryDate)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                connection.Close()
                Return rowsAffected > 0
            End Using
        Catch ex As Exception
            ' Handle the exception or rethrow it for higher-level error handling
            Throw ex
        End Try
    End Function

    'UPDATE SALE
    Public Function SetDeliveredSale(invoiceNumber As String, pending As Boolean) As Boolean
        Dim query As String = "UPDATE sales SET pending = @pending WHERE invoice_number = @invoiceNumber"

        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@invoiceNumber", invoiceNumber)
                cmd.Parameters.AddWithValue("@pending", pending)
                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using

        Return True
    End Function

    'ADD SALED
    Public Function AddSaled(ByVal sale As Sale) As Boolean
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim cmd As SqlCommand = New SqlCommand("INSERT INTO sales (id, invoice_number, item_name, item_quantity, item_price, item_total_price, total_payment, customer_name, customer_address, customer_contact, release_date, release_time, payment_method, order_type, returned, remarks, delivered) VALUES (@id, @invoice_number, @item_name, @item_quantity, @item_price, @item_total_price, @total_payment, @customer_name, @customer_address, @customer_contact, @release_date, @release_time, @payment_method, @order_type, @returned, @remarks, @delivered)", connection)

                cmd.Parameters.AddWithValue("@id", sale.Id)
                cmd.Parameters.AddWithValue("@invoice_number", sale.Invoice_Number)
                cmd.Parameters.AddWithValue("@item_name", sale.Product_Name)
                cmd.Parameters.AddWithValue("@item_quantity", sale.Quantity)
                cmd.Parameters.AddWithValue("@item_price", sale.Price)
                cmd.Parameters.AddWithValue("@item_total_price", sale.Total_Price)
                cmd.Parameters.AddWithValue("@total_payment", sale.Total_Payment)
                cmd.Parameters.AddWithValue("@customer_name", sale.Customer_Name)
                cmd.Parameters.AddWithValue("@customer_address", sale.Customer_Address)
                cmd.Parameters.AddWithValue("@customer_contact", sale.Customer_Contact)
                cmd.Parameters.AddWithValue("@release_date", sale.Release_Date)
                cmd.Parameters.AddWithValue("@release_time", sale.Release_Time)
                cmd.Parameters.AddWithValue("@payment_method", sale.Payment_Method)
                cmd.Parameters.AddWithValue("@order_type", sale.Order_Type)
                cmd.Parameters.AddWithValue("@returned", sale.Returned)
                cmd.Parameters.AddWithValue("@remarks", sale.Remarks)
                cmd.Parameters.AddWithValue("@delivered", sale.Delivered)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                connection.Close()
                Return rowsAffected > 0
            End Using
        Catch ex As Exception
            ' Handle the exception or rethrow it for higher-level error handling
            Throw ex
        End Try
    End Function

    'GET SALE
    Public Function GetSale() As List(Of Sale)
        Dim sales As New List(Of Sale)()
        Dim dataTable As New DataTable()
        Dim dt As New DataTable()
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim cmd As New SqlCommand With {
                    .Connection = connection,
                    .CommandText = "SELECT * FROM sales"
                }
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ' Create a new Sale object and populate it with data from the current row in the result set
                    Dim sale As New Sale With {
                        .Id = Convert.ToInt32(reader("id")),
                        .Invoice_Number = reader("invoice_number").ToString(),
                        .Product_Id = reader("product_id").ToString(),
                        .Product_Name = reader("item_name").ToString(),
                        .Quantity = Convert.ToInt32(reader("item_quantity")),
                        .Price = Convert.ToInt32(reader("item_price")),
                        .Total_Price = Convert.ToInt32(reader("item_total_price")),
                        .Total_Payment = Convert.ToInt32(reader("total_payment")),
                        .Customer_Name = reader("customer_name").ToString(),
                        .Customer_Address = reader("customer_address").ToString(),
                        .Customer_Contact = reader("customer_contact").ToString(),
                        .Release_Date = reader("release_date").ToString(),
                        .Release_Time = reader("release_time").ToString(),
                        .Payment_Method = reader("payment_method").ToString(),
                        .Order_Type = reader("order_type").ToString(),
                        .Returned = reader.GetBoolean(reader.GetOrdinal("returned")),
                        .Remarks = reader("remarks").ToString(),
                        .Delivered = reader.GetBoolean(reader.GetOrdinal("delivered")),
                        .Pending = reader.GetBoolean(reader.GetOrdinal("pending")),
                        .DeliveryDate = reader.GetOrdinal("delivery_date").ToString
                    }
                    ' Add the Sale object to the list of sales
                    sales.Add(sale)
                End While
                ' Close the reader and release the connection back to the connection pool
                reader.Close()
                connection.Close()
            End Using
        Catch

        End Try
        ' Return the list of sales
        Return sales
    End Function
    'Get WEEKLY SALE.
    Public Function GetSalesWeekly() As List(Of Sale)
        Dim sales As New List(Of Sale)()
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                ' Get sales data for the last 7 days
                Dim cmd As New SqlCommand With {
                    .Connection = connection,
                    .CommandText = "SELECT * FROM sales WHERE release_date >= @start_date AND release_date <= @end_date"
                }
                cmd.Parameters.AddWithValue("@start_date", DateTime.Now.AddDays(-7).ToString("MM-dd-yyyy"))
                cmd.Parameters.AddWithValue("@end_date", DateTime.Now.ToString("MM-dd-yyyy"))

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ' Create a new Sale object and populate it with data from the current row in the result set
                    Dim sale As New Sale With {
                    .Id = Convert.ToInt32(reader("id")),
                    .Invoice_Number = Convert.ToInt32(reader("invoice_number")),
                    .Product_Name = reader("item_name").ToString(),
                    .Quantity = Convert.ToInt32(reader("item_quantity")),
                    .Price = Convert.ToInt32(reader("item_price")),
                    .Total_Price = Convert.ToInt32(reader("item_total_price")),
                    .Total_Payment = Convert.ToInt32(reader("total_payment")),
                    .Customer_Name = reader("customer_name").ToString(),
                    .Customer_Address = reader("customer_address").ToString(),
                    .Customer_Contact = reader("customer_contact").ToString(),
                    .Release_Date = reader("release_date").ToString(),
                    .Release_Time = reader("release_time").ToString(),
                    .Payment_Method = reader("payment_method").ToString(),
                    .Order_Type = reader("order_type").ToString(),
                    .Returned = Convert.ToInt32(reader("returned")),
                    .Remarks = reader("remarks").ToString(),
                    .Delivered = Convert.ToInt32(reader("delivered"))
                }
                    ' Add the Sale object to the list of sales
                    sales.Add(sale)
                End While

                ' Close the reader and release the connection back to the connection pool
                reader.Close()
                connection.Close()
            End Using
        Catch ex As Exception
            ' Handle the exception or rethrow it for higher-level error handling
            Throw ex
        End Try

        ' Return the list of sales
        Return sales
    End Function
    'Get MONTHLY SALE
    Public Function GetSalesMonthly() As List(Of Sale)
        Dim sales As New List(Of Sale)()

        Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                ' Get sales data for the last 30 days
                Dim cmd As New SqlCommand With {
                .Connection = connection,
                .CommandText = "SELECT * FROM sales WHERE release_date >= @start_date AND release_date <= @end_date"
            }
                connection.Close()
                connection.Open()

                cmd.Parameters.AddWithValue("@start_date", "01-01-2023")
                cmd.Parameters.AddWithValue("@end_date", DateTime.Now.ToString("MM-dd-yyyy"))

                'cmd.Parameters.AddWithValue("@start_date", DateTime.Now.AddDays(-30).ToString("MM-dd-yyyy"))
                'cmd.Parameters.AddWithValue("@end_date", DateTime.Now.ToString("MM-dd-yyyy"))

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ' Create a new Sale object and populate it with data from the current row in the result set
                    Dim sale As New Sale With {
                    .Id = Convert.ToInt32(reader("id")),
                    .Invoice_Number = Convert.ToInt32(reader("invoice_number")),
                    .Product_Name = reader("item_name").ToString(),
                    .Quantity = Convert.ToInt32(reader("item_quantity")),
                    .Price = Convert.ToInt32(reader("item_price")),
                    .Total_Price = Convert.ToInt32(reader("item_total_price")),
                    .Total_Payment = Convert.ToInt32(reader("total_payment")),
                    .Customer_Name = reader("customer_name").ToString(),
                    .Customer_Address = reader("customer_address").ToString(),
                    .Customer_Contact = reader("customer_contact").ToString(),
                    .Release_Date = reader("release_date").ToString(),
                    .Release_Time = reader("release_time").ToString(),
                    .Payment_Method = reader("payment_method").ToString(),
                    .Order_Type = reader("order_type").ToString(),
                    .Returned = Convert.ToInt32(reader("returned")),
                    .Remarks = reader("remarks").ToString(),
                    .Delivered = Convert.ToInt32(reader("delivered"))
                }
                    ' Add the Sale object to the list of sales
                    sales.Add(sale)
                End While

                ' Close the reader and release the connection back to the connection pool
                reader.Close()
                connection.Close()
            End Using


        ' Return the list of sales
        Return sales
    End Function
    'DELETE EMPLOYEE
    Public Function DeleteEmployee(userId As String) As Boolean
        Dim query As String = "DELETE FROM users WHERE id = @userId"
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@userId", userId)

            Try
                cmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Return False
            Finally
                cmd.Dispose()
                connection.Close()
            End Try
        End Using

    End Function
    'GET EMPLOYEE BY USERNAMES
    Public Function GetEmployeeByUsernames(username As String) As DataTable
        Dim query As String = "SELECT * FROM users WHERE username = @username"
        Dim dataTable As DataTable = New DataTable()

        Using connection As New SqlConnection(getConnectionString),
          cmd As SqlCommand = New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)
            connection.Open()
            Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                sda.Fill(dataTable)
            End Using
            connection.Close()
        End Using
        MsgBox(dataTable.Rows(0).Item(0))
        Return dataTable
    End Function
    'GET EMPLOYEE BY USERNAME
    Public Function GetEmployeeByUsername(ByVal username As String) As User
        Dim query As String = "SELECT * FROM users WHERE username = @uname"
        Dim user As User = Nothing

        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@uname", username)

                Try
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()
                        user = New User With {
                            .Id = reader.GetString(reader.GetOrdinal("id")),
                            .Username = reader.GetString(reader.GetOrdinal("username")),
                            .Password = reader.GetString(reader.GetOrdinal("password")),
                            .Role = reader.GetString(reader.GetOrdinal("role"))
                           }
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                End Try
            End Using

            connection.Close()
        End Using

        Return user
    End Function

    'GET account BY USERNAME
    Public Function GetaccountByUsername(ByVal username As String) As User
        Dim query As String = "SELECT * FROM users WHERE username = @uname"
        Dim user As User = Nothing

        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@uname", username)

                Try
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()
                        user = New User With {
                            .Id = reader.GetInt32(reader.GetOrdinal("id")),
                            .Username = reader.GetString(reader.GetOrdinal("username")),
                            .Password = reader.GetString(reader.GetOrdinal("password")),
                            .Role = reader.GetString(reader.GetOrdinal("role")),
                            .Secretquestion = reader.GetString(reader.GetOrdinal("secretquestion")),
                            .Answer = reader.GetString(reader.GetOrdinal("answer"))
                        }
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                End Try
            End Using

            connection.Close()
        End Using

        Return user
    End Function


    'GET AVAILABLE STOCK
    Public Function GetAvailableStock(productName As String) As Integer
        Dim cmd As SqlCommand = Nothing
        Dim availableStock As Integer = 0
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                cmd = New SqlCommand("SELECT stock FROM products WHERE name = @name", connection)
                cmd.Parameters.AddWithValue("@name", productName)

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    availableStock = Convert.ToInt32(reader("stock"))
                End If
                connection.Close()
            End Using
        Catch

        Finally
            cmd?.Dispose()
        End Try

        Return availableStock
    End Function
    'UPDATE PRODUCT STOCK
    Public Function DecreaseProductStock(productId As String, count As Integer) As Boolean

        Dim cmd As SqlCommand = Nothing
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                cmd = New SqlCommand("UPDATE products SET stock = stock - @count WHERE id = @id AND stock >= @count", connection)
                cmd.Parameters.AddWithValue("@id", productId)
                cmd.Parameters.AddWithValue("@count", count)

                Dim rowsAffected = cmd.ExecuteNonQuery()
                If rowsAffected >= 0 Then
                    Return True
                Else
                    Return False
                End If
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to decrease product stock. Error: {ex.Message}", "Failed")
            Return False
        Finally
            cmd?.Dispose()
        End Try
    End Function

    'INCREASE PRODUCT STOCK
    Public Function IncreaseProductStock(productId As Integer, count As Integer) As Boolean
        Debug.WriteLine($"Updating stock for product {productId} by {count} units")
        Dim cmd As SqlCommand = Nothing

        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                cmd = New SqlCommand("UPDATE products SET stock = stock + @count WHERE id = @id", connection)
                cmd.Parameters.AddWithValue("@id", productId)
                cmd.Parameters.AddWithValue("@count", count)

                Dim rowsAffected = cmd.ExecuteNonQuery()
                If rowsAffected = 1 Then
                    Return True
                Else
                    Return False
                End If
                connection.Close()
            End Using
        Catch ex As Exception
            Return False
        Finally
            cmd?.Dispose()
        End Try
    End Function

    'DELETE PRODUCT
    Public Function DeleteProduct(productId As String) As Boolean
        Dim query As String = "DELETE FROM products WHERE id = @id"
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", productId)
            Try
                cmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Return False
            Finally
                cmd.Dispose()
                connection.Close()
            End Try
        End Using
    End Function
    'GET PRODUCTS BY NAME
    Public Function GetProductsByNames(ByVal name As String) As DataTable
        Dim query As String = "SELECT * FROM products WHERE name LIKE @name"
        Dim dataTable As DataTable = New DataTable()

        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@name", "%" & Regex.Replace(name, "[^0-9a-zA-Z]+", "%") & "%")

                Try
                    Using sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                        sda.Fill(dataTable)
                    End Using
                Catch ex As Exception
                    Throw
                End Try
            End Using

            connection.Close()
        End Using

        Return dataTable
    End Function
    'GET CATEGORIES
    Public Function GetCategories() As List(Of Category)
        Dim cmd As SqlCommand = Nothing
        Dim adapter As SqlDataAdapter = Nothing
        Dim categryList As New List(Of Category)

        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM category1 ORDER BY categoryName"
                cmd = New SqlCommand(sql, connection)
                adapter = New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                For Each row As DataRow In dt.Rows
                    Dim product As New Category With {
                        .Id = Convert.ToString(row("id")),
                        .DisplayName = Convert.ToString(row("categoryName")),
                        .categoryClass = Convert.ToString(row("categoryClass")),
                        .categoryBrand = Convert.ToString(row("categoryBrand")),
                        .lengthWidth = Convert.ToBoolean(row("lengthWidth")),
                        .height = Convert.ToBoolean(row("height")),
                        .thickness = Convert.ToBoolean(row("thickness")),
                        .weight = Convert.ToBoolean(row("weight")),
                        .electricity = Convert.ToBoolean(row("electricity")),
                        .volume = Convert.ToBoolean(row("volume")),
                        .size = Convert.ToBoolean(row("size"))
                    }
                    categryList.Add(product)
                Next

                Return categryList
                connection.Close()
            End Using
        Catch

        Finally
            adapter?.Dispose()
            cmd?.Dispose()
        End Try
    End Function
    'GET PRODUCTS
    Public Function GetProducts() As List(Of Product)

        Dim cmd As SqlCommand = Nothing
        Dim adapter As SqlDataAdapter = Nothing
        Dim productList As New List(Of Product)

        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM products ORDER BY category"
                cmd = New SqlCommand(sql, connection)
                adapter = New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                For Each row As DataRow In dt.Rows
                    Dim product As New Product With {
                        .Batch_Id = Convert.ToInt32(row("batch_id")),
                        .Id = Convert.ToString(row("id")),
                        .Name = Convert.ToString(row("name")),
                        .Brand = Convert.ToString(row("brand")),
                        .Category = Convert.ToString(row("category")),
                        .Unit = Convert.ToString(row("unit")),
                        .Size = Convert.ToString(row("size")),
                        .Colors = Convert.ToString(row("colors")),
                        .Price = Convert.ToDouble(row("price")),
                        .Expiration_Date = Convert.ToString(row("expiration_date")),
                        .Critical_Stock_Limit = Convert.ToInt32(row("critical_stock_limit")),
                        .Stock = Convert.ToInt32(row("stock")),
                        .Available = Convert.ToBoolean(row("available")),
                        .Classification = Convert.ToString(row("classification")),
                        .Expires = Convert.ToString(row("expires"))
                    }
                    productList.Add(product)
                Next

                Return productList
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            adapter?.Dispose()
            cmd?.Dispose()
        End Try
    End Function
    'GET Damages
    Public Function GetDamages() As List(Of Damage)

        Dim cmd As SqlCommand = Nothing
        Dim adapter As SqlDataAdapter = Nothing
        Dim productList As New List(Of Damage)

        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM damages"
                cmd = New SqlCommand(sql, connection)
                adapter = New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                For Each row As DataRow In dt.Rows
                    Dim product As New Damage With {
                        .Id = Convert.ToInt32(row("id")),
                        .Product_Id = Convert.ToString(row("product_id")),
                        .Quantity = Convert.ToString(row("quantity")),
                        .DamagesDate = Convert.ToString(row("date")),
                        .Remarks = Convert.ToString(row("remarks"))
                    }
                    productList.Add(product)
                Next

                Return productList
                connection.Close()
            End Using
        Catch

        Finally
            adapter?.Dispose()
            cmd?.Dispose()
        End Try
    End Function
    'UPDATE PRODUCT
    Public Function UpdateProduct(product As Product) As Boolean
        ' Update the user's password in the database

        Dim query As String = "UPDATE products SET stock = @stock WHERE id = @id"
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@id", product.Id)
                cmd.Parameters.AddWithValue("@stock", product.Stock)
                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using

        Return True
    End Function
    'SET PRODUCT TO AVAILABLE
    Public Function SetAvailableProduct(productId As String, available As Boolean) As Boolean
        ' Update the user's password in the database
        Dim query As String = "UPDATE products SET available = @available WHERE id = @id"

        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@id", productId)
                cmd.Parameters.AddWithValue("@available", available)
                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using

        Return True
    End Function
    'GET PRODUCTS OLD FUNCTION
    Public Function GetProductss() As DataTable
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM products", connection)
            Dim sqlDa As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dTable As DataTable = New DataTable()

            Try
                sqlDa.Fill(dTable)
                connection.Close()
                Return dTable
            Catch ex As Exception
                connection.Close()
                If dTable IsNot Nothing Then
                    dTable.Dispose()
                End If
                Return Nothing
            Finally
                If sqlDa IsNot Nothing Then
                    sqlDa.Dispose()
                End If
                If cmd IsNot Nothing Then
                    cmd.Dispose()
                End If
            End Try
        End Using
    End Function
    'SEARCH PRODUCT
    Public Function SearchProduct(ByVal name As String) As DataTable
        If name.Length < 3 Then
            Return Nothing
        End If

        Dim cmd As SqlCommand = Nothing
        Dim sqlDa As SqlDataAdapter = Nothing
        Dim dTable As DataTable = Nothing

        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM products WHERE name LIKE @name"
            cmd = New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@name", "%" + name + "%")

            sqlDa = New SqlDataAdapter(cmd)
            dTable = New DataTable()
                sqlDa.Fill(dTable)
                connection.Close()
            End Using
        Catch ex As Exception
            ' Handle the exception here as per your requirement '
        Finally
            If sqlDa IsNot Nothing Then sqlDa.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

        Return dTable
    End Function
    'GET PRODUCTS BY CATEGRY
    Public Function GetProductsByCategory(ByVal categoryId As String) As DataTable

        Dim cmd As SqlCommand = Nothing
        Dim adapter As SqlDataAdapter = Nothing
        Dim sqlDt As DataTable = Nothing

        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM products WHERE category = @category_id"
            cmd = New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@category_id", categoryId)
            adapter = New SqlDataAdapter(cmd)
            sqlDt = New DataTable()
            adapter.Fill(sqlDt)
                Return sqlDt
                connection.Close()
            End Using
        Catch ex As Exception
            Throw
        Finally
            adapter?.Dispose()
            cmd?.Dispose()
        End Try
    End Function
    'UPDATE USER PASSWORD
    Public Function UpdateUserPassword(ByVal userId As String, ByVal newPassword As String) As Boolean
        If UserSession.SignedInUser.Role <> "admin" Then
            MessageBox.Show("You are not allowed to update the password.")
            Return False
        End If

        Dim query As String = "UPDATE users SET password = @newPassword WHERE username = @username"
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", userId)
                cmd.Parameters.AddWithValue("@newPassword", newPassword)
                Try
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    Throw
                End Try

            End Using
            connection.Close()
        End Using
    End Function
    'UPDATE USER
    Public Function UpdateUser(user As User) As Boolean
        ' Update the user's password in the database
        Dim query As String = "UPDATE users SET username = @username, password = @newPassword, role = @newRole WHERE id = @id"

        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@id", user.Id)
                cmd.Parameters.AddWithValue("@username", user.Username)
                cmd.Parameters.AddWithValue("@newPassword", user.Password)
                cmd.Parameters.AddWithValue("@newRole", user.Role.ToLower.Trim)
                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using

        Return True
    End Function

    'GET USERS
    Public Function GetUsers() As List(Of User)
        Dim userList As New List(Of User)()

        Using connection As New SqlConnection(getConnectionString),
            Command As New SqlCommand("SELECT * FROM users", connection)
            connection.Open()
            Using reader As SqlDataReader = Command.ExecuteReader()
                While reader.Read()
                    Dim user As New User() With {
                    .Id = reader.GetInt32(0),
                    .Username = reader.GetString(1),
                    .Password = reader.GetString(2),
                    .Role = reader.GetString(3)
                }
                    userList.Add(user)
                End While
            End Using
            connection.Close()
        End Using

        Return userList
    End Function

    'GET PRDUCTS BY NAME
    Public Function GetProductsByName(ByVal name As String) As DataTable
        Dim query As String = "SELECT * FROM products WHERE name LIKE '%' + @name + '%'"
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Using cmd As SqlCommand = New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@name", name)
                Using adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim table As DataTable = New DataTable()
                    Try
                        adapter.Fill(table)
                        Return table
                    Catch ex As Exception
                        Return Nothing
                    End Try
                End Using
            End Using
            connection.Close()
        End Using
    End Function
    'GET PRODUCTS TABLE
    Public Function GetProductsTable() As DataTable
        Dim dataTable As New DataTable()
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Try
                Dim command As New SqlCommand("SELECT * FROM products", connection)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dataTable)
            Finally
                connection.Close()
            End Try
        End Using
        Return dataTable
    End Function
    'GET IF EMPLOYEE EXISTS
    Public Function EmployeeExists(ByVal username As String) As Boolean
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM users WHERE username = @username"
            Dim cmd As SqlCommand = New SqlCommand(sql, connection)
            cmd.Parameters.AddWithValue("@username", username)
            Dim count As Integer = 0
            Try
                count = Convert.ToInt32(cmd.ExecuteScalar())
            Catch ex As Exception
                Return False
            Finally
                connection.Close()
            End Try
            Return count > 0
        End Using
    End Function
    'GET IF PRODUCT EXISTS
    Public Function ProductExists(ByVal _name As String) As Boolean
        Using connection As New SqlConnection(getConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = New SqlCommand("select * from products where name = @name", connection)
            cmd.Parameters.AddWithValue("@name", _name)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            Try
                sda.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            Finally
                connection.Close()
            End Try
        End Using
    End Function
    'GET IF CATEGORY EXISTS
    Public Function CategoryExist(ByVal _name As String, _class As String, _brand As String) As Boolean

        Dim cmd As SqlCommand = Nothing
        Dim sda As SqlDataAdapter = Nothing
        Dim dt As DataTable = Nothing
        Try
            Using connection As New SqlConnection(getConnectionString)
                connection.Open()
                cmd = New SqlCommand("SELECT * FROM category1 WHERE display_name = @name AND categoryClass = @class AND categoryBrand = @brand", connection)
            cmd.Parameters.AddWithValue("@name", _name.ToLower())
            cmd.Parameters.AddWithValue("@class", _class.ToLower())
            cmd.Parameters.AddWithValue("@brand", _brand.ToLower())
            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()
            sda.Fill(dt)
                Return (dt.Rows.Count > 0)
                connection.Close()
            End Using
        Catch ex As Exception
            Return False
        Finally
            If dt IsNot Nothing Then dt.Dispose()
            If sda IsNot Nothing Then sda.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()

        End Try
    End Function
    'GET IF ADMIN
    Public Function IsAdmin(ByVal _role As String) As Boolean
        If _role.Equals("admin") Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
