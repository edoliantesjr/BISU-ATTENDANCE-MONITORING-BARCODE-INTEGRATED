<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BubbleNotification
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.txtHeader = New Guna.UI.WinForms.GunaLabel()
        Me.msgText = New Guna.UI.WinForms.GunaLabel()
        Me.iconPic = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.iconPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 75)
        Me.Panel1.TabIndex = 5
        '
        'Timer1
        '
        '
        'Guna2TileButton1
        '
        Me.Guna2TileButton1.CheckedState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.CustomImages.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TileButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton1.HoverState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Location = New System.Drawing.Point(301, 0)
        Me.Guna2TileButton1.Name = "Guna2TileButton1"
        Me.Guna2TileButton1.ShadowDecoration.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Size = New System.Drawing.Size(28, 27)
        Me.Guna2TileButton1.TabIndex = 9
        Me.Guna2TileButton1.Text = "X"
        '
        'txtHeader
        '
        Me.txtHeader.AutoSize = True
        Me.txtHeader.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeader.ForeColor = System.Drawing.Color.White
        Me.txtHeader.Location = New System.Drawing.Point(67, 9)
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(94, 30)
        Me.txtHeader.TabIndex = 7
        Me.txtHeader.Text = "Success!"
        '
        'msgText
        '
        Me.msgText.AutoSize = True
        Me.msgText.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.msgText.ForeColor = System.Drawing.Color.White
        Me.msgText.Location = New System.Drawing.Point(81, 44)
        Me.msgText.Name = "msgText"
        Me.msgText.Size = New System.Drawing.Size(97, 17)
        Me.msgText.TabIndex = 8
        Me.msgText.Text = "Message Text"
        '
        'iconPic
        '
        Me.iconPic.Image = Global.BISU_BILAR_SSG_ATTENDANCE_MONITORING.My.Resources.Resources.success
        Me.iconPic.Location = New System.Drawing.Point(18, 6)
        Me.iconPic.Name = "iconPic"
        Me.iconPic.ShadowDecoration.Parent = Me.iconPic
        Me.iconPic.Size = New System.Drawing.Size(46, 44)
        Me.iconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconPic.TabIndex = 6
        Me.iconPic.TabStop = False
        '
        'BubbleNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(330, 75)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2TileButton1)
        Me.Controls.Add(Me.txtHeader)
        Me.Controls.Add(Me.msgText)
        Me.Controls.Add(Me.iconPic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BubbleNotification"
        Me.Text = "BubbleNotification"
        Me.TopMost = True
        CType(Me.iconPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents txtHeader As Guna.UI.WinForms.GunaLabel
    Friend WithEvents msgText As Guna.UI.WinForms.GunaLabel
    Friend WithEvents iconPic As Guna.UI2.WinForms.Guna2PictureBox
End Class
