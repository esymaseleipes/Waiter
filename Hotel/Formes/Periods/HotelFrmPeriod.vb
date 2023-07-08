Imports DevExpress.Xpo

Public Class HotelFrmPeriod
    Dim Ses As Session
    Public Sub New()
        InitializeComponent()
        Cmp300.RoomPeriods.AutoSaveOnEndEdit = True
        Ses = New Session(Kefdal)

    End Sub
End Class