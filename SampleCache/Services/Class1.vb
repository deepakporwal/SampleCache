Public Class Class1
    Public Shared Function GetValue() As String
        Dim res As String = ""
        Try
            res = IsNothing(HttpRuntime.Cache.Get("JsonObj"))
            Dim ds As New DataSet
            'ds = CType(HttpRuntime.Cache.Get("JsonObj"), DataSet)
            ds = HttpRuntime.Cache.Get("JsonObj")
            If ds.Tables(0).Rows.Count > 0 Then
                res = ds.Tables(0).Rows(0)(0).ToString() & " " & ds.Tables(0).Rows(0)(1).ToString()
            End If
            'res = HttpRuntime.Cache.Get("JsonObj")
        Catch ex As Exception
            res = "object nothing"
        End Try
        Return res.ToString
    End Function

    Public Shared Function GetValuej() As String
        Dim res As String = ""
        Try
            res = IsNothing(HttpRuntime.Cache.Get("Json"))

            res = HttpRuntime.Cache.Get("Json")
        Catch ex As Exception
            res = "object nothing"
        End Try
        Return res.ToString
    End Function

End Class

