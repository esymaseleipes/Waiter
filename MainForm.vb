Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraBars.Ribbon
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300



Public Class MainForm

    Public Sub New()
        InitializeComponent()
        Me.Text = "NRG Waiter:" & Application.ProductVersion
        Dim f As FormLogon = New FormLogon
        f.ShowDialog()
    End Sub
#Region "MainProc"
    Public Sub AddFormToMdiWithoutPermisions(frm As DevExpress.XtraEditors.XtraForm)
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Public Sub AddFormToMdi(frm As DevExpress.XtraEditors.XtraForm, Optional NoCheck As Boolean = False)
        If TypeOf (frm) Is IcanCrud Then
            Dim f As IcanCrud = frm
            If ClsShareFunctions.CheckPermisions(f.Entity, EnCrudCommands.EnViewRecord) = False Then
                MsgBox("Ο Χρήστης Δέν Έχει Τα Απαραίτητα Δικαιώματα!!")
                Exit Sub
            End If
        End If
        If NoCheck = False Then
            For Each p As DevExpress.XtraTabbedMdi.XtraMdiTabPage In MdiManager.Pages
                If p.MdiChild.Name = frm.Name Then Exit Sub
            Next
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Start.LogonData.LogonCompany.PosCnfgs(0).Skin <> "" Then DefaultLookAndFeel1.LookAndFeel.SkinName = Start.LogonData.LogonCompany.PosCnfgs(0).Skin

        'If XmlParams.Skin <> "" Then DefaultLookAndFeel1.LookAndFeel.SkinName = XmlParams.Skin
        Try
            If Start.LogonData.LogonCompany.PosCnfgs(0).RoomManager = True Then
                RibbonPageHotel.Visible = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'End
    End Sub
    Private Sub SkinObject_GalleryItemClick(sender As Object, e As GalleryItemClickEventArgs) Handles SkinObject.GalleryItemClick
        Start.LogonData.LogonCompany.PosCnfgs(0).Skin = e.Item.Caption
        Start.LogonData.LogonCompany.PosCnfgs(0).Save()
    End Sub

#End Region
#Region "Buttons"
    Private Sub BtnProducts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnProducts.ItemClick
        AddFormToMdi(New FrmProductBrowser)
    End Sub
    '
    '

#End Region
#Region "Interface Commands"
    Private Sub BtnAbb_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnAdd.ItemClick
        iCrud(EnCrudCommands.EnNewRecord)
    End Sub
    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEdit.ItemClick
        iCrud(EnCrudCommands.EnEditRecord)
    End Sub
    Private Sub BtnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDelete.ItemClick
        iCrud(EnCrudCommands.EnDeleteRecord)
    End Sub
    Private Sub BtnView_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnView.ItemClick
        iCrud(EnCrudCommands.EnViewRecord)
    End Sub
    Private Sub iCrud(CrudCommand As EnCrudCommands)
        If TypeOf (Me.ActiveMdiChild) Is IcanCrud Then
            Dim f As IcanCrud = Me.ActiveMdiChild
            Select Case CrudCommand
                Case EnCrudCommands.EnNewRecord
                    If ClsShareFunctions.CheckPermisions(f.Entity, EnCrudCommands.EnNewRecord) = True Then
                        f.AddRecord()
                    Else
                        MsgBox("Ο Χρήστης Δέν Έχει Τα Απαραίτητα Δικαιώματα Προσθήκης")
                    End If
                Case EnCrudCommands.EnEditRecord
                    If ClsShareFunctions.CheckPermisions(f.Entity, EnCrudCommands.EnEditRecord) = True Then
                        f.EditRecord()
                    Else
                        MsgBox("Ο Χρήστης Δέν Έχει Τα Απαραίτητα Δικαιώματα Μεταβολής")
                    End If
                Case EnCrudCommands.EnDeleteRecord
                    If ClsShareFunctions.CheckPermisions(f.Entity, EnCrudCommands.EnDeleteRecord) = True Then
                        f.DeleteRecord()
                    Else
                        MsgBox("Ο Χρήστης Δέν Έχει Τα Απαραίτητα Δικαιώματα Διαγραφής")
                    End If
                Case EnCrudCommands.EnViewRecord
                    If ClsShareFunctions.CheckPermisions(f.Entity, EnCrudCommands.EnViewRecord) = True Then
                        f.ViewRecord()
                    Else
                        MsgBox("Ο Χρήστης Δέν Έχει Τα Απαραίτητα Δικαιώματα Προβολής")
                    End If

            End Select
        End If
    End Sub

    '

    Private Sub BtnPrinters_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPrinters.ItemClick
        Dim f As New FrmPrinters
        f.ShowDialog()
    End Sub

    '
    '
    '

    Private Sub BtnUsers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnUsers.ItemClick
        AddFormToMdi(New FrmUsers)
    End Sub

    Private Sub BtnRollsManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRollsManager.ItemClick
        AddFormToMdi(New FrmRolls)
    End Sub

    '
    '
    Private Sub BtnReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnReport.ItemClick
        'Dim rep As FrmNewReport = New FrmNewReport
        Dim rep As New WaiterReport1
        rep.Show()
        'AddFormToMdi(New WaiterReport1)
    End Sub
    '

    Private Sub BtnFpa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnFpa.ItemClick

        AddFormToMdi(New FrmFrpas)
    End Sub

    Private Sub btnChangeProductFpa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChangeProductFpa.ItemClick
        If InputBox("Κωδικός Service:") = "1054210542" Then
            Dim f As FrmChangeProductFpa = New FrmChangeProductFpa
            f.ShowDialog()
        End If
    End Sub
    '



    Private Sub BarBtnYpoomades_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnYpoomades.ItemClick
        Dim f As FrmStorFeat2s = New FrmStorFeat2s
        f.ShowDialog()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim f As FrmQrCode = New FrmQrCode
        f.ShowDialog()
    End Sub

    Private Sub BarBtnGsisSetup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub BarBtnGsis_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnGsis.ItemClick
        Dim f As FrmGsis = New FrmGsis
        f.ShowDialog()
    End Sub

    Private Sub BarBtnPool_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnPool.ItemClick
        AddFormToMdi(New FrmPhLister)

    End Sub

    Private Sub BarBtnPosCnfg_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnPosCnfg.ItemClick
        AddFormToMdi(New FrmPosConfig(LogonData.LogonCompany))
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        AddFormToMdi(New FrmTrapeziaGroup(LogonData.LogonCompany))
    End Sub

    Private Sub BtnRooms_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRooms.ItemClick
        AddFormToMdi(New FrmRoomsLister)
    End Sub

    Private Sub BarBtnRoomTypes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnRoomTypes.ItemClick
        '  AddFormToMdi(New FrmlRoomTypeLister)
    End Sub

    Private Sub BtnArrivals_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnArrivals.ItemClick
        AddFormToMdi(New FrmArrivals(EnRoomTransType.EnΑrrival))
    End Sub

    Private Sub BtnRoomHold_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRoomHold.ItemClick
        AddFormToMdi(New FrmArrivals(EnRoomTransType.EnReservation))
    End Sub





    Private Sub BtnCustomers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCustomers.ItemClick
        AddFormToMdi(New FrmCustomers)
    End Sub

    Private Sub BtnHtm_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnHtm.ItemClick
        Dim f As FrmReportDesign = New FrmReportDesign
        f.Show()
    End Sub

    Private Sub BtnRoomsLog_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRoomsLog.ItemClick
        AddFormToMdi(New FrmRoomLogs)
    End Sub





    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        AddFormToMdi(New FrmRoomLogs(1))
    End Sub

    Private Sub BtnHotelOrderChange_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnHotelOrderChange.ItemClick
        Dim f As FrmRoomChanges = New FrmRoomChanges
        f.ShowDialog()

    End Sub

    Private Sub BtnRoomOrderChange1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRoomOrderChange1.ItemClick
        AddFormToMdi(New FrmRoomOrderChange)
    End Sub

    Private Sub BarBtnApografh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnApografh.ItemClick
        AddFormToMdi(New FrmApografh)
    End Sub




#End Region
End Class