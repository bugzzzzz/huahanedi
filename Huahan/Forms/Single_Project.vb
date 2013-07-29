Imports Microsoft.VisualBasic.DateAndTime

Public Class Single_Project

    Public vessel_basic As New DataSet
    Public vessels As New DataSet
    Public Property _vessels_id As Integer
    Private Property _eng_name As String
    Private Property _chn_name As String
    Private Property _voyage As String
    Private Property _vessel_code As String
    Private Property _open_date As DateTime
    Private Property _close_date As DateTime
    Private Property _dep_date As DateTime

    Public Property vessels_id As Integer
        Get
            Return _vessels_id
        End Get
        Set(value As Integer)
            _vessels_id = vessels_id
        End Set
    End Property

    Private Sub Single_Project_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim db As New SQLite1
        db.Init()

        Dim drs() As DataRow
        Dim dr As DataRow
        vessel_basic = db.GetTableData("vessel_basic")
        If IsDBNull(vessel_basic) Then
            MessageBox.Show("")
            db.Close()
            Exit Sub
        Else
            db.Close()
        End If

        Dim vessel As New AutoCompleteStringCollection
        drs = vessel_basic.Tables(0).Select()
        For Each dr In drs
            vessel.Add(dr("vessel_english_name"))
        Next

        tb_eng_name.AutoCompleteCustomSource = vessel
        tb_eng_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tb_eng_name.AutoCompleteSource = AutoCompleteSource.CustomSource

        tb_voyage.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tb_voyage.AutoCompleteSource = AutoCompleteSource.CustomSource


        '三个时间控件初始时间
        dtp_open_date.Value = "2000-1-1"
        dtp_close_date.Value = "2000-1-1"
        dtp_dep_date.Value = "2000-1-1"
        If _vessels_id <> 0 Then
            'Dim db As New SQLite1
            db.Init()
            vessels = db.GetTableData("vessels")
            drs = vessels.Tables(0).Select("id=" & vessels_id)
            If drs.Count = 1 Then
                _eng_name = drs(0)("eng_name")
                _chn_name = drs(0)("chn_name")
                _voyage = drs(0)("voyage")
                _open_date = drs(0)("open_date")
                _close_date = drs(0)("close_date")
                _dep_date = drs(0)("dep_date")
                _vessel_code = drs(0)("vessel_code")

                tb_eng_name.Text = _eng_name
                tb_chn_name.Text = _chn_name
                tb_voyage.Text = _voyage
                dtp_open_date.Value = _open_date
                dtp_close_date.Value = _close_date
                dtp_dep_date.Value = _dep_date
                tb_vessel_code.Text = _vessel_code
            End If
            db.Close()
        End If

    End Sub

    Private Sub bt_auto_get_vessel_code_Click(sender As System.Object, e As System.EventArgs) Handles bt_auto_get_vessel_code.Click
        If tb_eng_name.Text <> "" And tb_voyage.Text <> "" Then
            Dim drs() As DataRow
            drs = vessel_basic.Tables(0).Select("vessel_english_name='" & tb_eng_name.Text & "' and export_voyage='" & tb_voyage.Text & "'")
            If drs.Count = 1 Then
                tb_vessel_code.Text = drs(0)("vessel_code")
            Else
                MessageBox.Show("")
            End If
        Else
            MessageBox.Show("")
        End If
    End Sub

    Private Sub tb_eng_name_LostFocus(sender As Object, e As System.EventArgs) Handles tb_eng_name.LostFocus
        Dim voyage As New AutoCompleteStringCollection
        Dim drs() As DataRow
        Dim dr As DataRow
        drs = vessel_basic.Tables(0).Select("vessel_english_name='" & tb_eng_name.Text & "'", "export_voyage")
        For Each dr In drs
            voyage.Add(dr("export_voyage"))
        Next
        tb_voyage.AutoCompleteCustomSource = voyage
    End Sub


    Private Sub bt_cancel_Click(sender As System.Object, e As System.EventArgs) Handles bt_cancel.Click
        Me.Close()
    End Sub

    Private Sub bt_save_Click(sender As System.Object, e As System.EventArgs) Handles bt_save.Click
        Dim newrow As DataRow
        Dim drs() As DataRow
        Dim db As New SQLite1
        If tb_eng_name.Text = "" Then
            MessageBox.Show("")
            tb_eng_name.Focus()
            Exit Sub
        End If

        If tb_voyage.Text = "" Then
            MessageBox.Show("")
            tb_voyage.Focus()
            Exit Sub
        End If
        If (Year(dtp_dep_date.Value) = 2000) And (Month(dtp_dep_date.Value) = 1) And (Day(dtp_dep_date.Value) = 1) Then
            MessageBox.Show("")
            dtp_dep_date.Focus()
            Exit Sub
        End If
        'MessageBox.Show(dtp_open_date.Value.ToString)
        If _vessels_id = 0 Then
            '插入

            db.Init()
            vessels = db.GetTableData("vessels")
            newrow = vessels.Tables(0).NewRow
            newrow("eng_name") = tb_eng_name.Text
            newrow("chn_name") = tb_chn_name.Text
            newrow("voyage") = tb_voyage.Text
            newrow("open_date") = dtp_open_date.Value
            newrow("close_date") = dtp_close_date.Value
            newrow("dep_date") = dtp_dep_date.Value
            newrow("vessel_code") = tb_vessel_code.Text
            vessels.Tables(0).Rows.Add(newrow)
            db.updatevessels(vessels.Tables(0))
            db.Close()
        Else
            '更新
            db.Init()
            vessels = db.GetTableData("vessels")
            drs = vessels.Tables(0).Select("id=" & _vessels_id)
            If drs.Count = 1 Then
                drs(0)("eng_name") = tb_eng_name.Text
                drs(0)("chn_name") = tb_chn_name.Text
                drs(0)("voyage") = tb_voyage.Text
                drs(0)("open_date") = dtp_open_date.Value
                drs(0)("close_date") = dtp_close_date.Value
                drs(0)("dep_date") = dtp_dep_date.Value
                drs(0)("vessel_code") = tb_vessel_code.Text
            End If
            db.updatevessels(vessels.Tables(0))
            db.Close()
        End If
        Me.Close()
    End Sub

End Class