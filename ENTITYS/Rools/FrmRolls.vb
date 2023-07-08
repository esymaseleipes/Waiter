Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports WaiterModel.Cmp300
Imports WindowsApplication1
Imports WindowsApplication1.Cmp300

Public Class FrmRolls
    Implements IcanCrud

    Dim ses As Session

    Public Sub New()
        InitializeComponent()
        Entity = EnEntitys.EnRolls
        ses = New Session(Kefdal)
        RollsCollection.Session = ses
        PorRollCollection.Session = ses
        CmbEntities.Items.AddEnum(GetType(EnEntitys))
        GridControl1.DataSource = Nothing
        Roll.AutoSaveOnEndEdit = True
        MasterTablesRoll.AutoSaveOnEndEdit = True
    End Sub



#Region "Interface"
    Dim _Entity As EnEntitys
    Public Property Entity As EnEntitys Implements IcanCrud.Entity
        Get
            Return _Entity
        End Get
        Set(value As EnEntitys)
            _Entity = value
        End Set
    End Property

    Public Sub AddRecord() Implements IcanCrud.AddRecord
        Dim tmproll As Roll = New Roll(ses) With {.Descr = ""}
        Dim f As FrmRoolDescr = New FrmRoolDescr(tmproll)

        If f.ShowDialog = DialogResult.OK Then
            RollsCollection.Add(f.TmpRoll)
            ses.Save(RollsCollection)
            cloneRollfromadmin(f.TmpRoll)
        End If




    End Sub


    Private Sub cloneRollfromadmin(toroll As Roll)
        Dim tmprool1 As Roll = ses.FindObject(Of Roll)(1)
        For Each mtr As MasterTablesRoll In tmprool1.MasterTablesRolls
            toroll.MasterTablesRolls.Add(New MasterTablesRoll(ses) With {.AddFunction = mtr.AddFunction,
                                         .DeleteFunction = mtr.DeleteFunction,
                                         .EditFunction = mtr.EditFunction,
                                         .ViewFunction = mtr.ViewFunction,
                                         .Entity = mtr.Entity,
                                         .Roll = toroll})

            toroll.Save()

        Next

        If tmprool1.PosRolls.Count = 0 Then
            tmprool1.PosRolls.Add(New PosRoll(ses) With {
                                 .AddFunction = True,
                                 .ChangeTable = True,
                                 .DeleteFunction = True,
                                .EditFUnction = True,
                                .Roll = tmprool1,
                                .Treat = True})
            tmprool1.Save()
        End If



        For Each pr As PosRoll In tmprool1.PosRolls
            toroll.PosRolls.Add(New PosRoll(ses) With {.AddFunction = pr.AddFunction,
                                .ChangeTable = pr.ChangeTable,
                                .DeleteFunction = pr.DeleteFunction,
                                .EditFUnction = pr.EditFUnction,
                                .Roll = toroll,
                                .Treat = pr.Treat})
            toroll.Save()
        Next


    End Sub



    Public Sub DeleteRecord() Implements IcanCrud.DeleteRecord
        ' Throw New NotImplementedException()
    End Sub

    Public Sub EditRecord() Implements IcanCrud.EditRecord
        '    Throw New NotImplementedException()
    End Sub

    Public Sub ViewRecord() Implements IcanCrud.ViewRecord
        '  Throw New NotImplementedException()
    End Sub

    Private Sub CmbMasterRoll_EditValueChanged(sender As Object, e As EventArgs) Handles CmbMasterRoll.EditValueChanged
        GridControl1.DataSource = DirectCast(CmbMasterRoll.EditValue, Roll).MasterTablesRolls
        GridControl2.DataSource = DirectCast(CmbMasterRoll.EditValue, Roll).PosRolls
    End Sub

    Private Sub CmbMasterRoll_Closed(sender As Object, e As ClosedEventArgs) Handles CmbMasterRoll.Closed

    End Sub
#End Region

End Class