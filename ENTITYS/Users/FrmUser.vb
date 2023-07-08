Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300

Public Class FrmUser
    Dim uw As UnitOfWork
    Dim bindobject As MyUsers
    Dim UserToStationCollection As XPCollection(Of UserToStation)
    Public Sub New()
        InitializeComponent()
        uw = New UnitOfWork(Kefdal)
        RollCollection.Session = uw
        bindobject = New MyUsers(uw) With {.fEnabled = True}
        initBind()
    End Sub
    Public Sub New(tmpuser As MyUsers)
        InitializeComponent()
        uw = New UnitOfWork(Kefdal)
        RollCollection.Session = uw
        bindobject = uw.GetObjectByKey(Of MyUsers)(tmpuser.Oid)
        initBind()
    End Sub

    Private Sub initBind()
        txtUserName.DataBindings.Add(New Binding("Text", bindobject, "UserName"))
        txtUserPass.DataBindings.Add(New Binding("Text", bindobject, "Pass"))
        ChkEnabled.DataBindings.Add(New Binding("Checked", bindobject, "fEnabled"))
        CmbRoll.DataBindings.Add(New Binding("EditValue", bindobject, "Roll!"))
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If bindobject.UserName = "" Then
            MsgBox("Προσοχή το όνομα Χρήστη Είναι Κενό!!!")
            Exit Sub
        End If
        If bindobject.Roll Is Nothing Then
            MsgBox("Προσοχή Χρήστης δέν έχει Δικαιώματα ")
            Exit Sub
        End If

        If bindobject.Oid < 0 Then
            UserToStationCollection = New XPCollection(Of UserToStation)(uw)
            UserToStationCollection.Add(New UserToStation(uw) With {.User = bindobject, .Station = uw.GetObjectByKey(Of SUBSIDS)(LogonData.LogonCompany.SubFileIdNo)})
        End If
        'UserToStationCollection = New XPCollection(Of UserToStation)(uw, New BinaryOperator("User", bindobject))

        uw.CommitChanges()
        Me.Close()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class