Imports System.Net
Imports Newtonsoft.Json
Imports System.Text
Imports System.IO

Public Class dnsUpdate

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdateDNS_Click(sender As Object, e As EventArgs) Handles btnUpdateDNS.Click
        Try
            prgBar.Visible = True

            txtResult.Text = sendDNSReq(txtApiKey.Text, txtHostName.Text, txtMyIp.Text, txtDeviceMan.Text, txtDeviceModel.Text, txtDeviceFirmware.Text)

            prgBar.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            prgBar.Visible = False
        End Try
    End Sub


    ''' <summary>
    ''' Send Request to ddnsapi.com's DNS update Server.
    ''' </summary>
    ''' <param name="apiKey">Your API Key, get this key from ddnsapi.com's management portal.</param>
    ''' <param name="hostname">The hostname assigned to the device, must be formatted: {devicename}.syncroot.ddnsapi.com</param>
    ''' <param name="myip">IP address.</param>
    ''' <param name="deviceman">Device Manufacturer Name</param>
    ''' <param name="devicemodel">Device Model</param>
    ''' <param name="deviceFirmware">Device Firmware</param>
    ''' <returns>String, response is either "nochg" or "good"</returns>
    ''' <remarks>Version 1.0 - 6/3/2014</remarks>
    Function sendDNSReq(apiKey As String, hostname As String, myip As String, deviceman As String, devicemodel As String, deviceFirmware As String) As String

        Dim buildUrl As String = "https://www.textconnects.com/nic/update?"
        buildUrl &= "hostname=" & hostname
        buildUrl &= "&myip=" & myip
        Dim authInfo As String = "updapi:" & apiKey
        authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))

        Dim request As HttpWebRequest = HttpWebRequest.Create(buildUrl)

        request.Method = WebRequestMethods.Http.Get
        request.Headers("Authorization") = "Basic " & authInfo
        request.UserAgent = deviceman & " - " & devicemodel & " - " & deviceFirmware

        Try
            Dim oResponse As HttpWebResponse = request.GetResponse()
            Dim reader As New StreamReader(oResponse.GetResponseStream())
            Dim tmp As String = reader.ReadToEnd()
            oResponse.Close()
            If oResponse.StatusCode = "200" Then
                Return tmp
            Else
                Throw New ApplicationException("Error Occurred, Code: " & oResponse.StatusCode)
            End If
        Catch ex As WebException
            Throw New ApplicationException(ex.Message)
        End Try
    End Function



End Class