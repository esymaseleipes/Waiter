Imports System.Text
Imports DevExpress.BarCodes
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300

Public Class FrmQrCode
    Dim ses As Session
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ses = New Session(Kefdal)
        GenQR()
    End Sub


    Private Sub GenQR()
        Me.PictureBox1.Image = Nothing

        Dim barCode As New BarCode()
        barCode.Symbology = Symbology.QRCode
        barCode.CodeText = GetData() '"https:/www.devexpress.com"
        barCode.BackColor = Color.White
        barCode.ForeColor = Color.Black
        barCode.RotationAngle = 0
        barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText)
        barCode.Options.QRCode.CompactionMode = QRCodeCompactionMode.Byte
        barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q
        barCode.Options.QRCode.ShowCodeText = False
        barCode.DpiX = 72
        barCode.DpiY = 72
        barCode.Module = 2.0F

        Me.PictureBox1.Image = barCode.BarCodeImage
        Dim FileToSaveAs As String = System.IO.Path.Combine(Application.StartupPath, "Img1")
        PictureBox1.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub
    'Private Function CreateFile(str As String, filepath As String) As Boolean
    '    Dim fileEncodingIso8859 As System.Text.Encoding = System.Text.Encoding.GetEncoding(28597)
    '    Dim fileEncodingUnicode As System.Text.Encoding = System.Text.Encoding.Unicode

    '    Using fs As New FileStream(filepath, FileMode.Create)
    '        Using sw As New StreamWriter(fs, fileEncodingIso8859)
    '            sw.WriteLine(str)
    '        End Using
    '    End Using
    'End Function

    Private Function GetData() As String
Top:


        Dim McCollection As XPCollection(Of MobileConnection) = New XPCollection(Of MobileConnection)(ses)

        If McCollection.Count = 0 Then
            BarButtonItem1_ItemClick(Nothing, Nothing)
            GoTo Top
        Else
            Dim mc As MobileConnection = McCollection(0)
            Dim rets As String = mc.SqlServer & "#" & mc.SqlInstance & "#" & mc.Database & "#" & mc.User & "#" & mc.Password & "#2" & mc.ShopDescr
            Return rets
        End If

    End Function

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If InputBox("Κωδικός Παραμετροποίησης") = Start.clsconnection.SqlConParams.SqlPass Then
            Dim ff As FrmMobileConnection = New FrmMobileConnection
            ff.ShowDialog()
        End If

    End Sub
End Class