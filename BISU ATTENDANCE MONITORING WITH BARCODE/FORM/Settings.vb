Imports MySql.Data.MySqlClient
Public Class Settings

#Region "My Methods"
    Sub clearUSer()
        tUserID.Text = ""
        tFirst.Text = ""
        tLast.Text = ""
        tUsername.Text = ""
        tPass.Text = ""
        tConfirm.Text = ""
        userPhoto.Image = My.Resources.dr_stone_senku_ishigami_uhdpaper_com_4K_9
        btnSaveUser.Text = "Save"
    End Sub
    Sub clearCourse()
        btnSaveCourse.Text = "Save"
        tCourseID.Text = ""
        tCourse.Text = ""
        tCourseAcronym.Text = ""
    End Sub
    Sub clearDept()
        tDeptId.Text = ""
        btnDelDept.Enabled = False
        btnSaveDept.Text = "Save"
        tDept.Text = ""
        tDeptAcronym.Text = ""
    End Sub

    ''ALL CAPS
    Sub capsUser()
        tUserID.Text = StrConv(tUserID.Text, VbStrConv.Uppercase)
        tFirst.Text = StrConv(tFirst.Text, VbStrConv.Uppercase)
        tLast.Text = StrConv(tLast.Text, VbStrConv.Uppercase)
        tUsername.Text = StrConv(tUsername.Text, VbStrConv.Uppercase)
        tPass.Text = StrConv(tPass.Text, VbStrConv.Uppercase)
        tConfirm.Text = StrConv(tPass.Text, VbStrConv.Uppercase)
    End Sub
    Sub capsCourse()
        tCourse.Text = StrConv(tCourse.Text, VbStrConv.Uppercase)
        tCourseAcronym.Text = StrConv(tCourseAcronym.Text, VbStrConv.Uppercase)
    End Sub
    Sub capsDept()
        tDept.Text = StrConv(tDept.Text, VbStrConv.Uppercase)
        tDeptAcronym.Text = StrConv(tDeptAcronym.Text, VbStrConv.Uppercase)
    End Sub

    Sub ExecuteMyQuery(sql As String, message As String)
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("SUCCESS", message, BubbleNotification.alertTypeEnum.Success)
        con.Close()
    End Sub

    Dim sql As String
    Sub saveUserAcct()
        sql = ""
        Dim fileSize As UInt64
        Dim mStream As New System.IO.MemoryStream()
        userPhoto.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim photo() As Byte = mStream.GetBuffer()
        fileSize = mStream.Length
        mStream.Close()

        Dim message = "New User Account Added!"
        ' Dim fullname As String = tFirst.Text + " " + tLast.Text

        sql = "INSERT INTO user_acct(userID,firstname,lastname,username,password,userPhoto)VALUES('" & tUserID.Text & "','" & tFirst.Text &
            "','" & tLast.Text & "','" & tUsername.Text & "','" & tPass.Text & "',@photo)"
        Dim cmd As New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@photo", photo)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("SUCCESS", message, BubbleNotification.alertTypeEnum.Success)
        con.Close()
    End Sub

    Sub saveCourse()
        sql = ""
        Dim message As String = "New Course Added!"

        sql = "INSERT INTO course_table(course,acronym)VALUES('" & tCourse.Text & "','" & tCourseAcronym.Text & "')"
        ExecuteMyQuery(sql, message)
    End Sub
    Sub saveDept()
        sql = ""
        Dim message As String = "New Department Added!"

        sql = "INSERT INTO department_table(department,acronym)VALUES('" & tDept.Text & "','" & tDeptAcronym.Text & "')"
        ExecuteMyQuery(sql, message)
    End Sub
    Dim userID As String
    Sub updateUser(userID As String)
        sql = ""
        Dim fileSize As UInt64
        Dim mStream As New System.IO.MemoryStream()
        userPhoto.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim photo() As Byte = mStream.GetBuffer()
        fileSize = mStream.Length
        mStream.Close()

        Dim message = "New User Account Added!"
        ' Dim fullname As String = tFirst.Text + " " + tLast.Text

        sql = "UPDATE user_acct SET userID='" & tUserID.Text & "',firstname='" & tFirst.Text & "',lastname='" & tLast.Text &
            "',username='" & tUsername.Text & "',password='" & tPass.Text &
            "',userPhoto=@photo WHERE id='" & userID & "'"

        Dim cmd As New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@photo", photo)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("SUCCESS", message, BubbleNotification.alertTypeEnum.Success)
        con.Close()
    End Sub

    Sub updateCourse()
        sql = ""
        Dim message As String = "Edited Successfully!"

        sql = "UPDATE course_table SET course='" & tCourse.Text & "',acronym='" & tCourseAcronym.Text & "' WHERE id='" & tCourseID.Text & "'"
        ExecuteMyQuery(sql, message)
    End Sub
    Sub updateDept()
        sql = ""
        Dim message As String = "Edited Successfully!"

        sql = "UPDATE department_table SET department='" & tDept.Text & "',acronym='" & tDeptAcronym.Text & "' WHERE id='" & tDeptId.Text & "'"
        ExecuteMyQuery(sql, message)
    End Sub
    Sub deleteUSer(id As String)
        sql = "DELETE FROM user_acct WHERE id='" & id & "'"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("SUCCESS", "User Deleted!", BubbleNotification.alertTypeEnum.Error)
        con.Close()
    End Sub
    Sub deleteCourse(id As String)
        sql = "DELETE FROM course_table WHERE id='" & id & "'"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("SUCCESS", "Course Deleted!", BubbleNotification.alertTypeEnum.Error)
        con.Close()
    End Sub
    Sub deleteDept(id As String)
        sql = "DELETE FROM department_table WHERE userId='" & id & "'"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("SUCCESS", "A Department Deleted!", BubbleNotification.alertTypeEnum.Error)
        con.Close()
    End Sub
    Sub countAllUser()
        Dim sql As String = " SELECT COUNT(*) FROM user_acct"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar
        con.Close()
        userCount.Text = count.ToString() + " Total User Account Created"
    End Sub
    Sub countAllCourse()
        Dim sql As String = " SELECT COUNT(*) FROM course_table"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar
        con.Close()
        count_course.Text = count.ToString() + " Total Course Saved"
    End Sub
    Sub countAllDept()
        Dim sql As String = " SELECT COUNT(*) FROM department_table"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar
        con.Close()
        count_dept.Text = count.ToString() + " Total Departments"
    End Sub


    ''search user
    Sub searchUser()
        sql = "SELECT id,userId as `I.D`,firstname as Firstname,lastname as Lastname,username,password FROM user_acct WHERE firstname LIKE '%" & txtSearchUser.Text &
            "%' OR username LIKE'%" & txtSearchUser.Text & "%' OR userID LIKE'%" & txtSearchUser.Text & "%' OR firstname LIKE '%" & txtSearchUser.Text & "&' "
        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "student_table")

        user_dgview.DataSource = ds.Tables(0)

        con.Close()
        If user_dgview.ColumnCount > 0 Then
            user_dgview.Columns(0).Visible = False
            user_dgview.Columns(4).Visible = False
            user_dgview.Columns(5).Visible = False

        End If
        If txtSearchUser.Text = Nothing Then
            countAllUser()
        Else
            userCount.Text = user_dgview.RowCount.ToString + " Student Found"
        End If
    End Sub

    ''searchCourse
    Sub searchCourse()
        sql = "SELECT id,acronym as Acronym, course as Course FROM course_table WHERE acronym LIKE '%" & txtCourse.Text &
            "%' OR course LIKE'%" & txtCourse.Text & "%' "

        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "course_table")

        course_dgview.DataSource = ds.Tables(0)

        con.Close()
        If course_dgview.ColumnCount > 0 Then
            course_dgview.Columns(0).Visible = False
        End If
        If txtCourse.Text = "" Then
            countAllCourse()
        Else
            count_course.Text = course_dgview.RowCount.ToString + " Course Found"
        End If
    End Sub

    ''search Department
    Sub searchDept()
        sql = "SELECT id,acronym as Acronym, department as Department FROM department_table WHERE acronym LIKE '%" & txtDept.Text &
           "%' OR department LIKE'%" & txtDept.Text & "%' "

        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "department_table")

        dept_dgview.DataSource = ds.Tables(0)

        con.Close()
        If dept_dgview.ColumnCount > 0 Then
            dept_dgview.Columns(0).Visible = False
        End If
        If txtCourse.Text = "" Then
            countAllDept()
        Else
            count_dept.Text = course_dgview.RowCount.ToString + " Departments Found"
        End If
    End Sub

    Sub getUserPhoto()
        Dim userPic As Byte()
        Dim sql As String = "select userPhoto from user_acct where userID='" & user_dgview.SelectedCells(1).Value.ToString() & "' limit 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                userPic = dr.Item("userPhoto")
                Dim mstream As New System.IO.MemoryStream(userPic)

                userPhoto.Image = Image.FromStream(mstream)

            End While
        End If
        con.Close()
    End Sub
    Sub getUserDetails()
        Try
            btnSaveUser.Text = "Update"
            userID = user_dgview.SelectedCells(0).Value.ToString()
            tUserID.Text = user_dgview.SelectedCells(1).Value.ToString
            tFirst.Text = user_dgview.SelectedCells(2).Value.ToString
            tLast.Text = user_dgview.SelectedCells(3).Value.ToString
            tUsername.Text = user_dgview.SelectedCells(4).Value.ToString
            tPass.Text = user_dgview.SelectedCells(5).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    ''getCourse

    Sub getCourse()
        Try
            btnDeleteCourse.Enabled = True
            btnSaveCourse.Text = "Update"
            tCourseID.Text = course_dgview.SelectedCells(0).Value.ToString()
            tCourseAcronym.Text = course_dgview.SelectedCells(1).Value.ToString()
            tCourse.Text = course_dgview.SelectedCells(2).Value.ToString()
        Catch ex As Exception

        End Try

    End Sub

    ''getDepartment
    Sub getDepartment()
        Try
            btnDelDept.Enabled = True
            btnSaveDept.Text = "Update"
            tDeptId.Text = dept_dgview.SelectedCells(0).Value.ToString()
            tDeptAcronym.Text = dept_dgview.SelectedCells(1).Value.ToString()
            tDept.Text = dept_dgview.SelectedCells(2).Value.ToString()
        Catch ex As Exception

        End Try

    End Sub
#End Region

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveUser.Click
        If tUserID.Text = "" Then
            tUserID.Focus()
            errSound()
            Alert("WARNING", "User ID is empty!", BubbleNotification.alertTypeEnum.Warning)
        ElseIf tFirst.Text = "" Then
            tFirst.Focus()
            errSound()
            Alert("WARNING", "Firstname is empty!", BubbleNotification.alertTypeEnum.Warning)
        ElseIf tLast.Text = "" Then
            tLast.Focus()
            errSound()
            Alert("WARNING", "Lastname is empty!", BubbleNotification.alertTypeEnum.Warning)
        ElseIf tUsername.Text = "" Then
            tUsername.Focus()
            errSound()
            Alert("WARNING", "Username is empty!", BubbleNotification.alertTypeEnum.Warning)
        ElseIf tPass.Text = "" Then
            tPass.Focus()
            errSound()
            Alert("WARNING", "Password is empty!", BubbleNotification.alertTypeEnum.Warning)
        ElseIf tConfirm.Text = "" Then
            tConfirm.Focus()
            errSound()
            Alert("WARNING", "Confirm your password!", BubbleNotification.alertTypeEnum.Warning)
        ElseIf tPass.Text <> tConfirm.Text Then
            errSound()
            Alert("ERROR", "Password should same as confirm password!", BubbleNotification.alertTypeEnum.Warning)
        Else
            If btnSaveUser.Text = "Save" Then
                saveUserAcct()
                clearUSer()
                searchUser()
            Else
                updateUser(userID)
                clearUSer()
                searchUser()
            End If
        End If
    End Sub

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        Try
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                userPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox("Please Select an Image File!")
            errSound()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        deleteUSer(userID)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearUser.Click
        clearUSer()
    End Sub

    Private Sub txtSearchUser_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUser.TextChanged
        searchUser()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchCourse()
        searchDept()
        searchUser()
    End Sub

    Private Sub strpEdit_Click(sender As Object, e As EventArgs) Handles strpEdit.Click
        getUserDetails()
        getUserPhoto()
    End Sub

    Private Sub stripDelete_Click(sender As Object, e As EventArgs) Handles stripDelete.Click
        userID = user_dgview.SelectedCells(0).Value.ToString()
        deleteUSer(userID)
        searchUser()
    End Sub

    Private Sub tConfirm_TextChanged(sender As Object, e As EventArgs) Handles tConfirm.TextChanged
        If tConfirm.Text = "" Then
            tConfirm.UseSystemPasswordChar = False
        Else
            tConfirm.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub tPass_TextChanged(sender As Object, e As EventArgs) Handles tPass.TextChanged
        If tPass.Text = "" Then
            tPass.UseSystemPasswordChar = False
        Else
            tPass.UseSystemPasswordChar = True
        End If


    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked = True Then
            tPass.UseSystemPasswordChar = False
            tConfirm.UseSystemPasswordChar = False
        Else
            tPass.UseSystemPasswordChar = True
            tConfirm.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnSaveCourse_Click(sender As Object, e As EventArgs) Handles btnSaveCourse.Click
        If tCourse.Text = Nothing Then
            errSound()
            tCourse.Focus()
            Alert("Warning", "Course is empty!", BubbleNotification.alertTypeEnum.Warning)
        ElseIf tCourseAcronym.Text = Nothing Then
            errSound()
            tCourseAcronym.Focus()
            Alert("Warning", "Acronym is empty!", BubbleNotification.alertTypeEnum.Warning)
        Else
            If btnSaveCourse.Text = "Save" Then
                saveCourse()
                clearCourse()
                searchCourse()
            Else
                updateCourse()
                searchCourse()
                clearCourse()
            End If
        End If

    End Sub

    Private Sub btnDeleteCourse_Click(sender As Object, e As EventArgs) Handles btnDeleteCourse.Click
        deleteCourse(tCourseID.Text)
        clearCourse()
        searchCourse()
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        clearCourse()
    End Sub

    Private Sub delCourse_Click(sender As Object, e As EventArgs) Handles delCourse.Click
        Dim getId As String = course_dgview.SelectedCells(0).Value.ToString()
        deleteCourse(getId)
        searchCourse()
    End Sub

    Private Sub editCourse_Click(sender As Object, e As EventArgs) Handles editCourse.Click
        getCourse()
    End Sub

    Private Sub txtCourse_TextChanged(sender As Object, e As EventArgs) Handles txtCourse.TextChanged
        searchCourse()
    End Sub

    Private Sub courseLeave(sender As Object, e As EventArgs) Handles tCourseAcronym.Leave, tCourse.Leave
        capsCourse()
    End Sub

    Private Sub deptLeave(sender As Object, e As EventArgs) Handles tDeptAcronym.Leave, tDept.Leave
        capsDept()
    End Sub

    Private Sub userLeave(sender As Object, e As EventArgs) Handles tUsername.Leave, tUserID.Leave, tPass.Leave, tLast.Leave, tFirst.Leave, tConfirm.Leave
        capsUser()
    End Sub

    Private Sub btnSaveDept_Click(sender As Object, e As EventArgs) Handles btnSaveDept.Click
        If tDept.Text = Nothing Then
            errSound()
            tDept.Focus()
            Alert("Warning ", "Department is empty", BubbleNotification.alertTypeEnum.Warning)
        ElseIf tDeptAcronym.Text = Nothing Then
            errSound()
            tDeptAcronym.Focus()
            Alert("Warning ", "DEpt. Acronym is empty", BubbleNotification.alertTypeEnum.Warning)
        Else
            If btnSaveDept.Text = "Save" Then
                saveDept()
                searchDept()
                clearDept()
            Else
                updateDept()
                searchDept()
                clearDept()
            End If
        End If
    End Sub

    Private Sub btnDelDept_Click(sender As Object, e As EventArgs) Handles btnDelDept.Click
        deleteDept(tDeptId.Text)
        searchDept()
        clearDept()
    End Sub

    Private Sub delDept_Click(sender As Object, e As EventArgs) Handles delDept.Click
        deleteDept(dept_dgview.SelectedCells(0).Value.ToString())
        searchDept()
        clearDept()
    End Sub

    Private Sub editDept_Click(sender As Object, e As EventArgs) Handles editDept.Click
        getDepartment()
    End Sub

    Private Sub txtDept_TextChanged(sender As Object, e As EventArgs) Handles txtDept.TextChanged
        searchDept()
    End Sub

    Private Sub btnClearDept_Click(sender As Object, e As EventArgs) Handles btnClearDept.Click
        clearDept()
    End Sub
End Class