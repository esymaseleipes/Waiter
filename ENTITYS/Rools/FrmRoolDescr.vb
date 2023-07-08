Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FrmRoolDescr
    Public Property TmpRoll As Roll


    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(_tmpRoll As Roll)
        InitializeComponent()
        TmpRoll = _tmpRoll
        TxtRoll.Text = TmpRoll.Descr
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        TmpRoll.Descr = TxtRoll.Text
        Me.Close()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class