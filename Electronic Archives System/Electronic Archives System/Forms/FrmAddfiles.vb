Imports System.IO

Public Class FrmAddfiles

    Dim cls As New ProjectClass
    Dim dt As New DataTable
    Public ReturnID As String ' متغير يحمل القيمة الراجعة التي تتم ارسالها بعد تنفيذ الاجراء المخزن 
    Public XFileCode As Decimal = 0 ' وظيفه هذا المتغير هي الحتواء على قيمة ارقم الملف الذي سيتم عمل عليه تعديل واستخدمناه في كود المينو ستريب للتعديل الموجود في الشاشة الرئيسية

    Private Sub btnScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click
        'If FolderParent.SelectedNode Is Nothing Then ' اي انه فارغ في بداية الامر
        '    MessageBox.Show(" من فضلك اختر المجلد الاب للملف", "رساله تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If

        'If Me.FolderParent.SelectedNode is Nothing or FileCode.Text  = String.Empty Then
        '    MessageBox.Show("يجب اختيار المجلد الاب اولا ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If
        'ScanTo = 1
        'If FrmScan.Visible = True Then FrmScan.Visible = False
        'FrmScan.Show(Me)


        'or
        If MyComboTreeBoxNodeIsNull(FolderParent, " المجلد الأب أولا ") Then Return

        ScanTo = 1
        If FrmScan.Visible = True Then FrmScan.Visible = False
        FrmScan.Show(Me)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'cls.FillMyComboBox(FolderParent) ' هذا الخاص بالكمبوبوكس القديم 
        cls.FillMyComboTreeBox(Me)
        cls.ClearFrmAddfilesControls(Me)


    End Sub

    Private Sub FileSecret_CheckedChanged(sender As Object, e As EventArgs) Handles FileSecret.CheckedChanged
        If FileSecret.Checked = True Then
            CkShowHide.Visible = True
            FilePassword.Enabled = True
            FilePassword.Focus()

        Else
            FilePassword.Enabled = False
            CkShowHide.Visible = False
            CkShowHide.Checked = False
            FilePassword.Clear()

        End If

    End Sub


    ' خاص بالكمبوبكوس القديم
    'Private Sub FolderParent_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If Me.FolderParent.SelectedIndex > 0 Then
    '        Me.FileCode.Text = cls.GetFileCode(Me.FolderParent.SelectedValue)
    '    End If

    'End Sub

    Private Sub btnAddAttaches_Click(sender As Object, e As EventArgs) Handles btnAddAttaches.Click
        cls.GetAttachedFilesInfo(Me, dgv)
    End Sub

    Private Sub btnForword_Click(sender As Object, e As EventArgs) Handles btnForword.Click

        If WebBrowser1.CanGoForward Then ' هل يمكن عمل التالي اي هل هناك امكانيه للتنقل للتالي 
            WebBrowser1.GoForward()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If WebBrowser1.CanGoBack Then ' هل يمكن عمل سابق اي هل هناك امكانيه للتنقل للسابق 
            WebBrowser1.GoBack()
        End If

    End Sub

    Private Sub btnbrows_Click(sender As Object, e As EventArgs) Handles btnbrows.Click
        cls.GetMainFileInfo(Me)

    End Sub



    Private Sub FrmAddfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cls.AddFilesFormFormatting(Me)
        Me.ComboBox1.SelectedIndex = 4
        cls.Show_Data_Of_FileData(Me, XFileCode) ' عرض بيانات الملف عبر رقمه الممرر من واجهة نفسها والتي يتم اسناد قيمة الملف له في الشاشة الرئيسية في كود المنيو ستريب الخاص بالتعديل والذي يؤخذ عند التحديد على العقدة
        ' وسيتم العرض عندما تكون هناك قيمة رقم الملف موجودة داخل المتغير ولايعرض شي عندما تكون قيمه ب 0 وهي الافتراضية
    End Sub

    Private Sub btnScanAttaches_Click(sender As Object, e As EventArgs) Handles btnScanAttaches.Click
        ' If MyCombIndexNull(Me.FolderParent, "المجلد الأب أولاً") Then Return ' خاص بالكمبوبوكس القديم

        ' this code here 

        'If Me.FileSize.Text.Trim = String.Empty Then
        '    MessageBox.Show("يجب اضافة الملف الاساسي اولا ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.TabControl1.SelectedTab = Me.TabPage1
        '    Return
        'End If
        'ScanTo = 2
        'FrmScan.Show(Me)

        'or
        If MyComboTreeBoxNodeIsNull(FolderParent, " المجلد الأب أولا ") Then Return
        Me.TabControl1.SelectedTab = Me.TabPage1
        ScanTo = 2
        FrmScan.Show(Me)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Select Case ComboBox1.SelectedIndex

            Case 0
                PictureBox1.SizeMode = PictureBoxSizeMode.Normal
            Case 1
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Case 2
                PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            Case 3
                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Case 4
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

        End Select

    End Sub

    Private Sub btnRotateRight_Click(sender As Object, e As EventArgs) Handles btnRotateRight.Click
        RotateRight(PictureBox1)
    End Sub


    Private Sub btnRotateLeft_Click(sender As Object, e As EventArgs) Handles btnRotateLeft.Click
        RotateLeft(PictureBox1)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click



        Dim Result As DialogResult = MessageBox.Show("انت على وشك تنفيذ عملية الحفظ" & vbNewLine & "هل تود تنفيذ عملية الحفظ مع تخزين الملفات في قاعدة البيانات ؟ ", "رسالة تنبيه", MessageBoxButtons.YesNoCancel)
            If Result = DialogResult.Yes Then
                cls.Save_Files(Me, True) ' يتم الحفظ في قاعدة البيانات لذلك نمرر ترو كقيمة للمتغيرالذي يحدد مكان الحفظ
            ElseIf Result = DialogResult.No Then
                cls.Save_Files(Me, False) ' لايحفظ في قاعدة البيانات ويحفظ في مجلدات الجهاز
            ElseIf Result = DialogResult.Cancel Then
                btnNew.PerformClick()
                ConfirmMessage(lblconfirmMessage, PicMessage, Timer1, "تم إلغاء الحفظ بنجاح") ' اظهار رسالة تم إلغاء الحفظ بنجاح 
                Exit Sub ' لايقوم بتنفيذ اي شي 
            End If



       


        End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        cls.CopySavedFile(Me, ReturnID) '  اجراء نسخ الملف الذي قمنا بارشفته من مكانه الى المسار الخاص بحفظ ملفات البرنامج  
        ' وسبب عمله في هذا الاجراء هو انه يمسك الملف في الخلفية بدون ان يسبب اي اخطاء او تعليق اثناء عمل البرنامج 

    End Sub

    Private Sub FolderParent_DropDownClosed(sender As Object, e As EventArgs) Handles FolderParent.DropDownClosed

        Try

            If FolderParent.SelectedNode Is Nothing Then Me.FileCode.Clear() : Return
            Me.FileCode.Text = cls.GetFileCode(FolderParent.SelectedNode.Tag)



        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

  
    Private Sub CkShowHide_CheckedChanged(sender As Object, e As EventArgs) Handles CkShowHide.CheckedChanged
        If CkShowHide.Checked = True Then
            FilePassword.UseSystemPasswordChar = False
            Me.CkShowHide.Text = "إخفاء"
        Else
            FilePassword.UseSystemPasswordChar = True
            Me.CkShowHide.Text = "إظهار"
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblconfirmMessage.Text = Nothing
        PicMessage.Image = Nothing
        Timer1.Stop()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If MessageBox.Show("هل تود تنفيذ عملية التعديل ؟", "رسالة تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            cls.Upate_Files(Me)
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show(" انت على وشك حذف الملف  [ " & Space(2) & Me.FileName.Text & " ] هل تود الاستمرار ؟ ", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            DeleteRecourd("Files", "FileCode", Me.FileCode.Text, Me.lblconfirmMessage, Me.PicMessage, Me.Timer1) 'دالة الحذف ونمرر لها اسم الجدول وسم العمود ورقم الملف والليبل لعمل عرض النص والايقونه والمؤقت الخاص بظهور الاشعار  

            '  السطرين هذه وهو اختياري ولو لم يوجد ستتم عملية الحذف
            Dim Xfind() As TreeNode = FrmMainPage.TreeView1.Nodes.Find(Me.FileCode.Text, True) ' يخزن متغير البحث كمصفوفة من نوع عقد الشجرة ويقوم بتخزين بداخلها مكان الملف المعدل بعد البحث عليه في الشجرة من خلال رقمه  والمتغير الثاني لكي يتم البحث في جميع عناصر الشجرة 
            FrmMainPage.TreeView1.SelectedNode = Xfind(0) ' قم بالتحديد او السلكت على الملف بعد البحث

            FrmMainPage.TreeView1.SelectedNode.Remove() ' قم بعمل حذف للعقدة من الشجرة 
            cls.ClearFrmAddfilesControls(Me) ' استدعاء دالة تنظيف الادوات الخاصة بشاشة اضافة الملفات
        End If
    End Sub

    Private Sub FrmAddfiles_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        keyBoardAbbreviatios(e, btnNew, btnSave, btnEdit, btnDelete, btnClose)
    End Sub


    Private Sub FrmAddfiles_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dt.Dispose()
    End Sub

    
    ' حدث الضغط على خلية الداتا جريد فيو
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

        If e.ColumnIndex = -1 Or dgv.Rows.Count = 0 Then Return '  اذا لا توجد بيانات في الداتا جريد فيو او لايوجد صفوف في الداتا جريد فيو يخرج من الاجراء لتجنب الاخطاء

        Dim ColName = dgv.Columns(e.ColumnIndex).Name

        ' اذا كان اسم العمود هو الفتح يتم اعطاء الويب براوز مسار الملف في العمود رقم 5 ليتم العرض
        If ColName = "btnOpen1" And dgv.CurrentRow.Cells(5).Value IsNot Nothing Then ' To Open Selected Files و الخلية 5 للصف الحالي ليست بفراغ وهي معناه ان هناك مسار كامل للملف 
            'Me.WebBrowser1.Url = New Uri(dgv(5, dgv.CurrentRow.Index).Value.ToString) '
            cls.OpenFiles(Me, dgv(5, dgv.CurrentRow.Index).Value.ToString) ' استدعاء داله فتح الملفات  وتمرير لها المسار الكامل


        ElseIf ColName = "btnOpen1" And dgv.CurrentRow.Cells(5).Value Is Nothing Then ' عند النقر على فتح  و الخلية 5 للصف الحالي  بفراغ وهي معناه انه ليس هناك مسار كامل للملف كون الملف مخز في قاعدة البيانات
            Dim xFullPath, xFileName As String ' نعرف متغيرين المسار الكامل و اسم الملف
            xFileName = dgv.CurrentRow.Cells(1).Value & dgv.CurrentRow.Cells(2).Value ' اسم الملف يساوي الخلية رقم 1 وهي اسم الملف و الخلية رقم 2 وهي الخاصة بامتداد الملف
            xFullPath = cls.GetAttachedFile(Me.FileID.Text, dgv.CurrentRow.Cells(8).Value, xFileName) ' نحفظ في متغير المسار الكامل المسار الذي  سوف يعود من الدالة ونمرر للدالة رقم الملف الاساسي وهو المعرف و هو رقم ترتيب الملف الموجود في الخلية رقم 8 و اسم الملف
            cls.OpenFiles(Me, xFullPath) ' نستدعي دالة فتح الملف ونمرر لها الواجهة ومسار الملف بالكامل الذي صار موجود على الجهاز 


            ' اذا كان اسم العمود هو الحذف يتم عمل رسالة للمستخدم  
        ElseIf ColName = "btnDelete1" Then ' To Delete Current Row
            ' تظهر الرسالة ويتم معها دمج اسم الملف بالنسبة للعمود الخاص به 
            If MessageBox.Show("هل تود حذف الملف" & dgv(1, dgv.CurrentRow.Index).Value & vbNewLine &
                           "بشكل نهائي ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' في حاله موافقة المستخدم يتم التحقق هل تم حفظ هذا الملف في قاعدة البيانات او لا عبر عمود المسلسل  فاذا تم اضافته ينفذ كود الشرط
                If Val(dgv(0, dgv.CurrentRow.Index).Value) > 0 Then ' كون ان القمية الاولية قبل الحفظ لاي ملف هي 0 واذا كانت قيمة اكبر او اخرى معناه ان الملف محفوظ بقاعدة البيانات

                    ' Delete file from table in database يحذف الملف من قاعدة البيانات 
                    cls.Delete_FromDataBase("AttachedFiles", "ID", dgv(0, dgv.CurrentRow.Index).Value, Me.lblconfirmMessage, Me.PicMessage, Me.Timer1)
                    ' Delete file from Computer 
                    If dgv.CurrentRow.Cells(5).Value IsNot Nothing Then File.Delete(dgv(5, dgv.CurrentRow.Index).Value) ' io هذا السطر يقوم بحذف ملف المرفقات من جهاز الكمبيوتر عن طريق دالة الحذف الموجودة في مكتبة  و 
                    '  ويمرر له مسار الملف الموجود في الخلية رقم 5 ولكن يطبق في حالة كانت الخلية رقم 5 غير فارغة ومعناها نه يوجد مسار لملف
                End If



                '    يحذف من الداتا جريد فيو في كلتا الحالتين سوا اكان موجود في القاعدة وتم حذفه او موجود في الداتا جريد فيو  
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index)
            End If

        End If

    End Sub
End Class