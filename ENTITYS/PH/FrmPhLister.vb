Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FrmPhLister
    Implements IcanCrud


    Public Sub New()
        InitializeComponent()
        Me.Entity = EnEntitys.EnRooms
    End Sub

    Private Property _Entity As EnEntitys
    Public Property Entity As EnEntitys Implements IcanCrud.Entity
        Get
            Return _Entity
        End Get
        Set(value As EnEntitys)
            _Entity = value
        End Set
    End Property

    Public Sub AddRecord() Implements IcanCrud.AddRecord
        Dim f As FrmPH = New FrmPH
        f.ShowDialog()
        XpCollection1.Reload()
    End Sub

    Public Sub EditRecord() Implements IcanCrud.EditRecord
        Dim oph As PHTrans = GridView1.GetFocusedRow
        Dim f As FrmPH = New FrmPH(oph)
        f.ShowDialog()
        XpCollection1.Reload()
    End Sub

    Public Sub DeleteRecord() Implements IcanCrud.DeleteRecord

    End Sub

    Public Sub ViewRecord() Implements IcanCrud.ViewRecord
        GridView1.ShowPrintPreview()
    End Sub
End Class