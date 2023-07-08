Imports WaiterModel.Cmp300

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPosConfig
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtLogo1 = New DevExpress.XtraEditors.TextEdit()
        Me.CmbCashMachine = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.CmbPosPrintLanguage = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.txtTamIp = New DevExpress.XtraEditors.TextEdit()
        Me.ChkShowOrderNumOnReceipt = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkShowDetailOnPrintServer = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckAutoOrderKerasma = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkErp = New DevExpress.XtraEditors.CheckEdit()
        Me.BtnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.CmbProductOmada = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.BtnPosCnfgExit = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnPosCnfgsave = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CmbProductSubCategory = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrinter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CmbMainPrinter = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colClonePrinter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CmbClonePrinter = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CmbCloneReciptPrinter = New DevExpress.XtraEditors.LookUpEdit()
        Me.CmbReciptPrinter = New DevExpress.XtraEditors.LookUpEdit()
        Me.CmbReciptBehavior = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.CmpProductCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkRoom = New DevExpress.XtraEditors.CheckEdit()
        Me.CmbCashMachineBehavior = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.CmbCommentPrintType = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.txtPosNullLines = New DevExpress.XtraEditors.SpinEdit()
        Me.txtLogo2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtLogo3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtLogo4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtLogo5 = New DevExpress.XtraEditors.TextEdit()
        Me.BtnFiscalPath = New DevExpress.XtraEditors.ButtonEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LuePosPrintLang = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.PrinterControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ProductSubCategoryCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtLogo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbCashMachine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbPosPrintLanguage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTamIp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowOrderNumOnReceipt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowDetailOnPrintServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckAutoOrderKerasma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkErp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbProductOmada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbProductSubCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMainPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbClonePrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbCloneReciptPrinter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbReciptPrinter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbReciptBehavior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmpProductCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbCashMachineBehavior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbCommentPrintType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPosNullLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogo3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogo4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogo5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFiscalPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LuePosPrintLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinterControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductSubCategoryCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtLogo1)
        Me.LayoutControl1.Controls.Add(Me.CmbCashMachine)
        Me.LayoutControl1.Controls.Add(Me.CmbPosPrintLanguage)
        Me.LayoutControl1.Controls.Add(Me.txtTamIp)
        Me.LayoutControl1.Controls.Add(Me.ChkShowOrderNumOnReceipt)
        Me.LayoutControl1.Controls.Add(Me.ChkShowDetailOnPrintServer)
        Me.LayoutControl1.Controls.Add(Me.CheckAutoOrderKerasma)
        Me.LayoutControl1.Controls.Add(Me.ChkErp)
        Me.LayoutControl1.Controls.Add(Me.BtnExit)
        Me.LayoutControl1.Controls.Add(Me.BtnSave)
        Me.LayoutControl1.Controls.Add(Me.CmbProductOmada)
        Me.LayoutControl1.Controls.Add(Me.LayoutControl2)
        Me.LayoutControl1.Controls.Add(Me.CmbCloneReciptPrinter)
        Me.LayoutControl1.Controls.Add(Me.CmbReciptPrinter)
        Me.LayoutControl1.Controls.Add(Me.CmbReciptBehavior)
        Me.LayoutControl1.Controls.Add(Me.CmpProductCategory)
        Me.LayoutControl1.Controls.Add(Me.chkRoom)
        Me.LayoutControl1.Controls.Add(Me.CmbCashMachineBehavior)
        Me.LayoutControl1.Controls.Add(Me.CmbCommentPrintType)
        Me.LayoutControl1.Controls.Add(Me.txtPosNullLines)
        Me.LayoutControl1.Controls.Add(Me.txtLogo2)
        Me.LayoutControl1.Controls.Add(Me.txtLogo3)
        Me.LayoutControl1.Controls.Add(Me.txtLogo4)
        Me.LayoutControl1.Controls.Add(Me.txtLogo5)
        Me.LayoutControl1.Controls.Add(Me.BtnFiscalPath)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(685, 362, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1216, 737)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtLogo1
        '
        Me.txtLogo1.Location = New System.Drawing.Point(222, 478)
        Me.txtLogo1.Name = "txtLogo1"
        Me.txtLogo1.Size = New System.Drawing.Size(415, 20)
        Me.txtLogo1.StyleController = Me.LayoutControl1
        Me.txtLogo1.TabIndex = 28
        '
        'CmbCashMachine
        '
        Me.CmbCashMachine.Location = New System.Drawing.Point(222, 78)
        Me.CmbCashMachine.Name = "CmbCashMachine"
        Me.CmbCashMachine.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbCashMachine.Size = New System.Drawing.Size(958, 20)
        Me.CmbCashMachine.StyleController = Me.LayoutControl1
        Me.CmbCashMachine.TabIndex = 27
        '
        'CmbPosPrintLanguage
        '
        Me.CmbPosPrintLanguage.Location = New System.Drawing.Point(210, 422)
        Me.CmbPosPrintLanguage.Name = "CmbPosPrintLanguage"
        Me.CmbPosPrintLanguage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbPosPrintLanguage.Size = New System.Drawing.Size(408, 20)
        Me.CmbPosPrintLanguage.StyleController = Me.LayoutControl1
        Me.CmbPosPrintLanguage.TabIndex = 25
        '
        'txtTamIp
        '
        Me.txtTamIp.Location = New System.Drawing.Point(210, 398)
        Me.txtTamIp.Name = "txtTamIp"
        Me.txtTamIp.Size = New System.Drawing.Size(395, 20)
        Me.txtTamIp.StyleController = Me.LayoutControl1
        Me.txtTamIp.TabIndex = 24
        '
        'ChkShowOrderNumOnReceipt
        '
        Me.ChkShowOrderNumOnReceipt.Location = New System.Drawing.Point(24, 374)
        Me.ChkShowOrderNumOnReceipt.Name = "ChkShowOrderNumOnReceipt"
        Me.ChkShowOrderNumOnReceipt.Properties.Caption = "Προβολή Αρ.Παρραγελίας στην Απόδειξη"
        Me.ChkShowOrderNumOnReceipt.Size = New System.Drawing.Size(1168, 20)
        Me.ChkShowOrderNumOnReceipt.StyleController = Me.LayoutControl1
        Me.ChkShowOrderNumOnReceipt.TabIndex = 23
        '
        'ChkShowDetailOnPrintServer
        '
        Me.ChkShowDetailOnPrintServer.Location = New System.Drawing.Point(24, 350)
        Me.ChkShowDetailOnPrintServer.Name = "ChkShowDetailOnPrintServer"
        Me.ChkShowDetailOnPrintServer.Properties.Caption = "Προβολή Λεπτομέριες Στον PrinterServer"
        Me.ChkShowDetailOnPrintServer.Size = New System.Drawing.Size(1168, 20)
        Me.ChkShowDetailOnPrintServer.StyleController = Me.LayoutControl1
        Me.ChkShowDetailOnPrintServer.TabIndex = 22
        '
        'CheckAutoOrderKerasma
        '
        Me.CheckAutoOrderKerasma.Location = New System.Drawing.Point(24, 326)
        Me.CheckAutoOrderKerasma.Name = "CheckAutoOrderKerasma"
        Me.CheckAutoOrderKerasma.Properties.Caption = "Αυτόματη παραγγελία στο Κέρασμα"
        Me.CheckAutoOrderKerasma.Size = New System.Drawing.Size(1168, 20)
        Me.CheckAutoOrderKerasma.StyleController = Me.LayoutControl1
        Me.CheckAutoOrderKerasma.TabIndex = 21
        '
        'ChkErp
        '
        Me.ChkErp.Location = New System.Drawing.Point(24, 302)
        Me.ChkErp.Name = "ChkErp"
        Me.ChkErp.Properties.Caption = "Σύνδεση με Erp"
        Me.ChkErp.Size = New System.Drawing.Size(1168, 20)
        Me.ChkErp.StyleController = Me.LayoutControl1
        Me.ChkErp.TabIndex = 20
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(1066, 610)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(126, 31)
        Me.BtnExit.StyleController = Me.LayoutControl1
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "Έξοδος"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(922, 610)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(140, 31)
        Me.BtnSave.StyleController = Me.LayoutControl1
        Me.BtnSave.TabIndex = 17
        Me.BtnSave.Text = "Αποθήκευση"
        '
        'CmbProductOmada
        '
        Me.CmbProductOmada.Location = New System.Drawing.Point(65, 46)
        Me.CmbProductOmada.Name = "CmbProductOmada"
        Me.CmbProductOmada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbProductOmada.Size = New System.Drawing.Size(1127, 20)
        Me.CmbProductOmada.StyleController = Me.LayoutControl1
        Me.CmbProductOmada.TabIndex = 16
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.BtnPosCnfgExit)
        Me.LayoutControl2.Controls.Add(Me.BtnPosCnfgsave)
        Me.LayoutControl2.Controls.Add(Me.GridControl1)
        Me.LayoutControl2.Location = New System.Drawing.Point(24, 70)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.Root
        Me.LayoutControl2.Size = New System.Drawing.Size(1168, 643)
        Me.LayoutControl2.TabIndex = 15
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'BtnPosCnfgExit
        '
        Me.BtnPosCnfgExit.Location = New System.Drawing.Point(585, 609)
        Me.BtnPosCnfgExit.Name = "BtnPosCnfgExit"
        Me.BtnPosCnfgExit.Size = New System.Drawing.Size(571, 22)
        Me.BtnPosCnfgExit.StyleController = Me.LayoutControl2
        Me.BtnPosCnfgExit.TabIndex = 6
        Me.BtnPosCnfgExit.Text = "Έξοδος"
        '
        'BtnPosCnfgsave
        '
        Me.BtnPosCnfgsave.Location = New System.Drawing.Point(12, 609)
        Me.BtnPosCnfgsave.Name = "BtnPosCnfgsave"
        Me.BtnPosCnfgsave.Size = New System.Drawing.Size(569, 22)
        Me.BtnPosCnfgsave.StyleController = Me.LayoutControl2
        Me.BtnPosCnfgsave.TabIndex = 5
        Me.BtnPosCnfgsave.Text = "Αποθήκευση"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CmbProductSubCategory, Me.CmbMainPrinter, Me.CmbClonePrinter})
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(1144, 593)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'XpCollection1
        '
        Me.XpCollection1.ObjectType = GetType(WaiterModel.Cmp300.Printers)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.GridColumn1, Me.GridColumn2, Me.colPrinter, Me.colClonePrinter, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Υποκατηγορία"
        Me.GridColumn1.ColumnEdit = Me.CmbProductSubCategory
        Me.GridColumn1.FieldName = "ProductSubCategory!"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'CmbProductSubCategory
        '
        Me.CmbProductSubCategory.AutoHeight = False
        Me.CmbProductSubCategory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbProductSubCategory.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sFeatureId", "s Feature Id", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tsDescr2", "ΠΕΡΙΓΡΑΦΗ ΟΜΑΔΑΣ", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbProductSubCategory.DisplayMember = "tsDescr2"
        Me.CmbProductSubCategory.Name = "CmbProductSubCategory"
        Me.CmbProductSubCategory.ValueMember = "This"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "ProductSubCategory!Key"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'colPrinter
        '
        Me.colPrinter.Caption = "Κύριος Εκτυπωτής"
        Me.colPrinter.ColumnEdit = Me.CmbMainPrinter
        Me.colPrinter.FieldName = "Printer"
        Me.colPrinter.Name = "colPrinter"
        Me.colPrinter.Visible = True
        Me.colPrinter.VisibleIndex = 1
        '
        'CmbMainPrinter
        '
        Me.CmbMainPrinter.AutoHeight = False
        Me.CmbMainPrinter.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMainPrinter.Name = "CmbMainPrinter"
        '
        'colClonePrinter
        '
        Me.colClonePrinter.Caption = "Παράλληλος Εκτυπωτής"
        Me.colClonePrinter.ColumnEdit = Me.CmbClonePrinter
        Me.colClonePrinter.FieldName = "ClonePrinter"
        Me.colClonePrinter.Name = "colClonePrinter"
        Me.colClonePrinter.Visible = True
        Me.colClonePrinter.VisibleIndex = 2
        '
        'CmbClonePrinter
        '
        Me.CmbClonePrinter.AutoHeight = False
        Me.CmbClonePrinter.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbClonePrinter.Name = "CmbClonePrinter"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "PosCnfg!"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "PosCnfg!Key"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "GridColumn5"
        Me.GridColumn5.FieldName = "ProductCategory!"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem13})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1168, 643)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.GridControl1
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1148, 597)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.BtnPosCnfgsave
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 597)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(573, 26)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.BtnPosCnfgExit
        Me.LayoutControlItem13.Location = New System.Drawing.Point(573, 597)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(575, 26)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'CmbCloneReciptPrinter
        '
        Me.CmbCloneReciptPrinter.Location = New System.Drawing.Point(222, 218)
        Me.CmbCloneReciptPrinter.Name = "CmbCloneReciptPrinter"
        Me.CmbCloneReciptPrinter.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.CmbCloneReciptPrinter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbCloneReciptPrinter.Size = New System.Drawing.Size(958, 20)
        Me.CmbCloneReciptPrinter.StyleController = Me.LayoutControl1
        Me.CmbCloneReciptPrinter.TabIndex = 14
        '
        'CmbReciptPrinter
        '
        Me.CmbReciptPrinter.Location = New System.Drawing.Point(222, 194)
        Me.CmbReciptPrinter.Name = "CmbReciptPrinter"
        Me.CmbReciptPrinter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbReciptPrinter.Size = New System.Drawing.Size(958, 20)
        Me.CmbReciptPrinter.StyleController = Me.LayoutControl1
        Me.CmbReciptPrinter.TabIndex = 13
        '
        'CmbReciptBehavior
        '
        Me.CmbReciptBehavior.Location = New System.Drawing.Point(732, 102)
        Me.CmbReciptBehavior.Name = "CmbReciptBehavior"
        Me.CmbReciptBehavior.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbReciptBehavior.Size = New System.Drawing.Size(448, 20)
        Me.CmbReciptBehavior.StyleController = Me.LayoutControl1
        Me.CmbReciptBehavior.TabIndex = 12
        '
        'CmpProductCategory
        '
        Me.CmpProductCategory.Location = New System.Drawing.Point(210, 254)
        Me.CmpProductCategory.Name = "CmpProductCategory"
        Me.CmpProductCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmpProductCategory.Size = New System.Drawing.Size(982, 20)
        Me.CmpProductCategory.StyleController = Me.LayoutControl1
        Me.CmpProductCategory.TabIndex = 11
        '
        'chkRoom
        '
        Me.chkRoom.Location = New System.Drawing.Point(24, 278)
        Me.chkRoom.Name = "chkRoom"
        Me.chkRoom.Properties.Caption = "Διαχείρηση Δωματίων"
        Me.chkRoom.Size = New System.Drawing.Size(1168, 20)
        Me.chkRoom.StyleController = Me.LayoutControl1
        Me.chkRoom.TabIndex = 8
        '
        'CmbCashMachineBehavior
        '
        Me.CmbCashMachineBehavior.Location = New System.Drawing.Point(222, 102)
        Me.CmbCashMachineBehavior.Name = "CmbCashMachineBehavior"
        Me.CmbCashMachineBehavior.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbCashMachineBehavior.Size = New System.Drawing.Size(372, 20)
        Me.CmbCashMachineBehavior.StyleController = Me.LayoutControl1
        Me.CmbCashMachineBehavior.TabIndex = 5
        '
        'CmbCommentPrintType
        '
        Me.CmbCommentPrintType.Location = New System.Drawing.Point(749, 398)
        Me.CmbCommentPrintType.Name = "CmbCommentPrintType"
        Me.CmbCommentPrintType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbCommentPrintType.Size = New System.Drawing.Size(443, 20)
        Me.CmbCommentPrintType.StyleController = Me.LayoutControl1
        Me.CmbCommentPrintType.TabIndex = 5
        '
        'txtPosNullLines
        '
        Me.txtPosNullLines.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPosNullLines.Location = New System.Drawing.Point(808, 422)
        Me.txtPosNullLines.Name = "txtPosNullLines"
        Me.txtPosNullLines.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPosNullLines.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPosNullLines.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPosNullLines.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPosNullLines.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtPosNullLines.Properties.MaxValue = New Decimal(New Integer() {800, 0, 0, 0})
        Me.txtPosNullLines.Size = New System.Drawing.Size(384, 20)
        Me.txtPosNullLines.StyleController = Me.LayoutControl1
        Me.txtPosNullLines.TabIndex = 26
        '
        'txtLogo2
        '
        Me.txtLogo2.Location = New System.Drawing.Point(222, 502)
        Me.txtLogo2.Name = "txtLogo2"
        Me.txtLogo2.Size = New System.Drawing.Size(415, 20)
        Me.txtLogo2.StyleController = Me.LayoutControl1
        Me.txtLogo2.TabIndex = 28
        '
        'txtLogo3
        '
        Me.txtLogo3.Location = New System.Drawing.Point(222, 526)
        Me.txtLogo3.Name = "txtLogo3"
        Me.txtLogo3.Size = New System.Drawing.Size(415, 20)
        Me.txtLogo3.StyleController = Me.LayoutControl1
        Me.txtLogo3.TabIndex = 28
        '
        'txtLogo4
        '
        Me.txtLogo4.Location = New System.Drawing.Point(222, 550)
        Me.txtLogo4.Name = "txtLogo4"
        Me.txtLogo4.Size = New System.Drawing.Size(415, 20)
        Me.txtLogo4.StyleController = Me.LayoutControl1
        Me.txtLogo4.TabIndex = 28
        '
        'txtLogo5
        '
        Me.txtLogo5.Location = New System.Drawing.Point(222, 574)
        Me.txtLogo5.Name = "txtLogo5"
        Me.txtLogo5.Size = New System.Drawing.Size(415, 20)
        Me.txtLogo5.StyleController = Me.LayoutControl1
        Me.txtLogo5.TabIndex = 28
        '
        'BtnFiscalPath
        '
        Me.BtnFiscalPath.Location = New System.Drawing.Point(222, 126)
        Me.BtnFiscalPath.Name = "BtnFiscalPath"
        Me.BtnFiscalPath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.BtnFiscalPath.Size = New System.Drawing.Size(958, 20)
        Me.BtnFiscalPath.StyleController = Me.LayoutControl1
        Me.BtnFiscalPath.TabIndex = 29
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1216, 737)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup2
        Me.TabbedControlGroup1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1196, 717)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.PrinterControlGroup})
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem5, Me.LuePosPrintLang, Me.EmptySpaceItem2, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlGroup5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1172, 671)
        Me.LayoutControlGroup2.Text = "Βασικές Ρυθμίσεις"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CmpProductCategory
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 208)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1172, 24)
        Me.LayoutControlItem8.Text = "Defualt Κατηγορία Είδων"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 116)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1172, 92)
        Me.LayoutControlGroup3.Text = "Εκτυπωτές"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.CmbReciptPrinter
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1148, 24)
        Me.LayoutControlItem9.Text = "Εκτυπωτής Λογαριασμού"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CmbCloneReciptPrinter
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1148, 24)
        Me.LayoutControlItem3.Text = "Παράλληλος Εκτυπωτής Λογαριασμού"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem24, Me.LayoutControlItem30})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1172, 116)
        Me.LayoutControlGroup4.Text = "Ταμειακή"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CmbCashMachineBehavior
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(562, 24)
        Me.LayoutControlItem2.Text = "Συμπεριφορά Ταμειακής"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CmbReciptBehavior
        Me.LayoutControlItem1.Location = New System.Drawing.Point(562, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(586, 24)
        Me.LayoutControlItem1.Text = "Συμπεριφορά Λογαριασμού"
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(129, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.CmbCashMachine
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(1148, 24)
        Me.LayoutControlItem24.Text = "Τύπος Ταμειακής"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.BtnFiscalPath
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(1148, 24)
        Me.LayoutControlItem30.Text = "Fiscal Path"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.BtnSave
        Me.LayoutControlItem14.Location = New System.Drawing.Point(898, 564)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(144, 35)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(144, 35)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(144, 107)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.BtnExit
        Me.LayoutControlItem15.Location = New System.Drawing.Point(1042, 564)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(130, 35)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(130, 35)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(130, 107)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.ChkErp
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 256)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(1172, 24)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.CheckAutoOrderKerasma
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 280)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(1172, 24)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.ChkShowDetailOnPrintServer
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 304)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(1172, 24)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.ChkShowOrderNumOnReceipt
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 328)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(1172, 24)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtTamIp
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 352)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(585, 24)
        Me.LayoutControlItem21.Text = "DropBox Backup FileName"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chkRoom
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 232)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1172, 24)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LuePosPrintLang
        '
        Me.LuePosPrintLang.Control = Me.CmbPosPrintLanguage
        Me.LuePosPrintLang.Location = New System.Drawing.Point(0, 376)
        Me.LuePosPrintLang.Name = "LuePosPrintLang"
        Me.LuePosPrintLang.Size = New System.Drawing.Size(598, 24)
        Me.LuePosPrintLang.Text = "Γλώσσα Εκτύπωσης Παραγγελίας"
        Me.LuePosPrintLang.TextSize = New System.Drawing.Size(182, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 564)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(898, 107)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.CmbCommentPrintType
        Me.LayoutControlItem22.CustomizationFormText = "Τρόπος Εκτύπωσης Σχολίων"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(585, 352)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(587, 24)
        Me.LayoutControlItem22.Text = "Τρόπος Εκτύπωσης Σχολίων"
        Me.LayoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(135, 13)
        Me.LayoutControlItem22.TextToControlDistance = 5
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtPosNullLines
        Me.LayoutControlItem23.CustomizationFormText = "Top Margin  Παραγγελίας"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(598, 376)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(574, 24)
        Me.LayoutControlItem23.Text = "Top Margin  Παραγγελίας"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem28, Me.LayoutControlItem29, Me.EmptySpaceItem3})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 400)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1172, 164)
        Me.LayoutControlGroup5.Text = "Τίτλος Λογαριασμού"
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtLogo1
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(605, 24)
        Me.LayoutControlItem25.Text = "Γραμμή 1"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txtLogo2
        Me.LayoutControlItem26.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem26.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(605, 24)
        Me.LayoutControlItem26.Text = "Γραμμή 2"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txtLogo3
        Me.LayoutControlItem27.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem27.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(605, 24)
        Me.LayoutControlItem27.Text = "Γραμμή 3"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtLogo4
        Me.LayoutControlItem28.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem28.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(605, 24)
        Me.LayoutControlItem28.Text = "Γραμμή 4"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(182, 13)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.txtLogo5
        Me.LayoutControlItem29.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem29.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(605, 24)
        Me.LayoutControlItem29.Text = "Γραμμή Fouter"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(182, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(605, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(543, 120)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'PrinterControlGroup
        '
        Me.PrinterControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem11})
        Me.PrinterControlGroup.Location = New System.Drawing.Point(0, 0)
        Me.PrinterControlGroup.Name = "PrinterControlGroup"
        Me.PrinterControlGroup.Size = New System.Drawing.Size(1172, 671)
        Me.PrinterControlGroup.Text = "Εκτυπωτής Ανα Ομάδα Είδους"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LayoutControl2
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1172, 647)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LayoutControlItem11.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem11.Control = Me.CmbProductOmada
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(1172, 24)
        Me.LayoutControlItem11.Text = "Ομάδα"
        Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(36, 13)
        Me.LayoutControlItem11.TextToControlDistance = 5
        '
        'ProductSubCategoryCollection
        '
        Me.ProductSubCategoryCollection.ObjectType = GetType(WaiterModel.Cmp300.STORFEAT2)
        '
        'FrmPosConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 737)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmPosConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPosConfig"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtLogo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbCashMachine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbPosPrintLanguage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTamIp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowOrderNumOnReceipt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowDetailOnPrintServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckAutoOrderKerasma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkErp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbProductOmada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbProductSubCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMainPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbClonePrinter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbCloneReciptPrinter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbReciptPrinter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbReciptBehavior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmpProductCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbCashMachineBehavior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbCommentPrintType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPosNullLines.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogo3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogo4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogo5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFiscalPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LuePosPrintLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinterControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductSubCategoryCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents CmbCashMachineBehavior As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents chkRoom As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CmpProductCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbReciptBehavior As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents CmbReciptPrinter As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CmbCloneReciptPrinter As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrinter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmbMainPrinter As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colClonePrinter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmbClonePrinter As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmbProductSubCategory As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ProductSubCategoryCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PrinterControlGroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CmbProductOmada As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnPosCnfgExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnPosCnfgsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChkErp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckAutoOrderKerasma As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ChkShowOrderNumOnReceipt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkShowDetailOnPrintServer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTamIp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CmbCommentPrintType As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CmbPosPrintLanguage As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents LuePosPrintLang As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtPosNullLines As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CmbCashMachine As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtLogo1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtLogo2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLogo3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLogo4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLogo5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BtnFiscalPath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
