Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WindowsApplication1.Cmp300

Public Class FrmArrivals
    Dim oRoomTransCollection As XPCollection(Of RoomTrans)
#Region "init ribon"
    Public WithEvents BtnAdd As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnEdit As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnDelete As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnView As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnRefresh As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnPrint As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnTranses As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnTransItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Public WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Dim RoomTransType As EnRoomTransType


    Private Sub InitRibon()
        Me.RibbonPage1.Text = "."
        Me.BtnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnView = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnTranses = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnTransItem = New DevExpress.XtraBars.BarButtonItem()
        '   Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BtnAdd, Me.BtnEdit, Me.BtnDelete, Me.BtnView, Me.BtnRefresh, Me.BtnPrint, Me.BtnExport, Me.BtnTranses, Me.BtnTransItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 11
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(826, 140)
        '
        'BtnAdd
        '
        Me.BtnAdd.Caption = "Νέα Καταχώρηση"
        Me.BtnAdd.Id = 1
        Me.BtnAdd.ImageUri.Uri = "Add"
        Me.BtnAdd.Name = "BtnAdd"
        '
        'BtnEdit
        '
        Me.BtnEdit.Caption = "Μεταβολή"
        Me.BtnEdit.Id = 2
        Me.BtnEdit.ImageUri.Uri = "Clear"
        Me.BtnEdit.Name = "BtnEdit"
        '
        'BtnDelete
        '
        Me.BtnDelete.Caption = "Διαγραφή"
        Me.BtnDelete.Id = 3
        Me.BtnDelete.ImageUri.Uri = "Cancel"
        Me.BtnDelete.Name = "BtnDelete"
        '
        'BtnView
        '
        Me.BtnView.Caption = "Προβολή"
        Me.BtnView.Id = 4
        Me.BtnView.ImageUri.Uri = "Show"
        Me.BtnView.Name = "BtnView"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Caption = "Refresh"
        Me.BtnRefresh.Id = 5
        Me.BtnRefresh.ImageUri.Uri = "Refresh"
        Me.BtnRefresh.Name = "BtnRefresh"
        '
        'BtnPrint
        '
        Me.BtnPrint.Caption = "Εκτύπωση"
        Me.BtnPrint.Id = 6
        Me.BtnPrint.ImageUri.Uri = "Print"
        Me.BtnPrint.Name = "BtnPrint"
        '
        'BtnExport
        '
        Me.BtnExport.Caption = "Export"
        Me.BtnExport.Id = 7
        Me.BtnExport.ImageUri.Uri = "SendBehindText"
        Me.BtnExport.Name = "BtnExport"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "."
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnAdd)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnEdit)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnDelete)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnView)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Βασικά Στοιχεία"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnRefresh)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnPrint)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnExport)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        'BtnTranses
        '
        Me.BtnTranses.Caption = "Γενική Καρτελα"
        Me.BtnTranses.Id = 8
        Me.BtnTranses.ImageUri.Uri = "ListBullets"
        Me.BtnTranses.Name = "BtnTranses"
        '
        'BtnTransItem
        '
        Me.BtnTransItem.Caption = "Καρτέλα Στοιχείου"
        Me.BtnTransItem.Id = 9
        Me.BtnTransItem.ImageUri.Uri = "ListNumbers"
        Me.BtnTransItem.Name = "BtnTransItem"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnTranses)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnTransItem)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
    End Sub
#End Region
    Dim ses As Session


    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        InitRibon()
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
        InitRibon()
        oRoomTransCollection = New XPCollection(Of RoomTrans)(ses, New BinaryOperator("TransType", RoomTransType))
        GridControl1.DataSource = oRoomTransCollection
    End Sub

    Private Sub NewArrival() Handles BtnAdd.ItemClick
        Dim ff As FrmHotelArrival = New FrmHotelArrival(RoomTransType)
        ff.ShowDialog()
        oRoomTransCollection.Reload()
        GridControl1.Refresh()
    End Sub
End Class