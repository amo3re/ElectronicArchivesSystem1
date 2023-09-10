Imports System.Data.SqlClient ' اسخدام مكاتب الاتصال

Public Class FrmServerCon

    Dim cls As New ProjectClass

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

      

            If MessageBox.Show("هل تود حفظ إعدادات الاتصال بالسيرفر", "رساله تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            My.Settings.ServerName = CmbServerName.SelectedItem

                If CombLoginMothed.SelectedIndex = 0 Then
                    My.Settings.LoginMothed = 0
                ElseIf CombLoginMothed.SelectedIndex = 1 Then
                    My.Settings.LoginMothed = 1
                    My.Settings.LoginID = txtUserName.Text.Trim
                    My.Settings.LogPassword = txtUserPassword.Text.Trim
                End If

            End If

            My.Settings.DataBaseName = CombDatabases.Text.Trim
            My.Settings.Save()

        ConfirmMessage(lblconfirmMessage, PicMessage, Timer1, "تم حفظ إعدادات الاتصال بالسيرفر بنجاح ...")




    End Sub

    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
       
        If MessageBox.Show("انت على وشك إلغاء إعدادات الاتصال بالسيرفر ؟" & vbNewLine & "هل تود الإستمرار ؟", "رساله تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            My.Settings.ServerName = Nothing
            My.Settings.DataBaseName = Nothing
            My.Settings.LoginMothed = 0
            My.Settings.LoginID = Nothing
            My.Settings.LogPassword = Nothing

            My.Settings.Save()

            ConfirmMessage(lblconfirmMessage, PicMessage, Timer1, "تم إلغاء إعدادات الاتصال بالسيرفر بنجاح ...")
        End If

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        'Try

        '    If CmbServerName.Text.Trim <> String.Empty Then
        '        CombDatabases.Items.Clear() '

        '        Dim SqlConnSrt As String = Nothing
        '        If My.Settings.LoginMothed = 0 Then
        '            ' Connection Statement by Windows Authentication
        '            SqlConnSrt = "Data Source ='" & CmbServerName.Text.Trim & "';Initial Catalog = master;Integrated Security=True "
        '        ElseIf My.Settings.LoginMothed = 1 Then
        '            ' Connection Statement by SQL Serve Authentication
        '            SqlConnSrt = "Data Source ='" & CmbServerName.Text.Trim & "';Initial Catalog = master;user ID ='" & My.Settings.LoginID & "'; Password='" & My.Settings.LogPassword & "' "
        '      End If

        '        Dim cn As New SqlConnection(SqlConnSrt) '
        '        Dim da As New SqlDataAdapter("select name from sys.databases ", cn) '
        '        Dim dt As New DataTable
        '        da.Fill(dt) '

        '        For i As Short = 0 To dt.Rows.Count - 1 ' 
        '            CombDatabases.Items.Add(dt.Rows(i).Item("name").ToString()) '
        '        Next

        '    End If

        'Catch ex As Exception
        '    ' في حاله وجود خطأ ستظهر رسالة الخطأ
        '    MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End Try


        Dim SqlConnSrt As String = Nothing
        Dim SqlConn As New SqlConnection

        If CombLoginMothed.SelectedIndex = 0 Then
            ' Connection Statement by Windows Authentication
            SqlConnSrt = "Data Source ='" & CmbServerName.Text.Trim & "';Initial Catalog = master;Integrated Security=True "
        ElseIf CombLoginMothed.SelectedIndex = 1 Then
            ' Connection Statement by SQL Serve Authentication
            SqlConnSrt = "Data Source ='" & CmbServerName.Text.Trim & "';Initial Catalog = master;user ID ='" & txtUserName.Text.Trim & "'; Password='" & txtUserPassword.Text.Trim & "' "
       
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

    Private Sub FrmServerCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.LoginMothed <> 3 Then
            cls.LoadInstalledServers(CmbServerName)
        End If
        If My.Settings.LoginMothed = 0 Then
            CmbServerName.Text = My.Settings.ServerName
            CombLoginMothed.SelectedIndex = 0
            txtUserName.Clear()
            txtUserPassword.Clear()

        ElseIf My.Settings.LoginMothed = 1 Then
            CmbServerName.Text = My.Settings.ServerName
            CombLoginMothed.SelectedIndex = 1
            txtUserName.Text = My.Settings.LoginID
            txtUserPassword.Text = My.Settings.LogPassword

        End If

        CombDatabases.Text = My.Settings.DataBaseName
    End Sub

    Private Sub CmbServerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServerName.SelectedIndexChanged
        Try

            If CmbServerName.Text.Trim <> String.Empty Then
                CombDatabases.Items.Clear() '

                Dim SqlConnSrt As String = Nothing
                If My.Settings.LoginMothed = 0 Then
                    ' Connection Statement by Windows Authentication
                    SqlConnSrt = "Data Source ='" & CmbServerName.Text.Trim & "';Initial Catalog = master;Integrated Security=True "
                ElseIf My.Settings.LoginMothed = 1 Then
                    ' Connection Statement by SQL Serve Authentication
                    SqlConnSrt = "Data Source ='" & CmbServerName.Text.Trim & "';Initial Catalog = master;user ID ='" & My.Settings.LoginID & "'; Password='" & My.Settings.LogPassword & "' "
                End If

                Dim cn As New SqlConnection(SqlConnSrt) '
                Dim da As New SqlDataAdapter("select name from sys.databases ", cn) '
                Dim dt As New DataTable
                da.Fill(dt) '

                For i As Short = 0 To dt.Rows.Count - 1 ' 
                    CombDatabases.Items.Add(dt.Rows(i).Item("name").ToString()) '
                Next

            End If

        Catch ex As Exception
            ' في حاله وجود خطأ ستظهر رسالة الخطأ
            MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ClearConfirmMessageTools(Me.lblconfirmMessage, Me.PicMessage, Me.Timer1)
    End Sub
End Class