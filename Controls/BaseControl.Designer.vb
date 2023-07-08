<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseControl
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BtnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnView = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BtnTranses = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnTransItem = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BtnAdd, Me.BtnEdit, Me.BtnDelete, Me.BtnView, Me.BtnRefresh, Me.BtnPrint, Me.BtnExport, Me.BtnTranses, Me.BtnTransItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 11
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(826, 140)
        '
        'BtnAdd
        '
        Me.BtnAdd.Caption = "Νέα Καταχώρηση"
        Me.BtnAdd.Id = 1
        Me.BtnAdd.ImageUri.Uri = "Add"
        Me.BtnAdd.Name = "BtnAdd"
        '
        'BtnEdit
        '
        Me.BtnEdit.Caption = "Μεταβολή"
        Me.BtnEdit.Id = 2
        Me.BtnEdit.ImageUri.Uri = "Clear"
        Me.BtnEdit.Name = "BtnEdit"
        '
        'BtnDelete
        '
        Me.BtnDelete.Caption = "Διαγραφή"
        Me.BtnDelete.Id = 3
        Me.BtnDelete.ImageUri.Uri = "Cancel"
        Me.BtnDelete.Name = "BtnDelete"
        '
        'BtnView
        '
        Me.BtnView.Caption = "Προβολή"
        Me.BtnView.Id = 4
        Me.BtnView.ImageUri.Uri = "Show"
        Me.BtnView.Name = "BtnView"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Caption = "Refresh"
        Me.BtnRefresh.Id = 5
        Me.BtnRefresh.ImageUri.Uri = "Refresh"
        Me.BtnRefresh.Name = "BtnRefresh"
        '
        'BtnPrint
        '
        Me.BtnPrint.Caption = "Εκτύπωση"
        Me.BtnPrint.Id = 6
        Me.BtnPrint.ImageUri.Uri = "Print"
        Me.BtnPrint.Name = "BtnPrint"
        '
        'BtnExport
        '
        Me.BtnExport.Caption = "Export"
        Me.BtnExport.Id = 7
        Me.BtnExport.ImageUri.Uri = "SendBehindText"
        Me.BtnExport.Name = "BtnExport"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnAdd)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnEdit)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnDelete)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnView)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Βασικά Στοιχεία"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnRefresh)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnPrint)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BtnExport)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 140)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(826, 372)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.ShowOnlyPredefinedDetails = True
        Me.GridControl1.Size = New System.Drawing.Size(802, 348)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(826, 372)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(806, 352)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'BtnTranses
        '
        Me.BtnTranses.Caption = "Γενική Καρτελα"
        Me.BtnTranses.Id = 8
        Me.BtnTranses.ImageUri.Uri = "ListBullets"
        Me.BtnTranses.Name = "BtnTranses"
        '
        'BtnTransItem
        '
        Me.BtnTransItem.Caption = "Καρτέλα Στοιχείου"
        Me.BtnTransItem.Id = 9
        Me.BtnTransItem.ImageUri.Uri = "ListNumbers"
        Me.BtnTransItem.Name = "BtnTransItem"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnTranses)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BtnTransItem)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'BaseControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "BaseControl"
        Me.Size = New System.Drawing.Size(826, 512)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Public WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Public WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Public WithEvents BtnAdd As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnEdit As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnDelete As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnView As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnRefresh As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnPrint As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnExport As DevExpress.XtraBars.BarButtonItem
    Public WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Public WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Public WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Public WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Public WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnTranses As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnTransItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
