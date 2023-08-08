
Public Class FrmServerCon


    Private Sub CombLoginMothed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombLoginMothed.SelectedIndexChanged
        If CombLoginMothed.SelectedIndex = 1 Then
            txtUserName.Enabled = True
            txtUserPassword.Enabled = True
        Else
            txtUserName.Clear()
            txtUserPassword.Clear()
            txtUserName.Enabled = False
            txtUserPassword.Enabled = False
        End If
    End Sub

   
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        My.Settings.ServerName = CmbServerName.SelectedItem

        If CombLoginMothed.SelectedIndex = 0 Then
            My.Settings.LoginMothed = 0
            My.Settings.LoginID = Nothing
            My.Settings.LogPassword = Nothing
            My.Settings.Save()
        ElseIf CombLoginMothed.SelectedIndex = 1 Then

            My.Settings.LoginMothed = 1
            My.Settings.LoginID = txtUserName.Text.Trim
            My.Settings.LogPassword = txtUserPassword.Text.Trim
            My.Settings.Save()
        End If

        My.Settings.DataBaseName = CombDatabases.SelectedItem

        My.Settings.Save()

    End Sub

    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
        My.Settings.ServerName = Nothing
        My.Settings.LoginMothed = 0
        My.Settings.LoginID = Nothing
        My.Settings.LogPassword = Nothing
        My.Settings.DataBaseName = Nothing
        My.Settings.Save()

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

    End Sub
End Class