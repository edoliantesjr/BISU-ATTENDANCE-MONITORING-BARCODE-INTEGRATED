Imports MySql.Data.MySqlClient

Public Class searchEvent
#Region "My Methods"


    ''count all event
    Sub countAllEvents()
        Dim sql As String = " SELECT COUNT(*) FROM event_table"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar
        con.Close()
        eventCount.Text = count.ToString() + " Total Events"
    End Sub

    ''search event
    Sub searchEvent()
        Dim sql As String = "SELECT id,event_id as `EVENT I.D`,event_name as `EVENT NAME` FROM event_table WHERE event_name LIKE '%" & txtEvent.Text & "%'"
        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "event_table")

        event_dgview.DataSource = ds.Tables(0)

        con.Close()
        If event_dgview.ColumnCount > 0 Then
            event_dgview.Columns(0).Visible = False
        End If
        If txtEvent.Text = Nothing Then
            countAllEvents()
        Else
            eventCount.Text = event_dgview.RowCount.ToString + " Events Found"
        End If
    End Sub
    ''getEvent
    Sub getEvent()
        LoadRecord.srchEvent.Text = event_dgview.SelectedCells(1).Value.ToString()
        Me.Close()
    End Sub


#End Region
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub searchEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        txtEvent.PlaceholderForeColor = Color.DimGray
        txtEvent.PlaceholderText = "Search Event.."
        txtEvent.Focus()
        searchEvent()
    End Sub

    Private Sub txtEvent_TextChanged(sender As Object, e As EventArgs) Handles txtEvent.TextChanged
        searchEvent()
    End Sub

    Private Sub SELECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTToolStripMenuItem.Click, event_dgview.DoubleClick
        getEvent()
    End Sub

End Class