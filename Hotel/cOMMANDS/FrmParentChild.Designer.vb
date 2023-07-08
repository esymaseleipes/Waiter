<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParentChild
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.XpCollection1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1173, 573)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'XpCollection1
        '
        Me.XpCollection1.ObjectType = GetType(WaiterModel.Cmp300.PosOrder)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colTrnums, Me.colDocNum, Me.colStatus, Me.colOrderPayType, Me.colTrapezi, Me.colOrderValue, Me.colOrderDate, Me.colOrderCreateTime, Me.colOrderCloseTime, Me.colFinalization, Me.GridColumn5, Me.GridColumn6, Me.colLanguage, Me.colPersons, Me.colNewCustomer, Me.colAddress, Me.colDeliveryMan, Me.colToCloud, Me.colfInvoice, Me.colOrderDisc, Me.colOrderDiscVal, Me.colOrderTotal, Me.colGetNetValue, Me.colGetVatValue})
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
        Me.colDocNum.VisibleIndex = 0
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'colOrderPayType
        '
        Me.colOrderPayType.FieldName = "OrderPayType"
        Me.colOrderPayType.Name = "colOrderPayType"
        '
        'colTrapezi
        '
        Me.colTrapezi.FieldName = "Trapezi"
        Me.colTrapezi.Name = "colTrapezi"
        Me.colTrapezi.Visible = True
        Me.colTrapezi.VisibleIndex = 1
        '
        'colOrderValue
        '
        Me.colOrderValue.FieldName = "OrderValue"
        Me.colOrderValue.Name = "colOrderValue"
        '
        'colOrderDate
        '
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        '
        'colOrderCreateTime
        '
        Me.colOrderCreateTime.FieldName = "OrderCreateTime"
        Me.colOrderCreateTime.Name = "colOrderCreateTime"
        '
        'colOrderCloseTime
        '
        Me.colOrderCloseTime.FieldName = "OrderCloseTime"
        Me.colOrderCloseTime.Name = "colOrderCloseTime"
        '
        'colFinalization
        '
        Me.colFinalization.FieldName = "Finalization"
        Me.colFinalization.Name = "colFinalization"
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "RoomTrans!"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "RoomTrans!Key"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'colLanguage
        '
        Me.colLanguage.FieldName = "Language"
        Me.colLanguage.Name = "colLanguage"
        '
        'colPersons
        '
        Me.colPersons.FieldName = "Persons"
        Me.colPersons.Name = "colPersons"
        '
        'colNewCustomer
        '
        Me.colNewCustomer.FieldName = "NewCustomer"
        Me.colNewCustomer.Name = "colNewCustomer"
        '
        'colAddress
        '
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        '
        'colDeliveryMan
        '
        Me.colDeliveryMan.FieldName = "DeliveryMan"
        Me.colDeliveryMan.Name = "colDeliveryMan"
        '
        'colToCloud
        '
        Me.colToCloud.FieldName = "ToCloud"
        Me.colToCloud.Name = "colToCloud"
        '
        'colfInvoice
        '
        Me.colfInvoice.FieldName = "fInvoice"
        Me.colfInvoice.Name = "colfInvoice"
        '
        'colOrderDisc
        '
        Me.colOrderDisc.FieldName = "OrderDisc"
        Me.colOrderDisc.Name = "colOrderDisc"
        '
        'colOrderDiscVal
        '
        Me.colOrderDiscVal.FieldName = "OrderDiscVal"
        Me.colOrderDiscVal.Name = "colOrderDiscVal"
        '
        'colOrderTotal
        '
        Me.colOrderTotal.FieldName = "OrderTotal"
        Me.colOrderTotal.Name = "colOrderTotal"
        Me.colOrderTotal.Visible = True
        Me.colOrderTotal.VisibleIndex = 2
        '
        'colGetNetValue
        '
        Me.colGetNetValue.FieldName = "GetNetValue"
        Me.colGetNetValue.Name = "colGetNetValue"
        '
        'colGetVatValue
        '
        Me.colGetVatValue.FieldName = "GetVatValue"
        Me.colGetVatValue.Name = "colGetVatValue"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'FrmParentChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 573)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "FrmParentChild"
        Me.Text = "FrmParentChild"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
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
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
