Imports MySql.Data.MySqlClient
Public Class LoginForm

#Region "MY METHODS"

    Public sessionLogIn As Boolean = False
    Sub loginNow()
        Try
            Dim sql As String = "SELECT * FROM user_acct WHERE (username='" & txtUser.Text & "'  
                                 OR userID='" & txtUser.Text & "') and password='" & txtPass.Text & "' LIMIT 1"
            Dim cmd As New MySqlCommand(sql, con)
            con.Open()
            Dim count As Integer = cmd.ExecuteScalar()
            con.Close()
            If count > 0 Then
                sessionLogIn = True
                Alert("Success!", "You have Logged In Successfully", BubbleNotification.alertTypeEnum.Success)
                speakNow("You Have Logged In Successfully!")
                MainForm.btnLogIn.Text = "Log Out"
                getUserPhoto()
                txtUser.Text = ""
                txtPass.Text = ""
                If MainForm.mainIsShown = False Then
                    MainForm.Show()
                End If
                Me.Hide()
            Else
                'MessageBox.Show("User Not Found", "Wrong username/password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Alert("Login Failed!", "Wrong username/password!", BubbleNotification.alertTypeEnum.Warning)
                txtPass.Text = ""
                txtPass.Focus()
                errSound()
                sessionLogIn = False
            End If

        Catch ex As Exception
            Alert("ERROR", "SYSTEM ERROR!", BubbleNotification.alertTypeEnum.Error)
            MsgBox(ex.Message)
            errSound()
        End Try
    End Sub

    Public getFullName As String
    Sub getUserPhoto()
        Dim arrImage As Byte()

        Dim sql As String = " SELECT userPhoto,firstname,lastname,username,password FROM user_acct WHERE username='" & txtUser.Text & "' or 
                                userID='" & txtUser.Text & "'LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)

        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                getFullName = dr.Item("firstname").ToString() + " " + dr.Item("lastname").ToString()
                arrImage = dr.Item("userphoto")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                MainForm.userPhoto.Image = Image.FromStream(mstream)
                userAccountInfo.userPhoto1.Image = Image.FromStream(mstream)
                userAccountInfo.fullName1.Text = getFullName
                userAccountInfo.username1.Text = dr.Item("username").ToString()
                userAccountInfo.password1.Text = dr.Item("password").ToString()
            End While
        End If
        con.Close()

    End Sub
#End Region


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        GunaLabel7.BringToFront()
        Guna2PictureBox1.SendToBack()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        If MainForm.mainIsShown = False Then
            End
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub checkPass_CheckedChanged(sender As Object, e As EventArgs) Handles checkPass.CheckedChanged
        If checkPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginNow()
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUser.Text = Nothing Then
            errSound()
            txtUser.Focus()
            Alert("Warning", "Username cannot be empty!", BubbleNotification.alertTypeEnum.Warning)
        ElseIf txtPass.Text = Nothing Then
            errSound()
            txtPass.Focus()
            Alert("Warning", "Password cannot be empty!", BubbleNotification.alertTypeEnum.Warning)
        Else
            loginNow()
        End If
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Process.Start("https://www.facebook.com/bisubilar")
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        Process.Start("https://www.youtube.com/bisubilar")
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Process.Start("https://www.twitter.com/bisubilar")
    End Sub

    Private Sub btnPicInfo_Click(sender As Object, e As EventArgs) Handles btnPicInfo.Click
        DevContact.ShowDialog()
    End Sub


End Class