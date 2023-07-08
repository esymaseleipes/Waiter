Imports WaiterModel.Cmp300

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WaiterReport1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WaiterReport1))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim XyDiagram4 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Me.OrdersLineCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.OrdersCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BtnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.XpDelete = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuant1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscval1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductVal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommentsVal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.BtnShowReport3 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDateEos = New DevExpress.XtraEditors.DateEdit()
        Me.txtDateApo = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ChartControl4 = New DevExpress.XtraCharts.ChartControl()
        Me.ChartControl3 = New DevExpress.XtraCharts.ChartControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscVal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductVal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommentsVal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToPrinter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToReceipt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToCashMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrinter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClonePrinter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAppComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPosition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMeriko = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVatValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XpCMyview = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.OrdersLineCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.txtDateEos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateEos.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateApo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateApo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCMyview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrdersLineCollection
        '
        Me.OrdersLineCollection.ObjectType = GetType(WaiterModel.Cmp300.PosOrderLine)
        '
        'OrdersCollection
        '
        Me.OrdersCollection.ObjectType = GetType(WaiterModel.Cmp300.PosOrder)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl5)
        Me.LayoutControl1.Controls.Add(Me.LayoutControl4)
        Me.LayoutControl1.Controls.Add(Me.LayoutControl3)
        Me.LayoutControl1.Controls.Add(Me.LayoutControl2)
        Me.LayoutControl1.Controls.Add(Me.ChartControl4)
        Me.LayoutControl1.Controls.Add(Me.ChartControl3)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.ChartControl2)
        Me.LayoutControl1.Controls.Add(Me.ChartControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 148)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1022, 592)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl5
        '
        Me.GridControl5.Location = New System.Drawing.Point(24, 96)
        Me.GridControl5.MainView = Me.GridView5
        Me.GridControl5.MenuManager = Me.RibbonControl1
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(974, 472)
        Me.GridControl5.TabIndex = 13
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn35, Me.GridColumn36, Me.GridColumn38, Me.GridColumn40, Me.GridColumn46})
        Me.GridView5.GridControl = Me.GridControl5
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.ReadOnly = True
        Me.GridView5.OptionsView.ShowFooter = True
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "Περιγραφή Είδος"
        Me.GridColumn35.FieldName = "Descr"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 0
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Συν.Ποσότητες"
        Me.GridColumn36.FieldName = "sQnt"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sQnt", "{0:0.##}")})
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 3
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "Συν.Αξίες"
        Me.GridColumn38.CustomizationCaption = "Συν.Αξίες"
        Me.GridColumn38.FieldName = "sVals"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sVals", "{0:0.##}")})
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 4
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "Ομάδα"
        Me.GridColumn40.CustomizationCaption = "Ομάδα"
        Me.GridColumn40.FieldName = "Om1"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 1
        '
        'GridColumn46
        '
        Me.GridColumn46.Caption = "Υποομάδα"
        Me.GridColumn46.FieldName = "Om2"
        Me.GridColumn46.Name = "GridColumn46"
        Me.GridColumn46.Visible = True
        Me.GridColumn46.VisibleIndex = 2
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BtnPrint})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 2
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1022, 148)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BtnPrint
        '
        Me.BtnPrint.Caption = "Εκτύπωση"
        Me.BtnPrint.Id = 1
        Me.BtnPrint.ImageOptions.SvgImage = CType(resources.GetObject("BtnPrint.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnPrint.Name = "BtnPrint"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Στατιστικά"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnPrint)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = " "
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 740)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1022, 27)
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.GridControl4)
        Me.LayoutControl4.Location = New System.Drawing.Point(24, 46)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.Root = Me.LayoutControlGroup8
        Me.LayoutControl4.Size = New System.Drawing.Size(974, 522)
        Me.LayoutControl4.TabIndex = 12
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'GridControl4
        '
        Me.GridControl4.DataSource = Me.XpDelete
        Me.GridControl4.Location = New System.Drawing.Point(12, 12)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.ShowOnlyPredefinedDetails = True
        Me.GridControl4.Size = New System.Drawing.Size(950, 498)
        Me.GridControl4.TabIndex = 4
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'XpDelete
        '
        Me.XpDelete.ObjectType = GetType(WaiterModel.Cmp300.DelPosOrderLine)
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid2, Me.GridColumn41, Me.GridColumn42, Me.colComments1, Me.colQuant1, Me.colPrice1, Me.colDisc1, Me.colDiscval1, Me.colProductVal1, Me.colCommentsVal1, Me.colTotal1, Me.colDocNum, Me.GridColumn43, Me.GridColumn44, Me.colTransTime, Me.colTransDate})
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        '
        'colOid2
        '
        Me.colOid2.FieldName = "Oid"
        Me.colOid2.Name = "colOid2"
        '
        'GridColumn41
        '
        Me.GridColumn41.FieldName = "Product!"
        Me.GridColumn41.Name = "GridColumn41"
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "Είδος"
        Me.GridColumn42.FieldName = "Product.sName"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 4
        '
        'colComments1
        '
        Me.colComments1.FieldName = "Comments"
        Me.colComments1.Name = "colComments1"
        '
        'colQuant1
        '
        Me.colQuant1.Caption = "Ποσότητα"
        Me.colQuant1.FieldName = "Quant"
        Me.colQuant1.Name = "colQuant1"
        Me.colQuant1.Visible = True
        Me.colQuant1.VisibleIndex = 5
        '
        'colPrice1
        '
        Me.colPrice1.Caption = "Τιμή"
        Me.colPrice1.FieldName = "Price"
        Me.colPrice1.Name = "colPrice1"
        Me.colPrice1.Visible = True
        Me.colPrice1.VisibleIndex = 6
        '
        'colDisc1
        '
        Me.colDisc1.Caption = "Έκπτ%"
        Me.colDisc1.FieldName = "Disc"
        Me.colDisc1.Name = "colDisc1"
        '
        'colDiscval1
        '
        Me.colDiscval1.Caption = "Αξία Έκπτ."
        Me.colDiscval1.FieldName = "Discval"
        Me.colDiscval1.Name = "colDiscval1"
        '
        'colProductVal1
        '
        Me.colProductVal1.Caption = "Αξία"
        Me.colProductVal1.FieldName = "ProductVal"
        Me.colProductVal1.Name = "colProductVal1"
        '
        'colCommentsVal1
        '
        Me.colCommentsVal1.Caption = "Extra"
        Me.colCommentsVal1.FieldName = "CommentsVal"
        Me.colCommentsVal1.Name = "colCommentsVal1"
        '
        'colTotal1
        '
        Me.colTotal1.Caption = "Σύνολο"
        Me.colTotal1.FieldName = "Total"
        Me.colTotal1.Name = "colTotal1"
        Me.colTotal1.Visible = True
        Me.colTotal1.VisibleIndex = 7
        '
        'colDocNum
        '
        Me.colDocNum.Caption = "Παραστ/κό"
        Me.colDocNum.FieldName = "DocNum"
        Me.colDocNum.Name = "colDocNum"
        Me.colDocNum.Visible = True
        Me.colDocNum.VisibleIndex = 3
        '
        'GridColumn43
        '
        Me.GridColumn43.FieldName = "User!"
        Me.GridColumn43.Name = "GridColumn43"
        '
        'GridColumn44
        '
        Me.GridColumn44.Caption = "Χρήστης"
        Me.GridColumn44.FieldName = "User.UserName"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 2
        '
        'colTransTime
        '
        Me.colTransTime.Caption = "ΩΡΑ"
        Me.colTransTime.DisplayFormat.FormatString = "HH:mm"
        Me.colTransTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTransTime.FieldName = "TransTime"
        Me.colTransTime.Name = "colTransTime"
        Me.colTransTime.Visible = True
        Me.colTransTime.VisibleIndex = 1
        '
        'colTransDate
        '
        Me.colTransDate.Caption = "Ημερ/νία"
        Me.colTransDate.FieldName = "TransDate"
        Me.colTransDate.Name = "colTransDate"
        Me.colTransDate.Visible = True
        Me.colTransDate.VisibleIndex = 0
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup8.GroupBordersVisible = False
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12})
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(974, 522)
        Me.LayoutControlGroup8.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.GridControl4
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(954, 502)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.BtnShowReport3)
        Me.LayoutControl3.Controls.Add(Me.txtDateEos)
        Me.LayoutControl3.Controls.Add(Me.txtDateApo)
        Me.LayoutControl3.Location = New System.Drawing.Point(24, 46)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup6
        Me.LayoutControl3.Size = New System.Drawing.Size(974, 46)
        Me.LayoutControl3.TabIndex = 11
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'BtnShowReport3
        '
        Me.BtnShowReport3.Location = New System.Drawing.Point(539, 12)
        Me.BtnShowReport3.Name = "BtnShowReport3"
        Me.BtnShowReport3.Size = New System.Drawing.Size(196, 22)
        Me.BtnShowReport3.StyleController = Me.LayoutControl3
        Me.BtnShowReport3.TabIndex = 7
        Me.BtnShowReport3.Text = "Προβολή"
        '
        'txtDateEos
        '
        Me.txtDateEos.EditValue = Nothing
        Me.txtDateEos.Location = New System.Drawing.Point(365, 12)
        Me.txtDateEos.MenuManager = Me.RibbonControl1
        Me.txtDateEos.Name = "txtDateEos"
        Me.txtDateEos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateEos.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateEos.Size = New System.Drawing.Size(170, 20)
        Me.txtDateEos.StyleController = Me.LayoutControl3
        Me.txtDateEos.TabIndex = 6
        '
        'txtDateApo
        '
        Me.txtDateApo.EditValue = Nothing
        Me.txtDateApo.Location = New System.Drawing.Point(96, 12)
        Me.txtDateApo.MenuManager = Me.RibbonControl1
        Me.txtDateApo.Name = "txtDateApo"
        Me.txtDateApo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateApo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateApo.Size = New System.Drawing.Size(181, 20)
        Me.txtDateApo.StyleController = Me.LayoutControl3
        Me.txtDateApo.TabIndex = 5
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup6.GroupBordersVisible = False
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.EmptySpaceItem2})
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(974, 46)
        Me.LayoutControlGroup6.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtDateApo
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(269, 26)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(269, 26)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(269, 26)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.Text = "Απο Ημερομηνία"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtDateEos
        Me.LayoutControlItem14.Location = New System.Drawing.Point(269, 0)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(258, 26)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(258, 26)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(258, 26)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "Έως Ημερομηνία"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(80, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.BtnShowReport3
        Me.LayoutControlItem15.Location = New System.Drawing.Point(527, 0)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(727, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(227, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GridControl2)
        Me.LayoutControl2.Location = New System.Drawing.Point(24, 46)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(974, 522)
        Me.LayoutControl2.TabIndex = 10
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(12, 28)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemButtonEdit2, Me.RepositoryItemButtonEdit3})
        Me.GridControl2.ShowOnlyPredefinedDetails = True
        Me.GridControl2.Size = New System.Drawing.Size(950, 482)
        Me.GridControl2.TabIndex = 4
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn37, Me.GridColumn39, Me.GridColumn45, Me.GridColumn47, Me.GridColumn48})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderValue", Me.GridColumn30, "(ΑΞΙΑ: SUM={0:0.##})")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "OrderId"
        Me.GridColumn15.FieldName = "Oid"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.ReadOnly = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        '
        'GridColumn16
        '
        Me.GridColumn16.FieldName = "Station!"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        '
        'GridColumn17
        '
        Me.GridColumn17.FieldName = "Station!Key"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "ΧΡΗΣΤΗΣ"
        Me.GridColumn18.FieldName = "User.UserName"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 6
        '
        'GridColumn19
        '
        Me.GridColumn19.FieldName = "User!Key"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        '
        'GridColumn20
        '
        Me.GridColumn20.FieldName = "Trnums!"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        '
        'GridColumn21
        '
        Me.GridColumn21.FieldName = "Trnums!Key"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "ΠΑΡΑΣΤΑΤΙΚΟ"
        Me.GridColumn22.FieldName = "DocNum"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 4
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "ΚΑΤΑΣΤΑΣΗ"
        Me.GridColumn23.FieldName = "Status"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 7
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "ΠΛΗΡΩΜΗ"
        Me.GridColumn24.FieldName = "OrderPayType"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 8
        '
        'GridColumn25
        '
        Me.GridColumn25.FieldName = "RoomTrans!"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        '
        'GridColumn26
        '
        Me.GridColumn26.FieldName = "RoomTrans!Key"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        '
        'GridColumn27
        '
        Me.GridColumn27.FieldName = "Customer!"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.AllowEdit = False
        '
        'GridColumn28
        '
        Me.GridColumn28.FieldName = "Customer!Key"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.OptionsColumn.AllowEdit = False
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "ΤΡΑΠΕΖΙ"
        Me.GridColumn29.FieldName = "Trapezi"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.OptionsColumn.AllowEdit = False
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 5
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "ΑΞΙΑ"
        Me.GridColumn30.FieldName = "OrderValue"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsColumn.AllowEdit = False
        Me.GridColumn30.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderValue", "ΣΥΝΟΛΟ={0:0.##}")})
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 9
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Ημερ/νία"
        Me.GridColumn31.FieldName = "OrderDate"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.AllowEdit = False
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 1
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Εκτύπωση Λογαριασμού"
        Me.GridColumn32.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.GridColumn32.Name = "GridColumn32"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Εκτύπωση Ταμειακή"
        Me.GridColumn33.ColumnEdit = Me.RepositoryItemButtonEdit2
        Me.GridColumn33.Name = "GridColumn33"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        Me.RepositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "Προβολή"
        Me.GridColumn34.ColumnEdit = Me.RepositoryItemButtonEdit3
        Me.GridColumn34.Name = "GridColumn34"
        '
        'RepositoryItemButtonEdit3
        '
        Me.RepositoryItemButtonEdit3.AutoHeight = False
        Me.RepositoryItemButtonEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit3.Name = "RepositoryItemButtonEdit3"
        Me.RepositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Εκπτ/ση %"
        Me.GridColumn37.FieldName = "OrderDisc"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 10
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "'Εκπτωση"
        Me.GridColumn39.FieldName = "OrderDiscVal"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderDiscVal", "{0:0.##}")})
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 11
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "Τελική Αξία"
        Me.GridColumn45.FieldName = "OrderTotal"
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderTotal", "{0:0.##}")})
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 12
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "StartTime"
        Me.GridColumn47.DisplayFormat.FormatString = "t"
        Me.GridColumn47.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn47.FieldName = "OrderCreateTime"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.OptionsColumn.ReadOnly = True
        Me.GridColumn47.Visible = True
        Me.GridColumn47.VisibleIndex = 2
        '
        'GridColumn48
        '
        Me.GridColumn48.Caption = "EndTime"
        Me.GridColumn48.DisplayFormat.FormatString = "t"
        Me.GridColumn48.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn48.FieldName = "OrderCloseTime"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.OptionsColumn.ReadOnly = True
        Me.GridColumn48.Visible = True
        Me.GridColumn48.VisibleIndex = 3
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(974, 522)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.GridControl2
        Me.LayoutControlItem8.CustomizationFormText = "."
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(954, 502)
        Me.LayoutControlItem8.Text = "."
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(4, 13)
        '
        'ChartControl4
        '
        Me.ChartControl4.AppearanceNameSerializable = "Dark Flat"
        Me.ChartControl4.DataSource = Me.OrdersLineCollection
        XyDiagram1.AxisX.QualitativeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum
        XyDiagram1.AxisX.Tickmarks.MinorVisible = False
        XyDiagram1.AxisX.Tickmarks.Visible = False
        XyDiagram1.AxisX.Title.Text = "Yποκατηγορίες"
        XyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl4.Diagram = XyDiagram1
        Me.ChartControl4.Legend.Name = "Default Legend"
        Me.ChartControl4.Location = New System.Drawing.Point(24, 443)
        Me.ChartControl4.Name = "ChartControl4"
        Me.ChartControl4.PaletteBaseColorNumber = 5
        Series1.ArgumentDataMember = "Product.NrgYpoomada.tsDescr2"
        Series1.Name = "Σύνολα ανα υποκ/ρία"
        Series1.ValueDataMembersSerializable = "Total"
        Me.ChartControl4.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl4.Size = New System.Drawing.Size(974, 125)
        Me.ChartControl4.TabIndex = 9
        '
        'ChartControl3
        '
        Me.ChartControl3.AppearanceNameSerializable = "Dark Flat"
        Me.ChartControl3.DataSource = Me.OrdersLineCollection
        XyDiagram2.AxisX.QualitativeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum
        XyDiagram2.AxisX.Tickmarks.MinorVisible = False
        XyDiagram2.AxisX.Tickmarks.Visible = False
        XyDiagram2.AxisX.Title.Text = "Κατηγορίες"
        XyDiagram2.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisX.VisualRange.Auto = False
        XyDiagram2.AxisX.VisualRange.MaxValueSerializable = "J"
        XyDiagram2.AxisX.VisualRange.MinValueSerializable = "A"
        XyDiagram2.AxisY.Interlaced = True
        XyDiagram2.AxisY.Tickmarks.MinorVisible = False
        XyDiagram2.AxisY.Tickmarks.Visible = False
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl3.Diagram = XyDiagram2
        Me.ChartControl3.Legend.Name = "Default Legend"
        Me.ChartControl3.Location = New System.Drawing.Point(24, 313)
        Me.ChartControl3.Name = "ChartControl3"
        Me.ChartControl3.PaletteBaseColorNumber = 4
        Series2.ArgumentDataMember = "Product.NrgOmada.tsDescr1"
        Series2.Name = "Σύνολα ανα κατηγορία"
        Series2.ValueDataMembersSerializable = "Total"
        Me.ChartControl3.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        Me.ChartControl3.Size = New System.Drawing.Size(974, 126)
        Me.ChartControl3.TabIndex = 7
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.OrdersLineCollection
        Me.GridControl1.Location = New System.Drawing.Point(24, 46)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(974, 522)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.colOid, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colComments, Me.colQuant, Me.colPrice, Me.colDisc, Me.colDiscVal, Me.colProductVal, Me.colCommentsVal, Me.colTotal, Me.colToPrinter, Me.colToReceipt, Me.colToCashMachine, Me.GridColumn5, Me.GridColumn6, Me.colPrinter, Me.colClonePrinter, Me.colAppComments, Me.colPosition, Me.colMeriko, Me.colNetPrice, Me.colNetValue, Me.colVatValue, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn49})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quant", Me.colQuant, "({0:0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", Me.colTotal, "({0:0.##})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Ημερ/νία"
        Me.GridColumn11.FieldName = "PosOrder.OrderDate"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 2
        Me.GridColumn11.Width = 53
        '
        'colOid
        '
        Me.colOid.Caption = "LineId"
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        Me.colOid.OptionsColumn.ReadOnly = True
        Me.colOid.Visible = True
        Me.colOid.VisibleIndex = 0
        Me.colOid.Width = 42
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "PosOrder!"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "OrderId"
        Me.GridColumn2.FieldName = "PosOrder!Key"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 50
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "Product!"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Είδος"
        Me.GridColumn4.FieldName = "Product.sName"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 116
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 10
        Me.colComments.Width = 20
        '
        'colQuant
        '
        Me.colQuant.Caption = "Ποσότητα"
        Me.colQuant.DisplayFormat.FormatString = "{0:0.##}"
        Me.colQuant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuant.FieldName = "Quant"
        Me.colQuant.Name = "colQuant"
        Me.colQuant.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quant", "SUM={0:0.##}")})
        Me.colQuant.Visible = True
        Me.colQuant.VisibleIndex = 6
        Me.colQuant.Width = 60
        '
        'colPrice
        '
        Me.colPrice.Caption = "Τιμή"
        Me.colPrice.DisplayFormat.FormatString = "{0:0.##}"
        Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 7
        Me.colPrice.Width = 34
        '
        'colDisc
        '
        Me.colDisc.FieldName = "Disc"
        Me.colDisc.Name = "colDisc"
        '
        'colDiscVal
        '
        Me.colDiscVal.FieldName = "DiscVal"
        Me.colDiscVal.Name = "colDiscVal"
        '
        'colProductVal
        '
        Me.colProductVal.FieldName = "ProductVal"
        Me.colProductVal.Name = "colProductVal"
        '
        'colCommentsVal
        '
        Me.colCommentsVal.FieldName = "CommentsVal"
        Me.colCommentsVal.Name = "colCommentsVal"
        '
        'colTotal
        '
        Me.colTotal.Caption = "Αξία"
        Me.colTotal.DisplayFormat.FormatString = "{0:0.##}"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "SUM={0:0.##}")})
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 9
        Me.colTotal.Width = 44
        '
        'colToPrinter
        '
        Me.colToPrinter.FieldName = "ToPrinter"
        Me.colToPrinter.Name = "colToPrinter"
        '
        'colToReceipt
        '
        Me.colToReceipt.Caption = "ΛΟΓΑΡΙΑΣΜΟΣ"
        Me.colToReceipt.FieldName = "ToReceipt"
        Me.colToReceipt.Name = "colToReceipt"
        Me.colToReceipt.Visible = True
        Me.colToReceipt.VisibleIndex = 18
        Me.colToReceipt.Width = 94
        '
        'colToCashMachine
        '
        Me.colToCashMachine.Caption = "ΤΑΜΕΙΑΚΗ"
        Me.colToCashMachine.FieldName = "ToCashMachine"
        Me.colToCashMachine.Name = "colToCashMachine"
        Me.colToCashMachine.Visible = True
        Me.colToCashMachine.VisibleIndex = 17
        Me.colToCashMachine.Width = 73
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "User!"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Χρήστης"
        Me.GridColumn6.FieldName = "User.UserName"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 11
        Me.GridColumn6.Width = 49
        '
        'colPrinter
        '
        Me.colPrinter.FieldName = "Printer"
        Me.colPrinter.Name = "colPrinter"
        '
        'colClonePrinter
        '
        Me.colClonePrinter.FieldName = "ClonePrinter"
        Me.colClonePrinter.Name = "colClonePrinter"
        '
        'colAppComments
        '
        Me.colAppComments.FieldName = "AppComments"
        Me.colAppComments.Name = "colAppComments"
        '
        'colPosition
        '
        Me.colPosition.FieldName = "Position"
        Me.colPosition.Name = "colPosition"
        '
        'colMeriko
        '
        Me.colMeriko.FieldName = "Meriko"
        Me.colMeriko.Name = "colMeriko"
        '
        'colNetPrice
        '
        Me.colNetPrice.FieldName = "NetPrice"
        Me.colNetPrice.Name = "colNetPrice"
        '
        'colNetValue
        '
        Me.colNetValue.FieldName = "NetValue"
        Me.colNetValue.Name = "colNetValue"
        '
        'colVatValue
        '
        Me.colVatValue.FieldName = "VatValue"
        Me.colVatValue.Name = "colVatValue"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Ομάδα"
        Me.GridColumn7.FieldName = "Product.NrgOmada.tsDescr1"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 53
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Υποομάδα"
        Me.GridColumn8.FieldName = "Product.NrgYpoomada.tsDescr2"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 53
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Δωμάτιο"
        Me.GridColumn9.FieldName = "PosOrder.RoomTrans.Room.RoomDescr"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 12
        Me.GridColumn9.Width = 46
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Τρόπος Πληρωμής"
        Me.GridColumn10.FieldName = "PosOrder.OrderPayType"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 13
        Me.GridColumn10.Width = 74
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Κατάσταση"
        Me.GridColumn12.FieldName = "PosOrder.Status"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 14
        Me.GridColumn12.Width = 52
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Αρ.Παραγγελίας"
        Me.GridColumn13.FieldName = "PosOrder.DocNum"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 15
        Me.GridColumn13.Width = 20
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Id Κράτησης"
        Me.GridColumn14.FieldName = "PosOrder.RoomTrans.Oid"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 16
        Me.GridColumn14.Width = 20
        '
        'ChartControl2
        '
        Me.ChartControl2.AppearanceNameSerializable = "Dark"
        Me.ChartControl2.DataSource = Me.OrdersCollection
        XyDiagram3.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero
        XyDiagram3.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum
        XyDiagram3.AxisX.Interlaced = True
        XyDiagram3.AxisX.MinorCount = 1
        XyDiagram3.AxisX.Tickmarks.MinorVisible = False
        XyDiagram3.AxisX.Tickmarks.Visible = False
        XyDiagram3.AxisX.Title.Text = "Ημέρες"
        XyDiagram3.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.Interlaced = True
        XyDiagram3.AxisY.Tickmarks.MinorVisible = False
        XyDiagram3.AxisY.Tickmarks.Visible = False
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl2.Diagram = XyDiagram3
        Me.ChartControl2.Legend.Name = "Default Legend"
        Me.ChartControl2.Location = New System.Drawing.Point(24, 180)
        Me.ChartControl2.Name = "ChartControl2"
        Me.ChartControl2.PaletteBaseColorNumber = 2
        Series3.ArgumentDataMember = "OrderDate"
        Series3.Name = "Σύνολα ανα ημέρα"
        Series3.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Series3.ValueDataMembersSerializable = "OrderValue"
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        Me.ChartControl2.Size = New System.Drawing.Size(974, 129)
        Me.ChartControl2.TabIndex = 5
        '
        'ChartControl1
        '
        Me.ChartControl1.AppearanceNameSerializable = "Dark"
        Me.ChartControl1.DataSource = Me.OrdersCollection
        XyDiagram4.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum
        XyDiagram4.AxisX.DateTimeScaleOptions.AutoGrid = False
        XyDiagram4.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
        XyDiagram4.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
        XyDiagram4.AxisX.GridLines.Visible = True
        XyDiagram4.AxisX.Interlaced = True
        XyDiagram4.AxisX.Label.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(161, Byte))})
        XyDiagram4.AxisX.Label.TextAlignment = System.Drawing.StringAlignment.Near
        XyDiagram4.AxisX.MinorCount = 1
        XyDiagram4.AxisX.Tickmarks.MinorVisible = False
        XyDiagram4.AxisX.Tickmarks.Visible = False
        XyDiagram4.AxisX.Title.Alignment = System.Drawing.StringAlignment.Near
        XyDiagram4.AxisX.Title.Text = "Μήνες"
        XyDiagram4.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram4.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram4.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram4
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(29, 46)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.PaletteBaseColorNumber = 1
        Me.ChartControl1.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.[Single]
        Me.ChartControl1.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
        Series4.ArgumentDataMember = "OrderDate"
        Series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series4.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
        Series4.DateTimeSummaryOptions.MeasureUnitMultiplier = 1
        Series4.Name = "Σύνολα Ανα Μήνα"
        Series4.ValueDataMembersSerializable = "OrderValue"
        Series4.View = LineSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
        Me.ChartControl1.SeriesTemplate.View = LineSeriesView2
        Me.ChartControl1.Size = New System.Drawing.Size(969, 130)
        Me.ChartControl1.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1022, 592)
        Me.Root.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup1
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1002, 572)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup5, Me.LayoutControlGroup7})
        Me.TabbedControlGroup1.Text = "Παραγγελίες"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(978, 526)
        Me.LayoutControlGroup2.Text = "Αναλυτικά"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(978, 526)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(978, 526)
        Me.LayoutControlGroup1.Text = "Συγγεντρωτικά"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ChartControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(978, 134)
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ChartControl2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 134)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(978, 133)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ChartControl3
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 267)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(978, 130)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.ChartControl4
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 397)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(978, 129)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(978, 526)
        Me.LayoutControlGroup3.Text = "Παραγγελίες"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.LayoutControl2
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(978, 526)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem16})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(978, 526)
        Me.LayoutControlGroup5.Text = "Σύνολα ανα είδος"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.LayoutControl3
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(978, 50)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.GridControl5
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(978, 476)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(978, 526)
        Me.LayoutControlGroup7.Text = "Διαγραφές"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.LayoutControl4
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(978, 526)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "RealProductPrice"
        Me.GridColumn49.FieldName = "Product.sRetailPr"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 8
        '
        'WaiterReport1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 767)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "WaiterReport1"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "WaiterReport1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.OrdersLineCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.txtDateEos.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateEos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateApo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateApo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCMyview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents OrdersCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscVal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductVal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommentsVal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToPrinter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToReceipt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToCashMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrinter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClonePrinter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAppComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPosition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeriko As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVatValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChartControl3 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrdersLineCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChartControl4 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XpCMyview As DevExpress.Xpo.XPCollection
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XpDelete As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuant1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscval1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductVal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommentsVal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BtnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtDateEos As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateApo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnShowReport3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
End Class
