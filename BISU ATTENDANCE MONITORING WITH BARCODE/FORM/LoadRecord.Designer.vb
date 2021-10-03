<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadRecord))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnPrintRecord = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbSect = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.srchStudent = New Guna.UI2.WinForms.Guna2TextBox()
        Me.srchCourses = New Guna.UI2.WinForms.Guna2TextBox()
        Me.srchEvent = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnLoadRecord = New Guna.UI2.WinForms.Guna2Button()
        Me.record_dgview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.record_dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrintRecord
        '
        Me.btnPrintRecord.BorderRadius = 5
        Me.btnPrintRecord.CheckedState.Parent = Me.btnPrintRecord
        Me.btnPrintRecord.CustomImages.Parent = Me.btnPrintRecord
        Me.btnPrintRecord.Enabled = False
        Me.btnPrintRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintRecord.ForeColor = System.Drawing.Color.White
        Me.btnPrintRecord.HoverState.Parent = Me.btnPrintRecord
        Me.btnPrintRecord.Location = New System.Drawing.Point(959, 526)
        Me.btnPrintRecord.Name = "btnPrintRecord"
        Me.btnPrintRecord.ShadowDecoration.Parent = Me.btnPrintRecord
        Me.btnPrintRecord.Size = New System.Drawing.Size(166, 45)
        Me.btnPrintRecord.TabIndex = 2
        Me.btnPrintRecord.Text = "PRINT RECORD"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.cmbSect)
        Me.Guna2Panel1.Controls.Add(Me.cmbYear)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.srchStudent)
        Me.Guna2Panel1.Controls.Add(Me.srchCourses)
        Me.Guna2Panel1.Controls.Add(Me.srchEvent)
        Me.Guna2Panel1.Controls.Add(Me.btnLoadRecord)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1113, 80)
        Me.Guna2Panel1.TabIndex = 3
        '
        'cmbSect
        '
        Me.cmbSect.BackColor = System.Drawing.Color.Transparent
        Me.cmbSect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSect.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbSect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbSect.FocusedState.Parent = Me.cmbSect
        Me.cmbSect.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSect.FormattingEnabled = True
        Me.cmbSect.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbSect.HoverState.Parent = Me.cmbSect
        Me.cmbSect.ItemHeight = 30
        Me.cmbSect.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P"})
        Me.cmbSect.ItemsAppearance.Parent = Me.cmbSect
        Me.cmbSect.Location = New System.Drawing.Point(566, 32)
        Me.cmbSect.Name = "cmbSect"
        Me.cmbSect.ShadowDecoration.Parent = Me.cmbSect
        Me.cmbSect.Size = New System.Drawing.Size(152, 36)
        Me.cmbSect.TabIndex = 25
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.Color.Transparent
        Me.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbYear.FocusedState.Parent = Me.cmbYear
        Me.cmbYear.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.cmbYear.HoverState.Parent = Me.cmbYear
        Me.cmbYear.ItemHeight = 30
        Me.cmbYear.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbYear.ItemsAppearance.Parent = Me.cmbYear
        Me.cmbYear.Location = New System.Drawing.Point(387, 32)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.ShadowDecoration.Parent = Me.cmbYear
        Me.cmbYear.Size = New System.Drawing.Size(152, 36)
        Me.cmbYear.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(741, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Select Student"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(563, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Select Section"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Select Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Select Course"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Select Event"
        '
        'srchStudent
        '
        Me.srchStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.srchStudent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.srchStudent.DefaultText = ""
        Me.srchStudent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.srchStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.srchStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.srchStudent.DisabledState.Parent = Me.srchStudent
        Me.srchStudent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.srchStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.srchStudent.FocusedState.Parent = Me.srchStudent
        Me.srchStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.srchStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.srchStudent.HoverState.Parent = Me.srchStudent
        Me.srchStudent.IconRight = CType(resources.GetObject("srchStudent.IconRight"), System.Drawing.Image)
        Me.srchStudent.IconRightOffset = New System.Drawing.Point(7, 0)
        Me.srchStudent.IconRightSize = New System.Drawing.Size(30, 30)
        Me.srchStudent.Location = New System.Drawing.Point(744, 32)
        Me.srchStudent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.srchStudent.Name = "srchStudent"
        Me.srchStudent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.srchStudent.PlaceholderText = "Look Up"
        Me.srchStudent.SelectedText = ""
        Me.srchStudent.ShadowDecoration.Parent = Me.srchStudent
        Me.srchStudent.Size = New System.Drawing.Size(173, 36)
        Me.srchStudent.TabIndex = 23
        Me.srchStudent.TextOffset = New System.Drawing.Point(5, 0)
        '
        'srchCourses
        '
        Me.srchCourses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.srchCourses.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.srchCourses.DefaultText = ""
        Me.srchCourses.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.srchCourses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.srchCourses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.srchCourses.DisabledState.Parent = Me.srchCourses
        Me.srchCourses.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.srchCourses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.srchCourses.FocusedState.Parent = Me.srchCourses
        Me.srchCourses.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.srchCourses.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.srchCourses.HoverState.Parent = Me.srchCourses
        Me.srchCourses.IconRight = CType(resources.GetObject("srchCourses.IconRight"), System.Drawing.Image)
        Me.srchCourses.IconRightOffset = New System.Drawing.Point(7, 0)
        Me.srchCourses.IconRightSize = New System.Drawing.Size(30, 30)
        Me.srchCourses.Location = New System.Drawing.Point(213, 32)
        Me.srchCourses.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.srchCourses.Name = "srchCourses"
        Me.srchCourses.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.srchCourses.PlaceholderText = "Look Up"
        Me.srchCourses.SelectedText = ""
        Me.srchCourses.ShadowDecoration.Parent = Me.srchCourses
        Me.srchCourses.Size = New System.Drawing.Size(152, 36)
        Me.srchCourses.TabIndex = 23
        Me.srchCourses.TextOffset = New System.Drawing.Point(5, 0)
        '
        'srchEvent
        '
        Me.srchEvent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.srchEvent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.srchEvent.DefaultText = ""
        Me.srchEvent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.srchEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.srchEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.srchEvent.DisabledState.Parent = Me.srchEvent
        Me.srchEvent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.srchEvent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.srchEvent.FocusedState.Parent = Me.srchEvent
        Me.srchEvent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.srchEvent.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.srchEvent.HoverState.Parent = Me.srchEvent
        Me.srchEvent.IconRight = CType(resources.GetObject("srchEvent.IconRight"), System.Drawing.Image)
        Me.srchEvent.IconRightOffset = New System.Drawing.Point(7, 0)
        Me.srchEvent.IconRightSize = New System.Drawing.Size(30, 30)
        Me.srchEvent.Location = New System.Drawing.Point(17, 32)
        Me.srchEvent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.srchEvent.Name = "srchEvent"
        Me.srchEvent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.srchEvent.PlaceholderText = "Look Up"
        Me.srchEvent.SelectedText = ""
        Me.srchEvent.ShadowDecoration.Parent = Me.srchEvent
        Me.srchEvent.Size = New System.Drawing.Size(173, 36)
        Me.srchEvent.TabIndex = 23
        Me.srchEvent.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnLoadRecord
        '
        Me.btnLoadRecord.AutoRoundedCorners = True
        Me.btnLoadRecord.BorderRadius = 21
        Me.btnLoadRecord.CheckedState.Parent = Me.btnLoadRecord
        Me.btnLoadRecord.CustomImages.Parent = Me.btnLoadRecord
        Me.btnLoadRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadRecord.ForeColor = System.Drawing.Color.White
        Me.btnLoadRecord.HoverState.Parent = Me.btnLoadRecord
        Me.btnLoadRecord.Location = New System.Drawing.Point(933, 26)
        Me.btnLoadRecord.Name = "btnLoadRecord"
        Me.btnLoadRecord.ShadowDecoration.Parent = Me.btnLoadRecord
        Me.btnLoadRecord.Size = New System.Drawing.Size(166, 45)
        Me.btnLoadRecord.TabIndex = 2
        Me.btnLoadRecord.Text = "GO"
        '
        'record_dgview
        '
        Me.record_dgview.AllowUserToAddRows = False
        Me.record_dgview.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.record_dgview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.record_dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.record_dgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.record_dgview.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.record_dgview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.record_dgview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.record_dgview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.record_dgview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.record_dgview.ColumnHeadersHeight = 26
        Me.record_dgview.ContextMenuStrip = Me.GunaContextMenuStrip1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.record_dgview.DefaultCellStyle = DataGridViewCellStyle3
        Me.record_dgview.EnableHeadersVisualStyles = False
        Me.record_dgview.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.record_dgview.Location = New System.Drawing.Point(12, 97)
        Me.record_dgview.Name = "record_dgview"
        Me.record_dgview.ReadOnly = True
        Me.record_dgview.RowHeadersVisible = False
        Me.record_dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.record_dgview.Size = New System.Drawing.Size(1113, 423)
        Me.record_dgview.TabIndex = 4
        Me.record_dgview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.record_dgview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.record_dgview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.record_dgview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.record_dgview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.record_dgview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.record_dgview.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.record_dgview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.record_dgview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.record_dgview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.record_dgview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.record_dgview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.record_dgview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.record_dgview.ThemeStyle.HeaderStyle.Height = 26
        Me.record_dgview.ThemeStyle.ReadOnly = True
        Me.record_dgview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.record_dgview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.record_dgview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.record_dgview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.record_dgview.ThemeStyle.RowsStyle.Height = 22
        Me.record_dgview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.record_dgview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaContextMenuStrip1
        '
        Me.GunaContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELETEToolStripMenuItem})
        Me.GunaContextMenuStrip1.Name = "GunaContextMenuStrip1"
        Me.GunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.GunaContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.GunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.GunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.GunaContextMenuStrip1.Size = New System.Drawing.Size(113, 26)
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'LoadRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1137, 583)
        Me.Controls.Add(Me.record_dgview)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnPrintRecord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoadRecord"
        Me.Text = "LoadRecord"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.record_dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrintRecord As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLoadRecord As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents record_dgview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents srchCourses As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents srchEvent As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents srchStudent As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbSect As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
End Class
