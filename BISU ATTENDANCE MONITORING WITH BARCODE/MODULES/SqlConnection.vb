Imports MySql.Data.MySqlClient
Module SqlConnection
    '//Establish Mysql Connection
    Public con As New MySqlConnection("Server=localhost;user=root;password=;database=ssg_attendancedb;")

    '//basic query
    Public Sub bQuery(ByVal query As String)
        Dim cmd As New MySqlCommand(query, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
End Module