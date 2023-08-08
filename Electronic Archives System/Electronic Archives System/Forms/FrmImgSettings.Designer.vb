<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImgSettings
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ComboExtension = New System.Windows.Forms.ComboBox()
        Me.DefualtName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ScandImageFolder = New System.Windows.Forms.TextBox()
        Me.btnSelectFolder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(284, 43)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Sakkal Majalla", 20.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(250, 40)
        Me.ToolStripLabel1.Text = "إعدادات المسح الضوئي"
        '
        'ComboExtension
        '
        Me.ComboExtension.BackColor = System.Drawing.SystemColors.Window
        Me.ComboExtension.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboExtension.FormattingEnabled = True
        Me.ComboExtension.ItemHeight = 13
        Me.ComboExtension.Items.AddRange(New Object() {"PNG", "JPEG", "TIFF"})
        Me.ComboExtension.Location = New System.Drawing.Point(12, 69)
        Me.ComboExtension.Name = "ComboExtension"
        Me.ComboExtension.Size = New System.Drawing.Size(85, 21)
        Me.ComboExtension.TabIndex = 21
        '
        'DefualtName
        '
        Me.DefualtName.BackColor = System.Drawing.SystemColors.Window
        Me.DefualtName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DefualtName.FormattingEnabled = True
        Me.DefualtName.ItemHeight = 13
        Me.DefualtName.Items.AddRange(New Object() {"Scan", "Image", "File"})
        Me.DefualtName.Location = New System.Drawing.Point(96, 69)
        Me.DefualtName.Name = "DefualtName"
        Me.DefualtName.Size = New System.Drawing.Size(160, 21)
        Me.DefualtName.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "امتداد الصورة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "الاسم الافتراضي للصور"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "مسار حفظ الصور"
        '
        'ScandImageFolder
        '
        Me.ScandImageFolder.Location = New System.Drawing.Point(5, 117)
        Me.ScandImageFolder.Name = "ScandImageFolder"
        Me.ScandImageFolder.Size = New System.Drawing.Size(236, 20)
        Me.ScandImageFolder.TabIndex = 26
        '
        'btnSelectFolder
        '
        Me.btnSelectFolder.Image = Global.Electronic_Archives_System.My.Resources.Resources.Open2_16x16
        Me.btnSelectFolder.Location = New System.Drawing.Point(247, 115)
        Me.btnSelectFolder.Name = "btnSelectFolder"
        Me.btnSelectFolder.Size = New System.Drawing.Size(25, 23)
        Me.btnSelectFolder.TabIndex = 27
        Me.btnSelectFolder.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 34)
        Me.Panel1.TabIndex = 28
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.Electronic_Archives_System.My.Resources.Resources.Delete_16x16
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(18, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 28)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "إغلاق      "
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Image = Global.Electronic_Archives_System.My.Resources.Resources.Save_16x16__4_
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(164, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 28)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "حفظ       "
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FrmImgSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSelectFolder)
        Me.Controls.Add(Me.ScandImageFolder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DefualtName)
        Me.Controls.Add(Me.ComboExtension)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmImgSettings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إعدادات المسح الضوئي"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ComboExtension As System.Windows.Forms.ComboBox
    Friend WithEvents DefualtName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ScandImageFolder As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectFolder As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
