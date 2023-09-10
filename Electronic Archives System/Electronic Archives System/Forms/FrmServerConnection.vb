

Public Class FrmServerConnection

    Dim cls As New ProjectClass



  

    Private Sub CKShow1_CheckedChanged(sender As Object, e As EventArgs) Handles CKShow1.CheckedChanged
        If CKShow1.Checked = True Then
            UserPassword.UseSystemPasswordChar = False
            Me.CKShow1.Text = "Hide"
        Else
            UserPassword.UseSystemPasswordChar = True
            Me.CKShow1.Text = "Show"
        End If
    End Sub

    Private Sub CKShow2_CheckedChanged(sender As Object, e As EventArgs) Handles CKShow2.CheckedChanged
        If CKShow2.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
            Me.CKShow2.Text = "Hide"
        Else
            txtPassword.UseSystemPasswordChar = True
            Me.CKShow2.Text = "Show"
        End If
    End Sub

    Private Sub CombAuth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CombAuth.SelectedIndexChanged
        If CombAuth.SelectedIndex = 1 Then
            txtPassword.UseSystemPasswordChar = False
            Me.UserId.Enabled = True
            Me.UserPassword.Enabled = True
            Me.UserId.Focus()
        Else
            Me.UserId.Enabled = False
            Me.UserPassword.Enabled = False
        End If

    End Sub


    Private Sub rbLocal_CheckedChanged(sender As Object, e As EventArgs) Handles rbLocal.CheckedChanged
        If rbLocal.Checked = True Then
            Me.GroupBox1.Enabled = True
            Me.GroupBox2.Enabled = False
            Me.GroupBox4.Enabled = False
        End If
    End Sub

    Private Sub rbNetwork_CheckedChanged(sender As Object, e As EventArgs) Handles rbNetwork.CheckedChanged
        If rbNetwork.Checked = True Then
            Me.GroupBox1.Enabled = False
            Me.GroupBox2.Enabled = True
            Me.GroupBox4.Enabled = False
        End If
    End Sub

    Private Sub rbWAN_CheckedChanged(sender As Object, e As EventArgs) Handles rbWAN.CheckedChanged
        If rbWAN.Checked = True Then
            Me.GroupBox1.Enabled = False
            Me.GroupBox2.Enabled = False
            Me.GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClearConfirmMessageTools(Me.lblConfirmMsg, Me.PicMsg, Me.Timer1)
    End Sub

    Private Sub FrmServerConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.LoginMothed <> 3 Then
            cls.LoadInstalledServers(CombServers)
            If rbLocal.Checked = True Then cls.FillCombByDataBases(Me.CombServers, Me.ComboDBs)
        End If
        ' cls.ShowSavedSettings(Me)

    End Sub


    Private Sub CombServers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CombServers.SelectedIndexChanged
        Try
            cls.FillCombByDataBases(Me.CombServers, Me.ComboDBs)
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        '   cls.TestSQLServerConnection(Me)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '    cls.Save_Conection_Settings(Me)
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '   cls.ResetSavedSettingsData(Me)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()
    End Sub

End Class