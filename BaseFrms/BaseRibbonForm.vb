Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300
Imports WindowsApplication1
Imports WindowsApplication1.Cmp300

Public Class BaseRibbonForm
    Implements IcanCrud
    Dim Ses As Session
    Dim BaseCollection As XPCollection
    Dim BaseType As Type
    Dim Criteria As CriteriaOperator

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
#Region "Commands"
    Private Sub CmdAdd() Handles BtnAdd.ItemClick
        AddRecord()
    End Sub
    Private Sub CmdEdit() Handles BtnEdit.ItemClick
        EditRecord()
    End Sub

    Private Sub CmdDelte() Handles BtnDelete.ItemClick
        DeleteRecord()
    End Sub
    Private Sub CmdView() Handles BtnShow.ItemClick
        ViewRecord()
    End Sub

    Private Sub CmdRefresh() Handles BtnRefresh.ItemClick
        RefreshGrid()
    End Sub
#End Region





End Class