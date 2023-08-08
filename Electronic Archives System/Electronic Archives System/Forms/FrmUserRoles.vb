Public Class FrmUserRoles

    
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CkUserAccForm.Checked = True
            CkUserAccSave.Checked = True
            CkUserAccUpdate.Checked = True
            CkUserAccDelete.Checked = True

            CkUserRoleForm.Checked = True
            CkUserRoleSave.Checked = True
            CkUserRoleDelete.Checked = True

            CkAddFolderForm.Checked = True
            CkFolderSave.Checked = True
            CkFolderUpdate.Checked = True
            CkFolderDelete.Checked = True

            CkAddFileForm.Checked = True
            CkFileSave.Checked = True
            CkFileUpdate.Checked = True
            CkFileDelete.Checked = True
            CkFileScan.Checked = True
            CkFileBrowse.Checked = True

            CkFileSend.Checked = True

            CkRecycleBin.Checked = True

            CkServerSettingForm.Checked = True

            CkBackupForm.Checked = True
            CkBackupButton.Checked = True
            CkRestoreButton.Checked = True
            CkBackSettingSave.Checked = True

        Else

            CkUserAccForm.Checked = False
            CkUserAccSave.Checked = False
            CkUserAccUpdate.Checked = False
            CkUserAccDelete.Checked = False

            CkUserRoleForm.Checked = False
            CkUserRoleSave.Checked = False
            CkUserRoleDelete.Checked = False

            CkAddFolderForm.Checked = False
            CkFolderSave.Checked = False
            CkFolderUpdate.Checked = False
            CkFolderDelete.Checked = False

            CkAddFileForm.Checked = False
            CkFileSave.Checked = False
            CkFileUpdate.Checked = False
            CkFileDelete.Checked = False
            CkFileScan.Checked = False
            CkFileBrowse.Checked = False

            CkFileSend.Checked = False

            CkRecycleBin.Checked = False

            CkServerSettingForm.Checked = False

            CkBackupForm.Checked = False
            CkBackupButton.Checked = False
            CkRestoreButton.Checked = False
            CkBackSettingSave.Checked = False


        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then

            CkAddFolderForm.Checked = True
            CkFolderSave.Checked = True
            CkFolderUpdate.Checked = True
            CkFolderDelete.Checked = True

            CkAddFileForm.Checked = True
            CkFileSave.Checked = True
            CkFileUpdate.Checked = True
            CkFileDelete.Checked = True
            CkFileScan.Checked = True
            CkFileBrowse.Checked = True

            CkFileSend.Checked = True

            CkRecycleBin.Checked = True

            CkServerSettingForm.Checked = True

            CkBackupForm.Checked = True
            CkBackupButton.Checked = True
            CkRestoreButton.Checked = True
            CkBackSettingSave.Checked = True

        Else

            CkAddFolderForm.Checked = False
            CkFolderSave.Checked = False
            CkFolderUpdate.Checked = False
            CkFolderDelete.Checked = False

            CkAddFileForm.Checked = False
            CkFileSave.Checked = False
            CkFileUpdate.Checked = False
            CkFileDelete.Checked = False
            CkFileScan.Checked = False
            CkFileBrowse.Checked = False

            CkFileSend.Checked = False

            CkRecycleBin.Checked = False

            CkServerSettingForm.Checked = False

            CkBackupForm.Checked = False
            CkBackupButton.Checked = False
            CkRestoreButton.Checked = False
            CkBackSettingSave.Checked = False

        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class