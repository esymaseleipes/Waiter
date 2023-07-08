Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FrmFpa
    Public Property fpa As VAT

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(_fpa As VAT)
        InitializeComponent()
        fpa = _fpa
        ShowVals()
    End Sub

    Private Sub ShowVals()
        TxtFpaVal.Text = fpa.FpaData
        TxtTmhma.Text = fpa.Tmhma
        TxtFpaCode.Text = fpa.FpaCode
    End Sub
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        fpa.FpaData = TxtFpaVal.Text
        fpa.Tmhma = TxtTmhma.Text
        fpa.FpaCode = TxtFpaCode.Text
    End Sub

End Class