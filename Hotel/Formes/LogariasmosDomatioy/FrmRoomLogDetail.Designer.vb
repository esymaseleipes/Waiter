<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRoomLogDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoomLogDetail))
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TxtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BtnPrintRoomLog = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnPrintRoomLogDetail = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCloseRoom = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.CmbPayType = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTrnums = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderPayType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTrapezi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderCreateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderCloseTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinalization = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLanguage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersons = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryMan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToCloud = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfInvoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDiscVal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGetNetValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGetVatValue = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbPayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XpCollection1
        '
        Me.XpCollection1.LoadingEnabled = False
        Me.XpCollection1.ObjectType = GetType(WaiterModel.Cmp300.PosOrder)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.TxtTotal)
        Me.LayoutControl1.Controls.Add(Me.CmbPayType)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 148)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1164, 420)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(637, 376)
        Me.TxtTotal.MenuManager = Me.RibbonControl1
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Properties.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(503, 20)
        Me.TxtTotal.StyleController = Me.LayoutControl1
        Me.TxtTotal.TabIndex = 6
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BtnPrintRoomLog, Me.BtnPrintRoomLogDetail, Me.BtnCloseRoom})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 4
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1164, 148)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BtnPrintRoomLog
        '
        Me.BtnPrintRoomLog.Caption = "Εκτύπωση Συνοπτικά"
        Me.BtnPrintRoomLog.Id = 1
        Me.BtnPrintRoomLog.ImageOptions.ImageUri.Uri = "Print"
        Me.BtnPrintRoomLog.Name = "BtnPrintRoomLog"
        '
        'BtnPrintRoomLogDetail
        '
        Me.BtnPrintRoomLogDetail.Caption = "Εκτύπωση Αναλυτικά"
        Me.BtnPrintRoomLogDetail.Id = 2
        Me.BtnPrintRoomLogDetail.ImageOptions.ImageUri.Uri = "Print"
        Me.BtnPrintRoomLogDetail.Name = "BtnPrintRoomLogDetail"
        '
        'BtnCloseRoom
        '
        Me.BtnCloseRoom.Caption = "Εξόφληση Δωματίου"
        Me.BtnCloseRoom.Id = 3
        Me.BtnCloseRoom.ImageOptions.Image = CType(resources.GetObject("BtnCloseRoom.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnCloseRoom.ImageOptions.LargeImage = CType(resources.GetObject("BtnCloseRoom.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnCloseRoom.Name = "BtnCloseRoom"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnPrintRoomLog)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnPrintRoomLogDetail)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnCloseRoom)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 568)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1164, 27)
        '
        'CmbPayType
        '
        Me.CmbPayType.Location = New System.Drawing.Point(78, 376)
        Me.CmbPayType.MenuManager = Me.RibbonControl1
        Me.CmbPayType.Name = "CmbPayType"
        Me.CmbPayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbPayType.Properties.NullText = "[EditValue is null]"
        Me.CmbPayType.Properties.PopupSizeable = True
        Me.CmbPayType.Size = New System.Drawing.Size(501, 20)
        Me.CmbPayType.StyleController = Me.LayoutControl1
        Me.CmbPayType.TabIndex = 5
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1164, 420)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 332)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1144, 68)
        Me.LayoutControlGroup1.Text = "ΤΡΟΠΟΣ ΠΛΗΡΩΜΗΣ"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CmbPayType
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(559, 24)
        Me.LayoutControlItem2.Text = "ΠΛΗΡΩΜΗ"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtTotal
        Me.LayoutControlItem3.Location = New System.Drawing.Point(559, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(561, 24)
        Me.LayoutControlItem3.Text = "ΠΟΣΟ"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(50, 13)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(1140, 328)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colTrnums, Me.colDocNum, Me.colStatus, Me.colOrderPayType, Me.colTrapezi, Me.colOrderValue, Me.colOrderDate, Me.colOrderCreateTime, Me.colOrderCloseTime, Me.colFinalization, Me.GridColumn5, Me.GridColumn6, Me.colLanguage, Me.colPersons, Me.colNewCustomer, Me.colAddress, Me.colDeliveryMan, Me.colToCloud, Me.colfInvoice, Me.colOrderDisc, Me.colOrderDiscVal, Me.colOrderTotal, Me.colGetNetValue, Me.colGetVatValue})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1144, 332)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Station!"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Station!Key"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "User!"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "User!Key"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'colTrnums
        '
        Me.colTrnums.FieldName = "Trnums"
        Me.colTrnums.Name = "colTrnums"
        '
        'colDocNum
        '
        Me.colDocNum.FieldName = "DocNum"
        Me.colDocNum.Name = "colDocNum"
        Me.colDocNum.Visible = True
        Me.colDocNum.VisibleIndex = 3
        Me.colDocNum.Width = 74
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 184
        '
        'colOrderPayType
        '
        Me.colOrderPayType.FieldName = "OrderPayType"
        Me.colOrderPayType.Name = "colOrderPayType"
        Me.colOrderPayType.Width = 107
        '
        'colTrapezi
        '
        Me.colTrapezi.FieldName = "Trapezi"
        Me.colTrapezi.Name = "colTrapezi"
        Me.colTrapezi.Visible = True
        Me.colTrapezi.VisibleIndex = 4
        Me.colTrapezi.Width = 83
        '
        'colOrderValue
        '
        Me.colOrderValue.FieldName = "OrderValue"
        Me.colOrderValue.Name = "colOrderValue"
        Me.colOrderValue.Visible = True
        Me.colOrderValue.VisibleIndex = 5
        Me.colOrderValue.Width = 78
        '
        'colOrderDate
        '
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.Visible = True
        Me.colOrderDate.VisibleIndex = 0
        Me.colOrderDate.Width = 83
        '
        'colOrderCreateTime
        '
        Me.colOrderCreateTime.FieldName = "OrderCreateTime"
        Me.colOrderCreateTime.Name = "colOrderCreateTime"
        Me.colOrderCreateTime.Visible = True
        Me.colOrderCreateTime.VisibleIndex = 1
        Me.colOrderCreateTime.Width = 117
        '
        'colOrderCloseTime
        '
        Me.colOrderCloseTime.FieldName = "OrderCloseTime"
        Me.colOrderCloseTime.Name = "colOrderCloseTime"
        Me.colOrderCloseTime.Visible = True
        Me.colOrderCloseTime.VisibleIndex = 2
        Me.colOrderCloseTime.Width = 120
        '
        'colFinalization
        '
        Me.colFinalization.FieldName = "Finalization"
        Me.colFinalization.Name = "colFinalization"
        Me.colFinalization.Width = 62
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "RoomTrans!"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 96
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "RoomTrans!Key"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Width = 70
        '
        'colLanguage
        '
        Me.colLanguage.FieldName = "Language"
        Me.colLanguage.Name = "colLanguage"
        Me.colLanguage.Width = 60
        '
        'colPersons
        '
        Me.colPersons.FieldName = "Persons"
        Me.colPersons.Name = "colPersons"
        Me.colPersons.Width = 81
        '
        'colNewCustomer
        '
        Me.colNewCustomer.FieldName = "NewCustomer"
        Me.colNewCustomer.Name = "colNewCustomer"
        Me.colNewCustomer.Width = 72
        '
        'colAddress
        '
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Width = 117
        '
        'colDeliveryMan
        '
        Me.colDeliveryMan.FieldName = "DeliveryMan"
        Me.colDeliveryMan.Name = "colDeliveryMan"
        Me.colDeliveryMan.Width = 98
        '
        'colToCloud
        '
        Me.colToCloud.FieldName = "ToCloud"
        Me.colToCloud.Name = "colToCloud"
        Me.colToCloud.Width = 67
        '
        'colfInvoice
        '
        Me.colfInvoice.FieldName = "fInvoice"
        Me.colfInvoice.Name = "colfInvoice"
        Me.colfInvoice.Width = 67
        '
        'colOrderDisc
        '
        Me.colOrderDisc.FieldName = "OrderDisc"
        Me.colOrderDisc.Name = "colOrderDisc"
        Me.colOrderDisc.Visible = True
        Me.colOrderDisc.VisibleIndex = 6
        Me.colOrderDisc.Width = 59
        '
        'colOrderDiscVal
        '
        Me.colOrderDiscVal.FieldName = "OrderDiscVal"
        Me.colOrderDiscVal.Name = "colOrderDiscVal"
        Me.colOrderDiscVal.Visible = True
        Me.colOrderDiscVal.VisibleIndex = 7
        Me.colOrderDiscVal.Width = 90
        '
        'colOrderTotal
        '
        Me.colOrderTotal.FieldName = "OrderTotal"
        Me.colOrderTotal.Name = "colOrderTotal"
        Me.colOrderTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderTotal", "SUM={0:0.##}")})
        Me.colOrderTotal.Visible = True
        Me.colOrderTotal.VisibleIndex = 8
        Me.colOrderTotal.Width = 90
        '
        'colGetNetValue
        '
        Me.colGetNetValue.FieldName = "GetNetValue"
        Me.colGetNetValue.Name = "colGetNetValue"
        Me.colGetNetValue.Width = 90
        '
        'colGetVatValue
        '
        Me.colGetVatValue.FieldName = "GetVatValue"
        Me.colGetVatValue.Name = "colGetVatValue"
        Me.colGetVatValue.Width = 235
        '
        'FrmRoomLogDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 595)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmRoomLogDetail"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Ανάλυση λογαριασμού δωματίου"
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbPayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BtnPrintRoomLog As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnPrintRoomLogDetail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCloseRoom As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CmbPayType As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTrnums As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderPayType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTrapezi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderCreateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderCloseTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinalization As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLanguage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersons As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryMan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToCloud As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfInvoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDiscVal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGetNetValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGetVatValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
