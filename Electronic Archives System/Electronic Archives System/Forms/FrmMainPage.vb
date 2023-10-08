Imports System.Threading

Public Class FrmMainPage

    Dim cls As New ProjectClass

    Private Sub ClearWebBrowser() ' اجراء تنظيف المتصفح من اي ملفات تم عرضها فيه 
        Try

            Me.WebBrowser1.DocumentText = Nothing  ' تنظيف المتصفح 
            Me.PictureBox1.Image = Nothing
            'Me.AxAcroPDF1.src = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteTempFiles() ' اجراء الحذف 
        Thread.Sleep(1000) ' قبل الحذف نعمل ايقاف للنظام بمقدار 1000 ملي سنكد اي مايعادل 1 ثانية 
        DeleteDirectory(My.Settings.FilePath & "Archived Files\Temp") ' تم استدعاء الداله التي تقوم بحذف الملفات والمجلدات التي انشأناها في المديول العام ومررنا لها المجلد المؤقت لكي تحذف الملفات التي فيه 
    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        '' تم استخدام الثريد لكي يتم حل مشكلة ظهور الاخطاء عند حذف الملفات من المجلد المؤقت فالثريد الاول ينظف المتصفح من اي ملف مفتوح وهو سبب ظهور الخطأ  
        '' والثريد الثاني يقوم بعملية الحذف للملفات الموجودة في المجلد المؤقت  
        'Dim Thr1 As Thread = New Thread(AddressOf ClearWebBrowser) ' عمل انشاء ثريد ونمرر له الداله التي نريد تنفيذها داخل هذا الثريد
        'Thr1.Start() ' تشغيل الثريد  رقم 1 
        'Dim Thr2 As Thread = New Thread(AddressOf DeleteTempFiles) ' عمل انشاء ثريد ونمرر له الداله التي نريد تنفيذها داخل هذا الثريد
        'Thr2.Start() ' تشغيل الثريد رقم 2 
        '' الى هنا يتم تنفيذ الاثنين الثريد في نفس الوقت ولكن سوف نحصل على نفس المشكلة كون ان الملف الى الان مفتوح والاثنين يشتغلو بنفس الوقت 
        '' ولحل هذه المشكلة نستخدم السطر هذا ووظيفتها  هي عمل بلوك او ايقاف لجميع الثريد الاخرى الموجودة لغايه ان ينتهي الثريد تبعها او الذي استدعاها ومن ثم عند الانتهاء يشتغل بقيه الثريد 
        'Thr1.Join() ' تعمل على تجميد بقيه الثريد الى حين انتهاء تنفيذ الثريد الذي استدعاها 

        'Application.Exit()


        If MessageBox.Show("هل تود إغلاق البرنامج ؟", "رسالة تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            ' استدعاء اجراء عمل النسخ الاحتياطي عند اغلاق النظام
            cls.EnableBackupAtCloseingSystem()

            ' تم استخدام الثريد لكي يتم حل مشكلة ظهور الاخطاء عند حذف الملفات من المجلد المؤقت فالثريد الاول ينظف المتصفح من اي ملف مفتوح وهو سبب ظهور الخطأ  
            ' والثريد الثاني يقوم بعملية الحذف للملفات الموجودة في المجلد المؤقت  
            Control.CheckForIllegalCrossThreadCalls = False
            Dim Thr1 As Thread = New Thread(AddressOf ClearWebBrowser) ' عمل انشاء ثريد ونمرر له الداله التي نريد تنفيذها داخل هذا الثريد
            Thr1.Start() ' تشغيل الثريد  رقم 1 
            Dim Thr2 As Thread = New Thread(AddressOf DeleteTempFiles) ' عمل انشاء ثريد ونمرر له الداله التي نريد تنفيذها داخل هذا الثريد
            Thr2.Start() ' تشغيل الثريد رقم 2 
            ' الى هنا يتم تنفيذ الاثنين الثريد في نفس الوقت ولكن سوف نحصل على نفس المشكلة كون ان الملف الى الان مفتوح والاثنين يشتغلو بنفس الوقت 
            ' ولحل هذه المشكلة نستخدم السطر هذا ووظيفتها  هي عمل بلوك او ايقاف لجميع الثريد الاخرى الموجودة لغايه ان ينتهي الثريد تبعها او الذي استدعاها ومن ثم عند الانتهاء يشتغل بقيه الثريد 
            Thr1.Join() ' تعمل على تجميد بقيه الثريد الى حين انتهاء تنفيذ الثريد الذي استدعاها 

            Application.Exit()
        End If

        


    End Sub

    Private Sub btnAddNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewUser.Click
        FrmUserAccounts.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        'FrmServerCon.ShowDialog() 
        FrmServerConnection1.ShowDialog()
        'FrmServerConnection.ShowDialog()
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        'FrmDatabase.ShowDialog()
        'FrmDatabase1.ShowDialog()
        FrmBuckupDataBase.ShowDialog()

    End Sub

    Private Sub btnAddNewFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewFolder.Click
        FrmAddFolders.ShowDialog()
    End Sub

    Private Sub btnAddNewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewFile.Click
        Try
            FrmAddfiles.Show(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMail.Click
        FrmEMail.Show(Me)
    End Sub

    Private Sub btnDeletedPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletedPin.Click
        Try

            FrmCyclePin.Show(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnUserRoles_Click(sender As Object, e As EventArgs) Handles btnUserRoles.Click
        FrmUserRoles.Show(Me)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' زر تحديث شجرة الأرشفة
        cls.LoadArchiveTree(Me)
        Me.TreeView1.Select()

    End Sub


    Private Sub btnExpandAll_Click(sender As Object, e As EventArgs) Handles btnExpandAll.Click
        ' زر عمل توسعة للشجرة
        Try
            Me.TreeView1.ExpandAll()
        Catch ex As Exception
            Exit Sub
        End Try


    End Sub

    Private Sub btnCollaps_Click(sender As Object, e As EventArgs) Handles btnCollaps.Click

        ' زر عمل طي للشجرة
        Try
            Me.TreeView1.CollapseAll()
            Me.TreeView1.TopNode.Expand() ' لكي يعمل على فتح للعقد الرئيسية بعد الطي 
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub btnAddFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnAddFolderToolStrip.Click

        Try ' تتم عمل معالجة الاخطاء للتخلص من اغلاق البرنامج عند عمل اضافه مجلد ولم يتم التحديد على اي عقده في الشجرة

            If TreeView1.SelectedNode.ImageIndex < 28 Then ' معنى هذا الشرط اني واق على مجلدات بنائا على رقم ايقونات المجلدات الموجوده في اداة قائمة الصور 

                Dim xx As New FrmAddFolders
                If xx.Visible = True Then xx.Visible = False ' يعمل على اغلاق الواجهة اذا كانت مفتوحة لتجنب الخطأ
                xx.Show(Me)
                If TreeView1.Nodes.Count = 0 Then Exit Sub ' يقوم باالخروج من الدالة ولا تنفذ السطر الاسفل منها اذا لم يكن هناك اي عقدة على الشجرة 

                '  FrmAddFolders.FolderParent.SelectedValue = Me.TreeView1.SelectedNode.Tag ' الكمبوبوس القديم

                cls.GetParentNode(xx.FolderParent.Nodes, CStr(Me.TreeView1.SelectedNode.Tag), xx.FolderParent) ' هذه الداله تجلب رقم المجلد الاب في الشجرة عند التحديد على والنقر اضافه مجلد الى الكموبوكس تري في شاشه اضافه المجلد لكي يكون اب للمجلد الجديد افتراضيا  
                ' نمرر للداله جميع العقد الموجودة في الشجرة و رقم العقدة التي تم التحديد عليها لاضافه المجلد فيها وثم نمرر الكمبوبوكس الشجري الموجود في فورم اضافة المجلد
                xx.FolderNumber.Text = cls.GetFolderNumber(xx.FolderParent.SelectedNode.Tag) ' هذه الدالة تقوم بجلب اعلى رقم مجلد موجود في هذه العقدة لكي يكون رقم المجلد  الجديدالذي سيتم اضافته وتخزنه في رقم المجلد في شاشه اضافة المجلدات تلقائيا 


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnEditFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnEditFolderToolStrip.Click

        Try

            If TreeView1.Nodes.Count = 0 Then Exit Sub ' يقوم باالخروج من الدالة ولا تنفذ السطر الاسفل منها اذا لم يكن هناك اي عقدة على الشجرة 
            If TreeView1.SelectedNode.ImageIndex < 28 Then ' معنى هذا الشرط اني واق على مجلدات بنائا على رقم ايقونات المجلدات الموجوده في اداة قائمة الصور 

                Dim xx As New FrmAddFolders
                If xx.Visible = True Then xx.Visible = False ' يعمل على اغلاق الواجهة اذا كانت مفتوحة لتجنب الخطأ
                xx.Id = Me.TreeView1.SelectedNode.Tag ' نسند رقم العقدة الحالية -الجدول- التي تم تحديدها وعمل تعديل عليها نسند رقمها الى متغير ايدي الموجود في شاشة اضافه المجدات لاستخدامه في جلب بيانات الملف للتعديل عليه ويكون جلب بيانات الملف عن طريق داله بيانات الملف في حدث تحميل الفورم 
                xx.ShowDialog() ' نعرض شاشه المجلدات

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnDeleteFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnDeleteFolderToolStrip.Click

        If TreeView1.Nodes.Count = 0 Then Exit Sub ' يقوم باالخروج من الدالة ولا تنفذ السطر الاسفل منها اذا لم يكن هناك اي عقدة على الشجرة 

        If TreeView1.SelectedNode.ImageIndex < 28 Then ' معنى هذا الشرط اني واق على مجلدات بنائا على رقم ايقونات المجلدات الموجوده في اداة قائمة الصور 

            Dim c As Int64 = Me.TreeView1.SelectedNode.GetNodeCount(False) ' هذه الدالة تقوم بارجاع عدد الابناء الخاص بالعقدة المستعلمة عنها 

            If c > 0 Then
                MessageBox.Show(" معذرة لايمكن حذف هذا المجلد قد يكون المجلد أب لمجلدات آخرى أو ملفات آخرى  ", " رسالة تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                If MessageBox.Show(" انت على وشك حذف حساب المجلد  " & Space(2) & Me.TreeView1.SelectedNode.Text & vbNewLine & " هل تود الإستمرار ؟ ", " رسالة تنبية ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    If cls.Delete_Folders(Me.TreeView1.SelectedNode.Tag) = 0 Then
                        Me.TreeView1.SelectedNode.Remove()

                    End If
                End If
            End If

        End If

    End Sub

    Private Sub btnExpandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnExpandToolStrip.Click
        ' زر عمل توسعة للشجرة
        btnExpandAll.PerformClick()

    End Sub

    Private Sub btnCollapseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnCollapseToolStrip.Click
        ' زر عمل طي للشجرة
        btnCollaps.PerformClick()

    End Sub

    Private Sub btnRefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnRefreshToolStrip.Click
        ' زر تحديث شجرة الأرشفة
        btnRefresh.PerformClick()

    End Sub

    Private Sub btnSendFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnSendFileToolStrip.Click
        If TreeView1.SelectedNode.ImageIndex >= 28 Then ' لان ايقونات المجلدات عددها 27 في قائمة الصور و صور الملفات تكون اكبر من او يساوي 28
            cls.CheckIFSelectedFileSecretBeforeSend(Me) ' Check IF Selected File Secret Before Send دالة التحقق من ان الملف المحدد محمي قبل الارسال الى شاشة الايميل 
        End If

    End Sub

    Private Sub FrmMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' we have to check Server Name before Load
        Me.Label2.Text = "المستخدم الحالي" & LogUserName '  لعرض المستخدم الحالي في الشاشة الرئيسية 
        cls.LoadArchiveTree(Me)  ' استدعاء اجراء عمل تحميل لشجرة الارشفة 
        cls.CreateTempFolder()  ' استدعاء اجراء انشاء ملف التيمب لفتح الملفات فيه
        If My.Settings.AutoBackup = 2 Then ' فحص اذا كان المتغير الخاص بالنسخ التلقائي يساوي 2 اي ان النسخ سيكون عبر الوقت المحدد بالساعات 
            Me.BackupTimer.Interval = My.Settings.BackTimerInterval ' لذلك سيقوم باسنداد قيمة الانترفل المخزنة ضمن متغير النظام الى الانترفل الخاص بالمؤقت الموجود في الاشاشة الرئيسية 
            Me.BackupTimer.Enabled = True ' ويقوم بتفعيل المؤقت 
        End If


    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            cls.SearchInArchiveTree(Me.txtsearch, dgv_Files) ' استدعاء دالة البحث
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub TreeView1_DoubleClick(sender As Object, e As EventArgs) Handles TreeView1.DoubleClick
        If TreeView1.SelectedNode.ImageIndex >= 28 Then ' becouse the icon of folder = 27 in image list and of file >= 28
            ' لان ايقونات المجلدات عددها 27 في قائمة الصور و صور الملفات تكون اكبر من او يساوي 28
            'cls.CheckIFSelectedFileSecret(Me) ' قم بعمل فحص للملف اذا كان يحتوي على كلمة سر او لا ومن ثم سيقوم بالفتح فاذا كان هناك كلمة سر يطلب ادخالها واذا لا يعرض مباشرة

            cls.CheckIFSelectedFileSecret(Me, True) ' قم بعمل فحص للملف اذا كان يحتوي على كلمة سر او لا ومن ثم سيقوم بالفتح فاذا كان هناك كلمة سر يطلب ادخالها واذا لا يعرض مباشرة  - القيمة الاخرى من تعديلي على البرنامج وفي حالة كانت صحيح اي 1 فالاختيار هنا سيكون فتح الملف ولو كانت خطأ اي 0 فالاختيار للتعديل 

        End If

    End Sub

    Private Sub btnOpenSelectedFile_Click(sender As Object, e As EventArgs) Handles btnOpenSelectedFileToolStrip.Click
        If TreeView1.SelectedNode.ImageIndex >= 28 Then ' becouse the icon of folder = 27 in image list and of file >= 28
            ' لان ايقونات المجلدات عددها 27 في قائمة الصور و صور الملفات تكون اكبر من او يساوي 28
            'cls.CheckIFSelectedFileSecret(Me) ' قم بعمل فحص للملف اذا كان يحتوي على كلمة سر او لا ومن ثم سيقوم بالفتح فاذا كان هناك كلمة سر يطلب ادخالها واذا لا يعرض مباشرة

            cls.CheckIFSelectedFileSecret(Me, True) ' قم بعمل فحص للملف اذا كان يحتوي على كلمة سر او لا ومن ثم سيقوم بالفتح فاذا كان هناك كلمة سر يطلب ادخالها واذا لا يعرض مباشرة  - القيمة الاخرى من تعديلي على البرنامج وفي حالة كانت صحيح اي 1 فالاختيار هنا سيكون فتح الملف ولو كانت خطأ اي 0 فالاختيار للتعديل 

        End If
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown

        If txtsearch.Text.Trim = String.Empty Then Exit Sub ' فحص هل حقل البحث فارغ  في حاله انه فارغ اخرج من الاجراء ولاتنفذ شي
        If e.KeyCode = Keys.Enter Then ' عد الضغط على انتر
            btnCollaps.PerformClick() ' لعمل طي للشجرة قبل عملية تحديد  العقدة وتوسيع الشجرة
            cls.FindSearchItem(dgv_Files, Me.TreeView1, Me.txtsearch) ' يعمل بحث عند النقر على انتر 
        ElseIf e.KeyCode = Keys.Down Then  ' عند الضغط على سهم الاسفل
            dgv_Files.Focus() ' يعمل تحديد على الداتا جردي فيو 
        End If

    End Sub


    Private Sub dgv_Files_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Files.CellClick

        If e.ColumnIndex = -1 Then Exit Sub '  اذا كان لايوجد اي عمود في الداتا جريد فيو  اغلق الدالة 
        If Me.dgv_Files.Columns(e.ColumnIndex).Name = "xName" Then  ' فحص اذا تم عمل كلك او نقر على الاسم الخاص بالخلية هل مساوي للعمود الذي انشاناه في الداتا جردي 
            btnCollaps.PerformClick() ' لعمل طي للشجرة قبل عملية تحديد  العقدة وتوسيع الشجرة
            cls.FindSearchItem(dgv_Files, Me.TreeView1, Me.txtsearch) ' يستدعي اجراء البحث 
        End If

    End Sub


    Private Sub dgv_Files_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_Files.KeyDown

        If e.KeyCode = Keys.Enter Then ' عد الضغط على انتر
            btnCollaps.PerformClick()  ' لعمل طي للشجرة قبل عملية تحديد  العقدة وتوسيع الشجرة
            cls.FindSearchItem(dgv_Files, Me.TreeView1, Me.txtsearch) ' يعمل بحث عند النقر على انتر 
        End If

    End Sub

    Private Sub btnAddFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnAddFileToolStrip.Click

        Try

            If TreeView1.SelectedNode.ImageIndex < 28 Then ' معنى هذا الشرط اني واق على مجلدات بنائا على رقم ايقونات المجلدات الموجوده في اداة قائمة الصور 
                ' لان اضافه الملف ستكون الى مجلد وليس الى ملف 

                Dim xx As New FrmAddfiles
                If xx.Visible = True Then xx.Visible = False ' يعمل على اغلاق الواجهة اذا كانت مفتوحة لتجنب الخطأ
                xx.Show(Me)
                xx.btnNew.PerformClick() ' 
                If TreeView1.Nodes.Count = 0 Then Exit Sub ' يقوم باالخروج من الدالة ولا تنفذ السطر الاسفل منها اذا لم يكن هناك اي عقدة على الشجرة 


                cls.GetParentNode(xx.FolderParent.Nodes, CStr(Me.TreeView1.SelectedNode.Tag), xx.FolderParent) ' هذه الداله تجلب رقم المجلد الاب في الشجرة عند التحديد على والنقر اضافه مجلد الى الكموبوكس تري في شاشه اضافه المجلد لكي يكون اب للمجلد الجديد افتراضيا  
                ' نمرر للداله جميع العقد الموجودة في الشجرة و رقم العقدة التي تم التحديد عليها لاضافه المجلد فيها وثم نمرر الكمبوبوكس الشجري الموجود في فورم اضافة الملفات

                xx.FileCode.Text = cls.GetFileCode(xx.FolderParent.SelectedNode.Tag) ' هذه الدالة تقوم بجلب اعلى رقم ملف موجود في هذا المجلد لكي يكون رقم الملف الجديد الذي سيتم اضافته وتخزنه في رقم الملف في شاشه اضافة الملفات تلقائيا 


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUpdateFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnUpdateFileToolStrip.Click

       
           
        If TreeView1.SelectedNode.ImageIndex >= 28 Then  ' becouse the icon of folder = 27 in image list and of file >= 28
            ' لان ايقونات المجلدات عددها 27 في قائمة الصور و صور الملفات تكون اكبر من او يساوي 28

            ClearWebBrowser() ' تنظيف لأداة العرض الخاصة بالملفات
            cls.CheckIFSelectedFileSecret(Me, False) ' قم بعمل فحص للملف اذا كان يحتوي على كلمة سر او لا ومن ثم سيقوم بالفتح فاذا كان هناك كلمة سر يطلب ادخالها واذا لا يعرض مباشرة  - القيمة الاخرى من تعديلي على البرنامج وفي حالة كانت صحيح اي 1 فالاختيار هنا سيكون فتح الملف ولو كانت خطأ اي 0 فالاختيار للتعديل 

            ' تم نقل هذا الكود الى داخل الداله التي في الاعلى 

            'If MessageBox.Show("هل تود تنفيذ عملية التعديل ؟", "رسالة تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            '    ClearWebBrowser() ' تنظيف لأداة العرض الخاصة بالملفات
            '    Dim xx As New FrmAddfiles ' عمل كائن من نوع شاشة اضافة الملفات
            '    xx.XFileCode = Me.TreeView1.SelectedNode.Tag ' قم بجعل قيمة متغير رقم الملف تساوي قيمة رقم الملف الذي تم التحديد عليه في الشجرة لاجراء التعديل عليه وذلك لكي يحمل الملف ويعرض مع جميع تفاصيله في الواجهة الخاصة باضافه الملفات عند النقر على التعديل
            '    xx.ShowDialog() ' عرض الشاشة
            'End If

        End If
    End Sub

    Private Sub btnDeleteFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnDeleteFileToolStrip.Click
        If MessageBox.Show("  انت على وشك حذف الملف [ " & Space(2) & Me.TreeView1.SelectedNode.Text & " ] هل تود الاستمرار ؟ ", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            DeleteRecourd("Files", "FileCode", Me.TreeView1.SelectedNode.Tag) 'دالة الحذف ونمرر لها اسم الجدول وسم العمود ورقم الملف وهو المخزن في خاصية التاج الخاصة بتحديد العقدة   
            TreeView1.SelectedNode.Remove() ' قم بعمل حذف للعقدة من الشجرة 
            Me.WebBrowser1.DocumentText = Nothing
        End If
    End Sub

    Private Sub btnCopyFile_Click(sender As Object, e As EventArgs) Handles btnCopyFileToolStrip.Click
        If TreeView1.SelectedNode.ImageIndex >= 28 Then  ' becouse the icon of folder = 27 in image list and of file >= 28
            ' لان ايقونات المجلدات عددها 27 في قائمة الصور و صور الملفات تكون اكبر من او يساوي 28

            cls.GetCopyOfFile(Me) ' استدعاء اجراء القيام بنسخ الملف الى اي مسار يحدده المستخدم

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex

            Case 0
                PictureBox3.SizeMode = PictureBoxSizeMode.Normal
            Case 1
                PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
            Case 2
                PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
            Case 3
                PictureBox3.SizeMode = PictureBoxSizeMode.CenterImage
            Case 4
                PictureBox3.SizeMode = PictureBoxSizeMode.Zoom

        End Select
    End Sub


    Private Sub FrmMainPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '' تم استخدام الثريد لكي يتم حل مشكلة ظهور الاخطاء عند حذف الملفات من المجلد المؤقت فالثريد الاول ينظف المتصفح من اي ملف مفتوح وهو سبب ظهور الخطأ  
        '' والثريد الثاني يقوم بعملية الحذف للملفات الموجودة في المجلد المؤقت  
        'Control.CheckForIllegalCrossThreadCalls = False
        'Dim Thr1 As Thread = New Thread(AddressOf ClearWebBrowser) ' عمل انشاء ثريد ونمرر له الداله التي نريد تنفيذها داخل هذا الثريد
        'Thr1.Start() ' تشغيل الثريد  رقم 1 
        'Dim Thr2 As Thread = New Thread(AddressOf DeleteTempFiles) ' عمل انشاء ثريد ونمرر له الداله التي نريد تنفيذها داخل هذا الثريد
        'Thr2.Start() ' تشغيل الثريد رقم 2 
        '' الى هنا يتم تنفيذ الاثنين الثريد في نفس الوقت ولكن سوف نحصل على نفس المشكلة كون ان الملف الى الان مفتوح والاثنين يشتغلو بنفس الوقت 
        '' ولحل هذه المشكلة نستخدم السطر هذا ووظيفتها  هي عمل بلوك او ايقاف لجميع الثريد الاخرى الموجودة لغايه ان ينتهي الثريد تبعها او الذي استدعاها ومن ثم عند الانتهاء يشتغل بقيه الثريد 
        'Thr1.Join() ' تعمل على تجميد بقيه الثريد الى حين انتهاء تنفيذ الثريد الذي استدعاها 

        'Application.Exit()
    End Sub

    ' حدث يتنفذ اثناء ظهور اة فتح المينيو ستريب
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        ' هذا العمل لتنظيم ظهور عناصر القائمة عن التحديد على مجلد او ملف ويتم ذك عن طريق بناء عناصر القائمة عبر الكود في هذا الحدث او التحكم بالظهور الخاص بالعناصر 

        If TreeView1.SelectedNode.ImageIndex < 28 Then ' becouse the icon of folder = 27 in image list and of file >= 28
            ' لان ايقونات المجلدات عددها 27 في قائمة الصور و صور الملفات تكون اكبر من او يساوي 28


            Me.btnAddFolderToolStrip.Visible = True
            Me.btnEditFolderToolStrip.Visible = True
            Me.btnDeleteFolderToolStrip.Visible = True
            Me.ToolStripSeparator1.Visible = True
            ' -----------------------------------
            Me.btnOpenSelectedFileToolStrip.Visible = False
            Me.ToolStripSeparator2.Visible = False
            ' -----------------------------------
            Me.btnAddFileToolStrip.Visible = True
            Me.btnUpdateFileToolStrip.Visible = False
            Me.btnDeleteFileToolStrip.Visible = False
            Me.ToolStripSeparator3.Visible = True
            ' -----------------------------------
            Me.btnCopyFileToolStrip.Visible = False
            Me.ToolStripSeparator4.Visible = False
            ' -----------------------------------
            Me.btnExpandToolStrip.Visible = True
            Me.btnCollapseToolStrip.Visible = True
            Me.ToolStripSeparator5.Visible = True
            ' -----------------------------------
            Me.btnRefreshToolStrip.Visible = True
            Me.ToolStripSeparator6.Visible = False
            ' -----------------------------------
            Me.btnSendFileToolStrip.Visible = False

        Else

            Me.btnAddFolderToolStrip.Visible = False
            Me.btnEditFolderToolStrip.Visible = False
            Me.btnDeleteFolderToolStrip.Visible = False
            Me.ToolStripSeparator1.Visible = False
            ' -----------------------------------
            Me.btnOpenSelectedFileToolStrip.Visible = True
            Me.ToolStripSeparator2.Visible = True
            ' -----------------------------------
            Me.btnAddFileToolStrip.Visible = False
            Me.btnUpdateFileToolStrip.Visible = True
            Me.btnDeleteFileToolStrip.Visible = True
            Me.ToolStripSeparator3.Visible = True
            ' -----------------------------------
            Me.btnCopyFileToolStrip.Visible = True
            Me.ToolStripSeparator4.Visible = False
            ' -----------------------------------
            Me.btnExpandToolStrip.Visible = False
            Me.btnCollapseToolStrip.Visible = False
            Me.ToolStripSeparator5.Visible = False
            ' -----------------------------------
            Me.btnRefreshToolStrip.Visible = False
            Me.ToolStripSeparator6.Visible = True
            ' -----------------------------------
            Me.btnSendFileToolStrip.Visible = True

        End If

    End Sub


    
    Private Sub btnFolderDeletedPin_Click(sender As Object, e As EventArgs) Handles btnFolderDeletedPin.Click
        Try

            FrmCyclePin1.Show(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmMainPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' استدعاء اجراء عمل النسخ الاحتياطي عند اغلاق النظام
        cls.EnableBackupAtCloseingSystem()

        ' تم استخدام الثريد لكي يتم حل مشكلة ظهور الاخطاء عند حذف الملفات من المجلد المؤقت فالثريد الاول ينظف المتصفح من اي ملف مفتوح وهو سبب ظهور الخطأ  
        ' والثريد الثاني يقوم بعملية الحذف للملفات الموجودة في المجلد المؤقت  
        Control.CheckForIllegalCrossThreadCalls = False
        Dim Thr1 As Thread = New Thread(AddressOf ClearWebBrowser) ' عمل انشاء ثريد ونمرر له الداله التي نريد تنفيذها داخل هذا الثريد
        Thr1.Start() ' تشغيل الثريد  رقم 1 
        Dim Thr2 As Thread = New Thread(AddressOf DeleteTempFiles) ' عمل انشاء ثريد ونمرر له الداله التي نريد تنفيذها داخل هذا الثريد
        Thr2.Start() ' تشغيل الثريد رقم 2 
        ' الى هنا يتم تنفيذ الاثنين الثريد في نفس الوقت ولكن سوف نحصل على نفس المشكلة كون ان الملف الى الان مفتوح والاثنين يشتغلو بنفس الوقت 
        ' ولحل هذه المشكلة نستخدم السطر هذا ووظيفتها  هي عمل بلوك او ايقاف لجميع الثريد الاخرى الموجودة لغايه ان ينتهي الثريد تبعها او الذي استدعاها ومن ثم عند الانتهاء يشتغل بقيه الثريد 
        Thr1.Join() ' تعمل على تجميد بقيه الثريد الى حين انتهاء تنفيذ الثريد الذي استدعاها 

        'Application.Exit()
    End Sub

    Private Sub BackupTimer_Tick(sender As Object, e As EventArgs) Handles BackupTimer.Tick
        cls.EnableBackupPerHours(BackupTimer) ' استدعاء اجراء الذي يقوم بتفعيل النسخ الاحتياطي حسب الوقت المعين  
    End Sub
End Class
