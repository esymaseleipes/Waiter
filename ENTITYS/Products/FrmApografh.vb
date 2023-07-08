Imports DevExpress.Xpo
Imports WindowsApplication1.Cmp300

Public Class FrmApografh
    Dim ses As Session
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ses = ClsShareFunctions.GetNewSession
        ProductsCollection.Session = ses

    End Sub
End Class