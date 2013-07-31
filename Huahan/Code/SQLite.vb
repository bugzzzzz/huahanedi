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

    Public Function GetTableData(table_name As String, Optional ByVal par2 As String = "") As Object
        Dim returndataset As New DataSet
        Dim querystr As String

        Select Case table_name
            Case "vessels"
                querystr = "select * from vessels"
            Case "vessel_basic"
                querystr = "select * from vessel_basic"
            Case "container"
                querystr = "select * from container where vessel_id=" & par2
            Case "port_basic"
                querystr = "select * from port_basic"
            Case Else
                querystr = ""
        End Select

        If querystr <> "" Then
            Dim da As New SQLiteDataAdapter(querystr, db)
            da.Fill(returndataset)
            Return (returndataset)
            returndataset.Tables(0).Select()
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

    Public Sub updatevessels(dt As DataTable)
        Dim da As New SQLiteDataAdapter("select * from vessels", db)
        da.InsertCommand = New SQLiteCommand("insert into vessels(eng_name, chn_name, voyage, open_date, close_date, dep_date, vessel_code) values(@eng_name, @chn_name, @voyage, @open_date, @close_date, @dep_date, @vessel_code)", db)
        da.InsertCommand.Parameters.Add("@eng_name", DbType.String, 40, "eng_name")
        da.InsertCommand.Parameters.Add("@chn_name", DbType.String, 40, "chn_name")
        da.InsertCommand.Parameters.Add("@voyage", DbType.String, 20, "voyage")
        da.InsertCommand.Parameters.Add("@open_date", DbType.DateTime, 0, "open_date")
        da.InsertCommand.Parameters.Add("@close_date", DbType.DateTime, 0, "close_date")
        da.InsertCommand.Parameters.Add("@dep_date", DbType.DateTime, 0, "dep_date")
        da.InsertCommand.Parameters.Add("@vessel_code", DbType.String, 40, "vessel_code")

        da.DeleteCommand = New SQLiteCommand("delete from vessels where id=@id", db)
        da.DeleteCommand.Parameters.Add("@id", DbType.Int32, 0, "id")

        da.UpdateCommand = New SQLiteCommand("update vessels set eng_name=@eng_name, chn_name=@chn_name, voyage=@voyage, open_date=@open_date, close_date=@close_date, dep_date=@dep_date, vessel_code=@vessel_code where id=@id", db)
        da.UpdateCommand.Parameters.Add("@id", DbType.Int32, 0, "id")
        da.UpdateCommand.Parameters.Add("@eng_name", DbType.String, 40, "eng_name")
        da.UpdateCommand.Parameters.Add("@chn_name", DbType.String, 40, "chn_name")
        da.UpdateCommand.Parameters.Add("@voyage", DbType.String, 20, "voyage")
        da.UpdateCommand.Parameters.Add("@open_date", DbType.DateTime, 0, "open_date")
        da.UpdateCommand.Parameters.Add("@close_date", DbType.DateTime, 0, "close_date")
        da.UpdateCommand.Parameters.Add("@dep_date", DbType.DateTime, 0, "dep_date")
        da.UpdateCommand.Parameters.Add("@vessel_code", DbType.String, 40, "vessel_code")

        da.Update(dt)
    End Sub

    Public Sub updatecontainer(dt As DataTable)
        Dim da As New SQLiteDataAdapter("select * from container", db)
        da.InsertCommand = New SQLiteCommand("insert into container(container_no, container_type, container_size, container_owen," & _
                                             "seal_no, container_weight, total_weight, carrier, hbl_no, dis_port, vessel_id) values(@container_no," & _
                                             "@container_type, @container_size, @container_owen, @seal_no, @container_weight," & _
                                             "@total_weight, @carrier, @hbl_no, @dis_port, @vessel_id)", db)
        da.InsertCommand.Parameters.Add("@container_no", DbType.String, 11, "container_no")
        da.InsertCommand.Parameters.Add("@container_type", DbType.String, 6, "container_type")
        da.InsertCommand.Parameters.Add("@container_size", DbType.String, 2, "container_size")
        da.InsertCommand.Parameters.Add("@container_owen", DbType.String, 20, "container_owen")
        da.InsertCommand.Parameters.Add("@seal_no", DbType.String, 20, "seal_no")
        da.InsertCommand.Parameters.Add("@container_weight", DbType.Double, 0, "container_weight")
        da.InsertCommand.Parameters.Add("@total_weight", DbType.Double, 0, "total_weight")
        da.InsertCommand.Parameters.Add("@carrier", DbType.String, 20, "carrier")
        da.InsertCommand.Parameters.Add("@hbl_no", DbType.String, 20, "hbl_no")
        da.InsertCommand.Parameters.Add("@dis_port", DbType.String, 30, "dis_port")
        da.InsertCommand.Parameters.Add("@vessel_id", DbType.Int32, 0, "vessel_id")

        da.DeleteCommand = New SQLiteCommand("delete from container where container_id=@container_id", db)
        da.DeleteCommand.Parameters.Add("@container_id", DbType.Int32, 0, "container_id")

        da.UpdateCommand = New SQLiteCommand("update container set container_no=@container_no, container_type=@container_type, container_size=@container_size," & _
                                             " container_owen=@container_owen, seal_no=@seal_no, container_weight=@container_weight, total_weight=@total_weight," & _
                                             "carrier=@carrier, hbl_no=@hbl_no, dis_port=@dis_port, vessel_id=@vessel_id where container_id=@container_id", db)
        da.UpdateCommand.Parameters.Add("@container_no", DbType.String, 11, "container_no")
        da.UpdateCommand.Parameters.Add("@container_type", DbType.String, 6, "container_type")
        da.UpdateCommand.Parameters.Add("@container_size", DbType.String, 2, "container_size")
        da.UpdateCommand.Parameters.Add("@container_owen", DbType.String, 20, "container_owen")
        da.UpdateCommand.Parameters.Add("@seal_no", DbType.String, 20, "seal_no")
        da.UpdateCommand.Parameters.Add("@container_weight", DbType.Double, 0, "container_weight")
        da.UpdateCommand.Parameters.Add("@total_weight", DbType.Double, 0, "total_weight")
        da.UpdateCommand.Parameters.Add("@carrier", DbType.String, 20, "carrier")
        da.UpdateCommand.Parameters.Add("@hbl_no", DbType.String, 20, "hbl_no")
        da.UpdateCommand.Parameters.Add("@dis_port", DbType.String, 30, "dis_port")
        da.UpdateCommand.Parameters.Add("@vessel_id", DbType.Int32, 0, "vessel_id")
        da.UpdateCommand.Parameters.Add("@container_id", DbType.Int32, 0, "container_id")

        da.Update(dt)
    End Sub

    Public Function ctn_no_calc(ctn_no As String) As Integer
        ctn_no_calc = 0
        For i = 1 To 10
            ctn_no_calc = ctn_no_calc + word_to_number(Mid(ctn_no, i, 1)) * 2 ^ (i - 1)
        Next
        ctn_no_calc = ctn_no_calc Mod 11
        If ctn_no_calc = 10 Then ctn_no_calc = 0
    End Function

    Public Function word_to_number(word As Char) As Integer
        Select Case word
            Case "A"
                Return 10
            Case "B"
                Return 12
            Case "C"
                Return 13
            Case "D"
                Return 14
            Case "E"
                Return 15
            Case "F"
                Return 16
            Case "G"
                Return 17
            Case "H"
                Return 18
            Case "I"
                Return 19
            Case "J"
                Return 20
            Case "K"
                Return 21
            Case "L"
                Return 23
            Case "M"
                Return 24
            Case "N"
                Return 25
            Case "O"
                Return 26
            Case "P"
                Return 27
            Case "Q"
                Return 28
            Case "R"
                Return 29
            Case "S"
                Return 30
            Case "T"
                Return 31
            Case "U"
                Return 32
            Case "V"
                Return 34
            Case "W"
                Return 35
            Case "X"
                Return 36
            Case "Y"
                Return 37
            Case "Z"
                Return 38
            Case Else
                Return Microsoft.VisualBasic.Val(word)
        End Select
    End Function
End Class
