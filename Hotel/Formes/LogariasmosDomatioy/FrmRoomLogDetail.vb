Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports WaiterModel.Cmp300

Public Class FrmRoomLogDetail
    Dim PosorderCollection As XPCollection(Of PosOrder)
    Dim ses As Session = New Session(Kefdal)
    Dim TheRoom As Room
    Dim WithEvents link As New PrintableComponentLink()

    Public Sub New()
        InitializeComponent()
    End Sub


    Public Sub New(_PosorderCollection As XPCollection(Of PosOrder), View As Boolean)
        InitializeComponent()
        PosorderCollection = _PosorderCollection
        ses = PosorderCollection.Session
        TheRoom = PosorderCollection(0).RoomTrans.Room
        GridControl1.DataSource = PosorderCollection

        Me.Text += "Δωμάτιο " & PosorderCollection(0).RoomTrans.Room.RoomDescr

        CmbPayType.Properties.AddEnum(GetType(EnOrderPayType))
        CmbPayType.Properties.Items.Remove(CmbPayType.Properties.Items.GetItem(EnOrderPayType.EnPayTypeRoomCharge))
        CmbPayType.EditValue = EnOrderPayType.EnPayTypeCash
        TxtTotal.Text = Math.Round((PosorderCollection.Sum(Function(a) a.OrderValue)), 2)

        If View = True Then BtnCloseRoom.Visibility = BarItemVisibility.Never


    End Sub

    Private Sub BtnPrintRoomLog_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPrintRoomLog.ItemClick
        Dim ReportFile As String = Application.StartupPath & "\Reports\SynoptikosLogariasmos.repx"
        Dim retb As Boolean = JustPrint(PosorderCollection, ReportFile)
    End Sub
    Public Shared Function JustPrint(PosOrders As XPCollection(Of PosOrder), ReportFile As String) As Boolean

        Try
            Dim report As New XtraReport
            report.LoadLayout(ReportFile)
            report.ShowPrintMarginsWarning = False
            report.DataSource = PosOrders
            report.ShowPreview
            Return True
        Catch ex As Exception
            Debug.Print(ex.Message)
            Return False
        End Try
    End Function

    Private Sub BtnPrintRoomLogDetail_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnPrintRoomLogDetail.ItemClick
        Dim ReportFile As String = Application.StartupPath & "\Reports\AnalytikosLogariasmos.repx"
        Dim retb As Boolean = JustPrint(PosorderCollection, ReportFile)
    End Sub







    Private Sub FrmRoomLogDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i = 0 To GridView1.RowCount - 1
            GridView1.ExpandMasterRow(i, 5)
        Next
        GridView1.OptionsDetail.ShowDetailTabs = False
    End Sub

    Private Sub BtnCloseRoom_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCloseRoom.ItemClick
        If PosorderCollection.Where(Function(a) a.Status = EnOrderStatus.EnOrderOpen).Count > 0 Then
            MsgBox("Υπάρχου ανοικτές παραγγελίες!!")
            Exit Sub
        End If

        For Each ord As PosOrder In PosorderCollection
            ses.ExecuteNonQuery("Update PosOrder set OrderPayType=" & CmbPayType.EditValue & " where Oid=" & ord.Oid)
        Next
        TheRoom.RoomStatus = EnRoomStatus.EnRoomsStatusAvailable
        TheRoom.Save()

        Dim rt As RoomTrans = PosorderCollection(0).RoomTrans
        rt.Status = 1
        rt.Save()
        ses.Save(rt)
        Me.Close()
    End Sub


End Class