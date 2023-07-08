Imports DevExpress.Xpo
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FrmMobileConnection
    Public Property MC As MobileConnection
    Dim ses As Session

    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        StartProc()
    End Sub

    Private Sub StartProc()
        Dim McCollection As XPCollection(Of MobileConnection) = New XPCollection(Of MobileConnection)(ses)
        If McCollection.Count = 0 Then
            ZeroConfig()
        Else
            MC = McCollection(0)
        End If

        InitBind()
    End Sub



    Private Sub InitBind()
        txtSqlServer.DataBindings.Add(New Binding("Text", MC, "SqlServer"))
        TxtSqlInstance.DataBindings.Add(New Binding("Text", MC, "SqlInstance"))
        TxtDatabase.DataBindings.Add(New Binding("Text", MC, "Database"))
        TxtUser.DataBindings.Add(New Binding("Text", MC, "User"))
        TxtPassword.DataBindings.Add(New Binding("Text", MC, "Password"))
        TxtShopDescr.DataBindings.Add(New Binding("Text", MC, "ShopDescr"))

    End Sub



    Private Sub ZeroConfig()
        MC = New MobileConnection(ses)
        MC.SqlServer = ""
        MC.SqlInstance = ""
        MC.Database = ""
        MC.User = ""
        MC.Password = ""
        MC.ShopDescr = ""
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        MC.Save()
        Me.Close()
    End Sub
    Private Sub BtnEsc_Click(sender As Object, e As EventArgs) Handles BtnEsc.Click
        Me.Close()
    End Sub
End Class