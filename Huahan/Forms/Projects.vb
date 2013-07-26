Public Class Projects

    Private Sub Projects_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim test As DataSet

        Me.WindowState = FormWindowState.Maximized

        Dim db As New SQLite1
        db.Init()
        Dim tabledata As Object
        tabledata = db.GetTableData("vessels")
        If IsDBNull(tabledata) Then
            MessageBox.Show("xxx")

        End If

        tabledata.Tables(0).Columns(0).ColumnName = "ID"
        tabledata.Tables(0).Columns(1).ColumnName = "英文船名"
        tabledata.Tables(0).Columns(2).ColumnName = "中文船名"
        tabledata.Tables(0).Columns(3).ColumnName = "航次"
        tabledata.Tables(0).Columns(4).ColumnName = "离港日期"
        tabledata.Tables(0).Columns(5).ColumnName = "集港日期"
        tabledata.Tables(0).Columns(6).ColumnName = "结关日期"
        tabledata.Tables(0).Columns(7).ColumnName = "船号"

        DataGridView1.DataSource = tabledata.tables(0)
        'DataGridView1.RowsDefaultCellStyle.BackColor = Color.Beige
        'DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque
        DataGridView1.AutoResizeColumns()
        db.Close()

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Single_Project.ShowDialog()

    End Sub
End Class