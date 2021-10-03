Imports MySql.Data.MySqlClient

Public Class LoadRecord

#Region "MY METHODS"
    ''set query report
    Dim sql As String

    ''search
    Sub setQuerySearch()

        ''show by event id,event name,event date,full name,course,year,section,amin,amout,pmin,pmout
        sql = "select attendance_table.event_id as `EVENT ID`,attendance_table.studentID,event_table.event_name as `EVENT NAME`,attendance_table.event_date as `EVENT DATE`,
               student_table.fullname as `STUDENT`,student_table.course as `COURSE`,student_table.yearLvl as `YEAR`,student_table.section as `SECTION`,
               attendance_table.am_in as `AM IN`, attendance_table.am_out AS `AM OUT`,attendance_table.pm_in AS `PM IN`,attendance_table.pm_out AS `PM OUT`
               FROM attendance_table INNER JOIN student_table USING(studentID) INNER JOIN event_table USING(event_id) 
               WHERE attendance_table.event_id='" & srchEvent.Text & "' and student_table.course LIKE '%" & srchCourses.Text & "%' and
               student_table.yearLvl LIKE '%" & cmbYear.Text & "%' and student_table.section LIKE '%" & cmbSect.Text & "%' and
               student_table.fullname LIKE '%" & srchStudent.Text & "%'"

        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "attendance_table,student_table,event_table")

        record_dgview.DataSource = ds.Tables(0)
        If record_dgview.ColumnCount > 0 Then
            record_dgview.Columns(1).Visible = False
        End If

        con.Close()

    End Sub

    ''print record



#End Region
    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles srchEvent.MouseClick
        searchEvent.ShowDialog()
    End Sub

    Private Sub srchCourse(sender As Object, e As EventArgs) Handles srchCourses.MouseClick
        searchCourse.ShowDialog()
    End Sub

    Private Sub LoadRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLoadRecord_Click(sender As Object, e As EventArgs) Handles btnLoadRecord.Click
        setQuerySearch()
    End Sub

    Private Sub srchStudent_TextChanged(sender As Object, e As EventArgs) Handles srchStudent.TextChanged, srchCourses.TextChanged,
        srchEvent.TextChanged, cmbSect.SelectedIndexChanged, cmbYear.SelectedIndexChanged

        setQuerySearch()
        If srchEvent.Text <> Nothing Then
            btnPrintRecord.Enabled = True
        Else
            btnPrintRecord.Enabled = False
        End If

    End Sub

    Private Sub btnPrintRecord_Click(sender As Object, e As EventArgs) Handles btnPrintRecord.Click
        Attendance_record.printRecord()
        Attendance_record.Show()
        Attendance_record.CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Dim date1 As Date = Convert.ToDateTime(record_dgview.SelectedCells(3).Value.ToString)

        Dim sql As String = "DELETE FROM attendance_table WHERE event_ID='" & record_dgview.SelectedCells(0).Value.ToString() & "' 
                                and studentID='" & record_dgview.SelectedCells(1).Value.ToString() & "' 
                                and event_date='" & date1.ToString("yyyy/M/dd") & "'"

        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("DELETED", "A Record Deleted!", BubbleNotification.alertTypeEnum.Error)
        errSound()
        con.Close()
        setQuerySearch()


    End Sub
End Class