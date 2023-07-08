Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300


Public Class FrmArrivals
    Implements IcanCrud

    Dim oRoomTransCollection As XPCollection(Of RoomTrans)
    Dim RoomTransType As EnRoomTransType
    Dim ses As Session

    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
    End Sub

    Public Sub New(_roomtransType As EnRoomTransType)
        InitializeComponent()
        RoomTransType = _roomtransType
        Select Case RoomTransType
            Case EnRoomTransType.Endeparture
                Me.Text = "Αναχωρήσεις"
            Case EnRoomTransType.EnReservation
                Me.Text = "Κρατήσεις"
            Case EnRoomTransType.EnΑrrival
                Me.Text = "Αφίξεις"
        End Select
        ses = New Session(Kefdal)

        oRoomTransCollection = New XPCollection(Of RoomTrans)(ses, New BinaryOperator("TransType", RoomTransType) And New BinaryOperator("Status", 0))
        GridControl1.DataSource = oRoomTransCollection
    End Sub

    Public Property Entity As EnEntitys Implements IcanCrud.Entity

        Get
            Return EnEntitys.EnRooms
        End Get
        Set(value As EnEntitys)
            '    Throw New NotImplementedException()
        End Set
    End Property

    Public Sub AddRecord() Implements IcanCrud.AddRecord
        Dim f As FrmHotelArrival = New FrmHotelArrival(EnRoomTransType.EnΑrrival)
        f.ShowDialog()
        oRoomTransCollection.Reload()
    End Sub

    Public Sub EditRecord() Implements IcanCrud.EditRecord
        Dim rt As RoomTrans = GridView1.GetFocusedRow
        If Not rt Is Nothing Then
            Dim f As FrmHotelArrival = New FrmHotelArrival(rt)
            f.ShowDialog()
        End If

        oRoomTransCollection.Reload()
    End Sub

    Public Sub DeleteRecord() Implements IcanCrud.DeleteRecord

    End Sub

    Public Sub ViewRecord() Implements IcanCrud.ViewRecord

    End Sub

    'Private Sub NewArrival() Handles BtnAdd.ItemClick
    '    Dim ff As FrmHotelArrival = New FrmHotelArrival(RoomTransType)
    '    ff.ShowDialog()
    '    oRoomTransCollection.Reload()
    '    GridControl1.Refresh()
    'End Sub
End Class