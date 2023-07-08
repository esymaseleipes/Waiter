Imports DevExpress.Xpo

Public Class FrmHotelRooms
    Dim ses As Session

    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        RoomsCollection.Session = ses
        RoomTypeCollection.Session = ses
        Cmp300.Room.AutoSaveOnEndEdit = True

    End Sub
End Class