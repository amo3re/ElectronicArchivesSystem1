<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserAccounts
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
        Me.lblconfirmMessage = New System.Windows.Forms.Label()
        Me.AccType = New System.Windows.Forms.ComboBox()
        Me.btnDeleteImage = New System.Windows.Forms.Button()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.UserImage = New System.Windows.Forms.PictureBox()
        Me.AccActivate = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PicMessage = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.UserAccountName = New System.Windows.Forms.TextBox()
        Me.UserAccID = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnhelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnLast = New System.Windows.Forms.ToolStripButton()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnPreviouse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFirst = New System.Windows.Forms.ToolStripButton()
        Me.btnNext = New System.Windows.Forms.ToolStripButton()
        Me.txtNevigate = New System.Windows.Forms.ToolStripTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UserPassword = New System.Windows.Forms.TextBox()
        Me.ck_ShowPasword = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblconfirmMessage
        '
        Me.lblconfirmMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblconfirmMessage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblconfirmMessage.ForeColor = System.Drawing.Color.Blue
        Me.lblconfirmMessage.Location = New System.Drawing.Point(263, 0)
        Me.lblconfirmMessage.Name = "lblconfirmMessage"
        Me.lblconfirmMessage.Size = New System.Drawing.Size(320, 29)
        Me.lblconfirmMessage.TabIndex = 3
        Me.lblconfirmMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AccType
        '
        Me.AccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccType.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccType.FormattingEnabled = True
        Me.AccType.Items.AddRange(New Object() {"مدير", "مستخدم"})
        Me.AccType.Location = New System.Drawing.Point(120, 282)
        Me.AccType.Name = "AccType"
        Me.AccType.Size = New System.Drawing.Size(322, 30)
        Me.AccType.TabIndex = 3
        '
        'btnDeleteImage
        '
        Me.btnDeleteImage.Location = New System.Drawing.Point(538, 244)
        Me.btnDeleteImage.Name = "btnDeleteImage"
        Me.btnDeleteImage.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteImage.TabIndex = 26
        Me.btnDeleteImage.Text = "حذف الصورة"
        Me.btnDeleteImage.UseVisualStyleBackColor = True
        '
        'btnChooseImage
        '
        Me.btnChooseImage.Location = New System.Drawing.Point(460, 244)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(75, 23)
        Me.btnChooseImage.TabIndex = 5
        Me.btnChooseImage.Text = "اختر صورة"
        Me.btnChooseImage.UseVisualStyleBackColor = True
        '
        'UserImage
        '
        Me.UserImage.BackgroundImage = Global.Electronic_Archives_System.My.Resources.Resources.Actions_list_add_user_icon__1_
        Me.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UserImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserImage.Location = New System.Drawing.Point(460, 88)
        Me.UserImage.Name = "UserImage"
        Me.UserImage.Size = New System.Drawing.Size(153, 150)
        Me.UserImage.TabIndex = 25
        Me.UserImage.TabStop = False
        '
        'AccActivate
        '
        Me.AccActivate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccActivate.Location = New System.Drawing.Point(177, 334)
        Me.AccActivate.Name = "AccActivate"
        Me.AccActivate.Size = New System.Drawing.Size(166, 24)
        Me.AccActivate.TabIndex = 4
        Me.AccActivate.Text = "تفعيل الحساب"
        Me.AccActivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AccActivate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(118, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(324, 29)
        Me.Label6.TabIndex = 24
        '
        'PicMessage
        '
        Me.PicMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.PicMessage.Location = New System.Drawing.Point(583, 0)
        Me.PicMessage.Name = "PicMessage"
        Me.PicMessage.Size = New System.Drawing.Size(32, 29)
        Me.PicMessage.TabIndex = 3
        Me.PicMessage.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "نوع الحساب"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "كلمة المرور"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 37)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "اسم المستخدم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "اسم الحساب"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "رقم الحساب"
        '
        'UserName
        '
        Me.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.Location = New System.Drawing.Point(118, 190)
        Me.UserName.MaxLength = 40
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(324, 29)
        Me.UserName.TabIndex = 1
        '
        'UserAccountName
        '
        Me.UserAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserAccountName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserAccountName.Location = New System.Drawing.Point(118, 143)
        Me.UserAccountName.MaxLength = 80
        Me.UserAccountName.Name = "UserAccountName"
        Me.UserAccountName.Size = New System.Drawing.Size(324, 29)
        Me.UserAccountName.TabIndex = 0
        '
        'UserAccID
        '
        Me.UserAccID.BackColor = System.Drawing.Color.Honeydew
        Me.UserAccID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserAccID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserAccID.Location = New System.Drawing.Point(118, 95)
        Me.UserAccID.Name = "UserAccID"
        Me.UserAccID.ReadOnly = True
        Me.UserAccID.Size = New System.Drawing.Size(324, 29)
        Me.UserAccID.TabIndex = 16
        Me.UserAccID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblconfirmMessage)
        Me.Panel3.Controls.Add(Me.PicMessage)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 379)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(617, 31)
        Me.Panel3.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 43)
        Me.Panel1.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnhelp, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(617, 43)
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
        Me.ToolStripLabel1.Text = "حسابات المستخدمين"
        '
        'btnLast
        '
        Me.btnLast.AutoSize = False
        Me.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLast.Image = Global.Electronic_Archives_System.My.Resources.Resources.Last_16x16
        Me.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(35, 35)
        Me.btnLast.Text = "السجل الاخير"
        '
        'btnNew
        '
        Me.btnNew.AutoSize = False
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = Global.Electronic_Archives_System.My.Resources.Resources.Add_16x16
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(35, 35)
        Me.btnNew.Text = "جديد"
        '
        'btnPreviouse
        '
        Me.btnPreviouse.AutoSize = False
        Me.btnPreviouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPreviouse.Image = Global.Electronic_Archives_System.My.Resources.Resources.Prev_16x16
        Me.btnPreviouse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreviouse.Name = "btnPreviouse"
        Me.btnPreviouse.Size = New System.Drawing.Size(35, 35)
        Me.btnPreviouse.Text = "السجل السابق"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.ToolStripSeparator1, Me.btnSave, Me.ToolStripSeparator2, Me.btnEdit, Me.ToolStripSeparator3, Me.btnDelete, Me.ToolStripSeparator4, Me.btnClose, Me.ToolStripSeparator5, Me.btnFirst, Me.btnNext, Me.txtNevigate, Me.btnPreviouse, Me.btnLast, Me.ToolStripSeparator6})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(615, 37)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = False
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = Global.Electronic_Archives_System.My.Resources.Resources.Save_16x16__4_
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(35, 35)
        Me.btnSave.Text = "حفظ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = False
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.Image = Global.Electronic_Archives_System.My.Resources.Resources.EditContact_16x16__2_
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(35, 35)
        Me.btnEdit.Text = "تعديل"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = False
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = Global.Electronic_Archives_System.My.Resources.Resources.Delete_16x16
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(35, 35)
        Me.btnDelete.Text = "حذف"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'btnClose
        '
        Me.btnClose.AutoSize = False
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Image = Global.Electronic_Archives_System.My.Resources.Resources.exitallb
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.Text = "إغلاق"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 37)
        '
        'btnFirst
        '
        Me.btnFirst.AutoSize = False
        Me.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFirst.Image = Global.Electronic_Archives_System.My.Resources.Resources.First_16x16
        Me.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(35, 35)
        Me.btnFirst.Text = "السجل الاول"
        '
        'btnNext
        '
        Me.btnNext.AutoSize = False
        Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNext.Image = Global.Electronic_Archives_System.My.Resources.Resources.Next_16x16
        Me.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(35, 35)
        Me.btnNext.Text = "السجل التالي"
        '
        'txtNevigate
        '
        Me.txtNevigate.Name = "txtNevigate"
        Me.txtNevigate.Size = New System.Drawing.Size(140, 37)
        Me.txtNevigate.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ToolStrip2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(617, 39)
        Me.Panel2.TabIndex = 11
        '
        'UserPassword
        '
        Me.UserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserPassword.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPassword.Location = New System.Drawing.Point(118, 235)
        Me.UserPassword.MaxLength = 30
        Me.UserPassword.Name = "UserPassword"
        Me.UserPassword.Size = New System.Drawing.Size(324, 29)
        Me.UserPassword.TabIndex = 2
        Me.UserPassword.UseSystemPasswordChar = True
        '
        'ck_ShowPasword
        '
        Me.ck_ShowPasword.BackColor = System.Drawing.Color.White
        Me.ck_ShowPasword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_ShowPasword.Location = New System.Drawing.Point(378, 237)
        Me.ck_ShowPasword.Name = "ck_ShowPasword"
        Me.ck_ShowPasword.Size = New System.Drawing.Size(61, 24)
        Me.ck_ShowPasword.TabIndex = 22
        Me.ck_ShowPasword.Text = "إظهار"
        Me.ck_ShowPasword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ck_ShowPasword.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'FrmUserAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(617, 410)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.AccType)
        Me.Controls.Add(Me.btnDeleteImage)
        Me.Controls.Add(Me.btnChooseImage)
        Me.Controls.Add(Me.UserImage)
        Me.Controls.Add(Me.ck_ShowPasword)
        Me.Controls.Add(Me.AccActivate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserPassword)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.UserAccountName)
        Me.Controls.Add(Me.UserAccID)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmUserAccounts"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حسابات المستخدمين"
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblconfirmMessage As System.Windows.Forms.Label
    Friend WithEvents AccType As System.Windows.Forms.ComboBox
    Friend WithEvents btnDeleteImage As System.Windows.Forms.Button
    Friend WithEvents btnChooseImage As System.Windows.Forms.Button
    Friend WithEvents UserImage As System.Windows.Forms.PictureBox
    Friend WithEvents AccActivate As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PicMessage As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents UserAccountName As System.Windows.Forms.TextBox
    Friend WithEvents UserAccID As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnhelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPreviouse As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNevigate As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UserPassword As System.Windows.Forms.TextBox
    Friend WithEvents ck_ShowPasword As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
