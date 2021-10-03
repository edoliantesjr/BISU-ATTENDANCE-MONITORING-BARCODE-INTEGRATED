<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventForm))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.eventDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.chckSelectDate = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.chkEveryday = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.eventPlace = New Guna.UI2.WinForms.Guna2TextBox()
        Me.eventID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.eventName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPMenable = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.pmOut = New System.Windows.Forms.DateTimePicker()
        Me.pmIn = New System.Windows.Forms.DateTimePicker()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.amIN = New System.Windows.Forms.DateTimePicker()
        Me.amOut = New System.Windows.Forms.DateTimePicker()
        Me.chkAMEnable = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.eventCount = New Guna.UI.WinForms.GunaLabel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.dgview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REMOVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.eventDate)
        Me.Guna2Panel1.Controls.Add(Me.chckSelectDate)
        Me.Guna2Panel1.Controls.Add(Me.chkEveryday)
        Me.Guna2Panel1.Controls.Add(Me.eventPlace)
        Me.Guna2Panel1.Controls.Add(Me.eventID)
        Me.Guna2Panel1.Controls.Add(Me.eventName)
        Me.Guna2Panel1.Controls.Add(Me.btnClear)
        Me.Guna2Panel1.Controls.Add(Me.btnDelete)
        Me.Guna2Panel1.Controls.Add(Me.btnAdd)
        Me.Guna2Panel1.Controls.Add(Me.GroupBox2)
        Me.Guna2Panel1.Controls.Add(Me.GroupBox1)
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel11)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel4)
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel3)
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(21, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(586, 559)
        Me.Guna2Panel1.TabIndex = 1
        '
        'eventDate
        '
        Me.eventDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.eventDate.BorderThickness = 1
        Me.eventDate.CheckedState.Parent = Me.eventDate
        Me.eventDate.Enabled = False
        Me.eventDate.FillColor = System.Drawing.Color.White
        Me.eventDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.eventDate.HoverState.Parent = Me.eventDate
        Me.eventDate.Location = New System.Drawing.Point(238, 248)
        Me.eventDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.eventDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.eventDate.Name = "eventDate"
        Me.eventDate.ShadowDecoration.Parent = Me.eventDate
        Me.eventDate.Size = New System.Drawing.Size(328, 36)
        Me.eventDate.TabIndex = 21
        Me.eventDate.Value = New Date(2020, 9, 19, 21, 15, 43, 444)
        '
        'chckSelectDate
        '
        Me.chckSelectDate.AutoSize = True
        Me.chckSelectDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.chckSelectDate.CheckedState.BorderRadius = 2
        Me.chckSelectDate.CheckedState.BorderThickness = 0
        Me.chckSelectDate.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.chckSelectDate.Location = New System.Drawing.Point(467, 228)
        Me.chckSelectDate.Name = "chckSelectDate"
        Me.chckSelectDate.Size = New System.Drawing.Size(82, 17)
        Me.chckSelectDate.TabIndex = 20
        Me.chckSelectDate.Text = "Select Date"
        Me.chckSelectDate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chckSelectDate.UncheckedState.BorderRadius = 2
        Me.chckSelectDate.UncheckedState.BorderThickness = 1
        Me.chckSelectDate.UncheckedState.FillColor = System.Drawing.Color.White
        Me.chckSelectDate.UseVisualStyleBackColor = True
        '
        'chkEveryday
        '
        Me.chkEveryday.AutoSize = True
        Me.chkEveryday.Checked = True
        Me.chkEveryday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.chkEveryday.CheckedState.BorderRadius = 2
        Me.chkEveryday.CheckedState.BorderThickness = 0
        Me.chkEveryday.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.chkEveryday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEveryday.Location = New System.Drawing.Point(353, 228)
        Me.chkEveryday.Name = "chkEveryday"
        Me.chkEveryday.Size = New System.Drawing.Size(70, 17)
        Me.chkEveryday.TabIndex = 20
        Me.chkEveryday.Text = "Everyday"
        Me.chkEveryday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkEveryday.UncheckedState.BorderRadius = 2
        Me.chkEveryday.UncheckedState.BorderThickness = 1
        Me.chkEveryday.UncheckedState.FillColor = System.Drawing.Color.White
        Me.chkEveryday.UseVisualStyleBackColor = True
        '
        'eventPlace
        '
        Me.eventPlace.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.eventPlace.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.eventPlace.DefaultText = ""
        Me.eventPlace.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.eventPlace.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.eventPlace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.eventPlace.DisabledState.Parent = Me.eventPlace
        Me.eventPlace.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.eventPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.eventPlace.FocusedState.Parent = Me.eventPlace
        Me.eventPlace.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.eventPlace.ForeColor = System.Drawing.Color.Black
        Me.eventPlace.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.eventPlace.HoverState.Parent = Me.eventPlace
        Me.eventPlace.Location = New System.Drawing.Point(239, 184)
        Me.eventPlace.Margin = New System.Windows.Forms.Padding(4)
        Me.eventPlace.Name = "eventPlace"
        Me.eventPlace.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.eventPlace.PlaceholderText = "Enter Event's Place"
        Me.eventPlace.SelectedText = ""
        Me.eventPlace.ShadowDecoration.Parent = Me.eventPlace
        Me.eventPlace.Size = New System.Drawing.Size(328, 37)
        Me.eventPlace.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.eventPlace.TabIndex = 19
        '
        'eventID
        '
        Me.eventID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.eventID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.eventID.DefaultText = ""
        Me.eventID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.eventID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.eventID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.eventID.DisabledState.Parent = Me.eventID
        Me.eventID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.eventID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.eventID.FocusedState.Parent = Me.eventID
        Me.eventID.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.eventID.ForeColor = System.Drawing.Color.Black
        Me.eventID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.eventID.HoverState.Parent = Me.eventID
        Me.eventID.Location = New System.Drawing.Point(428, 63)
        Me.eventID.Margin = New System.Windows.Forms.Padding(4)
        Me.eventID.Name = "eventID"
        Me.eventID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.eventID.PlaceholderText = "ID"
        Me.eventID.SelectedText = ""
        Me.eventID.ShadowDecoration.Parent = Me.eventID
        Me.eventID.Size = New System.Drawing.Size(138, 37)
        Me.eventID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.eventID.TabIndex = 19
        '
        'eventName
        '
        Me.eventName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.eventName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.eventName.DefaultText = ""
        Me.eventName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.eventName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.eventName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.eventName.DisabledState.Parent = Me.eventName
        Me.eventName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.eventName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.eventName.FocusedState.Parent = Me.eventName
        Me.eventName.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.eventName.ForeColor = System.Drawing.Color.Black
        Me.eventName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.eventName.HoverState.Parent = Me.eventName
        Me.eventName.Location = New System.Drawing.Point(239, 120)
        Me.eventName.Margin = New System.Windows.Forms.Padding(4)
        Me.eventName.Name = "eventName"
        Me.eventName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.eventName.PlaceholderText = "Enter Event Name"
        Me.eventName.SelectedText = ""
        Me.eventName.ShadowDecoration.Parent = Me.eventName
        Me.eventName.Size = New System.Drawing.Size(328, 37)
        Me.eventName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.eventName.TabIndex = 19
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
        Me.btnClear.Location = New System.Drawing.Point(428, 507)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Enabled = True
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnClear.Size = New System.Drawing.Size(139, 43)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
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
        Me.btnDelete.Location = New System.Drawing.Point(278, 507)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Enabled = True
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnDelete.Size = New System.Drawing.Size(145, 45)
        Me.btnDelete.TabIndex = 17
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
        Me.btnAdd.Location = New System.Drawing.Point(135, 507)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Enabled = True
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.btnAdd.Size = New System.Drawing.Size(137, 45)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPMenable)
        Me.GroupBox2.Controls.Add(Me.pmOut)
        Me.GroupBox2.Controls.Add(Me.pmIn)
        Me.GroupBox2.Controls.Add(Me.GunaLabel6)
        Me.GroupBox2.Controls.Add(Me.GunaLabel9)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 397)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 104)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AFTERNOON / EVENING SESSION"
        '
        'chkPMenable
        '
        Me.chkPMenable.AutoSize = True
        Me.chkPMenable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.chkPMenable.CheckedState.BorderRadius = 2
        Me.chkPMenable.CheckedState.BorderThickness = 0
        Me.chkPMenable.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.chkPMenable.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.chkPMenable.Location = New System.Drawing.Point(10, 26)
        Me.chkPMenable.Name = "chkPMenable"
        Me.chkPMenable.Size = New System.Drawing.Size(140, 25)
        Me.chkPMenable.TabIndex = 10
        Me.chkPMenable.Text = "Enable Session"
        Me.chkPMenable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkPMenable.UncheckedState.BorderRadius = 2
        Me.chkPMenable.UncheckedState.BorderThickness = 1
        Me.chkPMenable.UncheckedState.FillColor = System.Drawing.Color.White
        Me.chkPMenable.UseVisualStyleBackColor = True
        '
        'pmOut
        '
        Me.pmOut.CustomFormat = "hh:mm tt"
        Me.pmOut.Enabled = False
        Me.pmOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pmOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.pmOut.Location = New System.Drawing.Point(426, 58)
        Me.pmOut.Name = "pmOut"
        Me.pmOut.ShowUpDown = True
        Me.pmOut.Size = New System.Drawing.Size(115, 26)
        Me.pmOut.TabIndex = 24
        Me.pmOut.Value = New Date(2020, 9, 19, 17, 0, 0, 0)
        '
        'pmIn
        '
        Me.pmIn.CustomFormat = "hh:mm tt"
        Me.pmIn.Enabled = False
        Me.pmIn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pmIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.pmIn.Location = New System.Drawing.Point(137, 57)
        Me.pmIn.Name = "pmIn"
        Me.pmIn.ShowUpDown = True
        Me.pmIn.Size = New System.Drawing.Size(115, 26)
        Me.pmIn.TabIndex = 24
        Me.pmIn.Value = New Date(2020, 9, 19, 13, 0, 0, 0)
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(308, 63)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(117, 21)
        Me.GunaLabel6.TabIndex = 6
        Me.GunaLabel6.Text = "Pm Time Out :"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(26, 63)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(101, 21)
        Me.GunaLabel9.TabIndex = 7
        Me.GunaLabel9.Text = "Pm Time In :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.amIN)
        Me.GroupBox1.Controls.Add(Me.amOut)
        Me.GroupBox1.Controls.Add(Me.chkAMEnable)
        Me.GroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GroupBox1.Controls.Add(Me.GunaLabel7)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 296)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 99)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MORNING SESSION"
        '
        'amIN
        '
        Me.amIN.CustomFormat = "hh:mm tt"
        Me.amIN.Enabled = False
        Me.amIN.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.amIN.Location = New System.Drawing.Point(137, 55)
        Me.amIN.Name = "amIN"
        Me.amIN.ShowUpDown = True
        Me.amIN.Size = New System.Drawing.Size(115, 26)
        Me.amIN.TabIndex = 24
        Me.amIN.Value = New Date(2020, 9, 19, 7, 0, 0, 0)
        '
        'amOut
        '
        Me.amOut.CustomFormat = "hh:mm tt"
        Me.amOut.Enabled = False
        Me.amOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.amOut.Location = New System.Drawing.Point(426, 57)
        Me.amOut.Name = "amOut"
        Me.amOut.ShowUpDown = True
        Me.amOut.Size = New System.Drawing.Size(115, 26)
        Me.amOut.TabIndex = 24
        Me.amOut.Value = New Date(2020, 9, 19, 12, 0, 0, 0)
        '
        'chkAMEnable
        '
        Me.chkAMEnable.AutoSize = True
        Me.chkAMEnable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.chkAMEnable.CheckedState.BorderRadius = 2
        Me.chkAMEnable.CheckedState.BorderThickness = 0
        Me.chkAMEnable.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.chkAMEnable.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.chkAMEnable.Location = New System.Drawing.Point(10, 24)
        Me.chkAMEnable.Name = "chkAMEnable"
        Me.chkAMEnable.Size = New System.Drawing.Size(140, 25)
        Me.chkAMEnable.TabIndex = 10
        Me.chkAMEnable.Text = "Enable Session"
        Me.chkAMEnable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkAMEnable.UncheckedState.BorderRadius = 2
        Me.chkAMEnable.UncheckedState.BorderThickness = 1
        Me.chkAMEnable.UncheckedState.FillColor = System.Drawing.Color.White
        Me.chkAMEnable.UseVisualStyleBackColor = True
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(308, 61)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(121, 21)
        Me.GunaLabel8.TabIndex = 6
        Me.GunaLabel8.Text = "Am Time Out :"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(26, 61)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(105, 21)
        Me.GunaLabel7.TabIndex = 7
        Me.GunaLabel7.Text = "Am Time In :"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.GunaLabel11.Location = New System.Drawing.Point(235, 224)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(105, 18)
        Me.GunaLabel11.TabIndex = 2
        Me.GunaLabel11.Text = "Date of Event :"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(8, 286)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(559, 10)
        Me.Guna2Separator1.TabIndex = 3
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(235, 161)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(112, 18)
        Me.GunaLabel4.TabIndex = 2
        Me.GunaLabel4.Text = "Place Of Event :"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(235, 98)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(97, 18)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "Event Name :"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(352, 74)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(77, 19)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Event ID :"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(8, 62)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(209, 221)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.GunaLabel1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(586, 56)
        Me.Guna2Panel2.TabIndex = 0
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(3, 19)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(206, 25)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "EVENT INFORMATION"
        '
        'eventCount
        '
        Me.eventCount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.eventCount.AutoSize = True
        Me.eventCount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventCount.Location = New System.Drawing.Point(631, 547)
        Me.eventCount.Name = "eventCount"
        Me.eventCount.Size = New System.Drawing.Size(144, 17)
        Me.eventCount.TabIndex = 23
        Me.eventCount.Text = "100 Total Saved Events"
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
        Me.txtSearch.Location = New System.Drawing.Point(804, 81)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search Event"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(321, 39)
        Me.txtSearch.TabIndex = 22
        Me.txtSearch.TextOffset = New System.Drawing.Point(10, 0)
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel10.Location = New System.Drawing.Point(629, 34)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(219, 25)
        Me.GunaLabel10.TabIndex = 21
        Me.GunaLabel10.Text = "SEARCH && EDIT EVENTS"
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgview.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgview.ColumnHeadersHeight = 30
        Me.dgview.ContextMenuStrip = Me.GunaContextMenuStrip1
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgview.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgview.EnableHeadersVisualStyles = False
        Me.dgview.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.dgview.Location = New System.Drawing.Point(610, 132)
        Me.dgview.MultiSelect = False
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.RowHeadersWidth = 30
        Me.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgview.Size = New System.Drawing.Size(524, 403)
        Me.dgview.TabIndex = 20
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
        Me.dgview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dgview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgview.ThemeStyle.RowsStyle.Height = 22
        Me.dgview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'GunaContextMenuStrip1
        '
        Me.GunaContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDITToolStripMenuItem, Me.REMOVEToolStripMenuItem})
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
        Me.GunaContextMenuStrip1.Size = New System.Drawing.Size(121, 48)
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'REMOVEToolStripMenuItem
        '
        Me.REMOVEToolStripMenuItem.Name = "REMOVEToolStripMenuItem"
        Me.REMOVEToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.REMOVEToolStripMenuItem.Text = "REMOVE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(631, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 16)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "to Edit or Delete"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(631, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 16)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Right Click "
        '
        'EventForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1137, 583)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.eventCount)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EventForm"
        Me.Text = "EventForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPMenable As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAMEnable As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents eventCount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pmOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents pmIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents amIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents amOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents eventPlace As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents eventName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chckSelectDate As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents chkEveryday As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REMOVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents eventDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents eventID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
