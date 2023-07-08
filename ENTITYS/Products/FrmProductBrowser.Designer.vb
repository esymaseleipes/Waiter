Imports WaiterModel.Cmp300

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProductBrowser
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductBrowser))
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions5 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject17 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject18 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject19 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject20 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ProductCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsFileId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsName_srt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRelCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFactCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFeature1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFeature2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsPlace = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUnitOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUnitOM2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUnitsRel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsWhsalePr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRetailPr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVATCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrStrs1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrStrs2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrStrs3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrStrs4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrDates1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrDates2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrDates3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrTbl1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrTbl2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrTbl3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrNums1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrNums2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrNums3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrNums4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrNums5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrNums6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrCnts1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrCnts2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrCnts3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrCnts4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrCnts5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrCnts6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrCnts7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUsrCnts8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSeason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsWhsMarkup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRetMarkup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsLastPrcPr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LueCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.LueOmada = New DevExpress.XtraEditors.LookUpEdit()
        Me.LueYpoomada = New DevExpress.XtraEditors.LookUpEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.DragDropEvents1 = New DevExpress.Utils.DragDrop.DragDropEvents(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LueCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LueOmada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LueYpoomada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.LueCategory)
        Me.LayoutControl1.Controls.Add(Me.LueOmada)
        Me.LayoutControl1.Controls.Add(Me.LueYpoomada)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1030, 663)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ProductCollection
        Me.GridControl1.Location = New System.Drawing.Point(12, 38)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(1006, 613)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ProductCollection
        '
        Me.ProductCollection.ObjectType = GetType(WaiterModel.Cmp300.SMAST)
        Me.ProductCollection.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[Sortid]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.BehaviorManager1.SetBehaviors(Me.GridView1, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.DragDrop.DragDropBehavior.Create(GetType(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), True, True, True, True, Me.DragDropEvents1), DevExpress.Utils.Behaviors.Behavior)})
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsFileId, Me.colsCode, Me.colsName, Me.colsName_srt, Me.colsRelCode, Me.colsFactCode, Me.colsFeature1, Me.colsFeature2, Me.colsPlace, Me.colsUnitOM, Me.colsUnitOM2, Me.colsUnitsRel, Me.colsWhsalePr, Me.colsRetailPr, Me.colsVATCode, Me.colsComments, Me.colsUsrStrs1, Me.colsUsrStrs2, Me.colsUsrStrs3, Me.colsUsrStrs4, Me.colsUsrDates1, Me.colsUsrDates2, Me.colsUsrDates3, Me.colsUsrTbl1, Me.colsUsrTbl2, Me.colsUsrTbl3, Me.colsUsrNums1, Me.colsUsrNums2, Me.colsUsrNums3, Me.colsUsrNums4, Me.colsUsrNums5, Me.colsUsrNums6, Me.colsUsrCnts1, Me.colsUsrCnts2, Me.colsUsrCnts3, Me.colsUsrCnts4, Me.colsUsrCnts5, Me.colsUsrCnts6, Me.colsUsrCnts7, Me.colsUsrCnts8, Me.colsSeason, Me.colsWhsMarkup, Me.colsRetMarkup, Me.colsLastPrcPr, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(1022, 564, 264, 233)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 4
        Me.GridView1.OptionsEditForm.FormCaptionFormat = "XXXX"
        Me.GridView1.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindFilterColumns = "sName"
        Me.GridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView1.OptionsFind.FindNullPrompt = ""
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colsFileId
        '
        Me.colsFileId.FieldName = "sFileId"
        Me.colsFileId.Name = "colsFileId"
        '
        'colsCode
        '
        Me.colsCode.Caption = "Κωδικός"
        Me.colsCode.FieldName = "sCode"
        Me.colsCode.Name = "colsCode"
        Me.colsCode.Width = 71
        '
        'colsName
        '
        Me.colsName.Caption = "Περιγραφή"
        Me.colsName.FieldName = "sName"
        Me.colsName.Name = "colsName"
        Me.colsName.Visible = True
        Me.colsName.VisibleIndex = 0
        Me.colsName.Width = 398
        '
        'colsName_srt
        '
        Me.colsName_srt.FieldName = "sName_srt"
        Me.colsName_srt.Name = "colsName_srt"
        '
        'colsRelCode
        '
        Me.colsRelCode.FieldName = "sRelCode"
        Me.colsRelCode.Name = "colsRelCode"
        '
        'colsFactCode
        '
        Me.colsFactCode.FieldName = "sFactCode"
        Me.colsFactCode.Name = "colsFactCode"
        '
        'colsFeature1
        '
        Me.colsFeature1.FieldName = "sFeature1"
        Me.colsFeature1.Name = "colsFeature1"
        '
        'colsFeature2
        '
        Me.colsFeature2.FieldName = "sFeature2"
        Me.colsFeature2.Name = "colsFeature2"
        '
        'colsPlace
        '
        Me.colsPlace.Caption = "Θέση"
        Me.colsPlace.FieldName = "sPlace"
        Me.colsPlace.Name = "colsPlace"
        Me.colsPlace.Width = 69
        '
        'colsUnitOM
        '
        Me.colsUnitOM.FieldName = "sUnitOM"
        Me.colsUnitOM.Name = "colsUnitOM"
        '
        'colsUnitOM2
        '
        Me.colsUnitOM2.FieldName = "sUnitOM2"
        Me.colsUnitOM2.Name = "colsUnitOM2"
        '
        'colsUnitsRel
        '
        Me.colsUnitsRel.FieldName = "sUnitsRel"
        Me.colsUnitsRel.Name = "colsUnitsRel"
        '
        'colsWhsalePr
        '
        Me.colsWhsalePr.FieldName = "sWhsalePr"
        Me.colsWhsalePr.Name = "colsWhsalePr"
        '
        'colsRetailPr
        '
        Me.colsRetailPr.Caption = "Τιμή"
        Me.colsRetailPr.FieldName = "sRetailPr"
        Me.colsRetailPr.Name = "colsRetailPr"
        Me.colsRetailPr.Visible = True
        Me.colsRetailPr.VisibleIndex = 6
        Me.colsRetailPr.Width = 92
        '
        'colsVATCode
        '
        Me.colsVATCode.Caption = "Φ.Π.Α"
        Me.colsVATCode.FieldName = "sVATCode"
        Me.colsVATCode.Name = "colsVATCode"
        Me.colsVATCode.Visible = True
        Me.colsVATCode.VisibleIndex = 5
        Me.colsVATCode.Width = 111
        '
        'colsComments
        '
        Me.colsComments.Caption = "Decription"
        Me.colsComments.FieldName = "sComments"
        Me.colsComments.Name = "colsComments"
        Me.colsComments.Visible = True
        Me.colsComments.VisibleIndex = 1
        '
        'colsUsrStrs1
        '
        Me.colsUsrStrs1.FieldName = "sUsrStrs1"
        Me.colsUsrStrs1.Name = "colsUsrStrs1"
        '
        'colsUsrStrs2
        '
        Me.colsUsrStrs2.FieldName = "sUsrStrs2"
        Me.colsUsrStrs2.Name = "colsUsrStrs2"
        '
        'colsUsrStrs3
        '
        Me.colsUsrStrs3.FieldName = "sUsrStrs3"
        Me.colsUsrStrs3.Name = "colsUsrStrs3"
        '
        'colsUsrStrs4
        '
        Me.colsUsrStrs4.FieldName = "sUsrStrs4"
        Me.colsUsrStrs4.Name = "colsUsrStrs4"
        '
        'colsUsrDates1
        '
        Me.colsUsrDates1.FieldName = "sUsrDates1"
        Me.colsUsrDates1.Name = "colsUsrDates1"
        '
        'colsUsrDates2
        '
        Me.colsUsrDates2.FieldName = "sUsrDates2"
        Me.colsUsrDates2.Name = "colsUsrDates2"
        '
        'colsUsrDates3
        '
        Me.colsUsrDates3.FieldName = "sUsrDates3"
        Me.colsUsrDates3.Name = "colsUsrDates3"
        '
        'colsUsrTbl1
        '
        Me.colsUsrTbl1.FieldName = "sUsrTbl1"
        Me.colsUsrTbl1.Name = "colsUsrTbl1"
        '
        'colsUsrTbl2
        '
        Me.colsUsrTbl2.FieldName = "sUsrTbl2"
        Me.colsUsrTbl2.Name = "colsUsrTbl2"
        '
        'colsUsrTbl3
        '
        Me.colsUsrTbl3.FieldName = "sUsrTbl3"
        Me.colsUsrTbl3.Name = "colsUsrTbl3"
        '
        'colsUsrNums1
        '
        Me.colsUsrNums1.FieldName = "sUsrNums1"
        Me.colsUsrNums1.Name = "colsUsrNums1"
        '
        'colsUsrNums2
        '
        Me.colsUsrNums2.FieldName = "sUsrNums2"
        Me.colsUsrNums2.Name = "colsUsrNums2"
        '
        'colsUsrNums3
        '
        Me.colsUsrNums3.FieldName = "sUsrNums3"
        Me.colsUsrNums3.Name = "colsUsrNums3"
        '
        'colsUsrNums4
        '
        Me.colsUsrNums4.FieldName = "sUsrNums4"
        Me.colsUsrNums4.Name = "colsUsrNums4"
        '
        'colsUsrNums5
        '
        Me.colsUsrNums5.FieldName = "sUsrNums5"
        Me.colsUsrNums5.Name = "colsUsrNums5"
        '
        'colsUsrNums6
        '
        Me.colsUsrNums6.FieldName = "sUsrNums6"
        Me.colsUsrNums6.Name = "colsUsrNums6"
        '
        'colsUsrCnts1
        '
        Me.colsUsrCnts1.FieldName = "sUsrCnts1"
        Me.colsUsrCnts1.Name = "colsUsrCnts1"
        '
        'colsUsrCnts2
        '
        Me.colsUsrCnts2.FieldName = "sUsrCnts2"
        Me.colsUsrCnts2.Name = "colsUsrCnts2"
        '
        'colsUsrCnts3
        '
        Me.colsUsrCnts3.FieldName = "sUsrCnts3"
        Me.colsUsrCnts3.Name = "colsUsrCnts3"
        '
        'colsUsrCnts4
        '
        Me.colsUsrCnts4.FieldName = "sUsrCnts4"
        Me.colsUsrCnts4.Name = "colsUsrCnts4"
        '
        'colsUsrCnts5
        '
        Me.colsUsrCnts5.FieldName = "sUsrCnts5"
        Me.colsUsrCnts5.Name = "colsUsrCnts5"
        '
        'colsUsrCnts6
        '
        Me.colsUsrCnts6.FieldName = "sUsrCnts6"
        Me.colsUsrCnts6.Name = "colsUsrCnts6"
        '
        'colsUsrCnts7
        '
        Me.colsUsrCnts7.FieldName = "sUsrCnts7"
        Me.colsUsrCnts7.Name = "colsUsrCnts7"
        '
        'colsUsrCnts8
        '
        Me.colsUsrCnts8.FieldName = "sUsrCnts8"
        Me.colsUsrCnts8.Name = "colsUsrCnts8"
        '
        'colsSeason
        '
        Me.colsSeason.Caption = "Κατηγορία"
        Me.colsSeason.FieldName = "sSeason"
        Me.colsSeason.Name = "colsSeason"
        Me.colsSeason.Width = 123
        '
        'colsWhsMarkup
        '
        Me.colsWhsMarkup.FieldName = "sWhsMarkup"
        Me.colsWhsMarkup.Name = "colsWhsMarkup"
        '
        'colsRetMarkup
        '
        Me.colsRetMarkup.FieldName = "sRetMarkup"
        Me.colsRetMarkup.Name = "colsRetMarkup"
        '
        'colsLastPrcPr
        '
        Me.colsLastPrcPr.FieldName = "sLastPrcPr"
        Me.colsLastPrcPr.Name = "colsLastPrcPr"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Κατηγορία"
        Me.GridColumn1.FieldName = "NrgCategory.sseDescr"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 104
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "NrgCategory!Key"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Ομάδα"
        Me.GridColumn3.FieldName = "NrgOmada.tsDescr1"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 116
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "NrgOmada!Key"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Υποομάδα"
        Me.GridColumn5.FieldName = "NrgYpoomada.tsDescr2"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 164
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "NrgYpoomada!Key"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "ΥΠΟΛΟΙΠΟ"
        Me.GridColumn7.FieldName = "Remain"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Θέση"
        Me.GridColumn8.FieldName = "OrderPosition"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 104
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ενεργό"
        Me.GridColumn9.FieldName = "Enabled"
        Me.GridColumn9.MinWidth = 21
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'LueCategory
        '
        Me.LueCategory.Location = New System.Drawing.Point(69, 12)
        Me.LueCategory.Name = "LueCategory"
        Me.LueCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LueCategory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LueCategory.Properties.Appearance.Options.UseFont = True
        Me.LueCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "ddd", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.LueCategory.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sseFileId", "sse File Id", 71, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sseDescr", "Περιγραφή", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LueCategory.Properties.DisplayMember = "sseDescr"
        Me.LueCategory.Properties.NullText = "[Επέλεξε Κατηγορία]"
        Me.LueCategory.Properties.ValueMember = "This"
        Me.LueCategory.Size = New System.Drawing.Size(235, 22)
        Me.LueCategory.StyleController = Me.LayoutControl1
        Me.LueCategory.TabIndex = 11
        '
        'LueOmada
        '
        Me.LueOmada.Location = New System.Drawing.Point(365, 12)
        Me.LueOmada.Name = "LueOmada"
        Me.LueOmada.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LueOmada.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LueOmada.Properties.Appearance.Options.UseFont = True
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.LueOmada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.LueOmada.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sFeatureId", "s Feature Id", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sFeature1", "Κωδικός", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tsDescr1", "Περιγραφή", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category!", "Category", 55, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category!Key", "Category", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LueOmada.Properties.DisplayMember = "tsDescr1"
        Me.LueOmada.Properties.NullText = "[Επέλεξε Ομάδα]"
        Me.LueOmada.Properties.ValueMember = "This"
        Me.LueOmada.Size = New System.Drawing.Size(288, 22)
        Me.LueOmada.StyleController = Me.LayoutControl1
        Me.LueOmada.TabIndex = 12
        '
        'LueYpoomada
        '
        Me.LueYpoomada.Location = New System.Drawing.Point(714, 12)
        Me.LueYpoomada.Name = "LueYpoomada"
        Me.LueYpoomada.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LueYpoomada.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LueYpoomada.Properties.Appearance.Options.UseFont = True
        EditorButtonImageOptions3.Image = CType(resources.GetObject("EditorButtonImageOptions3.Image"), System.Drawing.Image)
        EditorButtonImageOptions4.Image = CType(resources.GetObject("EditorButtonImageOptions4.Image"), System.Drawing.Image)
        EditorButtonImageOptions5.Image = CType(resources.GetObject("EditorButtonImageOptions5.Image"), System.Drawing.Image)
        Me.LueYpoomada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Edit", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Comments", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Medical", -1, True, True, False, EditorButtonImageOptions5, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject17, SerializableAppearanceObject18, SerializableAppearanceObject19, SerializableAppearanceObject20, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.LueYpoomada.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sFeatureId", "s Feature Id", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sFeature2", "Κωδικός", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tsDescr2", "Περιγραφή", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Parent!", "Parent", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Parent!Key", "Parent", 42, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LueYpoomada.Properties.DisplayMember = "tsDescr2"
        Me.LueYpoomada.Properties.NullText = "[Επέλεξε Υποομάδα]"
        Me.LueYpoomada.Properties.ValueMember = "This"
        Me.LueYpoomada.Size = New System.Drawing.Size(304, 22)
        Me.LueYpoomada.StyleController = Me.LayoutControl1
        Me.LueYpoomada.TabIndex = 13
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1030, 663)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.GridControl1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1010, 617)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.LueCategory
        Me.LayoutControlItem7.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(296, 26)
        Me.LayoutControlItem7.Text = "Κατηγορία"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.LueOmada
        Me.LayoutControlItem8.CustomizationFormText = "Ομάδα       "
        Me.LayoutControlItem8.Location = New System.Drawing.Point(296, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(349, 26)
        Me.LayoutControlItem8.Text = "Ομάδα       "
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.LueYpoomada
        Me.LayoutControlItem9.CustomizationFormText = "Υποομάδα"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(645, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(365, 26)
        Me.LayoutControlItem9.Text = "Υποομάδα"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(53, 13)
        '
        'FrmProductBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 663)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmProductBrowser"
        Me.Text = "Λίστα Προιόντων"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LueCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LueOmada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LueYpoomada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ProductCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsFileId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsName_srt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRelCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFactCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFeature1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFeature2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsPlace As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnitOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnitOM2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnitsRel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsWhsalePr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRetailPr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVATCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrStrs1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrStrs2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrStrs3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrStrs4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrDates1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrDates2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrDates3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrTbl1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrTbl2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrTbl3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrNums1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrNums2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrNums3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrNums4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrNums5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrNums6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrCnts1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrCnts2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrCnts3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrCnts4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrCnts5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrCnts6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrCnts7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUsrCnts8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSeason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsWhsMarkup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRetMarkup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsLastPrcPr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LueCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LueOmada As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LueYpoomada As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents DragDropEvents1 As DevExpress.Utils.DragDrop.DragDropEvents
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
End Class
