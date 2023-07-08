Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports WaiterModel.Cmp300
Imports WindowsApplication1
Imports WindowsApplication1.Cmp300

Public Class FrmUsers
    Implements IcanCrud
    Dim ses As Session
    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        UsersCollection.Session = ses
        RollsCollection.Session = ses
        Me.Entity = EnEntitys.EnUsers
        MyUsers.AutoSaveOnEndEdit = True
    End Sub


#Region "INTERFACE"
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
        Dim f As FrmUser = New FrmUser
        f.ShowDialog()
        f.Dispose()
        UsersCollection.Reload()
    End Sub

    Public Sub DeleteRecord() Implements IcanCrud.DeleteRecord
        '   Throw New NotImplementedException()
    End Sub

    Public Sub EditRecord() Implements IcanCrud.EditRecord
        Dim tmpuser As MyUsers = GridView1.GetFocusedRow
        If tmpuser IsNot Nothing Then
            Dim f As FrmUser = New FrmUser(tmpuser)
            f.ShowDialog()
            f.Dispose()
            UsersCollection.Reload()
        End If
    End Sub

    Public Sub ViewRecord() Implements IcanCrud.ViewRecord
        '  Throw New NotImplementedException()
    End Sub

    Private Sub BtnStations_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles BtnStations.ButtonClick
        Dim user As MyUsers = TryCast(GridView1.GetFocusedRow, MyUsers)
        Dim f As New FrmUserToStation(user)
        f.ShowDialog()
    End Sub
#End Region
End Class