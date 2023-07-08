Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300


Public Class FrmSeason
    Private _Obj As SSEAZON
    Public Property Obj() As SSEAZON
        Get
            Return _Obj
        End Get
        Set(ByVal value As SSEAZON)
            _Obj = value
        End Set
    End Property



    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(TheVal As SSEAZON)
        InitializeComponent()
        Obj = TheVal
        If Obj.sseFileId = 0 Then TheVal.sseFileId = ClsShareFunctions.RetLastId(GetType(SSEAZON))
        SetBindings()
    End Sub
    Private Sub SetBindings()
        TextEdit1.DataBindings.Add(New Binding("Text", Obj, "sseDescr", True))
    End Sub

End Class