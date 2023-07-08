Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300

Public Class FrmHotelArrival
    Dim ses As Session
    Dim TmpRoomTrans As RoomTrans
    Dim RoomsCollection As XPCollection(Of Room)
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(_transType As EnRoomTransType)
        InitializeComponent()
        ses = New Session(Kefdal)

        RoomsCollection = New XPCollection(Of Room)(ses, New BinaryOperator("RoomStatus", 1))
        RoomsCollection.Session = ses
        CmbRoom.Properties.DataSource = RoomsCollection
        TmpRoomTrans = New RoomTrans(ses) With {.TransType = _transType}
        RoomTransToCustomerCollection.Session = ses

        initBind()
    End Sub
    Public Sub New(_roomTrans As RoomTrans)
        InitializeComponent()
        TmpRoomTrans = _roomTrans
        ses = TmpRoomTrans.Session
        RoomsCollection = New XPCollection(Of Room)(ses)
        CmbRoom.Properties.DataSource = RoomsCollection
        RoomTransToCustomerCollection.Session = ses

        initBind()
    End Sub
    Private Sub initBind()
        CmbRoom.DataBindings.Add(New Binding("EditValue", TmpRoomTrans, "Room!"))
        DateEdit1.DataBindings.Add(New Binding("EditValue", TmpRoomTrans, "ArrivalDate"))
        DateEdit2.DataBindings.Add(New Binding("EditValue", TmpRoomTrans, "DueDate"))

    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TmpRoomTrans.Room Is Nothing Then Exit Sub

        ses.Save(TmpRoomTrans)

        Select Case TmpRoomTrans.TransType
            Case EnRoomTransType.EnReservation
            Case EnRoomTransType.Endeparture
            Case EnRoomTransType.EnΑrrival
                TmpRoomTrans.Room.RoomStatus = EnRoomStatus.EnRoomsTypeNotAvailable
                ses.Save(TmpRoomTrans.Room)
        End Select

        Me.Close()





    End Sub

    Private Sub BtnCancell_Click(sender As Object, e As EventArgs) Handles BtnCancell.Click
        Me.Close()
    End Sub
End Class