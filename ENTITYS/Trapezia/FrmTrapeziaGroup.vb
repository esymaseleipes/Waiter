Imports WaiterModel.Cmp300


Public Class FrmTrapeziaGroup
    Implements IcanCrud

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(station As SUBSIDS)
        InitializeComponent()
        GridControl1.DataSource = station.TRAPEZIAGROUPs
        Entity = EnEntitys.EnGroupTrapezia
        TRAPEZIAGROUP.AutoSaveOnEndEdit = True
    End Sub

#Region "Interface"

    Private _entity As EnEntitys
    Public Property Entity As EnEntitys Implements IcanCrud.Entity
        Get
            Return _entity
        End Get
        Set(value As EnEntitys)
            _entity = value
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

    Private Sub BtnShowTrapezia_Click(sender As Object, e As EventArgs) Handles BtnShowTrapezia.Click
        Dim tgroup As TRAPEZIAGROUP = TryCast(GridView1.GetFocusedRow, TRAPEZIAGROUP)
        Dim f As New FrmTrapezia(tgroup)
        f.ShowDialog()
    End Sub
#End Region
End Class