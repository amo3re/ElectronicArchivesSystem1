<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatabase1
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnhelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblConfirmMsg = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CombBackupDB = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbToNew = New System.Windows.Forms.RadioButton()
        Me.rbToExisting = New System.Windows.Forms.RadioButton()
        Me.ckOverwrite = New System.Windows.Forms.CheckBox()
        Me.ckAppendTo = New System.Windows.Forms.CheckBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CombRestoreDB = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbNORECOVERY = New System.Windows.Forms.RadioButton()
        Me.rbRECOVERY = New System.Windows.Forms.RadioButton()
        Me.ckWithReplace = New System.Windows.Forms.CheckBox()
        Me.ckTransLog = New System.Windows.Forms.CheckBox()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGetPath2 = New System.Windows.Forms.Button()
        Me.txtRestorePath = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CombBackupType = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGetPath3 = New System.Windows.Forms.Button()
        Me.txtMainBackupPath = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumOfHours = New System.Windows.Forms.NumericUpDown()
        Me.rbPerHours = New System.Windows.Forms.RadioButton()
        Me.rbAtClose = New System.Windows.Forms.RadioButton()
        Me.rbStop = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PicMessage = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumOfHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 43)
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
        Me.ToolStrip1.Size = New System.Drawing.Size(561, 43)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnhelp
        '
        Me.btnhelp.AutoSize = False
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(35, 35)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Sakkal Majalla", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(490, 40)
        Me.ToolStripLabel1.Text = "النسخ الاحتياطي لقواعد البيانات"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblConfirmMsg)
        Me.Panel3.Controls.Add(Me.PicMessage)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 343)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 31)
        Me.Panel3.TabIndex = 3
        '
        'lblConfirmMsg
        '
        Me.lblConfirmMsg.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblConfirmMsg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmMsg.ForeColor = System.Drawing.SystemColors.Window
        Me.lblConfirmMsg.Location = New System.Drawing.Point(3, 0)
        Me.lblConfirmMsg.Name = "lblConfirmMsg"
        Me.lblConfirmMsg.Size = New System.Drawing.Size(524, 29)
        Me.lblConfirmMsg.TabIndex = 15
        Me.lblConfirmMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(561, 300)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.btnBackup)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(553, 262)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "النسخ الاحتياطي"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.CombBackupDB)
        Me.Panel5.Location = New System.Drawing.Point(10, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(529, 40)
        Me.Panel5.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(374, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "اسم قاعده البيانات"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombBackupDB
        '
        Me.CombBackupDB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CombBackupDB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CombBackupDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CombBackupDB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombBackupDB.FormattingEnabled = True
        Me.CombBackupDB.Location = New System.Drawing.Point(47, 7)
        Me.CombBackupDB.Name = "CombBackupDB"
        Me.CombBackupDB.Size = New System.Drawing.Size(324, 26)
        Me.CombBackupDB.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CombBackupDB, "اختر قاعدة البيانات")
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbToNew)
        Me.GroupBox6.Controls.Add(Me.rbToExisting)
        Me.GroupBox6.Controls.Add(Me.ckOverwrite)
        Me.GroupBox6.Controls.Add(Me.ckAppendTo)
        Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(7, 59)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(537, 156)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "خيارات النسخ الاحتياطي"
        '
        'rbToNew
        '
        Me.rbToNew.AutoSize = True
        Me.rbToNew.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbToNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbToNew.Location = New System.Drawing.Point(55, 122)
        Me.rbToNew.Name = "rbToNew"
        Me.rbToNew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rbToNew.Size = New System.Drawing.Size(194, 19)
        Me.rbToNew.TabIndex = 11
        Me.rbToNew.Text = "Back up To New Media Set"
        Me.rbToNew.UseVisualStyleBackColor = True
        '
        'rbToExisting
        '
        Me.rbToExisting.AutoSize = True
        Me.rbToExisting.Checked = True
        Me.rbToExisting.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbToExisting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbToExisting.Location = New System.Drawing.Point(55, 22)
        Me.rbToExisting.Name = "rbToExisting"
        Me.rbToExisting.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rbToExisting.Size = New System.Drawing.Size(217, 19)
        Me.rbToExisting.TabIndex = 11
        Me.rbToExisting.TabStop = True
        Me.rbToExisting.Text = "Back up To Existing Media Set"
        Me.rbToExisting.UseVisualStyleBackColor = True
        '
        'ckOverwrite
        '
        Me.ckOverwrite.AutoSize = True
        Me.ckOverwrite.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckOverwrite.Location = New System.Drawing.Point(96, 87)
        Me.ckOverwrite.Name = "ckOverwrite"
        Me.ckOverwrite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ckOverwrite.Size = New System.Drawing.Size(252, 19)
        Me.ckOverwrite.TabIndex = 10
        Me.ckOverwrite.Text = "Overwrite All Existing Back up Sets"
        Me.ckOverwrite.UseVisualStyleBackColor = True
        '
        'ckAppendTo
        '
        Me.ckAppendTo.AutoSize = True
        Me.ckAppendTo.Checked = True
        Me.ckAppendTo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckAppendTo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAppendTo.Location = New System.Drawing.Point(96, 54)
        Me.ckAppendTo.Name = "ckAppendTo"
        Me.ckAppendTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ckAppendTo.Size = New System.Drawing.Size(228, 19)
        Me.ckAppendTo.TabIndex = 10
        Me.ckAppendTo.Text = "Append To Existing Back up Set"
        Me.ToolTip1.SetToolTip(Me.ckAppendTo, "overwrite an existing database")
        Me.ckAppendTo.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(55, 223)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(137, 33)
        Me.btnBackup.TabIndex = 1
        Me.btnBackup.Text = "نسخ احتياطي"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.ckTransLog)
        Me.TabPage2.Controls.Add(Me.btnRestore)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(553, 262)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "إسترجاع النسخ الاحتياطيه"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.CombRestoreDB)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(10, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(529, 40)
        Me.Panel4.TabIndex = 12
        '
        'CombRestoreDB
        '
        Me.CombRestoreDB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CombRestoreDB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CombRestoreDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CombRestoreDB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombRestoreDB.FormattingEnabled = True
        Me.CombRestoreDB.Location = New System.Drawing.Point(47, 7)
        Me.CombRestoreDB.Name = "CombRestoreDB"
        Me.CombRestoreDB.Size = New System.Drawing.Size(324, 26)
        Me.CombRestoreDB.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.CombRestoreDB, "اختر قاعدة البيانات")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(375, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "اسم قاعده البيانات"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbNORECOVERY)
        Me.GroupBox4.Controls.Add(Me.rbRECOVERY)
        Me.GroupBox4.Controls.Add(Me.ckWithReplace)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(7, 59)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(537, 80)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "خيارات استرجاع النسخه الاحتياطيه"
        '
        'rbNORECOVERY
        '
        Me.rbNORECOVERY.AutoSize = True
        Me.rbNORECOVERY.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNORECOVERY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbNORECOVERY.Location = New System.Drawing.Point(261, 51)
        Me.rbNORECOVERY.Name = "rbNORECOVERY"
        Me.rbNORECOVERY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rbNORECOVERY.Size = New System.Drawing.Size(197, 19)
        Me.rbNORECOVERY.TabIndex = 11
        Me.rbNORECOVERY.Text = "Restore WITH NORecovery"
        Me.rbNORECOVERY.UseVisualStyleBackColor = True
        '
        'rbRECOVERY
        '
        Me.rbRECOVERY.AutoSize = True
        Me.rbRECOVERY.Checked = True
        Me.rbRECOVERY.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRECOVERY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbRECOVERY.Location = New System.Drawing.Point(49, 52)
        Me.rbRECOVERY.Name = "rbRECOVERY"
        Me.rbRECOVERY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rbRECOVERY.Size = New System.Drawing.Size(177, 19)
        Me.rbRECOVERY.TabIndex = 11
        Me.rbRECOVERY.TabStop = True
        Me.rbRECOVERY.Text = "Restore WITH Recovery"
        Me.rbRECOVERY.UseVisualStyleBackColor = True
        '
        'ckWithReplace
        '
        Me.ckWithReplace.AutoSize = True
        Me.ckWithReplace.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckWithReplace.Location = New System.Drawing.Point(50, 23)
        Me.ckWithReplace.Name = "ckWithReplace"
        Me.ckWithReplace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ckWithReplace.Size = New System.Drawing.Size(116, 19)
        Me.ckWithReplace.TabIndex = 10
        Me.ckWithReplace.Text = "WITH Replace"
        Me.ToolTip1.SetToolTip(Me.ckWithReplace, "overwrite an existing database")
        Me.ckWithReplace.UseVisualStyleBackColor = True
        '
        'ckTransLog
        '
        Me.ckTransLog.AutoSize = True
        Me.ckTransLog.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckTransLog.Enabled = False
        Me.ckTransLog.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckTransLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckTransLog.Location = New System.Drawing.Point(401, 234)
        Me.ckTransLog.Name = "ckTransLog"
        Me.ckTransLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ckTransLog.Size = New System.Drawing.Size(142, 19)
        Me.ckTransLog.TabIndex = 10
        Me.ckTransLog.Text = " Transaction Log.."
        Me.ckTransLog.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(55, 225)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(137, 33)
        Me.btnRestore.TabIndex = 2
        Me.btnRestore.Text = "إسترجاع النسخه"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnGetPath2)
        Me.GroupBox3.Controls.Add(Me.txtRestorePath)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 149)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(538, 72)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " مسار النسخه الاحتياطيه"
        '
        'btnGetPath2
        '
        Me.btnGetPath2.FlatAppearance.BorderSize = 0
        Me.btnGetPath2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnGetPath2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetPath2.Image = Global.Electronic_Archives_System.My.Resources.Resources.Open2_16x16
        Me.btnGetPath2.Location = New System.Drawing.Point(6, 23)
        Me.btnGetPath2.Name = "btnGetPath2"
        Me.btnGetPath2.Size = New System.Drawing.Size(46, 43)
        Me.btnGetPath2.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnGetPath2, "اختر مسار النسخ الاحتياطيه")
        Me.btnGetPath2.UseVisualStyleBackColor = True
        '
        'txtRestorePath
        '
        Me.txtRestorePath.BackColor = System.Drawing.Color.Honeydew
        Me.txtRestorePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRestorePath.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestorePath.Location = New System.Drawing.Point(52, 23)
        Me.txtRestorePath.Multiline = True
        Me.txtRestorePath.Name = "txtRestorePath"
        Me.txtRestorePath.ReadOnly = True
        Me.txtRestorePath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRestorePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRestorePath.Size = New System.Drawing.Size(471, 43)
        Me.txtRestorePath.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(553, 262)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "إعدادات النسخ الاحتياطي"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.CombBackupType)
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(529, 40)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(361, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "نوع النسخ الاحتياطي"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombBackupType
        '
        Me.CombBackupType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CombBackupType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CombBackupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombBackupType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CombBackupType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombBackupType.FormattingEnabled = True
        Me.CombBackupType.Items.AddRange(New Object() {"Full Backup", "Differential Backup", "Transaction Log Backup"})
        Me.CombBackupType.Location = New System.Drawing.Point(52, 6)
        Me.CombBackupType.Name = "CombBackupType"
        Me.CombBackupType.Size = New System.Drawing.Size(305, 26)
        Me.CombBackupType.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGetPath3)
        Me.GroupBox1.Controls.Add(Me.txtMainBackupPath)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مسار النسخ الاحتياطيه"
        '
        'btnGetPath3
        '
        Me.btnGetPath3.FlatAppearance.BorderSize = 0
        Me.btnGetPath3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnGetPath3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetPath3.Image = Global.Electronic_Archives_System.My.Resources.Resources.Open2_16x16
        Me.btnGetPath3.Location = New System.Drawing.Point(8, 26)
        Me.btnGetPath3.Name = "btnGetPath3"
        Me.btnGetPath3.Size = New System.Drawing.Size(41, 26)
        Me.btnGetPath3.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnGetPath3, "اختر مسار النسخ الاحتياطي")
        Me.btnGetPath3.UseVisualStyleBackColor = True
        '
        'txtMainBackupPath
        '
        Me.txtMainBackupPath.BackColor = System.Drawing.Color.Honeydew
        Me.txtMainBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMainBackupPath.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMainBackupPath.Location = New System.Drawing.Point(53, 26)
        Me.txtMainBackupPath.Name = "txtMainBackupPath"
        Me.txtMainBackupPath.ReadOnly = True
        Me.txtMainBackupPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMainBackupPath.Size = New System.Drawing.Size(463, 26)
        Me.txtMainBackupPath.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.NumOfHours)
        Me.GroupBox2.Controls.Add(Me.rbPerHours)
        Me.GroupBox2.Controls.Add(Me.rbAtClose)
        Me.GroupBox2.Controls.Add(Me.rbStop)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(529, 136)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "النسخ التلقائي"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Electronic_Archives_System.My.Resources.Resources.Save_16x16__4_
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(7, 97)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 33)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ساعة"
        '
        'NumOfHours
        '
        Me.NumOfHours.Enabled = False
        Me.NumOfHours.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumOfHours.Location = New System.Drawing.Point(201, 98)
        Me.NumOfHours.Name = "NumOfHours"
        Me.NumOfHours.Size = New System.Drawing.Size(59, 26)
        Me.NumOfHours.TabIndex = 1
        Me.NumOfHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbPerHours
        '
        Me.rbPerHours.AutoSize = True
        Me.rbPerHours.Location = New System.Drawing.Point(261, 100)
        Me.rbPerHours.Name = "rbPerHours"
        Me.rbPerHours.Size = New System.Drawing.Size(242, 20)
        Me.rbPerHours.TabIndex = 0
        Me.rbPerHours.Text = "النسخ الاحتياطي لقاعدة البيانات كل"
        Me.rbPerHours.UseVisualStyleBackColor = True
        '
        'rbAtClose
        '
        Me.rbAtClose.AutoSize = True
        Me.rbAtClose.Location = New System.Drawing.Point(168, 65)
        Me.rbAtClose.Name = "rbAtClose"
        Me.rbAtClose.Size = New System.Drawing.Size(334, 20)
        Me.rbAtClose.TabIndex = 0
        Me.rbAtClose.Text = "النسخ الاحتياطي لقاعدة البيانات عند إغلاق البرنامج"
        Me.rbAtClose.UseVisualStyleBackColor = True
        '
        'rbStop
        '
        Me.rbStop.AutoSize = True
        Me.rbStop.Checked = True
        Me.rbStop.Location = New System.Drawing.Point(351, 34)
        Me.rbStop.Name = "rbStop"
        Me.rbStop.Size = New System.Drawing.Size(152, 20)
        Me.rbStop.TabIndex = 0
        Me.rbStop.TabStop = True
        Me.rbStop.Text = "إيقاف النسخ التلقائي"
        Me.rbStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'PicMessage
        '
        Me.PicMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.PicMessage.Location = New System.Drawing.Point(527, 0)
        Me.PicMessage.Name = "PicMessage"
        Me.PicMessage.Size = New System.Drawing.Size(32, 29)
        Me.PicMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicMessage.TabIndex = 3
        Me.PicMessage.TabStop = False
        '
        'FrmDatabase1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(561, 374)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDatabase1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "النسخ الاحتياطي لقواعد البيانات"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumOfHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnhelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PicMessage As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumOfHours As System.Windows.Forms.NumericUpDown
    Friend WithEvents rbPerHours As System.Windows.Forms.RadioButton
    Friend WithEvents rbAtClose As System.Windows.Forms.RadioButton
    Friend WithEvents rbStop As System.Windows.Forms.RadioButton
    Friend WithEvents btnGetPath3 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtMainBackupPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetPath2 As System.Windows.Forms.Button
    Friend WithEvents txtRestorePath As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CombBackupDB As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CombBackupType As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CombRestoreDB As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNORECOVERY As System.Windows.Forms.RadioButton
    Friend WithEvents rbRECOVERY As System.Windows.Forms.RadioButton
    Friend WithEvents ckWithReplace As System.Windows.Forms.CheckBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblConfirmMsg As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbToNew As System.Windows.Forms.RadioButton
    Friend WithEvents rbToExisting As System.Windows.Forms.RadioButton
    Friend WithEvents ckAppendTo As System.Windows.Forms.CheckBox
    Friend WithEvents ckOverwrite As System.Windows.Forms.CheckBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckTransLog As System.Windows.Forms.CheckBox
End Class
