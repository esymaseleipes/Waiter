Public Class ClsRegKeys
    Public Shared Property PrinterKey As String = "NrgErp\Printers"
    Public Shared Property PrinterKeyFullPath As String = "HKEY_CURRENT_USER\" & PrinterKey

    Public Shared Property PrintServicesKey As String = "NrgErp\PrintServices"
    Public Shared Property PrintServicesKeyFullPath As String = "HKEY_CURRENT_USER\" & PrintServicesKey

End Class
