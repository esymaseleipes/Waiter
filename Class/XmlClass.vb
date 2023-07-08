Imports System.IO
Imports System.Xml.Serialization
Imports WindowsApplication1.Cmp300

Public Class XmlClass
    Shared Myparams As ClsPararms
    'Shared sFilename As String = Application.StartupPath & "\AppParams.xml"


    Public Shared Function getParams(xmlpath As String) As ClsPararms
        If Dir(xmlpath) = "" Then
            ' MsgBox("Δεν Υπαρχει το αρχείο " & Start.xmlpath)
            '  End
        End If

        Try
            Dim objStreamReader As New StreamReader(xmlpath)
            Dim x As New XmlSerializer(GetType(ClsPararms))
            Return x.Deserialize(objStreamReader)
            objStreamReader.Close()
        Catch ex As Exception
            Debug.Print("ClsDb->getParams Error:" & Err.Description)
            Return Nothing
        End Try
    End Function


    Public Shared Sub SaveClassToXml(XmlFilename As String, TheType As Type, _Obj As Object)
        Dim objStreamWriter As New StreamWriter(Application.StartupPath & "\" & XmlFilename)
        Dim serializer As New XmlSerializer(TheType)
        serializer.Serialize(objStreamWriter, _Obj)
        objStreamWriter.Close()
    End Sub

End Class
Public Class ClsPararms
    Private _Printer1 As String
    Public Property Printer1() As String
        Get
            Return _Printer1
        End Get
        Set(ByVal value As String)
            _Printer1 = value
        End Set
    End Property
    Private _SqlServer As SqlConnectrionParams
    Public Property SqlServer() As SqlConnectrionParams
        Get
            Return _SqlServer
        End Get
        Set(ByVal value As SqlConnectrionParams)
            _SqlServer = value
        End Set
    End Property
    Private _trnumsid As Integer
    Public Property trnumsid As Integer
        Get
            Return _trnumsid
        End Get
        Set(ByVal value As Integer)
            _trnumsid = value
        End Set


    End Property
    Private _ProductParam As ProductParams
    Public Property ProductParam() As ProductParams
        Get
            Return _ProductParam
        End Get
        Set(ByVal value As ProductParams)
            _ProductParam = value
        End Set
    End Property
    Private _PosStation As Boolean
    Public Property PosStation As Boolean
        Get
            Return _PosStation
        End Get
        Set(ByVal value As Boolean)
            _PosStation = value
        End Set
    End Property
    Private _Skin As String
    Public Property Skin() As String
        Get
            Return _Skin
        End Get
        Set(ByVal value As String)
            _Skin = value
        End Set
    End Property
    Private _Title As ClsTitle
    Public Property Title() As ClsTitle
        Get
            Return _Title
        End Get
        Set(ByVal value As ClsTitle)
            _Title = value
        End Set
    End Property

    Private _OldData As SqlConnectrionParams
    Public Property OldData() As SqlConnectrionParams
        Get
            Return _OldData
        End Get
        Set(ByVal value As SqlConnectrionParams)
            _OldData = value
        End Set
    End Property
End Class
Public Class SqlConnectrionParams
    Private _SqlServer As String
    Public Property SqlServer() As String
        Get
            Return _SqlServer
        End Get
        Set(ByVal value As String)
            _SqlServer = value
        End Set
    End Property
    Private _SqlUser As String
    Public Property SqlUser() As String
        Get
            Return _SqlUser
        End Get
        Set(ByVal value As String)
            _SqlUser = value
        End Set
    End Property
    Private _SqlPass As String
    Public Property SqlPass() As String
        Get
            Return _SqlPass
        End Get
        Set(ByVal value As String)
            _SqlPass = value
        End Set
    End Property
    Private _SqlDataBase As String
    Public Property SqlDataBase() As String
        Get
            Return _SqlDataBase
        End Get
        Set(ByVal value As String)
            _SqlDataBase = value
        End Set
    End Property
End Class
Public Class ProductParams
    Enum EnCodeParts
        EnLastNum = 0
        Encategory = 1
        EnOmada = 2
        EnYpoomada = 3
        EnNothing = 100
    End Enum
    Private _ProductCodeReadOnly As Boolean
    Public Property ProductCodeReadOnly() As Boolean
        Get
            Return _ProductCodeReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ProductCodeReadOnly = value
        End Set
    End Property
    Private _ProductCodeSymbol As String
    Public Property ProductCodeSymbol() As String
        Get
            Return _ProductCodeSymbol
        End Get
        Set(ByVal value As String)
            _ProductCodeSymbol = value
        End Set
    End Property
    Private Property _FirstCodePart As EnCodeParts
    Public Property FirstCodePart() As EnCodeParts
        Get
            Return _FirstCodePart
        End Get
        Set(ByVal value As EnCodeParts)
            _FirstCodePart = value
        End Set
    End Property
    Private _SecondPart As EnCodeParts
    Public Property SecondPart() As EnCodeParts
        Get
            Return _SecondPart
        End Get
        Set(ByVal value As EnCodeParts)
            _SecondPart = value
        End Set
    End Property
    Private _ThirdPart As EnCodeParts
    Public Property ThirdPart() As EnCodeParts
        Get
            Return _ThirdPart
        End Get
        Set(ByVal value As EnCodeParts)
            _ThirdPart = value
        End Set
    End Property
    Private _ForthPart As EnCodeParts
    Public Property FortPart() As EnCodeParts
        Get
            Return _ForthPart
        End Get
        Set(ByVal value As EnCodeParts)
            _ForthPart = value
        End Set
    End Property
End Class
Public Class ClsTitle
    Private _Line1 As String
    Public Property Line1() As String
        Get
            Return _Line1
        End Get
        Set(ByVal value As String)
            _Line1 = value
        End Set
    End Property
    Private _Line2 As String
    Public Property Line2() As String
        Get
            Return _Line2
        End Get
        Set(ByVal value As String)
            _Line2 = value
        End Set
    End Property

    Private _Line3 As String
    Public Property Line3() As String
        Get
            Return _Line3
        End Get
        Set(ByVal value As String)
            _Line3 = value
        End Set
    End Property

    Private _Line4 As String
    Public Property Line4() As String
        Get
            Return _Line4
        End Get
        Set(ByVal value As String)
            _Line4 = value
        End Set
    End Property
    Private _Line5 As String
    Public Property Line5() As String
        Get
            Return _Line5
        End Get
        Set(ByVal value As String)
            _Line5 = value
        End Set
    End Property
End Class