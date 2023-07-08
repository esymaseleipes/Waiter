Imports DevExpress.Xpo
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FrmStockUnit
    Dim mm As STOCKUNIT
    Dim ses As Session
    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        mm = New STOCKUNIT(ses)
    End Sub
    Public Sub New(_mm As STOCKUNIT)
        InitializeComponent()
        mm = _mm
        txtCode.Text = mm.sunCode
        TxtDescr.Text = mm.sunDescr
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        With mm
            .sunCode = txtCode.Text
            .sunDescr = TxtDescr.Text
            mm.Save()
        End With
    End Sub
End Class