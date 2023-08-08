<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddFolders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddFolders))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnhelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.btnPreviouse = New System.Windows.Forms.ToolStripButton()
        Me.btnLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderID = New System.Windows.Forms.TextBox()
        Me.FolderName = New System.Windows.Forms.TextBox()
        Me.FolderNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblconfirmMessage = New System.Windows.Forms.Label()
        Me.PicMessage = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderParent = New ComboTreeBox()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PicMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 43)
        Me.Panel1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnhelp, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(568, 43)
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
        Me.ToolStripLabel1.Text = "إضافة مجلد جديد"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ToolStrip2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 39)
        Me.Panel2.TabIndex = 5
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.ToolStripSeparator1, Me.btnSave, Me.ToolStripSeparator2, Me.btnEdit, Me.ToolStripSeparator3, Me.btnDelete, Me.ToolStripSeparator4, Me.btnClose, Me.ToolStripSeparator5, Me.btnFirst, Me.btnNext, Me.txtNevigate, Me.btnPreviouse, Me.btnLast, Me.ToolStripSeparator6})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(566, 37)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
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
        Me.btnClose.Image = Global.Electronic_Archives_System.My.Resources.Resources.Close_16x16
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 37)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "معرف المجلد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "اسم المجلد"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "رقم المجلد"
        '
        'FolderID
        '
        Me.FolderID.BackColor = System.Drawing.Color.Honeydew
        Me.FolderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FolderID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderID.Location = New System.Drawing.Point(150, 245)
        Me.FolderID.Name = "FolderID"
        Me.FolderID.ReadOnly = True
        Me.FolderID.Size = New System.Drawing.Size(348, 29)
        Me.FolderID.TabIndex = 3
        Me.FolderID.TabStop = False
        '
        'FolderName
        '
        Me.FolderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FolderName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderName.Location = New System.Drawing.Point(150, 150)
        Me.FolderName.MaxLength = 100
        Me.FolderName.Name = "FolderName"
        Me.FolderName.Size = New System.Drawing.Size(348, 29)
        Me.FolderName.TabIndex = 1
        '
        'FolderNumber
        '
        Me.FolderNumber.BackColor = System.Drawing.Color.Honeydew
        Me.FolderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FolderNumber.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolderNumber.Location = New System.Drawing.Point(150, 103)
        Me.FolderNumber.Name = "FolderNumber"
        Me.FolderNumber.ReadOnly = True
        Me.FolderNumber.Size = New System.Drawing.Size(348, 29)
        Me.FolderNumber.TabIndex = 0
        Me.FolderNumber.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "المجلد الاب"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblconfirmMessage)
        Me.Panel3.Controls.Add(Me.PicMessage)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 307)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(568, 31)
        Me.Panel3.TabIndex = 13
        '
        'lblconfirmMessage
        '
        Me.lblconfirmMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblconfirmMessage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblconfirmMessage.ForeColor = System.Drawing.Color.Blue
        Me.lblconfirmMessage.Location = New System.Drawing.Point(214, 0)
        Me.lblconfirmMessage.Name = "lblconfirmMessage"
        Me.lblconfirmMessage.Size = New System.Drawing.Size(320, 29)
        Me.lblconfirmMessage.TabIndex = 3
        Me.lblconfirmMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PicMessage
        '
        Me.PicMessage.Dock = System.Windows.Forms.DockStyle.Right
        Me.PicMessage.Location = New System.Drawing.Point(534, 0)
        Me.PicMessage.Name = "PicMessage"
        Me.PicMessage.Size = New System.Drawing.Size(32, 29)
        Me.PicMessage.TabIndex = 3
        Me.PicMessage.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
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
        'FolderParent
        '
        Me.FolderParent.BackColor = System.Drawing.Color.White
        Me.FolderParent.DrawWithVisualStyles = False
        Me.FolderParent.DropDownHeight = 400
        Me.FolderParent.DroppedDown = False
        Me.FolderParent.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.FolderParent.Images = Me.ImageList1
        Me.FolderParent.Location = New System.Drawing.Point(150, 198)
        Me.FolderParent.Name = "FolderParent"
        Me.FolderParent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FolderParent.SelectedNode = Nothing
        Me.FolderParent.Size = New System.Drawing.Size(348, 29)
        Me.FolderParent.TabIndex = 2
        '
        'FrmAddFolders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 338)
        Me.Controls.Add(Me.FolderParent)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FolderID)
        Me.Controls.Add(Me.FolderName)
        Me.Controls.Add(Me.FolderNumber)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddFolders"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة مجلد"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PicMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnhelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents btnPreviouse As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderID As System.Windows.Forms.TextBox
    Friend WithEvents FolderName As System.Windows.Forms.TextBox
    Friend WithEvents FolderNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblconfirmMessage As System.Windows.Forms.Label
    Friend WithEvents PicMessage As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents FolderParent As ComboTreeBox
End Class
