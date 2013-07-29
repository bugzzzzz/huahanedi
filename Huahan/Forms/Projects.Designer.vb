<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Projects
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Projects))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsb_new_vessel = New System.Windows.Forms.ToolStripButton()
        Me.tsb_modify_vessel = New System.Windows.Forms.ToolStripButton()
        Me.tsb_delete_vessel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsb_all_selected = New System.Windows.Forms.ToolStripButton()
        Me.tsb_unselected = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.收货订单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.装箱订单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.放行信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.预配舱单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_new_vessel, Me.tsb_modify_vessel, Me.tsb_delete_vessel, Me.ToolStripSeparator1, Me.tsb_all_selected, Me.tsb_unselected, Me.ToolStripSeparator2, Me.ToolStripSplitButton1, Me.ToolStripSplitButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(889, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsb_new_vessel
        '
        Me.tsb_new_vessel.Image = CType(resources.GetObject("tsb_new_vessel.Image"), System.Drawing.Image)
        Me.tsb_new_vessel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_new_vessel.Name = "tsb_new_vessel"
        Me.tsb_new_vessel.Size = New System.Drawing.Size(85, 24)
        Me.tsb_new_vessel.Text = "新建计划"
        '
        'tsb_modify_vessel
        '
        Me.tsb_modify_vessel.Image = CType(resources.GetObject("tsb_modify_vessel.Image"), System.Drawing.Image)
        Me.tsb_modify_vessel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_modify_vessel.Name = "tsb_modify_vessel"
        Me.tsb_modify_vessel.Size = New System.Drawing.Size(85, 24)
        Me.tsb_modify_vessel.Text = "修改计划"
        '
        'tsb_delete_vessel
        '
        Me.tsb_delete_vessel.Image = CType(resources.GetObject("tsb_delete_vessel.Image"), System.Drawing.Image)
        Me.tsb_delete_vessel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_delete_vessel.Name = "tsb_delete_vessel"
        Me.tsb_delete_vessel.Size = New System.Drawing.Size(85, 24)
        Me.tsb_delete_vessel.Text = "删除计划"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tsb_all_selected
        '
        Me.tsb_all_selected.Image = CType(resources.GetObject("tsb_all_selected.Image"), System.Drawing.Image)
        Me.tsb_all_selected.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_all_selected.Name = "tsb_all_selected"
        Me.tsb_all_selected.Size = New System.Drawing.Size(57, 24)
        Me.tsb_all_selected.Text = "全选"
        '
        'tsb_unselected
        '
        Me.tsb_unselected.Image = CType(resources.GetObject("tsb_unselected.Image"), System.Drawing.Image)
        Me.tsb_unselected.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_unselected.Name = "tsb_unselected"
        Me.tsb_unselected.Size = New System.Drawing.Size(57, 24)
        Me.tsb_unselected.Text = "反选"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.收货订单ToolStripMenuItem, Me.装箱订单ToolStripMenuItem, Me.放行信息ToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(97, 24)
        Me.ToolStripSplitButton1.Text = "生成报表"
        '
        '收货订单ToolStripMenuItem
        '
        Me.收货订单ToolStripMenuItem.Name = "收货订单ToolStripMenuItem"
        Me.收货订单ToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.收货订单ToolStripMenuItem.Text = "收货订单"
        '
        '装箱订单ToolStripMenuItem
        '
        Me.装箱订单ToolStripMenuItem.Name = "装箱订单ToolStripMenuItem"
        Me.装箱订单ToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.装箱订单ToolStripMenuItem.Text = "装箱订单"
        '
        '放行信息ToolStripMenuItem
        '
        Me.放行信息ToolStripMenuItem.Name = "放行信息ToolStripMenuItem"
        Me.放行信息ToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.放行信息ToolStripMenuItem.Text = "放行信息"
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.预配舱单ToolStripMenuItem})
        Me.ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(92, 24)
        Me.ToolStripSplitButton2.Text = "生成EDI"
        '
        '预配舱单ToolStripMenuItem
        '
        Me.预配舱单ToolStripMenuItem.Name = "预配舱单ToolStripMenuItem"
        Me.预配舱单ToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.预配舱单ToolStripMenuItem.Text = "预配舱单"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 32)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(889, 464)
        Me.DataGridView1.TabIndex = 1
        '
        'Projects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 501)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Projects"
        Me.Text = "装箱计划"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsb_new_vessel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsb_modify_vessel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsb_delete_vessel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents 收货订单ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 装箱订单ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 放行信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents 预配舱单ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsb_all_selected As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsb_unselected As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
