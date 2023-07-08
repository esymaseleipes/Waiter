Imports DevExpress.Spreadsheet
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraSpreadsheet

Public Class FrmPlano
    Public Sub New()
        InitializeComponent()


    End Sub

    'Private Sub test()
    '    Dim Cell As DevExpress.Spreadsheet.Cell
    '    Dim I As Integer
    '    Dim colcount As Integer = SpreadsheetControl1.ActiveWorksheet.Columns.LastUsedIndex
    '    MsgBox(colcount)
    '    For I = 1 To colcount
    '        Debug.Print(SpreadsheetControl1.ActiveWorksheet.Columns.Item(I).Name)
    '    Next

    '    'For I = 1 To SpreadsheetControl1.ActiveWorksheet.Rows.LastUsedIndex
    '    '    Cell = SpreadsheetControl1.ActiveWorksheet.Rows(I)("B")
    '    '    Voucher = Cell.Value.ToString

    '    '    REFDOC = GetDocFromVoucher(Voucher)
    '    '    If REFDOC Is Nothing Then
    '    '        SetCell(I, "H", "", Color.Red)
    '    '        SetCell(I, "I", "ERROR", Color.Red)
    '    '    Else
    '    '        SetCell(I, "H", REFDOC.sdDocum, Color.Green)
    '    '        SetCell(I, "I", REFDOC.cFileId.cName, Color.Green)
    '    '        RefCtrn = GetCtrnFromVoucher(REFDOC)
    '    '        If RefCtrn Is Nothing Then
    '    '            SetCell(I, "K", "CTRN ERROR", Color.Red)
    '    '        Else
    '    '            SetCell(I, "K", "CTRN OK", Color.Green)

    '    '            '' Here Create New Trans (GenTrans)
    '    '            Dim RetCtrnID As Integer = GenTrans(TheCourier, Now, RefCtrn)
    '    '            If RetCtrnID = 0 Then
    '    '                SetCell(I, "L", "New CtrnTrans Error", Color.Red)
    '    '            Else
    '    '                SetCell(I, "L", "New CtrnTrans Ok", Color.Green)

    '    '                If newcpopen(RefCtrn.ctNetValue + RefCtrn.ctVATValue, RefCtrn.ctFileId, RetCtrnID) = False Then
    '    '                    SetCell(I, "M", "New CpOpen Error", Color.Red)
    '    '                Else
    '    '                    RefCtrn.ctCovered = RefCtrn.ctNetValue + RefCtrn.ctVATValue
    '    '                    ses.Save(RefCtrn)
    '    '                    SetCell(I, "M", "New CpOpen OK", Color.Green)
    '    '                End If
    '    '            End If

    '    '        End If
    '    '    End If
    '    'Next
    'End Sub

    'Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
    '    test()
    'End Sub

    'Private Sub SpreadsheetControl1_CustomDrawColumnHeader(sender As Object, e As CustomDrawColumnHeaderEventArgs)
    '    Dim foreColor As Color = Color.Blue
    '    Dim textBounds As Rectangle = e.Bounds
    '    Dim headingFont As New Font(e.Font, FontStyle.Italic)
    '    Dim settingsSheet As Worksheet = SpreadsheetControl1.ActiveWorksheet ' SpreadsheetControl1.Document.Worksheets("SheetSettings")
    '    Dim text As String = Now.Date.AddDays(e.ColumnIndex)

    '    'settingsSheet.Cells(0, e.ColumnIndex).DisplayText
    '    If text <> String.Empty Then
    '        Dim formatHeaderText As New StringFormat()
    '        formatHeaderText.LineAlignment = StringAlignment.Center
    '        formatHeaderText.Alignment = StringAlignment.Center
    '        formatHeaderText.Trimming = StringTrimming.EllipsisCharacter
    '        e.Graphics.DrawString(text, headingFont, e.Cache.GetSolidBrush(foreColor), textBounds, formatHeaderText)
    '    End If
    'End Sub
End Class