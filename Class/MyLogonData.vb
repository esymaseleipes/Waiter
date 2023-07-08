Imports DevExpress.Xpo
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class MyLogonData
    Public Property LogonDate As Date
    Public Property LogonUserId As Integer
    Private _logonUser As MyUsers
    Public Property LogonUser() As MyUsers
        Get
            Return _logonUser
        End Get
        Set(ByVal value As MyUsers)
            _logonUser = value
            LogonUserId = value.Oid
        End Set
    End Property

    Public Property MainCnfg() As MainCnfg

    Public Property LogonCompany As SUBSIDS
    Public Sub New()

        Dim ses As Session = New Session(Kefdal)
        MainCnfg = New MainCnfg With {
            .DiscDecBin = 2,
            .PriceDecBit = 2,
            .QuantDecBit = 2,
            .ValueDecBit = 2,
            .ProductCngf = New ProductCngf With {
            .LastBuyPriceContainDisc = False
        }
        }
    End Sub
    Public Sub New(dal As IDataLayer)

        MainCnfg = New MainCnfg With {
            .DiscDecBin = 2,
            .PriceDecBit = 2,
            .QuantDecBit = 2,
            .ValueDecBit = 2,
            .ProductCngf = New ProductCngf With {
            .LastBuyPriceContainDisc = False
        }
        }
    End Sub
    Public Function GetCurrentDate() As Date
        Return DateTime.UtcNow
    End Function
    Public Function GetCurrentTime() As Date
        Return DateTime.UtcNow
    End Function

End Class

Public Class MainCnfg
    Public Property QuantDecBit() As Integer
    Public Property PriceDecBit() As Integer
    Public Property ValueDecBit() As Integer
    Public Property DiscDecBin() As Integer
    Public Property GsisCode() As GsisCodes
    Public Property ProductCngf() As ProductCngf
End Class
Public Class GsisCodes
    Public Property UserName() As String
    Public Property UserPassword() As String
    Public Property RelVat() As String
End Class
Public Class ProductCngf
    Public Property LastBuyPriceContainDisc() As Boolean
End Class
