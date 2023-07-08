Imports DevExpress.Xpo
Imports WaiterModel.Cmp300

Public Class FrmSetOrderNewRoom
    Dim ses As Session
    Dim Tmpposorder As PosOrder
    Public Sub New(_ses As Session, _posorder As PosOrder)
        InitializeComponent()
        ses = _ses
        ReservedRooms.Session = ses
        Tmpposorder = _posorder
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim tmproom As Room = LookUpEdit1.EditValue
        Dim tmproomtrans As RoomTrans = tmproom.RoomTransCollection.Where(Function(a) a.Status = 0).FirstOrDefault
        Tmpposorder.RoomTrans = tmproomtrans
        Tmpposorder.Save()

        Me.Close()
    End Sub

    Private Sub BtnEsc_Click(sender As Object, e As EventArgs) Handles BtnEsc.Click
        Me.Close()
    End Sub
End Class