Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering
Imports WindowsApplication1.Cmp300
Imports DevExpress.Skins
Imports System.Threading
Imports System.Globalization
Imports WaiterModel.Cmp300
Imports DevExpress.Charts.Native
Imports DevExpress.Xpo.Metadata
Imports Newtonsoft.Json
Imports System.Reflection
Imports DevExpress.XtraCharts.Designer.Native
Imports Newtonsoft.Json.Serialization
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.Xpo.Metadata.Helpers




Module Start
    Public SqlConParmFile As String = Application.StartupPath & "\vault\SqlCon.json"
    Public Kefdal As IDataLayer
    Public LogonData As MyLogonData
    Public WorkCompany As SUBSIDS
    Public clsconnection As SqlConnector.ClsConnection
    Dim CryptKey As String = ""

    <STAThread>
    Public Sub main(args As String())

        '   CheckForExistingInstance()
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("el-GR")
        SkinManager.EnableFormSkins()
        SkinManager.EnableMdiFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
p1:
        If Not args.Count = 0 Then SqlConParmFile = Application.StartupPath & "\vault\" & args(0)
        Debug.Print(SqlConParmFile)
        clsconnection = New SqlConnector.ClsConnection(SqlConParmFile, CryptKey)



        Kefdal = clsconnection.GetDataLayer(AutoCreateOption.DatabaseAndSchema)

        Debug.Print(Kefdal.Connection.ConnectionString)

        If Kefdal Is Nothing Then
            If MsgBox("Το αρχείο Παραμετρών συνδεσης με το Sql Δέν Υπάρχει Θέλετε να το Ρυθμίσετε τώρα", vbYesNo) = vbYes Then
                clsconnection.ShowFrmSqlDetail()
                GoTo p1
            End If
        End If
        LogonData = New MyLogonData
        Application.Run(New MainForm)
    End Sub

    Public Sub CheckForExistingInstance()
        'Get number of processes of you program
        If Process.GetProcessesByName _
          (Process.GetCurrentProcess.ProcessName).Length > 1 Then
            MessageBox.Show("Η Εφαρμογή Εκτελείται", "Απαγορεύονται πολλαπλά Στιγμιότυπα!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
            Application.Exit()
        End If
    End Sub









End Module


