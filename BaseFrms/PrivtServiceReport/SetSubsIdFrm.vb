Imports WaiterModel.Cmp300
Imports WindowsApplication1
Imports WindowsApplication1.Cmp300

Public Class SetSubsIdFrm
    Public Sub New()
        InitializeComponent()
        XpCollection1.Session = New DevExpress.Xpo.Session(Kefdal)
    End Sub

    Private Sub BtnSet_Click(sender As Object, e As EventArgs) Handles BtnSet.Click
        My.Computer.Registry.CurrentUser.CreateSubKey(ClsRegKeys.PrintServicesKey)
        Dim TheSubsids As SUBSIDS = LookUpEdit1.EditValue

        My.Computer.Registry.SetValue(ClsRegKeys.PrintServicesKeyFullPath, "SubId", TheSubsids.SubFileIdNo)
        End
    End Sub
End Class