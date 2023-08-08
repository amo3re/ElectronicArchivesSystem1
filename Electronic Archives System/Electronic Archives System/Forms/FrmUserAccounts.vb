
Public Class FrmUserAccounts

    Dim cls As New ProjectClass
    Dim dt As New DataTable


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'لإزاله جميع النصوص الموجوده على الادوات على الفورم
        cls.ClearControls_FrmUsers(Me)
        GetIDOFRecords(dt, "UserAccounts", "UserAccID", txtNevigate, " عدد المستخدمين ")

    End Sub

    Private Sub FrmUserAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnNew.PerformClick()
    End Sub

    Private Sub ck_ShowPasword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_ShowPasword.CheckedChanged
        If ck_ShowPasword.Checked = True Then
            UserPassword.UseSystemPasswordChar = False 'Show Password
            ck_ShowPasword.Text = "إخفاء"
        Else
            UserPassword.UseSystemPasswordChar = True ' hide Password
            ck_ShowPasword.Text = "إظهار"
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        cls.Save_In_UsersTbl(Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblconfirmMessage.Text = Nothing
        PicMessage.Image = Nothing
        Timer1.Stop()
    End Sub

    Private Sub FrmUserAccounts_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        ' الكود القديم
        'If e.KeyCode = Keys.Enter Then ' عد الضغط على انتر
        '    Me.SelectNextControl(Me.ActiveControl, True, True, False, True)
        'ElseIf e.KeyCode = Keys.Up Then  ' عند الضغط على سهم الاعلى
        '    Me.SelectNextControl(Me.ActiveControl, False, True, False, True)


        '    ' اختصارات في الشاشة لزر الجديد والحفظ والتعديل والحذف والاغلاق 
        'ElseIf e.Control AndAlso e.KeyCode = Keys.N Then ' عند الضغط على كنترول + N
        '    btnNew.PerformClick()
        'ElseIf e.Control AndAlso e.KeyCode = Keys.S Then ' عند الضغط على كنترول + S
        '    btnSave.PerformClick()
        'ElseIf e.Control AndAlso e.KeyCode = Keys.E Then ' عند الضغط على كنترول + E
        '    btnEdit.PerformClick()
        'ElseIf e.Control AndAlso e.KeyCode = Keys.D Then ' عند الضغط على كنترول + D
        '    btnDelete.PerformClick()
        'ElseIf e.Control AndAlso e.KeyCode = Keys.Q Then ' عند الضغط على كنترول + Q
        '    btnClose.PerformClick()

        'End If

        keyBoardAbbreviatios(e, btnNew, btnSave, btnEdit, btnDelete, btnClose)


    End Sub

    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        cls.GetImageTo_PictureBox(UserImage)
    End Sub

    Private Sub btnDeleteImage_Click(sender As Object, e As EventArgs) Handles btnDeleteImage.Click
        '  img = 0 ' تم استبداله بالشرط الذي يوجد داخل اجراء حفظ الصورة في قاعدة البيانات 
        UserImage.Image = Nothing
    End Sub

    Private Sub UserName_Leave(sender As Object, e As EventArgs) Handles UserName.Leave
        If btnEdit.Enabled = True Then Exit Sub ' فحص لكي لا يتم التحقق من اسم المستخدم في وضع التعديل  
        'Check Exisance Of Entered Name
        cls.CheckExisanceOfName(UserName)  ' يتم التحقق من اسم المستخدم في وضع الحفظ
    End Sub


    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim id As Int16
        id = MyfirstRecord(dt, Me, txtNevigate)
        cls.Show_UsersAccounts_Data(Me, dt.Rows(id).Item("UserAccID"))
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim id As Int16
        id = MyNextRecord(dt, Me, txtNevigate)
        cls.Show_UsersAccounts_Data(Me, dt.Rows(id).Item("UserAccID"))
    End Sub

    Private Sub btnPreviouse_Click(sender As Object, e As EventArgs) Handles btnPreviouse.Click
        Dim id As Int16
        id = MyPreviouseRecord(dt, Me, txtNevigate)
        cls.Show_UsersAccounts_Data(Me, dt.Rows(id).Item("UserAccID"))
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Dim id As Int16
        id = MyLastRecord(dt, Me, txtNevigate)
        cls.Show_UsersAccounts_Data(Me, dt.Rows(id).Item("UserAccID"))
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        cls.Update_In_UsersTbl(Me)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show(" انت على وشك حذف حساب المستخدم  " & UserAccountName.Text & vbNewLine & " هل تود الإستمرار ؟ ", " رسالة تنبية ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            DeleteRecourd("UserAccounts", "UserAccID", UserAccID.Text, lblconfirmMessage, PicMessage, Timer1)
            btnNew.PerformClick()
        End If

    End Sub
End Class