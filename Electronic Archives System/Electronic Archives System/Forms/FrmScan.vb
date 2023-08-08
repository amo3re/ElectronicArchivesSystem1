Imports TwainLib
Imports System.IO
Imports System.Drawing.Printing ' لتفعيل مكاتب الطباعة 
Imports ALquhaliLibrary
Imports WIA

Public Class FrmScan
    
    Dim cls As New ProjectClass
    Public XPath As String

    ' تم نقل الكود المعلق الى صفحةالبوبلك كلاس لكي يكون الكود عام هناك 

    ' Clean Controls of FrmScan تنظيف ادوات فورم الماسح الضوئي
    'Public Sub CleanControl()
    '    Me.CheckedListBox1.Items.Clear()
    '    Me.txtFileName.Clear()
    '    Me.lblCount.Text = 0
    '    Me.lblImagePath.Text = ""
    '    Me.PictureBox1.Image = Nothing
    '    Me.ComboBox1.SelectedIndex = 1
    '    FillComboByScanners()
    'End Sub

    'Reload Items تحميل العناصر 
    'Public Sub ReloadItems()

    '    If CheckedListBox1.Items.Count = 0 Then Return
    '    Dim items As Object() = New Object(CheckedListBox1.Items.Count - 1) {}
    '    Me.CheckedListBox1.Items.CopyTo(items, 0)
    '    Me.CheckedListBox1.Items.Clear()
    '    Me.CheckedListBox1.Items.AddRange(items)
    '    Me.lblCount.Text = CheckedListBox1.Items.Count
    '    Me.lblImagePath.Text = ""

    'End Sub


    ' Show Selected Item On CheckedListBox عرض الصورة في اداة عرض الصور عند التحديد على اي صورة او عنصر في القائمة الجانبية
    'Public Sub ShowSelectedItemOnCheckedListBox()
    '    Try
    '        If CheckedListBox1.Items.Count > 0 Then
    '            Dim bt As New Bitmap(CheckedListBox1.SelectedItem.ToString)
    '            Me.PictureBox1.Image = bt
    '            Me.lblImagePath.Text = CheckedListBox1.SelectedItem.ToString

    '        End If
    '    Catch ex As Exception
    '        Return
    '    End Try


    'End Sub


    '' internl code

    ''Print Page طباعة الصفحة  
    'Public Sub PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
    '    Try
    '        e.Graphics.DrawImage(PictureBox1.Image, 0, 0, PictureBox1.Width, PictureBox1.Height)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End Try
    'End Sub


    ''Print Image طباعة الصورة 
    'Public Sub PrintImage(ByVal Pb As PictureBox)
    '    Try
    '        If Pb.Image Is Nothing Then Return
    '        If MessageBox.Show("هل تود طباعة الصورة ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
    '            Pb.SizeMode = PictureBoxSizeMode.AutoSize
    '            Dim PD As New PrintDialog
    '            Dim doc As New PrintDocument
    '            AddHandler doc.PrintPage, AddressOf PrintPage
    '            PD.Document = doc
    '            If PD.ShowDialog() = Windows.Forms.DialogResult.OK Then doc.Print() ' ظهور مربع الطباعة لاختيار الطابعة وغيره 
    '        End If
    '    Catch ex As Exception
    '        Return
    '    End Try

    'End Sub

    Private Sub FillComboByScanners()
        Me.ComboScanners.Items.Clear()

        Dim deviceManager = New DeviceManager ' كلاس في مكتبة الويا يقوم بالدخول الى مدير الاجهزة لاخذ الاجهزة المعنية بالتقاط الصور 
        For i As Integer = 1 To deviceManager.DeviceInfos.Count
            ' اذا كان نوع الجهاز ليس ماسح ضوئي فقم بالاستمرار في الدوارة  واذا كان من نوع ماسح ضوئي فيقوم باضافته الى الكمبوبوكس  
            If deviceManager.DeviceInfos(i).Type <> WiaDeviceType.ScannerDeviceType Then Continue For
            Me.ComboScanners.Items.Add(New Scanner(deviceManager.DeviceInfos(i)))
        Next
        If Me.ComboScanners.Items.Count > 0 Then Me.ComboScanners.SelectedIndex = 0
    End Sub


    Public Sub StartScanning(ByVal CombScaners As ComboBox, ByVal SavedImageFolder As String, ByVal ImageName As String, ByVal ImageExt As Short, ByVal pic As PictureBox)
        Try

            Dim device As Scanner = Nothing
            Invoke(New MethodInvoker(Function()
                                         device = CType(CombScaners.SelectedItem, Scanner)
                                         '  Return device
                                     End Function))

            If device Is Nothing Then
                MessageBox.Show("من فضلك تأكد من وجود ماسح ضوئي متصل بالجهاز", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            ElseIf String.IsNullOrEmpty(ImageName) Then
                MessageBox.Show("ادخل اسم للصور المراد مسحها من خلال اعدادات المسح الضوئي", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim ScandImgName As String = ImageName & Now.ToString("yyyy-MM-dd-hhmmssff")
            pic.Image = Nothing
            Dim imgExtension As String = ""
            Dim image As New ImageFile()
            Invoke(New MethodInvoker(Function()

                                         Select Case ImageExt
                                             Case 0
                                                 image = device.ScanPNG()
                                                 imgExtension = ".png"
                                             Case 1
                                                 image = device.ScanJPEG()
                                                 imgExtension = ".jpeg"
                                             Case 2
                                                 image = device.ScanTIFF()
                                                 imgExtension = ".tiff"
                                         End Select

                                         ' Return imgExtension
                                     End Function))

            XPath = Path.Combine(SavedImageFolder, ScandImgName & imgExtension)
            image.SaveFile(XPath)
            pic.Image = New Bitmap(XPath)
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Public Sub TriggerScanner()

        If Me.ComboScanners.SelectedItem Is Nothing Or Me.PictureBox1.Image Is Nothing Then Return
        Me.CheckedListBox1.Items.Add(XPath)
        Me.lblCount.Text = CheckedListBox1.Items.Count
        Me.lblImagePath.Text = XPath
        If MessageBox.Show("هل تود عمل مسح آخر ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            btnScan.PerformClick()

        End If

    End Sub







    '#Region "Print"
    '        ' Print Page طباعة الصفحة  
    '    Private Sub PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
    '        Try
    '            e.Graphics.DrawImage(PictureBox1.Image, 0, 0, PictureBox1.Width, PictureBox1.Height)
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '        End Try
    '    End Sub

    '    'Print Image طباعة الصورة 
    '    Public Sub PrintImage()

    '        Try
    '            If PictureBox1.Image Is Nothing Then Return
    '            If MessageBox.Show("هل تود طباعة الصورة ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
    '                PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
    '                Dim PD As New PrintDialog
    '                Dim doc As PrintDocument = Nothing
    '                AddHandler doc.PrintPage, AddressOf PrintPage
    '                PD.Document = doc
    '                If PD.ShowDialog() = Windows.Forms.DialogResult.OK Then doc.Print() ' ظهور مربع الطباعة لاختيار الطابعة وغيره 
    '            End If
    '        Catch ex As Exception
    '            Return
    '        End Try

    '    End Sub

    '#End Region




    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click

        'Dim FileName = TwainLib.ScanImages(".jpg", True, My.Settings.DefualtScanner)
        'For Each Item In FileName
        '    CheckedListBox1.Items.Add(Item)
        'Next
        'lblCount.Text = CheckedListBox1.Items.Count

        Try
            If Me.ComboScanners.SelectedItem Is Nothing Then FillComboByScanners()
            BackgroundWorker1.RunWorkerAsync() ' استدعاء اجراء تعبئة الكمبوبوكس في الاداة لكي تقوم بتحميل الماسحات بالخلفية في حدث الدو وورك 
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        Try
            My.Settings.DefualtScanner = TwainLib.GetScanSource()
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erorr Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        cls.ShowSelectedItemOnCheckedListBox(Me, CheckedListBox1)
    End Sub

    Private Sub btnCreatePDF_Click(sender As Object, e As EventArgs) Handles btnCreatePDF.Click
        cls.CreateAndArchivePDF(Me)
    End Sub

    Private Sub btnPDFPath_Click(sender As Object, e As EventArgs) Handles btnPDFPath.Click
        Dim FBD As New FolderBrowserDialog
        If FBD.ShowDialog = DialogResult.OK Then
            My.Settings.PDFFolderPath = FBD.SelectedPath
            My.Settings.Save()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Select Case ComboBox1.SelectedIndex

            Case 0
                PictureBox1.SizeMode = PictureBoxSizeMode.Normal
            Case 1
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Case 2
                PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            Case 3
                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Case 4
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

        End Select
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Try

            Dim FBD As New FolderBrowserDialog
            If FBD.ShowDialog = DialogResult.OK Then

                ' CheckedListBox1.Items.Clear() ' لا اريد تنظيف الصور السابقة واذا اردت انه في كل عملية تحميل صور يتم التنظيف ازل التعليق 
                Dim XPath As New DirectoryInfo(FBD.SelectedPath)
                For Each File As FileInfo In XPath.GetFiles
                    Select Case File.Extension.ToLower
                        Case ".jpg", ".png", ".jpge", ".gif", ".tiff", ".dng", ".emf", ".raw", ".ico", ".bmp", ".jpeg"
                            Me.CheckedListBox1.Items.Add(File.FullName)
                    End Select
                Next
                Me.lblCount.Text = CheckedListBox1.Items.Count
                Me.lblImagePath.Text = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckedListBox1_Click(sender As Object, e As EventArgs) Handles CheckedListBox1.Click
        cls.ShowSelectedItemOnCheckedListBox(Me, CheckedListBox1)
    End Sub

    Private Sub btnZoomIn_Click(sender As Object, e As EventArgs) Handles btnZoomIn.Click
        Try
            ZoomInOutPictures(PictureBox1, 1.2)
            ComboBox1.SelectedIndex = 1
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) Handles btnZoomOut.Click
        Try
            ZoomInOutPictures(PictureBox1, 0.8)
            ComboBox1.SelectedIndex = 1
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnMoveLeft_Click(sender As Object, e As EventArgs) Handles btnMoveLeft.Click
        If CheckedListBox1.Items.Count = 0 Then Return

        If CheckedListBox1.SelectedItem = Nothing Then
            CheckedListBox1.SetSelected(CheckedListBox1.Items.Count - 1, True) ' يمرر رقم اخر عنصر ويمرر القيمة صح علشان يسمح بالتنقل في القائمة 
        Else ' في حاله وجود تحديد على اي عنصر
            Dim i As Short = CheckedListBox1.SelectedIndex ' نخزن موقع العنصر المحدد من القائمة في الممتغير 

            If i = 0 Then Return

            CheckedListBox1.SetSelected(i - 1, True) ' نقوم بانقاص الموقع - 1 لكي ينتقل

        End If
    End Sub

    Private Sub btnMoveRight_Click(sender As Object, e As EventArgs) Handles btnMoveRight.Click
        If CheckedListBox1.Items.Count = 0 Then Return

        If CheckedListBox1.SelectedItem = Nothing Then
            CheckedListBox1.SetSelected(0, True) ' يمرر القيمة 0 و صح علشان يسمح بالتنقل في القائمة 
        Else ' في حاله وجود تحديد على اي عنصر
            Dim i As Short = CheckedListBox1.SelectedIndex ' نخزن موقع العنصر المحدد من القائمة في الممتغير 

            If i = CheckedListBox1.Items.Count Then Return

            CheckedListBox1.SetSelected(i + 1, True) ' نقوم بزيادة الموقع + 1 لكي ينتقل

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Try
            ' PrintImage(Me.PictureBox1) ' internl code
            cls.PrintImage(Me)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnRotateRight_Click(sender As Object, e As EventArgs) Handles btnRotateRight.Click
        RotateRight(PictureBox1)
    End Sub

    Private Sub btnRotateLeft_Click(sender As Object, e As EventArgs) Handles btnRotateLeft.Click
        RotateLeft(PictureBox1)
    End Sub

    Private Sub FrmScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls.CleanControl(Me)
        FillComboByScanners()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.CheckedListBox1.Items.Clear()
        Me.lblCount.Text = CheckedListBox1.Items.Count
        Me.lblImagePath.Text = Nothing
        Me.PictureBox1.Image = Nothing
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cls.ReloadItems(Me)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click

        '  تحريك العنصر للاسفل
        ' اذا كان لايوجد اي عنصر في القائمة او لم يتم تحديد اي عنصر 
        If CheckedListBox1.Items.Count = 0 Or CheckedListBox1.SelectedItem = Nothing Then Return
        Dim i As Short = CheckedListBox1.SelectedIndex ' خزن في المتغير  موقع العنصر المحدد
        Dim str As String = CheckedListBox1.SelectedItem.ToString ' هنا نقوم بتخزين بالمتغير لعنصر المحدد بعد تحويله لنص
        If i < CheckedListBox1.Items.Count - 1 Then ' اذا كان المتغير اقل من عدد عناصر القائمة 
            CheckedListBox1.Items.RemoveAt(i) ' يقوم بحذف العنصر بالاعتماد على المتغير المخزن فيه موقع العنصر
            CheckedListBox1.Items.Insert(i + 1, str) ' يتم اضافة العنصر للموقع مضاف اليه 1 وتمرر قميتين الاولى رقمية لتحديد موقع الاضافة والاخرى تخص اسم العنصر 
            CheckedListBox1.SetSelected(i + 1, True) ' يتم التحديد على العنصر المضاف 
        End If

    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click

        '  تحريك العنصر للاعلى 
        ' اذا كان لايوجد اي عنصر في القائمة او لم يتم تحديد اي عنصر 
        If CheckedListBox1.Items.Count = 0 Or CheckedListBox1.SelectedItem = Nothing Then Return
        Dim i As Short = CheckedListBox1.SelectedIndex ' خزن في المتغير  موقع العنصر المحدد
        Dim str As String = CheckedListBox1.SelectedItem.ToString ' هنا نقوم بتخزين بالمتغير لعنصر المحدد بعد تحويله لنص
        If i > 0 Then ' اذا كان المتغير اكبر من عدد 0 حيث ان المتغير ليس اول (موقع) عنصر لانه لا حاجه الى ازاحته طالما انه في اول موقع 
            CheckedListBox1.Items.RemoveAt(i) ' يقوم بحذف العنصر بالاعتماد على المتغير المخزن فيه موقع العنصر
            CheckedListBox1.Items.Insert(i - 1, str) ' يتم اضافة العنصر للموقع ناقص منه 1 وتمرر قميتين الاولى رقمية لتحديد موقع الاضافة والاخرى تخص اسم العنصر 
            CheckedListBox1.SetSelected(i - 1, True) ' يتم التحديد على العنصر المضاف 
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        ' اذا كان لايوجد اي عنصر في القائمة او لم يتم تحديد اي عنصر 
        If CheckedListBox1.Items.Count = 0 Or CheckedListBox1.SelectedItem = Nothing Then Return
        If MessageBox.Show("سيتم حذف العنصر المحدد من القائمة" & vbNewLine & "هل ترغب بالاستمرار ؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.CheckedListBox1.Items.RemoveAt(CheckedListBox1.SelectedIndex) ' يتم حذف العنصر الذي حدنا موقعه او محددين عليه 
            Me.lblCount.Text = CheckedListBox1.Items.Count
            Me.PictureBox1.Image = Nothing
            Me.lblImagePath.Text = Nothing
        End If

    End Sub

    Private Sub btnOpenSavedFolder_Click(sender As Object, e As EventArgs) Handles btnOpenSavedFolder.Click

        If CheckedListBox1.Items.Count = 0 Then Return
        Try
            Me.PictureBox1.Image = Nothing ' تفريغ اداة عرض الصور 
            Dim FolderPath As String = Path.GetDirectoryName(Me.CheckedListBox1.Items(0)) ' تخزين اسم المجلد مع المسار الموجود فيه الصور المعروضة في القائمة داخل المتغير 
            Process.Start(FolderPath) ' فتح المجلد
        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub btnScanSetting_Click(sender As Object, e As EventArgs) Handles btnScanSetting.Click
        FrmImgSettings.ShowDialog()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Threading.Thread.Sleep(100)
        StartScanning(ComboScanners, My.Settings.ImgFolderPath, My.Settings.DefualtImageName, My.Settings.ImageFormat, PictureBox1)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        TriggerScanner()
    End Sub
End Class
