Imports System.ComponentModel

Public Class MyNumPad
    Dim CommaPress As Boolean
    Public Sub New()
        InitializeComponent()
        NumPadValue = 0
        TxtVal.Properties.PasswordChar = "*"
        BtnComma.Visible = False
        initBinding()

        Me.ShowDialog()
    End Sub
    Public Sub New(_val As Decimal, comma As Boolean)
        InitializeComponent()
        NumPadValue = _val
        BtnComma.Visible = comma
        initBinding()

        Me.ShowDialog()
    End Sub




    Private _NumPadValue As Decimal
    Public Property NumPadValue() As Decimal
        Get
            Return _NumPadValue
        End Get
        Set(ByVal value As Decimal)
            _NumPadValue = value
            Debug.Print("new Numpadval=" & value)
        End Set

    End Property
    Private Sub initBinding()
        Try
            TxtVal.DataBindings.Add(New Binding("EditValue", Me, "NumPadValue", True))
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try

    End Sub
    Private Sub SimpleButton13_Click(sender As Object, e As EventArgs) Handles SimpleButton13.Click
        NumPadValue = vbNull
        Me.Dispose()
    End Sub


#Region "NumButonPress"
    Private Sub BtnClick(Num As Integer)
        If CommaPress = True Then
            NumPadValue += Num / 10
            CommaPress = False
            TxtVal.Text = NumPadValue
        Else
            Dim StrNum As String = NumPadValue.ToString
            NumPadValue = CDec(StrNum & Num)
            TxtVal.Text = NumPadValue
        End If
    End Sub
    Private Sub BtnDelClick()
        Dim StrNum As String = NumPadValue.ToString
        Dim delstr As String = Mid(StrNum, 1, Len(StrNum) - 1)
        If delstr = "" Then
            NumPadValue = 0
            TxtVal.Text = NumPadValue
            BtnComma.Visible = True
            Exit Sub
        End If
        NumPadValue = CDec(delstr)
        TxtVal.Text = NumPadValue
    End Sub
    Private Sub BtnCommaClick()
        Dim StrNum As String = NumPadValue.ToString
        NumPadValue = CDec(StrNum & ",")
        TxtVal.Text = NumPadValue
        'NumPadValue += 0.0

        ' TxtVal.Text = NumPadValue
    End Sub
    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        BtnClick(0)
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        BtnClick(1)
    End Sub
    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        BtnClick(2)
    End Sub
    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        BtnClick(3)
    End Sub
    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        BtnClick(4)
    End Sub
    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        BtnClick(5)
    End Sub
    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        BtnClick(6)
    End Sub
    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        BtnClick(7)
    End Sub
    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        BtnClick(8)
    End Sub
    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        BtnClick(9)
    End Sub
    Private Sub SimpleButton14_Click(sender As Object, e As EventArgs) Handles SimpleButton14.Click ''Delete
        BtnDelClick()
    End Sub
    Private Sub BtnComma_Click(sender As Object, e As EventArgs) Handles BtnComma.Click
        CommaPress = True
        BtnComma.Visible = False
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        Me.Dispose()
    End Sub
#End Region
End Class