<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Single_Container
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_container_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cb_container_size = New System.Windows.Forms.ComboBox()
        Me.cb_container_type = New System.Windows.Forms.ComboBox()
        Me.cb_container_owen = New System.Windows.Forms.ComboBox()
        Me.tb_seal_no = New System.Windows.Forms.TextBox()
        Me.tb_container_weight = New System.Windows.Forms.TextBox()
        Me.tb_total_weight = New System.Windows.Forms.TextBox()
        Me.tb_carrier = New System.Windows.Forms.TextBox()
        Me.tb_hbl_no = New System.Windows.Forms.TextBox()
        Me.tb_dis_port = New System.Windows.Forms.TextBox()
        Me.bt_save = New System.Windows.Forms.Button()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "提单号："
        '
        'tb_container_no
        '
        Me.tb_container_no.Location = New System.Drawing.Point(193, 38)
        Me.tb_container_no.MaxLength = 11
        Me.tb_container_no.Name = "tb_container_no"
        Me.tb_container_no.Size = New System.Drawing.Size(196, 26)
        Me.tb_container_no.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "箱号："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "箱型："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "尺寸："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "箱主："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(125, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "封号："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(125, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "箱重："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(125, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "总重："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(111, 314)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "承运人："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(111, 392)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "卸货港："
        '
        'cb_container_size
        '
        Me.cb_container_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_container_size.FormattingEnabled = True
        Me.cb_container_size.Items.AddRange(New Object() {"20", "40"})
        Me.cb_container_size.Location = New System.Drawing.Point(193, 77)
        Me.cb_container_size.Name = "cb_container_size"
        Me.cb_container_size.Size = New System.Drawing.Size(196, 28)
        Me.cb_container_size.TabIndex = 11
        '
        'cb_container_type
        '
        Me.cb_container_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_container_type.FormattingEnabled = True
        Me.cb_container_type.Items.AddRange(New Object() {"20GP", "20RF", "40GP", "40HQ"})
        Me.cb_container_type.Location = New System.Drawing.Point(193, 116)
        Me.cb_container_type.Name = "cb_container_type"
        Me.cb_container_type.Size = New System.Drawing.Size(196, 28)
        Me.cb_container_type.TabIndex = 12
        '
        'cb_container_owen
        '
        Me.cb_container_owen.FormattingEnabled = True
        Me.cb_container_owen.Location = New System.Drawing.Point(193, 155)
        Me.cb_container_owen.Name = "cb_container_owen"
        Me.cb_container_owen.Size = New System.Drawing.Size(196, 28)
        Me.cb_container_owen.TabIndex = 13
        '
        'tb_seal_no
        '
        Me.tb_seal_no.Location = New System.Drawing.Point(193, 194)
        Me.tb_seal_no.Name = "tb_seal_no"
        Me.tb_seal_no.Size = New System.Drawing.Size(196, 26)
        Me.tb_seal_no.TabIndex = 14
        '
        'tb_container_weight
        '
        Me.tb_container_weight.Location = New System.Drawing.Point(193, 233)
        Me.tb_container_weight.Name = "tb_container_weight"
        Me.tb_container_weight.Size = New System.Drawing.Size(196, 26)
        Me.tb_container_weight.TabIndex = 15
        '
        'tb_total_weight
        '
        Me.tb_total_weight.Location = New System.Drawing.Point(193, 272)
        Me.tb_total_weight.Name = "tb_total_weight"
        Me.tb_total_weight.Size = New System.Drawing.Size(196, 26)
        Me.tb_total_weight.TabIndex = 16
        '
        'tb_carrier
        '
        Me.tb_carrier.Location = New System.Drawing.Point(193, 311)
        Me.tb_carrier.Name = "tb_carrier"
        Me.tb_carrier.Size = New System.Drawing.Size(196, 26)
        Me.tb_carrier.TabIndex = 17
        '
        'tb_hbl_no
        '
        Me.tb_hbl_no.Location = New System.Drawing.Point(193, 350)
        Me.tb_hbl_no.Name = "tb_hbl_no"
        Me.tb_hbl_no.Size = New System.Drawing.Size(196, 26)
        Me.tb_hbl_no.TabIndex = 18
        '
        'tb_dis_port
        '
        Me.tb_dis_port.Location = New System.Drawing.Point(193, 389)
        Me.tb_dis_port.Name = "tb_dis_port"
        Me.tb_dis_port.Size = New System.Drawing.Size(196, 26)
        Me.tb_dis_port.TabIndex = 19
        '
        'bt_save
        '
        Me.bt_save.Location = New System.Drawing.Point(90, 453)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(89, 31)
        Me.bt_save.TabIndex = 20
        Me.bt_save.Text = "保存"
        Me.bt_save.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.Location = New System.Drawing.Point(272, 453)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(88, 31)
        Me.bt_cancel.TabIndex = 21
        Me.bt_cancel.Text = "取消"
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'Single_Container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 534)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_save)
        Me.Controls.Add(Me.tb_dis_port)
        Me.Controls.Add(Me.tb_hbl_no)
        Me.Controls.Add(Me.tb_carrier)
        Me.Controls.Add(Me.tb_total_weight)
        Me.Controls.Add(Me.tb_container_weight)
        Me.Controls.Add(Me.tb_seal_no)
        Me.Controls.Add(Me.cb_container_owen)
        Me.Controls.Add(Me.cb_container_type)
        Me.Controls.Add(Me.cb_container_size)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_container_no)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Single_Container"
        Me.Text = "Single_Container"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_container_no As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cb_container_size As System.Windows.Forms.ComboBox
    Friend WithEvents cb_container_type As System.Windows.Forms.ComboBox
    Friend WithEvents cb_container_owen As System.Windows.Forms.ComboBox
    Friend WithEvents tb_seal_no As System.Windows.Forms.TextBox
    Friend WithEvents tb_container_weight As System.Windows.Forms.TextBox
    Friend WithEvents tb_total_weight As System.Windows.Forms.TextBox
    Friend WithEvents tb_carrier As System.Windows.Forms.TextBox
    Friend WithEvents tb_hbl_no As System.Windows.Forms.TextBox
    Friend WithEvents tb_dis_port As System.Windows.Forms.TextBox
    Friend WithEvents bt_save As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
