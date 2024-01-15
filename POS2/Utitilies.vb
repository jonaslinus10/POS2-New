Public Class Utitilies
    Dim shakeCount As Integer = 0

    Public Function Shake(ByVal _textbox As TextBox)
        If (shakeCount >= 500) Then
            shakeCount = 0
        End If

        Do Until shakeCount = 500
            _textbox.Left -= 4
            _textbox.Left += 4
            shakeCount += 1
        Loop
    End Function
End Class
