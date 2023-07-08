Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class StorFeat1Frm
    Private _Obj As STORFEAT1
    Public Property Obj() As STORFEAT1
        Get
            Return _Obj
        End Get
        Set(ByVal value As STORFEAT1)
            _Obj = value
        End Set
    End Property

    Public Sub New(TheVal As STORFEAT1)
        InitializeComponent()
        Obj = TheVal

        SetBindings()
        If Obj.sFeatureId = 0 Then
            Obj.sFeature1 = ClsShareFunctions.RetLastCode(GetType(STORFEAT1), 3)
            Obj.sFeatureId = CInt(Obj.sFeature1)
        End If

    End Sub
    Private Sub SetBindings()
        TextEdit1.DataBindings.Add(New Binding("EditValue", Obj, "sFeature1", True))
        TextEdit2.DataBindings.Add(New Binding("EditValue", Obj, "tsDescr1", True))
        PictureEdit1.DataBindings.Add(New Binding("EditValue", Obj, "Photo", True))

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub
End Class