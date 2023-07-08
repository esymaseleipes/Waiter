<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmlRoomTypeLister
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.RoomTypeCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MainBedCmb = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BedsCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMainBedNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtraBedNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaxPersons = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMinPersons = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomTypeCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainBedCmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedsCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(919, 674)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.RoomTypeCollection
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.MainBedCmb})
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(895, 650)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'RoomTypeCollection
        '
        Me.RoomTypeCollection.ObjectType = GetType(NrgWaiterModel.Cmp300.RoomType)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colDescr, Me.GridColumn1, Me.GridColumn2, Me.colMainBedNum, Me.colExtraBedNum, Me.GridColumn3, Me.GridColumn4, Me.colMaxPersons, Me.colMinPersons})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colDescr
        '
        Me.colDescr.Caption = "Περιγραφή Τύπου Δωματίου"
        Me.colDescr.FieldName = "Descr"
        Me.colDescr.Name = "colDescr"
        Me.colDescr.Visible = True
        Me.colDescr.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Βασικό Κρεβάτι"
        Me.GridColumn1.ColumnEdit = Me.MainBedCmb
        Me.GridColumn1.FieldName = "MainBedType!"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'MainBedCmb
        '
        Me.MainBedCmb.AutoHeight = False
        Me.MainBedCmb.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MainBedCmb.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Oid", "Oid", 39, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descr", "Περιγραφή Κρεβατιού", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Persons", "Άτομα", 48, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.MainBedCmb.DataSource = Me.BedsCollection
        Me.MainBedCmb.DisplayMember = "Descr"
        Me.MainBedCmb.Name = "MainBedCmb"
        Me.MainBedCmb.ValueMember = "This"
        '
        'BedsCollection
        '
        Me.BedsCollection.ObjectType = GetType(NrgWaiterModel.Cmp300.BedType)
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "MainBedType!Key"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'colMainBedNum
        '
        Me.colMainBedNum.Caption = "Αριθμός Κύριων Κρεβατιών"
        Me.colMainBedNum.FieldName = "MainBedNum"
        Me.colMainBedNum.Name = "colMainBedNum"
        Me.colMainBedNum.Visible = True
        Me.colMainBedNum.VisibleIndex = 1
        '
        'colExtraBedNum
        '
        Me.colExtraBedNum.Caption = "Αριθμός Έξτρα Κρεβατιών"
        Me.colExtraBedNum.FieldName = "ExtraBedNum"
        Me.colExtraBedNum.Name = "colExtraBedNum"
        Me.colExtraBedNum.Visible = True
        Me.colExtraBedNum.VisibleIndex = 3
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Έξτρα Κρεβάτι"
        Me.GridColumn3.ColumnEdit = Me.MainBedCmb
        Me.GridColumn3.FieldName = "ExtraBedType!"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "ExtraBedType!Key"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'colMaxPersons
        '
        Me.colMaxPersons.FieldName = "MaxPersons"
        Me.colMaxPersons.Name = "colMaxPersons"
        '
        'colMinPersons
        '
        Me.colMinPersons.FieldName = "MinPersons"
        Me.colMinPersons.Name = "colMinPersons"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(919, 674)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(899, 654)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FrmHotelRoomTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 674)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmHotelRoomTypes"
        Me.Text = "FrmHotelRoomTypes"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomTypeCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainBedCmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedsCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RoomTypeCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMainBedNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtraBedNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaxPersons As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinPersons As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MainBedCmb As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BedsCollection As DevExpress.Xpo.XPCollection
End Class
