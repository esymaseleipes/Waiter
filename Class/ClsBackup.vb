Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Compression
Imports DBOX

Public Class ClsBackup
    Shared WithEvents Sqlcmd As New SqlCommand
    Public SqlBackupDirectory As String = Application.StartupPath & "\Backup\"
    Public SqlBackupFile As String = "backup.bak"
    Public CompressDirectory As String = Application.StartupPath & "\Zip\"
    Public CompressFile As String = "backup.zip"

    Public Sub CreateDirectory(path As String)
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
    End Sub
    Public Sub DeleteDirectoryFiles(path As String)
        For Each deleteFile In Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next
    End Sub

    Public Async Function BackupDataBase() As Task
        Await (sql_backup(SqlBackupDirectory & SqlBackupFile))
    End Function
    Public Function CompressBackupFile() As Boolean
        Try
            ZipFile.CreateFromDirectory(SqlBackupDirectory, CompressDirectory & CompressFile)
            Return True
        Catch ex As Exception
            MsgBox("Zip Error:" & ex.Message)
            Return False
        End Try
    End Function






    Public Shared Async Function sql_backup(DestPath As String) As Task(Of Boolean)
        'Start.clsconnection.SqlConParams.SqlDataBase

        Dim strExecute As String
        'strExecute = "BACKUP DATABASE [" & Database & "] TO DISK = '" & DestPath & "'  WITH NOFORMAT, INIT,  SKIP, NOREWIND, NOUNLOAD, COMPRESSION,  STATS = 10"
        strExecute = "BACKUP DATABASE [" & Start.clsconnection.SqlConParams.SqlDataBase & "] TO DISK = '" & DestPath & "'  WITH NOFORMAT, INIT,  SKIP, NOREWIND, NOUNLOAD,  STATS = 10"



        Dim SqlConn As New SqlConnection
        Dim SqlConnStr As String = "Data Source=" & Start.clsconnection.SqlConParams.SqlServer & ";Persist Security Info=False;User ID=" & Start.clsconnection.SqlConParams.SqlUser & ";Password=" & Start.clsconnection.SqlConParams.SqlPass
        If SqlConn.State = ConnectionState.Closed Then
            SqlConn.ConnectionString = SqlConnStr
            Try
                Sqlcmd.CommandTimeout = 0
                SqlConn.Open()
                Sqlcmd.CommandType = CommandType.Text
                Sqlcmd.CommandText = strExecute
                Sqlcmd.Connection = SqlConn
                Sqlcmd.ExecuteNonQuery()
                Await Sqlcmd.ExecuteNonQueryAsync()
                Return True
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
                Return False
            End Try
        Else
            Return False
        End If
    End Function

End Class
