Public Class FrmAddFolders

    Dim cls As New ProjectClass
    Dim DT_Folder, dt As New DataTable
    Public Id As Decimal

    ' عندما كان الكمبوبوكس السابق

    'Private Sub FolderParent_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Try
    '        Me.FolderNumber.Text = cls.GetFolderNumber(Me, FolderParent.SelectedValue)
    '    Catch ex As Exception
    '        Exit Sub
    '    End Try
    'End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        cls.ClearFrmAddFoldersControls(Me)
        'cls.FillMyComboBox(Me.FolderParent) ' عندما كان الكمبوبوكس السابق
        cls.FillMyComboTreeBox(Me)
        GetIDOFRecords(dt, "Folders", "FolderNumber", txtNevigate, " عدد المجلدات ")
    End Sub

    Private Sub FrmAddFolders_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        ' الكود القديم
        'If e.KeyCode = Keys.Enter Then ' عد الضغط على انتر
        '    Me.SelectNextControl(Me.ActiveControl, True, True, False, True)
        'ElseIf e.KeyCode = Keys.Up Then  ' عند الضغط على سهم الاعلى
        '    Me.SelectNextControl(Me.ActiveControl, False, True, False, True)
        'End If

        keyBoardAbbreviatios(e, btnNew, btnSave, btnEdit, btnDelete, btnClose)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' cls.Save_Folders(Me, CDec(Me.FolderNumber.Text), Me.FolderName.Text, CDec(Me.FolderParent.SelectedValue), LogUserID) ' عندما كان الكمبوبوكس السابق
        ' لم يتم اخذ القيمة من داخل الكمبو بوكس لتجنب وقوع الخطاء 

        Dim str As String
        If FolderParent.SelectedNode Is Nothing Then str = 0 Else str = FolderParent.SelectedNode.Tag

        cls.Save_Folders(Me, CDec(Me.FolderNumber.Text), Me.FolderName.Text, CDec(str), LogUserID)

    End Sub

    Private Sub FrmAddFolders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNew.PerformClick()
        cls.Show_Folders_Data(Me, Id) ' داله عرض بيانات الملف للتعديل عليه عند النقر على تعديل من المينو ستريب بدلاله رقم المجلد المرسل من الشاشه الرئيسية عند الضغط على تعديل المجلد
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClearConfirmMessageTools(Me.lblconfirmMessage, Me.PicMessage, Me.Timer1)
    End Sub


    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim id As Int16
        id = MyfirstRecord(dt, Me, txtNevigate)
        cls.Show_Folders_Data(Me, dt.Rows(id).Item("FolderNumber"))
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim id As Int16
        id = MyNextRecord(dt, Me, txtNevigate)
        cls.Show_Folders_Data(Me, dt.Rows(id).Item("FolderNumber"))
    End Sub

    Private Sub btnPreviouse_Click(sender As Object, e As EventArgs) Handles btnPreviouse.Click
        Dim id As Int16
        id = MyPreviouseRecord(dt, Me, txtNevigate)
        cls.Show_Folders_Data(Me, dt.Rows(id).Item("FolderNumber"))
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Dim id As Int16
        id = MyLastRecord(dt, Me, txtNevigate)
        cls.Show_Folders_Data(Me, dt.Rows(id).Item("FolderNumber"))
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        '  cls.Update_Folders(Me, CInt(FolderID.Text), CDec(FolderNumber.Text), FolderName.Text, CDec(FolderParent.SelectedValue), LogUserID) ' عندما كان الكمبوبوكس السابق


        cls.Update_Folders(Me, CInt(FolderID.Text), CDec(FolderNumber.Text), FolderName.Text, CDec(FolderParent.SelectedNode.Tag), LogUserID)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try
            If MessageBox.Show(" انت على وشك حذف حساب المجلد  " & Space(2) & Me.FolderName.Text & vbNewLine & " هل تود الإستمرار ؟ ", " رسالة تنبية ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then


                If cls.Delete_Folders(FolderNumber.Text) = 0 Then
                    ConfirmMessage(Me.lblconfirmMessage, Me.PicMessage, Me.Timer1, "تم الحذف بنجاح")
                    btnNew.PerformClick()

                Else

                    MessageBox.Show(" معذرة لايمكن حذف هذا المجلد قد يكون المجلد أب لمجلدات آخرى أو ملفات آخرى  ", " رسالة تنبية ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub FolderParent_DropDownClosed(sender As Object, e As EventArgs) Handles FolderParent.DropDownClosed

        Try

            ' If FolderParent.SelectedNode Is Nothing Then Return
            ' or
            If FolderParent.SelectedNode Is Nothing Then Me.FolderNumber.Clear() : Return
            Me.FolderNumber.Text = cls.GetFileCode(FolderParent.SelectedNode.Tag)

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub


End Class