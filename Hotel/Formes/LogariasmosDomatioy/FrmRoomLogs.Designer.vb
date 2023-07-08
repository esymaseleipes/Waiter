<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoomLogs
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoomLogs))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGetRoomRemain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArrivalDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colService = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnEditRoomTransState = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BtnRoomLogDetail = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCloseOpenOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCloseOpenOrderσ = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnService = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.WindowsApplication1.WaitForm1), True, True)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEditRoomTransState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 148)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(912, 420)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BtnEditRoomTransState})
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(888, 396)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.GridColumn2, Me.GridColumn7, Me.colGetRoomRemain, Me.colArrivalDate, Me.colDueDate, Me.colTransType, Me.GridColumn1, Me.colService})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindFilterColumns = "Room.RoomDescr"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.Caption = "Id Κράτησης"
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        Me.colOid.Visible = True
        Me.colOid.VisibleIndex = 0
        Me.colOid.Width = 86
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Δωμάτιο"
        Me.GridColumn2.FieldName = "Room.RoomDescr"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 158
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Τύπος Δωματίου"
        Me.GridColumn7.FieldName = "RoomType.Descr"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 96
        '
        'colGetRoomRemain
        '
        Me.colGetRoomRemain.Caption = "Υπόλοιπο"
        Me.colGetRoomRemain.FieldName = "Room.GetRoomClosedTotal"
        Me.colGetRoomRemain.Name = "colGetRoomRemain"
        Me.colGetRoomRemain.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Room.GetRoomClosedTotal", "SUM={0:0.##}")})
        Me.colGetRoomRemain.Visible = True
        Me.colGetRoomRemain.VisibleIndex = 5
        Me.colGetRoomRemain.Width = 154
        '
        'colArrivalDate
        '
        Me.colArrivalDate.FieldName = "ArrivalDate"
        Me.colArrivalDate.Name = "colArrivalDate"
        Me.colArrivalDate.Visible = True
        Me.colArrivalDate.VisibleIndex = 3
        Me.colArrivalDate.Width = 147
        '
        'colDueDate
        '
        Me.colDueDate.FieldName = "DueDate"
        Me.colDueDate.Name = "colDueDate"
        Me.colDueDate.Visible = True
        Me.colDueDate.VisibleIndex = 4
        Me.colDueDate.Width = 147
        '
        'colTransType
        '
        Me.colTransType.FieldName = "TransType"
        Me.colTransType.Name = "colTransType"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Εκρεμείς Παραγγελίες"
        Me.GridColumn1.FieldName = "Room.GetRoomOpenTotal"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Room.GetRoomOpenTotal", "SUM={0:0.##}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 79
        '
        'colService
        '
        Me.colService.Caption = "Service"
        Me.colService.ColumnEdit = Me.BtnEditRoomTransState
        Me.colService.Name = "colService"
        '
        'BtnEditRoomTransState
        '
        Me.BtnEditRoomTransState.AutoHeight = False
        Me.BtnEditRoomTransState.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.BtnEditRoomTransState.Name = "BtnEditRoomTransState"
        Me.BtnEditRoomTransState.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(912, 420)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(892, 400)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BtnRoomLogDetail, Me.BtnRefresh, Me.BtnCloseOpenOrder, Me.BtnCloseOpenOrderσ, Me.BtnService})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(912, 148)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BtnRoomLogDetail
        '
        Me.BtnRoomLogDetail.Caption = "Λογαριασμός Δωματίου"
        Me.BtnRoomLogDetail.Id = 1
        Me.BtnRoomLogDetail.ImageOptions.ImageUri.Uri = "ListNumbers"
        Me.BtnRoomLogDetail.Name = "BtnRoomLogDetail"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Caption = "Refresh"
        Me.BtnRefresh.Id = 2
        Me.BtnRefresh.ImageOptions.SvgImage = CType(resources.GetObject("BtnRefresh.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnRefresh.Name = "BtnRefresh"
        '
        'BtnCloseOpenOrder
        '
        Me.BtnCloseOpenOrder.Caption = "Κλείσε Τις ανοικτές Παραγγελίες Δωματίου"
        Me.BtnCloseOpenOrder.Id = 3
        Me.BtnCloseOpenOrder.ImageOptions.ImageUri.Uri = "ShowHidden"
        Me.BtnCloseOpenOrder.ImageOptions.SvgImage = CType(resources.GetObject("BtnCloseOpenOrder.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnCloseOpenOrder.Name = "BtnCloseOpenOrder"
        '
        'BtnCloseOpenOrderσ
        '
        Me.BtnCloseOpenOrderσ.Caption = "Κλείσε όλες τις ανοικτές Παραγγελίες Δωματίων"
        Me.BtnCloseOpenOrderσ.Id = 4
        Me.BtnCloseOpenOrderσ.ImageOptions.SvgImage = CType(resources.GetObject("BtnCloseOpenOrderσ.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnCloseOpenOrderσ.Name = "BtnCloseOpenOrderσ"
        '
        'BtnService
        '
        Me.BtnService.Caption = "Service"
        Me.BtnService.Id = 5
        Me.BtnService.Name = "BtnService"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnRoomLogDetail)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnRefresh)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnCloseOpenOrder)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnCloseOpenOrderσ)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 568)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(912, 27)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'FrmRoomLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 595)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmRoomLogs"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Υπόλοιπα Παραγγελιοδωσίας ανά δωμάτιο"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEditRoomTransState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGetRoomRemain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArrivalDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BtnRoomLogDetail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCloseOpenOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCloseOpenOrderσ As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents BtnService As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colService As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnEditRoomTransState As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
