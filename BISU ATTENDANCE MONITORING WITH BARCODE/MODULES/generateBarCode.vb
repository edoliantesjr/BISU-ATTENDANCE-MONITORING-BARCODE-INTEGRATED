Module generateBarCode
    Public Sub genBarCode(id As String, pictBox As PictureBox)
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.IncludeLabel = True
        Generator.CustomLabel = id
        Try
            pictBox.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code39, id))
            StudentForm.saveBarcode.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
End Module
