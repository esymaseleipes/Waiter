Imports DevExpress.Xpo

Public Class FrmHotelRoomTypes
    Dim ses As Session
    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        Cmp300.RoomType.AutoSaveOnEndEdit = True

        RoomTypeCollection.Session = ses
        BedsCollection.Session = ses
    End Sub
End Class