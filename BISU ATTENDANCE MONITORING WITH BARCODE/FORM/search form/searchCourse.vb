Imports MySql.Data.MySqlClient

Public Class searchCourse

#Region "My Methods"


    ''count all course
    Sub countAllCourse()
        Dim sql As String = " SELECT COUNT(*) FROM course_table"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar
        con.Close()
        courseCount.Text = count.ToString() + " Total Courses"
    End Sub

    ''search course
    Sub searchCourse()
        Dim Sql As String = "SELECT id,acronym as Acronym, course as Course FROM course_table WHERE acronym LIKE '%" & txtCourse.Text &
            "%' OR course LIKE'%" & txtCourse.Text & "%' "

        Dim da As New MySqlDataAdapter(Sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "course_table")

        course_dgview.DataSource = ds.Tables(0)

        con.Close()
        If course_dgview.ColumnCount > 0 Then
            course_dgview.Columns(0).Visible = False
        End If
        If txtCourse.Text = Nothing Then
            countAllCourse()
        Else
            courseCount.Text = course_dgview.RowCount.ToString + " Courses Found"
        End If
    End Sub
    ''getCourse
    Sub getCourse()
        LoadRecord.srchCourses.Text = course_dgview.SelectedCells(1).Value.ToString()
        Me.Close()
    End Sub


#End Region
    Private Sub searchCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        txtCourse.PlaceholderForeColor = Color.DimGray
        txtCourse.PlaceholderText = "Search Course.."
        txtCourse.Focus()
        searchCourse()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub SELECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTToolStripMenuItem.Click, course_dgview.DoubleClick
        getCourse()
    End Sub

    Private Sub txtCourse_TextChanged(sender As Object, e As EventArgs) Handles txtCourse.TextChanged
        searchCourse()
    End Sub
End Class