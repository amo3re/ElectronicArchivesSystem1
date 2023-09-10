Imports System.IO ' استخدام الادخال والاخراج 
Imports System.Data.SqlClient ' اسخدام مكاتب الاتصال

Public Class FrmCyclePin1
    Dim cls As New ProjectClass ' تعريف الكلاس الخاص بجميع الاكواد
    Dim DT, dtFolders As New DataTable ' تعريف جداول
    Dim zz As Short = 0 ' متغير لمعرفة هل تمت عملية حذف الملف ام لا


    '  حدث يشتغل عندما تقلع الفورم
    Private Sub FrmCyclePin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Try

        '    dtFolders = GetDataTable("SelectFolderTree", Nothing) ' استدعاء اجراء تنفيذ الاجراء المخزن لاستدعاء اجراء جلب المجدات 
        '    cls.FillDataGridViewComboBoxFromDataTable(Me.dgvFolders, "FolderName", "FolderNumber", dtFolders) ' اجراء يقوم بتعبئة  الكمبو بوكس الخاص بالداتا جريد فيو ببيانات المجلد الاب ونمرر له اسم عمود الكمبوبوكس الموجود في الداتا جريد واسم عمود اسم الجلدات و رقم المجلدات و الداتا تيبل المعرف بالاعلى

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        'End Try


    End Sub


    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Try

            DT = GetDataTable("SelectDeletedFolders", Nothing) ' استدعاء اجراء تنفيذ الاجراء المخزن
            Me.dgv.AutoGenerateColumns = False ' اغلاق خاصية الداتا جريد فيو التي تعمل على التوليد التلقائي للاعمدة 
            Me.dgv.DataSource = DT ' نجعل مصدر الداتا جريد فيو من الجدول
            Me.lblCount.Text = dgv.Rows.Count ' عدد الملفات ياخد من عدد سجلات الداتا جريد فيو 

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    ' حدث يتنفذ عند اغلاق الفورم وقمنا بعمل حذف لبيانات الجداول المخزنة فيها البيانات لتحرير الذاكرة 
    Private Sub FrmCyclePin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DT.Dispose()
        dtFolders.Dispose()
        dgv.DataSource = Nothing
    End Sub


    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

        Try

            If e.ColumnIndex = -1 Or dgv.Rows.Count = 0 Then Return '  اذا لا توجد بيانات في الداتا جريد فيو او لايوجد صفوف في الداتا جريد فيو يخرج من الاجراء لتجنب الاخطاء

            If Me.dgv.CurrentCell.ColumnIndex = 4 Then ' اذا كان الضغط على الخلية 4 وهي بوتن الحذف نهائيا

                If MessageBox.Show(" هل تود حذف الملف " & vbNewLine & "[" & dgv.CurrentRow.Cells(2).Value & " ] بشكل نهائي ؟ ", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then ' اذا كانت نتيجة الرسالة هي نعم يقوم بالتالي
                    zz = cls.DeleteFoldersFromDataBase(CInt(dgv.CurrentRow.Cells(0).Value)) ' نقوم باستدعاء اجراء حذف الملف من قاعدة البيانات وتمرير له قيمة الخلية 0 وهي ايدي المخفية بعد تحويلها الى عدد صحيح والقيمة الثانية هي قيمة الخلية 7 وهي قيمة مكان الحفظ ويحولها ل بولين
                    ' ترجع الدالة السابقة 1 اذا تم الحذف الملف من قاعدة البيانات و 0 اذا لم يتم الحذف وهذا يعين ان الملف على الجهاز وتخزن هنا في المتغير zz
                    If zz <> 1 Then Return ' اذا كانت القيمة لاتساوي 1 الملف ليس في قاعدة البيانات اخرج من الاجراء كامل او الاف الشرطية الخاصة برسالة الحذف واذا كانت القيمة تساوي 1 استمر بباقي الكود
                    ' سبب الخروج اذا كانت القيمة لاتساوي 1 اي انها 0 هو لان الملف ليس موجود على قاعدة البيانات فلم يستطع حذفه فيقوم باكمال الكود لحذف الملف من الجهاز 

                    Dim xFolderPath As String  ' تعريف متغيرين الاول لمسار المجلد والثاني لاسم الملف
                    'xFileName = dgv.CurrentRow.Cells(1).Value   ' نسند لمتغير اسم الملف = قيمة الخلية رقم 2 وهي تحدد اسم الملف وقيمة الخلية رقم 5 وهي تحدد الامتداد
                    xFolderPath = My.Settings.FilePath & "\Archived Files\" & dgv.CurrentRow.Cells(1).Value   ' نسند لمتغير مسار المجلد الاب = اسم القرص المخزن في متغير الاعدادت + اسم مجلد البرنامج مع السلاشات السابقة والاحقه + قيمة الخلية 3 وهي اسم المجلد الاب + باك سلاش اخيره
                    'File.Delete(xFolderPath)  ' نستدعي داله حذف الملف من كلاس الملف من مكتبة الانبوت والاوتبوت لعمل حذف للملف من الجهاز ونمرر لها مسار الملف وهو لدينا في متغير مسار المجلد الاب + متغير اسم الملف 
                    DeleteFolders(xFolderPath)  ' قم باستدعاء داله حذف المجلدات مع الملفات - الموجودة في كلاس المديول العام الذي انشأناه - ويعمل على حذف الملفات التي بداخل المسار الخاص بالملف والمجلد يكون بدخله ملفات المرفقات اذا وجد مرفقات للملف ونمرر لها مسار الملف وهو لدينا في قيمة مسار المجلد الاب + قيمة الخلية 0 وهي قيمة الفايل ايدي المخفية لان ملفات المرفقات تكون جدول برقم الملف الاساسي
                    'End If
                    ' اذا كانت قيمة المتغير تساوي 1 اي انه تم الحذف نقوم بالتالي 
                    dgv.Rows.RemoveAt(dgv.CurrentRow.Index) ' قم بحذف السجل من الداتا جريد فيو
                    ConfirmMessage(Me.lblconfirmMessage, Me.PicMessage, Me.Timer1, " تم الحذف بنجاح ") ' وقم باظهار رسالة تم الحذف
                End If
                ' هنا نهاية شرط هل تريد الحذف نهائيا 

            ElseIf Me.dgv.CurrentCell.ColumnIndex = 5 Then ' هنا فحص الشرط هل تم الضغط على الخلية رقم 5 وهي البوتن الذي  تحدد الاستعادة
                If MessageBox.Show(" هل تود استعادة الملف " & vbNewLine & "[" & dgv.CurrentRow.Cells(2).Value & " ] ؟ ", "استعادة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then ' رساله تبين تاكيد هل تريد الاستعادة اذا كان نعم قم بعمل التالي
                    ReturnRecord("Folders", "FolderID", dgv.CurrentRow.Cells(0).Value.ToString()) ' قم باستدعاء اجراء اعادة السجل وتقوم بتمرير قيمة الفولدر ايدي المخفية 
                    dgv.Rows.RemoveAt(dgv.CurrentRow.Index) ' قم بحذف السجل من الداتا جريد فيو
                    ConfirmMessage(Me.lblconfirmMessage, Me.PicMessage, Me.Timer1, " تم الاستعادة بنجاح ") ' وقم باظهار رسالة تم الاستعادة بنجاح

                End If
                ' نهاية شرط رسالة الاستعادة
            End If
            ' نهاية شرط الضغط على الخلية رقم 5 و رقم 4


            Me.lblCount.Text = dgv.Rows.Count  ' هنا نقوم باسناد عدد الصفوف الى المتغير الخاص بعدد الملفات 


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnRestoreAll_Click(sender As Object, e As EventArgs) Handles btnRestoreAll.Click
        cls.ReturnAllFolders(Me) ' اجراء استعادة كل الجداول دفعة واحدة
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        cls.DeleteAllFolders(Me)  ' اجراء افراغ كل الجداول دفعة واحدة
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            cls.Search_InDataGridViewFolders(Me, DT) ' اجراء البحث عن الجداول في الشجرة  ونمرر له الواجهة و الجدول الذي فيه الجداول المحذوفة مبدئيا
        Catch ex As Exception
            Return
        End Try
    End Sub

    ' 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClearConfirmMessageTools(Me.lblconfirmMessage, Me.PicMessage, Me.Timer1)
    End Sub
End Class