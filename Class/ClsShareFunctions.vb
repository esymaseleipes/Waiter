Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Threading
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports WaiterModel.Cmp300

Namespace Cmp300
    Public Enum EnAddEdit
        EnNothing = 0
        EnAdd = 1
        EnEdit = 2
        EnView = 3
        EnPrint = 4
    End Enum
    Public Class ClsShareFunctions
        Public Shared Function RetDataLayer(SqlParms As SqlConnectrionParams, _AutoCreateOption As AutoCreateOption) As IDataLayer
            Try
                Return XpoDefault.GetDataLayer(
            MSSqlConnectionProvider.GetConnectionString(
                                       SqlParms.SqlServer,
                                       SqlParms.SqlUser,
                                       SqlParms.SqlPass,
                                       SqlParms.SqlDataBase
                                       ),
            _AutoCreateOption
            )
            Catch ex As Exception
                MsgBox("Δέν Μπορώ Να Συνδεθώ Στον SqlServer=" & SqlParms.SqlServer)
                MsgBox(ex.Message)
                End
            End Try
        End Function

        Public Shared Function GetNewSession() As Session
            Return New Session(Kefdal)
        End Function
        Public Shared Sub MyError(FunctionName As String, ex As Exception)
            Dim f As FrmError
            f = New FrmError(FunctionName & vbCrLf & ex.Message)
            f.ShowDialog()
        End Sub
        Public Shared Sub MyDebug(FunctionName As String)
            Debug.Print("---->" & FunctionName & vbCrLf)
        End Sub

        Public Shared Function RetLastSmastCode(Part1 As STORFEAT1, Part2 As STORFEAT2, CodeLen As Integer) As String


            Dim d As Date = Now.Date.ToLongTimeString
            Dim t1 As Integer = Now.TimeOfDay.Hours
            Dim t2 As Integer = Now.TimeOfDay.Minutes
            Dim t3 As Integer = Now.TimeOfDay.Seconds
            Dim t4 As Integer = Now.TimeOfDay.Milliseconds
            Dim t As String = t1.ToString & t2.ToString & t3.ToString & t4.ToString



            Return t
            '  Return t.ToString("0000000000")


        End Function
        Public Shared Function RetLastCode(ct As Type, CodeLen As Integer) As String
            Dim MaxId As Integer
            Dim MaxCode As String = ""
            Dim Mystep As Integer = 1
            MaxId = ClsShareFunctions.GetNewSession.ExecuteScalar("SELECT COUNT(*) FROM [" & ct.Name & "]") + 1
Top:
            Select Case CodeLen
                Case 1
                    MaxCode = MaxId.ToString("0")
                Case 2
                    MaxCode = MaxId.ToString("00")
                Case 3
                    MaxCode = MaxId.ToString("000")
                Case 4
                    MaxCode = MaxId.ToString("0000")
            End Select



            If ct Is GetType(SMAST) And Not ClsShareFunctions.GetNewSession.FindObject(Of SMAST)(New BinaryOperator("sCode", MaxCode, BinaryOperatorType.Equal)) Is Nothing Then
                MaxId += 1
                Mystep += 1
                GoTo Top
            End If


            Return MaxCode
        End Function
        Public Shared Function RetLastId(ct As Type) As Integer
            Dim ses As Session = New Session(Kefdal)
            If ct.Name = "Profesion" Then Return ses.ExecuteScalar("SELECT COUNT(*) FROM [CUSTFEAT1]") + 1
            If ct.Name = "City" Then Return ses.ExecuteScalar("SELECT COUNT(*) FROM [CUSTFEAT2]") + 1
            If ct.Name = "SUBSIDS" Then Return ses.ExecuteScalar("SELECT COUNT(*) FROM [SUBSIDS]") + 1
            Return ses.ExecuteScalar("SELECT COUNT(*) FROM [" & ct.Name & "]") + 1
        End Function

        Public Shared Function GetCurrentDateUs() As String
            Dim dt As DateTime = DateTime.Now
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            Return dt.ToString("d")
        End Function
        Public Shared Function GetCurrentDateUs(Dvalue As Date) As String
            Dim dt As DateTime = DateTime.Now
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            Return dt.ToString("d")
        End Function
        Public Shared Function GetCurrentTime() As String
            Dim dt As DateTime = DateTime.Now
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            Return dt.ToString("t")
        End Function



        Public Shared Function CheckPermisions(Entity As EnEntitys, Cmd As EnCrudCommands) As Boolean
            LogonData.LogonUser.Roll.MasterTablesRolls.Filter = New BinaryOperator("Entity", Entity, BinaryOperatorType.Equal)
            If LogonData.LogonUser.Roll.MasterTablesRolls.Count = 0 Then
                MsgBox("Δεν Υπάρχουν Καταχωρημένοι Ρόλοι στον Χρήστη Για την Εργασία που ζητήσατε !!!!")
                Return False
            End If
            ' DumpRolls(LogonData.LogonUser.Roll.MasterTablesRolls(0))
            Select Case Cmd
                Case EnCrudCommands.EnNewRecord
                    Return LogonData.LogonUser.Roll.MasterTablesRolls(0).AddFunction
                Case EnCrudCommands.EnEditRecord
                    Return LogonData.LogonUser.Roll.MasterTablesRolls(0).EditFunction
                Case EnCrudCommands.EnDeleteRecord
                    Return LogonData.LogonUser.Roll.MasterTablesRolls(0).DeleteFunction
                Case EnCrudCommands.EnViewRecord
                    Return LogonData.LogonUser.Roll.MasterTablesRolls(0).ViewFunction
            End Select
        End Function

        Public Shared Function GetAvalablePrinters() As List(Of String)
            Dim pkInstalledPrinters As String
            Dim printerlist As New List(Of String)
            For Each pkInstalledPrinters In PrinterSettings.InstalledPrinters
                printerlist.Add(pkInstalledPrinters)
            Next
            Return printerlist
        End Function
    End Class



End Namespace



