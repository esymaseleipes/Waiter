Imports DevExpress.Xpo
Imports WindowsApplication1.Cmp300

Public Class FrmBedType
    Dim Ses As Session
    Public Sub New()
        InitializeComponent()
        BedType.AutoSaveOnEndEdit = True

        Ses = New Session(Kefdal)
        BedCollection.Session = Ses
    End Sub
End Class