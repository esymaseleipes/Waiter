Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports WaiterModel.Cmp300

Public Class FrmNewReport
    Dim ses As Session
    Dim OrderLines As XPCollection(Of PosOrderLine)

    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        'Dim SqlStr As String = "select PosOrder.OrderDate,PosOrderLine.Product,sum (PosOrderLine.Quant) as sqnt,sum(PosOrderLine.ProductVal) as sval"
        'SqlStr += " from PosOrder,PosOrderLine where PosOrder.OID=PosOrderLine.PosOrder "
        'SqlStr += " group by PosOrderLine.Product,PosOrderLine.Quant,PosOrderLine.ProductVal,PosOrder.OrderDate"

        Dim SqlStr As String = "select Product,sum (Quant) as sqnt,sum(ProductVal) as sval"
        SqlStr += " from PosOrderLine  "
        SqlStr += " group by Product"

        Dim seldata As SelectedData = ses.ExecuteQuery(SqlStr)

        Dim myview1 As New List(Of myview)

        For Each row As SelectStatementResultRow In seldata.ResultSet(0).Rows


            myview1.Add(New myview With {
                            .Product = ses.GetObjectByKey(Of SMAST)(row.Values(0)),
                            .Qnt = row.Values(1),
                            .Value = row.Values(2),
                            .Omada = .Product.NrgOmada,
                            .YpoOmada = .Product.NrgYpoomada
                            })
        Next

        GridControl1.DataSource = myview1
    End Sub


    Private Class myview
        Public Property Product As SMAST
        Public Property Qnt As Decimal
        Public Property Value As Decimal
        Public Property Omada As STORFEAT1
        Public Property YpoOmada As STORFEAT2

    End Class

End Class