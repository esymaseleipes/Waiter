Imports DevExpress.Xpo
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FrmPH
    Dim oph As PHTrans
    Dim ses As Session

    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        oph = New PHTrans(ses)
        initbind()
    End Sub

    Public Sub New(_oph As PHTrans)
        InitializeComponent()
        oph = _oph
        ses = oph.Session
        initbind()
    End Sub


    Private Sub initbind()
        txtDate.DataBindings.Add(New Binding("EditValue", oph, "iDate"))
        txtTime.DataBindings.Add(New Binding("EditValue", oph, "iTime"))
        txtcl.DataBindings.Add(New Binding("Text", oph, "Cl"))
        txtph.DataBindings.Add(New Binding("Text", oph, "Ph"))
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        oph.Save()
        Me.Close()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class