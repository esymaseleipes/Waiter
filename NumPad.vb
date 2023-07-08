Module NumPad
    Public Function GetPad(sender As Object) As Decimal
        Dim f As New MyNumPad()
        If f.NumPadValue = vbNull Then
            Return vbNull
        Else
            Return f.NumPadValue
        End If
    End Function
End Module
