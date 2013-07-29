<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Single_Project
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_chn_name = New System.Windows.Forms.TextBox()
        Me.dtp_open_date = New System.Windows.Forms.DateTimePicker()
        Me.dtp_close_date = New System.Windows.Forms.DateTimePicker()
        Me.dtp_dep_date = New System.Windows.Forms.DateTimePicker()
        Me.tb_eng_name = New System.Windows.Forms.TextBox()
        Me.tb_voyage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_vessel_code = New System.Windows.Forms.TextBox()
        Me.bt_save = New System.Windows.Forms.Button()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.bt_auto_get_vessel_code = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "英文船名："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "中文船名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(24, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "出口航次："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(24, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "离港日期："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 205)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "结关时间："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 169)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "集港时间："
        '
        'tb_chn_name
        '
        Me.tb_chn_name.Location = New System.Drawing.Point(119, 56)
        Me.tb_chn_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_chn_name.Name = "tb_chn_name"
        Me.tb_chn_name.Size = New System.Drawing.Size(265, 26)
        Me.tb_chn_name.TabIndex = 7
        '
        'dtp_open_date
        '
        Me.dtp_open_date.Location = New System.Drawing.Point(119, 164)
        Me.dtp_open_date.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtp_open_date.Name = "dtp_open_date"
        Me.dtp_open_date.Size = New System.Drawing.Size(265, 26)
        Me.dtp_open_date.TabIndex = 13
        '
        'dtp_close_date
        '
        Me.dtp_close_date.Location = New System.Drawing.Point(119, 200)
        Me.dtp_close_date.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtp_close_date.Name = "dtp_close_date"
        Me.dtp_close_date.Size = New System.Drawing.Size(265, 26)
        Me.dtp_close_date.TabIndex = 15
        '
        'dtp_dep_date
        '
        Me.dtp_dep_date.Location = New System.Drawing.Point(119, 128)
        Me.dtp_dep_date.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtp_dep_date.Name = "dtp_dep_date"
        Me.dtp_dep_date.Size = New System.Drawing.Size(265, 26)
        Me.dtp_dep_date.TabIndex = 11
        '
        'tb_eng_name
        '
        Me.tb_eng_name.Location = New System.Drawing.Point(119, 20)
        Me.tb_eng_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_eng_name.Name = "tb_eng_name"
        Me.tb_eng_name.Size = New System.Drawing.Size(265, 26)
        Me.tb_eng_name.TabIndex = 5
        '
        'tb_voyage
        '
        Me.tb_voyage.Location = New System.Drawing.Point(119, 92)
        Me.tb_voyage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_voyage.Name = "tb_voyage"
        Me.tb_voyage.Size = New System.Drawing.Size(265, 26)
        Me.tb_voyage.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 239)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "船号："
        '
        'tb_vessel_code
        '
        Me.tb_vessel_code.Location = New System.Drawing.Point(119, 236)
        Me.tb_vessel_code.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_vessel_code.Name = "tb_vessel_code"
        Me.tb_vessel_code.Size = New System.Drawing.Size(265, 26)
        Me.tb_vessel_code.TabIndex = 17
        '
        'bt_save
        '
        Me.bt_save.Location = New System.Drawing.Point(56, 292)
        Me.bt_save.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(100, 32)
        Me.bt_save.TabIndex = 16
        Me.bt_save.Text = "保存"
        Me.bt_save.UseVisualStyleBackColor = True
        '
        'bt_cancel
        '
        Me.bt_cancel.Location = New System.Drawing.Point(267, 292)
        Me.bt_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(100, 32)
        Me.bt_cancel.TabIndex = 17
        Me.bt_cancel.Text = "取消"
        Me.bt_cancel.UseVisualStyleBackColor = True
        '
        'bt_auto_get_vessel_code
        '
        Me.bt_auto_get_vessel_code.Location = New System.Drawing.Point(383, 236)
        Me.bt_auto_get_vessel_code.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bt_auto_get_vessel_code.Name = "bt_auto_get_vessel_code"
        Me.bt_auto_get_vessel_code.Size = New System.Drawing.Size(25, 26)
        Me.bt_auto_get_vessel_code.TabIndex = 18
        Me.bt_auto_get_vessel_code.Text = "?"
        Me.bt_auto_get_vessel_code.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(392, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "*请不要输入空格"
        '
        'Single_Project
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 358)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.bt_auto_get_vessel_code)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_save)
        Me.Controls.Add(Me.tb_vessel_code)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_voyage)
        Me.Controls.Add(Me.tb_eng_name)
        Me.Controls.Add(Me.dtp_dep_date)
        Me.Controls.Add(Me.dtp_close_date)
        Me.Controls.Add(Me.dtp_open_date)
        Me.Controls.Add(Me.tb_chn_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Single_Project"
        Me.Text = "Single_Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_chn_name As System.Windows.Forms.TextBox
    Friend WithEvents dtp_open_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_close_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_dep_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_eng_name As System.Windows.Forms.TextBox
    Friend WithEvents tb_voyage As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_vessel_code As System.Windows.Forms.TextBox
    Friend WithEvents bt_save As System.Windows.Forms.Button
    Friend WithEvents bt_cancel As System.Windows.Forms.Button
    Friend WithEvents bt_auto_get_vessel_code As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
