<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainPage))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAddNewFolder = New System.Windows.Forms.ToolStripButton()
        Me.btnAddNewFile = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnExpandAll = New System.Windows.Forms.ToolStripButton()
        Me.btnCollaps = New System.Windows.Forms.ToolStripButton()
        Me.btnSendMail = New System.Windows.Forms.ToolStripButton()
        Me.btnDeletedPin = New System.Windows.Forms.ToolStripButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnAddFolderToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEditFolderToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeleteFolderToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnOpenSelectedFileToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAddFileToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUpdateFileToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDeleteFileToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCopyFileToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExpandToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCollapseToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRefreshToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSendFileToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_Files = New System.Windows.Forms.DataGridView()
        Me.xCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_Side = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddNewUser = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnUserRoles = New System.Windows.Forms.Button()
        Me.P_Tail = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.WebPanel = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.PicPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblImagePath = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.btnRotateRight = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRotateLeft = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.PDFPanel = New System.Windows.Forms.Panel()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.txtPanel = New System.Windows.Forms.Panel()
        Me.txtReader = New System.Windows.Forms.RichTextBox()
        Me.TailPanel = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFolderDeletedPin = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_Files, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_Side.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.P_Tail.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.WebPanel.SuspendLayout()
        Me.PicPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.PDFPanel.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txtPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddNewFolder, Me.btnAddNewFile, Me.btnRefresh, Me.btnExpandAll, Me.btnCollaps, Me.btnSendMail, Me.btnDeletedPin, Me.btnFolderDeletedPin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(374, 38)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAddNewFolder
        '
        Me.btnAddNewFolder.AutoSize = False
        Me.btnAddNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddNewFolder.Image = Global.Electronic_Archives_System.My.Resources.Resources.folder_add
        Me.btnAddNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddNewFolder.Name = "btnAddNewFolder"
        Me.btnAddNewFolder.Size = New System.Drawing.Size(35, 35)
        Me.btnAddNewFolder.Text = "إضافة مجلد "
        '
        'btnAddNewFile
        '
        Me.btnAddNewFile.AutoSize = False
        Me.btnAddNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddNewFile.Image = Global.Electronic_Archives_System.My.Resources.Resources.book_add
        Me.btnAddNewFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddNewFile.Name = "btnAddNewFile"
        Me.btnAddNewFile.Size = New System.Drawing.Size(35, 35)
        Me.btnAddNewFile.Text = "إضافة ملف "
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = Global.Electronic_Archives_System.My.Resources.Resources.refresh
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(35, 35)
        Me.btnRefresh.Text = "تحديث"
        '
        'btnExpandAll
        '
        Me.btnExpandAll.AutoSize = False
        Me.btnExpandAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExpandAll.Image = Global.Electronic_Archives_System.My.Resources.Resources.ExpandFieldPivotTable_16x16
        Me.btnExpandAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExpandAll.Name = "btnExpandAll"
        Me.btnExpandAll.Size = New System.Drawing.Size(35, 35)
        Me.btnExpandAll.Text = "توسعة الشجرة"
        '
        'btnCollaps
        '
        Me.btnCollaps.AutoSize = False
        Me.btnCollaps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCollaps.Image = Global.Electronic_Archives_System.My.Resources.Resources.CollapseFieldPivotTable_16x16
        Me.btnCollaps.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCollaps.Name = "btnCollaps"
        Me.btnCollaps.Size = New System.Drawing.Size(35, 35)
        Me.btnCollaps.Text = "طي الشجرة"
        '
        'btnSendMail
        '
        Me.btnSendMail.AutoSize = False
        Me.btnSendMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSendMail.Image = Global.Electronic_Archives_System.My.Resources.Resources.email_add
        Me.btnSendMail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(35, 35)
        Me.btnSendMail.Text = "إرسال ملف"
        '
        'btnDeletedPin
        '
        Me.btnDeletedPin.AutoSize = False
        Me.btnDeletedPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeletedPin.Image = Global.Electronic_Archives_System.My.Resources.Resources.Trash_16x16
        Me.btnDeletedPin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeletedPin.Name = "btnDeletedPin"
        Me.btnDeletedPin.Size = New System.Drawing.Size(35, 35)
        Me.btnDeletedPin.Text = "سلة المحذوفات"
        Me.btnDeletedPin.ToolTipText = "سلة المحذوفات الخاصة بالملفات"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.ToolStrip1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(376, 40)
        Me.Panel5.TabIndex = 1
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(0, 1)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(376, 29)
        Me.txtsearch.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.txtsearch)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 40)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(376, 31)
        Me.Panel6.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.Electronic_Archives_System.My.Resources.Resources.Find_16x16__3_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(7, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Indent = 38
        Me.TreeView1.ItemHeight = 40
        Me.TreeView1.Location = New System.Drawing.Point(0, 73)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.RightToLeftLayout = True
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(378, 563)
        Me.TreeView1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Times New Roman", 13.25!, System.Drawing.FontStyle.Bold)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddFolderToolStrip, Me.btnEditFolderToolStrip, Me.btnDeleteFolderToolStrip, Me.ToolStripSeparator1, Me.btnOpenSelectedFileToolStrip, Me.ToolStripSeparator2, Me.btnAddFileToolStrip, Me.btnUpdateFileToolStrip, Me.btnDeleteFileToolStrip, Me.ToolStripSeparator3, Me.btnCopyFileToolStrip, Me.ToolStripSeparator4, Me.btnExpandToolStrip, Me.btnCollapseToolStrip, Me.ToolStripSeparator5, Me.btnRefreshToolStrip, Me.ToolStripSeparator6, Me.btnSendFileToolStrip})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 328)
        '
        'btnAddFolderToolStrip
        '
        Me.btnAddFolderToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.folder_add
        Me.btnAddFolderToolStrip.Name = "btnAddFolderToolStrip"
        Me.btnAddFolderToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnAddFolderToolStrip.Text = "إضافة مجلد "
        '
        'btnEditFolderToolStrip
        '
        Me.btnEditFolderToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.EditContact_16x16__2_
        Me.btnEditFolderToolStrip.Name = "btnEditFolderToolStrip"
        Me.btnEditFolderToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnEditFolderToolStrip.Text = "تعديل بيانات مجلد"
        '
        'btnDeleteFolderToolStrip
        '
        Me.btnDeleteFolderToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.folder_delete
        Me.btnDeleteFolderToolStrip.Name = "btnDeleteFolderToolStrip"
        Me.btnDeleteFolderToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnDeleteFolderToolStrip.Text = "حذف مجلد"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(176, 6)
        '
        'btnOpenSelectedFileToolStrip
        '
        Me.btnOpenSelectedFileToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.Open2_16x16
        Me.btnOpenSelectedFileToolStrip.Name = "btnOpenSelectedFileToolStrip"
        Me.btnOpenSelectedFileToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnOpenSelectedFileToolStrip.Text = "فتح الملف"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(176, 6)
        '
        'btnAddFileToolStrip
        '
        Me.btnAddFileToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.book_add
        Me.btnAddFileToolStrip.Name = "btnAddFileToolStrip"
        Me.btnAddFileToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnAddFileToolStrip.Text = "إضافة ملف"
        '
        'btnUpdateFileToolStrip
        '
        Me.btnUpdateFileToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.EditContact_16x16__2_
        Me.btnUpdateFileToolStrip.Name = "btnUpdateFileToolStrip"
        Me.btnUpdateFileToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnUpdateFileToolStrip.Text = "تعديل بيانات ملف"
        '
        'btnDeleteFileToolStrip
        '
        Me.btnDeleteFileToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.Delete_24x24
        Me.btnDeleteFileToolStrip.Name = "btnDeleteFileToolStrip"
        Me.btnDeleteFileToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnDeleteFileToolStrip.Text = "حذف ملف"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(176, 6)
        '
        'btnCopyFileToolStrip
        '
        Me.btnCopyFileToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources._118916_guardar_save_document_icon
        Me.btnCopyFileToolStrip.Name = "btnCopyFileToolStrip"
        Me.btnCopyFileToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnCopyFileToolStrip.Text = "نسخ الملف"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(176, 6)
        '
        'btnExpandToolStrip
        '
        Me.btnExpandToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.ExpandFieldPivotTable_16x16
        Me.btnExpandToolStrip.Name = "btnExpandToolStrip"
        Me.btnExpandToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnExpandToolStrip.Text = "توسيع الشجرة"
        '
        'btnCollapseToolStrip
        '
        Me.btnCollapseToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.CollapseFieldPivotTable_16x16
        Me.btnCollapseToolStrip.Name = "btnCollapseToolStrip"
        Me.btnCollapseToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnCollapseToolStrip.Text = "طي الشجرة"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(176, 6)
        '
        'btnRefreshToolStrip
        '
        Me.btnRefreshToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.refresh
        Me.btnRefreshToolStrip.Name = "btnRefreshToolStrip"
        Me.btnRefreshToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnRefreshToolStrip.Text = "تحديث"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(176, 6)
        '
        'btnSendFileToolStrip
        '
        Me.btnSendFileToolStrip.Image = Global.Electronic_Archives_System.My.Resources.Resources.email_add
        Me.btnSendFileToolStrip.Name = "btnSendFileToolStrip"
        Me.btnSendFileToolStrip.Size = New System.Drawing.Size(179, 24)
        Me.btnSendFileToolStrip.Text = "إرسال ملف "
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "pngwing.com (1).png")
        Me.ImageList1.Images.SetKeyName(1, "folder (3).png")
        Me.ImageList1.Images.SetKeyName(2, "folder (4).png")
        Me.ImageList1.Images.SetKeyName(3, "Green - Dark.png")
        Me.ImageList1.Images.SetKeyName(4, "Red.png")
        Me.ImageList1.Images.SetKeyName(5, "Black.png")
        Me.ImageList1.Images.SetKeyName(6, "Orange.png")
        Me.ImageList1.Images.SetKeyName(7, "Blue - Navy.png")
        Me.ImageList1.Images.SetKeyName(8, "Pink - Dark.png")
        Me.ImageList1.Images.SetKeyName(9, "Green.png")
        Me.ImageList1.Images.SetKeyName(10, "Beige.png")
        Me.ImageList1.Images.SetKeyName(11, "Red - Dark.png")
        Me.ImageList1.Images.SetKeyName(12, "Yellow.png")
        Me.ImageList1.Images.SetKeyName(13, "Green - Lime.png")
        Me.ImageList1.Images.SetKeyName(14, "Pink - Light.png")
        Me.ImageList1.Images.SetKeyName(15, "Yellow - Light.png")
        Me.ImageList1.Images.SetKeyName(16, "Blue - Light.png")
        Me.ImageList1.Images.SetKeyName(17, "Grey.png")
        Me.ImageList1.Images.SetKeyName(18, "Blue.png")
        Me.ImageList1.Images.SetKeyName(19, "Turquoise.png")
        Me.ImageList1.Images.SetKeyName(20, "Purple - Dark.png")
        Me.ImageList1.Images.SetKeyName(21, "Pink.png")
        Me.ImageList1.Images.SetKeyName(22, "Purple.png")
        Me.ImageList1.Images.SetKeyName(23, "pngwing.com (4).png")
        Me.ImageList1.Images.SetKeyName(24, "pngwing.com (3).png")
        Me.ImageList1.Images.SetKeyName(25, "pngwing.com.png")
        Me.ImageList1.Images.SetKeyName(26, "folder (2).png")
        Me.ImageList1.Images.SetKeyName(27, "open-folder.png")
        Me.ImageList1.Images.SetKeyName(28, "‫book.png")
        Me.ImageList1.Images.SetKeyName(29, "PDF24.png")
        Me.ImageList1.Images.SetKeyName(30, "MS-Word-24.png")
        Me.ImageList1.Images.SetKeyName(31, "Excel-icon24.png")
        Me.ImageList1.Images.SetKeyName(32, "PowerPoint24.png")
        Me.ImageList1.Images.SetKeyName(33, "microsoft_Access24.png")
        Me.ImageList1.Images.SetKeyName(34, "Winrar.png")
        Me.ImageList1.Images.SetKeyName(35, "Picture_24x24.png")
        Me.ImageList1.Images.SetKeyName(36, "movie ‫‬.png")
        Me.ImageList1.Images.SetKeyName(37, "play-music.png")
        Me.ImageList1.Images.SetKeyName(38, "Text .png")
        Me.ImageList1.Images.SetKeyName(39, "web1.ico")
        Me.ImageList1.Images.SetKeyName(40, "DVD Disk_24x24.png")
        Me.ImageList1.Images.SetKeyName(41, "my-reports24.png")
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(378, 73)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dgv_Files)
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 640)
        Me.Panel1.TabIndex = 0
        '
        'dgv_Files
        '
        Me.dgv_Files.AllowUserToAddRows = False
        Me.dgv_Files.AllowUserToDeleteRows = False
        Me.dgv_Files.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgv_Files.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Files.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Files.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Files.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Files.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Files.ColumnHeadersVisible = False
        Me.dgv_Files.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.xCode, Me.xName})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Files.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Files.EnableHeadersVisualStyles = False
        Me.dgv_Files.Location = New System.Drawing.Point(18, 73)
        Me.dgv_Files.MultiSelect = False
        Me.dgv_Files.Name = "dgv_Files"
        Me.dgv_Files.ReadOnly = True
        Me.dgv_Files.RowHeadersWidth = 25
        Me.dgv_Files.Size = New System.Drawing.Size(359, 200)
        Me.dgv_Files.TabIndex = 2
        Me.dgv_Files.Visible = False
        '
        'xCode
        '
        Me.xCode.DataPropertyName = "FileCode"
        Me.xCode.HeaderText = "رقم الملف أو المجلد"
        Me.xCode.Name = "xCode"
        Me.xCode.ReadOnly = True
        Me.xCode.Visible = False
        '
        'xName
        '
        Me.xName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.xName.DataPropertyName = "FileName"
        Me.xName.HeaderText = "اسم الملف أو المجلد"
        Me.xName.Name = "xName"
        Me.xName.ReadOnly = True
        '
        'P_Side
        '
        Me.P_Side.BackColor = System.Drawing.Color.SteelBlue
        Me.P_Side.Controls.Add(Me.Label3)
        Me.P_Side.Controls.Add(Me.Label2)
        Me.P_Side.Controls.Add(Me.btnAddNewUser)
        Me.P_Side.Controls.Add(Me.btnSettings)
        Me.P_Side.Controls.Add(Me.btnBackup)
        Me.P_Side.Controls.Add(Me.btnAbout)
        Me.P_Side.Controls.Add(Me.btnClose)
        Me.P_Side.Controls.Add(Me.Panel10)
        Me.P_Side.Controls.Add(Me.Panel9)
        Me.P_Side.Controls.Add(Me.Panel8)
        Me.P_Side.Dock = System.Windows.Forms.DockStyle.Left
        Me.P_Side.Location = New System.Drawing.Point(0, 0)
        Me.P_Side.Name = "P_Side"
        Me.P_Side.Size = New System.Drawing.Size(120, 668)
        Me.P_Side.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "المستخدم الحالي" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddNewUser
        '
        Me.btnAddNewUser.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewUser.BackgroundImage = Global.Electronic_Archives_System.My.Resources.Resources.user_add_icon
        Me.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewUser.FlatAppearance.BorderSize = 0
        Me.btnAddNewUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewUser.Location = New System.Drawing.Point(5, 266)
        Me.btnAddNewUser.Name = "btnAddNewUser"
        Me.btnAddNewUser.Size = New System.Drawing.Size(110, 52)
        Me.btnAddNewUser.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnAddNewUser, "حسابات المستخدمين")
        Me.btnAddNewUser.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Image = Global.Electronic_Archives_System.My.Resources.Resources._1309721023_setting_tools
        Me.btnSettings.Location = New System.Drawing.Point(2, 328)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(110, 49)
        Me.btnSettings.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnSettings, "إعدادات الاتصال بالسيرفر")
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Image = Global.Electronic_Archives_System.My.Resources.Resources.database_go
        Me.btnBackup.Location = New System.Drawing.Point(4, 382)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(110, 49)
        Me.btnBackup.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnBackup, "النسخ الاحتياطي")
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Image = Global.Electronic_Archives_System.My.Resources.Resources.Information_48x48
        Me.btnAbout.Location = New System.Drawing.Point(5, 437)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(110, 49)
        Me.btnAbout.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnAbout, "حول البرنامج")
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Electronic_Archives_System.My.Resources.Resources.exitallb
        Me.btnClose.Location = New System.Drawing.Point(6, 500)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 45)
        Me.btnClose.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnClose, "إغلاق البرنامج")
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.pictureBox2)
        Me.Panel10.Controls.Add(Me.Label1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 546)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(120, 122)
        Me.Panel10.TabIndex = 2
        '
        'pictureBox2
        '
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(0, 8)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(120, 88)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 20
        Me.pictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "12:00:00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.PictureBox1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 45)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(120, 126)
        Me.Panel9.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Electronic_Archives_System.My.Resources.Resources.flat_seo_30_512
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 126)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnUserRoles)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(120, 45)
        Me.Panel8.TabIndex = 0
        '
        'btnUserRoles
        '
        Me.btnUserRoles.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUserRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUserRoles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUserRoles.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnUserRoles.FlatAppearance.BorderSize = 0
        Me.btnUserRoles.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnUserRoles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnUserRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnUserRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserRoles.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserRoles.ForeColor = System.Drawing.Color.White
        Me.btnUserRoles.Image = Global.Electronic_Archives_System.My.Resources.Resources._1322323808_group_key
        Me.btnUserRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUserRoles.Location = New System.Drawing.Point(0, 0)
        Me.btnUserRoles.Name = "btnUserRoles"
        Me.btnUserRoles.Size = New System.Drawing.Size(120, 45)
        Me.btnUserRoles.TabIndex = 4
        Me.btnUserRoles.Text = "الصلاحيات"
        Me.btnUserRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.btnUserRoles, "صلاحيات المستخدمين")
        Me.btnUserRoles.UseVisualStyleBackColor = False
        '
        'P_Tail
        '
        Me.P_Tail.BackColor = System.Drawing.SystemColors.Control
        Me.P_Tail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.P_Tail.Controls.Add(Me.lblCount)
        Me.P_Tail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.P_Tail.Location = New System.Drawing.Point(120, 642)
        Me.P_Tail.Name = "P_Tail"
        Me.P_Tail.Size = New System.Drawing.Size(1020, 26)
        Me.P_Tail.TabIndex = 4
        '
        'lblCount
        '
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCount.ForeColor = System.Drawing.Color.Blue
        Me.lblCount.Location = New System.Drawing.Point(613, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(403, 22)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(120, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 642)
        Me.SplitContainer1.SplitterDistance = 384
        Me.SplitContainer1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.WebPanel)
        Me.Panel3.Controls.Add(Me.PicPanel)
        Me.Panel3.Controls.Add(Me.PDFPanel)
        Me.Panel3.Controls.Add(Me.txtPanel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(630, 640)
        Me.Panel3.TabIndex = 5
        '
        'WebPanel
        '
        Me.WebPanel.Controls.Add(Me.WebBrowser1)
        Me.WebPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebPanel.Location = New System.Drawing.Point(0, 0)
        Me.WebPanel.Name = "WebPanel"
        Me.WebPanel.Size = New System.Drawing.Size(630, 640)
        Me.WebPanel.TabIndex = 22
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(630, 640)
        Me.WebBrowser1.TabIndex = 0
        '
        'PicPanel
        '
        Me.PicPanel.Controls.Add(Me.PictureBox3)
        Me.PicPanel.Controls.Add(Me.Panel4)
        Me.PicPanel.Controls.Add(Me.Panel7)
        Me.PicPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicPanel.Location = New System.Drawing.Point(0, 0)
        Me.PicPanel.Name = "PicPanel"
        Me.PicPanel.Size = New System.Drawing.Size(630, 640)
        Me.PicPanel.TabIndex = 24
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Location = New System.Drawing.Point(0, 46)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(630, 577)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblImagePath)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 623)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(630, 17)
        Me.Panel4.TabIndex = 0
        '
        'lblImagePath
        '
        Me.lblImagePath.AutoSize = True
        Me.lblImagePath.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblImagePath.Location = New System.Drawing.Point(0, 0)
        Me.lblImagePath.Name = "lblImagePath"
        Me.lblImagePath.Size = New System.Drawing.Size(44, 13)
        Me.lblImagePath.TabIndex = 0
        Me.lblImagePath.Text = "Label14"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.ComboBox1)
        Me.Panel7.Controls.Add(Me.ToolStrip4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(630, 46)
        Me.Panel7.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Normal", "StretchImage", "AutoSize", "CenterImage", "Zoom"})
        Me.ComboBox1.Location = New System.Drawing.Point(189, 9)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 25)
        Me.ComboBox1.TabIndex = 5
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRotateRight, Me.ToolStripSeparator15, Me.btnRotateLeft, Me.ToolStripSeparator16, Me.ToolStripLabel2})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip4.Size = New System.Drawing.Size(628, 44)
        Me.ToolStrip4.TabIndex = 4
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'btnRotateRight
        '
        Me.btnRotateRight.AutoSize = False
        Me.btnRotateRight.Image = Global.Electronic_Archives_System.My.Resources.Resources.rotate_right24
        Me.btnRotateRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRotateRight.Name = "btnRotateRight"
        Me.btnRotateRight.Size = New System.Drawing.Size(31, 31)
        Me.btnRotateRight.ToolTipText = "تدوير ناحيه اليمين"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 44)
        '
        'btnRotateLeft
        '
        Me.btnRotateLeft.AutoSize = False
        Me.btnRotateLeft.Image = Global.Electronic_Archives_System.My.Resources.Resources.rotate_left24
        Me.btnRotateLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRotateLeft.Name = "btnRotateLeft"
        Me.btnRotateLeft.Size = New System.Drawing.Size(31, 31)
        Me.btnRotateLeft.ToolTipText = "تدوير ناحيه اليسار"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 44)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(117, 41)
        Me.ToolStripLabel2.Text = "Size Mode of Image :"
        '
        'PDFPanel
        '
        Me.PDFPanel.Controls.Add(Me.AxAcroPDF1)
        Me.PDFPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PDFPanel.Location = New System.Drawing.Point(0, 0)
        Me.PDFPanel.Name = "PDFPanel"
        Me.PDFPanel.Size = New System.Drawing.Size(630, 640)
        Me.PDFPanel.TabIndex = 23
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(630, 640)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'txtPanel
        '
        Me.txtPanel.Controls.Add(Me.txtReader)
        Me.txtPanel.Controls.Add(Me.TailPanel)
        Me.txtPanel.Controls.Add(Me.TopPanel)
        Me.txtPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPanel.Location = New System.Drawing.Point(0, 0)
        Me.txtPanel.Name = "txtPanel"
        Me.txtPanel.Size = New System.Drawing.Size(630, 640)
        Me.txtPanel.TabIndex = 25
        '
        'txtReader
        '
        Me.txtReader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReader.Location = New System.Drawing.Point(0, 0)
        Me.txtReader.Name = "txtReader"
        Me.txtReader.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txtReader.Size = New System.Drawing.Size(630, 624)
        Me.txtReader.TabIndex = 2
        Me.txtReader.Text = ""
        '
        'TailPanel
        '
        Me.TailPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TailPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TailPanel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TailPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TailPanel.Location = New System.Drawing.Point(0, 624)
        Me.TailPanel.Name = "TailPanel"
        Me.TailPanel.Size = New System.Drawing.Size(630, 16)
        Me.TailPanel.TabIndex = 1
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(539, 46)
        Me.TopPanel.TabIndex = 0
        '
        'btnFolderDeletedPin
        '
        Me.btnFolderDeletedPin.AutoSize = False
        Me.btnFolderDeletedPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFolderDeletedPin.Image = Global.Electronic_Archives_System.My.Resources.Resources.Trash_16x16
        Me.btnFolderDeletedPin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFolderDeletedPin.Name = "btnFolderDeletedPin"
        Me.btnFolderDeletedPin.Size = New System.Drawing.Size(35, 35)
        Me.btnFolderDeletedPin.Text = "سلة المحذوفات"
        Me.btnFolderDeletedPin.ToolTipText = "سلة المحذوفات الخاصة بالمجلدات"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1140, 668)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.P_Tail)
        Me.Controls.Add(Me.P_Side)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmMainPage"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "برنامج الارشيف الالكتروني"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_Files, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_Side.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.P_Tail.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.WebPanel.ResumeLayout(False)
        Me.PicPanel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.PDFPanel.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txtPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDeletedPin As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSendMail As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCollaps As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExpandAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAddNewFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAddNewFolder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents P_Side As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddNewUser As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents P_Tail As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnUserRoles As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnAddFolderToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEditFolderToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDeleteFolderToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAddFileToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpdateFileToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDeleteFileToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExpandToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCollapseToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRefreshToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSendFileToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnOpenSelectedFileToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCopyFileToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgv_Files As System.Windows.Forms.DataGridView
    Friend WithEvents xCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents WebPanel As System.Windows.Forms.Panel
    Friend WithEvents PicPanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblImagePath As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRotateRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRotateLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PDFPanel As System.Windows.Forms.Panel
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents txtPanel As System.Windows.Forms.Panel
    Friend WithEvents txtReader As System.Windows.Forms.RichTextBox
    Friend WithEvents TailPanel As System.Windows.Forms.Panel
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnFolderDeletedPin As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
