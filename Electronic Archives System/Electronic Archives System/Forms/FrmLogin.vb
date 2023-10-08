Public Class FrmLogin

    Dim cls As New ProjectClass
    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lblTime.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        End
    End Sub

    Private Sub ToolStripLabel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripLabel1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub ToolStripLabel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripLabel1.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
        End If
    End Sub

    Private Sub btnLoging_Click(sender As Object, e As EventArgs) Handles btnLoging.Click
        cls.LoginToProgram(Me, Me.txtUserName.Text.Trim, Me.txtUserPassword.Text.Trim) ' استدعاء اجراء تسجيل الدخول للبرنامج نمرر له الشاشة كامل و اسم المستخدم وكلمة المرور
    End Sub

    
    Private Sub txtUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(Me.txtUserName.Text.Trim) = False Then
                Me.txtUserPassword.Focus()
            End If
        End If
    End Sub

    Private Sub txtUserPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(Me.txtUserPassword.Text.Trim) = False Then
                cls.LoginToProgram(Me, Me.txtUserName.Text.Trim, Me.txtUserPassword.Text.Trim) ' استدعاء اجراء تسجيل الدخول للبرنامج نمرر له الشاشة كامل و اسم المستخدم وكلمة المرور
            End If
        End If
    End Sub

    
    Private Sub FrmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            End
        End If
    End Sub

    Private Sub ckConSettings_CheckedChanged(sender As Object, e As EventArgs) Handles ckConSettings.CheckedChanged

        Try
            If ckConSettings.Checked Then
                Dim zz As New FrmPassword
                zz.Label1.Text = "ادخل كلمة المرور لفتح شاشة إعدادات الاتصال"
                zz.ShowDialog()
                If zz.InputText = Nothing Then ckConSettings.Checked = False : Return
                If zz.InputText = My.Settings.FrmConStrPaS Then
                    Dim Frm As New FrmServerConnection1 ' FrmServerConnection
                    Frm.ShowDialog()
                Else
                    MessageBox.Show("معذرةً، كلمة المرور الذي ادخلتها غير صحيحة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                ckConSettings.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub txtUserName_Enter(sender As Object, e As EventArgs) Handles txtUserName.Enter
        ChangeToArabic() ' عند الضغط على انتر في خانة اسم المستخدم يتم استدعاء اجؤاء تحويل اللغة الى اللغة العربية تلقائيا
    End Sub
End Class