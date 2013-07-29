Public Class Loading

    Public _container_id As Integer = 0

    Public Property container_id As Integer
        Get
            Return _container_id
        End Get
        Set(value As Integer)
            _container_id = container_id
        End Set
    End Property

    Private Sub Loading_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If _container_id <> 0 Then
            Dim db As New SQLite1
            Dim container As DataSet

            db.Init()
            container = db.GetTableData("container")
            DataGridView1.DataSource = container.Tables(0).Select("container_id=" & _container_id)

            db.Close()

        End If
    End Sub

    Private Sub Loading_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
        'DataGridView1.Top = SplitContainer1.Panel1.Top + ToolStrip1.Height
        'DataGridView1.Left = SplitContainer1.Panel1.Left
        'DataGridView1.Width = SplitContainer1.Panel1.Width
        'DataGridView1.Height = SplitContainer1.Panel1.Height - ToolStrip1.Height

        'DataGridView2.Top = SplitContainer1.Panel2.Top + ToolStrip2.Height
        'DataGridView2.Left = SplitContainer1.Panel2.Left
        'DataGridView2.Width = SplitContainer1.Panel2.Width
        'DataGridView2.Height = SplitContainer1.Panel2.Height - ToolStrip2.Height
    End Sub

    Private Sub tsb_new_container_Click(sender As System.Object, e As System.EventArgs) Handles tsb_new_container.Click

    End Sub
End Class