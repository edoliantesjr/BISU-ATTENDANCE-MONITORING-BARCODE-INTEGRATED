<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSect = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbDept = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.studentBarcode = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.tLast = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tMiddleInitial = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tFirst = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.saveBarcode = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnSelectPic = New Guna.UI2.WinForms.Guna2Button()
        Me.studentPhoto = New Guna.UI.WinForms.GunaPictureBox()
        Me.studentCount = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.dgview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.rightClickMenu = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.strpEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.studentBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.studentPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rightClickMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 18)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(294, 25)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "ADD / EDIT / SEARCH STUDENT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.cmbSect)
        Me.GroupBox1.Controls.Add(Me.cmbYear)
        Me.GroupBox1.Controls.Add(Me.cmbCourse)
        Me.GroupBox1.Controls.Add(Me.cmbDept)
        Me.GroupBox1.Controls.Add(Me.studentBarcode)
        Me.GroupBox1.Controls.Add(Me.tLast)
        Me.GroupBox1.Controls.Add(Me.tMiddleInitial)
        Me.GroupBox1.Controls.Add(Me.tFirst)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtStudID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.saveBarcode)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.GunaElipsePanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 502)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'cmbSect
        '
        Me.cmbSect.BackColor = System.Drawing.Color.Transparent
        Me.cmbSect.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbSect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbSect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSect.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbSect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbSect.FocusedState.Parent = Me.cmbSect
        Me.cmbSect.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cmbSect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSect.FormattingEnabled = True
        Me.cmbSect.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbSect.HoverState.Parent = Me.cmbSect
        Me.cmbSect.ItemHeight = 30
        Me.cmbSect.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R"})
        Me.cmbSect.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbSect.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cmbSect.ItemsAppearance.Parent = Me.cmbSect
        Me.cmbSect.ItemsAppearance.SelectedBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbSect.Location = New System.Drawing.Point(187, 384)
        Me.cmbSect.Name = "cmbSect"
        Me.cmbSect.ShadowDecoration.Parent = Me.cmbSect
        Me.cmbSect.Size = New System.Drawing.Size(150, 36)
        Me.cmbSect.TabIndex = 7
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.Color.Transparent
        Me.cmbYear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbYear.FocusedState.Parent = Me.cmbYear
        Me.cmbYear.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cmbYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbYear.HoverState.Parent = Me.cmbYear
        Me.cmbYear.ItemHeight = 30
        Me.cmbYear.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbYear.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbYear.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cmbYear.ItemsAppearance.Parent = Me.cmbYear
        Me.cmbYear.ItemsAppearance.SelectedBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbYear.Location = New System.Drawing.Point(22, 384)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.ShadowDecoration.Parent = Me.cmbYear
        Me.cmbYear.Size = New System.Drawing.Size(159, 36)
        Me.cmbYear.TabIndex = 6
        '
        'cmbCourse
        '
        Me.cmbCourse.BackColor = System.Drawing.Color.Transparent
        Me.cmbCourse.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbCourse.FocusedState.Parent = Me.cmbCourse
        Me.cmbCourse.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cmbCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbCourse.HoverState.Parent = Me.cmbCourse
        Me.cmbCourse.ItemHeight = 30
        Me.cmbCourse.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbCourse.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cmbCourse.ItemsAppearance.Parent = Me.cmbCourse
        Me.cmbCourse.ItemsAppearance.SelectedBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbCourse.Location = New System.Drawing.Point(22, 319)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.ShadowDecoration.Parent = Me.cmbCourse
        Me.cmbCourse.Size = New System.Drawing.Size(315, 36)
        Me.cmbCourse.TabIndex = 5
        '
        'cmbDept
        '
        Me.cmbDept.BackColor = System.Drawing.Color.Transparent
        Me.cmbDept.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDept.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbDept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbDept.FocusedState.Parent = Me.cmbDept
        Me.cmbDept.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cmbDept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbDept.HoverState.Parent = Me.cmbDept
        Me.cmbDept.ItemHeight = 30
        Me.cmbDept.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cmbDept.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cmbDept.ItemsAppearance.Parent = Me.cmbDept
        Me.cmbDept.ItemsAppearance.SelectedBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbDept.Location = New System.Drawing.Point(22, 246)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.ShadowDecoration.Parent = Me.cmbDept
        Me.cmbDept.Size = New System.Drawing.Size(315, 36)
        Me.cmbDept.TabIndex = 4
        '
        'studentBarcode
        '
        Me.studentBarcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.studentBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentBarcode.Image = Global.BISU_BILAR_SSG_ATTENDANCE_MONITORING.My.Resources.Resources.sampleBARCode
        Me.studentBarcode.Location = New System.Drawing.Point(383, 285)
        Me.studentBarcode.Name = "studentBarcode"
        Me.studentBarcode.ShadowDecoration.Parent = Me.studentBarcode
        Me.studentBarcode.Size = New System.Drawing.Size(245, 99)
        Me.studentBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentBarcode.TabIndex = 23
        Me.studentBarcode.TabStop = False
        '
        'tLast
        '
        Me.tLast.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tLast.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tLast.DefaultText = ""
        Me.tLast.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tLast.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tLast.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tLast.DisabledState.Parent = Me.tLast
        Me.tLast.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tLast.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tLast.FocusedState.Parent = Me.tLast
        Me.tLast.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLast.ForeColor = System.Drawing.Color.Black
        Me.tLast.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tLast.HoverState.Parent = Me.tLast
        Me.tLast.Location = New System.Drawing.Point(24, 182)
        Me.tLast.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.tLast.Name = "tLast"
        Me.tLast.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tLast.PlaceholderText = "Lastname"
        Me.tLast.SelectedText = ""
        Me.tLast.ShadowDecoration.Parent = Me.tLast
        Me.tLast.Size = New System.Drawing.Size(313, 37)
        Me.tLast.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.tLast.TabIndex = 3
        '
        'tMiddleInitial
        '
        Me.tMiddleInitial.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tMiddleInitial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tMiddleInitial.DefaultText = ""
        Me.tMiddleInitial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tMiddleInitial.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tMiddleInitial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tMiddleInitial.DisabledState.Parent = Me.tMiddleInitial
        Me.tMiddleInitial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tMiddleInitial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tMiddleInitial.FocusedState.Parent = Me.tMiddleInitial
        Me.tMiddleInitial.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMiddleInitial.ForeColor = System.Drawing.Color.Black
        Me.tMiddleInitial.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tMiddleInitial.HoverState.Parent = Me.tMiddleInitial
        Me.tMiddleInitial.Location = New System.Drawing.Point(246, 139)
        Me.tMiddleInitial.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.tMiddleInitial.Name = "tMiddleInitial"
        Me.tMiddleInitial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tMiddleInitial.PlaceholderText = "M.I"
        Me.tMiddleInitial.SelectedText = ""
        Me.tMiddleInitial.ShadowDecoration.Parent = Me.tMiddleInitial
        Me.tMiddleInitial.Size = New System.Drawing.Size(93, 37)
        Me.tMiddleInitial.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.tMiddleInitial.TabIndex = 2
        '
        'tFirst
        '
        Me.tFirst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tFirst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tFirst.DefaultText = ""
        Me.tFirst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tFirst.DisabledState.Parent = Me.tFirst
        Me.tFirst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tFirst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tFirst.FocusedState.Parent = Me.tFirst
        Me.tFirst.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFirst.ForeColor = System.Drawing.Color.Black
        Me.tFirst.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tFirst.HoverState.Parent = Me.tFirst
        Me.tFirst.Location = New System.Drawing.Point(24, 139)
        Me.tFirst.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.tFirst.Name = "tFirst"
        Me.tFirst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tFirst.PlaceholderText = "Firstname"
        Me.tFirst.SelectedText = ""
        Me.tFirst.ShadowDecoration.Parent = Me.tFirst
        Me.tFirst.Size = New System.Drawing.Size(206, 37)
        Me.tFirst.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.tFirst.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(185, 363)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Section :"
        '
        'txtStudID
        '
        Me.txtStudID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txtStudID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudID.DefaultText = ""
        Me.txtStudID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudID.DisabledState.Parent = Me.txtStudID
        Me.txtStudID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txtStudID.FocusedState.Parent = Me.txtStudID
        Me.txtStudID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.ForeColor = System.Drawing.Color.Black
        Me.txtStudID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.txtStudID.HoverState.Parent = Me.txtStudID
        Me.txtStudID.Location = New System.Drawing.Point(24, 74)
        Me.txtStudID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudID.PlaceholderText = ""
        Me.txtStudID.SelectedText = ""
        Me.txtStudID.ShadowDecoration.Parent = Me.txtStudID
        Me.txtStudID.Size = New System.Drawing.Size(315, 37)
        Me.txtStudID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtStudID.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(19, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Department :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(19, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Year :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(19, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Course :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(21, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Student Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(21, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Student ID :"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Animated = True
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BorderRadius = 6
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.FillColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(348, 437)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Enabled = True
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnClear.Size = New System.Drawing.Size(147, 49)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        '
        'saveBarcode
        '
        Me.saveBarcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.saveBarcode.Animated = True
        Me.saveBarcode.BackColor = System.Drawing.Color.Transparent
        Me.saveBarcode.BorderRadius = 6
        Me.saveBarcode.CheckedState.Parent = Me.saveBarcode
        Me.saveBarcode.CustomImages.Parent = Me.saveBarcode
        Me.saveBarcode.Enabled = False
        Me.saveBarcode.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.saveBarcode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBarcode.ForeColor = System.Drawing.Color.White
        Me.saveBarcode.HoverState.Parent = Me.saveBarcode
        Me.saveBarcode.Location = New System.Drawing.Point(512, 390)
        Me.saveBarcode.Name = "saveBarcode"
        Me.saveBarcode.ShadowDecoration.Enabled = True
        Me.saveBarcode.ShadowDecoration.Parent = Me.saveBarcode
        Me.saveBarcode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.saveBarcode.Size = New System.Drawing.Size(116, 30)
        Me.saveBarcode.TabIndex = 11
        Me.saveBarcode.Text = "Save Barcode"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.Animated = True
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BorderRadius = 6
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.Enabled = False
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(190, 437)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Enabled = True
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnDelete.Size = New System.Drawing.Size(152, 49)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.Animated = True
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderRadius = 6
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(24, 437)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Enabled = True
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnAdd.Size = New System.Drawing.Size(159, 49)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.btnSelectPic)
        Me.GunaElipsePanel1.Controls.Add(Me.studentPhoto)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(383, 34)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(245, 246)
        Me.GunaElipsePanel1.TabIndex = 13
        '
        'btnSelectPic
        '
        Me.btnSelectPic.Animated = True
        Me.btnSelectPic.CheckedState.Parent = Me.btnSelectPic
        Me.btnSelectPic.CustomImages.Parent = Me.btnSelectPic
        Me.btnSelectPic.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSelectPic.FillColor = System.Drawing.SystemColors.ControlDark
        Me.btnSelectPic.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectPic.ForeColor = System.Drawing.Color.White
        Me.btnSelectPic.HoverState.Parent = Me.btnSelectPic
        Me.btnSelectPic.Location = New System.Drawing.Point(0, 202)
        Me.btnSelectPic.Name = "btnSelectPic"
        Me.btnSelectPic.ShadowDecoration.Parent = Me.btnSelectPic
        Me.btnSelectPic.Size = New System.Drawing.Size(245, 44)
        Me.btnSelectPic.TabIndex = 0
        Me.btnSelectPic.Text = "Select Photo"
        '
        'studentPhoto
        '
        Me.studentPhoto.BackColor = System.Drawing.Color.Transparent
        Me.studentPhoto.BaseColor = System.Drawing.SystemColors.Control
        Me.studentPhoto.Dock = System.Windows.Forms.DockStyle.Top
        Me.studentPhoto.Image = Global.BISU_BILAR_SSG_ATTENDANCE_MONITORING.My.Resources.Resources.dr_stone_senku_ishigami_uhdpaper_com_4K_9
        Me.studentPhoto.InitialImage = Nothing
        Me.studentPhoto.Location = New System.Drawing.Point(0, 0)
        Me.studentPhoto.Name = "studentPhoto"
        Me.studentPhoto.Radius = 5
        Me.studentPhoto.Size = New System.Drawing.Size(245, 206)
        Me.studentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentPhoto.TabIndex = 5
        Me.studentPhoto.TabStop = False
        '
        'studentCount
        '
        Me.studentCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.studentCount.AutoSize = True
        Me.studentCount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentCount.Location = New System.Drawing.Point(689, 554)
        Me.studentCount.Name = "studentCount"
        Me.studentCount.Size = New System.Drawing.Size(175, 17)
        Me.studentCount.TabIndex = 19
        Me.studentCount.Text = "99 Total Student Registered"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.25!)
        Me.GunaLabel2.Location = New System.Drawing.Point(688, 68)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(249, 22)
        Me.GunaLabel2.TabIndex = 17
        Me.GunaLabel2.Text = "Search and Manage Students"
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgview.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgview.ColumnHeadersHeight = 30
        Me.dgview.ContextMenuStrip = Me.rightClickMenu
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgview.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgview.EnableHeadersVisualStyles = False
        Me.dgview.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.dgview.Location = New System.Drawing.Point(677, 150)
        Me.dgview.MultiSelect = False
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgview.Size = New System.Drawing.Size(457, 387)
        Me.dgview.TabIndex = 16
        Me.dgview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.dgview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgview.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.dgview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgview.ThemeStyle.HeaderStyle.Height = 30
        Me.dgview.ThemeStyle.ReadOnly = True
        Me.dgview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgview.ThemeStyle.RowsStyle.Height = 22
        Me.dgview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'rightClickMenu
        '
        Me.rightClickMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.strpEdit, Me.stripDelete})
        Me.rightClickMenu.Name = "GunaContextMenuStrip1"
        Me.rightClickMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rightClickMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.rightClickMenu.RenderStyle.ColorTable = Nothing
        Me.rightClickMenu.RenderStyle.RoundedEdges = True
        Me.rightClickMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rightClickMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.rightClickMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.rightClickMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.rightClickMenu.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.rightClickMenu.Size = New System.Drawing.Size(115, 46)
        '
        'strpEdit
        '
        Me.strpEdit.Name = "strpEdit"
        Me.strpEdit.Padding = New System.Windows.Forms.Padding(0)
        Me.strpEdit.Size = New System.Drawing.Size(114, 20)
        Me.strpEdit.Text = "Edit"
        '
        'stripDelete
        '
        Me.stripDelete.Name = "stripDelete"
        Me.stripDelete.Size = New System.Drawing.Size(114, 22)
        Me.stripDelete.Text = "Delete"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "JPEG|*.jpg|PNG|*.png|GIF|*.gif|All Files|*."
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.AutoRoundedCorners = True
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.txtSearch.BorderRadius = 18
        Me.txtSearch.BorderThickness = 2
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconRight = CType(resources.GetObject("txtSearch.IconRight"), System.Drawing.Image)
        Me.txtSearch.IconRightOffset = New System.Drawing.Point(7, 0)
        Me.txtSearch.IconRightSize = New System.Drawing.Size(30, 30)
        Me.txtSearch.Location = New System.Drawing.Point(824, 103)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search Student"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(301, 39)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(689, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 16)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "to Edit or Delete"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(689, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 16)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Right Click "
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1137, 583)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.studentCount)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentForm"
        Me.Text = "StudentForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.studentBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        CType(Me.studentPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rightClickMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents studentBarcode As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents tFirst As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnSelectPic As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents studentPhoto As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents tMiddleInitial As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents saveBarcode As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents studentCount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmbDept As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbSect As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents rightClickMenu As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents strpEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stripDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tLast As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
