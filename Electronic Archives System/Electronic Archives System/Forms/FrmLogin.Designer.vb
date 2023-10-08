<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnhelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.ckConSettings = New System.Windows.Forms.CheckBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnLoging = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 45)
        Me.Panel1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Navy
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnhelp, Me.ToolStripLabel1, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(540, 45)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnhelp
        '
        Me.btnhelp.AutoSize = False
        Me.btnhelp.BackgroundImage = Global.Electronic_Archives_System.My.Resources.Resources.archive482
        Me.btnhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnhelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnhelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(40, 40)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Sakkal Majalla", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(450, 40)
        Me.ToolStripLabel1.Text = "برنامج الإرشيف الإلكتروني"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = False
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Image = Global.Electronic_Archives_System.My.Resources.Resources.x_mark_3_32
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.Text = "إغلاق"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 455)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 45)
        Me.Panel2.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(357, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(131, 45)
        Me.lblTime.TabIndex = 1
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Image = Global.Electronic_Archives_System.My.Resources.Resources.clock_play
        Me.Label1.Location = New System.Drawing.Point(488, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 45)
        Me.Label1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUserPassword)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 129)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معلومات الدخول"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "كلمة المرور"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(360, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "اسم المستخدم"
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPassword.Location = New System.Drawing.Point(40, 86)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserPassword.Size = New System.Drawing.Size(317, 29)
        Me.txtUserPassword.TabIndex = 1
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(40, 41)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(317, 29)
        Me.txtUserName.TabIndex = 0
        '
        'ckConSettings
        '
        Me.ckConSettings.AutoSize = True
        Me.ckConSettings.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckConSettings.Location = New System.Drawing.Point(35, 415)
        Me.ckConSettings.Name = "ckConSettings"
        Me.ckConSettings.Size = New System.Drawing.Size(180, 29)
        Me.ckConSettings.TabIndex = 3
        Me.ckConSettings.Text = "إعدادات الاتصال بالسيرفر"
        Me.ckConSettings.UseVisualStyleBackColor = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnLoging
        '
        Me.btnLoging.ActiveBorderThickness = 1
        Me.btnLoging.ActiveCornerRadius = 20
        Me.btnLoging.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.btnLoging.ActiveForecolor = System.Drawing.Color.White
        Me.btnLoging.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.btnLoging.BackColor = System.Drawing.SystemColors.Control
        Me.btnLoging.BackgroundImage = CType(resources.GetObject("btnLoging.BackgroundImage"), System.Drawing.Image)
        Me.btnLoging.ButtonText = "دخول"
        Me.btnLoging.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoging.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoging.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnLoging.IdleBorderThickness = 1
        Me.btnLoging.IdleCornerRadius = 20
        Me.btnLoging.IdleFillColor = System.Drawing.Color.White
        Me.btnLoging.IdleForecolor = System.Drawing.Color.SteelBlue
        Me.btnLoging.IdleLineColor = System.Drawing.Color.SteelBlue
        Me.btnLoging.Location = New System.Drawing.Point(68, 353)
        Me.btnLoging.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLoging.Name = "btnLoging"
        Me.btnLoging.Size = New System.Drawing.Size(209, 41)
        Me.btnLoging.TabIndex = 5
        Me.btnLoging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.ActiveBorderThickness = 1
        Me.btnLogout.ActiveCornerRadius = 20
        Me.btnLogout.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.btnLogout.ActiveForecolor = System.Drawing.Color.White
        Me.btnLogout.ActiveLineColor = System.Drawing.Color.SteelBlue
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.ButtonText = "خروج"
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnLogout.IdleBorderThickness = 1
        Me.btnLogout.IdleCornerRadius = 20
        Me.btnLogout.IdleFillColor = System.Drawing.Color.White
        Me.btnLogout.IdleForecolor = System.Drawing.Color.SteelBlue
        Me.btnLogout.IdleLineColor = System.Drawing.Color.SteelBlue
        Me.btnLogout.Location = New System.Drawing.Point(300, 353)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(209, 41)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.BunifuImageButton1.Image = Global.Electronic_Archives_System.My.Resources.Resources.flat_seo_30_512
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(203, 54)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(157, 139)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 6
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 7
        Me.BunifuElipse2.TargetControl = Me.BunifuImageButton1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 500)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLoging)
        Me.Controls.Add(Me.ckConSettings)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة الدخول"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnhelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents ckConSettings As System.Windows.Forms.CheckBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnLoging As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
