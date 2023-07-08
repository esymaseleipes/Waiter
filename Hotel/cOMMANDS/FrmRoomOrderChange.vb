Imports DevExpress.Xpo
Imports WaiterModel.Cmp300

Public Class FrmRoomOrderChange
    Dim ses As Session
    Dim Tmproom As Room = Nothing
    Dim CloseOpenOrders As Boolean = False
    Dim ReservedRooms As XPCollection(Of Room)
    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        ReservedRooms = New XPCollection(Of Room)(ses)

        GridControl1.DataSource = Nothing
        ' LookUpEdit1.Properties.DataSource = ReservedRooms
    End Sub
    Public Sub New(_CloseOpenOrders As Boolean)
        InitializeComponent()
        ses = New Session(Kefdal)
        ReservedRooms = New XPCollection(Of Room)(ses)
        GridControl1.DataSource = Nothing
        CloseOpenOrders = _CloseOpenOrders
        LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'BtnCloseOpenOrders.Visible = True
    End Sub




    Private Function ShowRoomTrans(Theroom As Room)
        GridControl1.DataSource = Theroom.RoomTransCollection.Where(Function(a) a.Status = 0).FirstOrDefault.PosOrders
    End Function


    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit1.EditValueChanged
        Tmproom = LookUpEdit1.EditValue
        ShowRoomTrans(Tmproom)
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click
        Dim rt As PosOrder = GridView1.GetFocusedRow
        If Not rt Is Nothing Then
            Dim ff As FrmSetOrderNewRoom = New FrmSetOrderNewRoom(ses, rt)
            ff.ShowDialog()
            GridControl1.DataSource = Nothing
            Tmproom.RoomTransCollection.Reload()
            ShowRoomTrans(Tmproom)
            'ses = Nothing
            'ses = ClsShareFunctions.GetNewSession


        End If
    End Sub

    Private Sub BtnCloseOpenOrders_Click(sender As Object, e As EventArgs) Handles BtnCloseOpenOrders.Click
        If Tmproom Is Nothing Then
            MsgBox("Επέλεξε ένα Δωμάτιο!!!")
            Exit Sub
        End If



        'Dim Openposorders As XPCollection(Of PosOrder) = Tmproom.RoomTransCollection.Where(Function(a) a.Status = 0).FirstOrDefault.PosOrders.Where(Function(b) b.Status = EnOrderStatus.EnOrderOpen)

        'Dim ses As Session = New Session(Posdal)
        'Dim OpenOrders As XPCollection(Of PosOrder) = New XPCollection(Of PosOrder)(ses, New BinaryOperator("Status", EnOrderStatus.EnOrderOpen))
        Dim usr As MyUsers = ses.GetObjectByKey(Of MyUsers)(LogonData.LogonUserId)
        Dim subs As SUBSIDS = ses.GetObjectByKey(Of SUBSIDS)(LogonData.LogonCompany.SubFileIdNo)


        For Each ord As PosOrder In Tmproom.RoomTransCollection.Where(Function(a) a.Status = 0).FirstOrDefault.PosOrders.Where(Function(b) b.Status = EnOrderStatus.EnOrderOpen)
            If Not ord.RoomTrans Is Nothing Then
                ord.OrderPayType = EnOrderPayType.EnPayTypeRoomCharge
                ord.Status = EnOrderStatus.EnOrderClosed
                ord.User = usr
                ord.Save()
                Dim hd As HardJob = New HardJob(ses) With {.PosOrder = ord, .ToDo = EnHardJobs.EnCloseOrder, .User = usr, .Station = subs}
                hd.Save()
            End If
        Next




    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class


