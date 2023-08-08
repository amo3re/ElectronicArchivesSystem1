Imports System.Data.SqlClient
Imports System.IO

Module PublicModule



#Region " Public variable المتغيرات العامة "

    Public LogUserID As Int16 = 1
    Public LogUserName As String = " المهندس عمر "
    Public ScanTo As Short = 0

#End Region

#Region "Load Data"

    'Fill Data Tables اجرائية تعبةالداتا تيبل ببيانات جدول ما 
    Public Sub FillDataTable(ByVal DT As DataTable, ByVal SqlSt As String)
        Try

            Dim da As SqlDataAdapter
            da = New SqlDataAdapter(SqlSt, Con)
            DT.Clear()
            da.Fill(DT)
            da.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    ' اجراء ضبط ازرار التنقل و ازرار الاختصارات 
    Public Sub keyBoardAbbreviatios(ByVal e As KeyEventArgs, ByVal btnNew As ToolStripButton, ByVal btnSave As ToolStripButton, ByVal btnEdit As ToolStripButton, ByVal btnDelete As ToolStripButton, ByVal btnClose As ToolStripButton)

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then ' عد الضغط على انتر
            SendKeys.Send("{Tab}")
            e.Handled = False

            'ElseIf e.KeyCode = Keys.Up Then  ' عند الضغط على سهم الاعلى
            '    Me.SelectNextControl(Me.ActiveControl, False, True, False, True)


            ' اختصارات في الشاشة لزر الجديد والحفظ والتعديل والحذف والاغلاق 
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then ' عند الضغط على كنترول + N
            btnNew.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then ' عند الضغط على كنترول + S
            btnSave.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then ' عند الضغط على كنترول + E
            btnEdit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then ' عند الضغط على كنترول + D
            btnDelete.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.Q Then ' عند الضغط على كنترول + Q
            btnClose.PerformClick()

        End If
    End Sub

#End Region

#Region "Procedures for moving between records اجرائيات التنقل بين السجلات"
    ' اجرائيات التنقل بين السجلات

    'Load Ids of Records اجرائية الحصول على عدد السجلات ووضعها في لايبل للعرض 
    Public Sub GetIDOFRecords(ByVal DT As DataTable, ByVal TableName As String, ByVal IDColumn As String, ByVal txt As ToolStripTextBox, ByVal str As String)
        DT.Clear()
        Dim sqlst As String
        sqlst = " SELECT " & IDColumn & " From " & TableName & " WHERE ( IsDeleted = 'False' )"

        FillDataTable(DT, sqlst)

        If DT.Rows.Count > 0 Then
            txt.Text = str & Space(2) & DT.Rows.Count
        Else
            txt.Text = str & Space(2) & 0
        End If


    End Sub

    'first Record السجل الاول 
    Public Function MyfirstRecord(ByVal dt As DataTable, ByVal Frm As Form, ByRef TXT As ToolStripTextBox)
        Dim Count, Pos As String

        Frm.BindingContext(dt).Position = 0
        Count = dt.Rows.Count
        Pos = Frm.BindingContext(dt).Position + 1
        TXT.Text = Pos & Space(2) & " من " & Space(2) & Count
        Return Pos - 1

    End Function

    'Last Record السجل الاخير 
    Public Function MyLastRecord(ByVal dt As DataTable, ByVal Frm As Form, ByRef TXT As ToolStripTextBox)
        Dim Count, Pos As String

        Frm.BindingContext(dt).Position = dt.Rows.Count - 1
        Count = dt.Rows.Count
        Pos = Frm.BindingContext(dt).Position + 1
        TXT.Text = Pos & Space(2) & " من " & Space(2) & Count
        Return Pos - 1

    End Function

    'Next Record السجل التالي
    Public Function MyNextRecord(ByVal dt As DataTable, ByVal Frm As Form, ByRef TXT As ToolStripTextBox)
        Dim Count, Pos As String

        Frm.BindingContext(dt).Position += 1
        Count = dt.Rows.Count
        Pos = Frm.BindingContext(dt).Position + 1
        TXT.Text = Pos & Space(2) & " من " & Space(2) & Count
        Return Pos - 1

    End Function

    'Previouse Record السجل السابق
    Public Function MyPreviouseRecord(ByVal dt As DataTable, ByVal Frm As Form, ByRef TXT As ToolStripTextBox)
        Dim Count, Pos As String

        Frm.BindingContext(dt).Position -= 1
        Count = dt.Rows.Count
        Pos = Frm.BindingContext(dt).Position + 1
        TXT.Text = Pos & Space(2) & " من " & Space(2) & Count
        Return Pos - 1

    End Function

#End Region

#Region "Chaking Function دوال او اجرائيات التحقق او الفحص "

    'Function to check the text element is not empty اجراء فحص هل الحقل فارغ او لا 
    Public Function MyTextNull(ByVal TxT As TextBox, ByVal Caption As String) As Boolean
        If TxT.Text.Trim = Nothing Then ' اذا كان الحقل فارغ 
            MsgBox(" حقل ' " & Caption & " '  " & " فارغاٌ ", MsgBoxStyle.Information, " تأكيد الإدخال ")
            TxT.Text = Nothing
            TxT.Focus()
            Return True
        Else ' اذا كان الحقل ليس فارغ 
            ' TxT.Text = TxT.Text.Trim
            Return False

        End If

    End Function

    'Function to check the Rich Text Box element is not empty اجراء فحص هل مربع النص فارغ او لا 
    Public Function MyRichTextNull(ByVal TxT As RichTextBox, ByVal Caption As String) As Boolean
        If TxT.Text.Trim = Nothing Then ' اذا كان الحقل فارغ 
            MsgBox(" حقل ' " & Caption & " '  " & " فارغاٌ ", MsgBoxStyle.Information, " تأكيد الإدخال ")
            TxT.Text = Nothing
            TxT.Focus()
            Return True
        Else ' اذا كان الحقل ليس فارغ 
            ' TxT.Text = TxT.Text.Trim
            Return False

        End If

    End Function


    ' Chaking whether there is a item selected the combobox  اجراء يقوم بالتحقق انه تم اختيار عنصر في الكمبوبوكس او لا 
    Public Function MyCombIndexNull(ByVal Comb As ComboBox, ByVal CombCaption As String) As Boolean
        If Comb.SelectedIndex = -1 Then ' اي انه فارغ في بداية الامر
            MsgBox("يرجى اختيار" & Space(1) & "'" & CombCaption & "'", MsgBoxStyle.Information, "تأكيد الإدخال")
            Comb.Focus()
            Return True

        Else ' اذا كان يوجد اختيار في الكمبو بوكس
            Return False

        End If


    End Function


    Public Function MyComboTreeBoxNodeIsNull(ByVal ComboTree As ComboTreeBox, ByVal CombCaption As String) As Boolean

        If ComboTree.SelectedNode Is Nothing Then ' اي انه فارغ في بداية الامر
            MsgBox("يرجى اختيار" & Space(1) & "'" & CombCaption & "'", MsgBoxStyle.Information, "تأكيد الإدخال")
            'MessageBox.Show(" من فضلك اختر المجلد الاب للملف", "رساله تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboTree.Focus() '
            Return True
        Else ' اذا كان يوجد اختيار في الكمبو بوكس
            Return False

        End If
    End Function

    ' إجرائية ظهور الرسالة بعد حداث الحفظ والتعديل و الاضافه و ظهور الايقونة وتفعيل المؤقت 
    Public Sub ConfirmMessage(ByVal lbl As Label, ByVal pic As PictureBox, ByVal t As Timer, ByVal msg As String)
        lbl.Text = msg
        pic.Image = My.Resources.OK
        t.Start()
    End Sub


#End Region

#Region " Insert And Update  And Delete Recourds DataTable اضافة وتعديل وحذف السجلات "
    '  اضافة وتعديل السجلات
    Public Sub RowInsert(ByVal DT As DataTable, ByVal da As SqlDataAdapter)

        Dim Save As New SqlCommandBuilder(da)
        da.Update(DT)
        DT.AcceptChanges()
        DT.Dispose()
        da.Dispose()

    End Sub

    '  حذف السجلات بحذف مؤقت وليس حذف كامل 
    Public Sub DeleteRecourd(ByVal TableName As String, ByVal ColumnOfID As String, ByVal Id As String, ByVal lbl As Label, ByVal Pic As PictureBox, ByVal t As Timer)

        Try
            Dim DT As New DataTable
            'DT.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(" Update " & TableName & " set IsDeleted = 'True' where " & ColumnOfID & " = " & Id & "", Con)
            da.Fill(DT)
            DT.Dispose()
            da.Dispose()

            lbl.Text = " تم الحذف بنجاح "
            Pic.Image = My.Resources.OK
            t.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '  حذف السجلات بحذف مؤقت وليس حذف كامل وهي نفس الدالة السابقة ولكن تم عمل لها تحميل زائد وتم تقليل عدد البراميترات 
    Public Sub DeleteRecourd(ByVal TableName As String, ByVal ColumnOfID As String, ByVal Id As String)

        Try
            Dim DT As New DataTable
            'DT.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(" Update " & TableName & " set IsDeleted = 'True' where " & ColumnOfID & " = " & Id & "", Con)
            da.Fill(DT)
            DT.Dispose()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' الدالة الخاصة باستعادة الملفات عن طريق تغيير قيمة حقل از دليتيد الى 0
    Public Sub ReturnRecord(ByVal Id As String)
        Try
            Dim DT As New DataTable
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(" Update Files set IsDeleted = 'False' where FileId = " & Id & "", Con)
            da.Fill(DT)
            DT.Dispose()
            da.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



#End Region

#Region " General Methods Of Files دوال عامة خاصة بالملفات "
    ' To Get Size Of File دالة الحصول على حجم الملف 
    Public Function GetFileSize(ByVal filePath As String) As String
        Dim Path As New FileInfo(filePath) ' نقوم بتعريف المتغير الذي تعيد له داله جاهزه في كلاس الايو ستريم تعيد جميع معلومات الملف
        Dim FileSize As Long = Path.Length ' نخزن حجم الملف بالبايت
        Dim KB As Decimal = 1024
        Dim MB As Decimal = KB * 1024
        Dim GB As Decimal = MB * 1024

        If (FileSize >= 0 And FileSize < KB) Then

            Return FileSize & "  Bytes  "

        ElseIf (FileSize >= KB And FileSize < MB) Then

            Return Math.Round(FileSize / KB, 2) & "  KB " ' الدالة تعمل على قسمه الحجم على الكيلو  بايت وتقوم بتقريب الرقم بمقدار رقمين بعد العلامة العشرية 

        ElseIf (FileSize >= MB And FileSize < GB) Then

            Return Math.Round(FileSize / MB, 2) & "  MB "

        Else

            Return Math.Round(FileSize / GB, 2) & "  GB "

        End If

    End Function

    ' To Get File Icon  دالة الحصول على ايقونة الملف
    Public Function GetFileIcon(ByVal FileExtenssion As String) As Int16

        ' get image of file 
        Select Case FileExtenssion
            Case ".pdf", ".PDF"
                Return 1
            Case ".doc", ".docx", ".DOC", ".DOCX"
                Return 2
            Case ".xls", ".xlsx", ".XLS", ".XLSX"
                Return 3
            Case ".ppt", ".pptx", ".PPT", ".PPTX"
                Return 4
            Case ".mdw", ".mdb", ".accdb", ".mde", ".MDW", ".MDB", ".ACCDB", ".MDE"
                Return 5
            Case ".zip", ".rar", ".7z", ".ZIP", ".RAR", ".7Z"
                Return 6
            Case ".jpg", ".png", ".jpge", ".gif", ".tiff", ".dng", ".emf", ".raw", ".ico", ".bmp", ".jpeg", ".JPG", ".PNG", ".JPGE", ".ICO", ".BMP", ".JPEG"
                Return 7
            Case ".mp4", ".3gp", ".mov", ".avi", ".wmv", ".divx", ".MP4", ".AVI", ".3GP", ".MOV", ".WMV"
                Return 8
            Case ".mp3", ".wav", ".MP3", ".WAV"
                Return 9
            Case ".txt", ".log", ".ini", ".sql", ".TXT", ".LOG", ".INI", ".SQL"
                Return 10
            Case ".html", ".htm", ".asp", ".aspx", ".css", ".php", ".js", ".url"
                Return 11
            Case Else
                Return 0


        End Select

    End Function

    ' To Delete Files Contained im Folder اجراء حذف جميع الملفات او المجلدات التي تحتوي على المجلد الذي سيتم حذفه وتستقبل هذه الدالة مسار المجلد - وسوف نستدعيه عند اغلاق البرنامج ككل
    Public Sub DeleteDirectory(ByVal FPath As String)

        Try
            If Directory.Exists(FPath) Then
                ' Delete all files from the Directory
                For Each filepath As String In Directory.GetFiles(FPath)
                    File.Delete(filepath)
                Next
                ' Delete all child from the Directories
                For Each dir As String In Directory.GetDirectories(FPath)
                    DeleteDirectory(dir)
                Next

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




#End Region

#Region " Image الصور "

    ' Zoom In Out Image in PictureBox تكبير وتصغير الصورة في اداة عرض الصور
    Public Sub ZoomInOutPictures(ByVal Pb As PictureBox, ByVal value As Double)

        Try
            If Pb.Image Is Nothing Then Return
            Pb.Width *= value
            Pb.Height *= value
            Pb.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            Exit Sub
        End Try


    End Sub

    ' Rotate Left تدوير الصورة لليسار
    Public Sub RotateLeft(ByVal Pb As PictureBox)
        Try
            If Pb.Image Is Nothing Then Return
            Dim pic As Bitmap = Pb.Image.Clone
            pic.RotateFlip(RotateFlipType.Rotate90FlipXY)
            Pb.Image = pic
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    ' Rotate Right تدوير الصورة لليمين
    Public Sub RotateRight(ByVal Pb As PictureBox)
        Try
            If Pb.Image Is Nothing Then Return
            Dim pic As Bitmap = Pb.Image.Clone
            pic.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Pb.Image = pic
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

#End Region

#Region " Change Between Computer Languages  التبديبل بين لغه الكمبيوتر"

    ' داله تغيير الكتابة الى العربية 
    Public Sub ChangeToArabic()
        Dim lang As InputLanguage
        For Each lang In InputLanguage.InstalledInputLanguages
            If lang.Culture.EnglishName.ToUpper Like "*arabic*".ToUpper Then
                InputLanguage.CurrentInputLanguage = lang
            End If
        Next

    End Sub


    ' داله تغيير الكتابة الى الانجليزية 
    Public Sub ChangeToEnglish()
        Dim lang As InputLanguage
        For Each lang In InputLanguage.InstalledInputLanguages
            If lang.Culture.EnglishName.ToUpper Like "*english*".ToUpper Then
                InputLanguage.CurrentInputLanguage = lang
            End If
        Next

    End Sub

#End Region

End Module
