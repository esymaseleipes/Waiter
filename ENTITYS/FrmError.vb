Public Class FrmError
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ErrDescr As String)
        InitializeComponent()
        Me.MemoEdit1.Text = ErrDescr
    End Sub
End Class