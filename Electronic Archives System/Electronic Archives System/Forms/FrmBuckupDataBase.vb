Public Class FrmBuckupDataBase

    Dim cls As New ProjectClass
    Dim dt As New DataTable


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClearConfirmMessageTools(Me.lblConfirmMsg, Me.PicMessage, Me.Timer1)
        ' تنظيف الرسائل بعد ظهورها
    End Sub

    Private Sub FrmBuckupDataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.LoginMothed <> 3 Then ' اذا كانت طريقة الدخول ليست عن طريق الاستضافة 
            dt = cls.ReturnNameOFDataBasesAsDataTable() ' يتم استدعاء داله جلب اسماء قواعد البيانات كجدول 
            Me.CombBackupDB.DataSource = dt ' ونسندها للكمبوبوكس الخاص باسم قاعدة البيانات لعمل النسخ الاحتياطي 
            Me.CombBackupDB.DisplayMember = "name" ' يتم اسناد قيمة الاسم لقيمة العرض الخاص بالكمبوبوكس
            Me.CombRestoreDB.DataSource = dt ' ونسندها للكمبوبوكس الخاص باسم قاعدة البيانات لعمل الاستعادة 
            Me.CombRestoreDB.DisplayMember = "name" ' يتم اسناد قيمة الاسم لقيمة العرض الخاص بالكمبوبوكس
        End If
        cls.LoadBackupSettings(Me) ' استدعاء داله تحميل اعدادات النسخ الاحتياطي التلقائي  

    End Sub

    Private Sub btnGetPath3_Click(sender As Object, e As EventArgs) Handles btnGetPath3.Click
        Dim fbd As New FolderBrowserDialog ' نعرف كائن فتح دايلوج استعراض الملفات 
        If fbd.ShowDialog = DialogResult.OK Then ' في حاله تم عرض الدايلوج واختيار مجلد كمسار لحفظ النسخ الاحتياطية إلية 
            Me.txtMainBackupPath.Text = fbd.SelectedPath ' نسند هذا المسار الذي تم اختياره لمربع النص الخاص بمسار حفظ النسخ الاحتياطية
        End If
    End Sub

    Private Sub rbPerHours_CheckedChanged(sender As Object, e As EventArgs) Handles rbPerHours.CheckedChanged
        If Me.rbPerHours.Checked = True Then Me.NumOfHours.Enabled = True Else Me.NumOfHours.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cls.SaveBackupSettings(Me) ' استدعاء اجراء حفظ اعدادات النسخ الاحتياطي
    End Sub

    Private Sub ckAppendTo_CheckedChanged(sender As Object, e As EventArgs) Handles ckAppendTo.CheckedChanged
        If Me.ckAppendTo.Checked Then Me.ckOverwrite.Checked = False
    End Sub

    Private Sub rbToExisting_CheckedChanged(sender As Object, e As EventArgs) Handles rbToExisting.CheckedChanged
        If rbToExisting.Checked Then
            Me.ckOverwrite.Enabled = True
            Me.ckAppendTo.Enabled = True
            Me.ckAppendTo.Checked = True
            Me.ckOverwrite.Checked = False
        Else
            Me.ckOverwrite.Enabled = False
            Me.ckAppendTo.Enabled = False
        End If

    End Sub

    Private Sub ckOverwrite_CheckedChanged(sender As Object, e As EventArgs) Handles ckOverwrite.CheckedChanged
        If Me.ckOverwrite.Checked Then Me.ckAppendTo.Checked = False
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim BackupOption As String = Nothing ' نعرف متغير خيار النسخ
        Dim BackupPath As String = My.Settings.BackupPath ' نعرف متغير مسار النسخ ونسند له مسار السخ الموجود في  النظام 
        Dim Backuptype As Short = My.Settings.BackupType ' نعرف متغير نوع النسخ ونسند له  نوع النسخ الموجود في متغير النظام 
        Dim IsBackupSucceed As Boolean = False ' نعرف متغير هل النسخ صحيح ويكون من نوع بولين اما صفر او واحد 

        If String.IsNullOrEmpty(BackupPath) Then ' نفحص في حال كان المتغير فارغ نظهر رساله تفيد بوضع مسار للنسخ اليه
            MessageBox.Show("من فضلك اختر مسار لحفظ النسخ الإحتياطي", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return ' نقوم بالخروج من الاجراء 
        End If

        If My.Computer.FileSystem.FileExists(BackupPath) = False Then System.IO.Directory.CreateDirectory(BackupPath) ' فحص في حاله اذا لم يكن المجلد المحدد كمسار غير موجود يقوم بإنشاءه
        If Me.rbToExisting.Checked AndAlso Me.ckAppendTo.Checked Then ' في حاله كا الخيار الاول مؤشر مع الشك بوكس حق التضمين مع المجوعة 
            BackupOption = "NOFORMAT, NOINIT, SKIP" ' جعل قيمة خيار النسخ هكذا
        ElseIf Me.rbToExisting.Checked AndAlso Me.ckOverwrite.Checked Then ' في حال كان الخيار الاول مؤشر مع خيار اعاجة الكتابة
            BackupOption = "NOFORMAT, INIT, SKIP" '  جعل قيمة خيار النسخ هكذا
        ElseIf Me.rbToNew.Checked Then ' في حال كان الخيار الخاص بعمل نسخ الى وسائط جديدة مفعل
            BackupOption = "FORMAT, INIT, SKIP" ' جعل قيمة خيار النسخ هكذا
        End If

        IsBackupSucceed = cls.BackupDataBase(Con(), Me.CombBackupDB.Text, BackupPath, BackupOption, Backuptype) ' نسند للمتغير داله النسخ الاحتياطي لقاعدة البيانات ونرسل لها الاتصال واسم القاعدة ومسار النسخ وخيار النسخ ونوع النسخ 
        If IsBackupSucceed = True Then ' في حال تم ارجاع قيمة  ان النسخ صحيح يقوم بطباعة رسالة النجاح 
            ConfirmMessage(Me.lblConfirmMsg, Me.PicMessage, Me.Timer1, "تم عمل نسخة إحتياطية بنجاح ")
        End If

    End Sub
End Class