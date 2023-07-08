Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class CtrlProductBrowser
    Public Property Product As SMAST
    Public Property ses As Session
    Dim products As XPCollection(Of SMAST)
    Dim CategoryCollection As XPCollection
    Dim OmadaCollection As XPCollection
    Dim YpoomadaCollection As XPCollection
    Public Sub New()
        InitializeComponent()
        ses = ClsShareFunctions.GetNewSession
        products = New XPCollection(Of SMAST)(ses)
        InitCategory()
        GridControl1.DataSource = products
    End Sub
    Public Sub New(_ses As Session)
        InitializeComponent()
        ses = _ses
        products = New XPCollection(Of SMAST)(ses)
        InitCategory()
        GridControl1.DataSource = products
    End Sub
    Private Sub InitCategory()
        CategoryCollection = New XPCollection(ses, GetType(SSEAZON))
        Dim Columns As LookUpColumnInfo() = New LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sseFileId", "sse File Id", 71, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New LookUpColumnInfo("sseDescr", "Περιγραφή", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)}
        ' CtrlAttribPerGroup1.InitNew("Κατηγορία", Columns, "sseDescr", "This", CategoryCollection)
    End Sub
    'Private Sub CtrlAttribPerGroup1_EditValueChanged(sender As Object, e As EventArgs) Handles CtrlAttribPerGroup1.EditValueChanged
    '    Dim le As LookUpEdit = TryCast(sender, LookUpEdit)
    '    Dim ss As SSEAZON = le.EditValue
    '    Dim BO As BinaryOperator = New BinaryOperator("Category", ss)
    '    OmadaCollection = New XPCollection(ses, GetType(STORFEAT1))
    '    OmadaCollection.Filter = BO
    '    Dim Columns As LookUpColumnInfo() = New LookUpColumnInfo() _
    '        {New LookUpColumnInfo("sFeatureId", "s FeatureId", 71, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far),
    '        New LookUpColumnInfo("tsDescr1", "Περιγραφή", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)}
    '    'CtrlAttribPerGroup2.InitNew("Ομάδα", Columns, "tsDescr1", "This", OmadaCollection)
    '    ProductFilter(ss)
    'End Sub
    'Private Sub CtrlAttribPerGroup2_EditValueChanged(sender As Object, e As EventArgs) Handles CtrlAttribPerGroup2.EditValueChanged
    '    Dim le As LookUpEdit = TryCast(sender, LookUpEdit)
    '    Dim ss As STORFEAT1 = le.EditValue
    '    Dim BO As BinaryOperator = New BinaryOperator("Parent", ss)
    '    YpoomadaCollection = New XPCollection(ses, GetType(STORFEAT2))
    '    YpoomadaCollection.Filter = BO
    '    Dim Columns As LookUpColumnInfo() = New LookUpColumnInfo() _
    '        {New LookUpColumnInfo("sFeatureId", "s FeatureId", 71, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far),
    '        New LookUpColumnInfo("tsDescr2", "Περιγραφή", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)}
    '    ' CtrlAttribPerGroup3.InitNew("Υποομαδα", Columns, "tsDescr2", "This", YpoomadaCollection)
    '    ProductFilter(ss)
    'End Sub
    'Private Sub CtrlAttribPerGroup3_EditValueChanged(sender As Object, e As EventArgs) Handles CtrlAttribPerGroup3.EditValueChanged
    '    Dim le As LookUpEdit = TryCast(sender, LookUpEdit)
    '    Dim ss As STORFEAT2 = le.EditValue
    '    ProductFilter(ss)
    'End Sub

#Region "FIlter Attribs"
    'Private Sub CtrlAttribPerGroup1_AttribChange() Handles CtrlAttribPerGroup1.AttribChange
    '    getAttribs()
    'End Sub

    'Private Sub CtrlAttribPerGroup2_AttribChange() Handles CtrlAttribPerGroup2.AttribChange
    '    getAttribs()
    'End Sub

    'Private Sub CtrlAttribPerGroup3_AttribChange() Handles CtrlAttribPerGroup3.AttribChange
    '    getAttribs()
    'End Sub
    'Private Function getAttribs()
    '    Dim cmbs1 As List(Of LookUpEdit) = CtrlAttribPerGroup1.GetCombos
    '    Dim cmbs2 As List(Of LookUpEdit) = CtrlAttribPerGroup2.GetCombos
    '    Dim cmbs3 As List(Of LookUpEdit) = CtrlAttribPerGroup3.GetCombos
    '    products.Filter = Nothing
    '    '  Dim _CmbAttribs As CmbAttribs
    '    Dim WHERE As ContainsOperator = Nothing
    '    For Each cmb As LookUpEdit In cmbs1
    '        If Not cmb.EditValue Is Nothing Then WHERE = ContainsOperator.And(New ContainsOperator("ProductAttributesCollection", New BinaryOperator("AttributeVal", cmb.EditValue)))
    '    Next
    '    For Each cmb As LookUpEdit In cmbs2
    '        If Not cmb.EditValue Is Nothing Then WHERE = ContainsOperator.And(New ContainsOperator("ProductAttributesCollection", New BinaryOperator("AttributeVal", cmb.EditValue)))
    '    Next
    '    For Each cmb As LookUpEdit In cmbs3
    '        If Not cmb.EditValue Is Nothing Then WHERE = ContainsOperator.And(New ContainsOperator("ProductAttributesCollection", New BinaryOperator("AttributeVal", cmb.EditValue)))
    '    Next
    '    products.Filter = WHERE

    'End Function


#End Region

    Private Sub ProductFilter(Obj As Object)
        If Obj Is Nothing Then
            products.Filter = Nothing
            GoTo p1
        End If
        Select Case Obj.GetType
            Case GetType(SSEAZON)
                products.Filter = New BinaryOperator("NrgCategory", TryCast(Obj, SSEAZON))
            Case GetType(STORFEAT1)
                products.Filter = New BinaryOperator("NrgOmada", TryCast(Obj, STORFEAT1))
            Case GetType(STORFEAT2)
                products.Filter = New BinaryOperator("NrgYpoomada", TryCast(Obj, STORFEAT2))
        End Select
p1:
        GridControl1.DataSource = products

    End Sub


















    Public Sub GetSelectedProduct()
        Product = CType(GridView1.GetFocusedRow(), SMAST)
    End Sub
    Private Sub GridView1_RowClick(sender As Object, e As RowClickEventArgs) Handles GridView1.RowClick
        GetSelectedProduct()
    End Sub


End Class


