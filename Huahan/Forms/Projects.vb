Imports Microsoft.VisualBasic.DateAndTime

Public Class Projects

    Private Sub Projects_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized



        dgvrefresh()
    End Sub

    Private Sub tsb_new_vessel_Click(sender As System.Object, e As System.EventArgs) Handles tsb_new_vessel.Click
        Dim newproject As New Single_Project

        newproject.StartPosition = FormStartPosition.CenterScreen
        newproject.ShowDialog()
        dgvrefresh()
    End Sub

    Private Sub tsb_modify_vessel_Click(sender As System.Object, e As System.EventArgs) Handles tsb_modify_vessel.Click
        If DataGridView1.RowCount > 0 Then

            Single_Project._vessels_id = DataGridView1("id", DataGridView1.CurrentRow.Index).Value
            Single_Project.StartPosition = FormStartPosition.CenterScreen
            Single_Project.ShowDialog()
            dgvrefresh()
        End If
    End Sub

    Private Sub dgvrefresh()
        Dim db As New SQLite1
        db.Init()
        Dim tabledata As Object
        tabledata = db.GetTableData("vessels")
        If IsDBNull(tabledata) Then
            MessageBox.Show("xxx")
            Exit Sub
        End If

        tabledata.Tables(0).Columns(0).ColumnName = "ID"
        tabledata.Tables(0).Columns(1).ColumnName = "英文船名"
        tabledata.Tables(0).Columns(2).ColumnName = "中文船名"
        tabledata.Tables(0).Columns(3).ColumnName = "航次"
        tabledata.Tables(0).Columns(4).ColumnName = "离港日期"
        tabledata.Tables(0).Columns(5).ColumnName = "集港日期"
        tabledata.Tables(0).Columns(6).ColumnName = "结关日期"
        tabledata.Tables(0).Columns(7).ColumnName = "船号"
        'Dim aa As DataSet
        tabledata.Tables(0).DefaultView.Sort = "离港日期 desc"
        DataGridView1.DataSource = tabledata.tables(0)
        Dim dgrc As DataGridViewColumn
        For Each dgrc In DataGridView1.Columns
            dgrc.ReadOnly = True
        Next
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.Beige
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque
        DataGridView1.Select()

        DataGridView1.AutoResizeColumns()
        db.Close()

    End Sub

    Private Sub tsb_delete_vessel_Click(sender As System.Object, e As System.EventArgs) Handles tsb_delete_vessel.Click
        Dim db As New SQLite1
        Dim vessels As New DataSet
        Dim delrows() As DataRow
        Dim dgvr As DataGridViewRow
        db.Init()
        vessels = db.GetTableData("vessels")
        For Each dgvr In DataGridView1.SelectedRows
            delrows = vessels.Tables(0).Select("id=" & DataGridView1("id", dgvr.Index).Value)
            delrows(0).Delete()
        Next
        db.updatevessels(vessels.Tables(0))
        db.Close()

        dgvrefresh()
    End Sub

    Private Sub tsb_all_selected_Click(sender As System.Object, e As System.EventArgs) Handles tsb_all_selected.Click
        Dim dgvr As DataGridViewRow
        For Each dgvr In DataGridView1.Rows
            dgvr.Selected = True
        Next
    End Sub

    Private Sub tsb_unselected_Click(sender As System.Object, e As System.EventArgs) Handles tsb_unselected.Click
        Dim dgvr As DataGridViewRow
        For Each dgvr In DataGridView1.Rows
            dgvr.Selected = Not (dgvr.Selected)
        Next
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim container_load As New Loading
        'MessageBox.Show(DataGridView1("id", DataGridView1.CurrentRow.Index).Value.ToString)
        container_load._vessel_id = DataGridView1("id", DataGridView1.CurrentRow.Index).Value
        container_load.MdiParent = MDImain
        container_load.Show()
    End Sub

    Private Sub ToolStripSplitButton2_ButtonClick(sender As System.Object, e As System.EventArgs) Handles ToolStripSplitButton2.ButtonClick
        ToolStripSplitButton2.ShowDropDown()
    End Sub

End Class