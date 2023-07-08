Imports DevExpress.Xpo

Public Class FrmParentChild
    Dim ses As Session

    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        XpCollection1.Session = ses

    End Sub
End Class