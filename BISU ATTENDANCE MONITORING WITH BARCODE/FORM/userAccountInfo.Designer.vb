<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userAccountInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userAccountInfo))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.userPhoto1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.fullName1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.username1 = New Guna.UI.WinForms.GunaLabel()
        Me.password1 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.userPhoto1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'userPhoto1
        '
        Me.userPhoto1.Image = CType(resources.GetObject("userPhoto1.Image"), System.Drawing.Image)
        Me.userPhoto1.Location = New System.Drawing.Point(69, 22)
        Me.userPhoto1.Name = "userPhoto1"
        Me.userPhoto1.ShadowDecoration.BorderRadius = 50
        Me.userPhoto1.ShadowDecoration.Depth = 50
        Me.userPhoto1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.userPhoto1.ShadowDecoration.Parent = Me.userPhoto1
        Me.userPhoto1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 0, 1, 2)
        Me.userPhoto1.Size = New System.Drawing.Size(193, 194)
        Me.userPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userPhoto1.TabIndex = 9
        Me.userPhoto1.TabStop = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(52, 250)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(45, 15)
        Me.GunaLabel2.TabIndex = 10
        Me.GunaLabel2.Text = "Name :"
        '
        'fullName1
        '
        Me.fullName1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fullName1.AutoSize = True
        Me.fullName1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fullName1.Location = New System.Drawing.Point(110, 250)
        Me.fullName1.Name = "fullName1"
        Me.fullName1.Size = New System.Drawing.Size(45, 15)
        Me.fullName1.TabIndex = 10
        Me.fullName1.Text = "Name :"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(31, 274)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(66, 15)
        Me.GunaLabel3.TabIndex = 10
        Me.GunaLabel3.Text = "Username :"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(34, 299)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(63, 15)
        Me.GunaLabel4.TabIndex = 10
        Me.GunaLabel4.Text = "Password :"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(333, 16)
        Me.GunaPanel1.TabIndex = 11
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.TargetControl = Me.GunaPanel1
        '
        'username1
        '
        Me.username1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.username1.AutoSize = True
        Me.username1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.username1.Location = New System.Drawing.Point(110, 274)
        Me.username1.Name = "username1"
        Me.username1.Size = New System.Drawing.Size(66, 15)
        Me.username1.TabIndex = 10
        Me.username1.Text = "Username :"
        '
        'password1
        '
        Me.password1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.password1.AutoSize = True
        Me.password1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.password1.Location = New System.Drawing.Point(110, 299)
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(63, 15)
        Me.password1.TabIndex = 10
        Me.password1.Text = "Password :"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(48, 330)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 15
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.Guna2Button1.Size = New System.Drawing.Size(111, 33)
        Me.Guna2Button1.TabIndex = 12
        Me.Guna2Button1.Text = "Close"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 15
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Black
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(165, 330)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.BorderRadius = 15
        Me.Guna2Button2.ShadowDecoration.Enabled = True
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 1, 1, 3)
        Me.Guna2Button2.Size = New System.Drawing.Size(111, 33)
        Me.Guna2Button2.TabIndex = 12
        Me.Guna2Button2.Text = "Log Out"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(75, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "USER ACCOUNT DETAILS"
        '
        'userAccountInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(333, 386)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.fullName1)
        Me.Controls.Add(Me.password1)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.username1)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.userPhoto1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userAccountInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userAccountInfo"
        CType(Me.userPhoto1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents userPhoto1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents fullName1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents password1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents username1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
