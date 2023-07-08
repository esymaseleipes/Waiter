Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FrmProductComments
    Dim ses As Session
    Dim Mycomments As XPCollection(Of Comments)

    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        Ypoomades.Session = ses
        Comments.AutoSaveOnEndEdit = True
        LookUpEdit1.Enabled = False
        Mycomments = New XPCollection(Of Comments)(ses, New NullOperator("Ypoomada"))
        Mycomments.DeleteObjectOnRemove = True
        GridControl1.DataSource = Mycomments
        Me.Text = "Διατροφικές Έπιλογές"
    End Sub
    Public Sub New(Ypoomada As STORFEAT2)
        InitializeComponent()
        Ypoomades.Session = Ypoomada.Session 'ClsShareFunctions.GetNewSession
        LookUpEdit1.EditValue = Ypoomada 'Ypoomades(0)

        LookUpEdit1.Enabled = False
    End Sub

    Protected Overrides Sub Finalize()
        Debug.Print("Finalize")
        MyBase.Finalize()
    End Sub

    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit1.EditValueChanged
        Mycomments = CType(LookUpEdit1.EditValue, STORFEAT2).CommentsCollection
        Mycomments.DeleteObjectOnRemove = True
        GridControl1.DataSource = Mycomments 'CType(LookUpEdit1.EditValue, STORFEAT2).CommentsCollection
    End Sub

    'Private Sub gridControl1_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles GridControl1.EmbeddedNavigator.ButtonClick
    '    If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
    '        If MessageBox.Show("Do you want to delete the current row?", "Confirm deletion",
    '       MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) <> DialogResult.Yes Then
    '            '  ses.Save(CType(LookUpEdit1.EditValue, STORFEAT2).CommentsCollection)
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub
End Class