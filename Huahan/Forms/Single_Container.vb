Public Class Single_Container

    Public container_id As Integer = 0
    Public _vessel_id As Integer = 0
    Public container_detail As New DataSet
    Public port_basic As New DataSet

    Private Property _container_type As String
    Private Property _container_no As String
    Private Property _container_size As String
    Private Property _container_owen As String
    Private Property _seal_no As String
    Private Property _container_weight As Double
    Private Property _total_weight As Double
    Private Property _carrier As String
    Private Property _hbl_no As String
    Private Property _dis_port As String

    Public Property vessel_id As Integer
        Get
            Return _vessel_id
        End Get
        Set(value As Integer)
            _vessel_id = vessel_id
        End Set
    End Property


    Private Sub Single_Container_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim db As New SQLite1
        db.Init()

        '基本港
        port_basic = db.GetTableData("port_basic")
        Dim port_basic_acsc As New AutoCompleteStringCollection
        Dim drs() As DataRow
        drs = port_basic.Tables(0).Select()
        For Each dr In drs
            port_basic_acsc.Add(dr("port_name"))
        Next
        tb_dis_port.AutoCompleteCustomSource = port_basic_acsc
        tb_dis_port.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tb_dis_port.AutoCompleteSource = AutoCompleteSource.CustomSource

        'container_id
        If container_id <> 0 Then
            container_detail = db.GetTableData("container", _vessel_id)
            drs = container_detail.Tables(0).Select("container_id=" & container_id)
            If drs.Count = 1 Then
                tb_container_no.Text = drs(0)("container_no")
                cb_container_owen.Text = drs(0)("container_owen")
                'MessageBox.Show(drs(0)("container_size"))
                cb_container_size.Text = drs(0)("container_size")
                cb_container_type.Text = drs(0)("container_type")
                tb_dis_port.Text = drs(0)("dis_port")
                tb_hbl_no.Text = drs(0)("hbl_no")
                tb_total_weight.Text = drs(0)("total_weight")
                tb_container_weight.Text = drs(0)("container_weight")
                tb_seal_no.Text = drs(0)("seal_no")
                tb_carrier.Text = drs(0)("carrier")
            End If
        Else
            cb_container_size.SelectedIndex = 0
            cb_container_type.SelectedIndex = 0
        End If
        db.Close()


    End Sub

    Private Sub tb_container_no_LostFocus(sender As Object, e As System.EventArgs) Handles tb_container_no.LostFocus

    End Sub

    Private Sub tb_container_no_TextChanged(sender As System.Object, e As System.EventArgs) Handles tb_container_no.TextChanged

    End Sub

    Private Sub bt_save_Click(sender As System.Object, e As System.EventArgs) Handles bt_save.Click
        Dim db As New SQLite1
        Dim container As New DataSet
        Dim newrow As DataRow
        '各种检测
        If tb_container_no.Text <> "" Then

        End If

        db.Init()
        container = db.GetTableData("container", _vessel_id)
        If container_id <> 0 Then
            '更新
            newrow = container.Tables(0).Select("container_id=" & container_id)(0)
            newrow("container_no") = tb_container_no.Text
            newrow("container_type") = cb_container_type.Text
            newrow("container_size") = cb_container_size.Text
            newrow("container_owen") = cb_container_owen.Text
            newrow("seal_no") = tb_seal_no.Text
            newrow("container_weight") = tb_container_weight.Text
            newrow("total_weight") = tb_total_weight.Text
            newrow("carrier") = tb_carrier.Text
            newrow("hbl_no") = tb_hbl_no.Text
            newrow("dis_port") = tb_dis_port.Text
            newrow("vessel_id") = _vessel_id
            db.updatecontainer(container.Tables(0))
        Else
            '插入
            newrow = container.Tables(0).NewRow
            newrow("container_no") = tb_container_no.Text
            newrow("container_type") = cb_container_type.Text
            newrow("container_size") = cb_container_size.Text
            newrow("container_owen") = cb_container_owen.Text
            newrow("seal_no") = tb_seal_no.Text
            newrow("container_weight") = tb_container_weight.Text
            newrow("total_weight") = tb_total_weight.Text
            newrow("carrier") = tb_carrier.Text
            newrow("hbl_no") = tb_hbl_no.Text
            newrow("dis_port") = tb_dis_port.Text
            newrow("vessel_id") = _vessel_id
            container.Tables(0).Rows.Add(newrow)
            db.updatecontainer(container.Tables(0))
        End If
        db.Close()

        Me.Close()
    End Sub

    Private Sub bt_cancel_Click(sender As System.Object, e As System.EventArgs) Handles bt_cancel.Click
        Me.Close()
    End Sub
End Class