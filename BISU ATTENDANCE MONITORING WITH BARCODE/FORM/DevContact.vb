Public Class DevContact
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub DevContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub GunaLabel13_Click(sender As Object, e As EventArgs) Handles GunaLabel13.Click
        Process.Start("https://www.facebook.com/edoliantes.jr")
    End Sub

    Private Sub GunaLabel12_Click(sender As Object, e As EventArgs) Handles GunaLabel12.Click
        Clipboard.Clear()
        Clipboard.SetText(GunaLabel12.Text)
    End Sub

    Private Sub GunaLabel11_Click(sender As Object, e As EventArgs) Handles GunaLabel11.Click
        Clipboard.Clear()
        Clipboard.SetText(GunaLabel11.Text)
    End Sub
End Class