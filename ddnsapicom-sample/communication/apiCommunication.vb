Imports System.Net
Imports System.Text
Imports System.IO
Module apiCommunication
    Public Function apiRequest(url As String, authToken As String) As String
        My.Settings.apiKeyTemp = authToken
        My.Settings.Save()
        Dim request As HttpWebRequest = HttpWebRequest.Create(url)
        request.Method = WebRequestMethods.Http.Get
        Dim authInfo As String = "z:" & authToken
        authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
        request.Headers("Authorization") = "Basic " & authInfo
        Dim oResponse As HttpWebResponse = request.GetResponse()
        Dim reader As New StreamReader(oResponse.GetResponseStream())
        Dim tmp As String = reader.ReadToEnd()
        oResponse.Close()
        Return tmp
    End Function


    Public Function apiPostRequest(ByVal data As String, url As String, authToken As String) As String
        My.Settings.apiKeyTemp = authToken
        My.Settings.Save()
        Dim request As HttpWebRequest = HttpWebRequest.Create(url)
        request.Method = WebRequestMethods.Http.Post
        Dim authInfo As String = "z:" & authToken
        authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
        request.Headers("Authorization") = "Basic " & authInfo


        request.ContentLength = data.Length
        request.ContentType = "application/json"
        Dim writer As New StreamWriter(request.GetRequestStream)
        writer.Write(data)
        writer.Close()
        Try
            Dim oResponse As HttpWebResponse = request.GetResponse()
            Dim reader As New StreamReader(oResponse.GetResponseStream())
            Dim tmp As String = reader.ReadToEnd()
            oResponse.Close()
            If oResponse.StatusCode = "200" Or oResponse.StatusCode = "202" Then
                Return tmp
            Else
                Throw New ApplicationException("Error Occurred, Code: " & oResponse.StatusCode & " : " & tmp)
            End If
        Catch ex As WebException
            If ex.Status = WebExceptionStatus.ProtocolError Then
                Dim read As New StreamReader(ex.Response.GetResponseStream())
                Dim tmp As String = read.ReadToEnd()
                read.Close()
                Throw New ApplicationException(CType(ex.Response, HttpWebResponse).StatusCode & " : " & tmp)
            Else
                Throw New ApplicationException(ex.Message)
            End If
        End Try
    End Function


End Module
