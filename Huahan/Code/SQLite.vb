Imports System.Data.SQLite


Public Class SQLite1
    Public _test As String
    Public db As New SQLiteConnection
    Public systemtable As New edi.systemtable

    Public Property test As String
        Get
            Return _test
        End Get
        Set(ByVal Value As String)
            _test = Value
        End Set
    End Property

    Public Sub Init()
        Dim connstr As String
        Dim querystr As String
        Dim rs As New SQLiteDataAdapter
        Dim dr As SQLiteDataReader
        Dim cmd As New SQLiteCommand

        connstr = "Data Source=c:\tddownload\1.db;Pooling=true;FailIfMissing=false"
        db.ConnectionString = connstr
        db.Open()
        
        querystr = "select value from system where name='login_name'"
        cmd.CommandText = "select * from system"
        cmd.Connection = db
        dr = cmd.ExecuteReader
        Do While dr.Read()
            Select Case dr.GetString(0)
                Case "login_name"
                    systemtable.login_name = dr.GetString(1)
                Case ("login_password")
                    systemtable.login_password = dr.GetString(1)
            End Select
        Loop
    End Sub

    Public Sub Close()
        db.Close()
    End Sub
End Class
