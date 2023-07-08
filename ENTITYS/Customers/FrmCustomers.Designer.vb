<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomers
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
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParatsoukli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAfm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(997, 585)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(973, 561)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'XpCollection1
        '
        Me.XpCollection1.ObjectType = GetType(WaiterModel.Cmp300.Customers)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colLname, Me.colParatsoukli, Me.colAfm, Me.colPhone1, Me.colPhone2, Me.colAddress1, Me.colAddress2, Me.colAddress3, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colLname
        '
        Me.colLname.Caption = "Επωνυμία"
        Me.colLname.FieldName = "Lname"
        Me.colLname.Name = "colLname"
        Me.colLname.Visible = True
        Me.colLname.VisibleIndex = 0
        '
        'colParatsoukli
        '
        Me.colParatsoukli.FieldName = "Paratsoukli"
        Me.colParatsoukli.Name = "colParatsoukli"
        '
        'colAfm
        '
        Me.colAfm.Caption = "ΑΦΜ"
        Me.colAfm.FieldName = "Afm"
        Me.colAfm.Name = "colAfm"
        Me.colAfm.Visible = True
        Me.colAfm.VisibleIndex = 1
        '
        'colPhone1
        '
        Me.colPhone1.Caption = "Τηλ1"
        Me.colPhone1.FieldName = "Phone1"
        Me.colPhone1.Name = "colPhone1"
        Me.colPhone1.Visible = True
        Me.colPhone1.VisibleIndex = 6
        '
        'colPhone2
        '
        Me.colPhone2.Caption = "Τηλ2"
        Me.colPhone2.FieldName = "Phone2"
        Me.colPhone2.Name = "colPhone2"
        Me.colPhone2.Visible = True
        Me.colPhone2.VisibleIndex = 7
        '
        'colAddress1
        '
        Me.colAddress1.FieldName = "Address1"
        Me.colAddress1.Name = "colAddress1"
        '
        'colAddress2
        '
        Me.colAddress2.FieldName = "Address2"
        Me.colAddress2.Name = "colAddress2"
        '
        'colAddress3
        '
        Me.colAddress3.FieldName = "Address3"
        Me.colAddress3.Name = "colAddress3"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Company!"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Company!Key"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(997, 585)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(977, 565)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Επάγγελμα"
        Me.GridColumn3.FieldName = "Profesion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Email"
        Me.GridColumn4.FieldName = "Email"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Διέυθυνση"
        Me.GridColumn5.FieldName = "MainAddress"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Πόλη"
        Me.GridColumn6.FieldName = "City"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'FrmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 585)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmCustomers"
        Me.Text = "Στοιχεία Πελατών"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParatsoukli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAfm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
