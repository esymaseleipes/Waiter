Imports System.Security.Cryptography
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Mask.Internal
Imports DevExpress.Pdf.Native
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout
Imports DevExpress.XtraPrinting
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class WaiterReport1
    Dim ses As Session
    Dim Collection1 As XPCollection(Of PosOrder)
    Dim GroupCollection As XPCollection(Of PosOrder)
    Dim ServiceMode As Boolean = False
    Private Class myview
        Public Property Product As SMAST
        Public Property Qnt As Decimal
        Public Property Value As Decimal
        Public Property Omada As String
        Public Property YpoOmada As String

    End Class



    Public Sub New()
        InitializeComponent()
        ses = ClsShareFunctions.GetNewSession
        If LogonData.LogonCompany.PosCnfgs(0).RoomManager = True Then
            'colTrapezi.Caption = "ΔΩΜΑΤΙΟ"
            'colTrapezi.FieldName = "RoomTrans.Room.RoomDescr"
            GridColumn29.Caption = "ΔΩΜΑΤΙΟ"
            GridColumn29.FieldName = "RoomTrans.Room.RoomDescr"
        End If

        Collection1 = New XPCollection(Of PosOrder)(ses, New BinaryOperator("Status", EnOrderStatus.EnOrderClosed))
        GridControl2.DataSource = Collection1
        OrdersCollection.Session = ses
        OrdersLineCollection.Session = ses
        XpDelete.Session = ses
        ChartControl2.DataSource = Nothing
        ChartControl4.DataSource = Nothing
        txtDateApo.EditValue = Now.Date
        txtDateEos.EditValue = Now.Date

        'GroupProducts()




    End Sub
    Private Sub ChartControl1_SelectedItemsChanged(sender As Object, e As SelectedItemsChangedEventArgs) Handles ChartControl1.SelectedItemsChanged
        Dim items As IList = ChartControl1.SelectedItems
        If items.Count > 0 Then
            ChartControl2.DataSource = Nothing
            ChartControl2.DataSource = items
            Dim FirstOrder As PosOrder = items(0)
            Dim LastOrder As PosOrder = items(items.Count - 1)


            'Dim oc As XPCollection(Of PosOrder) = New XPCollection(Of PosOrder)(ses, New BetweenOperator("OrderDate", FirstOrder.OrderDate, LastOrder.OrderDate))
            ' Dim FirstOrder As PosOrder = oc(0)
            ' Dim LastOrder As PosOrder = oc.Last



            'Dim oclines As XPCollection(Of PosOrderLine) = New XPCollection(Of PosOrderLine)(ses, New InOperator("PosOrder", oc))
            Dim oclines As XPCollection(Of PosOrderLine) = New XPCollection(Of PosOrderLine)(ses,
                                                                                             New BinaryOperator("PosOrder.Oid", FirstOrder.Oid, BinaryOperatorType.GreaterOrEqual) And
                                                                                             New BinaryOperator("PosOrder.Oid", LastOrder.Oid, BinaryOperatorType.LessOrEqual))



            ChartControl3.DataSource = Nothing
            ChartControl3.DataSource = oclines
            ChartControl4.DataSource = Nothing
            ChartControl4.DataSource = oclines





        End If
    End Sub
    Private Sub ChartControl2_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles ChartControl2.ObjectSelected
        If Not e.HitInfo.AxisLabelItem Is Nothing Then
            Dim dt As Date = e.HitInfo.AxisLabelItem.Text
            Dim oc As XPCollection(Of PosOrder) = New XPCollection(Of PosOrder)(ses, New BinaryOperator("OrderDate", dt))
            Dim oclines As XPCollection(Of PosOrderLine) = New XPCollection(Of PosOrderLine)(ses, New InOperator("PosOrder", oc))
            ChartControl3.DataSource = Nothing
            ChartControl3.DataSource = oclines
            ChartControl4.DataSource = Nothing
            ChartControl4.DataSource = oclines
        End If
    End Sub

    Private Sub ChartControl3_ObjectSelected(sender As Object, e As HotTrackEventArgs) Handles ChartControl3.ObjectSelected
        If Not e.HitInfo.AxisLabelItem Is Nothing Then
            Dim cat As String = e.HitInfo.AxisLabelItem.Text
            Dim ocat As STORFEAT1 = ses.FindObject(Of STORFEAT1)(New BinaryOperator("tsDescr1", cat))
            Dim XpLines As XPCollection(Of PosOrderLine) = New XPCollection(Of PosOrderLine)(ses, New BinaryOperator("Product.NrgOmada", ocat))

            ChartControl4.DataSource = Nothing
            ChartControl4.DataSource = XpLines
        End If


    End Sub




    '

    Private Sub TabbedControlGroup1_SelectedPageChanged(sender As Object, e As LayoutTabPageChangedEventArgs) Handles TabbedControlGroup1.SelectedPageChanged
        If e.Page.Name = "LayoutControlGroup7" Then XpDelete.Reload()
        'Debug.Print(e.Page.Name)
    End Sub

    Private Sub BtnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPrint.ItemClick
        Dim gv As GridView = Nothing


        Select Case TabbedControlGroup1.SelectedTabPage.Name
            Case "LayoutControlGroup2"
                gv = GridView1
            Case "LayoutControlGroup3"
                gv = GridView2
            Case "LayoutControlGroup5"
                gv = GridView5
            Case "LayoutControlGroup7"
                gv = GridView4
        End Select

        'If Not grid.IsPrintingAvailable Then
        '    MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
        '    Return
        'End If

        ' Print.

        If gv IsNot Nothing Then
            gv.OptionsPrint.ExpandAllGroups = False
            gv.ShowPrintPreview()
        End If
    End Sub

    Private Sub GridViewPrintInitialize(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView1.PrintInitialize, GridView2.PrintInitialize
        Dim pb As PrintingSystemBase = CType(e.PrintingSystem, PrintingSystemBase)
        pb.PageSettings.Landscape = True
    End Sub

    Private Sub BtnShowReport3_Click(sender As Object, e As EventArgs) Handles BtnShowReport3.Click
        'txtDateApo.EditValue = Now.Date
        'txtDateEos.EditValue = Now.Date

        'Dim dt1 As Date = txtDateApo.EditValue
        'Dim dt2 As Date = txtDateEos.EditValue


        GroupProducts(Nothing, Nothing)
    End Sub
    Private Sub GroupProducts(dt1 As Date, dt2 As Date)
        ses = New Session(Kefdal)
        Dim d1 As Date = txtDateApo.EditValue
        Dim d2 As Date = txtDateEos.EditValue

        Dim filtr As String = "PosOrder.OrderDate >= ? and PosOrder.OrderDate <= ?"
        Dim co As CriteriaOperator = CriteriaOperator.Parse(filtr, d1, d2)
        Dim OrderLines As XPCollection(Of PosOrderLine) = New XPCollection(Of PosOrderLine)(ses, co)

        Dim list = From c In OrderLines
                   Group c By ID = c.Product Into G = Group Select New With {
                                                           Key ID,
                                                              .sQnt = G.Sum(Function(a) a.Quant),
                                                              .sVals = G.Sum(Function(b) b.Total),
                                                              .Descr = ID.sName,
                                                              .Om1 = ID.NrgOmada.tsDescr1,
                                                              .Om2 = ID.NrgYpoomada.tsDescr2}










        GridControl5.DataSource = list
        Exit Sub



        'Dim SqlStr As String = "select Product,sum (Quant) as sqnt,sum(ProductVal) as sval from PosOrderLine group by Product"
        'Dim seldata As SelectedData = ses.ExecuteQuery(SqlStr)
        'Dim myview1 As New List(Of myview)
        'Dim Prd As SMAST
        'Dim PrdId As Integer
        ''        MsgBox(seldata0.ResultSet(0).Rows.Count)

        'For Each row As SelectStatementResultRow In seldata.ResultSet(0).Rows
        '    PrdId = row.Values(0)
        '    Prd = ses.GetObjectByKey(Of SMAST)(PrdId)
        '    Debug.Print("Val1=" & row.Values(1) & "Val2=" & row.Values(2))
        '    myview1.Add(New myview With {
        '                    .Product = Prd,
        '                    .Qnt = row.Values(1),
        '                    .Value = row.Values(2),
        '                    .Omada = Prd.NrgOmada.tsDescr1,
        '                    .YpoOmada = Prd.NrgYpoomada.tsDescr2
        '                    })

        '    Debug.Print("PrdId=" & Prd.sFileId & " ==>" & Prd.NrgYpoomada.tsDescr2)
        '    Next


        'GridControl3.DataSource = myview1
    End Sub

    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click

    End Sub

    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        Dim ord As PosOrder = GridView2.GetFocusedRow
        If Not ord Is Nothing Then
            Dim f As FrmOrder = New FrmOrder(ord)
            f.ShowDialog()
            GridControl2.Refresh()
            GridView2.RefreshData()
        End If
        '
    End Sub
End Class