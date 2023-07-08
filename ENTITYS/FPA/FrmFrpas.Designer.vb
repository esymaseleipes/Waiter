Imports WaiterModel.Cmp300

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFrpas
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
        Me.FpaCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFpaId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFpaCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFpaData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFpaFiler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFpaFile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTmhma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpaCollection, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LayoutControl1.Size = New System.Drawing.Size(829, 535)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.FpaCollection
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(805, 511)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'FpaCollection
        '
        Me.FpaCollection.ObjectType = GetType(WaiterModel.Cmp300.VAT)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFpaId, Me.colFpaCode, Me.colFpaData, Me.colFpaFiler, Me.colFpaFile, Me.colTmhma})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFpaId
        '
        Me.colFpaId.Caption = "Id"
        Me.colFpaId.FieldName = "FpaId"
        Me.colFpaId.Name = "colFpaId"
        Me.colFpaId.Width = 133
        '
        'colFpaCode
        '
        Me.colFpaCode.Caption = "Περιγραφή ΦΠΑ"
        Me.colFpaCode.FieldName = "FpaCode"
        Me.colFpaCode.Name = "colFpaCode"
        Me.colFpaCode.Visible = True
        Me.colFpaCode.VisibleIndex = 0
        Me.colFpaCode.Width = 217
        '
        'colFpaData
        '
        Me.colFpaData.Caption = "ΦΠΑ%"
        Me.colFpaData.FieldName = "FpaData"
        Me.colFpaData.Name = "colFpaData"
        Me.colFpaData.Visible = True
        Me.colFpaData.VisibleIndex = 1
        Me.colFpaData.Width = 217
        '
        'colFpaFiler
        '
        Me.colFpaFiler.FieldName = "FpaFiler"
        Me.colFpaFiler.Name = "colFpaFiler"
        '
        'colFpaFile
        '
        Me.colFpaFile.FieldName = "FpaFile"
        Me.colFpaFile.Name = "colFpaFile"
        '
        'colTmhma
        '
        Me.colTmhma.Caption = "Τμήμα Ταμειακής"
        Me.colTmhma.FieldName = "Tmhma"
        Me.colTmhma.Name = "colTmhma"
        Me.colTmhma.Visible = True
        Me.colTmhma.VisibleIndex = 2
        Me.colTmhma.Width = 217
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(829, 535)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(809, 515)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FrmFrpas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 535)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmFrpas"
        Me.Text = "Κατηγορίες ΦΠΑ"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpaCollection, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FpaCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents colFpaId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFpaCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFpaData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFpaFiler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFpaFile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTmhma As DevExpress.XtraGrid.Columns.GridColumn
End Class
