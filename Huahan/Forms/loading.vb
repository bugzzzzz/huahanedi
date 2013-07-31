Public Class Loading

    Public _vessel_id As Integer = 0

    Public Property vessel_id As Integer
        Get
            Return _vessel_id
        End Get
        Set(value As Integer)
            _vessel_id = vessel_id
        End Set
    End Property

    Private Sub Loading_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If _vessel_id <> 0 Then
            dgvrefresh()

        End If
        'MessageBox.Show(_vessel_id.ToString)
    End Sub

    Private Sub Loading_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged

    End Sub

    Private Sub tsb_new_container_Click(sender As System.Object, e As System.EventArgs) Handles tsb_new_container.Click
        Dim new_container As New Single_Container
        new_container._vessel_id = vessel_id
        new_container.StartPosition = FormStartPosition.CenterScreen
        new_container.ShowDialog()
        dgvrefresh()
    End Sub

    Private Sub tsb_modify_container_Click(sender As System.Object, e As System.EventArgs) Handles tsb_modify_container.Click
        If DataGridView1.Rows.Count > 0 Then
            Dim modify_container As New Single_Container
            modify_container.StartPosition = FormStartPosition.CenterScreen
            modify_container._vessel_id = vessel_id
            modify_container.container_id = DataGridView1("id", DataGridView1.CurrentRow.Index).Value
            modify_container.ShowDialog()
            dgvrefresh()
        End If
    End Sub

    Private Sub tsb_delete_container_Click(sender As System.Object, e As System.EventArgs) Handles tsb_delete_container.Click
        Dim db As New SQLite1
        Dim container As New DataSet
        Dim delrows() As DataRow
        Dim dgvr As DataGridViewRow
        db.Init()
        container = db.GetTableData("container", _vessel_id)
        For Each dgvr In DataGridView1.SelectedRows
            delrows = container.Tables(0).Select("container_id=" & DataGridView1("id", dgvr.Index).Value)
            delrows(0).Delete()
        Next
        db.updatecontainer(container.Tables(0))
        db.Close()

        dgvrefresh()
    End Sub

    Private Sub dgvrefresh()
        Dim db As New SQLite1
        db.Init()
        Dim tabledata As Object
        tabledata = db.GetTableData("container", _vessel_id)
        If IsDBNull(tabledata) Then
            MessageBox.Show("xxx")
            Exit Sub
        End If

        tabledata.Tables(0).Columns("container_id").ColumnName = "ID"
        tabledata.Tables(0).Columns("container_no").ColumnName = "箱号"
        tabledata.Tables(0).Columns("container_type").ColumnName = "箱型"
        tabledata.Tables(0).Columns("container_size").ColumnName = "尺寸"
        tabledata.Tables(0).Columns("container_owen").ColumnName = "箱主"
        tabledata.Tables(0).Columns("seal_no").ColumnName = "封号"
        tabledata.Tables(0).Columns("container_weight").ColumnName = "箱重"
        tabledata.Tables(0).Columns("total_weight").ColumnName = "总重"
        tabledata.tables(0).columns("carrier").columnname = "承运人"
        tabledata.tables(0).columns("hbl_no").columnname = "提单号"
        tabledata.tables(0).columns("dis_port").columnname = "卸货港"

        
        DataGridView1.DataSource = tabledata.tables(0)
        Dim dgrc As DataGridViewColumn
        For Each dgrc In DataGridView1.Columns
            dgrc.ReadOnly = True
        Next
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.Beige
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque
        DataGridView1.Columns("vessel_id").Visible = False
        DataGridView1.Select()

        DataGridView1.AutoResizeColumns()
        db.Close()


    End Sub

    Private Sub ToolStripSplitButton2_ButtonClick(sender As System.Object, e As System.EventArgs) Handles ToolStripSplitButton2.ButtonClick
        ToolStripSplitButton2.ShowDropDown()
    End Sub

End Class