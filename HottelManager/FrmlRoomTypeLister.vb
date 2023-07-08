Imports DevExpress.Xpo
Imports NrgWaiterModel.Cmp300

Public Class FrmlRoomTypeLister
    Dim ses As Session
    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        RoomType.AutoSaveOnEndEdit = True

        RoomTypeCollection.Session = ses
        BedsCollection.Session = ses
    End Sub
End Class