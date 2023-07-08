Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports WaiterModel.Cmp300

Public Class FrmRoom
    Public Property BindObj As Room
    Dim ses As Session

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(_room As Room)
        InitializeComponent()
        BindObj = _room
        ses = _room.Session
        Roomtypes.Session = BindObj.Session
        CmbRoomStatus.Properties.Items.AddEnum(GetType(EnRoomStatus))
        'CmbRoomStatus.Enabled = False
        initbind()
    End Sub

    Private Sub initbind()
        txtRoomNumber.DataBindings.Add(New Binding("Text", BindObj, "RoomDescr"))
        '     CmbRoomType.DataBindings.Add(New Binding("EditValue", BindObj, "RoomType!"))
        CmbRoomStatus.DataBindings.Add(New Binding("EditValue", BindObj, "RoomStatus"))
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If txtRoomNumber.Text = "" Then
            MsgBox("Προσοχή κενός αριθμός δωματίου")
            Exit Sub
        End If
        If CheckRoomNumExist() = True Then
            MsgBox("Ο αριθμός Δωματίού Υπάρχει καταχωρημένος!!!")
            Exit Sub
        End If

        BindObj.Save()
        Me.Close()
    End Sub

    Private Sub BtnEsc_Click(sender As Object, e As EventArgs) Handles BtnEsc.Click
        Me.Close()
    End Sub



    Private Function CheckRoomNumExist() As Boolean
        Dim tmproom As Room = ses.FindObject(Of Room)(New BinaryOperator("RoomDescr", BindObj.RoomDescr))
        If tmproom Is Nothing Then Return False

        If BindObj.Oid > 0 Then
            If tmproom.Oid <> BindObj.Oid Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If

    End Function
End Class