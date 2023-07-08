Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WindowsApplication1.Cmp300

Public Class FrmHotelArrival
    Dim ses As Session
    Dim TmpRoomTrans As RoomTrans
    Dim TmpRoomTransToCustomer As RoomTransToCustomer
    Dim TransType As EnRoomTransType
    Dim AgentCollection As XPCollection(Of CMAST)
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(_transType As EnRoomTransType)
        InitializeComponent()
        ses = New Session(Kefdal)
        RoomsCollection.Session = ses

        'CustomersCollection.CriteriaString = "[cFeatCode1] = 1L"
        'CustomersCollection.Session = ses
        CmbCustomer.DataSource = CMAST.ReturnNotAgentCollection(ses)


        TmpRoomTrans = New RoomTrans(ses)
        RoomTransToCustomerCollection.Session = ses
        TransType = _transType
        GridControl1.DataSource = TmpRoomTrans.RoomTransToCustomers
        AgentCollection = CMAST.ReturnAgentCollection(ses)

        With CmbAgent.Properties
            .DataSource = AgentCollection
            .ValueMember = "This"
            .DisplayMember = "cName"
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cFileId", "cFileID", 50, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far),
                              New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cName", "Επωνυμία", 107, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        End With



    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CmbRoom.EditValue Is Nothing Then Exit Sub
        With TmpRoomTrans

            .Room = CmbRoom.EditValue
            .ArrivalDate = DateEdit1.EditValue
            .DueDate = DateEdit2.EditValue
            .TransType = TransType ' EnRoomTransType.EnΑrrival
            .Save()

            Select Case TransType
                Case EnRoomTransType.EnReservation
                Case EnRoomTransType.Endeparture
                Case EnRoomTransType.EnΑrrival
                    .Room.RoomStatus = EnRoomStatus.EnRoomsTypeNotAvailable
                    ses.Save(.Room)
            End Select

            Me.Close()
        End With




    End Sub

    Private Sub BtnCancell_Click(sender As Object, e As EventArgs) Handles BtnCancell.Click
        Me.Close()
    End Sub
End Class