Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300


Public Class FrmRoomLogs
    Dim ses As Session
    Dim RoomTransCollection As XPCollection(Of RoomTrans)
    Dim status As Integer
    Public Sub New()
        InitializeComponent()
        status = 0
        RefreshGrid()
    End Sub

    Public Sub New(_status As Integer)
        InitializeComponent()
        status = _status
        GridControl1.DataSource = Nothing
        If Not ses Is Nothing Then ses.Dispose()
        ses = New Session(Kefdal)
        RoomTransCollection = New XPCollection(Of RoomTrans)(ses, New BinaryOperator("Status", _status))
        GridControl1.DataSource = RoomTransCollection
    End Sub

    Private Function RefreshGrid() As Boolean
        GridControl1.DataSource = Nothing
        If Not ses Is Nothing Then ses.Dispose()
        ses = New Session(Kefdal)
        RoomTransCollection = New XPCollection(Of RoomTrans)(ses, New BinaryOperator("Status", status))
        GridControl1.DataSource = RoomTransCollection
    End Function


    Private Sub BtnRoomLogDetail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRoomLogDetail.ItemClick
        Dim trans As RoomTrans = GridView1.GetFocusedRow
        Dim trans2 As RoomTrans = GridView1.GetFocusedRow
        If trans Is Nothing Then Exit Sub

        trans.PosOrders.Filter = New BinaryOperator("OrderPayType", EnOrderPayType.EnPayTypeRoomCharge)

        If trans.PosOrders.Count = 0 Then
            trans.PosOrders.Filter = New BinaryOperator("Status", EnOrderStatus.EnOrderOpen)
            If trans.PosOrders.Count = 0 Then
                If MsgBox("Τό δωμάτιο " & trans.Room.RoomDescr & " δέν έχει κινήσεις!!! Θέλετε να κλείσετε το δωμάτιο", vbYesNo) = vbYes Then
                    closeroom(trans)
                End If
                Exit Sub
            Else
                MsgBox("Τό δωμάτιο " & trans.Room.RoomDescr & "  έχει Ανοικτές Παραγγελίες!!!")
                Exit Sub
            End If
        End If



        trans2.PosOrders.Filter = New BinaryOperator("Status", EnOrderStatus.EnOrderOpen)
        If trans2.PosOrders.Count > 0 Then
            MsgBox("Τό δωμάτιο " & trans2.Room.RoomDescr & "  έχει Ανοικτές Παραγγελίες!!!")
            ShowRoomDetail(trans, True)
            Exit Sub
        End If



        ShowRoomDetail(trans, False)


    End Sub
    Private Sub ShowRoomDetail(trans As RoomTrans, rview As Boolean)
        trans.PosOrders.Filter = New BinaryOperator("OrderPayType", EnOrderPayType.EnPayTypeRoomCharge)
        Dim f As FrmRoomLogDetail = New FrmRoomLogDetail(trans.PosOrders, rview)
        f.ShowDialog()
        ses.DropIdentityMap()
        ses = New Session(Kefdal)
        RoomTransCollection.Session = ses
        GridControl1.Refresh()
    End Sub

    'GetOpenRoomRemain



    Private Sub closeroom(TheTrans As RoomTrans)
        Dim theroom As Room = TheTrans.Room
        theroom.RoomStatus = EnRoomStatus.EnRoomsStatusAvailable
        theroom.Save()
        TheTrans.Status = 1
        ses.Save(TheTrans)
        RoomTransCollection.Reload()
    End Sub

    Private Sub BtnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRefresh.ItemClick
        RefreshGrid()
        'RoomTransCollection.Reload()
    End Sub

    Private Sub BtnCloseOpenOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCloseOpenOrder.ItemClick
        Dim rt As RoomTrans = GridView1.GetFocusedRow
        If rt Is Nothing Then
            MsgBox("Επέλεξε ένα δωμάτιο!!!")
            Exit Sub
        End If

        If MsgBox("Θέλετε να κλείσετε τις ανοικτές παραγγελίες του δωματίου:" & rt.Room.RoomDescr, vbYesNo) = vbYes Then
            Dim usr As MyUsers = ses.GetObjectByKey(Of MyUsers)(LogonData.LogonUserId)
            Dim subs As SUBSIDS = ses.GetObjectByKey(Of SUBSIDS)(LogonData.LogonCompany.SubFileIdNo)


            For Each ord As PosOrder In rt.PosOrders.Where(Function(b) b.Status = EnOrderStatus.EnOrderOpen)
                If Not ord.RoomTrans Is Nothing Then
                    ord.OrderPayType = EnOrderPayType.EnPayTypeRoomCharge
                    ord.Status = EnOrderStatus.EnOrderClosed
                    ord.User = usr
                    ord.Save()
                    Dim hd As HardJob = New HardJob(ses) With {.PosOrder = ord, .ToDo = EnHardJobs.EnCloseOrder, .User = usr, .Station = subs}
                    hd.Save()
                End If
            Next

        End If

        'Dim f As FrmRoomOrderChange = New FrmRoomOrderChange(True)
        'f.ShowDialog()
        RoomTransCollection.Reload()
    End Sub

    Private Sub FrmRoomLogs_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Debug.Print("FrmRoomLogs_Activated")
    End Sub

    Private Sub FrmRoomLogs_Load(sender As Object, e As EventArgs) Handles Me.Load
        Debug.Print("FrmRoomLogs_Load")

    End Sub

    Private Sub FrmRoomLogs_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Debug.Print("FrmRoomLogs_Shown")
        ' Dim pf As MainForm = Me.MdiParent
        ' pf.SplashScreenManager1.CloseWaitForm()
    End Sub

    Private Sub BtnCloseOpenOrderσ_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCloseOpenOrderσ.ItemClick
        If MsgBox("Θέλετε να κλείσουν όλες οι ανοικτές παραγγελίες των δωματίων", vbYesNo) = vbNo Then Exit Sub
        Dim pf As MainForm = Me.MdiParent

        Dim usr As MyUsers = ses.GetObjectByKey(Of MyUsers)(LogonData.LogonUserId)
        Dim subs As SUBSIDS = ses.GetObjectByKey(Of SUBSIDS)(LogonData.LogonCompany.SubFileIdNo)

        pf.SplashScreenManager1.ShowWaitForm()

        For Each rt As RoomTrans In RoomTransCollection
            For Each ord As PosOrder In rt.PosOrders.Where(Function(a) a.Status = EnOrderStatus.EnOrderOpen)
                ord.OrderPayType = EnOrderPayType.EnPayTypeRoomCharge
                ord.Status = EnOrderStatus.EnOrderClosed
                ord.User = usr
                ord.Save()
                Dim hd As HardJob = New HardJob(ses) With {.PosOrder = ord, .ToDo = EnHardJobs.EnCloseOrder, .User = usr, .Station = subs}
                hd.Save()
            Next
        Next
        pf.SplashScreenManager1.CloseWaitForm()
        Me.Close()
    End Sub

    'Private Sub BtnService_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnService.ItemClick
    '    If InputBox("Service code") = "1054210542" Then
    '        GridView1.OptionsBehavior.Editable = True
    '        GridView1.Columns.Where(Function(a) a.Name = "colService")(0).Visible = True
    '    End If
    'End Sub

    Private Sub BtnEditRoomTransState_Click(sender As Object, e As EventArgs) Handles BtnEditRoomTransState.Click
        Dim trans As RoomTrans = GridView1.GetFocusedRow
        trans.Status = 1
        trans.Save()
        MsgBox("Trans Changed")
    End Sub

    'Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click

    'End Sub

    ''Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click

    ''End Sub
End Class