Imports DevExpress.Data.Filtering
Imports DevExpress.Utils.DragDrop
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports WaiterModel.Cmp300
Imports WindowsApplication1
Imports WindowsApplication1.Cmp300

Public Class FrmProductBrowser
    Implements IcanCrud

    Dim Ses As Session

    Dim CategoryCollection As XPCollection(Of SSEAZON)




    Public Sub New()
        InitializeComponent()
        Entity = EnEntitys.EnProduct
        Ses = ClsShareFunctions.GetNewSession
        ProductCollection.Session = Ses
        CategoryCollection = New XPCollection(Of SSEAZON)(Ses)
        LueCategory.Properties.DataSource = CategoryCollection

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


        Dim DesthitPoint As Point = targetGrid.GridControl.PointToClient(Cursor.Position)
        Dim DesthitInfo As GridHitInfo = targetGrid.CalcHitInfo(DesthitPoint)
        If DesthitInfo.RowHandle < 0 Then Exit Sub

        Debug.Print("From " & GridView1.FocusedRowHandle & " To " & DesthitInfo.RowHandle)


        Dim TmpPrd As SMAST = GridView1.GetFocusedRow
        Dim ThisRowHandle As Integer = DesthitInfo.RowHandle

        'TmpPrd.Sortid = ThisRowHandle
        'Ses.Save(TmpPrd)

        Dim tmpprd2 As SMAST
        For i = 0 To GridView1.RowCount - 1
            tmpprd2 = TryCast(GridView1.GetRow(i), SMAST)
            If TmpPrd Is tmpprd2 Then
                tmpprd2.Sortid = ThisRowHandle
            Else
                tmpprd2.Sortid = i
            End If


            Ses.Save(tmpprd2)
        Next
        GridView1.RefreshData()
    End Sub
#Region "Interface"
    Dim _Entity As EnEntitys
    Public Property Entity As EnEntitys Implements IcanCrud.Entity
        Get
            Return _Entity
        End Get
        Set(value As EnEntitys)
            _Entity = value
        End Set
    End Property
    Public Sub AddRecord() Implements IcanCrud.AddRecord
        Dim f As FrmProduct = New FrmProduct(Ses)
        'f.MdiParent = Me.MdiParent
        'f.Show()
        f.ShowDialog()
        ProductCollection.Reload()
    End Sub
    Public Sub EditRecord() Implements IcanCrud.EditRecord
        Dim Prd As SMAST = GridView1.GetFocusedRow()
        If Not Prd Is Nothing Then
            Dim f As FrmProduct = New FrmProduct(Prd)
            f.ShowDialog()
        End If
        ProductCollection.Reload()
    End Sub
    Public Sub DeleteRecord() Implements IcanCrud.DeleteRecord
        Dim Prd As SMAST = GridView1.GetFocusedRow()

        If MsgBox("Θέλετε να διαγραφέι το Είδος:" & Prd.sName, vbYesNo) = vbNo Then Exit Sub

        If Not Prd Is Nothing Then
            If New XPCollection(Of PosOrderLine)(Ses, New BinaryOperator("Product", Prd)).Count > 0 Then
                MsgBox("Το Είδος Έχει Παραγγελίες και δεν μπορεί να διαγραφεί!!!")
            Else
                '  Dim sstorecollection As XPCollection(Of SSTORE) = New XPCollection(Of SSTORE)(Ses, New BinaryOperator("sFileId", Prd))
                ' Dim strncollection As XPCollection(Of STRN) = New XPCollection(Of STRN)(Ses, New BinaryOperator("sFileId", Prd))
                ''  Prd.Session.Delete(sstorecollection)
                '  Prd.Session.Save(sstorecollection)
                ' Prd.Session.Delete(strncollection)
                '  Prd.Session.Save(strncollection)
                Prd.Delete()
                MsgBox("H διαγραφή Ολοκληρώθηκε Επιτυχώς")
            End If
        End If

    End Sub
    Public Sub ViewRecord() Implements IcanCrud.ViewRecord
        GridView1.OptionsPrint.PrintDetails = True
        GridControl1.ShowPrintPreview()
        'Throw New NotImplementedException()
    End Sub
#End Region



    Private Sub LueCategory_EditValueChanged(sender As Object, e As EventArgs) Handles LueCategory.EditValueChanged
        Dim Cat As SSEAZON = LueCategory.EditValue
        If Not Cat Is Nothing Then
            LueOmada.Properties.DataSource = Cat.STORFEAT1s
            If Cat.STORFEAT1s.Count > 0 Then LueOmada.EditValue = Cat.STORFEAT1s(0)
        Else
            LueOmada.Properties.DataSource = Nothing
            LueYpoomada.Properties.DataSource = Nothing
        End If
        ProductFilter()
    End Sub
    Private Sub LueOmada_EditValueChanged(sender As Object, e As EventArgs) Handles LueOmada.EditValueChanged
        Dim Omada As STORFEAT1 = LueOmada.EditValue
        If Not Omada Is Nothing Then
            LueYpoomada.Properties.DataSource = Omada.STORFEAT2s
            If Omada.STORFEAT2s.Count > 0 Then LueYpoomada.EditValue = Omada.STORFEAT2s(0)
        Else
            LueYpoomada.Properties.DataSource = Nothing
        End If
        ProductFilter()
    End Sub
    Private Sub LueYpoomada_EditValueChanged(sender As Object, e As EventArgs) Handles LueYpoomada.EditValueChanged
        ProductFilter()
    End Sub

    Private Sub ProductFilter()
        Dim cat As SSEAZON = LueCategory.EditValue
        Dim Omada As STORFEAT1 = LueOmada.EditValue
        Dim Ypoomada As STORFEAT2 = LueYpoomada.EditValue


        If Not Omada Is Nothing AndAlso Not Ypoomada Is Nothing Then
            HandleBehaviorDragDropEvents()
        Else
            HandleBehaviorDragDropEvents(True)
        End If

        If cat Is Nothing Then
            ProductCollection.Filter = Nothing
        Else

            ProductCollection.Filter = IIf(cat Is Nothing, Nothing, New BinaryOperator("NrgCategory", cat)) And
            IIf(Omada Is Nothing, Nothing, New BinaryOperator("NrgOmada", Omada)) And
             IIf(Ypoomada Is Nothing, Nothing, New BinaryOperator("NrgYpoomada", Ypoomada))

            ProductCollection.Sorting.AddRange(New SortProperty() {New SortProperty("[Sortid]", DB.SortingDirection.Ascending)})

        End If

        GridControl1.DataSource = ProductCollection

    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim Prd As SMAST = GridView1.GetFocusedRow()
        If Not Prd Is Nothing Then
            Dim f As FrmProduct = New FrmProduct(Prd)
            f.ShowDialog()
        End If
        ProductCollection.Reload()

        'Dim Prd As SMAST = GridView1.GetFocusedRow()
        'If Not Prd Is Nothing Then
        '    Dim f As FrmProduct = New FrmProduct(Prd)
        '    f.ShowDialog()
        '    f.Dispose()
        'End If
        'ProductCollection.Reload()
        ''Dim FF As FrmProductTranses = New FrmProductTranses(Prd)
        'FF.MdiParent = Me.MdiParent
        'FF.Show()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        HandleBehaviorDragDropEvents()
    End Sub

    Private Sub LueOmada_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles LueOmada.ButtonClick
        Dim f3 As StorFeat1Frm
        Dim Cat As SSEAZON = LueCategory.EditValue
        Dim omad As STORFEAT1
        If Cat Is Nothing Then
            MsgBox("Δέν έχετε Επιλέξει Κατηγορία!!!")
            Exit Sub
        End If

        If e.Button.Kind = -5 Then Exit Sub

        'Debug.Print("e.Button.Kind=" & e.Button.Kind)

        Select Case e.Button.Kind
            Case ButtonPredefines.Plus
                omad = New STORFEAT1(Ses) With {.Category = Cat}

            Case ButtonPredefines.Glyph
                omad = LueOmada.EditValue
                If omad Is Nothing Then Return
        End Select

        f3 = New StorFeat1Frm(omad)
        If f3.ShowDialog() = DialogResult.OK Then
            If f3.Obj.tsDescr1 = "" Then
                MsgBox("Προσοχή Κενή Περιγραφή Ομάδας")
            Else
                f3.Obj.Save()
                Cat.Reload()
                LueOmada.Refresh()
                GridControl1.Refresh()
                GridView1.RefreshData()
            End If
        End If
    End Sub

    Private Sub LueYpoomada_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles LueYpoomada.ButtonClick
        Try


            Dim f3 As StorFeat2Frm
            Dim omada As STORFEAT1 = LueOmada.EditValue
            Dim ypoomad As STORFEAT2 = LueYpoomada.EditValue

            If omada Is Nothing Then
                MsgBox("Δέν έχετε Επιλέξει Ομάδα!!!")
                Return
            End If

            If e.Button.Kind = ButtonPredefines.Plus Then
                f3 = New StorFeat2Frm(New STORFEAT2(Ses) With {.Parent = omada})
                If f3.ShowDialog() = DialogResult.OK Then
                    If f3.Obj.tsDescr2 = "" Then
                        MsgBox("Προσοχή Κενή Περιγραφή ΥποΟμάδας")
                        Return
                    End If
                    f3.Obj.Save()
                    omada.Reload()
                End If
            End If

            If e.Button.Kind = ButtonPredefines.Glyph Then
                If ypoomad Is Nothing Then Return

                If e.Button.Caption = "Edit" Then
                    f3 = New StorFeat2Frm(ypoomad)
                    If f3.ShowDialog() = DialogResult.OK Then
                        If Not f3.Obj Is Nothing Then
                            If f3.Obj.tsDescr2 = "" Then
                                MsgBox("Προσοχή Κενή Περιγραφή ΥποΟμάδας")
                                Return
                            Else
                                f3.Obj.Save()
                                omada.Reload()
                                ypoomad.Reload()
                                LueYpoomada.Refresh()
                                GridControl1.Refresh()
                                GridView1.RefreshData()
                            End If
                        End If
                    End If
                End If


                If e.Button.Caption = "Comments" Then
                    Dim frmcommen As FrmProductComments = New FrmProductComments(ypoomad)
                    frmcommen.ShowDialog()
                End If

                If e.Button.Caption = "Medical" Then
                    Dim frmcommen As FrmProductComments = New FrmProductComments()
                    frmcommen.ShowDialog()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class

