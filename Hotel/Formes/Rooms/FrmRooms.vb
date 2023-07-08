Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports WindowsApplication1
Imports WindowsApplication1.Cmp300

Public Class FrmRooms
    Implements IcanCrud

    Dim ses As Session
    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        RoomsCollection.Session = ses
        CmbRoomType.AddEnum(Of EnRoomsType)()
        Me.Entity = EnEntitys.EnRooms
        Room.AutoSaveOnEndEdit = True
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

    End Sub

    Public Sub DeleteRecord() Implements IcanCrud.DeleteRecord

    End Sub

    Public Sub EditRecord() Implements IcanCrud.EditRecord

    End Sub

    Public Sub ViewRecord() Implements IcanCrud.ViewRecord

    End Sub
    Private Sub GridControl1_EmbeddedNavigator_ButtonClick(sender As Object, e As NavigatorButtonClickEventArgs) Handles GridControl1.EmbeddedNavigator.ButtonClick
        Select Case e.Button.ButtonType
            Case NavigatorButtonType.Append
                e.Handled = True
                RoomsCollection.Add(New Room(ses) With {.RoomStatus = EnRoomStatus.EnRoomsStatusAvailable})


        End Select
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim Tmproom As Room = GridView1.GetRow(e.RowHandle)
        Tmproom.RoomStatus = EnRoomStatus.EnRoomsStatusAvailable
    End Sub
End Class