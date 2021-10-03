<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectImgSource
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectImgSource))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.checkDefault = New Guna.UI.WinForms.GunaCheckBox()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnContinue = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.rFile = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.rCamera = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'checkDefault
        '
        Me.checkDefault.BaseColor = System.Drawing.Color.White
        Me.checkDefault.CheckedOffColor = System.Drawing.Color.Gray
        Me.checkDefault.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkDefault.FillColor = System.Drawing.Color.White
        Me.checkDefault.Location = New System.Drawing.Point(78, 69)
        Me.checkDefault.Name = "checkDefault"
        Me.checkDefault.Size = New System.Drawing.Size(143, 20)
        Me.checkDefault.TabIndex = 23
        Me.checkDefault.Text = "Always Use as Default"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(315, 22)
        Me.Guna2Panel1.TabIndex = 25
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(4, 31)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(204, 21)
        Me.GunaLabel1.TabIndex = 26
        Me.GunaLabel1.Text = "Select Student Photo Using :"
        '
        'btnContinue
        '
        Me.btnContinue.Animated = True
        Me.btnContinue.AnimationHoverSpeed = 0.07!
        Me.btnContinue.AnimationSpeed = 0.03!
        Me.btnContinue.BackColor = System.Drawing.Color.Transparent
        Me.btnContinue.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnContinue.BorderColor = System.Drawing.Color.Black
        Me.btnContinue.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnContinue.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnContinue.CheckedForeColor = System.Drawing.Color.White
        Me.btnContinue.CheckedImage = CType(resources.GetObject("btnContinue.CheckedImage"), System.Drawing.Image)
        Me.btnContinue.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnContinue.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnContinue.Enabled = False
        Me.btnContinue.FocusedColor = System.Drawing.Color.Empty
        Me.btnContinue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.White
        Me.btnContinue.Image = Nothing
        Me.btnContinue.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnContinue.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnContinue.Location = New System.Drawing.Point(78, 168)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnContinue.OnHoverBorderColor = System.Drawing.Color.Empty
        Me.btnContinue.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnContinue.OnHoverImage = Nothing
        Me.btnContinue.OnHoverLineColor = System.Drawing.Color.Empty
        Me.btnContinue.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btnContinue.Radius = 5
        Me.btnContinue.Size = New System.Drawing.Size(160, 40)
        Me.btnContinue.TabIndex = 24
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rFile
        '
        Me.rFile.Animated = True
        Me.rFile.AnimationHoverSpeed = 0.07!
        Me.rFile.AnimationSpeed = 0.03!
        Me.rFile.BackColor = System.Drawing.Color.Transparent
        Me.rFile.BaseColor = System.Drawing.Color.Transparent
        Me.rFile.BorderColor = System.Drawing.Color.Black
        Me.rFile.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.rFile.CheckedBaseColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rFile.CheckedBorderColor = System.Drawing.Color.Black
        Me.rFile.CheckedForeColor = System.Drawing.Color.White
        Me.rFile.CheckedImage = CType(resources.GetObject("rFile.CheckedImage"), System.Drawing.Image)
        Me.rFile.CheckedLineColor = System.Drawing.Color.DimGray
        Me.rFile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.rFile.FocusedColor = System.Drawing.Color.Empty
        Me.rFile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rFile.ForeColor = System.Drawing.Color.White
        Me.rFile.Image = CType(resources.GetObject("rFile.Image"), System.Drawing.Image)
        Me.rFile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rFile.ImageSize = New System.Drawing.Size(50, 50)
        Me.rFile.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rFile.Location = New System.Drawing.Point(198, 94)
        Me.rFile.Name = "rFile"
        Me.rFile.OnHoverBaseColor = System.Drawing.SystemColors.Control
        Me.rFile.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.rFile.OnHoverForeColor = System.Drawing.Color.White
        Me.rFile.OnHoverImage = Nothing
        Me.rFile.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rFile.OnPressedColor = System.Drawing.SystemColors.Control
        Me.rFile.Radius = 2
        Me.rFile.Size = New System.Drawing.Size(49, 42)
        Me.rFile.TabIndex = 21
        '
        'rCamera
        '
        Me.rCamera.Animated = True
        Me.rCamera.AnimationHoverSpeed = 0.07!
        Me.rCamera.AnimationSpeed = 0.03!
        Me.rCamera.BackColor = System.Drawing.Color.Transparent
        Me.rCamera.BaseColor = System.Drawing.Color.Transparent
        Me.rCamera.BorderColor = System.Drawing.Color.Black
        Me.rCamera.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.rCamera.CheckedBaseColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rCamera.CheckedBorderColor = System.Drawing.Color.Black
        Me.rCamera.CheckedForeColor = System.Drawing.Color.White
        Me.rCamera.CheckedImage = CType(resources.GetObject("rCamera.CheckedImage"), System.Drawing.Image)
        Me.rCamera.CheckedLineColor = System.Drawing.Color.DimGray
        Me.rCamera.DialogResult = System.Windows.Forms.DialogResult.None
        Me.rCamera.FocusedColor = System.Drawing.Color.Empty
        Me.rCamera.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rCamera.ForeColor = System.Drawing.Color.White
        Me.rCamera.Image = CType(resources.GetObject("rCamera.Image"), System.Drawing.Image)
        Me.rCamera.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rCamera.ImageSize = New System.Drawing.Size(50, 50)
        Me.rCamera.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rCamera.Location = New System.Drawing.Point(78, 95)
        Me.rCamera.Name = "rCamera"
        Me.rCamera.OnHoverBaseColor = System.Drawing.SystemColors.Control
        Me.rCamera.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.rCamera.OnHoverForeColor = System.Drawing.Color.White
        Me.rCamera.OnHoverImage = Nothing
        Me.rCamera.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.rCamera.OnPressedColor = System.Drawing.SystemColors.Control
        Me.rCamera.Radius = 2
        Me.rCamera.Size = New System.Drawing.Size(49, 42)
        Me.rCamera.TabIndex = 22
        '
        'SelectImgSource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 230)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.checkDefault)
        Me.Controls.Add(Me.rFile)
        Me.Controls.Add(Me.rCamera)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SelectImgSource"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SelectImgSource"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnContinue As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents checkDefault As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents rFile As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents rCamera As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
