Public Class SelectImgSource
    Private Sub selectImgSource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub rCamera_Click(sender As Object, e As EventArgs) Handles rCamera.Click
        btnContinue.Enabled = True
    End Sub

    Private Sub rFile_Click(sender As Object, e As EventArgs) Handles rFile.Click
        btnContinue.Enabled = True
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If checkDefault.Checked = True And rCamera.Checked = True Then
            StudentForm.cameraOn()
            StudentForm.alwaysCamera = "Open Camera"

        ElseIf checkDefault.Checked = True And rFile.Checked = True Then
            StudentForm.openFolder()
            StudentForm.btnSelectPic.Text = "Open Folder"

        ElseIf rCamera.Checked = True Then
            StudentForm.cameraOn()
            StudentForm.alwaysCamera = "Select Photo"

        ElseIf rFile.Checked = True Then
            StudentForm.openFolder()
            StudentForm.btnSelectPic.Text = "Select Photo"
        End If
        Me.Close()
    End Sub
End Class