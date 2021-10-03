Imports MySql.Data.MySqlClient

Public Class MainForm

#Region "MY METHODS"
    '// RECEIVE THE DATA FROM BARCODE SCANNER//
    Private barcode As String = ""
    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
    ' Try
    'Dim con As New KeysConverter
    'Dim c As Char
    '      c = Char.ConvertFromUtf32(keyData)
    '  If c = ChrW(Keys.OemMinus) Then
    ' c = "-"
    'End If

    '    barcode += c

    'If c = ChrW(Keys.Return) Then
    '         txtStudentID.Text = barcode
    '         GunaLabel5.Text = barcode
    '         recordAttendance(barcode)
    '        recordRecentLog()
    '        showRecentLog()
    '
    'End If

    'Catch ex As Exception

    'End Try
    'Return MyBase.ProcessCmdKey(msg, keyData)
    'End Function

    '//switch panel
    Sub switchPanel(myPanel As Object)
        Me.mainPanel.Controls.Clear()
        Dim mpanel As Form = TryCast(myPanel, Form)
        mpanel.TopLevel = False
        mpanel.Dock = DockStyle.Fill
        Me.mainPanel.Controls.Add(mpanel)
        Me.mainPanel.Tag = mpanel
        mpanel.Show()
    End Sub
    '//showHomePanel
    Sub showHome()
        mainPanel.Controls.Clear()
        mainPanel.Controls.Add(GunaLabel1)
        mainPanel.Controls.Add(GunaLinePanel1)
        mainPanel.Controls.Add(cmbEvent)
        mainPanel.Controls.Add(txtStudentID)
        mainPanel.Controls.Add(btnGo)
        mainPanel.Controls.Add(GunaLabel2)
        mainPanel.Controls.Add(GunaLabel3)
        mainPanel.Controls.Add(amSession)
        mainPanel.Controls.Add(pmSession)
        mainPanel.Controls.Add(grpBox1)
        mainPanel.Controls.Add(grpBox2)
        mainPanel.Controls.Add(GunaLabel4)
        mainPanel.Controls.Add(dateEvent)
    End Sub
    Dim getEventID As String
    Sub getID()
        getEventID = ""
        Dim sql As String = "SELECT event_id FROM event_table WHERE event_name='" & cmbEvent.Text & "' "
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then

            While dr.Read
                getEventID = dr.Item("event_id").ToString()
                ' Label1.Text = getEventID
            End While

        End If

        con.Close()
    End Sub
    Sub getEventList()

        Try
            Dim sql As String = "SELECT event_name FROM event_table "
            Dim da As New MySqlDataAdapter(sql, con)
            con.Open()
            Dim ds As New DataSet
            da.Fill(ds, "event_name")
            con.Close()

            cmbEvent.DataSource = ds.Tables(0)
            cmbEvent.DisplayMember = "event_name"
            cmbEvent.ValueMember = "event_name"
            cmbEvent.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Dim strAm_in As String
    Dim strAm_out As String
    Dim strPm_in As String
    Dim strPm_out As String
    Dim strEvent_date As String
    Dim not_set As String = "NOT SET"
    Sub getEventSessionDetails()
        If cmbEvent.Text = Nothing Then
            amSession.Text = not_set
            pmSession.Text = not_set
        Else
            Dim sql As String = "SELECT am_in,am_out,pm_in,pm_out,event_date FROM event_table WHERE event_name='" & cmbEvent.Text & "' LIMIT 1"
            Dim cmd As New MySqlCommand(sql, con)

            con.Open()
            Dim dr As MySqlDataReader = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    strAm_in = dr.Item("am_in").ToString()
                    strAm_out = dr.Item("am_out").ToString()
                    strPm_in = dr.Item("pm_in").ToString()
                    strPm_out = dr.Item("pm_out").ToString()
                    strEvent_date = dr.Item("event_date").ToString()
                    If strEvent_date <> "EVERYDAY" Then
                        dateEvent.Text = Convert.ToDateTime(strEvent_date).ToString("MMM. dd, yyyy")
                    Else
                        dateEvent.Text = strEvent_date
                    End If


                    If dr.Item("am_in").ToString() = not_set And dr.Item("am_out").ToString() = not_set Then
                        amSession.Text = not_set
                    ElseIf dr.Item("pm_in").ToString() = not_set And dr.Item("pm_out").ToString() = not_set Then
                        pmSession.Text = not_set
                    Else
                        amSession.Text = strAm_in + " TO " + strAm_out
                        pmSession.Text = strPm_in + " TO " + strPm_out
                    End If

                End While
            Else
                amSession.Text = not_set
                pmSession.Text = not_set
            End If

            con.Close()
        End If
    End Sub
    Dim RecordAlreadyExist As Boolean
    Sub checkRecord()
        Dim sql As String = "SELECT * FROM attendance_table WHERE event_id='" & getEventID & "' AND studentID='" & barcode & "' 
                            AND event_date='" & Date.Today.ToString("yyyy/M/dd") & "' LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()
        If count > 0 Then
            RecordAlreadyExist = True

        Else
            RecordAlreadyExist = False

        End If
    End Sub

    Dim studentFound As Boolean
    Sub checkStudent(id As String)
        Dim sql As String = "SELECT * FROM student_table WHERE studentID='" & barcode & "' LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()
        If count > 0 Then
            studentFound = True

        Else
            studentFound = False

        End If
    End Sub


    Dim logDetails As String
    Dim logTime As String
    Dim remarks As String
    Dim on_time As String = "ON TIME"
    Dim late As String = "LATE"
    Dim plusHour As DateTime = "01:00"
    Dim sql As String
    Sub recordAttendance(barcode As String)
        Dim event_date As Date
        sql = ""
        Dim Strdate_today As String = Date.Today
        If strEvent_date <> "EVERYDAY" Then
            event_date = Convert.ToDateTime(strEvent_date)
        Else
            event_date = Date.Today
        End If

        Dim date_today As Date = Convert.ToDateTime(Strdate_today)
        Dim am_in As Date = Convert.ToDateTime(strAm_in).ToString("hh:mm tt")
        Dim am_out As Date = Convert.ToDateTime(strAm_out).ToString("hh:mm tt")
        Dim pm_in As Date = Convert.ToDateTime(strPm_in).ToString("hh:mm tt")
        Dim pm_out As Date = Convert.ToDateTime(strPm_out).ToString("hh:mm tt")

        checkRecord()
        checkStudent(barcode)

        If event_date < date_today Then
            errSound()
            Alert("ERROR", "Event Has Already Ended!", BubbleNotification.alertTypeEnum.Error)

        ElseIf event_date > date_today Then
            errSound()
            Alert("ERROR", "Event Is Not Yet Started!", BubbleNotification.alertTypeEnum.Error)

        ElseIf event_date = date_today Then

            If studentFound = True Then

                If RecordAlreadyExist = False Then

                    If TimeOfDay() < am_out Then

                        'log am in
                        logDetails = "AM LOG IN"
                        logTime = TimeOfDay().ToString("hh:mm tt")

                        If TimeOfDay > am_in.AddHours(1) Then
                            remarks = late

                        Else
                            remarks = on_time

                        End If
                        sql = "INSERT INTO attendance_table(event_id,event_date,studentID,am_in,am_in_remark)VALUES('" & getEventID &
                            "','" & Date.Today.ToString("yyyy/M/dd") & "','" & barcode & "','" & logTime & "','" & remarks & "')"

                        getStudentDetails(barcode)
                        recordRecentLog()

                    ElseIf TimeOfDay() >= am_out And TimeOfDay() < pm_in Then

                        'log am out
                        logDetails = "AM LOG OUT"
                        logTime = TimeOfDay().ToString("hh:mm tt")

                        If TimeOfDay > am_out.AddHours(1) Then
                            remarks = late

                        Else
                            remarks = on_time

                        End If
                        sql = "INSERT INTO attendance_table(event_id,event_date,studentID,am_out,am_out_remark)VALUES('" & getEventID &
                            "','" & Date.Today.ToString("yyyy/M/dd") & "','" & barcode & "','" & logTime & "','" & remarks & "')"

                        getStudentDetails(barcode)
                        recordRecentLog()

                    ElseIf TimeOfDay() >= pm_in And TimeOfDay() < pm_out Then

                        'log pm in
                        logDetails = "PM LOG IN"
                        logTime = TimeOfDay().ToString("hh:mm tt")

                        If TimeOfDay > pm_in.AddHours(1) Then
                            remarks = late

                        Else
                            remarks = on_time

                        End If
                        sql = "INSERT INTO attendance_table(event_id,event_date,studentID,pm_in,pm_in_remark)VALUES('" & getEventID &
                            "','" & Date.Today.ToString("yyyy/M/dd") & "','" & barcode & "','" & logTime & "','" & remarks & "')"

                        getStudentDetails(barcode)
                        recordRecentLog()

                    ElseIf TimeOfDay() >= pm_out Then
                        'log pm out
                        logDetails = "PM LOG OUT"
                        logTime = TimeOfDay().ToString("hh:mm tt")

                        If TimeOfDay > pm_out.AddHours(1) Then
                            remarks = late

                        Else
                            remarks = on_time

                        End If

                        sql = "INSERT INTO attendance_table(event_id,event_date,studentID,pm_out,pm_out_remark)VALUES('" & getEventID &
                            "','" & Date.Today.ToString("yyyy/M/dd") & "','" & barcode & "','" & logTime & "','" & remarks & "')"

                        getStudentDetails(barcode)
                        recordRecentLog()

                    End If

                ElseIf RecordAlreadyExist = True Then

                    If TimeOfDay() < am_out Then

                        'log am in

                        logDetails = "AM LOG IN"
                        logTime = TimeOfDay().ToString("hh:mm tt")

                        If TimeOfDay > am_in.AddHours(1) Then
                            remarks = late

                        Else
                            remarks = on_time

                        End If

                        sql = "UPDATE attendance_table SET am_in='" & logTime &
                            "',am_in_remark='" & remarks & "' WHERE studentId='" & barcode & "' AND event_id='" & getEventID & "'"
                        getStudentDetails(barcode)
                        recordRecentLog()

                    ElseIf TimeOfDay() >= am_out And TimeOfDay() < pm_in Then

                        'log am out
                        logDetails = "AM LOG OUT"
                        logTime = TimeOfDay().ToString("hh:mm tt")

                        If TimeOfDay > am_out.AddHours(1) Then
                            remarks = late

                        Else
                            remarks = on_time

                        End If

                        sql = "UPDATE attendance_table SET am_out='" & logTime &
                            "',am_out_remark='" & remarks & "' WHERE studentId='" & barcode & "' AND event_id='" & getEventID & "'"

                        getStudentDetails(barcode)
                        recordRecentLog()

                    ElseIf TimeOfDay() >= pm_in And TimeOfDay() < pm_out Then

                        'log pm in
                        logDetails = "PM LOG IN"
                        logTime = TimeOfDay().ToString("hh:mm tt")

                        If TimeOfDay > pm_in.AddHours(1) Then
                            remarks = late

                        Else
                            remarks = on_time

                        End If

                        sql = "UPDATE attendance_table SET pm_in='" & logTime &
                            "',pm_in_remark='" & remarks & "' WHERE studentId='" & barcode & "' AND event_id='" & getEventID & "'"

                        getStudentDetails(barcode)
                        recordRecentLog()

                    ElseIf TimeOfDay() >= pm_out Then

                        'log pm out
                        logDetails = "PM LOG OUT"
                        logTime = TimeOfDay().ToString("hh:mm tt")

                        If TimeOfDay > pm_out.AddHours(1) Then
                            remarks = late

                        Else
                            remarks = on_time

                        End If

                        sql = "UPDATE attendance_table SET pm_out='" & logTime &
                            "',pm_out_remark='" & remarks & "' WHERE studentId='" & barcode & "' AND event_id='" & getEventID & "'"
                        getStudentDetails(barcode)
                        recordRecentLog()

                    End If

                End If

                Dim cmd As New MySqlCommand(sql, con)
                con.Open()
                cmd.ExecuteNonQuery()
                Alert("SUCCESS", "LOG SAVED FOR : " + logDetails, BubbleNotification.alertTypeEnum.Success)
                con.Close()

            ElseIf studentFound = False Then
                errSound()
                Alert("ERROR", "Student Not Found!", BubbleNotification.alertTypeEnum.Error)
            End If


        End If


    End Sub
    ''get student details
    Sub getStudentDetails(barcode As String)
        Dim studPic As Byte()
        Dim studBarcode As Byte()
        Dim sql As String = "select fname,lname,course,yearLvl,section,photo,barcode from student_table where studentID='" & barcode & "' limit 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                studPic = dr.Item("photo")
                studBarcode = dr.Item("barcode")
                Dim mstream As New System.IO.MemoryStream(studPic)
                Dim mstream1 As New System.IO.MemoryStream(studBarcode)
                studentPhoto.Image = Image.FromStream(mstream)
                studentBarcode.Image = Image.FromStream(mstream1)
                studName.Text = dr.Item("fname").ToString + " " + dr.Item("lname").ToString()
                studCourse.Text = dr.Item("course").ToString()
                studYr.Text = dr.Item("yearLvl").ToString() + " yr. " + dr.Item("section").ToString()
                studLog.Text = logDetails
                studLogtime.Text = logTime
                studRemark.Text = remarks
            End While
        End If
        con.Close()
    End Sub

    Sub recordRecentLog()
        Dim sql As String
        If RecordAlreadyExist = True Then
            sql = "UPDATE recent_log SET time='" & TimeOfDay.ToString("hh:mm:ss tt") & "' WHERE studentID='" & barcode & "' AND activityLog='" & studLog.Text & "' 
                   AND date='" & Date.Today.ToString("yyyy/M/dd") & "' and event_id='" & getEventID & "'"
            bQuery(sql)

        Else
            sql = "Insert into recent_log(event_id,studentId,activityLog,date,time) VALUES('" & getEventID & "','" & barcode & "','" & studLog.Text & "',
                            '" & Date.Today.ToString("yyyy/M/dd") & "','" & TimeOfDay.ToString("hh:mm:ss tt") & "')"
            bQuery(sql)
        End If
    End Sub

    Sub showRecentLog()
        Dim sql As String = "SELECT student_table.fullName as `STUDENT`,recent_log.activityLog as `ACTIVITY`,time as `LOG TIME` FROM recent_log 
                             INNER JOIN student_table USING(studentID) WHERE recent_log.date='" & Date.Today.ToString("yyyy/M/dd") & "' ORDER BY time DESC LIMIT 15"
        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "recent_log,student_table")

        recentTable.DataSource = ds.Tables(0)

        con.Close()
    End Sub

#End Region

    Public mainIsShown As Boolean = False
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
            txtStudentID.Focus()
            getEventList()
            cmbEvent.SelectedIndex = 0
            showRecentLog()
            mainIsShown = True
            txtStudentID.PlaceholderText = "Student  Barcode ID"
            Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        errSound()
        If MessageBox.Show("Are you sure to Exit The Program?", "CONRIFM", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            '  Alert("Exit", "System Exit...", BubbleNotification.alertTypeEnum.Success)
            End
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub navStudent_Click(sender As Object, e As EventArgs) Handles navStudent.Click
        If LoginForm.sessionLogIn = True Then
            switchPanel(StudentForm)
        Else
            LoginForm.ShowDialog()
            nav_home.Checked = True
        End If

    End Sub

    Private Sub nav_home_Click(sender As Object, e As EventArgs) Handles nav_home.Click

        showHome()
        txtStudentID.Focus()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If btnLogIn.Text = "Log In" Then
            LoginForm.ShowDialog()
        Else
            errSound()
            If MessageBox.Show("Are you sure you want to Log Out?", "CONRIFM", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                '  Alert("Exit", "System Exit...", BubbleNotification.alertTypeEnum.Success)
                LoginForm.Show()
                Me.Close()
                mainIsShown = False
            End If
        End If

    End Sub

    Private Sub navEvent_Click(sender As Object, e As EventArgs) Handles navEvent.Click
        If LoginForm.sessionLogIn = True Then
            switchPanel(EventForm)
        Else
            LoginForm.ShowDialog()
            nav_home.Checked = True
        End If
    End Sub

    Private Sub loadTime_Tick(sender As Object, e As EventArgs) Handles loadTime.Tick
        lblDate.Text = Format(Now, "MMM. d, yyyy")
        lblTime.Text = Format(Now, "hh:mm tt")

    End Sub

    Private Sub cmbEvent_TextChanged(sender As Object, e As EventArgs) Handles cmbEvent.TextChanged, cmbEvent.SelectedValueChanged
        getEventSessionDetails()
        getID()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        txtStudentID.Focus()
        barcode = txtStudentID.Text.Trim
        recordAttendance(barcode)
        showRecentLog()
    End Sub

    Private Sub navSettings_Click(sender As Object, e As EventArgs) Handles navSettings.Click
        If LoginForm.sessionLogIn = True Then
            switchPanel(Settings)
        Else
            LoginForm.ShowDialog()
            nav_home.Checked = True
        End If

    End Sub

    Private Sub navRecord_Click(sender As Object, e As EventArgs) Handles navRecord.Click
        If LoginForm.sessionLogIn = True Then
            switchPanel(LoadRecord)
        Else
            LoginForm.ShowDialog()
            nav_home.Checked = True
        End If

    End Sub

    Private Sub userPhoto_Click(sender As Object, e As EventArgs) Handles userPhoto.Click
        If LoginForm.sessionLogIn = True Then
            userAccountInfo.ShowDialog()
        End If

    End Sub

    Private Sub userPhoto_MouseHover(sender As Object, e As EventArgs) Handles userPhoto.MouseHover
        Guna2HtmlToolTip1.SetToolTip(userPhoto, "Show User Information Only if User has login.")
    End Sub

    Private Sub btnLogIn_MouseHover(sender As Object, e As EventArgs) Handles btnLogIn.MouseHover
        Guna2HtmlToolTip1.SetToolTip(btnLogIn, "Login Now to Access Locked Features.")
    End Sub

    Private Sub MainForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        ' If Me.txtSudentID.Focused = False Then
        'txtSudentID.Focus()
        ' End If


    End Sub

    '   Private Sub txtSudentID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentID.KeyDown
    ' If e.KeyCode = Keys.Enter Then
    'e.SuppressKeyPress = True
    'txtSudentID.SelectAll()

    'barcode = txtSudentID.Text
    'recordAttendance(barcode)
    'showRecentLog()
    'End If
    '   End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        txtStudentID.Focus()

        If e.KeyCode = Keys.Enter Then
            txtStudentID.Focus()
            e.SuppressKeyPress = True
            txtStudentID.SelectAll()

            barcode = txtStudentID.Text.Trim
            recordAttendance(barcode)
            txtStudentID.Text = ""
            showRecentLog()
            txtStudentID.Focus()
        End If
    End Sub

    Private Sub focusClick(sender As Object, e As EventArgs) Handles mainPanel.Click, Guna2Panel3.Click, Guna2Panel1.Click, Guna2Panel1.MouseClick
        txtStudentID.Focus()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint

    End Sub
End Class