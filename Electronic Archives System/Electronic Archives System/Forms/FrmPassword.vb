Public Class FrmPassword

    Public InputText As String = Nothing
    Private Sub ckShow_CheckedChanged(sender As Object, e As EventArgs) Handles ckShow.CheckedChanged

        If ckShow.Checked = True Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If TextBox1.Text.Trim = Nothing Then
            MessageBox.Show("فضلا ادخل كلمة السر أولا ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            InputText = TextBox1.Text.Trim
            Me.Close()
        End If


    End Sub

    Private Sub FrmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()

    End Sub
End Class