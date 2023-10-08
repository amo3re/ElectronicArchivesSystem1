Imports System.Data.SqlClient ' اسخدام مكاتب الاتصال
Imports System.IO ' استخدام الادخال والاخراج 
Imports System.Drawing.Imaging ' اسخدام مكاتب رسم الصور
Imports ALquhaliLibrary
' تم استدعاء المكتبة للحصول على دالة تحويل الصور الى بي دي اف
Imports System.Drawing.Printing ' لتفعيل مكاتب الطباعة 

Imports System.Net.Mail ' المكتبة التي سوف نستخدمها للتعامل مع الايميل
Imports System.Net ' 
Imports Microsoft.Win32 ' للتعامل مع الريجستري

Public Class ProjectClass

#Region "UserAcounts المستخدمين"


    'Command Builder Class

    'Clear Controls Data اجرائية تنظيف الادوات 
    Public Sub ClearControls_FrmUsers(ByVal xx As FrmUserAccounts)

        xx.UserAccID.Text = GetNewID("UserAccID", "UserAccounts")
        xx.UserAccountName.Clear()
        xx.UserName.Clear()
        xx.UserPassword.Clear()
        xx.AccType.Text = Nothing
        xx.AccActivate.Checked = False
        xx.UserImage.Image = Nothing
        xx.ck_ShowPasword.Checked = False
        xx.txtNevigate.Text = Nothing

        xx.btnSave.Enabled = True
        xx.btnEdit.Enabled = False
        xx.btnDelete.Enabled = False
        xx.UserAccountName.Focus()

    End Sub

    ' Get New ID اجرائية جلب الرقم الجديد عند ادخال سجل جديد 
    Public Function GetNewID(ByVal ColumnName As String, ByVal TableName As String)

        'Try

        Dim dt As New DataTable
        dt.Clear()
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter("select MAX(" & ColumnName & ") from " & TableName & "", Con)
        da.Fill(dt)

        Dim MyNewID As Int64
        If IsDBNull(dt(0)(0)) = True Then
            MyNewID = 1
        Else
            MyNewID = dt(0)(0) + 1
        End If

        Return MyNewID

        da.Dispose()
        dt.Dispose()


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End Try

    End Function

    ' Check Null Control in FrmUserAccounts التأكد من الادوات الفارغة في فورم المستخدمين
    Function FrmUserControl_Null(ByVal xx As FrmUserAccounts) As Boolean

        If MyTextNull(xx.UserAccountName, "اسم الحساب") Then Return True
        If MyTextNull(xx.UserName, "اسم المستخدم") Then Return True
        If MyTextNull(xx.UserPassword, "كلمة المرور") Then Return True
        If MyCombIndexNull(xx.AccType, " نوع الحساب ") Then Return True

        Return False

    End Function

    'Save Users Acounts Data اجرائية حفظ معلومات المستخدمين 
    Public Sub Save_In_UsersTbl(ByVal xx As FrmUserAccounts)


        Try

            ' الفحص بطريقة يدوية بدون استخدام الاجراء الخاص بفحص الحقول 

            'If xx.UserAccountName.Text.Trim = Nothing Then
            '    MessageBox.Show("من فضلك ادخل اسم الحساب ", "رسالة تنبية ")
            '    Exit Sub

            'ElseIf xx.UserName.Text.Trim = Nothing Then
            '    MessageBox.Show("من فضلك ادخل اسم المستخدم ", "رسالة تنبية ")
            '    xx.UserName.Focus()

            'ElseIf xx.UserPassword.Text.Trim = Nothing Then
            '    MessageBox.Show("من فضلك ادخل كلمة المرور ", "رسالة تنبية ")
            '    xx.UserPassword.Focus()

            'ElseIf xx.AccType.SelectedIndex = -1 Then
            '    MessageBox.Show("من فضلك اختر نوع الحساب ", "رسالة تنبية ")
            '    xx.AccType.Focus()


            ' الفحص بإستخدام اجراء فحص الحقول 
            'If MyTextNull(xx.UserAccountName, "اسم الحساب") = True Then Exit Sub
            'If MyTextNull(xx.UserName, "اسم المستخدم") = True Then Exit Sub
            'If MyTextNull(xx.UserPassword, "كلمة المرور") = True Then Exit Sub
            'If MyCombIndexNull(xx.AccType, " نوع الحساب ") = True Then Exit Sub

            If FrmUserControl_Null(xx) = True Then Exit Sub ' ^ اختصار لهذا

            ' End If

            Dim dt As New DataTable
            dt.Clear()
            Dim da As New SqlDataAdapter
            Dim sqlstr As String
            sqlstr = "Select * FROM UserAccounts where UserAccID = " & xx.UserAccID.Text & " "
            da = New SqlDataAdapter(sqlstr, Con)
            da.Fill(dt)

            If dt.Rows.Count = 0 Then

                dt.Rows.Add()
                Dim last As Integer = dt.Rows.Count - 1

                dt.Rows(last).Item("UserAccID") = xx.UserAccID.Text
                dt.Rows(last).Item("UserAccName") = xx.UserAccountName.Text
                dt.Rows(last).Item("UserName") = xx.UserName.Text
                dt.Rows(last).Item("UserPassword") = xx.UserPassword.Text
                dt.Rows(last).Item("AccType") = xx.AccType.SelectedIndex
                dt.Rows(last).Item("AccActivate") = xx.AccActivate.Checked
                dt.Rows(last).Item("AddUser") = LogUserID ' لكي نقوم بتسجيل من قام بالحفظ او الاضافة 
                'dt.Rows(last).Item("AddDate") = Now.ToString("dd-MM-yyyy hh:mm:ss tt") ' لكي نقوم بتسجيل تاريخ الإضافة
                'dt.Rows(last).Item("IsDeleted") = False

                ' this code for Image ---------
                ' If img = 1 Then ' تم استبداله بالشرط الذي يوجد داخل اجراء حفظ الصورة في قاعدة البيانات 
                SavePicture(xx.UserImage, dt, last, "UserImage")
                ' End If

                '------------------------------

                RowInsert(dt, da)

                'Dim Save As New SqlCommandBuilder(da) ' RowInsert(dt, da) تم استبدالهم بالسطر 
                'da.Update(dt)
                'dt.AcceptChanges()
                'dt.Dispose()
                'da.Dispose() ' RowInsert(dt, da) تم استبدالهم بالسطر 

                'ClearControls_FrmUsers(FrmUserAccounts) ' xx.btnNew.PerformClick()  تم تعليقه واستخدام  لحل مشكلة عدم تحديث الفورم وظهور اخر سجل تم اضافته 
                xx.btnNew.PerformClick() '  قم بالضغط على زر جديد بعد عملية الحفظ لكي لا اكرر الكود المكتوب هناك  

                'xx.lblconfirmMessage.Text = " تم الحفظ بنجاح "
                'xx.PicMessage.Image = My.Resources.OK
                'xx.Timer1.Start()
                ConfirmMessage(xx.lblconfirmMessage, xx.PicMessage, xx.Timer1, "تم الحفظ بنجاح") ' ^ اختصار للثلاثة الاسطر هذه 



            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    'To get Image to pictureBox اجرائية جلب الصورة من الجهاز 
    Public Sub GetImageTo_PictureBox(ByVal pic As PictureBox)

        Dim ofd As New OpenFileDialog
        ofd.Title = " اختر صورة"
        ofd.Filter = "Choose Image (*.PNG; *.JPG; *.GIF; *.JPEG)| *.PNG; *.JPG; *.GIF; *.JPEG"

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' img = 1 ' تم استبداله بالشرط الذي يوجد داخل اجراء حفظ الصورة في قاعدة البيانات 
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Load(ofd.FileName)
        End If


    End Sub

    'Save Picture Inside DataBase اجرائية حفظ الصورة في قاعدة البيانات 
    Public Sub SavePicture(ByVal pic As PictureBox, ByVal dt As DataTable, ByVal RowIndx As Integer, ByVal ImgCol As String)
        If pic.Image Is Nothing Then ' اذا كان حقل الصورة لايساوي شي اولا يحتوي على صورة 
            dt.Rows(RowIndx).Item("" & ImgCol & "") = Nothing ' نخزن في الحقل انه فارغ Null 

        Else ' والا اذا وجدت صورة فنفذ التالي 

            Dim ImgArray() As Byte

            Dim stream As New MemoryStream()

            pic.Image.Save(stream, ImageFormat.Jpeg)

            ImgArray = stream.ToArray()

            stream.Close()

            dt.Rows(RowIndx).Item("" & ImgCol & "") = ImgArray

            ' img = 0 'to return default value to variable ' تم استبداله بالشرط الذي يوجد في بداية الاجراء  

        End If
    End Sub

    'Check Exisance Of Entered Name  اجرائية فحص اسم المستخدم اذا تكرر
    Public Sub CheckExisanceOfName(ByVal TXT As TextBox)

        If TXT.Text.Trim = Nothing Then
            Exit Sub


        Else

            Dim dt As New DataTable
            Dim sqlstr As String
            sqlstr = "select UserName from UserAccounts where UserName = N'" & TXT.Text.Trim & "' "
            FillDataTable(dt, sqlstr)

            If dt.Rows.Count > 0 Then
                MessageBox.Show("اسم المستخدم " & Space(2) & "'" & TXT.Text.Trim & "'" & " موجود من قبل ", " رسالة تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TXT.Text = Nothing
                TXT.Focus()
            End If

        End If

    End Sub

    'Show Saved Picture or show Image to pictureBox اجرائية عرض الصور المحفوظة في قاعدة البيانات
    Public Sub ShowSavedPicture(ByVal pic As PictureBox, ByVal dt As DataTable, ByVal RowIndx As Integer, ByVal ImgCol As String)

        If IsDBNull(dt.Rows(RowIndx).Item("" & ImgCol & "")) = False Then '  فحص ان الحقل حق الصوره ليس فارغ - اي يحتوي على صورة  

            Dim ImgArray() As Byte
            ImgArray = CType(dt.Rows(RowIndx).Item("" & ImgCol & ""), Byte()) ' تحويل الصورة الى بايت  وتخزن في المصفوفة 

            Dim stream As New MemoryStream(ImgArray) ' نقوم بتعريف مخزن بيانات في الذاكرة ونمرر له المصفوفة التي تحتوي على الصورة 

            pic.Image = Image.FromStream(stream)

            stream.Close() ' نغلق المخزن الذي قمنا بإنشائه للحفاظ على الذاكرة 
        Else
            pic.Image = Nothing '  الشرط المعاكس وهو ان الحقل لايحتوي ع صورة لذلك نجعل أداة العرض فارغة 
        End If

    End Sub

    'Show Users Accounts details  اجرائية عرض معلومات حسابات المستخدمين 
    Public Sub Show_UsersAccounts_Data(ByVal xx As FrmUserAccounts, ByVal AccID As String)

        Try
            Dim DT As New DataTable
            DT.Clear()
            Dim sqlstr As String
            sqlstr = "select * from UserAccounts where ( UserAccID = " & AccID & ")"
            FillDataTable(DT, sqlstr)

            If DT.Rows.Count > 0 Then

                xx.UserAccID.Text = DT.Rows(0).Item("UserAccID")
                xx.UserAccountName.Text = DT.Rows(0).Item("UserAccName")
                xx.UserName.Text = DT.Rows(0).Item("UserName")
                xx.UserPassword.Text = DT.Rows(0).Item("UserPassword")
                xx.AccType.SelectedIndex = DT.Rows(0).Item("AccType")
                xx.AccActivate.Checked = DT.Rows(0).Item("AccActivate")

                ShowSavedPicture(xx.UserImage, DT, 0, "UserImage") ' To Show Image


                xx.btnSave.Enabled = False
                xx.btnEdit.Enabled = True
                xx.btnDelete.Enabled = True

            End If

            DT.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'Update Users Acounts Data اجرائية تعديل معلومات المستخدمين 
    Public Sub Update_In_UsersTbl(ByVal xx As FrmUserAccounts)


        Try

            ' الفحص بإستخدام اجراء فحص الحقول 
            'If MyTextNull(xx.UserAccountName, "اسم الحساب") = True Then Exit Sub
            'If MyTextNull(xx.UserName, "اسم المستخدم") = True Then Exit Sub
            'If MyTextNull(xx.UserPassword, "كلمة المرور") = True Then Exit Sub
            'If MyCombIndexNull(xx.AccType, " نوع الحساب ") = True Then Exit Sub
            If FrmUserControl_Null(xx) = True Then Exit Sub ' ^ اختصار لهذا

            Dim dt As New DataTable
            dt.Clear()
            Dim da As New SqlDataAdapter
            Dim sqlstr As String
            sqlstr = "Select * FROM UserAccounts where UserAccID = " & xx.UserAccID.Text & " "
            da = New SqlDataAdapter(sqlstr, Con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                'dt.Rows(0).Item("UserAccID") = xx.UserAccID.Text ' لاننا لا نعدل رقم المستخدم 
                dt.Rows(0).Item("UserAccName") = xx.UserAccountName.Text
                dt.Rows(0).Item("UserName") = xx.UserName.Text
                dt.Rows(0).Item("UserPassword") = xx.UserPassword.Text
                dt.Rows(0).Item("AccType") = xx.AccType.SelectedIndex
                dt.Rows(0).Item("AccActivate") = xx.AccActivate.Checked
                dt.Rows(0).Item("EditUser") = LogUserID ' لكي نقوم بتسجيل من قام بالتعديل
                dt.Rows(0).Item("AddDate") = Now.ToString("dd-MM-yyyy hh:mm:ss tt") ' لكي نقوم بتسجيل تاريخ التعديل
                'dt.Rows(0).Item("IsDeleted") = False

                ' this code for Image ---------
                SavePicture(xx.UserImage, dt, 0, "UserImage")
                '------------------------------

                RowInsert(dt, da)


                xx.btnNew.PerformClick() '  قم بالضغط على زر جديد بعد عملية الحفظ لكي لا اكرر الكود المكتوب هناك  

                ConfirmMessage(xx.lblconfirmMessage, xx.PicMessage, xx.Timer1, " تم التعديل بنجاح ")


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            '  MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub



#End Region

#Region "Folders المجلدات"
    'clear FrmAddFolders Controls اجرائية تنظيف ادوات فورم اضافة المجلدات 
    Public Sub ClearFrmAddFoldersControls(ByVal xx As FrmAddFolders)

        '  xx.FolderNumber.Text = GetFolderNumber(xx, xx.FolderParent.SelectedValue) ' عندما كان الكمبوبوكس السابق 

        Dim ParentID As Decimal
        If xx.FolderParent.SelectedNode Is Nothing Then ParentID = 0 Else ParentID = xx.FolderParent.SelectedNode.Tag

        xx.FolderNumber.Text = GetFolderNumber(ParentID)
        xx.FolderName.Clear()
        xx.FolderID.Clear()
        xx.FolderParent.Text = Nothing

        xx.btnSave.Enabled = True
        xx.btnEdit.Enabled = False
        xx.btnDelete.Enabled = False
        xx.FolderName.Focus()


    End Sub

    ' كانت تستخدم سابقا مع الكمبوبوكس القديم
    ' Get New Folder Number or Code اجراء يقوم بجلب او ارجاع رقم المجلد 
    'Public Function GetFolderNumber(ByVal xx As FrmAddFolders, ByVal ComValue As String) As Decimal

    '    Dim dt As New DataTable
    '    Dim SqlSt As String

    '    If xx.FolderParent.Text = String.Empty Then
    '        SqlSt = "select MAX(FolderNumber) from Folders where FolderParent = " & 0 & " "
    '        FillDataTable(dt, SqlSt)
    '        'ElseIf xx.FolderParent.SelectedValue >= 0 Then ' عندما كان الكمبوبوكس السابق
    '    ElseIf xx.FolderParent.SelectedNode Is Nothing Then
    '        SqlSt = "select MAX(FolderNumber) from Folders where FolderParent = '" & ComValue & "' "
    '        FillDataTable(dt, SqlSt)
    '    End If


    '    If IsDBNull(dt(0)(0)) = True Then
    '        Return ComValue & 0 & 0 & 1
    '    Else
    '        Return dt(0)(0) + 1
    '    End If

    '    dt.Dispose()
    'End Function


    ' هذه هي الجديدة التي تستخدم مع الكمبوبوكس الشجري 
    ' Get Folder Number or Code اجراء يقوم بجلب او ارجاع رقم المجلد 
    Public Function GetFolderNumber(ByVal FolderParent As Decimal) As Decimal

        Dim Paramter(0) As SqlParameter

        Paramter(0) = New SqlParameter("@FolderParent", SqlDbType.Decimal, 25)
        Paramter(0).Value = FolderParent

        Dim dt As New DataTable
        dt = GetDataTable("[GetFolderNumber]", Paramter) '  نرسل الاجراء المخزن الخاص بجلب رقم المجلد 
        Return dt(0)(0)
        ' Return dt.Rows(0).Item("FolderNumber") ' or
        dt.Dispose()
    End Function


    ' خاص بالكمبوبوكس القديم 
    ' Fill Combobox by Folders تعبئة الكمبويوكس بالمجلدات
    'Public Sub FillMyComboBox(ByVal Combo As ComboBox)

    '    Dim Sqlst As String
    '    Dim DT As New DataTable
    '    Sqlst = "select FolderNumber,FolderName from Folders where IsDeleted='False'"
    '    FillDataTable(DT, Sqlst)

    '    If DT.Rows.Count > 0 Then
    '        Combo.DataSource = DT
    '        Combo.DisplayMember = "FolderName"
    '        Combo.ValueMember = "FolderNumber"
    '        Combo.Text = Nothing
    '    End If

    'End Sub

    ' Save Folders اجرائية حفظ المجلدات 
    Public Sub Save_Folders(ByVal xx As FrmAddFolders, ByVal FolderNumber As Decimal, ByVal FolderName As String, ByVal FolderParent As Decimal, ByVal AddUser As Int16)

        Try

            Dim Cmd As SqlCommand
            Cmd = New SqlCommand("InsertFolders", Con)
            Cmd.CommandType = CommandType.StoredProcedure

            Dim Paramter(3) As SqlParameter

            Paramter(0) = New SqlParameter("@FolderNumber", SqlDbType.Decimal, 25) ' 35 for above big tree
            Paramter(0).Value = FolderNumber

            Paramter(1) = New SqlParameter("@FolderName", SqlDbType.NVarChar, 100)
            Paramter(1).Value = FolderName

            Paramter(2) = New SqlParameter("@FolderParent", SqlDbType.Decimal, 25) ' 35 for above big tree
            Paramter(2).Value = FolderParent

            Paramter(3) = New SqlParameter("@AddUser", SqlDbType.TinyInt)
            Paramter(3).Value = AddUser

            Cmd.Parameters.AddRange(Paramter)

            OpenConnection()
            Cmd.ExecuteNonQuery()
            CloseConnection()

            AddFolderToTreeview(FrmMainPage.TreeView1, FolderName, CStr(FolderParent), CStr(FolderNumber), FrmMainPage.lblCount) ' استدعاء للدالة التي عرفناها في الاسفل لظهور الحفظ بشكل مباشر

            xx.btnNew.PerformClick() ' clear controls
            ConfirmMessage(xx.lblconfirmMessage, xx.PicMessage, xx.Timer1, "تم الحفظ بنجاح")
            'or
            ' MessageBox.Show(" تم الحفظ بنجاح ")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Dim DT As New DataTable

    '' Fill Treeview by Folders اجرائية تعبئة الشجرة بالمجلدات 
    'Public Sub FillTreeview(ByVal key As String, ByVal txt As String, ByVal N As TreeNode, ByVal ImgIndex As Int16, ByVal TV As TreeView)

    '    Dim NN As TreeNode

    '    If N Is Nothing Then
    '        NN = TV.Nodes.Add(key, txt, ImgIndex, ImgIndex)
    '        NN.Tag = key
    '    Else
    '        NN = N.Nodes.Add(key, txt, ImgIndex, 10)
    '        NN.Tag = key
    '    End If

    '    Dim dv As DataView = DT.DefaultView
    '    Dim xkey As Int64 = Convert.ToInt64(key) ' UInt64 for above big tree

    '    dv.RowFilter = "FolderParent = '" & xkey & "'"

    '    For Each dr As DataRow In dv.ToTable.Rows
    '        FillTreeview(dr("FolderNumber"), dr("FolderName"), NN, dr("FolderImageIndex"), TV)
    '    Next
    '    DT.Dispose()


    'End Sub

    ' Fill Treeview by Folders اجرائية تعبئة الشجرة بالمجلدات 
    Public Sub FillTreeview(ByVal key As String, ByVal txt As String, ByVal N As TreeNode, ByVal ImgIndex As Int16, ByVal TV As TreeView, ByVal DT As DataTable, ByVal SelectedIndex As Short)

        Dim NN As TreeNode

        If N Is Nothing Then
            NN = TV.Nodes.Add(key, txt, ImgIndex, SelectedIndex)
            NN.Tag = key
        Else
            NN = N.Nodes.Add(key, txt, ImgIndex, SelectedIndex)
            NN.Tag = key
        End If

        Dim dv As DataView = DT.DefaultView
        Dim xkey As Int64 = Convert.ToInt64(key) ' UInt64 for above big tree

        dv.RowFilter = "FolderParent = '" & xkey & "'"

        For Each dr As DataRow In dv.ToTable.Rows
            FillTreeview(dr("FolderNumber"), dr("FolderName"), NN, dr("FolderImageIndex"), TV, DT, dr("SelectedIndex"))
        Next
        DT.Dispose()


    End Sub


    '' Build Archive Tree Treeview  اجرائية بناء شجرة الارشفة
    'Public Sub LoadArchiveTree(ByVal xx As FrmMainPage)


    '    Dim DT As New DataTable




    '    DT = GetDataTable("SelectArchiveTree", Nothing)

    '    xx.TreeView1.BeginUpdate()
    '    xx.TreeView1.Nodes.Clear()
    '    FillTreeview("0", "شجرة الأرشفة", Nothing, 0, xx.TreeView1)
    '    xx.TreeView1.TopNode.Expand()
    '    xx.TreeView1.TopNode.NodeFont = New Font("Times New Roman", 20.25!, FontStyle.Bold)
    '    xx.TreeView1.TopNode.ForeColor = Color.Blue
    '    xx.TreeView1.Select()
    '    xx.TreeView1.EndUpdate()
    '  xx.lblCount.Text = xx.TreeView1.TopNode.GetNodeCount(True)
    '    xx.txtsearch.Focus()



    'End Sub

    ' Build Archive Tree Treeview  اجرائية بناء شجرة الارشفة
    Public Sub LoadArchiveTree(ByVal xx As FrmMainPage)


        Dim DT As New DataTable
        Dim Paramter(0) As SqlParameter

        Paramter(0) = New SqlParameter("@NumberOFItem", SqlDbType.VarChar, 200)
        Paramter(0).Direction = ParameterDirection.Output

        DT = GetDataTable("SelectArchiveTree", Paramter)

        xx.TreeView1.BeginUpdate()
        xx.TreeView1.Nodes.Clear()
        FillTreeview("0", "شجرة الأرشفة", Nothing, 0, xx.TreeView1, DT, 0)
        xx.TreeView1.TopNode.Expand()
        xx.TreeView1.TopNode.NodeFont = New Font("Times New Roman", 20.25!, FontStyle.Bold)
        xx.TreeView1.TopNode.ForeColor = Color.Blue
        xx.TreeView1.Select()
        xx.TreeView1.EndUpdate()
        '  xx.lblCount.Text = xx.TreeView1.TopNode.GetNodeCount(True)
        xx.lblCount.Text = Paramter(0).Value
        xx.txtsearch.Focus()



    End Sub

    'Show Folders details  اجرائية عرض معلومات المجلدات 
    Public Sub Show_Folders_Data(ByVal xx As FrmAddFolders, ByVal ID As Decimal)

        Try
            If ID > 0 Then

                Dim DT As New DataTable
                DT.Clear()
                Dim sqlstr As String
                sqlstr = "select [FolderID],[FolderNumber],[FolderName],[FolderParent] from Folders where ( FolderNumber = " & ID & ")"
                FillDataTable(DT, sqlstr)

                If DT.Rows.Count > 0 Then

                    xx.FolderID.Text = DT.Rows(0).Item("FolderID")
                    'xx.FolderNumber.Text = DT.Rows(0).Item("FolderNumber")
                    xx.FolderName.Text = DT.Rows(0).Item("FolderName")
                    'xx.FolderParent.SelectedValue = DT.Rows(0).Item("FolderParent") ' عندما كان الكمبوبوكس السابق


                    GetParentNode(xx.FolderParent.Nodes, CStr(DT.Rows(0).Item("FolderParent")), xx.FolderParent)


                    xx.FolderNumber.Text = DT.Rows(0).Item("FolderNumber") ' تم نقله الى هنا لان هذا الحقل تكوينه يكون بدلاله المجلد الاب وسبب النقل لكي تكون قيمته عند العرض صحيحة 


                    xx.btnSave.Enabled = False
                    xx.btnEdit.Enabled = True
                    xx.btnDelete.Enabled = True

                End If
                DT.Dispose()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Get Parent Node of ComboTreeBox داله تقوم بجلب العقدة الاب للكمبوبوكس الشجري 
    Public Function GetParentNode(ByVal Nodes As IEnumerable, ByVal ParentID As String, ByVal CTB As ComboTreeBox) As Boolean

        For Each Node As ComboTreeNode In Nodes

            If Node.Tag.Equals(ParentID) Then
                CTB.SelectedNode = Node
            End If

            If GetParentNode(Node.Nodes, ParentID, CTB) = True Then Return True

        Next

        Return False

    End Function



    ' Update Folders اجرائية تعديل المجلدات 
    Public Sub Update_Folders(ByVal xx As FrmAddFolders, ByVal FolderID As Int32, ByVal FolderNumber As Decimal, ByVal FolderName As String, ByVal FolderParent As Decimal, ByVal EditUser As Int16)

        Dim Cmd As SqlCommand
        Cmd = New SqlCommand("UpdateFolders", Con)
        Cmd.CommandType = CommandType.StoredProcedure

        Dim Paramter(4) As SqlParameter

        Paramter(0) = New SqlParameter("@FolderNumber", SqlDbType.Decimal, 25) ' 35 for above big tree
        Paramter(0).Value = FolderNumber

        Paramter(1) = New SqlParameter("@FolderName", SqlDbType.NVarChar, 100)
        Paramter(1).Value = FolderName

        Paramter(2) = New SqlParameter("@FolderParent", SqlDbType.Decimal, 25) ' 35 for above big tree
        Paramter(2).Value = FolderParent

        Paramter(3) = New SqlParameter("@EditUser", SqlDbType.TinyInt)
        Paramter(3).Value = EditUser

        Paramter(4) = New SqlParameter("@FolderID", SqlDbType.Int)
        Paramter(4).Value = FolderID

        Cmd.Parameters.AddRange(Paramter)

        OpenConnection()
        Cmd.ExecuteNonQuery()
        CloseConnection()

        UpdateNodeInTreeview(FrmMainPage.TreeView1, FolderName, CStr(FolderNumber)) ' استدعاء للدالة التي عرفناها في الاسفل لظهور الحفظ بشكل مباشر

        xx.btnNew.PerformClick() ' clear controls
        ConfirmMessage(xx.lblconfirmMessage, xx.PicMessage, xx.Timer1, "تم التعديل بنجاح")
        'or
        ' MessageBox.Show(" تم التعديل بنجاح ")


    End Sub

    ' Delete Folders اجرائية حذف المجلدات التي تقوم بالفحص عبر الاجراء المخزن ولكن عملية الحذف تتم في زر حذف الواجهة - انظر الكود هناك 
    Public Function Delete_Folders(ByVal FolderNumber As String) As Int64

        Dim Paramter(0) As SqlParameter

        Paramter(0) = New SqlParameter("@FolderNumber", SqlDbType.Decimal)
        Paramter(0).Value = CDec(FolderNumber)

        Dim Dt As DataTable
        Dt = GetDataTable("CheckAndDeleteFolders", Paramter)

        ' Return Dt.Rows(0)(0) ' هذا السطر نفس الذي ولكن في الاسفل تم ذكر اسم البراميتر الذي مخزن فيه القمية 
        Return Dt.Rows(0).Item("Result")

    End Function

    ' Add Folder To Treeview  اضافة المجلد الى شجرة الارشيف وظهورها بشكل مباشر 
    Public Sub AddFolderToTreeview(ByVal Tv As TreeView, ByVal FolderName As String, ByVal ParentFolder As String, ByVal FolderNumber As String, ByVal lbl As Label)

        If Tv.Nodes.Count = 0 Then Exit Sub
        Dim TN As TreeNode
        Dim xfind() As TreeNode = Tv.Nodes.Find(ParentFolder, True) ' دالة البحث عن العقدة الاب 
        Tv.SelectedNode = xfind(0) ' تاخذ اول قيمة وهي قيمة العقدة الاب وحيث انها عقدة واحدة فقط 
        Tv.SelectedNode.Expand() ' عمل توسعة للشجرة للعقدة الاب التي تم البحث عنها وتم ايجادها

        Dim index As Int16 = Tv.SelectedNode.ImageIndex + 1 ' نقوم بزيادة المتغير عنوان الصورة بواحد لكي يتغير لون المجلد كون ان الاضافه سوف تكون في مستوى جديد وفي الشجرة لدينا كل مستوى يوجد به لون موحد 
        TN = Tv.SelectedNode.Nodes.Add(FolderNumber, FolderName, index, 27) ' عمل اضافة للعقدة الجديدة 
        ' 27 تشير الى ايقونه المجلد المفتوح لانه عندما نظيف العقدة الجديد في الشجرة سنكون واقفين عليها اي التحديد عليها لذلك ضعها على حسب الموقع الخاص بالصورة في اداة قائمة الصور 
        TN.Tag = FolderNumber ' نخزن رقم العقدة في التاج الخاص بالعقدة لاستخدامه عند العمليات الاخرى
        Tv.SelectedNode = TN ' نقوم بالتحديد على العقدة في الشجرة بعد الاضافة
        lbl.Text = Val(lbl.Text) + 1 ' نزيد عداد المجلدات بواحد كونه تم اضافة عقدة جديدة 


    End Sub

    ' Update Node In Treeview  تعديل المجلد في شجرة الارشيف وظهورها بشكل مباشر 
    Public Sub UpdateNodeInTreeview(ByVal Tv As TreeView, ByVal NodeName As String, ByVal NodeID As String)

        If Tv.Nodes.Count = 0 Then Exit Sub

        'Dim xfind() As TreeNode = Tv.Nodes.Find(NodeID, True) ' دالة البحث عن العقدة الاب 
        'Tv.SelectedNode = xfind(0) ' تاخذ اول قيمة وهي قيمة العقدة الاب وحيث انها عقدة واحدة فقط 

        '  لتجنب ظهور المشكلة عند تعديل في عقدة ايدي غير موجودة لكون قيمة الايدي تغيرت في الواجهة بعد التحديد
        ' اصل ظهور المشكلة انه عندما ناخذ ايدي العقدة عند التحديد وتكون العقده ليس لها اب بمعنى الاب 0 ثم نقوم بعمل لها اب - او عندما نقوم بتغيير الاب للعقدة اذا كان لديها اب تظهر المشكلة كون ان رقم المجلد قد تغير 
        ' لحل هذه المشكلة مبدئيا نقوم بعليق الكود الذي في الاعلى لتجنب ظهور الخطأ 
        Tv.SelectedNode.Text = NodeName
        Tv.SelectedNode.Tag = NodeID


    End Sub






#End Region

#Region " Files   الملفات"

    'Clear Controls  اجرائية تنظيف الادوات 
    Public Sub ClearFrmAddfilesControls(ByVal xx As FrmAddfiles)

        Clear_Control_On_TabControl(xx.TabControl1) ' تم اختصار كود تنظيف الأدوات في هذه الدالة
        xx.AddUser.Text = LogUserName
        xx.AddDate.Text = Now.ToString("dd-MM-yyyy hh:mm tt ")
        xx.dgv.Rows.Clear()
        xx.WebBrowser1.DocumentText = ""
        xx.WebBrowser1.Visible = False
        'xx.WebBrowser1.CanGoBack.Equals(False)
        'xx.WebBrowser1.CanGoForward.Equals(False)

        xx.WebPanel.BringToFront()
        xx.WebBrowser1.BringToFront()
        xx.PictureBox1.Image = Nothing
        xx.lblImagePath.Text = Nothing
        xx.txtReader.Clear()
        xx.AxAcroPDF1.src = Nothing



        xx.btnScan.Enabled = True
        xx.btnbrows.Enabled = True
        xx.btnSave.Enabled = True
        xx.btnEdit.Enabled = False
        xx.btnDelete.Enabled = False
        xx.btnSaveAttaches.Enabled = False
        ' xx.FolderParent.selectedValue = Nothing ' الكمبوبوس القديم
        xx.FolderParent.SelectedNode = Nothing ' لحذف محتوى الاداة وتعني عدم تحديد اي عقدة 
        xx.FolderParent.Focus()

    End Sub

    'Clear Control On TabControl  اجرائية تنظيف جميع الادوات الموجودة في التاب كونترول
    Public Sub Clear_Control_On_TabControl(ByVal TabControl As TabControl)
        TabControl.Enabled = True

        For i As Int16 = 0 To TabControl.TabPages.Count - 1 ' يقوم بتخزين عدد صفحات التاب  الموجودة في التاب كنترول الرئيسية

            For x As Int16 = 0 To TabControl.TabPages(i).Controls.Count - 1 ' داخل كل صفحة قم بعمل عد او لف على جميع الأدوات الموجودة في التاب 0 او 1 حسب قيمة العداد للفور السابقة 

                If TypeOf TabControl.TabPages(i).Controls(x) Is TextBox Then ' Clear TextBox Control  تنظيف حقل النص 
                    Dim TXT As TextBox = TabControl.TabPages(i).Controls(x)
                    TXT.Clear()
                End If

                If TypeOf TabControl.TabPages(i).Controls(x) Is ComboBox Then ' Clear ComboBox Control تنظيف القائمة المنسدلة 
                    Dim Combo As ComboBox = TabControl.TabPages(i).Controls(x)
                    Combo.SelectedValue = 0
                    Combo.SelectedIndex = -1
                    Combo.Text = Nothing
                End If

                If TypeOf TabControl.TabPages(i).Controls(x) Is CheckBox Then ' Clear CheckBox Control تنظيف مربع الإختيار 
                    Dim Ck As CheckBox = TabControl.TabPages(i).Controls(x)
                    Ck.Checked = False
                End If

                If TypeOf TabControl.TabPages(i).Controls(x) Is DataGridView Then ' Clear DataGridView Control تنظيف داتا جريد فيو 
                    Dim dgv1 As DataGridView = TabControl.TabPages(i).Controls(x)
                    dgv1.Rows.Clear()
                End If

                If TypeOf TabControl.TabPages(i).Controls(x) Is ComboTreeBox Then ' Clear ComboTreeBox Control تنظيف داتا الكمبوبوكس الشجري 
                    Dim cmbTree As ComboTreeBox = TabControl.TabPages(i).Controls(x)
                    cmbTree.SelectedNode = Nothing
                End If

            Next ' End insted For (x)

        Next ' End For (i)

    End Sub

    ' Get File Code  دالة جلب كود الملف
    Public Function GetFileCode(ByVal CmbValue As Decimal) As Decimal ' or As Uint64 but Uint64 the best ولك حسب نوع البيانات الموجود في قاعدة البيانات لحقل كود الملف

        Dim Paramter(0) As SqlParameter

        Paramter(0) = New SqlParameter("@FolderParent", SqlDbType.Decimal, 25) ' 35 for above big tree
        Paramter(0).Value = CmbValue

        Dim dt As New DataTable
        dt = GetDataTable("[GetFileCode]", Paramter)
        Return dt(0)(0) ' or dt Dt.Rows(0).Item(" اسم المتغير في الاجراء المخزن")
        ' or dt Dt.Rows(0).Item("FileCode")
        dt.Dispose()


    End Function

    ' Get Main File Info  دالة الحصول على معلومات الملف الرئيسي 
    Public Sub GetMainFileInfo(ByVal xx As FrmAddfiles)

        ' If MyCombIndexNull(xx.FolderParent, " المجلد الأب أولا ") Then Return ' عندما كان كوموبوكس عادي
        If MyComboTreeBoxNodeIsNull(xx.FolderParent, " المجلد الأب أولا ") Then Return

        ' كود فتح الديلوج الخاص اختيار الملف من الجهاز 
        Dim OldFilePath, NewFilePath, StoredPath As String
        Dim ofd As New OpenFileDialog
        ofd.Title = ""
        If ofd.ShowDialog = DialogResult.OK Then
            OldFilePath = ofd.FileName
        Else ' في حاله لم يتم اختيار اي ملف لايظر اي خطأ بسبب هذا الشرط المعاكس 
            Exit Sub
        End If

        ' هذا المتغير الخاص بمسار البرنامج فهو يقوم بدمج القيمة مع النص الدال ع ان المجلد خاص بنظام الأرشفة ويعمل مجلد بداخل المسار واضافة مجلد بداخله ب رقم المجلد الاب الذي تم تحديدة من مربع الاختيار
        'StoredPath = My.Settings.FilePath & "\Archived Files\" & xx.FolderParent.SelectedValue  ' للكمبوبوكس القديم 
        StoredPath = My.Settings.FilePath & "\Archived Files\" & xx.FolderParent.SelectedNode.Tag



        ' Check if stored folder Exist فحص هل مجلد التخزين موجود او لا لتجنب عدم الانشاء في كل مرة اريد اضافة ملفات 
        If My.Computer.FileSystem.FileExists(StoredPath) = True Then ' اذا كان موجود
            NewFilePath = StoredPath & "\" & Path.GetFileName(OldFilePath) ' يقوم بتخزين  اسم و امتداد الملف الذي سوف نقوم بارشفته المسمى ب مسار الملف القديم الذي تم اختيارة في مربع دايلوج اختيار الملف داخل المجلد الاب الموجود مسبقا
        Else
            Directory.CreateDirectory(StoredPath) ' اذا لم يكن موجود فيقوم بانشاء المجلد الاب من الكمبوبوكس معتمدا على سطر المسار الذي في الاعلى الذي يحتوي مسار البرنامج واسم وامتداد الملف الذي سوف نقوم بارشفته المسمى ب مسار الملف القديم الذي تم اختيارة في مربع دايلوج اختيار الملف
            NewFilePath = StoredPath & "\" & Path.GetFileName(OldFilePath)
        End If



        ' Check if The Selected File Exist فحص اذا كان الملف موجود او تم اضافته مسبقا او لا 
        If My.Computer.FileSystem.FileExists(NewFilePath) = True Then ' اذا كان موجود سوف يقوم باظهار رسالة تفيد بانه موجود من قبل 
            Dim Msg As String = " الملف الذي تم اختيارة موجود مسقبا في المجلد " & xx.FolderParent.Text & vbNewLine &
                                " يمكنك تغيير اسم الملف أو اختيار ملف اخر .. "

            If MessageBox.Show(Msg, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                GetMainFileInfo(xx) ' اذا قمت بالضغط على نعم اريد تغيير الاسم او اختيار ملف اخر يقوم بإعادة استدعاء الداله مره اخرى وتطبيق كل ماسبق ابتدائا ب فتح دايلوج اختيار الملف
            End If

        Else ' اذا لم يكن الملف موجود مسبقا فقم بعمل التالي
            xx.FileName.Text = Path.GetFileNameWithoutExtension(OldFilePath) ' يقوم بعرض الاسم الخاص بالملف بدون الامتداد في حقل اسم الملف 
            xx.FileExtenssion.Text = Path.GetExtension(OldFilePath.ToLower) ' يجلب الامتداد ويعرضه في حقل الامتداد
            xx.FileSize.Text = GetFileSize(OldFilePath) ' يجلب الحجم ويعرضه في حقل الحجم
            xx.FileType.SelectedIndex = GetFileIcon(xx.FileExtenssion.Text) ' يقوم بتحديد ايقونة الملف من الكمبوبوكس المخزن فيه القيم آليا اعتمادا على امتدادة
            xx.FileDescription.Tag = OldFilePath ' يتم تخزين اسم الملف وامتدادة ( عبر متغير المسار القديم ) للاستخدام فيما بعد في عملية الحفظ
            xx.RefrenceNum.Tag = StoredPath '   يخزن المسار كاملا الذي يحتوي على مسار البرنامج + المجلد الاب لملف في خاصية التاج حق رقم المسار للاستخدام فيما بعد في عملية الحفظ
            xx.WebBrowser1.Visible = True ' يقوم بعرض اداة العرض 
            'xx.WebBrowser1.Url = New Uri(OldFilePath) ' جعل مسار عرض اداة العرض يعرض الملف
            OpenFiles(xx, OldFilePath) ' استدعاء داله فتح الملفات بدلا من العرض في المتصفح الخاص بالنظام
        End If

    End Sub

    ' Get Main File Info second overloading دالة تحميل زائد الحصول على معلومات الملف الرئيسي 
    Public Sub GetMainFileInfo(ByVal xx As FrmAddfiles, ByVal XFilePath As String)

        Dim OldFilePath, NewFilePath, StoredPath As String

        OldFilePath = XFilePath ' XFilePath هو الملف المرسل وهو ملف البي دي اف الذي نريد ارشفته 

        ' هذا المتغير الخاص بمسار البرنامج فهو يقوم بدمج القيمة مع النص الدال ع ان المجلد خاص بنظام الأرشفة ويعمل مجلد بداخل المسار واضافة مجلد بداخله ب رقم المجلد الاب الذي تم تحويله الى بي دي اف 
        'StoredPath = My.Settings.FilePath & "\Archived Files\" & xx.FolderParent.SelectedValue  ' للكمبوبوكس القديم 
        StoredPath = My.Settings.FilePath & "\Archived Files\" & xx.FolderParent.SelectedNode.Tag


        ' Check if stored folder Exist فحص هل مجلد التخزين موجود او لا لتجنب عدم الانشاء في كل مرة اريد اضافة ملفات 
        If My.Computer.FileSystem.FileExists(StoredPath) = True Then ' اذا كان موجود
            NewFilePath = StoredPath & "\" & Path.GetFileName(OldFilePath) ' يقوم بتخزين  اسم و امتداد الملف الذي سوف نقوم بارشفته المسمى ب مسار الملف القديم الذي تم خزن ملف البي دي اف فيه
        Else
            Directory.CreateDirectory(StoredPath) ' اذا لم يكن موجود فيقوم بانشاء المجلد الاب من الكمبوبوكس معتمدا على سطر المسار الذي في الاعلى الذي يحتوي مسار البرنامج واسم وامتداد الملف الذي سوف نقوم بارشفته المسمى ب مسار الملف القديم الذي تم خزن ملف البي دي اف فيه
            NewFilePath = StoredPath & "\" & Path.GetFileName(OldFilePath)
        End If



        ' Check if The Selected File Exist فحص اذا كان الملف موجود او تم اضافته مسبقا او لا 
        If My.Computer.FileSystem.FileExists(NewFilePath) = True Then ' اذا كان موجود سوف يقوم باظهار رسالة تفيد بانه موجود من قبل 
            Dim Msg As String = " الملف الذي تم اختيارة موجود مسقبا في المجلد " & xx.FolderParent.Text & vbNewLine &
                                " يمكنك تغيير اسم الملف أو اختيار ملف اخر .. "

            If MessageBox.Show(Msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.OK Then
                GetMainFileInfo(xx, XFilePath) ' اذا قمت بالضغط على نعم اريد تغيير الاسم او اختيار ملف اخر يقوم بإعادة استدعاء الداله مره اخرى وتطبيق كل ماسبق 
            End If

        Else ' اذا لم يكن الملف موجود مسبقا فقم بعمل التالي
            xx.FileName.Text = Path.GetFileNameWithoutExtension(OldFilePath) ' يقوم بعرض الاسم الخاص بالملف بدون الامتداد في حقل اسم الملف 
            xx.FileExtenssion.Text = Path.GetExtension(OldFilePath.ToLower) ' يجلب الامتداد ويعرضه في حقل الامتداد
            xx.FileSize.Text = GetFileSize(OldFilePath) ' يجلب الحجم ويعرضه في حقل الحجم
            xx.FileType.SelectedIndex = GetFileIcon(xx.FileExtenssion.Text) ' يقوم بتحديد ايقونة الملف من الكمبوبوكس المخزن فيه القيم آليا اعتمادا على امتدادة
            xx.FileDescription.Tag = OldFilePath ' يتم تخزين اسم الملف وامتدادة ( عبر متغير المسار القديم ) للاستخدام فيما بعد في عملية الحفظ
            xx.RefrenceNum.Tag = StoredPath '   يخزن المسار كاملا الذي يحتوي على مسار البرنامج + المجلد الاب لملف في خاصية التاج حق رقم المسار للاستخدام فيما بعد في عملية الحفظ
            xx.WebBrowser1.Visible = True ' يقوم بعرض اداة العرض 
            'xx.WebBrowser1.Url = New Uri(OldFilePath) ' جعل مسار عرض اداة العرض يعرض الملف
            OpenFiles(xx, OldFilePath) ' استدعاء داله فتح الملفات بدلا من العرض في المتصفح الخاص بالنظام
        End If

    End Sub

    ' Get Attached Files Info دالة الحصول على معلومات الملفات المرفقة 
    Public Sub GetAttachedFilesInfo(ByRef xx As FrmAddfiles, ByVal dgv As DataGridView)

        ' هذا الشرط يقوم بالتحقق ما اذا كان هناك ملف اساسي او لا واذا لم يكن موجود يظهر رسالة تنبيه لاضافة الملف الاساسي 
        If xx.FileSize.Text.Trim = String.Empty Then ' تم اختيار حقل حجم الملف لانه ينزل تلقائي ولا يمكن التعديل عليه فهو في خاصية القراءة فقط 
            MessageBox.Show("يجب اضافة الملف الأساسي اولاً", "رسالة تنبية")
            xx.TabControl1.SelectedTab = xx.TabPage1 ' هذا السطر يعيدك الى التاب االولى الخاصة بالملف الاساسي
            Return
        End If


        Dim OldFilePath, XFileName As String

        Dim Ofd As New OpenFileDialog
        Ofd.Title = "اختر الملف"

        If Ofd.ShowDialog = DialogResult.OK Then ' في حاله اختيار ملف مرفق
            OldFilePath = Ofd.FileName ' نسند في المتغير مسار الملف واسمه وامتداده
            XFileName = Path.GetFileNameWithoutExtension(OldFilePath).ToString ' في هذا المتغير نخزن فيه اسم الملف فقط 


            ' check if the Selected File Exist فحص اذا كان الملف الذي تم تحديده موجود مسبقاً او لا 
            Dim Msg As String = "الملف الذي تم اختياره موجود مسبقاً ضمن المرفقات "

            For i As Int16 = 0 To dgv.Rows.Count - 1 ' عداد ليمر على جميع صفوف الداتا جريد فيو 
                If dgv(1, i).Value.ToString = XFileName Then ' يتم التحقق من العمود رقم 1 كون هو يحتوي على اسماء الملفات والصف للعداد يتم التحقق عن طريق مقارنة الاسم الخاص بالملف
                    MessageBox.Show(Msg, "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dgv(1, i).Selected = True ' يعمل تحديد على اسم الملف المكرر اضافته لمعرفته موقع الملف اين هو موجود 
                    Return ' يخرج من الدالة ولا ينفذ مابعد هذا الكود 

                End If
            Next

            ' اذا لم يكن الملف المختار موجود ضمن المرفقات يستمر التنفيذ 
            dgv.Rows.Add()
            Dim x As Integer = dgv.Rows.Count - 1
            dgv(0, dgv.Rows(x).Index).Value = 0 ' قيمة اولية لل اي دي 
            dgv(1, dgv.Rows(x).Index).Value = XFileName
            dgv(2, dgv.Rows(x).Index).Value = Path.GetExtension(OldFilePath.ToLower)
            dgv(3, dgv.Rows(x).Index).Value = GetFileSize(OldFilePath)
            dgv(4, dgv.Rows(x).Index).Value = Now.ToString("dd-MM-yyyy hh:mm:ss tt")
            dgv(5, dgv.Rows(x).Index).Value = OldFilePath
            'xx.WebBrowser1.Url = New Uri(OldFilePath) 
            OpenFiles(xx, OldFilePath) ' استدعاء داله فتح الملفات بدلا من العرض في المتصفح الخاص بالنظام

        End If
        ' end if of Ofd.ShowDialog

    End Sub

    ' Get Attached Files Info second overloading دالة تحميل زائد للحصول على معلومات الملفات المرفقة  
    Public Sub GetAttachedFilesInfo(ByRef xx As FrmAddfiles, ByVal FilePath As String)


        Dim OldFilePath, XFileName As String

        OldFilePath = FilePath ' نسند في المتغير مسار الملف واسمه وامتداده
        XFileName = Path.GetFileNameWithoutExtension(OldFilePath).ToString ' في هذا المتغير نخزن فيه اسم الملف فقط 


        ' check if the Selected File Exist فحص اذا كان الملف الذي تم تحديده موجود مسبقاً او لا 
        Dim Msg As String = "الملف الذي تم اختياره موجود مسبقاً ضمن المرفقات "

        For i As Int16 = 0 To xx.dgv.Rows.Count - 1 ' عداد ليمر على جميع صفوف الداتا جريد فيو 
            If xx.dgv(1, i).Value.ToString = XFileName Then ' يتم التحقق من العمود رقم 1 كون هو يحتوي على اسماء الملفات والصف للعداد يتم التحقق عن طريق مقارنة الاسم الخاص بالملف
                MessageBox.Show(Msg, "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                xx.dgv(1, i).Selected = True ' يعمل تحديد على اسم الملف المكرر اضافته لمعرفته موقع الملف اين هو موجود 
                Return ' يخرج من الدالة ولا ينفذ مابعد هذا الكود 

            End If
        Next

        ' اذا لم يكن الملف المختار موجود ضمن المرفقات يستمر التنفيذ 
        xx.dgv.Rows.Add()
        Dim x As Integer = xx.dgv.Rows.Count - 1 ' المتغير هذا يحتوي على عدد السجلات الخاصة  بالداتا جريد فيو وسوف نستخدمه لكي نظيف البيانات في اخر سجل تم اضافته بالسطر السابق  
        xx.dgv(0, x).Value = 0 ' قيمة اولية لل اي دي 
        xx.dgv(1, x).Value = XFileName
        xx.dgv(2, x).Value = Path.GetExtension(OldFilePath.ToLower)
        xx.dgv(3, x).Value = GetFileSize(OldFilePath)
        xx.dgv(4, x).Value = Now.ToString("dd-MM-yyyy hh:mm:ss tt")
        xx.dgv(5, x).Value = OldFilePath
        'xx.WebBrowser1.Url = New Uri(OldFilePath)
        OpenFiles(xx, OldFilePath) ' استدعاء داله فتح الملفات 

    End Sub

    ' Add Files Form Formatting اجراء تهئية فورم اضافة الملفات 
    Public Sub AddFilesFormFormatting(ByVal xx As FrmAddfiles)

        xx.btnScan.Enabled = False
        xx.btnbrows.Enabled = False
        xx.btnSave.Enabled = False
        xx.btnEdit.Enabled = False
        xx.btnDelete.Enabled = False
        Clear_Control_On_TabControl(xx.TabControl1)
        xx.TabControl1.Enabled = False

        xx.WebPanel.BringToFront()
        xx.WebBrowser1.BringToFront()
        xx.PictureBox1.Image = Nothing
        xx.lblImagePath.Text = Nothing
        xx.ComboBox1.SelectedIndex = 4
        xx.txtReader.Clear()
        xx.AxAcroPDF1.src = Nothing

    End Sub


    '  Delete From DataBase حذف من قاعدة البيانات بشكل نهائي 
    Public Sub Delete_FromDataBase(ByVal TableName As String, ByVal ColumnName As String, ByVal ID As String, ByVal lbl As Label, ByVal Pic As PictureBox, ByVal t As Timer)

        Try

            Dim DT As New DataTable
            'DT.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter(" Delete from" & TableName & "  where " & ColumnName & " = " & ID & "", Con)
            da.Fill(DT)
            DT.Dispose()
            da.Dispose()
            ConfirmMessage(lbl, Pic, t, "تم الحذف بنجاح")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'Create Archive PDF  اجرائية انشاء ملف pdf للصور لعمل ارشفة 
    ' يتبع شاشة الماسح الضوئي
    Public Sub CreateAndArchivePDF(ByVal xx As FrmScan)
        Try
            If xx.CheckedListBox1.Items.Count = 0 Then Return ' اولا نبدا نتحقق هل يوجد صور في القائمة اذا لاتوجد فيقوم بالخروج من الاجراء 
            If MyTextNull(xx.txtFileName, "اسم الملف الذي تريد انشائه") Then Return '   نتحقق هل يوجد اسم للملف الذي تريد انشائه  اذا لايوجد فيقوم بالخروج من الاجراء

            If My.Settings.PDFFolderPath = String.Empty Then ' اذا كان  متغير أو مسار حفظ ملف البي دي اف على الجهاز فارغ يقوم باعطاء رسالة تفيد بتحديد الجدول ويقوم بالخروج من الاجراء 
                MessageBox.Show("اختر مسار حفظ ملفات الــ " & vbNewLine & "PDF", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim CreatedFileFolder As String = My.Settings.PDFFolderPath ' يتم اخذ المسار الخاص بالحفظ الى هذا المتغير
            Dim CreatedFilePath As String = CreatedFileFolder & "\" & xx.txtFileName.Text.Trim & ".pdf" ' ينشى الملف في جهاز الكمبيوتر بنائا على المسار و اسم الملف والامتداد ويخزنه في هذا المتغير 

            If My.Computer.FileSystem.FileExists(CreatedFileFolder) = False Then Directory.CreateDirectory(CreatedFileFolder) ' يتم التحقق هل ان مجلد المسار موجود على الكمبيوتر اذا لم يوجد يقوم بانشائه

            TPro.ConvertImagesToPDF(xx.CheckedListBox1, CreatedFilePath) ' داله التحويل مأخوذة من مكتبة تسهيل برو وتمرر للدالة القائمة الخاصة بالصور و اسم الملف والامتداد الموجود في المتغير الذي في الاعلى  

            If MessageBox.Show("هل تود أرشفة الملف " & xx.txtFileName.Text.Trim, "رسالة تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ' يتم السؤال بعد التحويل مباشرة اذا كان المستخدم يريد أرشفة ملف البي دي اف او لا اذا نعم يتم تنفيذ التالي  
                xx.Close() ' اغلاق واجهة الفحص frmScan
                ' يتم فحص المتغير العام حيث اذا كان 1 فيعتبر الملف خاص بالملف الاساسي وتم مسحه من واجهة الملفات الرئيسية واذا ب 2 فهو خاص ب ملف المرفقات وتم مسحه من واجهة ملفات المرفقات 
                If ScanTo = 1 Then
                    'Get Man File info
                    GetMainFileInfo(FrmAddfiles, CreatedFilePath)
                ElseIf ScanTo = 2 Then
                    'Get Attached Files Info
                    GetAttachedFilesInfo(FrmAddfiles, CreatedFilePath)
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Open Files اجرائية فتح الملفات 
    Public Sub OpenFiles(ByVal xx As FrmAddfiles, ByVal XfilePath As String)
        Try

            Dim extension As String = Path.GetExtension(XfilePath.ToLower)

            Select Case extension

                Case ".jpg", ".png", ".jpge", ".gif", ".tiff", ".dng", ".emf", ".raw", ".ico", ".bmp", ".jpeg"

                    xx.PicPanel.BringToFront()
                    Dim bt As New Bitmap(XfilePath)
                    xx.PictureBox1.Image = bt
                    xx.lblImagePath.Text = XfilePath

                Case ".pdf"
                    xx.PDFPanel.BringToFront()
                    xx.AxAcroPDF1.src = XfilePath

                Case ".html", ".htm", ".asp", ".aspx", ".css", ".php", ".js", ".url"
                    xx.WebPanel.BringToFront()
                    xx.WebBrowser1.Visible = True
                    xx.WebBrowser1.Url = New Uri(XfilePath)

                Case ".doc", ".docx"
                    xx.txtPanel.BringToFront()
                    Dim readonly1 As Object = True
                    Dim visible As Object = True
                    Dim filename As Object = XfilePath
                    Dim missing As Object = Type.Missing

                    Dim doc1 As Microsoft.Office.Interop.Word._Document = Nothing
                    Dim word1 As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application() With {.visible = False}
                    doc1 = word1.Documents.Open(filename, readonly1, visible)
                    doc1.ActiveWindow.Selection.WholeStory()
                    doc1.ActiveWindow.Selection.Copy()
                    Dim data1 As IDataObject = Clipboard.GetDataObject
                    xx.txtReader.Rtf = data1.GetData(DataFormats.Rtf).ToString
                    word1.Quit(missing)


                Case ".txt", ".log", ".ini", ".sql"
                    xx.txtPanel.BringToFront()
                    xx.txtReader.Text = My.Computer.FileSystem.ReadAllText(XfilePath)

                Case Else
                    Process.Start(XfilePath)
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Build Tree in ComboTreeBox   اجرائية بناء شجرة الارشفة داخل الكومبوبوكس تري
    Public Sub BuildComboTreeBox(ByVal key As String, ByVal txt As String, ByVal N As ComboTreeNode, ByVal ImgIndex As Int16, ByVal CTB As ComboTreeBox, ByVal DT As DataTable)

        Dim CNT As ComboTreeNode     ' تعريف كائن من كلاس كومبو تري نود لكي نتعامل بهذا الكائن 

        If N Is Nothing Then ' اذا كانت الشجرة فارغة 
            CNT = CTB.Nodes.Add(txt) ' فقم باضافة اسم الجدول في العقدة الاولى 
            CNT.ImageIndex = ImgIndex ' موقع الصورة او الايقونة = الموقع الممر عبر الدالة 
            CNT.ExpandedImageIndex = ImgIndex ' وقع الصورة او الايقونة = الموقع الممر عبر الدالة حسب تسلسل المجلد في الشجرة 
            CNT.Tag = key ' نحتفظ ب رقم رقم المجلد   في خاصية التاج الخاص بالعقدة لاستخدامة لاحقا باشياء اخرى 
        Else ' في حال توجد عقدة 
            CNT = N.Nodes.Add(txt) ' نظيف المجلد الممرر عبرة الدلة ونظيفة الى العقدة السابقة حيث ن هي العقدة السابقة 
            CNT.ImageIndex = ImgIndex ' موقع الصورة او الايقونة = الموقع الممر عبر الدالة حسب تسلسل المجلد في الشجرة 
            CNT.ExpandedImageIndex = 27 ' ظهور ايقونة فتح المجلدات عند التحديد على المجلد  - حسب تسلسلها في اداة imagelist
            CNT.Tag = key ' نحتفظ ب رقم رقم المجلد في خاصية التاج الخاص بالعقدة لاستخدامة لاحقا باشياء اخرى 
        End If

        ' هذا الكود يتكرر في جميع الحالات 
        Dim dv As DataView = DT.DefaultView
        Dim xkey As Int64 = Convert.ToInt64(key) ' UInt64 for above big tree

        dv.RowFilter = "FolderParent = '" & xkey & "'" ' نقوم بعمل فلترة للعناصر بنائاً على المجلد الاب الذي يساوي المتغير المعبر عن رقم المجلد 


        For Each dr As DataRow In dv.ToTable.Rows
            BuildComboTreeBox(dr("FolderNumber"), dr("FolderName"), CNT, dr("FolderImageIndex"), CTB, DT)
        Next
        DT.Dispose()


    End Sub


    'Fill ComboTreeBox by Folders اجرائية تعبئة الكومبوبوكس تري بشجرة المجلدات في شاشة اضافة المجلدات
    Public Sub FillMyComboTreeBox(ByVal xx As FrmAddfiles)

        Dim DT As New DataTable

        DT = GetDataTable("SelectFolderTree", Nothing) ' نمرر لدالة اسم الاجراء المخزن والاشي تقصد بانه لايوجد براميتر 
        xx.FolderParent.Nodes.Clear()
        BuildComboTreeBox("0", "شجرة المجلدات", Nothing, 0, xx.FolderParent, DT)
        xx.FolderParent.FirstVisibleNode.FontStyle = FontStyle.Bold

    End Sub

    'Fill ComboTreeBox by Folders اجرائية تعبئة الكومبوبوكس تري بشجرة المجلدات في شاشة اضافة المجلدات
    ' خاص بشاشة المجلدات
    Public Sub FillMyComboTreeBox(ByVal xx As FrmAddFolders)

        Dim DT As New DataTable

        DT = GetDataTable("SelectFolderTree", Nothing) ' نمرر لدالة اسم الاجراء المخزن والاشي تقصد بانه لايوجد براميتر 
        xx.FolderParent.Nodes.Clear()
        BuildComboTreeBox("0", "شجرة المجلدات", Nothing, 0, xx.FolderParent, DT)
        xx.FolderParent.FirstVisibleNode.FontStyle = FontStyle.Bold

    End Sub

    ' Check before Save فحص  قبل الحفظ  
    Function CheckBeforeSave(ByVal xx As FrmAddfiles) As Boolean

        If MyTextNull(xx.FileCode, "رقم الملف") Then Return True '

        ' الكمبوبوكس القديم
        'If xx.FolderParent.SelectedNode Is Nothing Then '
        '    MessageBox.Show(" من فضلك اختر المجلد الاب للملف", "رساله تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    xx.FolderParent.Focus() '
        '    Return True
        'End If

        If MyComboTreeBoxNodeIsNull(xx.FolderParent, " المجلد الأب أولا ") Then Return True ' بدلا عن الاسطر المعلقة 


        If MyTextNull(xx.FileName, "اسم الملف") Then Return True '
        If MyCombIndexNull(xx.FileType, "نوع الملف") Then Return True '
        If xx.FileSecret.Checked = True And xx.FilePassword.Text.Trim = String.Empty Then xx.FileSecret.Checked = False
        Return False




    End Function

    'To Build AttachedFiles Table ( DTAttaches ) دالة بناء جدول المرفقات الخاصة بالملفات المرفقة الذي سوف نرسله دفعة واحدة كبراميتر الى الاجراء المخزن في السيكول سيرفر الذي تم بناءة مسبقا باسم  
    Private Function BuildAttachedFilesTable(ByVal dgv As DataGridView, ByVal SaveIn As Boolean) As DataTable

        Dim dt As New DataTable   '  نعرف جدول ونضيف فيه الحقول التالية 
        dt.Columns.Add("ParentID")
        dt.Columns.Add("FileName")
        dt.Columns.Add("FileExtenssion")
        dt.Columns.Add("FileSize")
        dt.Columns.Add("FileData", Type.GetType("System.Byte[]"))  '  هذا الحقل يم تخزين فيه المرفق كمصفوفة بايتات
        dt.Columns.Add("FileOrder")

        For i As Int16 = 0 To dgv.Rows.Count - 1 ' فور تساوي عدد السجلات في الداتا جريد فيو
            If Val(dgv(0, i).Value) > 0 Then Continue For '  اذا كانت القيمة الموجودة في الصف الحالي ( حسب قيمة الفور ) اكبر من الصفر فقم بالاستمرار بالفور والسبب هو انه اذا هناك ملف مرفق جديد سوف يتم عمل عليها اضافة واما بقية المرفقات فانها موجودة مسبقا - وسبب انه اكبر من الصفر لان قيمة الملف الجديد حسب رقم المتسلسل الايدي تساوي 0 اما اذا كان موجود مسبقا فسيكون اكبر من 0 
            If SaveIn = True Then ' اذا كانت قيمة متغير تحديدالحفظ تساوي 1 ف الحفظ يكون في قاعدة البيانات 
                ' كل قيمة تمثل الحقل في الداتا جريد فيو حسب تسلسل الاعمدة
                dt.Rows.Add(0, dgv(1, i).Value, dgv(2, i).Value, dgv(3, i).Value, ReadFileData(dgv(5, i).Value), i + 1) ' لذلك نقوم ببناء الجدول كاملا ويحتوي على المرفق في اخر عمود 
            Else ' اذا كانت قيمة متغير تحديدالحفظ تساوي 0 ف الحفظ يكون في مجلدات الجهاز 
                dt.Rows.Add(0, dgv(1, i).Value, dgv(2, i).Value, dgv(3, i).Value, Nothing, i + 1) ' لذلك فاننا نقوم بتمرير البيانات جميعها ولكن اخر شي لانمرر شي في عمود بيانات الملف  
            End If
        Next
        Return dt ' ارجاع الجدول 
        dt.Dispose() ' تنظيف الجدول 
    End Function


    ' Save Files Data حفظ بيانات الملفات 
    Public Sub Save_Files(ByVal xx As FrmAddfiles, ByVal SaveIn As Boolean)
        Try
            If CheckBeforeSave(xx) = True Then Return ' اي لم يتم تعبئة بعض الحقول حسب عمل الدالة 

            Dim Cmd As SqlCommand
            Cmd = New SqlCommand("InsertFiles", Con)
            Cmd.CommandType = CommandType.StoredProcedure

            Dim Paramter(14) As SqlParameter

            Paramter(0) = New SqlParameter("@FileCode", SqlDbType.Decimal, 28)
            Paramter(0).Value = CDec(xx.FileCode.Text)

            Paramter(1) = New SqlParameter("@FileName", SqlDbType.NVarChar, 300)
            Paramter(1).Value = xx.FileName.Text


            Paramter(2) = New SqlParameter("@FolderParent", SqlDbType.Decimal, 25)
            Paramter(2).Value = CDec(xx.FolderParent.SelectedNode.Tag)

            Paramter(3) = New SqlParameter("@RefrenceNum", SqlDbType.NVarChar)
            Paramter(3).Value = xx.RefrenceNum.Text

            Paramter(4) = New SqlParameter("@FileDescription", SqlDbType.NVarChar)
            Paramter(4).Value = xx.FileDescription.Text

            Paramter(5) = New SqlParameter("@FileExtenssion", SqlDbType.VarChar, 10)
            Paramter(5).Value = xx.FileExtenssion.Text

            Paramter(6) = New SqlParameter("@FileSize", SqlDbType.VarChar, 20)
            Paramter(6).Value = xx.FileSize.Text

            Paramter(7) = New SqlParameter("@FileType", SqlDbType.TinyInt)
            Paramter(7).Value = CShort(xx.FileType.SelectedIndex)

            Paramter(8) = New SqlParameter("@FileSecret", SqlDbType.Bit)
            Paramter(8).Value = CBool(xx.FileSecret.Checked)

            Paramter(9) = New SqlParameter("@FilePassword", SqlDbType.NVarChar, 25)
            Paramter(9).Value = xx.FilePassword.Text

            Paramter(10) = New SqlParameter("@AddUser", SqlDbType.TinyInt)
            Paramter(10).Value = LogUserID

            Paramter(11) = New SqlParameter("@DTAttaches", SqlDbType.Structured) ' النوع الذي تم انشاءه كجدول داخل السيكول سيرفر ويعتبر متغير معرف من قبل المستخدم
            Paramter(11).Value = BuildAttachedFilesTable(xx.dgv, SaveIn) ' وقيم هذا الاستركشر ناخذه عن طريق هذه الدالة التي قمنا بعمله لبناء جدول بيانات المرفقات + تمرير المتغير الذي يحدد نوع الحفظ   


            ' متغير يعيد لنا قيمة بعد عملية الحفظ وهذه القمية اما رقم الملف اذا تم التنفيذ بشكل سليم واذا لا يرجع القمية 0  
            Paramter(12) = New SqlParameter("@ID", SqlDbType.Int)
            Paramter(12).Direction = ParameterDirection.Output ' الدايركشن اي الاتجاه الخاص به هو من نوع مخرج ولي مدخل للبيانات 

            ' يمرر القيمة التي تحدد مكان الحفظ  
            Paramter(13) = New SqlParameter("@SavedIn", SqlDbType.Bit)
            Paramter(13).Value = SaveIn

            ' 
            Paramter(14) = New SqlParameter("@FilesData", SqlDbType.VarBinary)
            If SaveIn = True Then Paramter(14).Value = ReadFileData(xx.FileDescription.Tag.ToString) Else Paramter(14).Value = Nothing
            '  اذا كانت قيمة المتغير 1 سوف ياخذ البراميتر البيانات من الدالة (ReadFileData) 
            ' وهذه الدالة مهمتها هي قراءة الملف لغرض التخزين في قاعدة البيانات ونمرر لها مسار الملف الموجود بخاصية التاج الخاص بحقل الوصف وهي تعيد الملف كمصوصفة بايتات
            ' واذا كان 0 فلا يمرر اي شي 




            Cmd.Parameters.AddRange(Paramter)
            OpenConnection()
            Cmd.ExecuteNonQuery()
            CloseConnection()



            If Paramter(12).Value > 0 Then ' قيمة المتغير من نوع اوتبوت الذي ترجع قيمته من السيكول اذا كانت اكبر من الصفر اي انه تمت عملية الحفظ بنجاح وتم ارجاع رقم الملف 
                xx.ReturnID = Paramter(12).Value ' نخزن القيمة المرتجعة في المتغير الخاص بالرقم الراجع
                If SaveIn = False Then xx.BackgroundWorker1.RunWorkerAsync() '  فحص لو قيمة متغير الحفظ ب 0 اي ان الحفظ في الجهاز وليس في قاعدة البانات  فيقوم بتنفيذ كود الخلفية على حدث الووركر الذي يقوم بنسخ الملف وعمله في مسار حفظ الملفات الخاصة بالبرنامج في الخلفية ووظيفته انه يقوم بنسخ الملف للمجلد الجديد ويقوم بحذفه من المجلد القديم ولو كانت القيمة ب 1 اي الحفظ في قاعدة البيانات فلن يتم تنفيذ هذا الكود 
                ConfirmMessage(xx.lblconfirmMessage, xx.PicMessage, xx.Timer1, "تم الحفظ بنجاح") ' اظهار رسالة تم الحفظ بنجاح 



                xx.btnNew.PerformClick() ' تنفيذ او ضغط على زر جديد 
            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Copy Saved File  اجراء نسخ الملف الذي قمنا بارشفته من مكانه الى المسار الخاص بحفظ ملفات البرنامج  
    Public Sub CopySavedFile(ByVal xx As FrmAddfiles, ByVal FileID As String)


        Try

            Dim StoredPath As String ' تعريف متغير لتخزين المسار
            StoredPath = My.Settings.FilePath & "\Archived Files\" & xx.FolderParent.SelectedNode.Tag.ToString ' تخزين المسار الجديد والمكون من مسار القرص الموجود في متغير التعديلات + اسم مجلد البرنامج + رقم المجلد الاب الجديد الخاص بالملف   
            If My.Computer.FileSystem.FileExists(StoredPath) = False Then Directory.CreateDirectory(StoredPath) ' اذا المجلد الذي بهذا المسار غير موجود في جهاز الكمبوتر يقوم بانشاءه

            File.Copy(xx.FileDescription.Tag, StoredPath & "\" & Path.GetFileName(xx.FileDescription.Tag)) ' اتمام عملية النسخ ع طريق داله النسخ والتي تستقبل الملف مع مساره السابق وهو المخزن في خاصية التاج الخاصة بحقل وصف الملف + القيمة الاخرى هي الملف ومساره الجديد

            If xx.dgv.Rows.Count > 0 Then ' هل يوجد صفوف في الداتا جريد فيو الخاصة بالملفات المرفقة وفي حال كان هناك صفوف
                StoredPath = StoredPath & "\" & FileID ' اضف الى متغير المسار السابق رقم ملف الاب التسلسلي  
                If My.Computer.FileSystem.FileExists(StoredPath) = False Then Directory.CreateDirectory(StoredPath) ' اذا لم يكون موجود هذا المجلد الخاص بالمرفقات في الجهاز فقم بانشاءه

                For i As Int16 = 0 To xx.dgv.Rows.Count - 1 ' فور تساوي عدد السجلات في الداتا جريد فيو 
                    File.Copy(xx.dgv(5, i).Value, StoredPath & "\" & Path.GetFileName(xx.dgv(5, i).Value)) ' تقوم بنسخ الملفات المرفقة الى المسار الجديد
                Next
            End If

            If xx.btnEdit.Enabled = True Then ' اذا كان زر التعديل مفعل اي اننا في وضع التعديل وليس الاضافة
                File.Delete(xx.FileDescription.Tag) ' قم بحذف الملف الاساسي  من المسار القديم 
                For i As Int16 = 0 To xx.dgv.Rows.Count - 1 ' فور تساوي عدد السجلات في الداتا جريد فيو
                    File.Delete(xx.dgv(5, i).Value) ' قم بحذف الملفات المرفقة للملف الاساسي من المسار القديم
                Next
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Read File Data قراءة بيانات الملف
    ' وهذه الدالة مهمتها هي قراءة الملف لغرض التخزين في قاعدة البيانات ونمرر لها مسار الملف الموجود بخاصية التاج الخاص بحقل الوصف وهي تعيد الملف كمصوصفة بايتات
    Private Function ReadFileData(ByVal FilePath As String) As Byte()

        Dim fileStream As New FileStream(FilePath, FileMode.Open, FileAccess.Read) '  دالة لقراءة الملف نمرر لها مسار املف ووضع املف ووالوصول للملف للقراءة

        Dim Br As New BinaryReader(fileStream) ' ننشى كائن من نوع قارى من نوع ثنائي ونمرر له الملف المخزن في الذاكرة 

        Dim FileData() As Byte = Br.ReadBytes(Br.BaseStream.Length) '  نعرف مصفوفة من نوع ثنائي ونجعلة يقرا جميع البايتات ونمرر له حجم الملف الذي تتم تمريره الى الكائن الثنائي  

        Return FileData ' نرجع مصفوفة البايتات التي تحتو على الملف 

    End Function

    ' وظيفة هذا الاجراء تنفيذ الاجراء المخزن الخاص بالبحث و عرض البيانات على الداتا جريد فيو 
    ' Search In Archive Tree البحث في شجرة الأرشفة 
    Public Sub SearchInArchiveTree(ByVal TXT As TextBox, ByVal dgv As DataGridView)

        If TXT.Text.Trim = String.Empty Then  ' فحص هل حقل البحث فارغ  في حاله انه فارغ
            dgv.Visible = False  ' اخفاء الداتاجريدفيو
            dgv.DataSource = Nothing  ' وجعل المصدر الخاص بها لاشي كي تحذف البيانات 
        Else  ' في حاله انه يوجد نص بالحقل
            ' نقوم بانشاء براميتر لارسال القيمة بالنص للسيكول وتنفيذ الاجراء المخزن الخاص بعملية البحث
            Dim paramter(0) As SqlParameter
            paramter(0) = New SqlParameter("@SearchName", SqlDbType.NVarChar, 300)
            paramter(0).Value = TXT.Text.Trim

            Dim dt As New DataTable
            dt = GetDataTable("[SearchInArchiveTree]", paramter) ' هذه داله تعمل على جلب البيانات الناتجة من الاجراء المخزن 

            If dt.Rows.Count > 0 Then  ' ي حال وجود صفوف في الداتا جريد فيو 
                dgv.Visible = True ' نظهر الداتا جريد فيو
                dgv.AutoGenerateColumns = False ' نغلق خاصية توليد الاعمدة التلقائية  
                dgv.DataSource = dt ' مصدرها الجدول الناتج من الاستعلام المخزن
            Else ' في حاله لا توجد صفوف
                dgv.Visible = False ' لايتم اظهار الداتا جريد فيو
                dgv.DataSource = Nothing  ' وجعل المصدر الخاص بها لاشي كي تحذف البيانات 
            End If

        End If

    End Sub


    ' وظيفة هذا الاجراء هي البحث عن العقدة - المجلد او الملف - الذي تم البحث عنه في الشجرة عبر استخدام الاجراء السابق الذي بالاعلى ويقوم بتحديده والانتقال اليه 
    ' To Find Search Item ايجاد العنصر الذي بحثنا عنه 
    Public Sub FindSearchItem(ByVal dgv As DataGridView, ByVal Tv As TreeView, ByVal TXT As TextBox)

        Try

            Dim xCode As String = dgv.CurrentRow.Cells("xCode").Value ' نعرف متغير من نوع نص ونجعله = قيمة الخانه للصف الحالي وهي رقم الملف أو المجلد 
            dgv.Visible = False  ' اخفاء الداتاجريدفيو
            dgv.DataSource = Nothing  ' وجعل المصدر الخاص بها لاشي كي تحذف البيانات 

            ' نعرف مصفوفة من نوع عقدة في الشجرة ونجعله = داله البحث عن اي عقدة في الشجرة 
            ' ونمرر لها القمية المراد البحث عنها و متغير بولين اذا كان ترو فيقوم بالبحث في العقد الرئيسية والابناء واذا كان فولس سيبحث في العقد الاباء فقط
            Dim xFind() As TreeNode = Tv.Nodes.Find(xCode, True)
            Tv.SelectedNode = xFind(0) ' نقوم بالتحديد على العقدة بواسطة موقع المصفوفه التي خزنت فيه البيانات وهو الموقع 0 0 لان القيمة المرسلة هي قيمة واحدة 
            TXT.Clear() ' تنظيف الحقل 
            TXT.Focus() ' جعل المؤشر في حقل البحث


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    '' تم تعليق هذه الدالة وتجزئتها الى 3 اجزاء في الاسفل منها 
    '' Open Selected File In Archived Tree فتح الملف عند التحديد عليه في شجرة الارشفة
    'Public Sub OpenSelectedFileInArchivedTree(ByVal xx As FrmMainPage, ByVal FileCode As Decimal, ByVal SavePath As String)
    '    Try

    '        Dim Paramter(1) As SqlParameter

    '        Paramter(0) = New SqlParameter("@FileCode", SqlDbType.Decimal, 28)
    '        Paramter(0).Value = FileCode

    '        Paramter(1) = New SqlParameter("@SavePath", SqlDbType.NVarChar, 200)
    '        Paramter(1).Value = SavePath

    '        Dim dt As New DataTable
    '        dt = GetDataTable("OpenSelectedFile", Paramter)

    '        If dt.Rows(0).Item("xx") = 0 Then
    '            xx.WebBrowser1.Url = New Uri(dt.Rows(0).Item("FileFullPath"))
    '            ' xx.AxAcroPDF1.src = dt.Rows(0).Item("FileFullPath") '   في حالة استخدام مكتبة ايكروبات 
    '        Else
    '            Dim FileData() As Byte = CType(dt.Rows(0).Item("FileData"), Byte())
    '            Dim FileStream As New FileStream(dt.Rows(0).Item("FullName"), FileMode.OpenOrCreate, FileAccess.Write)
    '            FileStream.Write(FileData, 0, FileData.Length)
    '            FileStream.Close()

    '            xx.WebBrowser1.Url = New Uri(dt.Rows(0).Item("FullName"))
    '            'xx.AxAcroPDF1.src = dt.Rows(0).Item("FullName") '   في حالة استخدام مكتبة ايكروبات 
    '        End If

    '        dt.Dispose()

    '    Catch ex As Exception
    '        Return
    '    End Try

    'End Sub


    ' Get Info OF Selected File in ArchiveTree اجراء جلب  بيانات أو معلومات الملف الذي قمنا بتحديدة عند تنفيذ الاجراء المخزن
    Public Function GetInfo_OF_SelectedFileInArchivedTree(ByVal FileCode As Decimal, ByVal SavePath As String) As DataTable

        Dim Paramter(1) As SqlParameter

        Paramter(0) = New SqlParameter("@FileCode", SqlDbType.Decimal, 28)
        Paramter(0).Value = FileCode

        Paramter(1) = New SqlParameter("@SavePath", SqlDbType.NVarChar, 200)
        Paramter(1).Value = SavePath

        Dim dt As New DataTable
        dt = GetDataTable("[OpenSelectedFile]", Paramter)
        Return dt ' ترجع جدول
        dt.Dispose()
    End Function

    'Check IF Selected File Secret دالة التحقق من ان الملف المحدد محمي 
    Public Sub CheckIFSelectedFileSecret(ByVal xx As FrmMainPage, ByVal op As Boolean) ' , ByVal op As Boolean  ' هذا المتغير لمعرفه نوع الاستعراض هل سيكون تعديل ام فتح وهو من اضافتي على البرنامج

        ' سبب اضافتي لهذه الفقرة هي انه عندما يكون الملف محمي بكلمة سر يجب عندما نقوم باختيار التعديل على الملف يجب ان يظهر اولا نافذه كلمة المرور وعند تجاوزها يسمح بالتعديل والا فلا يسمح

        If op = True Then ' اذا كان صحيح اي 1 فهو يعني الفتح العادي 

            Dim dt As New DataTable
            dt = GetInfo_OF_SelectedFileInArchivedTree(CDec(xx.TreeView1.SelectedNode.Tag), My.Settings.FilePath & "Archived Files\") ' يتم اسناد البيانات او المعلومات الخاصه بالملف الى الجدول الذي هنا عبر استدعاء دالة جلب معلومات الملف المحدد 
            If dt.Rows(0).Item("isFileSecret") = True Then ' فحص ماذا كانت قيمة العمود 1 اي ان الملف محمي 
                Dim zz As New FrmPassword  ' نقوم بانشاء كائن من واجهة كلمة المرور
                zz.ShowDialog() ' نعرضها 
                If zz.InputText = Nothing Then Return ' في حاله كان الحقل فارغ بعد قم بالخروج 
                If zz.InputText = dt.Rows(0).Item("FilePassword") Then ' اذا كانت كلمة المرور المكتوبة بالحقل مساوية لكلمة المرور الاصلية 
                    OpenSelectedFileInArchivedTree(xx, dt) ' يتم استدعاء داله الفتح للملف وتمرير الملف له 
                Else ' في حاله ان كلمة المرور خاطئة تظهر الرسالة هذه 
                    MessageBox.Show("معذرةً ، كلمة المرور الذي ادخلتها غير صحيحة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else ' في حاله لم يكن الملف محمي 
                OpenSelectedFileInArchivedTree(xx, dt) ' يتم استدعاء داله الفتح للملف مباشرة وتمرير الملف له 
            End If
            dt.Dispose()

        End If

        If op = False Then ' في حالة كان خطأ اي 0 فالاختيار للتعديل 

            Dim dt As New DataTable
            dt = GetInfo_OF_SelectedFileInArchivedTree(CDec(xx.TreeView1.SelectedNode.Tag), My.Settings.FilePath & "Archived Files\") ' يتم اسناد البيانات او المعلومات الخاصه بالملف الى الجدول الذي هنا عبر استدعاء دالة جلب معلومات الملف المحدد ونمرر للدالة رقم الملف الموجود في خاصية التاج في العقدة الشجرية ونمرر لها ايضا مسار الملف الكامل الخاص بالتخزين وندمجه مع اسم المجلد على القرص  
            If dt.Rows(0).Item("isFileSecret") = True Then ' فحص ماذا كانت قيمة العمود 1 اي ان الملف محمي عن طريق القيمة الراجعة من الاستعلام 
                Dim zz As New FrmPassword  ' نقوم بانشاء كائن من واجهة كلمة المرور
                zz.ShowDialog() ' نعرضها 
                If zz.InputText = Nothing Then Return ' في حاله كان الحقل فارغ بعد قم بالخروج 
                If zz.InputText = dt.Rows(0).Item("FilePassword") Then ' اذا كانت كلمة المرور المكتوبة بالحقل مساوية لكلمة المرور الاصلية 

                    If MessageBox.Show("هل تود تنفيذ عملية التعديل ؟", "رسالة تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                        'ClearWebBrowser() ' تنظيف لأداة العرض الخاصة بالملفات
                        Dim xxx As New FrmAddfiles ' عمل كائن من نوع شاشة اضافة الملفات
                        xxx.XFileCode = xx.TreeView1.SelectedNode.Tag ' قم بجعل قيمة متغير رقم الملف تساوي قيمة رقم الملف الذي تم التحديد عليه في الشجرة لاجراء التعديل عليه وذلك لكي يحمل الملف ويعرض مع جميع تفاصيله في الواجهة الخاصة باضافه الملفات عند النقر على التعديل
                        xxx.ShowDialog() ' عرض الشاشة
                    End If


                Else ' في حاله ان كلمة المرور خاطئة تظهر الرسالة هذه 
                    MessageBox.Show("معذرةً ، كلمة المرور الذي ادخلتها غير صحيحة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else ' في حاله لم يكن الملف محمي 

                ' هذا الكود كان في زر التعديل وتم نقله الى هنا ليؤدي الغرض الخاص به
                If MessageBox.Show("هل تود تنفيذ عملية التعديل ؟", "رسالة تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                    'ClearWebBrowser() ' تنظيف لأداة العرض الخاصة بالملفات
                    Dim xxx As New FrmAddfiles ' عمل كائن من نوع شاشة اضافة الملفات
                    xxx.XFileCode = xx.TreeView1.SelectedNode.Tag ' قم بجعل قيمة متغير رقم الملف تساوي قيمة رقم الملف الذي تم التحديد عليه في الشجرة لاجراء التعديل عليه وذلك لكي يحمل الملف ويعرض مع جميع تفاصيله في الواجهة الخاصة باضافه الملفات عند النقر على التعديل
                    xxx.ShowDialog() ' عرض الشاشة
                End If


            End If
            dt.Dispose()

        End If


    End Sub

    'Open Selected File in ArchiveTree دالة فتح الملف المحدد في شجرة الأرشفة 
    Public Sub OpenSelectedFileInArchivedTree(ByVal xx As FrmMainPage, ByVal dt As DataTable)
        Try
            '  xx ترمز لمتغير الذي يحدد مكان الحفظ 
            If dt.Rows(0).Item("xx") = 0 Then ' اذا كان الملف غير مخزن في قاعدة البيانات اي انه في ملفات الجهاز 

                OpenFilesInMainPage(xx, dt.Rows(0).Item("FileFullPath"))
                'xx.WebBrowser1.Url = New Uri(dt.Rows(0).Item("FileFullPath")) ' قم بفتحه مباشرة 
                'xx.AxAcroPDF1.src = dt.Rows(0).Item("FileFullPath") ' قم بفتحه مباشرة  في حالة استخدام مكتبة ايكروبات 
            Else ' اذا كان الملف مخزن في قاعدة البيانات 
                Dim FileData() As Byte = CType(dt.Rows(0).Item("FileData"), Byte()) ' نقوم بانشاء مصفوفة ونمرر لها القيم الموجودة في حقل بيانات الملف وهي الملف نفسه ويتم تمريرها كمصفوفة بايتات 
                Dim FileStream As New FileStream(dt.Rows(0).Item("FullName"), FileMode.OpenOrCreate, FileAccess.Write) ' نحجز مساحة في الذاكرة ونمررلها اسم الملف كامل  -  الذي يمرر للدالة  1 اسم الملف 2 وضع الملف اذا موجود اعمل فتح واذا لا انشئه 3 صلاحية الوصول  
                FileStream.Write(FileData, 0, FileData.Length) '  نقوم بعمل كتابة ونمرر الملف والقمية 0 و طول الملف لكي تتم الكتابه كاملة 
                FileStream.Close() ' نغلق مساحة الذاكرة 

                OpenFilesInMainPage(xx, dt.Rows(0).Item("FullName"))
                'xx.WebBrowser1.Url = New Uri(dt.Rows(0).Item("FullName")) ' يتم عرض الملف في المتصفح حق النظام عن طريق تمرير الملف من الجدول 
                'xx.AxAcroPDF1.src = dt.Rows(0).Item("FullName") '   في حالة استخدام مكتبة ايكروبات 
            End If
        Catch ex As Exception
            Return ' رجوع في حالة وجود خطأ 
        End Try
    End Sub

    ' Open Files In MainPage اجرائية فتح الملفات في الواجهة الرئيسية
    Public Sub OpenFilesInMainPage(ByVal xx As FrmMainPage, ByVal XfilePath As String)
        Try

            Dim extension As String = Path.GetExtension(XfilePath.ToLower)

            Select Case extension

                Case ".jpg", ".png", ".jpge", ".gif", ".tiff", ".dng", ".emf", ".raw", ".ico", ".bmp", ".jpeg"

                    xx.PicPanel.BringToFront()
                    Dim bt As New Bitmap(XfilePath)
                    xx.PictureBox3.Image = bt
                    xx.ComboBox1.SelectedIndex = 4
                    xx.lblImagePath.Text = XfilePath

                Case ".pdf"
                    xx.PDFPanel.BringToFront()
                    xx.AxAcroPDF1.src = XfilePath
                    'xx.WebPanel.BringToFront()
                    'xx.WebBrowser1.Visible = True
                    'xx.WebBrowser1.Url = New Uri(XfilePath)

                Case ".html", ".htm", ".asp", ".aspx", ".css", ".php", ".js", ".url"
                    xx.WebPanel.BringToFront()
                    xx.WebBrowser1.Visible = True
                    xx.WebBrowser1.Url = New Uri(XfilePath)

                Case ".doc", ".docx"
                    xx.txtPanel.BringToFront()
                    Dim readonly1 As Object = True
                    Dim visible As Object = True
                    Dim filename As Object = XfilePath
                    Dim missing As Object = Type.Missing

                    Dim doc1 As Microsoft.Office.Interop.Word._Document = Nothing
                    Dim word1 As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application() With {.visible = False}
                    doc1 = word1.Documents.Open(filename, readonly1, visible)
                    doc1.ActiveWindow.Selection.WholeStory()
                    doc1.ActiveWindow.Selection.Copy()
                    Dim data1 As IDataObject = Clipboard.GetDataObject
                    xx.txtReader.Rtf = data1.GetData(DataFormats.Rtf).ToString
                    word1.Quit(missing)


                Case ".txt", ".log", ".ini", ".sql"
                    xx.txtPanel.BringToFront()
                    xx.txtReader.Text = My.Computer.FileSystem.ReadAllText(XfilePath)

                Case Else
                    Process.Start(XfilePath)
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Create Temp Folder انشاء المجلد المؤقت الذي سيتم تحميل ملفات البيدي اف فيه عند عرضها في البرنامج 
    Public Sub CreateTempFolder()
        Try
            Dim StoredPath As String = My.Settings.FilePath & "\Archived Files\Temp"
            If My.Computer.FileSystem.FileExists(StoredPath) = False Then Directory.CreateDirectory(StoredPath)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    ' Get Copy Of File اجراء نسخ الملف الى اي موقع يختاره المستخدم في الكمبيوتر
    Public Sub GetCopyOfFile(ByVal xx As FrmMainPage)

        Try

            If MessageBox.Show(" هل تود اخذ نسخة من الملف " & xx.TreeView1.SelectedNode.Text & "؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return ' في حاله الضغط على لا يخرج من الاجراء واذا نعم ينفذ التالي 

            Dim dt As New DataTable
            dt = GetInfo_OF_SelectedFileInArchivedTree(CDec(xx.TreeView1.SelectedNode.Tag), My.Settings.FilePath & "Archived Files\") ' يتم اسناد البيانات او المعلومات الخاصه بالملف الى الجدول الذي هنا عبر استدعاء دالة جلب معلومات الملف المحدد بنائا على رقم كود الملف و مسار الملف على الجهاز في مجلد النظام 

            If dt.Rows.Count > 0 Then ' في حالة وجود بيانات 
                Dim FilePath, NewPath As String ' تعريف متغيرين الاول مسار الملف والثاني المسار الجديد
                Dim fbd As New FolderBrowserDialog ' تعريف كائن من كلاس تصفح المجلدات

                If dt.Rows(0).Item("xx") = 0 Then ' شرط في حالة كان الملف موجود على جهاز الكمبيوتر 
                    FilePath = dt.Rows(0).Item("FileFullPath") ' فان متغير المسار يأخذ مسار الملف الموجود في المتغير  ملف المسار الكامل الراجع من استعلام الاجراء المخزن
                Else ' في حالة كان الملف مخزن في قاعدة البيانات
                    Dim FileData() As Byte = CType(dt.Rows(0).Item("FileData"), Byte()) ' نقوم بتعريف مسفوفة بيانات ونسند لها الملف الموجود في متغير بيانات الملف الراجع من استعلام الملف في الاجراء المخزن وبيانات الملف تكون كنوع باينري داتا 
                    Dim FileStream As New FileStream(dt.Rows(0).Item("FullName"), FileMode.OpenOrCreate, FileAccess.Write) ' يتم فتح مساحة في الذاكرة لتحميل الملف فيها عبر مسار الملف حيث انه مخزن في المتغير الاسم كاملا الراجع من الاستعلام الخاص بالاجراء المخزن ونوع الملف فتح او انشاء ونوع وصول الملف هو كتابة 
                    FileStream.Write(FileData, 0, FileData.Length) ' نكتب البيانات في المساحة  عن طريق اسناد لها مصفوفة الملف الثنائية و 0 تبدا الكتابة من اول الملف و وتنتم الكتابة ع حسب طول الملف اي العملية تكون كدوارة تكتب على بت بت 
                    FileStream.Close() ' نغلق المساحة 
                    FilePath = dt.Rows(0).Item("FullName") ' نسند لمتغير مسار الملف  مسار الملف حيث انه مخزن في المتغير الاسم كاملا الراجع من الاستعلام الخاص بالاجراء المخزن 
                End If ' نهاية شرط معرفة مكان وجود الملف 


                If MessageBox.Show(" من فضلك اختر المكان المراد حفظ الملف فيه  ", "رسالة تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.Cancel Then Return ' عرض رسالة تفيد للمستخدم اختيار المكان الذي سنقوم بنسخ الملف اليه ولو ضغط الغاء سيخرج من الدالة ولو ضغط نعم سينفذ التالي


                If fbd.ShowDialog = DialogResult.OK Then ' نقوم بفتح دايلوج اختيار المكان على جهاز الكمبيوتر فحين يقوم المستخدم بالاختيار والضغط على اوك سينفذ التالي 
                    NewPath = fbd.SelectedPath & "\" & My.Computer.FileSystem.GetName(FilePath) ' يتم اسناد مكان المجلد المختار + باك سلاش + اسم الملف عن طريق دالة جلب اسم الملف التي تقدمها البيئة ويتم اخذا الاسم بناء على تمرير قيمة مسار الملف بعد ان حددد مكانه وذلك يكون كقيمة للمتغير المسار الجديد 


                    If My.Computer.FileSystem.FileExists(NewPath) = True Then ' في حالة كان الملف موجود مسبقا في المسار الجديد 
                        If MessageBox.Show(" ان ملف " & xx.TreeView1.SelectedNode.Text & vbNewLine & " موجود مسبقاً .. هل تود نسخ الملف باسم جديد ؟ ", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return ' تعرض رسالة تفيد بان الملف موجود فلو اردت تغيير اسمه اضغط نعم واذا ضغط لا فتتوقف الدالة عن بقية التنفيذ
                        Dim NewName As String ' في حالة الضغط على نعم نعرف متغير     الاسم الجديد
                        NewName = InputBox("ادخل الاسم الجديد للملف", "إدخال") ' والمتغير يساوي واجهة صغيره تظهر للمستخدم تفيد بادخال الاسم الجديد للملف ويسند الاسم الجديد للمتغير تلقائيا
                        NewPath = fbd.SelectedPath & "\" & NewName & Path.GetExtension(FilePath) ' بعد هذا نقوم بتغيير قيمة متغير المسار الجديد الجدول المراد نسخ الملف اليه + الباك سلاش + الاسم الجديد للملف +امتداد الملف عن طريق اخذه من مسار الملف الاصلي عبر داله الحصول على الامتداد
                    End If
                    ' نهاية شرط اذا كان الملف موجود مسبقا في المجلد الذي اختاره المستخدم 

                    FileCopy(FilePath, NewPath) ' ننسخ الملف الى المسار المحدد عبر دالة نسخ الملف الموجودة في مكتبة الادخال والاخراج ونمرر لها الملف  والمسار الجديد الذي سننسخ الملف اليه
                    MessageBox.Show(" تمت عملية نسخ الملف بنجاح   ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information) ' سوف تكتمل عملية النسخ وستظهر رسالة نجاح العملية 

                End If
                ' نهاية شرط اختيار المجلد الذي سننسخ الملف اليه 
            End If
            ' نهاية شرط اذا كان هنالك بيانات 

            ' في حالة عدم وجود بيانات لن يتم تنفيذ اي شي 


            ' جزء معالجة الاخطاء في حالة حدوثها
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'Show Files Data عرض الملفات عند عمل تعديل من القائمة الجانبية
    Public Sub Show_Data_Of_FileData(ByVal xx As FrmAddfiles, ByVal ID As Decimal)
        Try
            If ID > 0 Then ' اذا كان الرقم اكبر من الصفر نفذ واذا لا لايتم تنفيذ اي شي 
                Dim DT, dt2 As New DataTable
                Dim sqlst As String
                sqlst = "Select * FROM FilesView where [FileCode] = " & ID & ""
                FillDataTable(DT, sqlst) ' يتم تعبئة الجدول الاول من الفيو التي تم انشائها في السيكول سيرفر

                If DT.Rows.Count > 0 Then ' اذا كان هناك صفوف 

                    If xx.TabControl1.Enabled = False Then xx.btnNew.PerformClick() ' اذا كانت صفحة التاب غير مفعلة قم باستدعاء حدث زر جديد
                    ' وقم بتعبئة الحقول كلا حسب البيانات الخاصة به

                    xx.FileCode.Text = DT.Rows(0).Item("FileCode").ToString
                    GetParentNode(xx.FolderParent.Nodes, CStr(DT.Rows(0).Item("FolderParent")), xx.FolderParent)
                    xx.FileName.Text = DT.Rows(0).Item("FileName").ToString
                    xx.RefrenceNum.Text = DT.Rows(0).Item("RefrenceNum").ToString
                    xx.FileDescription.Text = DT.Rows(0).Item("FileDescription").ToString
                    xx.FileExtenssion.Text = DT.Rows(0).Item("FileExtenssion").ToString
                    xx.FileSize.Text = DT.Rows(0).Item("FileSize").ToString
                    xx.FileSize.Tag = DT.Rows(0).Item("SavedIn") ' تم التخزين في التاج الخاص ب حجم الملف بسبب عدم وجود حقل خاص بمتغير تحديد مكان الحفظ 
                    xx.FileType.SelectedIndex = DT.Rows(0).Item("FileType")
                    xx.FileSecret.Checked = CBool(DT.Rows(0).Item("FileSecret"))
                    xx.FilePassword.Text = DT.Rows(0).Item("FilePassword").ToString
                    xx.FileID.Text = DT.Rows(0).Item("FileId").ToString
                    xx.AddUser.Text = DT.Rows(0).Item("AddUser").ToString
                    xx.AddDate.Text = DT.Rows(0).Item("AddDate").ToString
                    xx.EditUser.Text = DT.Rows(0).Item("EditUser").ToString

                    ' اذا لم يكن تاريخ التعديل ليس فارغ فقم بملئ الحقل من الجدول مثل البيانات السابقة واذا كان فارغ فقم بافراغ الحقل 
                    If IsDBNull(DT.Rows(0).Item("EditDate")) = False Then xx.EditDate.Text = DT.Rows(0).Item("EditDate") Else xx.EditDate.Clear()


                    ' في حاله لم يكن الملف مخزف في قاعدة البيانات 
                    Dim StoredPath, FileStoredPath As String ' نعرف متغيرين الاول المتغير العام والثاني مسار حفظ الملف بالنسبة للمجلد الاب
                    StoredPath = My.Settings.FilePath & "Archived Files\"
                    FileStoredPath = StoredPath & CStr(DT.Rows(0).Item("FolderParent")) & "\"
                    xx.RefrenceNum.Tag = FileStoredPath ' نخزن في خاصية التاج الخاص بمتغير رقم المرجع نخزن فيه المسار الخاص بالحفظ للملف كاملا بدون اسم الملف

                    'داله عرض مرفقات الملفات 
                    ' وتستقبل الداتا جريد فيو ورقم الملف الاساسي و متغير تحديد مكان الحفظ و نمرر المسارالخاص بعمليةالحفظ للملف 
                    Show_AttachedFiles(xx.dgv, CInt(DT.Rows(0).Item("FileId")), CBool(DT.Rows(0).Item("SavedIn")), FileStoredPath)


                    xx.btnScan.Enabled = False ' اغلق تفعيل زر الماسح الضوئي
                    xx.btnbrows.Enabled = False ' اغلق زر تصفح الملفات
                    xx.btnSave.Enabled = False ' اغلق زر الحفظ
                    xx.btnEdit.Enabled = True ' تفعيل زر التعديل
                    xx.btnDelete.Enabled = True ' تفعيل زر الحذف

                    'xx.TSHeader.Text = "تعديل بيانات الملف"

                    If CBool(DT.Rows(0).Item("SavedIn")) = False Then ' اذا كان قيمة المتغير الذي يحدد مكان الحفظ يساوي 0 اي غير محفوظ بقاعدة البيانات
                        ' نقوم بتخزين مسار المجلد على الجهاز + اسم الملف + امتداده في خاصية التاج بمتغير وصف الملف لكي استخدمه عند عملية الحفظ بحيث اذا اردنا نقل مجلد الحفظ او تغييره   
                        xx.FileDescription.Tag = FileStoredPath & DT.Rows(0).Item("FileName") & DT.Rows(0).Item("FileExtenssion")
                    Else
                        ' اذا كان مخزن في قاعدة البيانات
                        ' نخزن في الجدول الاخر الذي صرحنا عنه نقوم بقراءة الملف اي جلب الملف عن طريق داله جلب الملف الذي استخدمناها لعرض الملفات عند التحديد وعمل دبل كلك في شجرة الارشفة ونمرر لها رقم الملف و مساره ملفات البرنامج على الجهاز لكي يتم فتح الملف فيه في المجلد المؤقت 
                        dt2 = GetInfo_OF_SelectedFileInArchivedTree(DT.Rows(0).Item("FileCode"), StoredPath)
                        ' انشاء قراءة او تخزين للملف وتحميلها على ذاكرة الجهاز لكي نقوم بفتحه عن طريق الدالة وتخزين مسار الملف في خاصية التاج الخاصه بمتغير وصف الملف  
                        xx.FileDescription.Tag = CreateSavedInFile(dt2)
                    End If

                    ' في كلتا الحالتين سيكون الملف مخزن في خاصية التاج الخاص بمتغير وصف الملف 
                    ' اما قد يكون مسار الملف من جداول الجهاز في مسار البرنامج او اسم الملف الذي قد قمنا بتحميله من قاعدئة البيانات في الذاكرة الخاصة بالجهاز
                    OpenFiles(xx, CStr(xx.FileDescription.Tag)) '  بعد ذلك نستدعي داله فتح الملفات ونمرر لها القيمة الموجودة في التاج الخاص بمتغير وصف الملف

                End If
                DT.Dispose() ' نفرغ الجدول الاول
                dt2.Dispose() ' نفرغ الجدول الثاني لكي لانخزن بيانات في الذاكرة
            End If
        Catch ex As Exception
            Return '  في حاله وجود خطأ اعمل رجوع ولاتنفذ اي شي 
        End Try
    End Sub

    ' Create Saved In File  انشاء قراءة للملف وتحميلها على ذاكرة الجهاز لكي نقوم بفتحه وتعيد مسار الملف 
    Public Function CreateSavedInFile(ByVal dt As DataTable) As String
        Dim FileData() As Byte = CType(dt.Rows(0).Item("FileData"), Byte())
        Dim FileStream As New FileStream(dt.Rows(0).Item("FullName"), FileMode.OpenOrCreate, FileAccess.Write)
        FileStream.Write(FileData, 0, FileData.Length)
        FileStream.Close()
        Return dt.Rows(0).Item("FullName").ToString() ' الداله تعيد مسار الملف
    End Function


    'Show Attached Files عرض مرفقات الملفات 
    ' وتستقبل الداتا جريد فيو ورقم الملف الاساسي و متغير تحديد مكان الحفظ و نمرر مسار الخاص بعملية الحفظ للملف 

    Public Sub Show_AttachedFiles(ByVal dgv As DataGridView, ByVal ID As Int32, ByVal IsSavedIn As Boolean, ByVal StoredPath As String)
        Try
            Dim DT As New DataTable
            Dim SqlSt As String
            SqlSt = "SELECT * From AttachedFiles where ParentID =" & ID & ""
            FillDataTable(DT, SqlSt) ' اجراء تعبة الجدول بالبيانات
            dgv.Rows.Clear() ' افراغ قبل العرض
            If DT.Rows.Count > 0 Then ' اذا كان هناك بيانات في الجدول الناتج من الاستعلام 
                For i As Int16 = 0 To DT.Rows.Count - 1 ' عمل دوران لتحميل جميع المرفقات الى الداتا جريد فيو
                    dgv.Rows.Add()
                    Dim last As Int16 = dgv.Rows.Count - 1 ' متغير الصف الأخير
                    dgv(0, last).Value = DT.Rows(i).Item("ID")
                    dgv(1, last).Value = DT.Rows(i).Item("FileName")
                    dgv(2, last).Value = DT.Rows(i).Item("FileExtenssion")
                    dgv(3, last).Value = DT.Rows(i).Item("FileSize")
                    dgv(4, last).Value = DT.Rows(i).Item("AddDate")

                    If IsSavedIn = False Then ' اذا كان المرفق مخزن على الجهاز 
                        ' نضيف المسار الكامل للملف - ويتكون من مسار التخزين و رقم الملف الاب و اسم الملف و امتدادة
                        dgv(5, last).Value = StoredPath & ID & "\" & DT.Rows(i).Item("FileName") & DT.Rows(i).Item("FileExtenssion")
                    Else ' في حاله المرفقات في قاعدة البيانات
                        dgv(5, last).Value = Nothing
                    End If

                    dgv(8, last).Value = DT.Rows(i).Item("FileOrder") 'لتسجيل ترتيب الملف 
                Next

            End If
            DT.Dispose() ' نفرغ الجدول 
        Catch ex As Exception
            Return  '  في حاله وجود خطأ اعمل رجوع ولاتنفذ اي شي 
        End Try
    End Sub

    ' Get Attached File  اجراء جلب مرفقات الملفات 
    Public Function GetAttachedFile(ByVal ParentID As Int32, ByVal FileOrder As Short, ByVal FileName As String) As String

        Try

            Dim Paramter(1) As SqlParameter

            Paramter(0) = New SqlParameter("@ParentID", SqlDbType.Int)
            Paramter(0).Value = ParentID

            Paramter(1) = New SqlParameter("@FileOrder", SqlDbType.TinyInt)
            Paramter(1).Value = FileOrder

            Dim dt As New DataTable
            dt = GetDataTable("[GetSavedInAttachedFile]", Paramter)
            Dim AttachedFolder, FullPath As String

            AttachedFolder = My.Settings.FilePath & "Archived Files\Temp\AttachedFile"  ' حفظ في المتغير المسار التالي وياخذ مسار التخزين + المسار الاخر
            ' يقوم بإنشاء المجلد في حاله كان غير موجود
            If My.Computer.FileSystem.FileExists(AttachedFolder) = False Then IO.Directory.CreateDirectory(AttachedFolder)

            FullPath = AttachedFolder & "\" & FileName  '  هذا المتغير يأخذ المتغير السابق الموجود في المسار السابق + الباك سلاش + اسم الملف

            ' عملية قراءة الملف من قاعدة البيانات حيث يتم تخزين البيانات في مصفوفة وثم تحميلها ع الذاكرة بواسطة الفايل ستريم 
            Dim FileData() As Byte = CType(dt.Rows(0).Item("AttachedFileData"), Byte())
            Dim FileStream As New FileStream(FullPath, FileMode.OpenOrCreate, FileAccess.Write)  ' نمرر له مسار الملف واسمه و طريقة العرض انشاء او فتح و الصلاحية هي كتابة 
            FileStream.Write(FileData, 0, FileData.Length)  '  يتم الكتابة والعرض حسب مصفوفة البايتات للملف و 0 و طول الملف
            FileStream.Close()  '  اغلاق الاستريم لتحرير الذاكرة 

            dt.Dispose()  ' حذف الجدول لتحرير الذاكرة
            Return FullPath  '  اعادة لمسار الملف واسمه الذي قمنا بإنشاءة



        Catch ex As Exception
            Return ""  '  في حالة وجود خطأ يرجع فراغ
        End Try


    End Function


    ' Update Files Data  اجراء تعديل بيانات الملف 
    Public Sub Upate_Files(ByVal xx As FrmAddfiles)
        Try
            If CheckBeforeSave(xx) = True Then Return '  فحص  قبل الحفظ  

            Dim Cmd As SqlCommand
            Cmd = New SqlCommand("UpdateFiles", Con)
            Cmd.CommandType = CommandType.StoredProcedure

            Dim Paramter(13) As SqlParameter

            Paramter(0) = New SqlParameter("@FileCode", SqlDbType.Decimal, 28)
            Paramter(0).Value = CDec(xx.FileCode.Text)

            Paramter(1) = New SqlParameter("@FileName", SqlDbType.NVarChar, 300)
            Paramter(1).Value = xx.FileName.Text

            Paramter(2) = New SqlParameter("@FolderParent", SqlDbType.Decimal, 25)
            Paramter(2).Value = CDec(xx.FolderParent.SelectedNode.Tag)

            Paramter(3) = New SqlParameter("@RefrenceNum", SqlDbType.NVarChar)
            Paramter(3).Value = xx.RefrenceNum.Text

            Paramter(4) = New SqlParameter("@FileDescription", SqlDbType.NVarChar)
            Paramter(4).Value = xx.FileDescription.Text

            Paramter(5) = New SqlParameter("@FileType", SqlDbType.TinyInt)
            Paramter(5).Value = CShort(xx.FileType.SelectedIndex)

            Paramter(6) = New SqlParameter("@FileSecret", SqlDbType.Bit)
            Paramter(6).Value = CBool(xx.FileSecret.Checked)

            Paramter(7) = New SqlParameter("@FilePassword", SqlDbType.NVarChar, 25)
            Paramter(7).Value = xx.FilePassword.Text.Trim

            Paramter(8) = New SqlParameter("@EditUser", SqlDbType.TinyInt)
            Paramter(8).Value = LogUserID

            Paramter(9) = New SqlParameter("@DTAttaches", SqlDbType.Structured) ' النوع الذي تم انشاءه كجدول داخل السيكول سيرفر ويعتبر متغير معرف من قبل المستخدم
            Paramter(9).Value = BuildAttachedFilesTable(xx.dgv, CBool(xx.FileSize.Tag)) ' وقيم هذا الاستركشر ناخذه عن طريق هذه الدالة التي قمنا بعمله لبناء جدول بيانات المرفقات + تمرير المتغير الذي يحدد نوع الحفظ   


            Paramter(10) = New SqlParameter("@SavedIn", SqlDbType.Bit)
            Paramter(10).Value = CBool(xx.FileSize.Tag)

            Paramter(11) = New SqlParameter("@FileId", SqlDbType.Int)
            Paramter(11).Value = CInt(xx.FileID.Text)

            Paramter(12) = New SqlParameter("@ID", SqlDbType.Decimal) ' FileCode نرجع من خلال هذا المتغير قيمة  لانه قد يمكن تعديله وسيتغير اذا تغير المجلد الاب
            Paramter(12).Direction = ParameterDirection.Output ' الدايركشن اي الاتجاه الخاص به هو من نوع مخرج ولي مدخل للبيانات

            Paramter(13) = New SqlParameter("@ISChange", SqlDbType.TinyInt) ' اذا كان الملف محفوظ على مسار داخل  جهاز الكمبيوتر فعند نقل الملف الى مجلد اخر بنروح ننقل الملف ايضا من المسار السابق الى المجلد الجديد على جهاز الكمبيوتر الذي يوجد فيه الملف بعد النقل اي ان هذا المتغير نعرف هل تم تغيير المجلد الاب او لا بحيث اذا تم النقل يتم عملية النقل الى المسار الجديد ولو لم يتم سيضل الملف في المجلد الاساسي 
            Paramter(13).Direction = ParameterDirection.Output  ' الدايركشن اي الاتجاه الخاص به هو من نوع مخرج ولي مدخل للبيانات




            Cmd.Parameters.AddRange(Paramter)
            OpenConnection()
            Cmd.ExecuteNonQuery()
            CloseConnection()


            If Paramter(12).Value > 0 Then ' قيمة المتغير من نوع اوتبوت الذي ترجع قيمته من السيكول اذا كانت اكبر من الصفر اي انه تمت عملية الحفظ بنجاح وتم ارجاع رقم الملف 
                xx.ReturnID = Paramter(11).Value.ToString ' نخزن القيمة المرتجعة وهي رقم الملف في المتغير الخاص بالرقم الراجع
                If Paramter(13).Value = 1 Then xx.BackgroundWorker1.RunWorkerAsync() ' فحص لو قيمة متغير الحفظ ب 1 اي ان الملف المخزن في مسار جهاز الكمبيوتر تم تعديل المجلد الاب له -  فيقوم بتنفيذ كود الخلفية على حدث الووركر الذي يقوم بنسخ الملف وعمله في مسار حفظ الملف الجديد الخاصة بالبرنامج في الخلفية ووظيفته انه يقوم بنسخ الملف للمجلد الجديد ويقوم بحذفه من المجلد القديم 
                ConfirmMessage(xx.lblconfirmMessage, xx.PicMessage, xx.Timer1, "تم التعديل بنجاح") ' اظهار رسالة تم التعديل بنجاح 
                Threading.Thread.Sleep(1000) ' عمل سليب للثريد بمقدار ثانية لكي يتسنا لنا عند عمل التحديث للشجرة يكون التعديل قد تم بالضبط وسوف يظهر في العرض 

                FrmMainPage.btnRefresh.PerformClick()  ' تنفيذ او ضغط على زر تحديث الشجرة الخاص بالواجهة الرئيسية 

                Dim Xfind() As TreeNode = FrmMainPage.TreeView1.Nodes.Find(Paramter(12).Value.ToString, True) ' يخزن متغير البحث كمصفوفة من نوع عقد الشجرة ويقوم بتخزين بداخلها مكان الملف المعدل بعد البحث عليه في الشجرة من خلال رقمه  والمتغير الثاني لكي يتم البحث في جميع عناصر الشجرة 
                FrmMainPage.TreeView1.SelectedNode = Xfind(0) ' قم بالتحديد او السلكت على الملف بعد البحث

                xx.btnNew.PerformClick()  ' تنفيذ او ضغط على زر جديد 
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





#End Region

#Region " Scan الماسح الضوئي"

    ' Clean Controls of FrmScan تنظيف ادوات فورم الماسح الضوئي
    Public Sub CleanControl(ByVal xx As FrmScan)
        xx.CheckedListBox1.Items.Clear()
        xx.txtFileName.Clear()
        xx.lblCount.Text = 0
        xx.lblImagePath.Text = ""
        xx.PictureBox1.Image = Nothing
        xx.ComboBox1.SelectedIndex = 4
        ' FillComboByScanners()
    End Sub

    'Reload Items تحميل العناصر 
    Public Sub ReloadItems(ByVal xx As FrmScan)

        If xx.CheckedListBox1.Items.Count = 0 Then Return
        Dim items As Object() = New Object(xx.CheckedListBox1.Items.Count - 1) {}
        xx.CheckedListBox1.Items.CopyTo(items, 0)
        xx.CheckedListBox1.Items.Clear()
        xx.CheckedListBox1.Items.AddRange(items)
        xx.lblCount.Text = xx.CheckedListBox1.Items.Count
        xx.lblImagePath.Text = ""

    End Sub


    ' Show Selected Item On CheckedListBox عرض الصورة في اداة عرض الصور عند التحديد على اي صورة او عنصر في القائمة الجانبية
    Public Sub ShowSelectedItemOnCheckedListBox(ByVal xx As FrmScan, ByVal CheckedListBox1 As CheckedListBox)
        Try
            If xx.CheckedListBox1.Items.Count > 0 Then
                Dim bt As New Bitmap(xx.CheckedListBox1.SelectedItem.ToString)
                xx.PictureBox1.Image = bt
                xx.lblImagePath.Text = xx.CheckedListBox1.SelectedItem.ToString

            End If
        Catch ex As Exception
            Return
        End Try


    End Sub

    ' السطور المعلقة تم نقلها الى الواجهة نفسها لعدم عملها هنا 
    '' Print Page طباعة الصفحة  

    Public Sub PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Dim xx As New FrmScan
        Try
            e.Graphics.DrawImage(xx.PictureBox1.Image, 0, 0, xx.PictureBox1.Width, xx.PictureBox1.Height)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    ' Print Image طباعة الصورة 
    Public Sub PrintImage(ByVal xx As FrmScan)
        Try
            If xx.PictureBox1.Image Is Nothing Then Return
            If MessageBox.Show("هل تود طباعة الصورة ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                xx.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
                Dim PD As New PrintDialog
                Dim doc As New PrintDocument
                AddHandler doc.PrintPage, AddressOf PrintPage
                PD.Document = doc
                If PD.ShowDialog() = Windows.Forms.DialogResult.OK Then doc.Print() ' ظهور مربع الطباعة لاختيار الطابعة وغيره 
            End If
        Catch ex As Exception
            Return
        End Try

    End Sub

#End Region

#Region " Frm CyclePin سلة المحذوفات"

    ' اجراء يقوم بتعبئة  الكمبو بوكس الخاص بالداتا جريد فيو ببيانات المجلد الاب
    Public Sub FillDataGridViewComboBoxFromDataTable(ByVal Combo As DataGridViewComboBoxColumn, ByVal DisplyMember As String, ByVal ValMember As String, ByVal DT As DataTable)

        Dim dv As New DataView(DT) ' تعريف المتغير كعرض من الجدول ونقوم بتمرير الجدول لها  
        If DT.Rows.Count > 0 Then '  في حاله وجود صفوف
            Combo.DataSource = dv ' اجعل الجدول مصدر للكمبوبوكس 
            Combo.DisplayMember = DisplyMember ' اجعل قيمة العرض تساوي القيمة الممرره للعرض وهي اسم المجلد الاب 
            Combo.ValueMember = ValMember ' اجعل قيمة التعامل  تساوي القيمة الممرره للتعامل مع قاعدة البيانات وهي رقم المجلد الاب

        End If

    End Sub


    ' Delete File From DataBase اجراء حذف الملفات نهائيا من قاعدة البيانات
    Public Function DeleteFileFromDataBase(ByVal FileId As Integer, ByVal Savedin As Boolean) As Short



        Dim Cmd As SqlCommand
        Cmd = New SqlCommand("DeleteFile", Con)
        Cmd.CommandType = CommandType.StoredProcedure

        Dim Paramter(2) As SqlParameter

        Paramter(0) = New SqlParameter("@FileId", SqlDbType.Int)
        Paramter(0).Value = FileId

        Paramter(1) = New SqlParameter("@SavedIn", SqlDbType.Bit)
        Paramter(1).Value = Savedin


        ' متغير يعيد لنا قيمة بعد عملية الحذف وهذه القمية اما الرقم 1 اذا تم التنفيذ بشكل سليم واذا لا يرجع القمية 0  
        Paramter(2) = New SqlParameter("@ID", SqlDbType.TinyInt)
        Paramter(2).Direction = ParameterDirection.Output ' الدايركشن اي الاتجاه الخاص به هو من نوع مخرج ولي مدخل للبيانات 



        Cmd.Parameters.AddRange(Paramter)
        OpenConnection()
        Cmd.ExecuteNonQuery()
        CloseConnection()

        Return Paramter(2).Value ' يرجع القيمة الخاص باتمام العملية ام لا بصيغة متغير شورت

    End Function

    ' اجراء استعادة كل الملفات دفعة واحدة
    Public Sub ReturnAllFiles(ByVal xx As FrmCyclePin)

        Try
            If MessageBox.Show(" هل تود استعادة جميع الملفات في القائمه ؟", "استعادة ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then ' رساله تبين تاكيد هل تريد الاستعادة اذا كان نعم قم بعمل التالي

                For i As Int32 = xx.dgv.Rows.Count - 1 To 0 Step -1 ' هذه دوارة عكسية تبدا من رقم السجلات الخاصة بالداتا جريد فيو وتتناقص في كل دورة
                    ReturnRecord(xx.dgv.Rows(i).Cells(0).Value) '  قم باستدعاء اجراء اعادة السجل وتقوم بتمرير قيمة الفايل ايدي المخفية  في الصف حسب الدوراة
                    xx.dgv.Rows.RemoveAt(i) ' قم بحذف السجل من الداتا جريد فيو
                Next

                ConfirmMessage(xx.lblconfirmMessage, xx.PicMessage, xx.Timer1, " تم استعادة الكل بنجاح ") ' وقم باظهار رسالة تم الاستعادة
                xx.lblCount.Text = xx.dgv.Rows.Count ' هنا نقوم باسناد عدد الصفوف الى المتغير الخاص بعدد الملفات 

            End If
            '  هنا نهاية شرط هل تريد استعادة الكل
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    ' اجراء افراغ كل الملفات دفعة واحدة
    Public Sub DeleteAllFiles(ByVal xx As FrmCyclePin)
        Dim zz As Short = 0 ' متغير لمعرفة هل تمت عملية حذف الملف ام لا
        Try
            If MessageBox.Show(" هل تود حذف جميع الملفات في القائمه بشكل نهائي ؟", "حذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then ' اذا كانت نتيجة الرسالة هي نعم يقوم بالتالي

                For i As Int32 = xx.dgv.Rows.Count - 1 To 0 Step -1  ' هذه دوارة عكسية تبدا من رقم السجلات الخاصة بالداتا جريد فيو وتتناقص في كل دورة

                    zz = DeleteFileFromDataBase(CInt(xx.dgv.Rows(i).Cells(0).Value), CBool(xx.dgv.Rows(i).Cells(7).Value)) ' نقوم باستدعاء اجراء حذف الملف من قاعدة البيانات وتمرير له قيمة الخلية 0 في الصف حسب الدوراة وهي ايدي المخفية بعد تحويلها الى عدد صحيح والقيمة الثانية هي قيمة الخلية 7 في الصف حسب الدوراة وهي قيمة مكان الحفظ ويحولها ل بولين
                    ' ترجع الدالة السابقة 1 اذا تم الحذف الملف من قاعدة البيانات و 0 اذا لم يتم الحذف وهذا يعين ان الملف على الجهاز وتخزن هنا في المتغير zz
                    If zz <> 1 Then Return ' اذا كانت القيمة لاتساوي 1 الملف ليس في قاعدة البيانات اخرج من الاجراء كامل او الاف الشرطية الخاصة برسالة الحذف واذا كانت القيمة تساوي 1 استمر بباقي الكود
                    ' سبب الخروج اذا كانت القيمة لاتساوي 1 اي انها 0 هو لان الملف ليس موجود على قاعدة البيانات فلم يستطع حذفه فيقوم باكمال الكود لحذف الملف من الجهاز 
                    If CBool(xx.dgv.Rows(i).Cells(7).Value) = False Then ' نقوم بالتحقق من ان قيمة مكان الحفظ عبر الخلية 7 في الصف حسب الدوراة يساوي 0 وهي ان الملف موجود على جهاز الكمبيوتر و نقوم بعمل التالي
                        Dim xFolderPath, xFileName As String  ' تعريف متغيرين الاول لمسار المجلد والثاني لاسم الملف
                        xFileName = xx.dgv.Rows(i).Cells(2).Value & xx.dgv.Rows(i).Cells(5).Value ' نسند لمتغير اسم الملف = قيمة الخلية رقم 2 في الصف حسب الدوراة وهي تحدد اسم الملف وقيمة الخلية رقم 5 في الصف حسب الدوراة وهي تحدد الامتداد
                        xFolderPath = My.Settings.FilePath & "Archived Files\" & xx.dgv.Rows(i).Cells(3).Value & "\" ' نسند لمتغير مسار المجلد الاب = اسم القرص المخزن في متغير الاعدادت + اسم مجلد البرنامج مع السلاشات السابقة والاحقه + قيمة الخلية 3 في الصف حسب الدوراة وهي اسم المجلد الاب + باك سلاش اخيره
                        File.Delete(xFolderPath & xFileName)  ' نستدعي داله حذف الملف من كلاس الملف من مكتبة الانبوت والاوتبوت لعمل حذف للملف من الجهاز ونمرر لها مسار الملف وهو لدينا في متغير مسار المجلد الاب + متغير اسم الملف 
                        DeleteDirectory(xFolderPath & xx.dgv.Rows(i).Cells(0).Value) ' قم باستدعاء داله حذف المجلدات مع الملفات - الموجودة في كلاس المديول العام الذي انشأناه - ويعمل على حذف الملفات التي بداخل المسار الخاص بالملف والمجلد يكون بدخله ملفات المرفقات اذا وجد مرفقات للملف ونمرر لها مسار الملف وهو لدينا في قيمة مسار المجلد الاب + قيمة الخلية 0  في الصف حسب الدوراة وهي قيمة الفايل ايدي المخفية لان ملفات المرفقات تكون جدول برقم الملف الاساسي
                    End If
                    ' اذا كانت قيمة المتغير تساوي 1 اي انه تم الحذف نقوم بالتالي 
                    xx.dgv.Rows.RemoveAt(i) ' قم بحذف السجل من الداتا جريد فيو
                Next
                ConfirmMessage(xx.lblconfirmMessage, xx.PicMessage, xx.Timer1, " تم حذف الكل بنجاح ") ' وقم باظهار رسالة تم الحذف
                xx.lblCount.Text = xx.dgv.Rows.Count  ' هنا نقوم باسناد عدد الصفوف الى المتغير الخاص بعدد الملفات 
            End If
            ' هنا نهاية شرط هل تريد الحذف نهائيا 
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    ' اجراء البحث عن الملفات في الشجرة 
    Public Sub Search_InDataGridView(ByVal xx As FrmCyclePin, ByVal DT As DataTable)
        Try
            Dim dv As New DataView(DT) ' نقوم بتعريف داتا فيو لعرض السجلات الموجودة في جدول الداتا الممرر من الواجهة 
            If String.IsNullOrEmpty(xx.txtSearch.Text.Trim) = False Then ' في حالة كان الحقل الخاص بالبحث ليس فارغا 
                If xx.rbName.Checked Then ' تابع الشرط الكلي  -  وكان الراديو بوتن الخاص باسم الملف موشر عليه فيعني ان البحث سيكون باسم الملف 
                    dv.RowFilter = "FileName like '%" & xx.txtSearch.Text.Trim & "%'" ' قم بعمل فورمات للصفوف بنائا على اسم الملف ويكون بين علامتي بالمئة لكي يطلع اي حرف موجود بالاسم سواء كان بالبداية او النهاية
                ElseIf xx.rbNumber.Checked Then ' تابع الشرط الكلي  -  وكان الراديو بوتن الخاص رقم الملف موشر عليه فيعني ان البحث سيكون برقم الملف
                    dv.RowFilter = "FileCode =" & xx.txtSearch.Text.Trim & "" ' قم بعمل فورمات للصفوف بنائا على رقم الملف ويجب ان يتم ادخال رقم الملف كاملا
                ElseIf xx.rbExt.Checked Then ' تابع الشرط الكلي  -  وكان الراديو بوتن الخاص بامتداد الملف موشر عليه فيعني ان البحث سيكون  بامتداد الملف 
                    dv.RowFilter = "FileExtenssion like '" & xx.txtSearch.Text.Trim & "'" ' قم بعمل فورمات للصفوف بنائا على امتداد الملف و يجب ان يسبقه . النقطة الخاصة بالامتداد وتم استخدام لايك 
                ElseIf xx.rbRef.Checked Then ' تابع الشرط الكلي  -  وكان الراديو بوتن الخاص برقم مرجع الملف موشر عليه فيعني ان البحث سيكون برقم مرجع الملف
                    dv.RowFilter = "RefrenceNum Like '" & xx.txtSearch.Text.Trim & "'" ' قم بعمل فورمات للصفوف بنائا على رقم مرجع الملف و يجب ان يتم ادخال رقم مرجع الملف كاملا وتم استخدام لايك 
                ElseIf xx.rbDesc.Checked Then ' تابع الشرط الكلي  -  وكان الراديو بوتن الخاص بوصف الملف موشر عليه فيعني ان البحث سيكون بوصف الملف
                    dv.RowFilter = "FileDescription like '%" & xx.txtSearch.Text.Trim & "%'" ' قم بعمل فورمات للصفوف بنائا على وصف الملف ويكون بين علامتي بالمئة لكي يطلع اي حرف موجود بالوصف سواء كان بالبداية او النهاية
                End If
                ' نهايه الشرط اذا كان الحقل ليس فارغا
                xx.dgv.DataSource = dv ' المصدر الخاص بالداتا جريد فيو هي الداتا فيو بعد الفلترة
            Else ' اذا كان الحقل فارغا
                xx.dgv.DataSource = DT ' المصدر الخاص بالداتا جريد فيو هي الداتا تيبل الممرر من الواجهة كما هو
            End If
            ' نهاية شرط البحث
            xx.lblCount.Text = xx.dgv.Rows.Count  ' هنا نقوم باسناد عدد الصفوف الى المتغير الخاص بعدد الملفات 
        Catch ex As Exception
            Exit Sub ' في حالة حصول خطأ قم بالخروج من الداله
        End Try
    End Sub


    ' اجراء استعادة كل الجداول دفعة واحدة
    Public Sub ReturnAllFolders(ByVal xx As FrmCyclePin1)

        Try
            If MessageBox.Show(" هل تود استعادة جميع الجداول في القائمه ؟", "استعادة ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then ' رساله تبين تاكيد هل تريد الاستعادة اذا كان نعم قم بعمل التالي

                For i As Int32 = xx.dgv.Rows.Count - 1 To 0 Step -1 ' هذه دوارة عكسية تبدا من رقم السجلات الخاصة بالداتا جريد فيو وتتناقص في كل دورة
                    ReturnRecord("Folders", "FolderID", xx.dgv.Rows(i).Cells(0).Value) '  قم باستدعاء اجراء اعادة السجل وتقوم بتمرير قيمة الفولدر ايدي المخفية  في الصف حسب الدوراة
                    xx.dgv.Rows.RemoveAt(i) ' قم بحذف السجل من الداتا جريد فيو
                Next

                ConfirmMessage(xx.lblconfirmMessage, xx.PicMessage, xx.Timer1, " تم استعادة الكل بنجاح ") ' وقم باظهار رسالة تم الاستعادة
                xx.lblCount.Text = xx.dgv.Rows.Count ' هنا نقوم باسناد عدد الصفوف الى المتغير الخاص بعدد الملفات 

            End If
            '  هنا نهاية شرط هل تريد استعادة الكل
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    ' اجراء افراغ كل الجداول دفعة واحدة
    Public Sub DeleteAllFolders(ByVal xx As FrmCyclePin1)
        Dim zz As Short = 0 ' متغير لمعرفة هل تمت عملية حذف الجداول ام لا
        Try
            If MessageBox.Show(" هل تود حذف جميع الجداول في القائمه بشكل نهائي ؟", "حذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then ' اذا كانت نتيجة الرسالة هي نعم يقوم بالتالي

                For i As Int32 = xx.dgv.Rows.Count - 1 To 0 Step -1  ' هذه دوارة عكسية تبدا من رقم السجلات الخاصة بالداتا جريد فيو وتتناقص في كل دورة

                    zz = DeleteFoldersFromDataBase(CInt(xx.dgv.Rows(i).Cells(0).Value)) ' نقوم باستدعاء اجراء حذف الملف من قاعدة البيانات وتمرير له قيمة الخلية 0 في الصف حسب الدوراة وهي ايدي المخفية بعد تحويلها الى عدد صحيح والقيمة الثانية هي قيمة الخلية 7 في الصف حسب الدوراة وهي قيمة مكان الحفظ ويحولها ل بولين
                    ' ترجع الدالة السابقة 1 اذا تم الحذف الملف من قاعدة البيانات و 0 اذا لم يتم الحذف وهذا يعين ان الملف على الجهاز وتخزن هنا في المتغير zz
                    If zz <> 1 Then Return ' اذا كانت القيمة لاتساوي 1 الملف ليس في قاعدة البيانات اخرج من الاجراء كامل او الاف الشرطية الخاصة برسالة الحذف واذا كانت القيمة تساوي 1 استمر بباقي الكود
                    ' سبب الخروج اذا كانت القيمة لاتساوي 1 اي انها 0 هو لان الملف ليس موجود على قاعدة البيانات فلم يستطع حذفه فيقوم باكمال الكود لحذف الملف من الجهاز 
                    ' If CBool(xx.dgv.Rows(i).Cells(7).Value) = False Then ' نقوم بالتحقق من ان قيمة مكان الحفظ عبر الخلية 7 في الصف حسب الدوراة يساوي 0 وهي ان الملف موجود على جهاز الكمبيوتر و نقوم بعمل التالي
                    Dim xFolderPath As String  ' تعريف متغيرين الاول لمسار المجلد والثاني لاسم الملف
                    'xFileName = xx.dgv.Rows(i).Cells(1).Value ' نسند لمتغير اسم الملف = قيمة الخلية رقم 2 في الصف حسب الدوراة وهي تحدد اسم الملف وقيمة الخلية رقم 5 في الصف حسب الدوراة وهي تحدد الامتداد
                    xFolderPath = My.Settings.FilePath & "Archived Files\" & xx.dgv.Rows(i).Cells(1).Value  ' نسند لمتغير مسار المجلد الاب = اسم القرص المخزن في متغير الاعدادت + اسم مجلد البرنامج مع السلاشات السابقة والاحقه + قيمة الخلية 3 في الصف حسب الدوراة وهي اسم المجلد الاب + باك سلاش اخيره
                    'File.Delete(xFolderPath)  ' نستدعي داله حذف الملف من كلاس الملف من مكتبة الانبوت والاوتبوت لعمل حذف للملف من الجهاز ونمرر لها مسار الملف وهو لدينا في متغير مسار المجلد الاب + متغير اسم الملف 
                    DeleteFolders(xFolderPath) ' قم باستدعاء داله حذف المجلدات مع الملفات - الموجودة في كلاس المديول العام الذي انشأناه - ويعمل على حذف الملفات التي بداخل المسار الخاص بالملف والمجلد يكون بدخله ملفات المرفقات اذا وجد مرفقات للملف ونمرر لها مسار الملف وهو لدينا في قيمة مسار المجلد الاب + قيمة الخلية 0  في الصف حسب الدوراة وهي قيمة الفايل ايدي المخفية لان ملفات المرفقات تكون جدول برقم الملف الاساسي
                    ' End If
                    ' اذا كانت قيمة المتغير تساوي 1 اي انه تم الحذف نقوم بالتالي 
                    xx.dgv.Rows.RemoveAt(i) ' قم بحذف السجل من الداتا جريد فيو
                Next
                ConfirmMessage(xx.lblconfirmMessage, xx.PicMessage, xx.Timer1, " تم حذف الكل بنجاح ") ' وقم باظهار رسالة تم الحذف
                xx.lblCount.Text = xx.dgv.Rows.Count  ' هنا نقوم باسناد عدد الصفوف الى المتغير الخاص بعدد الملفات 
            End If
            ' هنا نهاية شرط هل تريد الحذف نهائيا 
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    ' اجراء البحث عن الجداول في الشجرة 
    Public Sub Search_InDataGridViewFolders(ByVal xx As FrmCyclePin1, ByVal DT As DataTable)
        Try
            Dim dv As New DataView(DT) ' نقوم بتعريف داتا فيو لعرض السجلات الموجودة في جدول الداتا الممرر من الواجهة 
            If String.IsNullOrEmpty(xx.txtSearch.Text.Trim) = False Then ' في حالة كان الحقل الخاص بالبحث ليس فارغا 
                If xx.rbName.Checked Then ' تابع الشرط الكلي  -  وكان الراديو بوتن الخاص باسم الملف موشر عليه فيعني ان البحث سيكون باسم الملف 
                    dv.RowFilter = "FolderName like '%" & xx.txtSearch.Text.Trim & "%'" ' قم بعمل فورمات للصفوف بنائا على اسم الملف ويكون بين علامتي بالمئة لكي يطلع اي حرف موجود بالاسم سواء كان بالبداية او النهاية
                ElseIf xx.rbNumber.Checked Then ' تابع الشرط الكلي  -  وكان الراديو بوتن الخاص رقم الملف موشر عليه فيعني ان البحث سيكون برقم الملف
                    dv.RowFilter = "FolderNumber =" & xx.txtSearch.Text.Trim & "" ' قم بعمل فورمات للصفوف بنائا على رقم الملف ويجب ان يتم ادخال رقم الملف كاملا
                End If
                ' نهايه الشرط اذا كان الحقل ليس فارغا
                xx.dgv.DataSource = dv ' المصدر الخاص بالداتا جريد فيو هي الداتا فيو بعد الفلترة
            Else ' اذا كان الحقل فارغا
                xx.dgv.DataSource = DT ' المصدر الخاص بالداتا جريد فيو هي الداتا تيبل الممرر من الواجهة كما هو
            End If
            ' نهاية شرط البحث
            xx.lblCount.Text = xx.dgv.Rows.Count  ' هنا نقوم باسناد عدد الصفوف الى المتغير الخاص بعدد الملفات 
        Catch ex As Exception
            Exit Sub ' في حالة حصول خطأ قم بالخروج من الداله
        End Try
    End Sub


    ' Delete Folders From DataBase اجراء حذف الجداول نهائيا من قاعدة البيانات
    Public Function DeleteFoldersFromDataBase(ByVal FolderID As Integer) As Short



        Dim Cmd As SqlCommand
        Cmd = New SqlCommand("DeleteFolders", Con)
        Cmd.CommandType = CommandType.StoredProcedure

        Dim Paramter(1) As SqlParameter

        Paramter(0) = New SqlParameter("@FolderID", SqlDbType.Int)
        Paramter(0).Value = FolderID


        ' متغير يعيد لنا قيمة بعد عملية الحذف وهذه القمية اما الرقم 1 اذا تم التنفيذ بشكل سليم واذا لا يرجع القمية 0  
        Paramter(1) = New SqlParameter("@ID", SqlDbType.TinyInt)
        Paramter(1).Direction = ParameterDirection.Output ' الدايركشن اي الاتجاه الخاص به هو من نوع مخرج ولي مدخل للبيانات 



        Cmd.Parameters.AddRange(Paramter)
        OpenConnection()
        Cmd.ExecuteNonQuery()
        CloseConnection()

        Return Paramter(1).Value ' يرجع القيمة الخاص باتمام العملية ام لا بصيغة متغير شورت

    End Function


#End Region

#Region " ارسال الملف عبر الايميل"

    ' داله التنظيف للكنترول - الادوات 
    Public Sub ClearMessageControls(ByVal xx As FrmEMail)
        'xx.SenderAddress.Clear()
        'xx.SenderAccPassword.Clear()
        xx.ReceiverAddress.Clear()
        xx.txtCopyTo.Clear()
        xx.txtHidenCopyTo.Clear()
        xx.txtSubject.Clear()
        xx.txtMessageBody.Clear()
        xx.AtatchName.Tag = Nothing ' نفرغ التاج لان فيها سيكون مسار الخاص بالملف 
        xx.AtatchName.Clear()
        xx.CombSMTPServers.SelectedIndex = 0 ' يحدد على اول عنصر في القائمة
        xx.btnSend.Enabled = True
        xx.SenderAddress.Focus()
        xx.CkShowHide.Checked = False
        xx.Ck1.Checked = False
        xx.Ck2.Checked = False
    End Sub

    ' تم تعريف الكتبات الدت نيت و الايميل  في الاعلى لاستخدامهم في هذه الدالة
    ' Send Email Message داله ارسال الايميل
    Public Sub Send_Email_Message(ByVal xx As FrmEMail)
        Try

            ' للتحقق من ادخال الحقول 
            If MyTextNull(xx.SenderAddress, "المرسل") Then Return
            If MyTextNull(xx.SenderAccPassword, "كلمة المرور") Then Return
            If MyTextNull(xx.ReceiverAddress, "المستلم") Then Return
            If MyCombIndexNull(xx.CombSMTPServers, "السيرفر") Then Return
            If MyCombIndexNull(xx.CombPorts, "البورت") Then Return
            If MyTextNull(xx.txtSubject, "عنوان الرسالة") Then Return
            If MyRichTextNull(xx.txtMessageBody, "نص الرسالة") Then Return


            Dim smtp = New SmtpClient(xx.CombSMTPServers.Text, xx.CombPorts.Text.Trim) ' نعرف كائن من كلاس اسمتيبي كلاينت ونمرر له السرفر المحدد و رقم البورت
            smtp.EnableSsl = True ' نفعل  خاصية ال ssl لتشفير عملية الارسال
            smtp.UseDefaultCredentials = False ' نجعل خاصية اوراق الاعتماد الافتراضية ب 0 اي غير مفعلة لكي لانرسل عبر الافتراضي 
            smtp.Credentials = New NetworkCredential(xx.SenderAddress.Text, xx.SenderAccPassword.Text) ' نجعل اوراق الاعتماد تاخذ تستخدم اوراق الاعماد عبر الانترنت ونمرر له البريد المرسل و كلمة السر  لكي يقوم بالتحقق من ان المرسل هو صاحب الحساب الحقيقي
            Dim MailMessage = New MailMessage(xx.SenderAddress.Text, xx.ReceiverAddress.Text, xx.txtSubject.Text, xx.txtMessageBody.Text) ' اجراء الارسال الموجود في الكلاس ضمن المكتبة المضمنة في الاعلى ونمرر له بريد المرسل و بريد المستقبل والموضوع الخاص بالرسالة و نص الرسالة
            MailMessage.Priority = MailPriority.High ' اعطاء الاولوية لهذه الرسالة ونجعلها عالية

            If xx.Ck1.Checked And xx.txtCopyTo.Text.Trim <> String.Empty Then MailMessage.CC.Add(xx.txtCopyTo.Text) ' في حال كان مربع الاختيار الخاص ب نسخة الى محدد وايضا حقل البريد الخاص به ليس فارغا سوف يرسل نسخة كاربونية للبريد عبر خاصية سس ونمرر لها البريد الموجود في الحقل   ولكن في الحاله هذه سيعرف المستقبل انه تم عمل نسخة كربونية لبريد اخر 
            If xx.Ck2.Checked And xx.txtHidenCopyTo.Text.Trim <> String.Empty Then MailMessage.Bcc.Add(xx.txtHidenCopyTo.Text) ' في حال كان مربع الاختيار الخاص ب نسخة مخفية الى محدد وايضا حقل البريد الخاص به ليس فارغا سوف يرسل نسخة كاربونية للبريد عبر خاصية ب سس ونمرر لها البريد الموجود في الحقل   ولكن في الحاله هذه لن يعرف المستقبل انه تم عمل نسخة كربونية لبريد اخر لانه تم استخدام خاصية النسخ المخفي 

            ' في حاله وجود مرفق
            If String.IsNullOrEmpty(xx.AtatchName.Tag) = False Then ' اذا كان خاصية التاج الخاصة باسم مرفق الملف ليست فارغه - حيث  اننا نخزن فيها مسار الملف
                Dim attach = New Attachment(xx.AtatchName.Tag) ' نقوم بإرفاق ملف من خلال كلاس المرفقات ونمرر له المسار الموجود في خاصية التاج الخاصه باسم الملف  
                MailMessage.Attachments.Add(attach) ' ونقوم باضافتها مع البيانات التي سوف ترسل عبر الميل مسج
            End If


            MailMessage.IsBodyHtml = True ' الفورمات الخاص بالرسالة التي سوف ترسل تصاغ ب لغة html
            smtp.Send(MailMessage) ' نقوم بالارسال عبر داله الارسال

            ' نظهر رسالة ان الارسال نجح 
            MessageBox.Show("تم إرسال الرساله بنجاح", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' في حاله وجود خطأ ستظهر رسالة الخطأ
            MessageBox.Show(ex.Message, "رسالة تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        End Try

    End Sub


    ' Check IF Selected File Secret Before Send دالة التحقق من ان الملف المحدد محمي قبل الارسال الى شاشة الايميل 
    Public Sub CheckIFSelectedFileSecretBeforeSend(ByVal xx As FrmMainPage)

        Dim dt As New DataTable
        dt = GetInfo_OF_SelectedFileInArchivedTree(CDec(xx.TreeView1.SelectedNode.Tag), My.Settings.FilePath & "Archived Files\") ' يتم اسناد البيانات او المعلومات الخاصه بالملف الى الجدول الذي هنا عبر استدعاء دالة جلب معلومات الملف المحدد ونمرر للدالة رقم الملف الموجود في خاصية التاج في العقدة الشجرية ونمرر لها ايضا مسار الملف الكامل الخاص بالتخزين وندمجه مع اسم المجلد على القرص  
        If dt.Rows(0).Item("isFileSecret") = True Then ' فحص ماذا كانت قيمة العمود 1 اي ان الملف محمي عن طريق القيمة الراجعة من الاستعلام 
            Dim zz As New FrmPassword  ' نقوم بانشاء كائن من واجهة كلمة المرور
            zz.ShowDialog() ' نعرضها 
            If zz.InputText = Nothing Then Return ' في حاله كان الحقل فارغ بعد قم بالخروج 
            If zz.InputText = dt.Rows(0).Item("FilePassword") Then ' اذا كانت كلمة المرور المكتوبة بالحقل مساوية لكلمة المرور الاصلية 
                SendFilePathToFrmEmail(xx, dt) ' يتم استدعاء داله ارسال الملف لشاشة الايميل وتمرير الملف له  
            Else ' في حاله ان كلمة المرور خاطئة تظهر الرسالة هذه 
                MessageBox.Show("معذرةً ، كلمة المرور الذي ادخلتها غير صحيحة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else ' في حاله لم يكن الملف محمي 
            SendFilePathToFrmEmail(xx, dt) ' يتم استدعاء داله ارسال الملف لشاشة الايميل وتمرير الملف له  
        End If
        dt.Dispose()

    End Sub

    '  Send File Path To Frm Email ارسال مسار الملف الى شاشة الايميل 
    Public Sub SendFilePathToFrmEmail(ByVal xx As FrmMainPage, ByVal dt As DataTable)

        Try
            If dt.Rows(0).Item("xx") = 0 Then ' فحص ماذا كانت قيمة العمود 0 اي ان الملف مخزن في ملفات جهاز الكمبيوتر ونعرف ذلك عن طريق القيمة الراجعة من الاستعلام المخزن الذي في الدالة السابقة 
                Dim Frm As New FrmEMail  ' نقوم بانشاء كائن من واجهة ارسال الايميل
                Frm.AttachPath = dt.Rows(0).Item("FileFullPath") ' نسند لمتغير مسار الملف مسار الملف حيث انه مخزن في المتغير الذي اسمه مسار الملف كاملا الراجع من الاستعلام الخاص بالاجراء المخزن 
                Frm.Show() ' نعرضها 

            Else ' في حاله ان الملف مخزن على قاعدة البيانات 

                Dim FileData() As Byte = CType(dt.Rows(0).Item("FileData"), Byte()) ' نقوم بتعريف مسفوفة بيانات ونسند لها الملف الموجود في متغير بيانات الملف الراجع من استعلام الملف في الاجراء المخزن وبيانات الملف تكون كنوع باينري داتا 
                Dim FileStream As New FileStream(dt.Rows(0).Item("FullName"), FileMode.OpenOrCreate, FileAccess.Write) ' يتم فتح مساحة في الذاكرة لتحميل الملف فيها عبر مسار الملف حيث انه مخزن في المتغير الاسم كاملا الراجع من الاستعلام الخاص بالاجراء المخزن ونوع الملف فتح او انشاء ونوع وصول الملف هو كتابة 
                FileStream.Write(FileData, 0, FileData.Length) ' نكتب البيانات في المساحة  عن طريق اسناد لها مصفوفة الملف الثنائية و 0 تبدا الكتابة من اول الملف و وتنتم الكتابة ع حسب طول الملف اي العملية تكون كدوارة تكتب على بت بت 
                FileStream.Close() ' نغلق المساحة 

                Dim Frm As New FrmEMail  ' نقوم بانشاء كائن من واجهة ارسال الايميل
                Frm.AttachPath = dt.Rows(0).Item("FullName") ' نسند لمتغير مسار الملف  مسار الملف حيث انه مخزن في المتغير الاسم كاملا الراجع من الاستعلام الخاص بالاجراء المخزن 
                Frm.Show() ' نعرضها 

            End If ' انهاء فحص معرفة مكان تخزين الملف 


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


#End Region

#Region " ServerCon   الاتصال بالسرفر"

    ' Load Installed Server Names
    Public Sub LoadInstalledServers(ByVal Combo As ComboBox)
        Try
            Dim RegKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64) '
            Dim SubRegKey = RegKey.OpenSubKey("SOFTWARE\Microsoft\Microsoft SQL Server") '
            Dim Instances = CType(SubRegKey.GetValue("InstalledInstances"), String()) ' 
            '
            If Instances.Length > 0 Then
                For Each element As String In Instances '
                    '
                    If element = "MSSQLSERVER" Then
                        Combo.Items.Add(Environment.MachineName) '
                    Else
                        Combo.Items.Add(Environment.MachineName + "\" + element) '
                    End If
                    '
                Next element
            End If
        Catch ex As Exception
            ' في حاله وجود خطأ ستظهر رسالة الخطأ
            MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub

    ' Fill Combobox By DataBase Name
    Public Sub FillCombByDataBases(ByVal CombServer As ComboBox, ByVal ComboDBs As ComboBox)
        Try
           
            If CombServer.Text.Trim <> String.Empty Then ' فحص اذا كان الكمبوبوكس المخزن فيه السرفرات ليس فارغا  
                ComboDBs.Items.Clear() ' يقوم بتنظيف الكمبوبوكس لتجنب التكرار فيه 

                Dim SqlConnSrt As String = Nothing ' نعرف متغير نص الاتصال 

                If My.Settings.LoginMothed = 0 Then
                    ' Connection Statement by Windows Authentication
                    ' صفر يعني ان الاتصال محلي عن طريق صلاحيات الويندوز ويكون نص الاتصال كالتالي
                    SqlConnSrt = "Data Source ='" & CombServer.Text.Trim & "';Initial Catalog = master;Integrated Security=True "
                ElseIf My.Settings.LoginMothed = 1 Then
                    ' Connection Statement by SQL Serve Authentication
                    ' واحد يعني ان الاتصال محلي عن طريق اسم مستخدم وكلمة مرور ويكون نص الاتصال كالتالي
                    SqlConnSrt = "Data Source ='" & CombServer.Text.Trim & "';Initial Catalog = master;user ID ='" & My.Settings.LoginID & "'; Password='" & My.Settings.LogPassword & "' "
                ElseIf My.Settings.LoginMothed = 2 Then
                    ' Connection Statement by through Network
                    ' اثنين يعني ان الاتصال شبكي على معمارية كلاينت وسيرفر ويكون نص الاتصال كالتالي
                    SqlConnSrt = "Data Source ='" & My.Settings.ServerIP & "','" & My.Settings.LoginPort & "' ;Network Library = DBMSSOCN; Initial Catalog = master;user ID ='" & My.Settings.LoginID & "'; Password='" & My.Settings.LogPassword & "' "
                End If

                Dim cn As New SqlConnection(SqlConnSrt) ' تعريف متغير للاتصال وتمرير له جملة الاتصال 
                ' يوجد فيو في الماستر داتا بيز تخزن فيه جميع اسماء قواعد البيانات  يتم جلبه عن طريق الاستعلام التالي 
                Dim da As New SqlDataAdapter("select name from sys.databases ", cn) ' نمرر الاستعلام الي يقوم باستدعاء اسماء القواعد و متغير الاتصال
                Dim dt As New DataTable
                da.Fill(dt) ' نقوم بتعبئة الجدول باسماء قواعد البيانات الراجعة من الاستعلام 

                For i As Short = 0 To dt.Rows.Count - 1 ' نقوم بعمل لوب تبدا من الصفر وتنتهي بعدد القواعد
                    ComboDBs.Items.Add(dt.Rows(i).Item("name").ToString()) ' لكي نقوم باضافتها للكمبوبوكس على حده 
                Next

            End If

        Catch ex As Exception
            ' في حاله وجود خطأ ستظهر رسالة الخطأ
            MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub

    ' Show Saved Settings
    Public Sub ShowSavedSettings(ByVal xx As FrmServerConnection1)


        If My.Settings.LoginMothed = 0 Then
            xx.rbLocal.Checked = True
            xx.CombServers.Text = My.Settings.ServerName
            xx.CombAuth.SelectedIndex = 0
            xx.UserId.Clear()
            xx.UserPassword.Clear()

        ElseIf My.Settings.LoginMothed = 1 Then
            xx.rbLocal.Checked = True
            xx.CombServers.Text = My.Settings.ServerName
            xx.CombAuth.SelectedIndex = 1
            xx.UserId.Text = My.Settings.LoginID
            xx.UserPassword.Text = My.Settings.LogPassword

        ElseIf My.Settings.LoginMothed = 2 Then
            xx.rbNetwork.Checked = True
            xx.txtIPAddress.Text = My.Settings.ServerIP
            xx.txtPort.Text = My.Settings.LoginPort
            xx.txtUserName.Text = My.Settings.LoginID
            xx.txtPassword.Text = My.Settings.LogPassword

        ElseIf My.Settings.LoginMothed = 3 Then
            xx.rbWAN.Checked = True
            xx.WANConString.Text = My.Settings.WANConString

        End If

        xx.ComboDBs.Text = My.Settings.DataBaseName

    End Sub

    ' Test SQL Server Connection
    Public Sub TestSQLServerConnection(ByVal xx As FrmServerConnection1)


        If CheckBeforeTestSaveSetting(xx) = True Then Return

        Dim SqlConnSrt As String = Nothing
        Dim SqlConn As New SqlConnection

        If xx.CombAuth.SelectedIndex = 0 And xx.rbLocal.Checked = True Then
            ' Connection Statement by Windows Authentication
            SqlConnSrt = "Data Source ='" & xx.CombServers.Text.Trim & "';Initial Catalog = master;Integrated Security=True "
        ElseIf xx.CombAuth.SelectedIndex = 1 And xx.rbLocal.Checked = True Then
            ' Connection Statement by SQL Serve Authentication
            SqlConnSrt = "Data Source ='" & xx.CombServers.Text.Trim & "';Initial Catalog = master;user ID ='" & xx.UserId.Text.Trim & "'; Password='" & xx.UserPassword.Text.Trim & "' "
        ElseIf xx.rbNetwork.Checked = True Then
            ' Connection Statement by through Network
            SqlConnSrt = "Data Source ='" & xx.txtIPAddress.Text.Trim & "','" & xx.txtPort.Text.Trim & "' ;Network Library = DBMSSOCN; Initial Catalog = master;user ID ='" & xx.txtUserName.Text.Trim & "'; Password='" & xx.txtPassword.Text.Trim & "' "
        ElseIf xx.rbWAN.Checked = True Then
            ' Connection Statement by through WAN Hosting
            SqlConnSrt = xx.WANConString.Text.Trim
        End If

        SqlConn.ConnectionString = SqlConnSrt
        If SqlConn.State = ConnectionState.Closed Then
            Try
                SqlConn.Open()
                MessageBox.Show("تمت عملية الاتصال بنجاح", "فحص الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("فشل الاتصال بالسيرفر" + vbCrLf + Err.Description, "فحص الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    ' Check Before Test Save Setting
    Public Function CheckBeforeTestSaveSetting(ByVal xx As FrmServerConnection1) As Boolean


        If xx.rbLocal.Checked = True Then
            If MyCombIndexNull(xx.CombServers, "اسم السرفر") = True Then Return True
            If xx.CombAuth.SelectedIndex = 1 Then
                xx.CombServers.Text = My.Settings.ServerName
                If MyTextNull(xx.UserId, "اسم المستخدم") = True Then Return True
                If MyTextNull(xx.UserPassword, "الباسورد") = True Then Return True
            End If

        ElseIf xx.rbNetwork.Checked = True Then
            If MyTextNull(xx.txtIPAddress, "عنوان أو اسم السيرفر") = True Then Return True
            If MyTextNull(xx.txtPort, " رقم البورت") = True Then Return True
            If MyTextNull(xx.txtUserName, "اسم المستخدم") = True Then Return True
            If MyTextNull(xx.txtPassword, "الباسورد") = True Then Return True

        ElseIf xx.rbWAN.Checked = True Then
            If MyTextNull(xx.WANConString, "جملة الاتصال") = True Then Return True

        End If

        If MyCombIndexNull(xx.ComboDBs, "اسم قاعدة البيانات") = True Then Return True

        Return False

    End Function

    '  Save Settings Of Sql Server
    Public Sub Save_Conection_Settings(ByVal xx As FrmServerConnection1)

        If MessageBox.Show("هل تود حفظ إعدادات الاتصال بالسيرفر", "رساله تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If CheckBeforeTestSaveSetting(xx) = True Then Return

            If xx.rbLocal.Checked = True Then
                My.Settings.ServerName = xx.CombServers.Text.Trim

                If xx.CombAuth.SelectedIndex = 0 Then
                    My.Settings.LoginMothed = 0
                ElseIf xx.CombAuth.SelectedIndex = 1 Then
                    My.Settings.LoginMothed = 1
                    My.Settings.LoginID = xx.UserId.Text.Trim
                    My.Settings.LogPassword = xx.UserPassword.Text.Trim
                End If

            ElseIf xx.rbNetwork.Checked = True Then
                My.Settings.LoginMothed = 2
                My.Settings.ServerIP = xx.txtIPAddress.Text.Trim
                My.Settings.LoginPort = xx.txtPort.Text.Trim
                My.Settings.LoginID = xx.txtUserName.Text.Trim
                My.Settings.LogPassword = xx.txtPassword.Text.Trim

            ElseIf xx.rbWAN.Checked = True Then
                My.Settings.LoginMothed = 3
                My.Settings.WANConString = xx.WANConString.Text.Trim

            End If

            My.Settings.DataBaseName = xx.ComboDBs.Text.Trim
            My.Settings.Save()

            ConfirmMessage(xx.lblConfirmMsg, xx.PicMsg, xx.Timer1, "تم حفظ إعدادات الاتصال بالسيرفر بنجاح ...")
        End If

    End Sub

    '   Reset Saved Settings Data
    Public Sub ResetSavedSettingsData(ByVal xx As FrmServerConnection1)

        If MessageBox.Show("انت على وشك إلغاء إعدادات الاتصال بالسيرفر ؟" & vbNewLine & "هل تود الإستمرار ؟", "رساله تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            My.Settings.ServerName = Nothing
            My.Settings.DataBaseName = Nothing
            My.Settings.LoginMothed = 0
            My.Settings.ServerIP = Nothing
            My.Settings.LoginID = Nothing
            My.Settings.LogPassword = Nothing
            My.Settings.WANConString = Nothing

            xx.rbLocal.Checked = True
            xx.CombAuth.SelectedIndex = 0

            My.Settings.Save()

            ConfirmMessage(xx.lblConfirmMsg, xx.PicMsg, xx.Timer1, "تم إلغاء إعدادات الاتصال بالسيرفر بنجاح ...")
        End If

    End Sub

#End Region




#Region " Backup And Restore "

    ' Load Backup Settings داله تحميل اعدادات النسخ الاحتياطي التلقائي
    Public Sub LoadBackupSettings(ByVal xx As FrmBuckupDataBase)
         xx.CombBackupType.SelectedIndex = My.Settings.BackupType ' اجعل الاندكس الخاص بنوع النسخ الاحتياطي يساوي الذي موجود في الاعداد الخاصة بالنظام  
        xx.txtMainBackupPath.Text = My.Settings.BackupPath ' اجعل المسار الخاص بمكان النسخ الاحتياطي  يساوي الذي موجود في الاعداد الخاصة بالنظام  
        xx.NumOfHours.Value = My.Settings.BackTimerInterval / 3600000 ' اجعل قيمة الاداة الرقمية الخاصة بفترة ساعات النسخ التلقائي  يساوي الذي موجود في الاعداد الخاصة بالنظام قسمة 3.600.000 او 3600*1000 لكي يقوم باعطاء الوقت بالساعات لان المتغير تسجل فيه القيمة بالثواني بحيث ان الثانية الواحدة تساوي 1000 ملي سكند   
        ' وعند ضرب 1000 ملي سنكد في 60 ثانية ينتج 60.000 ملي سكند نقوم بضربها في 60 دقيقة ينتج 3.600.000 اي ساعة فهنا تتم العملية عكسية كونها قسمة لكي يتم العرض في الاداة


        If My.Settings.AutoBackup = 0 Then ' اذا كان نوع النسخ الاحتياطي يساوي 0 
            xx.rbStop.Checked = True ' يتم تفعيل الخيار الخاص ايقاف النسخ التلقائي
        ElseIf My.Settings.AutoBackup = 1 Then ' اذا كان نوع النسخ الاحتياطي يساوي 1 
            xx.rbAtClose.Checked = True ' يتم تفعيل الخيار الخاص بالنسخ الاحتياطي عند ايقاف البرنامج 
        ElseIf My.Settings.AutoBackup = 2 Then ' اذا كان نوع النسخ الاحتياطي يساوي 2 
            xx.rbPerHours.Checked = True ' يتم تفعيل الخيار الخاص بالنسخ الاحتياطي عبر فترة زمنية معينة
        End If

        xx.CombBackupDB.Text = My.Settings.DataBaseName ' يقوم باسناد اسم قاعدة البيانات الموجودة في متغيرات النظام الى الكمبوبوكس الخاص بانشاء النسخ الاحتياطية للقاعدة
        xx.CombRestoreDB.Text = My.Settings.DataBaseName ' يقوم باسناد اسم قاعدة البيانات الموجودة في متغيرات النظام الى الكمبوبوكس الخاص بإستعادة القاعدة النسخ الاحتياطية


    End Sub

    ' Activate Backup Timer اجراء تفعيل المؤقت الخاص بالنسخ الاحتياطي التلقائي 
    Public Sub ActivateBackupTimer(ByVal xx As FrmBuckupDataBase)

        Dim x As Int64 = Val(xx.NumOfHours.Value) * 1000 * 3600 ' تعريف متغير صحيح طويل جدا يقوم بالاحتفاظ بقيمة عدد ساعات عمل النسخ الاحتياطية التلقائية ويتم اسناد القيمة له عن طريق ضربها في 3.600.000 او 3600*1000 لكي يقوم باعطاء الوقت بالساعات لان المتغير تسجل فيه القيمة بالثواني بحيث ان الثانية الواحدة تساوي 1000 ملي سكند  
        ' وعند ضرب 1000 ملي سنكد في 60 ثانية ينتج 60.000 ملي سكند نقوم بضربها في 60 دقيقة ينتج 3.600.000 اي ساعة 

        My.Settings.BackTimerInterval = x ' نسندالقيمة للمتغير الموجود في اعدادات النظام
        FrmMainPage.BackupTimer.Enabled = True ' نقوم بتفعيل المؤقت الموجود في الواجهة الرئيسية 
        FrmMainPage.BackupTimer.Interval = x ' نعطي الانترفل الخاص بالمؤقت قيمة الانترفل المسندة 

    End Sub

    ' Save Backup Settings اجراء حفظ اعدادات النسخ الاحتياطي 
    Public Sub SaveBackupSettings(ByVal xx As FrmBuckupDataBase)
        Try
            If xx.txtMainBackupPath.Text.Trim = String.Empty Then ' في حالة كان مربح النص الخاص  بمسار حفظ النسخ الاحتياطي فارغا 
                MessageBox.Show("من فضلك اختر مسار لحفظ النسخ الإحتياطي", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return ' نقوم بالخروج من الاجراء 
            End If
            My.Settings.BackupType = xx.CombBackupType.SelectedIndex ' نسند للمتغير الموجود بالنظام نوع النسخ الاحتياطي 
            My.Settings.BackupPath = xx.txtMainBackupPath.Text  ' Save Path  ' نسند للمتغير الموجود في النظام مسار النسخ الاحتياطي 


            ' Save AutoBackup Options  حفظ خيارات النسخ التلقائي 
            If xx.rbStop.Checked = True Then ' في حالة كان الخيار الخاص بالنسخ التلقائي مفعل 
                My.Settings.AutoBackup = 0 ' نسند لمتغير الحفظ التلقائي القيمة 0
            ElseIf xx.rbAtClose.Checked = True Then ' وفي حالة كان خيار النسخ التلقائي عند الاغلاق مفعل 
                My.Settings.AutoBackup = 1 ' نسند لمتغير الحفظ التلقائي القيمة 1
            ElseIf xx.rbPerHours.Checked = True Then ' وفي حالة كان خيار النسخ التلقائي عند كل عدد ساعات معينة مفعلا
                My.Settings.AutoBackup = 2 ' نسند لمتغير الحفظ التلقائي القيمة 2
                ActivateBackupTimer(xx) ' ثم نستدعي اجراء تفعيل المؤقت الزمني الخاص بالنسخ الاحتياطي
            End If

            My.Settings.Save() ' ثم نقوم بحفظ الاعدادات
            ConfirmMessage(xx.lblConfirmMsg, xx.PicMessage, xx.Timer1, " تم حفظ إعدادات النسخ الاحتياطي بنجاح ") ' ثم نظهر رسالة الحفظ بنجاح


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    ' داله ترجع اسماء قواعد البيانات كجدول
    Public Function ReturnNameOFDataBasesAsDataTable() As DataTable
        Dim dt As New DataTable ' تعريف الجدول
        dt.Columns.Add("name") 'اضافة عمود للجدول باسم name

        Try
            Dim ServerName, ServerIPAddress As String ' تعريف للمتغيرين اسم السرفر و عنوان ايبي السيرفر   
            ServerName = My.Settings.ServerName ' نسند لهم القيم من المتغيرات المحفوظة بالنظام
            ServerIPAddress = My.Settings.ServerIP ' نسند لهم القيم من المتغيرات المحفوظة بالنظام

            ' فحص اذا كان اسم السرفر ليس فارغا او ايبي السرفر ليس فارغا ايضا يتم عمل التالي
            If String.IsNullOrEmpty(ServerName) = False Or String.IsNullOrEmpty(ServerIPAddress) = False Then


                Dim SqlConnSrt As String = Nothing ' نعرف متغير الاتصال
                If My.Settings.LoginMothed = 0 Then
                    ' Connection Statement by Windows Authentication 
                    ' صفر يعني ان الاتصال محلي عن طريق صلاحيات الويندوز ويكون نص الاتصال كالتالي
                    SqlConnSrt = "Data Source ='" & ServerName & "';Initial Catalog = master;Integrated Security=True "
                ElseIf My.Settings.LoginMothed = 1 Then
                    ' Connection Statement by SQL Serve Authentication
                    ' واحد يعني ان الاتصال محلي عن طريق اسم مستخدم وكلمة مرور ويكون نص الاتصال كالتالي
                    SqlConnSrt = "Data Source ='" & ServerName & "';Initial Catalog = master;user ID ='" & My.Settings.LoginID & "'; Password='" & My.Settings.LogPassword & "' "
                ElseIf My.Settings.LoginMothed = 2 Then
                    ' Connection Statement by through Network
                    ' اثنين يعني ان الاتصال شبكي على معمارية كلاينت وسيرفر ويكون نص الاتصال كالتالي
                    SqlConnSrt = "Data Source ='" & My.Settings.ServerIP & "','" & My.Settings.LoginPort & "' ;Network Library = DBMSSOCN; Initial Catalog = master;user ID ='" & My.Settings.LoginID & "'; Password='" & My.Settings.LogPassword & "' "
                End If

                Dim cn As New SqlConnection(SqlConnSrt) ' تعريف متغير للاتصال وتمرير له جملة الاتصال 
                ' يوجد فيو في الماستر داتا بيز تخزن فيه جميع اسماء قواعد البيانات  يتم جلبه عن طريق الاستعلام التالي 
                Dim da As New SqlDataAdapter("select name from sys.databases ", cn) ' نمرر الاستعلام الي يقوم باستدعاء اسماء القواعد و متغير الاتصال
                da.Fill(dt) ' نقوم بتعبئة الجدول باسماء قواعد البيانات الراجعة من الاستعلام 

            End If

        Catch ex As Exception
            ' في حاله وجود خطأ ستظهر رسالة الخطأ
            MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

        Return dt 'ارجاع للجدول الموجود فيه اسماء القواعد 

    End Function


    '  Backup DataBase
    ' Backup DataBase داله عمل النسخ الاحتياطي 
    Public Function BackupDataBase(ByVal con As SqlConnection, ByVal DatabaseName As String, ByVal DestinationFolderPath As String, ByVal BackupOption As String, ByVal Backuptype As String) As Boolean
        Try
            Dim SqlCmd As New SqlCommand ' تعريف كائن من سيكول كوموند 
            SqlCmd = con.CreateCommand ' جعله يساوي كائن الاتصال وينشى جملة جديدة 
            Dim CommandStr As String = Nothing ' ننشى متغير نصي ليحتوي نص النسخ

           
            If Backuptype = 0 Then  ' في حاله كان نوع النسخ يساوي 0 اي ان النسخ سيكون اي انه نسخ كامل  فسيكون نص االاتصال كما هو موضح في ناتج الشرط
                CommandStr = "backup database " & DatabaseName &
                                        " to disk = N'" & DestinationFolderPath & "\" & DatabaseName & "_FULL_" & Now.ToString("yyyy-MM-dd hh-mm-ss") & " .bak' WITH " & BackupOption
                ' سيكون هكذا كما في السيكول سيرفر ولكن مع اضافة التاريخ والوقت لاسم النسخة 
                '       BACKUP DATABASE [EArchive2022] 
                '  TO  DISK = N'D:\Archived Files\Backup\EArchive2022_FULL_Date+time.bak'
                '    WITH NOFORMAT, NOINIT, SKIP
            ElseIf Backuptype = 1 Then ' في حاله كان نوع النسخ يساوي 1 اي ان النسخ سيكون نسخ تفاضلي  فسيكون نص االاتصال كما هو موضح في ناتج الشرط
                CommandStr = "backup database " & DatabaseName &
                                        " to disk = N'" & DestinationFolderPath & "\" & DatabaseName & "_DIFF_" & Now.ToString("yyyy-MM-dd hh-mm-ss") & " .bak' WITH DIFFERENTIAL , " & BackupOption & ""
                ' سيكون هكذا كما في السيكول سيرفر ولكن مع اضافة التاريخ والوقت لاسم النسخة 
                '       BACKUP DATABASE [EArchive2022] 
                '  TTO  DISK = N'D:\Archived Files\Backup\EArchive2022_DIFF_Date+time' 
                '     WITH  DIFFERENTIAL , NOFORMAT, NOINIT 
            ElseIf Backuptype = 2 Then ' في حاله كان نوع النسخ يساوي 2 اي ان النسخ سيكون  نسخ لملف اللوج اي للعمليات الترانساكشن  فسيكون نص االاتصال كما هو موضح في ناتج الشرط
                CommandStr = "backup LOG " & DatabaseName &
                                        " to disk = N'" & DestinationFolderPath & "\" & DatabaseName & "_Trans_Log_" & Now.ToString("yyyy-MM-dd hh-mm-ss") & " .trn' WITH " & BackupOption
                ' سيكون هكذا كما في السيكول سيرفر ولكن مع اضافة التاريخ والوقت لاسم النسخة 
                ' BACKUP LOG [EArchive2022]
                '  TO  DISK = N'D:\Archived Files\Backup\EArchive2022_Trans_Log_Date+time.trn' 
                ' WITH NOFORMAT, NOINIT
            End If


            SqlCmd.CommandText = CommandStr ' نسند النص الخاص بالنسخ لخاصية جمله النص في كائن جملة السيكول
            con.Open() ' نفتح الاتصال
            SqlCmd.ExecuteNonQuery() ' ننفذ الامر
            con.Close() ' نغلق الاتصال 

            Return True ' نرجع القيمه ترو اذا تم الامر بنجاح

        Catch ex As Exception
            ' في حاله وجود خطأ ستظهر رسالة الخطأ
            MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' ونرجع فولس اذا كان هناك اي خطأ حدث
        End Try

    End Function

    '  Enable Backup At Closeing System  اجراء عمل نسخه احتياطية عند اغلاق النظام 
    Public Sub EnableBackupAtCloseingSystem()
        Try

            If My.Settings.AutoBackup = 1 AndAlso String.IsNullOrEmpty(My.Settings.BackupPath) = False Then ' نقوم بفحص اذا كان متغير النسخ التلقائي الموجود في متغيرات النظام يساوي 1 اي ان النسخ سيكون عند اغلاق البرنامج وايضا نفحص ما اذا كان متغير المسار الوجود في متغيرات النظام ليس فارغا 
                If My.Computer.FileSystem.FileExists(My.Settings.BackupPath) = False Then System.IO.Directory.CreateDirectory(My.Settings.BackupPath) ' فحص في حاله اذا لم يكن المجلد المحدد كمسار غير موجود يقوم بإنشاءه
                Dim BackupOption As String = Nothing ' نعرف متغير خيار النسخ
                Dim IsBackupSucceed As Boolean = False ' نعرف متغير هل النسخ صحيح ويكون من نوع بولين اما صفر او واحد 
                BackupOption = "NOFORMAT, INIT, SKIP" '   جعل قيمة خيار النسخ هكذا
                IsBackupSucceed = BackupDataBase(Con(), My.Settings.DataBaseName, My.Settings.BackupPath, BackupOption, My.Settings.BackupType) ' نسند للمتغير داله النسخ الاحتياطي لقاعدة البيانات ونرسل لها الاتصال واسم القاعدة ومسار النسخ وخيار النسخ ونوع النسخ الموجودين في متغيرات النظام  
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    '  Enable Backup Per Hours  اجراء عمل نسخه احتياطية  حسب خيار عدد الساعات
    Public Sub EnableBackupPerHours(ByVal T As Timer)
        Try

            If My.Settings.AutoBackup = 2 AndAlso String.IsNullOrEmpty(My.Settings.BackupPath) = False Then ' نقوم بفحص اذا كان متغير النسخ التلقائي الموجود في متغيرات النظام يساوي 1 اي ان النسخ سيكون حسب الوقت المحدد بالساعات وايضا نفحص ما اذا كان متغير المسار الوجود في متغيرات النظام ليس فارغا 
                If My.Computer.FileSystem.FileExists(My.Settings.BackupPath) = False Then System.IO.Directory.CreateDirectory(My.Settings.BackupPath) ' فحص في حاله اذا لم يكن المجلد المحدد كمسار غير موجود يقوم بإنشاءه
                Dim BackupOption As String = Nothing ' نعرف متغير خيار النسخ
                Dim IsBackupSucceed As Boolean = False ' نعرف متغير هل النسخ صحيح ويكون من نوع بولين اما صفر او واحد 
                BackupOption = "NOFORMAT, INIT, SKIP" '   جعل قيمة خيار النسخ هكذا
                IsBackupSucceed = BackupDataBase(Con(), My.Settings.DataBaseName, My.Settings.BackupPath, BackupOption, My.Settings.BackupType) ' نسند للمتغير داله النسخ الاحتياطي لقاعدة البيانات ونرسل لها الاتصال واسم القاعدة ومسار النسخ وخيار النسخ ونوع النسخ الموجودين في متغيرات النظام  
            Else
                T.Stop() ' لو لم يكن هذا خيار الحفظ التلقائي يساوي 2 قم بإقاف المؤقت 
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    ' Restore DataBase



#End Region


#Region " Login "

    ' Login To Program
    Public Sub LoginToProgram(ByVal xx As FrmLogin, ByVal Username As String, ByVal txtPassword As String)
        Try
            If MyTextNull(xx.txtUserName, "اسم المستخدم") Then Return
            If MyTextNull(xx.txtUserPassword, "كلمة المرور") Then Return
            If TestServerConectionBeforLogin() = False Then Return

            Dim dt As New DataTable
            FillDataTable(dt, "SELECT UserAccID,UserAccName,AccType,UserImage,AccActivate from UserAccounts where IsDeleted=0 and (UserName = N'" & Username & "') and (UserPassword =N'" & txtPassword & "')")

            If dt.Rows.Count > 0 Then

                If dt.Rows(0).Item("AccActivate") = False Then
                    MessageBox.Show("ان حساب المستخدم " & dt.Rows(0).Item("UserAccName") & " ليس لديه صلاحية الدخول الى النظام" & vbNewLine &
                                    "يرجى متابعة مدير النظام", "رسالة تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                LogUserID = dt.Rows(0).Item("UserAccID")  ' Get LogUserId
                LogUserName = dt.Rows(0).Item("UserAccName")  'Get LogUserName

                FrmMainPage.Show() ' Open MainForm 

                ShowSavedPicture(FrmMainPage.UserImagPic, dt, 0, "UserImage")

                xx.Close()

            Else
                MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                xx.txtUserName.Clear()
                xx.txtUserPassword.Clear()
                xx.txtUserName.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Test Server Conection Befor Login
    Public Function TestServerConectionBeforLogin() As Boolean
        Try
            Dim ServerName As String = My.Settings.ServerName
            Dim SqlConn As New SqlConnection

            Dim SqlConnStr As String = Nothing
            If My.Settings.LoginMothed = 0 Then
                SqlConnStr = "Data Source=" & ServerName & ";Initial Catalog=master;Integrated Security=True"
            ElseIf My.Settings.LoginMothed = 1 Then
                SqlConnStr = "Data Source=" & ServerName & ";Initial Catalog=master;User ID=" & My.Settings.LoginID & ";Password=" & My.Settings.LogPassword & ""
            ElseIf My.Settings.LoginMothed = 2 Then
                SqlConnStr = "Data Source=" & My.Settings.ServerIP & "," & My.Settings.LoginPort & ";Network Library=DBMSSOCN;Initial Catalog=master;User ID=" & My.Settings.LoginID & ";Password=" & My.Settings.LogPassword & ""
            ElseIf My.Settings.LoginMothed = 3 Then
                SqlConnStr = My.Settings.WANConString
            End If

            SqlConn.ConnectionString = SqlConnStr
            If SqlConn.State = ConnectionState.Closed Then SqlConn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("فشل الاتصال بالسيرفر" + vbCrLf + Err.Description, "فحص الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region


End Class
