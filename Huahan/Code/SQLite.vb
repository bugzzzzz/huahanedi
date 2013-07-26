Imports System.Data.SQLite


Public Class SQLite1
    Public _test As String
    Public db As New SQLiteConnection
    Public systemtable As New edi.systemtable
    Dim connstr As String = "Data Source=c:\tddownload\1.db;Pooling=true;FailIfMissing=false"

    Public Property test As String
        Get
            Return _test
        End Get
        Set(ByVal Value As String)
            _test = Value
        End Set
    End Property

    Public Sub Init()
        Dim querystr As String
        'Dim rs As New SQLiteDataAdapter
        Dim dr As SQLiteDataReader
        Dim cmd As New SQLiteCommand

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

    Public Function ChangePassword(new_password As String) As Boolean
        'db.ConnectionString = connstr
        'db.Open()

        Dim cmd As New SQLiteCommand
        Dim querystr As String

        querystr = "update system set value=@login_password where name='login_password'"
        cmd.CommandText = querystr
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@login_password", DbType.String)
        cmd.Parameters(0).Value = new_password
        cmd.Connection = db
        cmd.ExecuteNonQuery()

        Return True
    End Function

    Public Function GetTableData(table_name As String) As Object
        Dim returndataset As New DataSet
        Dim querystr As String

        Select Case table_name
            Case "vessels"
                querystr = "select * from vessels"
            Case Else
                querystr = ""
        End Select

        If querystr <> "" Then
            Dim da As New SQLiteDataAdapter(querystr, db)
            da.Fill(returndataset)
            Return (returndataset)
        Else
            Return System.DBNull.Value
        End If
    End Function

    Public Sub updatevesselbasic(dt As DataTable)
        Dim cmd As New SQLite.SQLiteCommand
        Dim querystr As String
        querystr = "delete from vessel_basic"
        cmd.CommandText = querystr
        cmd.CommandType = CommandType.Text
        cmd.Connection = db
        cmd.ExecuteNonQuery()

        Dim da As New SQLiteDataAdapter("select * from vessel_basic", db)
        da.InsertCommand = New SQLiteCommand("insert into vessel_basic(vessel_code, vessel_english_name, import_voyage, export_voyage) values(@vessel_code, @vessel_english_name, @import_voyage, @export_voyage)", db)
        da.InsertCommand.Parameters.Add("@vessel_code", DbType.String, 6, "vessel_code")
        da.InsertCommand.Parameters.Add("@vessel_english_name", DbType.String, 50, "vessel_english_name")
        da.InsertCommand.Parameters.Add("@import_voyage", DbType.String, 10, "import_voyage")
        da.InsertCommand.Parameters.Add("@export_voyage", DbType.String, 10, "export_voyage")
        da.Update(dt)
    End Sub
End Class
