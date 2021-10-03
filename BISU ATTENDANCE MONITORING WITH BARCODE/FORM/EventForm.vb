Imports MySql.Data.MySqlClient

Public Class EventForm

#Region "MY METHODS"

    Sub clearFields()
        eventID.Text = ""
        eventName.Text = ""
        eventPlace.Text = ""
        chkEveryday.Checked = True
        chkAMEnable.Checked = False
        chkPMenable.Checked = False
        amIN.Value = Convert.ToDateTime(Date.Today + " " + "7:00 AM")
        amOut.Value = Convert.ToDateTime(Date.Today + " " + "12:00 PM")
        pmIn.Value = Convert.ToDateTime(Date.Today + " " + " 1:00 PM")
        pmOut.Value = Convert.ToDateTime(Date.Today + " " + " 5:00 PM")
        btnAdd.Text = "Add"
        btnDelete.Enabled = False
    End Sub
    Dim every_day As String
    Dim sql As String
    Dim not_set As String = "NOT SET"
    Sub addEvent()
        sql = ""
        If chkEveryday.Checked = False Then
            every_day = eventDate.Value.ToString("yyyy/M/dd")
        Else
            every_day = "EVERYDAY"
        End If
        If chkAMEnable.Checked = True And chkPMenable.Checked = False Then
            sql = "INSERT INTO event_table(event_name,event_id,event_held,event_date,am_in,am_out,pm_in,pm_out)VALUES('" & eventName.Text & _
               "','" & eventID.Text & "','" & eventPlace.Text & "','" & every_day & "','" & amIN.Value.ToString("hh:mm tt") & "','" & amOut.Value.ToString("hh:mm tt") & _
               "','" & not_set & "','" & not_set & "')"
        ElseIf chkAMEnable.Checked = False And chkPMenable.Checked = True Then
            sql = "INSERT INTO event_table(event_name,event_id,event_held,event_date,pm_in,pm_out,am_in,am_out)VALUES('" & eventName.Text & _
              "','" & eventID.Text & "','" & eventPlace.Text & "','" & every_day & "','" & pmIn.Value.ToString("hh:mm tt") & "','" & pmOut.Value.ToString("hh:mm tt") & _
              "','" & not_set & "','" & not_set & "')"
        ElseIf chkAMEnable.Checked = True And chkPMenable.Checked = True Then
            sql = "INSERT INTO event_table(event_name,event_id,event_held,event_date,am_in,am_out,pm_in,pm_out)VALUES('" & eventName.Text & "','" & eventID.Text & _
                "','" & eventPlace.Text & "','" & every_day & "','" & amIN.Value.ToString("hh:mm tt") & "','" & amOut.Value.ToString("hh:mm tt") & _
                "','" & pmIn.Value.ToString("hh:mm tt") & "','" & pmOut.Value.ToString("hh:mm tt") & "')"
        End If
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("SUCCESS", "New Event Added!", BubbleNotification.alertTypeEnum.Success)
        con.Close()
    End Sub

    Sub updateEvent()
        sql = ""
        If chkEveryday.Checked = False Then
            every_day = eventDate.Value.ToString("yyyy/M/dd")
        Else
            every_day = "EVERYDAY"
        End If
        If chkAMEnable.Checked = True And chkPMenable.Checked = False Then
            sql = "UPDATE event_table SET event_id='" & eventID.Text & "',event_name='" & eventName.Text & "',event_held='" & eventPlace.Text & "',event_date='" & every_day & _
                "',am_in='" & amIN.Value.ToString("hh:mm tt") & "',am_out='" & amOut.Value.ToString("hh:mm tt") & _
                "',pm_in='" & not_set & "',pm_out='" & not_set & "' WHERE id='" & getID & "'"

        ElseIf chkAMEnable.Checked = False And chkPMenable.Checked = True Then
            sql = "UPDATE event_table SET event_id='" & eventID.Text & "',event_name='" & eventName.Text & "',event_held='" & eventPlace.Text & "',event_date='" & every_day & _
                "',pm_in='" & pmIn.Value.ToString("hh:mm tt") & "',pm_out='" & pmOut.Value.ToString("hh:mm tt") & _
                "',am_in='" & not_set & "',am_out='" & not_set & "' WHERE id='" & getID & "'"

        ElseIf chkAMEnable.Checked = True And chkPMenable.Checked = True Then
            sql = "UPDATE event_table SET event_id='" & eventID.Text & "',event_name='" & eventName.Text & "',event_held='" & eventPlace.Text & "',event_date='" & every_day & _
                "',am_in='" & amIN.Value.ToString("hh:mm tt") & "',am_out='" & amOut.Value.ToString("hh:mm tt") & "',pm_in='" & pmIn.Value.ToString("hh:mm tt") & _
                "',pm_out='" & pmOut.Value.ToString("hh:mm tt") & "' WHERE id ='" & getID & "'"

        End If

        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("SUCCESS", "Event's Details was modified!", BubbleNotification.alertTypeEnum.Success)
        con.Close()

    End Sub

    Sub deleteEvent(id As String)
        Dim sql As String = "DELETE FROM event_table WHERE ID='" & id & "'"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("DELETED", "Event deleted permanently!", BubbleNotification.alertTypeEnum.Error)
        con.Close()
    End Sub
    Sub countAllEvents()
        Dim sql As String = " SELECT COUNT(*) FROM event_table"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar
        con.Close()
        eventCount.Text = count.ToString() + " Total Saved Events"
    End Sub
    Sub searchEvent()

        Dim sql As String = "SELECT id,event_id as `I.D`,event_name as `Event`,event_held,event_date as Date,am_in as `AM IN`,am_out as `AM OUT`,pm_in as `PM IN`,pm_out AS `PM OUT` FROM event_table WHERE event_name LIKE '%" & txtSearch.Text & "%'"
        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "event_table")

        dgview.DataSource = ds.Tables(0)

        con.Close()
        If dgview.ColumnCount > 0 Then
            dgview.Columns(0).Visible = False
            dgview.Columns(3).Visible = False
        End If
        If txtSearch.Text = Nothing Then
            countAllEvents()
        Else
            eventCount.Text = dgview.RowCount.ToString + " Events Found"
        End If
    End Sub
    Dim getID As String
    Sub getTableData()
        getID = ""
        every_day = ""
        getID = dgview.SelectedCells(0).Value.ToString()
        eventID.Text = dgview.SelectedCells(1).Value.ToString()
        eventName.Text = dgview.SelectedCells(2).Value.ToString()
        eventPlace.Text = dgview.SelectedCells(3).Value.ToString()
        Dim date_event As String = dgview.SelectedCells(4).Value.ToString()
        Dim am_in As String = dgview.SelectedCells(5).Value.ToString()
        Dim am_out As String = dgview.SelectedCells(6).Value.ToString()
        Dim pm_in As String = dgview.SelectedCells(7).Value.ToString()
        Dim pm_out As String = dgview.SelectedCells(8).Value.ToString()

        If date_event = "EVERYDAY" Then
            chkEveryday.Checked = True
        Else
            chckSelectDate.Checked = True
            eventDate.Value = Convert.ToDateTime(dgview.SelectedCells(4).Value.ToString())
        End If

        If am_in = not_set And am_out = not_set Then
            chkAMEnable.Checked = False
        Else
            chkAMEnable.Checked = True
            amIN.Value = Convert.ToDateTime(dgview.SelectedCells(5).Value.ToString())
            amOut.Value = Convert.ToDateTime(dgview.SelectedCells(6).Value.ToString())
        End If

        If pm_in = not_set And pm_out = not_set Then
            chkPMenable.Checked = False
        Else
            chkPMenable.Checked = True
            pmIn.Value = Convert.ToDateTime(dgview.SelectedCells(7).Value.ToString())
            pmOut.Value = Convert.ToDateTime(dgview.SelectedCells(8).Value.ToString())
        End If
        btnAdd.Text = "Update"
        btnDelete.Enabled = True
    End Sub

    Dim eventIdAlreadyExist As Boolean
    Dim eventNameAlreadyExist As Boolean
    Sub checkID()
        Dim sql As String = "SELECT * FROM event_table WHERE event_id='" & eventID.Text & "' OR event_name='" & eventName.Text & "' LIMIT 2"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()
        If count > 0 Then
            errSound()
            Alert("WARNING", "Event ID or Event Name Already Existed!", BubbleNotification.alertTypeEnum.Warning)
            eventIdAlreadyExist = True
            eventNameAlreadyExist = True
        Else
            eventIdAlreadyExist = False
            eventNameAlreadyExist = False
        End If
    End Sub
#End Region

    Private Sub chkEveryday_CheckedChanged(sender As Object, e As EventArgs) Handles chkEveryday.CheckedChanged
        If chkEveryday.Checked = True Then
            eventDate.Enabled = False
            chckSelectDate.Checked = False
        End If
    End Sub

    Private Sub chckSelectDate_CheckedChanged(sender As Object, e As EventArgs) Handles chckSelectDate.CheckedChanged
        If chckSelectDate.Checked = True Then
            chkEveryday.Checked = False
            eventDate.Enabled = True
        End If
    End Sub

    Private Sub chkAMEnable_CheckedChanged(sender As Object, e As EventArgs) Handles chkAMEnable.CheckedChanged
        If chkAMEnable.Checked = True Then
            amIN.Enabled = True
            amOut.Enabled = True

        Else
            amIN.Enabled = False
            amOut.Enabled = False
        End If
    End Sub

    Private Sub chkPMenable_CheckedChanged(sender As Object, e As EventArgs) Handles chkPMenable.CheckedChanged
        If chkPMenable.Checked = True Then
            pmIn.Enabled = True
            pmOut.Enabled = True
        Else
            pmIn.Enabled = False
            pmOut.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If eventName.Text = "" Then
            errSound()
            eventName.Focus()
            Alert("ERROR", "Event Name is Empty!", BubbleNotification.alertTypeEnum.Error)
        ElseIf eventPlace.Text = "" Then
            errSound()
            eventPlace.Focus()
            Alert("ERROR", "Event's Place is Empty!", BubbleNotification.alertTypeEnum.Error)
        ElseIf chkEveryday.Checked = False And chckSelectDate.Checked = False Then
            errSound()
            Alert("ERROR", "Event Date is Required!", BubbleNotification.alertTypeEnum.Error)
        ElseIf amIN.Value >= amOut.Value Then
            errSound()
            Alert("ERROR", "AM Time In is >= Am Time Out", BubbleNotification.alertTypeEnum.Error)
        ElseIf pmIn.Value >= pmOut.Value Then
            errSound()
            Alert("ERROR", "PM Time In is >= PM Time Out", BubbleNotification.alertTypeEnum.Error)
        ElseIf chkAMEnable.Checked = False And chkPMenable.Checked = False Then
            errSound()
            Alert("ERROR", "Log Session is Required!", BubbleNotification.alertTypeEnum.Error)
        ElseIf btnAdd.Text = "Add" Then
            checkID()
            If eventIdAlreadyExist = False And eventNameAlreadyExist = False Then
                addEvent()
                clearFields()
                searchEvent()
                MainForm.getEventSessionDetails()
                MainForm.getEventList()
            End If

        ElseIf btnAdd.Text = "Update" Then
            updateEvent()
            clearFields()
            searchEvent()
            MainForm.getEventSessionDetails()
            MainForm.getEventList()
        End If
    End Sub

    Private Sub EDITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click
        clearFields()
        getTableData()
    End Sub

    Private Sub REMOVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMOVEToolStripMenuItem.Click
        deleteEvent(dgview.SelectedCells(0).Value.ToString())
        searchEvent()
    End Sub

    Private Sub eventPlace_Leave(sender As Object, e As EventArgs) Handles eventPlace.Leave, eventName.Leave, eventID.Leave
        eventName.Text = StrConv(eventName.Text, VbStrConv.Uppercase)
        eventPlace.Text = StrConv(eventPlace.Text, VbStrConv.Uppercase)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
    End Sub

    Private Sub amIN_ValueChanged(sender As Object, e As EventArgs) Handles amIN.ValueChanged, amOut.ValueChanged, pmIn.ValueChanged, pmOut.ValueChanged
        If amIN.Value >= Convert.ToDateTime(Date.Today + " " + "1:00 PM") Then

            'Alert("ERROR", "Time exceeds Morning TimeFrame", BubbleNotification.alertTypeEnum.Error)
            amIN.Value = Convert.ToDateTime(Date.Today + " " + "1:00 AM")
            '  Alert("Warning", "Value Resets", BubbleNotification.alertTypeEnum.Warning)

        ElseIf amOut.Value >= Convert.ToDateTime(Date.Today + " " + "2:00 PM") Then

            'Alert("ERROR", "Time exceeds Morning TimeFrame", BubbleNotification.alertTypeEnum.Error)
            amOut.Value = Convert.ToDateTime(Date.Today + " " + "12:00 PM")
            '   Alert("Warning", "Value Resets", BubbleNotification.alertTypeEnum.Warning)
        ElseIf pmIn.Value <= Convert.ToDateTime(Date.Today + " " + "11:00 AM") Then

            pmIn.Value = Convert.ToDateTime(Date.Today + " " + "1:00 PM")

        ElseIf pmOut.Value <= Convert.ToDateTime(Date.Today + " " + "1:00 AM") Then

            pmOut.Value = Convert.ToDateTime(Date.Today + " " + "5:00 PM")

        End If

    End Sub

    Private Sub EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        amIN.Value = Convert.ToDateTime(Date.Today + " " + "7:00 AM")
        amOut.Value = Convert.ToDateTime(Date.Today + " " + "12:00 PM")
        pmIn.Value = Convert.ToDateTime(Date.Today + " " + " 1:00 PM")
        pmOut.Value = Convert.ToDateTime(Date.Today + " " + " 5:00 PM")
        eventDate.Value = Date.Today
        searchEvent()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchEvent()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        deleteEvent(eventID.Text)
        clearFields()
        searchEvent()

    End Sub

    Private Sub dgview_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        clearFields()
        getTableData()
    End Sub
End Class