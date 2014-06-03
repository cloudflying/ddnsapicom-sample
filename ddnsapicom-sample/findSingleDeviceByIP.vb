Imports Newtonsoft.Json
Public Class findSingleDeviceByIP

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Try
            prgBar.Visible = True

            Dim result As String = apiRequest(My.Settings.baseAPIurl & "/1.0/devices/iplookup/" & txtDeviceIP.Text & "/view", txtApiKey.Text)

            Dim resultProperties As deviceList = JsonConvert.DeserializeObject(Of deviceList)(result)

            txtResult.Clear()
            txtResult.AppendText("Completed: " & resultProperties.completed & vbNewLine)
            txtResult.AppendText("Record Count: " & resultProperties.count & vbNewLine & vbNewLine & "------------------" & vbNewLine & vbNewLine)

            For Each device In resultProperties.devices
                txtResult.AppendText("Device Name: " & device.deviceName & vbNewLine)
                txtResult.AppendText("Device Host: " & device.deviceHost & vbNewLine)
                txtResult.AppendText("IP : " & device.ip & vbNewLine)
                txtResult.AppendText("Manufacturer : " & device.manufacturer & vbNewLine)
                txtResult.AppendText("Model : " & device.model & vbNewLine)
                txtResult.AppendText("Firmware : " & device.firmware & vbNewLine)
                txtResult.AppendText(vbNewLine & "------------------" & vbNewLine & vbNewLine)
            Next

            txtResult.AppendText("RAW JSON RESPONSE: " & vbNewLine & vbNewLine)
            txtResult.AppendText(result)


            prgBar.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class