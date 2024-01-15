Public Class Sale
    Public Property Id() As Integer = 0
    Public Property Invoice_Number() As String = String.Empty
    Public Property Product_Id() As String = String.Empty

    Public Property Product_Name() As String = String.Empty
    Public Property Quantity() As Integer = 0
    Public Property Price() As Integer = 0
    Public Property Total_Price() As Integer = 0
    Public Property Total_Payment() As Integer = 0
    Public Property Customer_Name() As String = String.Empty
    Public Property Customer_Address() As String = String.Empty
    Public Property Customer_Contact() As String = String.Empty
    Public Property Release_Date() As String = String.Empty
    Public Property Release_Time() As String = String.Empty
    Public Property Payment_Method() As String = String.Empty
    Public Property Order_Type() As String = String.Empty
    Public Property Returned() As Integer = 0
    Public Property Remarks() As String = String.Empty
    Public Property Delivered() As Integer = 0
    Public Property Pending() As Boolean = False
    Public Property DeliveryDate() As String = String.Empty
    Public Property Reciept() As String = String.Empty


End Class