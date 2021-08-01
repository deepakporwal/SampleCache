Imports System.Web.Http
Imports System.Web
Public Class TestController
    Inherits ApiController

    <HttpGet>
    <ActionName("AddToCache")>
    Public Function AddToCache() As String
        Dim result As String = ""
        Try
            Dim ds As New DataSet
            Dim dt As New DataTable
            dt.Columns.Add("userid")
            dt.Columns.Add("pwd")
            dt.Rows.Add("deepak", "deepak")
            ds.Tables.Add(dt)
            Dim strjson As String = ""
            strjson = Newtonsoft.Json.JsonConvert.SerializeObject(ds)
            HttpRuntime.Cache.Insert("Json", strjson)
            HttpRuntime.Cache.Insert("JsonObj", ds)
            result = "success"
        Catch ex As Exception
            result = "failure :" & ex.Message
        End Try
        Return result
    End Function

    <HttpGet>
    <ActionName("GetFromCache")>
    Public Function GetFromCache() As String
        Dim result As String = ""
        Try
            result = Class1.GetValue
        Catch ex As Exception
            result = "failure :" & ex.Message
        End Try
        Return result
    End Function

    <HttpGet>
    <ActionName("GetFromCachej")>
    Public Function GetFromCachej() As String
        Dim result As String = ""
        Try
            result = Class1.GetValuej
        Catch ex As Exception
            result = "failure :" & ex.Message
        End Try
        Return result
    End Function
End Class
