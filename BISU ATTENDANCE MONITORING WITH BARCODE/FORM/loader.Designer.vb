<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loader
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
        Me.loadingCtrl = New Guna.UI2.WinForms.Guna2ProgressIndicator()
        Me.loadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'loadingCtrl
        '
        Me.loadingCtrl.AnimationSpeed = 79
        Me.loadingCtrl.AutoStart = True
        Me.loadingCtrl.BackColor = System.Drawing.Color.Transparent
        Me.loadingCtrl.CircleSize = 1.0!
        Me.loadingCtrl.Location = New System.Drawing.Point(0, 0)
        Me.loadingCtrl.Name = "loadingCtrl"
        Me.loadingCtrl.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.loadingCtrl.Size = New System.Drawing.Size(285, 285)
        Me.loadingCtrl.TabIndex = 2
        '
        'loadTimer
        '
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(55, 272)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(199, 25)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "SYSTEM LOADING . . ."
        '
        'loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(285, 305)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.loadingCtrl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loader"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loadingCtrl As Guna.UI2.WinForms.Guna2ProgressIndicator
    Friend WithEvents loadTimer As System.Windows.Forms.Timer
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
