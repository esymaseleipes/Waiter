Imports DevExpress.Xpo
Imports WindowsApplication1.Cmp300

Public Class FrmHotelRoomBoard
    Dim ses As Session

    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        RoomBoard.AutoSaveOnEndEdit = True
    End Sub
End Class