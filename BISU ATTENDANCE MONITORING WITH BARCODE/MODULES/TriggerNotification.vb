Module TriggerNotification
    Public Sub Alert(header As String, msg1 As String, type As BubbleNotification.alertTypeEnum)
        Dim f As BubbleNotification = New BubbleNotification
        f.setAlert(header, msg1, type)
    End Sub
End Module
