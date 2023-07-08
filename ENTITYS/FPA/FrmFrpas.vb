Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300
Imports WindowsApplication1
Imports WindowsApplication1.Cmp300

Public Class FrmFrpas
    Implements IcanCrud
    Dim ses As Session


    Public Sub New()
        InitializeComponent()
        ses = ClsShareFunctions.GetNewSession
        FpaCollection.Session = ses
    End Sub





    Public Property Entity As EnEntitys Implements IcanCrud.Entity
        Get
            Return EnEntitys.EnFPA
        End Get
        Set(value As EnEntitys)
            Entity = EnEntitys.EnFPA
        End Set
    End Property

    Public Sub AddRecord() Implements IcanCrud.AddRecord
        Dim op As CriteriaOperator = CriteriaOperator.Parse("Max(FpaId)")
        Dim maxId As Int32 = ses.Evaluate(Of VAT)(op, Nothing)
        maxId += 1
        Dim TmpFpa As VAT = New VAT(ses) With {.FpaId = maxId, .FpaCode = maxId.ToString, .FpaFile = 3, .FpaFiler = 2, .FpaData = 0, .Tmhma = 0}

        Dim F As FrmFpa = New FrmFpa(TmpFpa)
        If F.ShowDialog() = DialogResult.OK Then
            FpaCollection.Add(F.fpa)
            ses.Save(FpaCollection)
        End If
    End Sub

    Public Sub EditRecord() Implements IcanCrud.EditRecord
        Dim tmpfpa As VAT = GridView1.GetFocusedRow
        If Not tmpfpa Is Nothing Then
            Dim F As FrmFpa = New FrmFpa(tmpfpa)
            If F.ShowDialog() = DialogResult.OK Then F.fpa.Save()
        End If


    End Sub

    Public Sub DeleteRecord() Implements IcanCrud.DeleteRecord
        '   Throw New NotImplementedException()
    End Sub

    Public Sub ViewRecord() Implements IcanCrud.ViewRecord
        '   Throw New NotImplementedException()
    End Sub
End Class