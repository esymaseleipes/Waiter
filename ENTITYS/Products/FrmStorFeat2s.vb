Imports DevExpress.Data.Filtering
Imports DevExpress.Utils.DragDrop
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports WaiterModel.Cmp300

Public Class FrmStorFeat2s
    Dim ses As Session
    Dim YpoomadaCollection As XPCollection(Of STORFEAT2)
    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        XpCollection1.Session = ses
        cmbOmada.EditValue = XpCollection1(0)
    End Sub

    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles cmbOmada.EditValueChanged
        Dim omada As STORFEAT1 = cmbOmada.EditValue
        If Not omada Is Nothing Then

            YpoomadaCollection = New XPCollection(Of STORFEAT2)(ses, New BinaryOperator("Parent", omada))
            '  fixnulls(YpoomadaCollection)
            YpoomadaCollection.Sorting.Add(New SortProperty("SortId", DB.SortingDirection.Ascending))

            GridControl1.DataSource = YpoomadaCollection
            HandleBehaviorDragDropEvents(False)
        End If
    End Sub


    Private Sub fixnulls(ypoomades As XPCollection(Of STORFEAT2))
        If ypoomades.Where(Function(a) a.SortId = Nothing).Count > 0 Then
            Debug.Print("Fixnulls")
            For i = 0 To ypoomades.Count - 1
                Debug.Print("Descr=" & ypoomades(i).tsDescr2 & "i=" & i)
                ypoomades(i).SortId = i
            Next
            ses.Save(ypoomades)

        End If

    End Sub




    Public Sub HandleBehaviorDragDropEvents(Optional RemoveHandlerf As Boolean = False)
        Dim gridControlBehavior As DragDropBehavior = BehaviorManager1.GetBehavior(Of DragDropBehavior)(Me.GridView1)
        If RemoveHandlerf = True Then
            RemoveHandler gridControlBehavior.DragDrop, AddressOf Behavior_DragDrop
            RemoveHandler gridControlBehavior.DragOver, AddressOf Behavior_DragOver
        Else
            AddHandler gridControlBehavior.DragDrop, AddressOf Behavior_DragDrop
            AddHandler gridControlBehavior.DragOver, AddressOf Behavior_DragOver
        End If
    End Sub
    Private Sub Behavior_DragOver(ByVal sender As Object, ByVal e As DragOverEventArgs)
        Dim args As DragOverGridEventArgs = DragOverGridEventArgs.GetDragOverGridEventArgs(e)
        e.InsertType = args.InsertType
        e.InsertIndicatorLocation = args.InsertIndicatorLocation
        e.Action = args.Action
        Cursor.Current = args.Cursor
        args.Handled = True
    End Sub
    Private Sub Behavior_DragDrop(ByVal sender As Object, ByVal e As DevExpress.Utils.DragDrop.DragDropEventArgs)
        Debug.Print("Behavior_DragDrop")
        Dim targetGrid As GridView = TryCast(e.Target, GridView)
        Dim sourceGrid As GridView = TryCast(e.Source, GridView)
        If e.Action = DragDropActions.None OrElse targetGrid IsNot sourceGrid Then
            Return
        End If


        '''Debug.Print(e.GetData(Of Integer))
        Dim DesthitPoint As Point = targetGrid.GridControl.PointToClient(Cursor.Position)
        Dim DesthitInfo As GridHitInfo = targetGrid.CalcHitInfo(DesthitPoint)
        If DesthitInfo.RowHandle < 0 Then Exit Sub

        Debug.Print("From " & GridView1.FocusedRowHandle & " To " & DesthitInfo.RowHandle)


        Dim TmpYpoomada As STORFEAT2 = GridView1.GetFocusedRow
        Dim ThisRowHandle As Integer = DesthitInfo.RowHandle


        Dim TmpYpoomada2 As STORFEAT2
        For i = 0 To GridView1.RowCount - 1

            TmpYpoomada2 = TryCast(GridView1.GetRow(i), STORFEAT2)

            If TmpYpoomada Is TmpYpoomada2 Then
                TmpYpoomada2.SortId = ThisRowHandle
            Else
                If i = ThisRowHandle Then
                    TmpYpoomada2.SortId = i + 1
                Else
                    TmpYpoomada2.SortId = i
                End If

            End If
            ses.Save(TmpYpoomada2)
        Next

        GridView1.RefreshData()
    End Sub
End Class