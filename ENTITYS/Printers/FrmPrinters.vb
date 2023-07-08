Imports System.Drawing.Printing
Imports DevExpress.XtraDiagram.Bars
Imports WindowsApplication1.Cmp300

Public Class FrmPrinters
    Dim Printers As List(Of String)

    'Public Shared Function GetParallelPrinters() As List(Of String)
    '    Dim printerlist As New List(Of String)
    '    Dim p(5) As String
    '    For i = 0 To 4
    '        Dim KeyWord As String = "Printer#Descr"
    '        KeyWord = KeyWord.Replace("#", i)
    '        p(i) = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, KeyWord, "")
    '    Next
    '    For i = 0 To 4
    '        If p(i) <> "" Then
    '            printerlist.Add(p(i))
    '        End If
    '    Next
    '    Return printerlist
    'End Function

    Public Sub New()
        InitializeComponent()
        Printers = ClsShareFunctions.GetAvalablePrinters

        LuePrinter1.Properties.DataSource = Printers
        LuePrinter2.Properties.DataSource = Printers
        LuePrinter3.Properties.DataSource = Printers
        LuePrinter4.Properties.DataSource = Printers
        LuePrinter5.Properties.DataSource = Printers





        LuePrinter1.EditValue = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer1", Nothing)
        LuePrinter2.EditValue = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer2", Nothing)
        LuePrinter3.EditValue = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer3", Nothing)
        LuePrinter4.EditValue = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer4", Nothing)
        LuePrinter5.EditValue = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer5", Nothing)

        txtPrinter1.Text = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer1Descr", "")
        txtPrinter2.Text = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer2Descr", "")
        txtPrinter3.Text = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer3Descr", "")
        txtPrinter4.Text = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer4Descr", "")
        txtPrinter5.Text = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer5Descr", "")


        ParallelPrinter1.EditValue = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter1", Nothing)
        ParallelPrinter2.EditValue = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter2", Nothing)
        ParallelPrinter3.EditValue = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter3", Nothing)
        ParallelPrinter4.EditValue = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter4", Nothing)
        ParallelPrinter5.EditValue = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter5", Nothing)

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SaveToReg()
        Me.Close()
    End Sub
    Private Sub SaveToReg()
        Try
            My.Computer.Registry.CurrentUser.CreateSubKey(ClsRegKeys.PrinterKey)
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "Printer1", IIf(LuePrinter1.EditValue = Nothing, "", LuePrinter1.Text))
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "Printer2", IIf(LuePrinter2.EditValue = Nothing, "", LuePrinter2.Text))
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "Printer3", IIf(LuePrinter3.EditValue = Nothing, "", LuePrinter3.Text))
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "Printer4", IIf(LuePrinter4.EditValue = Nothing, "", LuePrinter4.Text))
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "Printer5", IIf(LuePrinter5.EditValue = Nothing, "", LuePrinter5.Text))



            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "Printer1Descr", txtPrinter1.Text)
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "Printer2Descr", txtPrinter2.Text)
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "Printer3Descr", txtPrinter3.Text)
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "Printer4Descr", txtPrinter4.Text)
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "Printer5Descr", txtPrinter5.Text)



            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter1", ParallelPrinter1.Text)
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter2", ParallelPrinter2.Text)
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter3", ParallelPrinter3.Text)
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter4", ParallelPrinter4.Text)
            My.Computer.Registry.SetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter5", ParallelPrinter5.Text)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class