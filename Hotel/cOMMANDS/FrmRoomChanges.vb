Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300


Public Class FrmRoomChanges
    Dim ses As Session
    Public Sub New()
        InitializeComponent()
        ses = Cmp300.ClsShareFunctions.GetNewSession
        AvailalesRooms.Session = ses
        NoAvailableRooms.Session = ses
    End Sub

    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles BtnChange.Click
        Try
            If LookUpEdit1.EditValue Is Nothing Or LookUpEdit2.EditValue Is Nothing Then
                MsgBox("Επέλεξε Δωμάτιο!!!!")
                Exit Sub
            End If

            Dim sourceroom As Room = LookUpEdit1.EditValue
            Dim destroom As Room = LookUpEdit2.EditValue
            Dim TmpRoomtrans As RoomTrans = ses.FindObject(Of RoomTrans)(New BinaryOperator("Room", sourceroom) And New BinaryOperator("Status", 0))
            TmpRoomtrans.Room = destroom
            ses.Save(TmpRoomtrans)

            sourceroom.RoomStatus = EnRoomStatus.EnRoomsStatusAvailable
            ses.Save(sourceroom)

            destroom.RoomStatus = EnRoomStatus.EnRoomsTypeNotAvailable
            ses.Save(destroom)

            MsgBox("Η αλλαγή δωματίου ολοκληρώθηκε!!!!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.Message)
        End Try




    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class


