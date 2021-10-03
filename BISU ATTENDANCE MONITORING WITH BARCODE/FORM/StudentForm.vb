Imports MySql.Data.MySqlClient
Imports AForge.Video.DirectShow
Imports AForge.Video
Imports System.IO

Public Class StudentForm

#Region "My Methods"

    Sub clearFields()
        Dim clr As String = ""
        txtStudID.Text = clr
        tFirst.Text = clr
        tMiddleInitial.Text = clr
        tLast.Text = clr
        cmbDept.SelectedIndex = -1
        cmbCourse.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        cmbSect.SelectedIndex = -1
        studentPhoto.Image = My.Resources.dr_stone_senku_ishigami_uhdpaper_com_4K_9
        studentBarcode.Image = My.Resources.sampleBARCode
        btnAdd.Text = "Add"
        btnDelete.Enabled = False
    End Sub

    'setDepartment
    Sub getDepartmentList()

        Try
            Dim sql As String = "SELECT acronym FROM department_table "
            Dim da As New MySqlDataAdapter(sql, con)
            con.Open()
            Dim ds As New DataSet
            da.Fill(ds, "department_table")
            con.Close()

            cmbDept.DataSource = ds.Tables(0)
            cmbDept.DisplayMember = "acronym"
            cmbDept.ValueMember = "acronym"
            cmbDept.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    ''setCourse
    Sub getCourseList()
        Try
            Dim sql As String = "SELECT acronym FROM course_table "
            Dim da As New MySqlDataAdapter(sql, con)
            con.Open()
            Dim ds As New DataSet
            da.Fill(ds, "course_table")
            con.Close()

            cmbCourse.DataSource = ds.Tables(0)
            cmbCourse.DisplayMember = "acronym"
            cmbCourse.ValueMember = "acronym"
            cmbCourse.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub addStudent()
        Dim fileSize As UInt64
        Dim fileSize1 As UInt64
        Dim mStream As New System.IO.MemoryStream()
        Dim mStream1 As New System.IO.MemoryStream()
        studentPhoto.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        studentBarcode.Image.Save(mStream1, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim photo() As Byte = mStream.GetBuffer()
        Dim barcode() As Byte = mStream1.GetBuffer()
        fileSize1 = mStream1.Length
        fileSize = mStream.Length
        mStream.Close()
        mStream1.Close()
        Dim fullName As String = tLast.Text + ", " + tFirst.Text + " " + tMiddleInitial.Text

        Dim sql As String = "INSERT INTO student_table(studentID,fName,lName,middle,fullName,department,course,yearLvl,section,photo,barcode) 
        VALUES('" & txtStudID.Text & "','" & tFirst.Text & "','" & tLast.Text & "','" & tMiddleInitial.Text & "','" & fullName & "',
        '" & cmbDept.Text & "','" & cmbCourse.Text & "', '" & cmbYear.Text & "','" & cmbSect.Text & "',@photo,@barcode )"
        Dim cmd As New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@photo", photo)
        cmd.Parameters.AddWithValue("@barcode", barcode)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("SUCCESS", "New Student Added!", BubbleNotification.alertTypeEnum.Success)
        con.Close()

    End Sub

    Sub updateStudent(id As String)

        Dim fileSize As UInt64
        Dim fileSize1 As UInt64
        Dim mStream As New System.IO.MemoryStream()
        Dim mStream1 As New System.IO.MemoryStream()
        studentPhoto.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        studentBarcode.Image.Save(mStream1, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim photo() As Byte = mStream.GetBuffer()
        Dim barcode() As Byte = mStream1.GetBuffer()
        fileSize1 = mStream1.Length
        fileSize = mStream.Length
        mStream.Close()
        mStream1.Close()
        Dim fullName As String = tLast.Text + ", " + tFirst.Text + " " + tMiddleInitial.Text

        Dim sql As String = "UPDATE student_table SET studentID='" & txtStudID.Text & "',fName='" & tFirst.Text & "',lName='" & tLast.Text &
            "',middle='" & tMiddleInitial.Text & "',fullName='" & fullName & "',department='" & cmbDept.Text & "',course='" & cmbCourse.Text & "',yearLvl='" & cmbYear.Text & "',section='" & cmbSect.Text &
            "',photo=@photo,barcode=@barcode WHERE id='" & id & "'"

        Dim cmd As New MySqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@photo", photo)
        cmd.Parameters.AddWithValue("@barcode", barcode)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("SUCCESS", "Student Info Updated!", BubbleNotification.alertTypeEnum.Success)
        con.Close()

    End Sub

    Sub deleteStudent()

        Dim sql As String = "DELETE FROM student_table WHERE studentID='" & txtStudID.Text & "'"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        Alert("DELETED", "Account Deleted Permanently", BubbleNotification.alertTypeEnum.Error)
        con.Close()

    End Sub

    Sub searchStudent()

        Dim sql As String = "SELECT id,studentID as `Student ID`,fname as `Firstname`,middle as `M.I`,lName as `Lastname`,course as `Course`,department,yearLvl,section FROM student_table WHERE studentID LIKE '%" & txtSearch.Text &
            "%' OR fname LIKE '%" & txtSearch.Text & "%' OR lName LIKE '%" & txtSearch.Text & "%' "
        Dim da As New MySqlDataAdapter(sql, con)

        con.Open()
        Dim ds As New DataSet
        da.Fill(ds, "student_table")

        dgview.DataSource = ds.Tables(0)

        con.Close()
        If dgview.ColumnCount > 0 Then
            dgview.Columns(0).Visible = False
            dgview.Columns(6).Visible = False
            dgview.Columns(7).Visible = False
            dgview.Columns(8).Visible = False
        End If
        If txtSearch.Text = Nothing Then
            countAllStudents()
        Else
            studentCount.Text = dgview.RowCount.ToString + " Student Found"
        End If
    End Sub

    Sub countAllStudents()
        Dim sql As String = " SELECT COUNT(*) FROM student_table"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar
        con.Close()
        studentCount.Text = count.ToString() + " Total Students Registered"
    End Sub

    Sub selectImageSource()
        SelectImgSource.ShowDialog()
    End Sub
    Public alwaysCamera As String
    Public Sub getImage()
        camera.Stop()
        btnSelectPic.Text = alwaysCamera
    End Sub

    Public camera As VideoCaptureDevice
    Public Sub cameraOn()
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            camera = cameras.VideoDevice
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Me.Captured)
            camera.Start()
            btnSelectPic.Text = "Capture"
        End If
    End Sub

    'method to get Image and show in PictureBox
    Sub Captured(ByVal sender As Object, ByVal eventargs As NewFrameEventArgs)
        Dim bmp As Bitmap
        bmp = DirectCast(eventargs.Frame.Clone(), Bitmap)
        studentPhoto.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub

    'Select Photo Using File Dialog
    Public Sub openFolder()
        Try
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                studentPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox("Please Select an Image File!")
            errSound()
        End Try
    End Sub

    Sub getSelectedPic()
        Dim studPic As Byte()
        Dim studBarcode As Byte()
        Dim sql As String = "select photo,barcode from student_table where studentID='" & dgview.SelectedCells(1).Value.ToString() & "' limit 1"
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

            End While
        End If
        con.Close()
    End Sub
    Dim getID As String
    Sub getTableData()
        getID = dgview.SelectedCells(0).Value.ToString()
        txtStudID.Text = dgview.SelectedCells(1).Value.ToString()
        tFirst.Text = dgview.SelectedCells(2).Value.ToString()
        tMiddleInitial.Text = dgview.SelectedCells(3).Value.ToString()
        tLast.Text = dgview.SelectedCells(4).Value.ToString()
        cmbDept.Text = dgview.SelectedCells(6).Value.ToString()
        cmbCourse.Text = dgview.SelectedCells(5).Value.ToString()
        cmbYear.Text = dgview.SelectedCells(7).Value.ToString()
        cmbSect.Text = dgview.SelectedCells(8).Value.ToString()
        btnAdd.Text = "Update"
        btnDelete.Enabled = True
        getSelectedPic()
    End Sub

    Dim studentIdAlreadyExist As Boolean
    Sub checkStudent()
        Dim sql As String = "SELECT * FROM student_table WHERE studentID='" & txtStudID.Text & "' LIMIT 1"
        Dim cmd As New MySqlCommand(sql, con)
        con.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        con.Close()
        If count > 0 Then
            errSound()
            Alert("WARNING", "Student ID Already Existed!", BubbleNotification.alertTypeEnum.Warning)
            studentIdAlreadyExist = True
        Else
            studentIdAlreadyExist = False
        End If
    End Sub

#End Region

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchStudent()
        getCourseList()
        getDepartmentList()
    End Sub

    Private Sub txtStudID_TextChanged(sender As Object, e As EventArgs) Handles txtStudID.TextChanged
        If txtStudID.Text = "" Then
            studentBarcode.Image = My.Resources.sampleBARCode
            saveBarcode.Enabled = False
        Else
            genBarCode(txtStudID.Text, studentBarcode)
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtStudID.Text = "" Then
            errSound()
            txtStudID.Focus()
            Alert("Warning", "Student ID is Empty!", BubbleNotification.alertTypeEnum.Error)
        ElseIf tFirst.Text = "" Then
            errSound()
            tFirst.Focus()
            Alert("Warning", "Firstname is Empty!", BubbleNotification.alertTypeEnum.Error)
        ElseIf tLast.Text = "" Then
            errSound()
            tLast.Focus()
            Alert("Warning", "Lastname is Empty!", BubbleNotification.alertTypeEnum.Error)
        ElseIf tMiddleInitial.Text = "" Then
            errSound()
            tMiddleInitial.Focus()
            Alert("Warning", "M.I is Empty!", BubbleNotification.alertTypeEnum.Error)
        ElseIf cmbDept.Text = "" Then
            errSound()
            cmbDept.Focus()
            Alert("Warning", "Please select a Department!", BubbleNotification.alertTypeEnum.Error)
        ElseIf cmbCourse.Text = "" Then
            errSound()
            cmbCourse.Focus()
            Alert("Warning", "Please select a Course!", BubbleNotification.alertTypeEnum.Error)
        ElseIf cmbYear.Text = "" Then
            errSound()
            cmbYear.Focus()
            Alert("Warning", "Year Level Cannot be empty!", BubbleNotification.alertTypeEnum.Error)
        ElseIf cmbSect.Text = "" Then
            errSound()
            cmbSect.Focus()
            Alert("Warning", "Please select a Section", BubbleNotification.alertTypeEnum.Error)
        ElseIf btnAdd.Text = "Add" Then
            checkStudent()
            If studentIdAlreadyExist = False Then
                addStudent()
                searchStudent()
                clearFields()
            End If

        ElseIf btnAdd.Text = "Update" Then
            updateStudent(getID)
            searchStudent()
            clearFields()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        deleteStudent()
        searchStudent()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
    End Sub

    Private Sub prntBarcode_Click(sender As Object, e As EventArgs) Handles saveBarcode.Click
        Dim SD As New SaveFileDialog
        SD.FileName = txtStudID.Text + " " + tFirst.Text + "," + tMiddleInitial.Text
        SD.Filter = "PNG File|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            Try
                studentBarcode.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
                Alert("Successful", "Barcode saved successfully!", BubbleNotification.alertTypeEnum.Success)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchStudent()
    End Sub

    Private Sub btnSelectPic_Click(sender As Object, e As EventArgs) Handles btnSelectPic.Click
        If btnSelectPic.Text = "Select Photo" Then
            selectImageSource()

        ElseIf btnSelectPic.Text = "Capture" Then
            getImage()
        ElseIf btnSelectPic.Text = "Open Camera" Then
            cameraOn()
        ElseIf btnSelectPic.Text = "Open Folder" Then
            openFolder()
        End If
    End Sub

    Private Sub strpEdit_Click(sender As Object, e As EventArgs) Handles strpEdit.Click
        Try
            getTableData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub stripDelete_Click(sender As Object, e As EventArgs) Handles stripDelete.Click
        Try
            Dim sql As String = "DELETE FROM student_table WHERE studentID='" & dgview.SelectedCells(1).Value.ToString() & "'"
            Dim cmd As New MySqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            Alert("DELETED", "Student Account Deleted!", BubbleNotification.alertTypeEnum.Error)
            errSound()
            con.Close()
            searchStudent()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dgview_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellContentDoubleClick
        Try
            getTableData()
        Catch ex As Exception

        End Try
    End Sub
End Class