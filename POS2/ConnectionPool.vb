Imports System.Data.SqlClient

Public Class ConnectionPool
    Private ReadOnly _connections As Queue(Of SqlConnection)
    Private ReadOnly _connectionString As String

    Public Sub New(ByVal connectionString As String, ByVal poolSize As Integer)
        _connectionString = connectionString
        _connections = New Queue(Of SqlConnection)()

        For i As Integer = 0 To poolSize - 1
            Dim connection As New SqlConnection(_connectionString)
            connection.Close()
            connection.Open()

            _connections.Enqueue(connection)
        Next
    End Sub

    Public Function GetConnection() As SqlConnection
        If _connections.Count > 0 Then
            Return _connections.Dequeue()
        Else
            Return New SqlConnection(_connectionString)
        End If
    End Function

    Public Sub ReleaseConnection(ByVal connection As SqlConnection)
        _connections.Enqueue(connection)
    End Sub
End Class
