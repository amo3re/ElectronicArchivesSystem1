<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserRoles
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnhelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblconfirmMessage = New System.Windows.Forms.Label()
        Me.PicMessage = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CkBackupForm = New System.Windows.Forms.CheckBox()
        Me.CkServerSettingForm = New System.Windows.Forms.CheckBox()
        Me.CkRestoreButton = New System.Windows.Forms.CheckBox()
        Me.CkBackSettingSave = New System.Windows.Forms.CheckBox()
        Me.CkBackupButton = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CkRecycleBin = New System.Windows.Forms.CheckBox()
        Me.CkFileSend = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CkFolderDelete = New System.Windows.Forms.CheckBox()
        Me.CkFileBrowse = New System.Windows.Forms.CheckBox()
        Me.CkFileScan = New System.Windows.Forms.CheckBox()
        Me.CkFileDelete = New System.Windows.Forms.CheckBox()
        Me.CkFileUpdate = New System.Windows.Forms.CheckBox()
        Me.CkFolderUpdate = New System.Windows.Forms.CheckBox()
        Me.CkFileSave = New System.Windows.Forms.CheckBox()
        Me.CkFolderSave = New System.Windows.Forms.CheckBox()
        Me.CkAddFileForm = New System.Windows.Forms.CheckBox()
        Me.CkAddFolderForm = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CkUserAccDelete = New System.Windows.Forms.CheckBox()
        Me.CkUserRoleDelete = New System.Windows.Forms.CheckBox()
        Me.CkUserAccUpdate = New System.Windows.Forms.CheckBox()
        Me.CkUserRoleSave = New System.Windows.Forms.CheckBox()
        Me.CkUserAccSave = New System.Windows.Forms.CheckBox()
        Me.CkUserRoleForm = New System.Windows.Forms.CheckBox()
        Me.CkUserAccForm = New System.Windows.Forms.CheckBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PicMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 43)
        Me.Panel1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnhelp, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(990, 43)
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(900, 40)
        Me.ToolStripLabel1.Text = "صلاحيات المستخدمين"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblconfirmMessage)
        Me.Panel3.Controls.Add(Me.PicMessage)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 537)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(990, 31)
        Me.Panel3.TabIndex = 3
        '
        'lblconfirmMessage
        '
        Me.lblconfirmMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblconfirmMessage.Location = New System.Drawing.Point(636, 0)
        Me.lblconfirmMessage.Name = "lblconfirmMessage"
        Me.lblconfirmMessage.Size = New System.Drawing.Size(320, 29)
        Me.lblconfirmMessage.TabIndex = 3
        Me.lblconfirmMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicMessage
        '
        Me.PicMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.PicMessage.Location = New System.Drawing.Point(956, 0)
        Me.PicMessage.Name = "PicMessage"
        Me.PicMessage.Size = New System.Drawing.Size(32, 29)
        Me.PicMessage.TabIndex = 3
        Me.PicMessage.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 43)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(990, 494)
        Me.SplitContainer1.SplitterDistance = 274
        Me.SplitContainer1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(272, 492)
        Me.Panel2.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(272, 402)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "رقم المستخدم"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "اسم المستخدم"
        Me.Column2.Name = "Column2"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnCancel)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 446)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(272, 46)
        Me.Panel5.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Electronic_Archives_System.My.Resources.Resources.Delete_16x16
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(34, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 32)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "إلغاء"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.Electronic_Archives_System.My.Resources.Resources.Save_16x16__4_
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(145, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(272, 44)
        Me.Panel4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.AliceBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Sakkal Majalla", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = Global.Electronic_Archives_System.My.Resources.Resources.reseller_programm
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "حسابات المستخدمين"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox4)
        Me.Panel6.Controls.Add(Me.GroupBox3)
        Me.Panel6.Controls.Add(Me.GroupBox2)
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(710, 492)
        Me.Panel6.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CkBackupForm)
        Me.GroupBox4.Controls.Add(Me.CkServerSettingForm)
        Me.GroupBox4.Controls.Add(Me.CkRestoreButton)
        Me.GroupBox4.Controls.Add(Me.CkBackSettingSave)
        Me.GroupBox4.Controls.Add(Me.CkBackupButton)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(54, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(232, 216)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "قواعد البيانات"
        '
        'CkBackupForm
        '
        Me.CkBackupForm.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkBackupForm.ForeColor = System.Drawing.Color.Red
        Me.CkBackupForm.Location = New System.Drawing.Point(53, 70)
        Me.CkBackupForm.Name = "CkBackupForm"
        Me.CkBackupForm.Size = New System.Drawing.Size(167, 29)
        Me.CkBackupForm.TabIndex = 0
        Me.CkBackupForm.Text = "النسخ الاحتياطي"
        Me.CkBackupForm.UseVisualStyleBackColor = True
        '
        'CkServerSettingForm
        '
        Me.CkServerSettingForm.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkServerSettingForm.ForeColor = System.Drawing.Color.Red
        Me.CkServerSettingForm.Location = New System.Drawing.Point(16, 25)
        Me.CkServerSettingForm.Name = "CkServerSettingForm"
        Me.CkServerSettingForm.Size = New System.Drawing.Size(204, 29)
        Me.CkServerSettingForm.TabIndex = 0
        Me.CkServerSettingForm.Text = "إعدادات الاتصال السيرفر"
        Me.CkServerSettingForm.UseVisualStyleBackColor = True
        '
        'CkRestoreButton
        '
        Me.CkRestoreButton.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkRestoreButton.ForeColor = System.Drawing.Color.Blue
        Me.CkRestoreButton.Location = New System.Drawing.Point(53, 140)
        Me.CkRestoreButton.Name = "CkRestoreButton"
        Me.CkRestoreButton.Size = New System.Drawing.Size(136, 29)
        Me.CkRestoreButton.TabIndex = 0
        Me.CkRestoreButton.Text = "إسترجاع نسخة"
        Me.CkRestoreButton.UseVisualStyleBackColor = True
        '
        'CkBackSettingSave
        '
        Me.CkBackSettingSave.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkBackSettingSave.ForeColor = System.Drawing.Color.Blue
        Me.CkBackSettingSave.Location = New System.Drawing.Point(53, 175)
        Me.CkBackSettingSave.Name = "CkBackSettingSave"
        Me.CkBackSettingSave.Size = New System.Drawing.Size(136, 29)
        Me.CkBackSettingSave.TabIndex = 0
        Me.CkBackSettingSave.Text = "حفظ الاعدادات"
        Me.CkBackSettingSave.UseVisualStyleBackColor = True
        '
        'CkBackupButton
        '
        Me.CkBackupButton.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkBackupButton.ForeColor = System.Drawing.Color.Blue
        Me.CkBackupButton.Location = New System.Drawing.Point(69, 106)
        Me.CkBackupButton.Name = "CkBackupButton"
        Me.CkBackupButton.Size = New System.Drawing.Size(120, 29)
        Me.CkBackupButton.TabIndex = 0
        Me.CkBackupButton.Text = "نسخ احتياطي"
        Me.CkBackupButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CkRecycleBin)
        Me.GroupBox3.Controls.Add(Me.CkFileSend)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(54, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 138)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "الإرشيف"
        '
        'CkRecycleBin
        '
        Me.CkRecycleBin.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkRecycleBin.ForeColor = System.Drawing.Color.Red
        Me.CkRecycleBin.Location = New System.Drawing.Point(51, 77)
        Me.CkRecycleBin.Name = "CkRecycleBin"
        Me.CkRecycleBin.Size = New System.Drawing.Size(167, 29)
        Me.CkRecycleBin.TabIndex = 0
        Me.CkRecycleBin.Text = "سلة المحذوفات"
        Me.CkRecycleBin.UseVisualStyleBackColor = True
        '
        'CkFileSend
        '
        Me.CkFileSend.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkFileSend.ForeColor = System.Drawing.Color.Red
        Me.CkFileSend.Location = New System.Drawing.Point(51, 25)
        Me.CkFileSend.Name = "CkFileSend"
        Me.CkFileSend.Size = New System.Drawing.Size(167, 29)
        Me.CkFileSend.TabIndex = 0
        Me.CkFileSend.Text = "إرسال بريد الكتروني"
        Me.CkFileSend.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CkFolderDelete)
        Me.GroupBox2.Controls.Add(Me.CkFileBrowse)
        Me.GroupBox2.Controls.Add(Me.CkFileScan)
        Me.GroupBox2.Controls.Add(Me.CkFileDelete)
        Me.GroupBox2.Controls.Add(Me.CkFileUpdate)
        Me.GroupBox2.Controls.Add(Me.CkFolderUpdate)
        Me.GroupBox2.Controls.Add(Me.CkFileSave)
        Me.GroupBox2.Controls.Add(Me.CkFolderSave)
        Me.GroupBox2.Controls.Add(Me.CkAddFileForm)
        Me.GroupBox2.Controls.Add(Me.CkAddFolderForm)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(292, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 360)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الإرشيف"
        '
        'CkFolderDelete
        '
        Me.CkFolderDelete.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkFolderDelete.ForeColor = System.Drawing.Color.Blue
        Me.CkFolderDelete.Location = New System.Drawing.Point(90, 130)
        Me.CkFolderDelete.Name = "CkFolderDelete"
        Me.CkFolderDelete.Size = New System.Drawing.Size(80, 29)
        Me.CkFolderDelete.TabIndex = 0
        Me.CkFolderDelete.Text = "حذف"
        Me.CkFolderDelete.UseVisualStyleBackColor = True
        '
        'CkFileBrowse
        '
        Me.CkFileBrowse.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkFileBrowse.ForeColor = System.Drawing.Color.Blue
        Me.CkFileBrowse.Location = New System.Drawing.Point(28, 327)
        Me.CkFileBrowse.Name = "CkFileBrowse"
        Me.CkFileBrowse.Size = New System.Drawing.Size(143, 29)
        Me.CkFileBrowse.TabIndex = 0
        Me.CkFileBrowse.Text = "استعراض الملفات"
        Me.CkFileBrowse.UseVisualStyleBackColor = True
        '
        'CkFileScan
        '
        Me.CkFileScan.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkFileScan.ForeColor = System.Drawing.Color.Blue
        Me.CkFileScan.Location = New System.Drawing.Point(57, 295)
        Me.CkFileScan.Name = "CkFileScan"
        Me.CkFileScan.Size = New System.Drawing.Size(113, 29)
        Me.CkFileScan.TabIndex = 0
        Me.CkFileScan.Text = "مسح ضوئي"
        Me.CkFileScan.UseVisualStyleBackColor = True
        '
        'CkFileDelete
        '
        Me.CkFileDelete.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkFileDelete.ForeColor = System.Drawing.Color.Blue
        Me.CkFileDelete.Location = New System.Drawing.Point(90, 260)
        Me.CkFileDelete.Name = "CkFileDelete"
        Me.CkFileDelete.Size = New System.Drawing.Size(80, 29)
        Me.CkFileDelete.TabIndex = 0
        Me.CkFileDelete.Text = "حذف"
        Me.CkFileDelete.UseVisualStyleBackColor = True
        '
        'CkFileUpdate
        '
        Me.CkFileUpdate.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkFileUpdate.ForeColor = System.Drawing.Color.Blue
        Me.CkFileUpdate.Location = New System.Drawing.Point(90, 225)
        Me.CkFileUpdate.Name = "CkFileUpdate"
        Me.CkFileUpdate.Size = New System.Drawing.Size(80, 29)
        Me.CkFileUpdate.TabIndex = 0
        Me.CkFileUpdate.Text = "تعديل"
        Me.CkFileUpdate.UseVisualStyleBackColor = True
        '
        'CkFolderUpdate
        '
        Me.CkFolderUpdate.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkFolderUpdate.ForeColor = System.Drawing.Color.Blue
        Me.CkFolderUpdate.Location = New System.Drawing.Point(90, 94)
        Me.CkFolderUpdate.Name = "CkFolderUpdate"
        Me.CkFolderUpdate.Size = New System.Drawing.Size(80, 29)
        Me.CkFolderUpdate.TabIndex = 0
        Me.CkFolderUpdate.Text = "تعديل"
        Me.CkFolderUpdate.UseVisualStyleBackColor = True
        '
        'CkFileSave
        '
        Me.CkFileSave.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkFileSave.ForeColor = System.Drawing.Color.Blue
        Me.CkFileSave.Location = New System.Drawing.Point(90, 191)
        Me.CkFileSave.Name = "CkFileSave"
        Me.CkFileSave.Size = New System.Drawing.Size(80, 29)
        Me.CkFileSave.TabIndex = 0
        Me.CkFileSave.Text = "حفظ"
        Me.CkFileSave.UseVisualStyleBackColor = True
        '
        'CkFolderSave
        '
        Me.CkFolderSave.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkFolderSave.ForeColor = System.Drawing.Color.Blue
        Me.CkFolderSave.Location = New System.Drawing.Point(90, 60)
        Me.CkFolderSave.Name = "CkFolderSave"
        Me.CkFolderSave.Size = New System.Drawing.Size(80, 29)
        Me.CkFolderSave.TabIndex = 0
        Me.CkFolderSave.Text = "حفظ"
        Me.CkFolderSave.UseVisualStyleBackColor = True
        '
        'CkAddFileForm
        '
        Me.CkAddFileForm.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkAddFileForm.ForeColor = System.Drawing.Color.Red
        Me.CkAddFileForm.Location = New System.Drawing.Point(6, 161)
        Me.CkAddFileForm.Name = "CkAddFileForm"
        Me.CkAddFileForm.Size = New System.Drawing.Size(188, 29)
        Me.CkAddFileForm.TabIndex = 0
        Me.CkAddFileForm.Text = "إضافة ملف"
        Me.CkAddFileForm.UseVisualStyleBackColor = True
        '
        'CkAddFolderForm
        '
        Me.CkAddFolderForm.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkAddFolderForm.ForeColor = System.Drawing.Color.Red
        Me.CkAddFolderForm.Location = New System.Drawing.Point(27, 25)
        Me.CkAddFolderForm.Name = "CkAddFolderForm"
        Me.CkAddFolderForm.Size = New System.Drawing.Size(167, 29)
        Me.CkAddFolderForm.TabIndex = 0
        Me.CkAddFolderForm.Text = "إضافة مجلد"
        Me.CkAddFolderForm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CkUserAccDelete)
        Me.GroupBox1.Controls.Add(Me.CkUserRoleDelete)
        Me.GroupBox1.Controls.Add(Me.CkUserAccUpdate)
        Me.GroupBox1.Controls.Add(Me.CkUserRoleSave)
        Me.GroupBox1.Controls.Add(Me.CkUserAccSave)
        Me.GroupBox1.Controls.Add(Me.CkUserRoleForm)
        Me.GroupBox1.Controls.Add(Me.CkUserAccForm)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(503, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 360)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "المستخدمين"
        '
        'CkUserAccDelete
        '
        Me.CkUserAccDelete.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkUserAccDelete.ForeColor = System.Drawing.Color.Blue
        Me.CkUserAccDelete.Location = New System.Drawing.Point(90, 130)
        Me.CkUserAccDelete.Name = "CkUserAccDelete"
        Me.CkUserAccDelete.Size = New System.Drawing.Size(80, 29)
        Me.CkUserAccDelete.TabIndex = 0
        Me.CkUserAccDelete.Text = "حذف"
        Me.CkUserAccDelete.UseVisualStyleBackColor = True
        '
        'CkUserRoleDelete
        '
        Me.CkUserRoleDelete.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkUserRoleDelete.ForeColor = System.Drawing.Color.Blue
        Me.CkUserRoleDelete.Location = New System.Drawing.Point(90, 230)
        Me.CkUserRoleDelete.Name = "CkUserRoleDelete"
        Me.CkUserRoleDelete.Size = New System.Drawing.Size(80, 29)
        Me.CkUserRoleDelete.TabIndex = 0
        Me.CkUserRoleDelete.Text = "إلغاء"
        Me.CkUserRoleDelete.UseVisualStyleBackColor = True
        '
        'CkUserAccUpdate
        '
        Me.CkUserAccUpdate.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkUserAccUpdate.ForeColor = System.Drawing.Color.Blue
        Me.CkUserAccUpdate.Location = New System.Drawing.Point(90, 94)
        Me.CkUserAccUpdate.Name = "CkUserAccUpdate"
        Me.CkUserAccUpdate.Size = New System.Drawing.Size(80, 29)
        Me.CkUserAccUpdate.TabIndex = 0
        Me.CkUserAccUpdate.Text = "تعديل"
        Me.CkUserAccUpdate.UseVisualStyleBackColor = True
        '
        'CkUserRoleSave
        '
        Me.CkUserRoleSave.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkUserRoleSave.ForeColor = System.Drawing.Color.Blue
        Me.CkUserRoleSave.Location = New System.Drawing.Point(90, 196)
        Me.CkUserRoleSave.Name = "CkUserRoleSave"
        Me.CkUserRoleSave.Size = New System.Drawing.Size(80, 29)
        Me.CkUserRoleSave.TabIndex = 0
        Me.CkUserRoleSave.Text = "حفظ"
        Me.CkUserRoleSave.UseVisualStyleBackColor = True
        '
        'CkUserAccSave
        '
        Me.CkUserAccSave.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkUserAccSave.ForeColor = System.Drawing.Color.Blue
        Me.CkUserAccSave.Location = New System.Drawing.Point(90, 60)
        Me.CkUserAccSave.Name = "CkUserAccSave"
        Me.CkUserAccSave.Size = New System.Drawing.Size(80, 29)
        Me.CkUserAccSave.TabIndex = 0
        Me.CkUserAccSave.Text = "حفظ"
        Me.CkUserAccSave.UseVisualStyleBackColor = True
        '
        'CkUserRoleForm
        '
        Me.CkUserRoleForm.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkUserRoleForm.ForeColor = System.Drawing.Color.Red
        Me.CkUserRoleForm.Location = New System.Drawing.Point(6, 161)
        Me.CkUserRoleForm.Name = "CkUserRoleForm"
        Me.CkUserRoleForm.Size = New System.Drawing.Size(188, 29)
        Me.CkUserRoleForm.TabIndex = 0
        Me.CkUserRoleForm.Text = "صلاحيات المستخدمين"
        Me.CkUserRoleForm.UseVisualStyleBackColor = True
        '
        'CkUserAccForm
        '
        Me.CkUserAccForm.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkUserAccForm.ForeColor = System.Drawing.Color.Red
        Me.CkUserAccForm.Location = New System.Drawing.Point(27, 25)
        Me.CkUserAccForm.Name = "CkUserAccForm"
        Me.CkUserAccForm.Size = New System.Drawing.Size(167, 29)
        Me.CkUserAccForm.TabIndex = 0
        Me.CkUserAccForm.Text = "حسابات المستخدمين"
        Me.CkUserAccForm.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.CheckBox2)
        Me.Panel8.Controls.Add(Me.CheckBox1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 44)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(710, 75)
        Me.Panel8.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox2.Location = New System.Drawing.Point(326, 40)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(376, 29)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "تحديد جميع الصلاحيات ماعدا صلاحيات المستخدمين"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Sakkal Majalla", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox1.Location = New System.Drawing.Point(366, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(336, 29)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "تحديد جميع الصلاحيات"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.TextBox2)
        Me.Panel7.Controls.Add(Me.TextBox1)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(710, 44)
        Me.Panel7.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(536, 11)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(54, 25)
        Me.TextBox2.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(200, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(392, 29)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(598, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "اسم المستخدم"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmUserRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(990, 568)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmUserRoles"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "صلاحيات المستخدمين"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PicMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnhelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblconfirmMessage As System.Windows.Forms.Label
    Friend WithEvents PicMessage As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CkFolderDelete As System.Windows.Forms.CheckBox
    Friend WithEvents CkFileUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents CkFolderUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents CkFileSave As System.Windows.Forms.CheckBox
    Friend WithEvents CkFolderSave As System.Windows.Forms.CheckBox
    Friend WithEvents CkAddFileForm As System.Windows.Forms.CheckBox
    Friend WithEvents CkAddFolderForm As System.Windows.Forms.CheckBox
    Friend WithEvents CkUserAccDelete As System.Windows.Forms.CheckBox
    Friend WithEvents CkUserRoleDelete As System.Windows.Forms.CheckBox
    Friend WithEvents CkUserAccUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents CkUserRoleSave As System.Windows.Forms.CheckBox
    Friend WithEvents CkUserAccSave As System.Windows.Forms.CheckBox
    Friend WithEvents CkUserRoleForm As System.Windows.Forms.CheckBox
    Friend WithEvents CkUserAccForm As System.Windows.Forms.CheckBox
    Friend WithEvents CkFileDelete As System.Windows.Forms.CheckBox
    Friend WithEvents CkFileBrowse As System.Windows.Forms.CheckBox
    Friend WithEvents CkFileScan As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CkRecycleBin As System.Windows.Forms.CheckBox
    Friend WithEvents CkFileSend As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CkBackupForm As System.Windows.Forms.CheckBox
    Friend WithEvents CkServerSettingForm As System.Windows.Forms.CheckBox
    Friend WithEvents CkRestoreButton As System.Windows.Forms.CheckBox
    Friend WithEvents CkBackSettingSave As System.Windows.Forms.CheckBox
    Friend WithEvents CkBackupButton As System.Windows.Forms.CheckBox
End Class
