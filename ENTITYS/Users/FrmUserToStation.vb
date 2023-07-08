Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FrmUserToStation
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(user As MyUsers)
        InitializeComponent()
        GridControl1.DataSource = user.UserToStations
        StationCollection.Session = user.Session
        UserToStation.AutoSaveOnEndEdit = True
    End Sub

End Class