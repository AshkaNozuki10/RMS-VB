Imports System.Data.SqlClient

Module dbconn

    Public connStr As String = "Data Source=DESKTOP-BLDBJKI;Initial Catalog=POSDB;Integrated Security=True"
    Public conn As New SqlConnection(connStr)

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function

    Function disconnect()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Return True
    End Function

End Module
