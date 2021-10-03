Public Class BubbleNotification

    Enum alertTypeEnum
        Success
        Warning
        [Error]
        Info
    End Enum

    Dim x, y As Integer
    Public Sub setAlert(header As String, msg1 As String, type As alertTypeEnum)
        Me.Opacity = 0
        Me.StartPosition = FormStartPosition.Manual
        Dim fname As String
        For i As Integer = 1 To 10
            fname = "alert" & i.ToString
            Dim f As BubbleNotification = Application.OpenForms.Item(fname)
            If f Is Nothing Then
                Me.Name = fname
                x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                Me.Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5
        Select Case type
            Case alertTypeEnum.Error
                Me.iconPic.Image = My.Resources._error
                Me.BackColor = Color.FromArgb(255, 121, 70)
            Case alertTypeEnum.Success
                Me.iconPic.Image = My.Resources.success
                Me.BackColor = Color.FromArgb(0, 144, 228)
            Case alertTypeEnum.Warning
                Me.iconPic.Image = My.Resources.warning
                Me.BackColor = Color.FromArgb(255, 179, 2)
        End Select
        Me.txtHeader.Text = header
        Me.msgText.Text = msg1

        '  Me.TopMost = True
        '  Me.ShowIcon = False
        'Me.ShowInTaskbar = False
        Me.Show()
        Me.Timer1.Interval = 1
        Me.Timer1.Start()
    End Sub

    Enum actionEnum
        wait
        start
        close
    End Enum
    Private action As actionEnum = actionEnum.start


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case actionEnum.start
                Me.Timer1.Interval = 1
                Me.Opacity += 0.1
                If x < Me.Location.X Then
                    Me.Left -= 1
                Else
                    If Me.Opacity = 1 Then
                        action = actionEnum.wait
                    End If
                End If
            Case actionEnum.wait
                Timer1.Interval = 800
                action = actionEnum.close
            Case actionEnum.close
                Timer1.Interval = 1
                Me.Opacity -= 0.2
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Close()
                End If
        End Select
    End Sub

    Private Sub BubbleNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Me.Timer1.Interval = 1
        action = actionEnum.close
    End Sub
End Class