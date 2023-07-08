Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraBars
Imports WindowsApplication1
Imports WindowsApplication1.Cmp300

Public Class BaseControl
    Implements IcanCrud
    Public Property Ses As Session
    Public Property BaseCollection As XPCollection
    Public Property BaseType As Type
    Public Property Criteria As CriteriaOperator
    Public Event BtnAddClick()
    Public Event BtnEditClick()
    Public Event BtnDeleteClick()
    Public Event BtnViewClick()
    Public Event BtnRefreshClick()
    Public Event BtnExportClick()
    Public Event BtnPrintClick()
    Public Event BtnTransesClick()
    Public Event BtnItemTransesClick()


    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(_entity As EnEntitys, _BaseType As Type, _Criteria As CriteriaOperator)
        InitializeComponent()
        Entity = _entity
        BaseType = _BaseType
        Criteria = _Criteria
        RefreshGrid()
    End Sub
    Public Sub RefreshGrid()
        GridControl1.DataSource = Nothing
        If Not Ses Is Nothing Then Ses.DropIdentityMap()
        Ses = New Session
        BaseCollection = New XPCollection(Ses, BaseType)
        BaseCollection.Criteria = Criteria
        GridControl1.DataSource = BaseCollection
        GridControl1.Refresh()
        'propertyGridControl1.SelectedObject = TryCast(gridControl1.MainView, GridView).Columns(0)
    End Sub
#Region "Interface"
    Private _Entity As EnEntitys
    Public Property Entity As EnEntitys Implements IcanCrud.Entity
        Get
            Return _Entity
        End Get
        Set(value As EnEntitys)
            _Entity = value
        End Set
    End Property
    Public Sub AddRecord() Implements IcanCrud.AddRecord
        Throw New NotImplementedException()
    End Sub

    Public Sub DeleteRecord() Implements IcanCrud.DeleteRecord
        Throw New NotImplementedException()
    End Sub

    Public Sub EditRecord() Implements IcanCrud.EditRecord
        Throw New NotImplementedException()
    End Sub

    Public Sub ViewRecord() Implements IcanCrud.ViewRecord
        Throw New NotImplementedException()
    End Sub

#End Region

#Region "EventsOfBtns"
    Private Sub BtnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnAdd.ItemClick
        RaiseEvent BtnAddClick()
    End Sub

    Private Sub BtnDelete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnDelete.ItemClick
        RaiseEvent BtnDeleteClick()
    End Sub

    Private Sub BtnEdit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnEdit.ItemClick
        RaiseEvent BtnEditClick()
    End Sub

    Private Sub BtnExport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnExport.ItemClick
        RaiseEvent BtnExportClick()
    End Sub

    Private Sub BtnPrint_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnPrint.ItemClick
        RaiseEvent BtnPrintClick()
    End Sub

    Private Sub BtnRefresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnRefresh.ItemClick
        RaiseEvent BtnRefreshClick()
    End Sub

    Private Sub BtnView_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnView.ItemClick
        RaiseEvent BtnViewClick()
    End Sub

    Private Sub BtnTranses_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnTranses.ItemClick
        RaiseEvent BtnTransesClick()
    End Sub

    Private Sub BtnTransItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BtnTransItem.ItemClick
        RaiseEvent BtnItemTransesClick()
    End Sub

#End Region

End Class
