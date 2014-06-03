Imports Newtonsoft.Json
Public Class findSingleDevice

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Try
            prgBar.Visible = True

            Dim result As String = apiRequest(My.Settings.baseAPIurl & "/1.0/devices/" & txtDeviceID.Text & "/view", txtApiKey.Text)

            Dim resultProperties As device = JsonConvert.DeserializeObject(Of device)(result)

            txtResult.Clear()
          

            txtResult.AppendText("Device Name: " & resultProperties.deviceName & vbNewLine)
            txtResult.AppendText("Device Host: " & resultProperties.deviceHost & vbNewLine)
            txtResult.AppendText("IP : " & resultProperties.ip & vbNewLine)
            txtResult.AppendText("Manufacturer : " & resultProperties.manufacturer & vbNewLine)
            txtResult.AppendText("Model : " & resultProperties.model & vbNewLine)
            txtResult.AppendText("Firmware : " & resultProperties.firmware & vbNewLine)
            txtResult.AppendText(vbNewLine & "------------------" & vbNewLine & vbNewLine)


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