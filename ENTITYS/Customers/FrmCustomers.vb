Imports DevExpress.Xpo
Imports WaiterModel.Cmp300

Public Class FrmCustomers
    Implements IcanCrud
    Dim ses As Session


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ses = New Session(Kefdal)
        Entity = EnEntitys.EnCustomers
        XpCollection1.Session = ses
    End Sub
    Dim _Entity As EnEntitys
    Public Property Entity As EnEntitys Implements IcanCrud.Entity
        Get
            Return _Entity
        End Get
        Set(value As EnEntitys)
            _Entity = value
        End Set
    End Property

    Public Sub AddRecord() Implements IcanCrud.AddRecord
        ShowCustomer(New Customers(ses) With {.Company = ses.GetObjectByKey(Of SUBSIDS)(LogonData.LogonCompany.SubFileIdNo)})
        'Throw New NotImplementedException()
    End Sub

    Public Sub EditRecord() Implements IcanCrud.EditRecord
        Dim customer As Customers = GridView1.GetFocusedRow
        If Not customer Is Nothing Then
            ShowCustomer(customer)
        End If
        'Throw New NotImplementedException()
    End Sub

    Public Sub DeleteRecord() Implements IcanCrud.DeleteRecord
        'Throw New NotImplementedException()
    End Sub

    Public Sub ViewRecord() Implements IcanCrud.ViewRecord
        'Throw New NotImplementedException()
    End Sub

    Private Sub ShowCustomer(OCustomer As Customers)
        Dim f As FrmCustomer = New FrmCustomer(OCustomer)
        f.ShowDialog()
        XpCollection1.Reload()
        GridView1.RefreshData()
    End Sub

End Class