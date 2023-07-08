Imports DevExpress.Xpo
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FrmChangeProductFpa
    Dim ses As Session

    Public Sub New()
        InitializeComponent()
        ses = ClsShareFunctions.GetNewSession
        ProdCollection.Session = ses
        FpaCollection.Session = ses
        GridControl1.DataSource = ProdCollection
    End Sub

    Private Sub BtnSet_Click(sender As Object, e As EventArgs) Handles BtnSet.Click
        Dim newvat As VAT = LookUpEdit1.EditValue

        For i = 0 To GridView1.RowCount - 1
            Dim rw As SMAST = GridView1.GetRow(i)
            rw.sVATCode = newvat.FpaCode
            rw.Save()
        Next
        MsgBox("Aλλαγή ΦΠΑ ολοκληρώθεικε !!!!")
    End Sub
End Class