Public Class userAccountInfo
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        errSound()
        If MessageBox.Show("Are you sure you want to Log Out?", "CONRIFM", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            '  Alert("Exit", "System Exit...", BubbleNotification.alertTypeEnum.Success)
            LoginForm.Show()
            Me.Close()
            MainForm.mainIsShown = False
            MainForm.Close()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub userAccountInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub


End Class