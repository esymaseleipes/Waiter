

Imports WaiterModel.Cmp300

Public Class FrmTrapezia
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(Trapeziagroup As TRAPEZIAGROUP)
        InitializeComponent()
        GridControl1.DataSource = Trapeziagroup.TRAPEZIACollection
        TRAPEZIA.AutoSaveOnEndEdit = True
    End Sub
End Class