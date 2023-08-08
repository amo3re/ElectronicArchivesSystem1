<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEMail))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnhelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Ck2 = New System.Windows.Forms.CheckBox()
        Me.Ck1 = New System.Windows.Forms.CheckBox()
        Me.txtHidenCopyTo = New System.Windows.Forms.TextBox()
        Me.txtCopyTo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CombPorts = New System.Windows.Forms.ComboBox()
        Me.CombSMTPServers = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReceiverAddress = New System.Windows.Forms.TextBox()
        Me.SenderAddress = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAddAttaches = New System.Windows.Forms.Button()
        Me.AtatchName = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtMessageBody = New System.Windows.Forms.RichTextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CkShowHide = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SenderAccPassword = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(603, 43)
        Me.Panel2.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnhelp, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(603, 43)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnhelp
        '
        Me.btnhelp.AutoSize = False
        Me.btnhelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnhelp.Image = Global.Electronic_Archives_System.My.Resources.Resources.Index_16x16
        Me.btnhelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(35, 35)
        Me.btnhelp.Text = "إرسال ملف"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Sakkal Majalla", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(500, 40)
        Me.ToolStripLabel1.Text = "إرسال بريد الكتروني"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CkShowHide)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.SenderAccPassword)
        Me.Panel1.Controls.Add(Me.Ck2)
        Me.Panel1.Controls.Add(Me.Ck1)
        Me.Panel1.Controls.Add(Me.txtHidenCopyTo)
        Me.Panel1.Controls.Add(Me.txtCopyTo)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CombPorts)
        Me.Panel1.Controls.Add(Me.CombSMTPServers)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ReceiverAddress)
        Me.Panel1.Controls.Add(Me.SenderAddress)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 251)
        Me.Panel1.TabIndex = 2
        '
        'Ck2
        '
        Me.Ck2.AutoSize = True
        Me.Ck2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Ck2.Location = New System.Drawing.Point(491, 221)
        Me.Ck2.Name = "Ck2"
        Me.Ck2.Size = New System.Drawing.Size(108, 20)
        Me.Ck2.TabIndex = 8
        Me.Ck2.Text = "نسخة مخفية"
        Me.Ck2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Ck2, "ارسال نسخة كاربونية من الرسالة ولكن في الحاله هذه لن يعرف المستقبل انه تم عمل نسخ" & _
        "ة كربونية لبريد اخر بسبب انها مخفية " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Ck2.UseVisualStyleBackColor = True
        '
        'Ck1
        '
        Me.Ck1.AutoSize = True
        Me.Ck1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ck1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Ck1.Location = New System.Drawing.Point(492, 186)
        Me.Ck1.Name = "Ck1"
        Me.Ck1.Size = New System.Drawing.Size(91, 20)
        Me.Ck1.TabIndex = 6
        Me.Ck1.Text = "نسخة الى"
        Me.ToolTip1.SetToolTip(Me.Ck1, "ارسال نسخة كاربونية من الرسالة ولكن في الحاله هذه سيعرف المستقبل انه تم عمل نسخة " & _
        "كربونية لبريد اخر")
        Me.Ck1.UseVisualStyleBackColor = True
        '
        'txtHidenCopyTo
        '
        Me.txtHidenCopyTo.BackColor = System.Drawing.SystemColors.Control
        Me.txtHidenCopyTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHidenCopyTo.Enabled = False
        Me.txtHidenCopyTo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHidenCopyTo.Location = New System.Drawing.Point(69, 215)
        Me.txtHidenCopyTo.Multiline = True
        Me.txtHidenCopyTo.Name = "txtHidenCopyTo"
        Me.txtHidenCopyTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHidenCopyTo.Size = New System.Drawing.Size(417, 30)
        Me.txtHidenCopyTo.TabIndex = 9
        '
        'txtCopyTo
        '
        Me.txtCopyTo.BackColor = System.Drawing.SystemColors.Control
        Me.txtCopyTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCopyTo.Enabled = False
        Me.txtCopyTo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopyTo.Location = New System.Drawing.Point(69, 180)
        Me.txtCopyTo.Multiline = True
        Me.txtCopyTo.Name = "txtCopyTo"
        Me.txtCopyTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCopyTo.Size = New System.Drawing.Size(417, 29)
        Me.txtCopyTo.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(174, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "البورت"
        '
        'CombPorts
        '
        Me.CombPorts.BackColor = System.Drawing.Color.AliceBlue
        Me.CombPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CombPorts.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombPorts.FormattingEnabled = True
        Me.CombPorts.Items.AddRange(New Object() {"587", "465", "25"})
        Me.CombPorts.Location = New System.Drawing.Point(69, 74)
        Me.CombPorts.Name = "CombPorts"
        Me.CombPorts.Size = New System.Drawing.Size(101, 26)
        Me.CombPorts.TabIndex = 4
        '
        'CombSMTPServers
        '
        Me.CombSMTPServers.BackColor = System.Drawing.Color.AliceBlue
        Me.CombSMTPServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CombSMTPServers.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombSMTPServers.FormattingEnabled = True
        Me.CombSMTPServers.Items.AddRange(New Object() {"smtp.gmail.com", "smtp.live.com", "smtp.yahoo.com", "plus.smtp.mail.yahoo.com", "mail.gmx.com"})
        Me.CombSMTPServers.Location = New System.Drawing.Point(227, 75)
        Me.CombSMTPServers.Name = "CombSMTPServers"
        Me.CombSMTPServers.Size = New System.Drawing.Size(259, 26)
        Me.CombSMTPServers.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(489, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "السرفر"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(490, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "المستلم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(489, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "المرسل"
        '
        'ReceiverAddress
        '
        Me.ReceiverAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReceiverAddress.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiverAddress.Location = New System.Drawing.Point(69, 107)
        Me.ReceiverAddress.Multiline = True
        Me.ReceiverAddress.Name = "ReceiverAddress"
        Me.ReceiverAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ReceiverAddress.Size = New System.Drawing.Size(417, 67)
        Me.ReceiverAddress.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ReceiverAddress, "اذا كنت تريد الارسال الى أكثر من بريد فعليك عمل بينهم علامة الكومة " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ",")
        '
        'SenderAddress
        '
        Me.SenderAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SenderAddress.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenderAddress.Location = New System.Drawing.Point(69, 5)
        Me.SenderAddress.Name = "SenderAddress"
        Me.SenderAddress.Size = New System.Drawing.Size(417, 29)
        Me.SenderAddress.TabIndex = 0
        Me.SenderAddress.Text = "amo3re@gmail.com"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Controls.Add(Me.btnSend)
        Me.Panel4.Controls.Add(Me.btnNew)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 582)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(603, 52)
        Me.Panel4.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.Electronic_Archives_System.My.Resources.Resources.Close_16x16
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(69, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 29)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "إغلاق"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Image = Global.Electronic_Archives_System.My.Resources.Resources.Mail_16x16__3_
        Me.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSend.Location = New System.Drawing.Point(160, 11)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(226, 29)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "إرسال"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.Electronic_Archives_System.My.Resources.Resources.AddItem_1616
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(392, 11)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(94, 29)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnAddAttaches)
        Me.Panel5.Controls.Add(Me.AtatchName)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 544)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(603, 38)
        Me.Panel5.TabIndex = 0
        '
        'btnAddAttaches
        '
        Me.btnAddAttaches.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAddAttaches.ForeColor = System.Drawing.Color.Black
        Me.btnAddAttaches.Location = New System.Drawing.Point(490, 4)
        Me.btnAddAttaches.Name = "btnAddAttaches"
        Me.btnAddAttaches.Size = New System.Drawing.Size(100, 29)
        Me.btnAddAttaches.TabIndex = 0
        Me.btnAddAttaches.Text = "إضافة مرفق"
        Me.btnAddAttaches.UseVisualStyleBackColor = True
        '
        'AtatchName
        '
        Me.AtatchName.BackColor = System.Drawing.SystemColors.Menu
        Me.AtatchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AtatchName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtatchName.ForeColor = System.Drawing.Color.Blue
        Me.AtatchName.Location = New System.Drawing.Point(69, 4)
        Me.AtatchName.Name = "AtatchName"
        Me.AtatchName.Size = New System.Drawing.Size(417, 29)
        Me.AtatchName.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtMessageBody)
        Me.Panel3.Controls.Add(Me.txtSubject)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(0, 295)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(603, 248)
        Me.Panel3.TabIndex = 5
        '
        'txtMessageBody
        '
        Me.txtMessageBody.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtMessageBody.Location = New System.Drawing.Point(69, 36)
        Me.txtMessageBody.Name = "txtMessageBody"
        Me.txtMessageBody.Size = New System.Drawing.Size(417, 206)
        Me.txtMessageBody.TabIndex = 1
        Me.txtMessageBody.Text = ""
        '
        'txtSubject
        '
        Me.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubject.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(69, 4)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(417, 29)
        Me.txtSubject.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(486, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "الرسالة"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(489, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "الموضوع"
        '
        'CkShowHide
        '
        Me.CkShowHide.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CkShowHide.BackColor = System.Drawing.Color.White
        Me.CkShowHide.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkShowHide.Location = New System.Drawing.Point(74, 42)
        Me.CkShowHide.Name = "CkShowHide"
        Me.CkShowHide.Size = New System.Drawing.Size(61, 24)
        Me.CkShowHide.TabIndex = 2
        Me.CkShowHide.Tag = ""
        Me.CkShowHide.Text = "إظهار"
        Me.CkShowHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CkShowHide.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(491, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "كلمه المرور"
        '
        'SenderAccPassword
        '
        Me.SenderAccPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SenderAccPassword.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenderAccPassword.Location = New System.Drawing.Point(69, 39)
        Me.SenderAccPassword.Name = "SenderAccPassword"
        Me.SenderAccPassword.Size = New System.Drawing.Size(415, 29)
        Me.SenderAccPassword.TabIndex = 1
        Me.SenderAccPassword.Tag = ""
        Me.SenderAccPassword.Text = "hhpbriolzcxnlnsu"
        Me.SenderAccPassword.UseSystemPasswordChar = True
        '
        'FrmEMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(603, 634)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEMail"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إرسال البريد الإلكتروني"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnhelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CombPorts As System.Windows.Forms.ComboBox
    Friend WithEvents CombSMTPServers As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ReceiverAddress As System.Windows.Forms.TextBox
    Friend WithEvents SenderAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtMessageBody As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAddAttaches As System.Windows.Forms.Button
    Friend WithEvents AtatchName As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Ck2 As System.Windows.Forms.CheckBox
    Friend WithEvents Ck1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtHidenCopyTo As System.Windows.Forms.TextBox
    Friend WithEvents txtCopyTo As System.Windows.Forms.TextBox
    Friend WithEvents CkShowHide As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SenderAccPassword As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
