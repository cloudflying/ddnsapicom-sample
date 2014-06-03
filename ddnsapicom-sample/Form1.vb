Public Class Form1

    Private Sub btnDNSUpdate_Click(sender As Object, e As EventArgs) Handles btnDNSUpdate.Click
        Dim dnsupd As New dnsUpdate
        dnsupd.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnAllDevices_Click(sender As Object, e As EventArgs) Handles btnAllDevices.Click
        Dim listDevice As New listDevicesAll
        listDevice.Show()
    End Sub

    Private Sub btnDeviceLookup_Click(sender As Object, e As EventArgs) Handles btnDeviceLookup.Click
        Dim singleDevice As New findSingleDevice
        singleDevice.Show()
    End Sub

    Private Sub btnIPLookup_Click(sender As Object, e As EventArgs) Handles btnIPLookup.Click
        Dim ipDeviceSearch As New findSingleDeviceByIP
        ipDeviceSearch.Show()
    End Sub

    Private Sub btnNewDevice_Click(sender As Object, e As EventArgs) Handles btnNewDevice.Click
        Dim create As New createDevice
        create.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim upd As New updateDevice
        upd.Show()
    End Sub
End Class
