Public Class loader

      Dim mseconds As Integer = 0
    Private Sub loadTimer_Tick(sender As Object, e As EventArgs) Handles loadTimer.Tick

        If mseconds >= 7 Then
            loadingCtrl.Visible = False
            Me.Hide()
            MainForm.txtStudentID.Focus()
            loadingCtrl.Stop()
            loadTimer.Stop()
        Else
            mseconds = mseconds + 1

        End If
    End Sub

    Private Sub loadingCtrl_Click(sender As Object, e As EventArgs) Handles loadingCtrl.Click

    End Sub

    Private Sub loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.loadTimer.Start()
        MainForm.Show()
    End Sub
End Class