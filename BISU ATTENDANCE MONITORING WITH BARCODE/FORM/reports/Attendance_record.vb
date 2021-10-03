Imports MySql.Data.MySqlClient
Public Class Attendance_record
    Dim dataAdapter As New MySqlDataAdapter()
    Dim ds As New DataSet()
    Sub printRecord()

        ds.Clear()
        Try
            With con
                If .State = ConnectionState.Open Then .Close()

                con.Open()
            End With
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
        Try
            Dim qryCompanies As String = "select attendance_table.event_id ,event_table.event_name ,attendance_table.event_date ,student_table.fullname ,
               student_table.course,student_table.yearLvl,student_table.section,attendance_table.am_in,attendance_table.am_out,attendance_table.pm_in,
               attendance_table.pm_out FROM attendance_table INNER JOIN student_table ON attendance_table.studentId=student_table.studentID 
               INNER JOIN event_table ON attendance_table.event_id=event_table.event_id
               WHERE attendance_table.event_id='" & LoadRecord.srchEvent.Text & "' and student_table.course LIKE '%" & LoadRecord.srchCourses.Text & "%' and
               student_table.yearLvl LIKE '%" & LoadRecord.cmbYear.Text & "%' and student_table.section LIKE '%" & LoadRecord.cmbSect.Text & "%' and
               student_table.fullname LIKE '%" & LoadRecord.srchStudent.Text & "%'"

            dataAdapter.SelectCommand = New MySqlCommand(qryCompanies, con)

            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(dataAdapter)

            dataAdapter.Fill(ds, "attendance_table,student_table,event_table")
            dataAdapter.Dispose()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Dim objRpt As New crystalAttendance
        objRpt.SetDataSource(ds.Tables("attendance_table,student_table,event_table"))
        CrystalReportViewer1.ReportSource = objRpt
        CrystalReportViewer1.RefreshReport()

    End Sub
    Private Sub record_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class