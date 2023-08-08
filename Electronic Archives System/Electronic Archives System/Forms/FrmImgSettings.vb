Imports System.IO

Public Class FrmImgSettings



    Private Sub FrmImgSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboExtension.SelectedIndex = My.Settings.ImageFormat
        Me.DefualtName.Text = My.Settings.DefualtImageName

        If My.Settings.ImgFolderPath = String.Empty Then
            Me.ScandImageFolder.Text = Path.GetTempPath()
        Else
            Me.ScandImageFolder.Text = My.Settings.ImgFolderPath
        End If

    End Sub

    Private Sub btnSelectFolder_Click(sender As Object, e As EventArgs) Handles btnSelectFolder.Click
        Dim FBD As New FolderBrowserDialog
        If FBD.ShowDialog = DialogResult.OK Then
            ScandImageFolder.Text = FBD.SelectedPath
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.ImageFormat = Me.ComboExtension.SelectedIndex
        My.Settings.DefualtImageName = Me.DefualtName.Text.Trim
        My.Settings.ImgFolderPath = Me.ScandImageFolder.Text
        My.Settings.Save()

    End Sub
End Class