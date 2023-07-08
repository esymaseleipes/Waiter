Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class StorFeat2Frm
    Dim ses As Session
    Private _Obj As STORFEAT2
    Public Property Obj As STORFEAT2
        Get
            Return _Obj
        End Get
        Set(ByVal value As STORFEAT2)
            _Obj = value
        End Set
    End Property

    Public Sub New(TheVal As STORFEAT2)
        InitializeComponent()
        Obj = TheVal
        ses = TheVal.Session
        OmadaCollection.Session = ses
        CmbOmada.EditValue = Obj.Parent
        'TextEdit1.EditValue = Obj.Parent.tsDescr1
        initbindigs()
        If Obj.sFeatureId = 0 Then
            Dim MaxId As Integer = ClsShareFunctions.GetNewSession.ExecuteScalar("SELECT max(sFeatureId) FROM STORFEAT2") + 1
            Obj.sFeature2 = MaxId.ToString("000")
            Obj.sFeatureId = MaxId
        Else
            CmbOmada.Properties.ReadOnly = False
        End If
        If Obj.sFeatureId > 0 Then
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub initbindigs()
        TextEdit2.DataBindings.Add(New Binding("EditValue", Obj, "sFeature2", True))
        TextEdit3.DataBindings.Add(New Binding("EditValue", Obj, "tsDescr2", True))
        PictureEdit1.DataBindings.Add(New Binding("EditValue", Obj, "Photo", True))
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not Obj.Parent Is CmbOmada.EditValue Then
            Obj.Parent = CmbOmada.EditValue
            Dim YpoomadaProducts As XPCollection(Of SMAST) = New XPCollection(Of SMAST)(ses, New BinaryOperator("NrgYpoomada", Obj))

            For Each prd As SMAST In YpoomadaProducts
                prd.NrgOmada = CmbOmada.EditValue
                prd.sFeature1 = TryCast(CmbOmada.EditValue, STORFEAT1).sFeature1
            Next
            ses.Save(YpoomadaProducts)
            ses.Save(Obj)
        End If
    End Sub

















    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If MsgBox("Η υποκατηγορία θα διαγραφεί μαζί με τα είδη της!!!", vbYesNo, "Προσοχή!!!") = vbYes Then
            'Dim pp As Printers
            'pp.ProductSubCategory

            Dim odal As IDataLayer = Start.Kefdal
            Dim oses As Session = New Session(odal)
            Dim oYpoomada As STORFEAT2 = oses.GetObjectByKey(Of STORFEAT2)(Obj.sFeatureId)
            Dim Products As XPCollection(Of SMAST) = New XPCollection(Of SMAST)(oses, New BinaryOperator("NrgYpoomada", oYpoomada))
            Dim delposorderlines As XPCollection(Of DelPosOrderLine) = New XPCollection(Of DelPosOrderLine)(oses, New InOperator("Product", Products))
            Dim oprinters As XPCollection(Of Printers) = New XPCollection(Of Printers)(oses, New BinaryOperator("ProductSubCategory", oYpoomada))

            MsgBox(oprinters.Count)
            oses.Delete(oYpoomada.CommentsCollection)
            oses.Delete(oprinters)
            oses.Delete(delposorderlines)




            For Each prd As SMAST In Products



                prd.NrgOmada = Nothing
                prd.NrgYpoomada = Nothing
                prd.Save()
            Next

            Obj = Nothing
            oYpoomada.Reload()
            oses.Delete(oYpoomada)

            'MsgBox(Collectiondelposorderline.Count)
            ' ses.Delete(Collectiondelposorderline)
            'ses.Delete(New XPCollection(Of DelPosOrderLine)(ses).Where(Function(a) a.Product in Obj.SMASTs))
            'ses.Delete(Obj.SMASTs)
            'ses.Delete(Obj)
            ' Me.Close()
        End If

    End Sub
End Class