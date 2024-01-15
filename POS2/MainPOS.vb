Public Class MainPOS
    Private Shared databaseHandler As DatabaseHandler
    Public Sub New()
        databaseHandler = New DatabaseHandler
        'Application.EnableVisualStyles()
        'Application.SetCompatibleTextRenderingDefault(False)
        'Application.Run(New FormLogin)
    End Sub

    Public Shared Function GetDatabaseHandler() As DatabaseHandler
        If databaseHandler Is Nothing Then
            databaseHandler = New DatabaseHandler
        End If
        Return databaseHandler
    End Function
End Class
