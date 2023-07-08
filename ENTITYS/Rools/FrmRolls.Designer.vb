Imports WaiterModel.Cmp300

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRolls
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.PorRollCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddFunction1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEditFUnction1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleteFunction1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTreat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangeTable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.RollsData = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddFunction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEditFunction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeleteFunction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colViewFunction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CmbEntities = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.CmbMasterRoll = New DevExpress.XtraEditors.LookUpEdit()
        Me.RollsCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.CmbRoll = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PorRollCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbEntities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMasterRoll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RollsCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.CmbMasterRoll)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(740, 557)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.PorRollCollection
        Me.GridControl2.Location = New System.Drawing.Point(12, 341)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.ShowOnlyPredefinedDetails = True
        Me.GridControl2.Size = New System.Drawing.Size(716, 204)
        Me.GridControl2.TabIndex = 6
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'PorRollCollection
        '
        Me.PorRollCollection.ObjectType = GetType(PosRoll)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid1, Me.colAddFunction1, Me.colEditFUnction1, Me.colDeleteFunction1, Me.colTreat, Me.colChangeTable, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colOid1
        '
        Me.colOid1.FieldName = "Oid"
        Me.colOid1.Name = "colOid1"
        '
        'colAddFunction1
        '
        Me.colAddFunction1.FieldName = "AddFunction"
        Me.colAddFunction1.Name = "colAddFunction1"
        Me.colAddFunction1.Visible = True
        Me.colAddFunction1.VisibleIndex = 0
        '
        'colEditFUnction1
        '
        Me.colEditFUnction1.FieldName = "EditFUnction"
        Me.colEditFUnction1.Name = "colEditFUnction1"
        Me.colEditFUnction1.Visible = True
        Me.colEditFUnction1.VisibleIndex = 1
        '
        'colDeleteFunction1
        '
        Me.colDeleteFunction1.FieldName = "DeleteFunction"
        Me.colDeleteFunction1.Name = "colDeleteFunction1"
        Me.colDeleteFunction1.Visible = True
        Me.colDeleteFunction1.VisibleIndex = 2
        '
        'colTreat
        '
        Me.colTreat.FieldName = "Treat"
        Me.colTreat.Name = "colTreat"
        Me.colTreat.Visible = True
        Me.colTreat.VisibleIndex = 3
        '
        'colChangeTable
        '
        Me.colChangeTable.FieldName = "ChangeTable"
        Me.colChangeTable.Name = "colChangeTable"
        Me.colChangeTable.Visible = True
        Me.colChangeTable.VisibleIndex = 4
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "Roll!"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "Roll!Key"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Delivery"
        Me.GridColumn5.CustomizationCaption = "Delivery"
        Me.GridColumn5.FieldName = "Delivery"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.RollsData
        Me.GridControl1.Location = New System.Drawing.Point(12, 38)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CmbEntities})
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(716, 299)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'RollsData
        '
        Me.RollsData.ObjectType = GetType(MasterTablesRoll)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colAddFunction, Me.colEditFunction, Me.colDeleteFunction, Me.colViewFunction, Me.GridColumn1, Me.GridColumn2, Me.colEntity})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colAddFunction
        '
        Me.colAddFunction.Caption = "ADD"
        Me.colAddFunction.FieldName = "AddFunction"
        Me.colAddFunction.Name = "colAddFunction"
        Me.colAddFunction.Visible = True
        Me.colAddFunction.VisibleIndex = 0
        '
        'colEditFunction
        '
        Me.colEditFunction.Caption = "EDIT"
        Me.colEditFunction.FieldName = "EditFunction"
        Me.colEditFunction.Name = "colEditFunction"
        Me.colEditFunction.Visible = True
        Me.colEditFunction.VisibleIndex = 1
        '
        'colDeleteFunction
        '
        Me.colDeleteFunction.Caption = "DELETE"
        Me.colDeleteFunction.FieldName = "DeleteFunction"
        Me.colDeleteFunction.Name = "colDeleteFunction"
        Me.colDeleteFunction.Visible = True
        Me.colDeleteFunction.VisibleIndex = 2
        '
        'colViewFunction
        '
        Me.colViewFunction.Caption = "VIEW"
        Me.colViewFunction.FieldName = "ViewFunction"
        Me.colViewFunction.Name = "colViewFunction"
        Me.colViewFunction.Visible = True
        Me.colViewFunction.VisibleIndex = 3
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Roll!"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Roll!Key"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'colEntity
        '
        Me.colEntity.FieldName = "Entity"
        Me.colEntity.Name = "colEntity"
        Me.colEntity.Visible = True
        Me.colEntity.VisibleIndex = 4
        '
        'CmbEntities
        '
        Me.CmbEntities.AutoHeight = False
        Me.CmbEntities.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbEntities.Name = "CmbEntities"
        '
        'CmbMasterRoll
        '
        Me.CmbMasterRoll.Location = New System.Drawing.Point(54, 12)
        Me.CmbMasterRoll.Name = "CmbMasterRoll"
        Me.CmbMasterRoll.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CmbMasterRoll.Properties.Appearance.Options.UseFont = True
        Me.CmbMasterRoll.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMasterRoll.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Oid", "Oid", 43, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descr", "Περιγραφή Ρόλου", 47, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CmbMasterRoll.Properties.DataSource = Me.RollsCollection
        Me.CmbMasterRoll.Properties.DisplayMember = "Descr"
        Me.CmbMasterRoll.Properties.ValueMember = "This"
        Me.CmbMasterRoll.Size = New System.Drawing.Size(674, 22)
        Me.CmbMasterRoll.StyleController = Me.LayoutControl1
        Me.CmbMasterRoll.TabIndex = 4
        '
        'RollsCollection
        '
        Me.RollsCollection.ObjectType = GetType(Roll)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.CmbRoll, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(740, 557)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'CmbRoll
        '
        Me.CmbRoll.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CmbRoll.AppearanceItemCaption.Options.UseFont = True
        Me.CmbRoll.Control = Me.CmbMasterRoll
        Me.CmbRoll.Location = New System.Drawing.Point(0, 0)
        Me.CmbRoll.Name = "CmbRoll"
        Me.CmbRoll.Size = New System.Drawing.Size(720, 26)
        Me.CmbRoll.Text = "Ρόλος"
        Me.CmbRoll.TextSize = New System.Drawing.Size(39, 16)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(720, 303)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridControl2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 329)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(720, 208)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FrmRolls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 557)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmRolls"
        Me.Text = "FrmRolls"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PorRollCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbEntities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMasterRoll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RollsCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CmbMasterRoll As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents CmbRoll As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RollsData As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddFunction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEditFunction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleteFunction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colViewFunction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmbEntities As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RollsCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents PorRollCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddFunction1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEditFUnction1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeleteFunction1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTreat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangeTable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
End Class
