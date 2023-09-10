Imports System.Data.SqlClient
Module ConnectionModule
    'ADO.Net


    Dim conn As New SqlConnection

    ' Connection Function دالة الاتصال
    Public Function Con() As SqlConnection

        If My.Settings.LoginMothed = 0 Then

            ' Connection Statement by Windows Authentication
            conn = New SqlConnection("Data Source ='" & My.Settings.ServerName & "';Initial Catalog ='" & My.Settings.DataBaseName & "';Integrated Security=True ")
        ElseIf My.Settings.LoginMothed = 1 Then
            ' Connection Statement by SQL Serve Authentication
            conn = New SqlConnection("Data Source ='" & My.Settings.ServerName & "';Initial Catalog ='" & My.Settings.DataBaseName & "';user ID ='" & My.Settings.LoginID & "'; Password='" & My.Settings.LogPassword & "' ")
        ElseIf My.Settings.LoginMothed = 2 Then
            ' Connection Statement by through Network
            conn = New SqlConnection("Data Source ='" & My.Settings.ServerIP & "','" & My.Settings.LoginPort & "' ;Network Library = DBMSSOCN; Initial Catalog ='" & My.Settings.DataBaseName & "';user ID ='" & My.Settings.LoginID & "'; Password='" & My.Settings.LogPassword & "' ")
        ElseIf My.Settings.LoginMothed = 3 Then
            ' Connection Statement by through WAN Hosting
            conn = New SqlConnection("" & My.Settings.WANConString & "")

        End If

        Return conn ' اعادة الاتصال

    End Function


    ' Public img As Int16 = 0 ' تم استبداله بالشرط الذي يوجد داخل اجراء حفظ الصورة في قاعدة البيانات 


    ' To Open Connection فتح الاتصال 
    Public Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If
    End Sub

    ' To Close Connection  اغلاق الاتصال 
    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()

        End If
    End Sub

    ' To Get Data from Database througt Stored Procedure  داله تقوم بجلب البيانات من قاعدة البيانات باستخدام الاجرائات المخزنة 
    Public Function GetDataTable(ByVal StoredProcedureName As String, ByVal Paramter() As SqlParameter) As DataTable
        Dim SqlCmd As SqlCommand = New SqlCommand(StoredProcedureName, Con())
        SqlCmd.CommandType = CommandType.StoredProcedure

        If Paramter IsNot Nothing Then
            SqlCmd.Parameters.AddRange(Paramter)
        End If


        Dim da As SqlDataAdapter = New SqlDataAdapter(SqlCmd)
        Dim DT As New DataTable

        da.Fill(DT)
        Return DT

        da.Dispose()
        DT.Clear()


    End Function

End Module
