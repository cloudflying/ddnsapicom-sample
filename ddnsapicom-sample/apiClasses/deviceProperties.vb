Public Class deviceProperties

End Class

Public Class deviceList
    Public Property completed As Boolean
    Public Property count As Integer
    Public Property devices As New List(Of device)
End Class

Public Class device
    Public Property id As String
    Public Property model As String
    Public Property manufacturer As String
    Public Property firmware As String
    Public Property ip As String
    Public Property deviceName As String
    Public Property deviceHost As String
    Public Property deviceUpdateUri As String
    Public Property deviceDeleteUri As String

End Class
Public Class deviceUpdate
    Public Property completed As Boolean
    Public Property device As New device
    Public Property operation As String
End Class
Public Class deviceCreate
    Public Property model As String
    Public Property manufacturer As String
    Public Property firmware As String
    Public Property ip As String
    Public Property deviceName As String
End Class
