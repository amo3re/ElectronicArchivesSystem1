Imports System.Net.Mail ' المكتبة التي سوف نستخدمها للتعامل مع الايميل
Imports System.Net ' 
Imports System.IO ' مكتبة التعامل مع الادخال والاخراج 

Public Class FrmEMail

    Dim cls As New ProjectClass ' تم تعريف كائن من الببلك كلاس لاستخدام الدوال المعرفه فيه 

    Public AttachPath As String = Nothing ' متغير سوف نستخدمه لتمرير المسار الذي سوف نعمل له ارسال وتضمينه كمرفق عند التحديد على الملف وعمل ارسال 

    ' تم نقل الدوال لصفحة البوبلك كلاس

    '' داله التنظيف للكنترول - الادوات 
    'Private Sub ClearMessageControls()
    '    Me.SenderAddress.Clear()
    '    Me.SenderAccPassword.Clear()
    '    Me.ReceiverAddress.Clear()
    '    Me.txtCopyTo.Clear()
    '    Me.txtHidenCopyTo.Clear()
    '    Me.txtSubject.Clear()
    '    Me.txtMessageBody.Clear()
    '    Me.AtatchName.Tag = Nothing ' نفرغ التاج لان فيها سيكون مسار الخاص بالملف 
    '    Me.AtatchName.Clear()
    '    Me.CombSMTPServers.SelectedIndex = 0 ' يحدد على اول عنصر في القائمة
    '    Me.btnSend.Enabled = True
    '    Me.SenderAddress.Focus()
    '    Me.CkShowHide.Checked = False
    '    Me.Ck1.Checked = False
    '    Me.Ck2.Checked = False
    'End Sub



    ' اجرائية ارسال الملفات عبر الايميل 

    '' Send Email Message داله ارسال الايميل
    'Public Sub Send_Email_Message()
    '    Try

    '        ' للتحقق من ادخال الحقول 
    '        If MyTextNull(Me.SenderAddress, "المرسل") Then Return
    '        If MyTextNull(Me.SenderAccPassword, "كلمة المرور") Then Return
    '        If MyTextNull(Me.ReceiverAddress, "المستلم") Then Return
    '        If MyCombIndexNull(Me.CombSMTPServers, "السيرفر") Then Return
    '        If MyCombIndexNull(Me.CombPorts, "البورت") Then Return
    '        If MyTextNull(Me.txtSubject, "عنوان الرسالة") Then Return
    '        If MyRichTextNull(Me.txtMessageBody, "نص الرسالة") Then Return


    '        Dim smtp = New SmtpClient(Me.CombSMTPServers.Text, Me.CombPorts.Text.Trim) ' نعرف كائن من كلاس اسمتيبي كلاينت ونمرر له السرفر المحدد و رقم البورت
    '        smtp.EnableSsl = True ' نفعل  خاصية ال ssl لتشفير عملية الارسال
    '        smtp.UseDefaultCredentials = False ' نجعل خاصية اوراق الاعتماد الافتراضية ب 0 اي غير مفعلة لكي لانرسل عبر الافتراضي 
    '        smtp.Credentials = New NetworkCredential(Me.SenderAddress.Text, Me.SenderAccPassword.Text) ' نجعل اوراق الاعتماد تاخذ تستخدم اوراق الاعماد عبر الانترنت ونمرر له البريد المرسل و كلمة السر  لكي يقوم بالتحقق من ان المرسل هو صاحب الحساب الحقيقي
    '        Dim MailMessage = New MailMessage(Me.SenderAddress.Text, Me.ReceiverAddress.Text, Me.txtSubject.Text, Me.txtMessageBody.Text) ' اجراء الارسال الموجود في الكلاس ضمن المكتبة المضمنة في الاعلى ونمرر له بريد المرسل و بريد المستقبل والموضوع الخاص بالرسالة و نص الرسالة
    '        MailMessage.Priority = MailPriority.High ' اعطاء الاولوية لهذه الرسالة ونجعلها عالية

    '        If Ck1.Checked And Me.txtCopyTo.Text.Trim <> String.Empty Then MailMessage.CC.Add(Me.txtCopyTo.Text) ' في حال كان مربع الاختيار الخاص ب نسخة الى محدد وايضا حقل البريد الخاص به ليس فارغا سوف يرسل نسخة كاربونية للبريد عبر خاصية سس ونمرر لها البريد الموجود في الحقل   ولكن في الحاله هذه سيعرف المستقبل انه تم عمل نسخة كربونية لبريد اخر 
    '        If Ck2.Checked And Me.txtHidenCopyTo.Text.Trim <> String.Empty Then MailMessage.Bcc.Add(Me.txtHidenCopyTo.Text) ' في حال كان مربع الاختيار الخاص ب نسخة مخفية الى محدد وايضا حقل البريد الخاص به ليس فارغا سوف يرسل نسخة كاربونية للبريد عبر خاصية ب سس ونمرر لها البريد الموجود في الحقل   ولكن في الحاله هذه لن يعرف المستقبل انه تم عمل نسخة كربونية لبريد اخر لانه تم استخدام خاصية النسخ المخفي 

    '        ' في حاله وجود مرفق
    '        If String.IsNullOrEmpty(Me.AtatchName.Tag) = False Then ' اذا كان خاصية التاج الخاصة باسم مرفق الملف ليست فارغه - حيث  اننا نخزن فيها مسار الملف
    '            Dim attach = New Attachment(Me.AtatchName.Tag) ' نقوم بإرفاق ملف من خلال كلاس المرفقات ونمرر له المسار الموجود في خاصية التاج الخاصه باسم الملف  
    '            MailMessage.Attachments.Add(attach) ' ونقوم باضافتها مع البيانات التي سوف ترسل عبر الميل مسج
    '        End If


    '        MailMessage.IsBodyHtml = True ' الفورمات الخاص بالرسالة التي سوف ترسل تصاغ ب لغة html
    '        smtp.Send(MailMessage) ' نقوم بالارسال عبر داله الارسال

    '        ' نظهر رسالة ان الارسال نجح 
    '        MessageBox.Show("تم إرسال الرساله بنجاح", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    Catch ex As Exception
    '        ' في حاله وجود خطأ ستظهر رسالة الخطأ
    '        MessageBox.Show(ex.Message, "رسالة تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
    '    End Try
    'End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ' ClearMessageControls()
        cls.ClearMessageControls(Me)
    End Sub


    Private Sub ComboSMTPServers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CombSMTPServers.SelectedIndexChanged
        ' لكي نظهر  رقم البورت بنائا على اختيار السرفر 
        If CombSMTPServers.SelectedIndex = 0 Then
            CombPorts.SelectedIndex = 0
        Else
            CombPorts.SelectedIndex = 1
        End If

    End Sub

    Private Sub FrmEMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNew.PerformClick() '
        Me.AtatchName.Tag = AttachPath ' تخزين مسار الملف في خاصية التاج الخاصة باسم المرفق 
        Me.AtatchName.Text = Path.GetFileName(AttachPath) '  ياخذ فقط من المسار الاسم مع الامتداد ويعرضه في مربع النص الخاص بالمرفقات
    End Sub


    Private Sub Ck1_CheckedChanged(sender As Object, e As EventArgs) Handles Ck1.CheckedChanged

        If Ck1.Checked Then
            Me.txtCopyTo.Enabled = True
            Me.txtCopyTo.Focus()
            Me.txtCopyTo.BackColor = Color.FromName("White")
        Else
            Me.txtCopyTo.Enabled = False
            Me.txtCopyTo.Clear()
            Me.txtCopyTo.BackColor = Color.FromName("Control")
        End If


    End Sub

    Private Sub Ck2_CheckedChanged(sender As Object, e As EventArgs) Handles Ck2.CheckedChanged
        If Ck2.Checked Then
            Me.txtHidenCopyTo.Enabled = True
            Me.txtHidenCopyTo.Focus()
            Me.txtHidenCopyTo.BackColor = Color.FromName("White")
        Else
            Me.txtHidenCopyTo.Enabled = False
            Me.txtHidenCopyTo.Clear()
            Me.txtHidenCopyTo.BackColor = Color.FromName("Control")
        End If
    End Sub

    Private Sub SenderAddress_Enter(sender As Object, e As EventArgs) Handles SenderAddress.Enter
        ChangeToEnglish() ' لتغيير نمط الكتابة الى الانجليزية تلقائيا عند الدخول للحقل 
    End Sub

    Private Sub SenderAccPassword_Enter(sender As Object, e As EventArgs)
        ChangeToEnglish() ' لتغيير نمط الكتابة الى الانجليزية تلقائيا عند الدخول للحقل 

    End Sub

    Private Sub ReceiverAddress_Enter(sender As Object, e As EventArgs) Handles ReceiverAddress.Enter
        ChangeToEnglish() ' لتغيير نمط الكتابة الى الانجليزية تلقائيا عند الدخول للحقل 

    End Sub

    Private Sub CkShowHide_CheckedChanged(sender As Object, e As EventArgs) Handles CkShowHide.CheckedChanged
        If CkShowHide.Checked = True Then
            SenderAccPassword.UseSystemPasswordChar = False
            Me.CkShowHide.Text = "إخفاء"
        Else
            SenderAccPassword.UseSystemPasswordChar = True
            Me.CkShowHide.Text = "إظهار"
        End If
    End Sub

    Private Sub btnAddAttaches_Click(sender As Object, e As EventArgs) Handles btnAddAttaches.Click
        Dim OFD = New OpenFileDialog()
        If OFD.ShowDialog() = DialogResult.OK Then
            AtatchName.Tag = OFD.FileName
            AtatchName.Text = Path.GetFileName(OFD.FileName)
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        ' اجرائية ارسال الملفات عبر الايميل
        ' Send_Email_Message()
        cls.Send_Email_Message(Me)
    End Sub


End Class