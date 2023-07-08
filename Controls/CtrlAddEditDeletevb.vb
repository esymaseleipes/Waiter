Public Class CtrlAddEditDeletevb
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Event AddObject()
    Public Event EditObject()
    Public Event DeleteObject()

    Public Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        RaiseEvent AddObject()
    End Sub

    Public Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        RaiseEvent DeleteObject()
    End Sub

    Public Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        RaiseEvent EditObject()
    End Sub
End Class
