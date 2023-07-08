Imports DevExpress.Xpo
Imports WindowsApplication1.Cmp300

Public Class FrmHotelCustomerAges
    Dim ses As Session

    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        CustomerAgesRange.AutoSaveOnEndEdit = True
    End Sub
End Class