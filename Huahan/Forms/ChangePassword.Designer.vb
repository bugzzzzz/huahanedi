<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.tb_old_password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_new_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_verify_password = New System.Windows.Forms.TextBox()
        Me.Bt_Save = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "原口令："
        '
        'tb_old_password
        '
        Me.tb_old_password.Location = New System.Drawing.Point(156, 37)
        Me.tb_old_password.Name = "tb_old_password"
        Me.tb_old_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_old_password.Size = New System.Drawing.Size(154, 21)
        Me.tb_old_password.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "新口令："
        '
        'tb_new_password
        '
        Me.tb_new_password.Location = New System.Drawing.Point(156, 75)
        Me.tb_new_password.Name = "tb_new_password"
        Me.tb_new_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_new_password.Size = New System.Drawing.Size(154, 21)
        Me.tb_new_password.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "确认新口令："
        '
        'tb_verify_password
        '
        Me.tb_verify_password.Location = New System.Drawing.Point(156, 114)
        Me.tb_verify_password.Name = "tb_verify_password"
        Me.tb_verify_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_verify_password.Size = New System.Drawing.Size(154, 21)
        Me.tb_verify_password.TabIndex = 5
        '
        'Bt_Save
        '
        Me.Bt_Save.Location = New System.Drawing.Point(125, 173)
        Me.Bt_Save.Name = "Bt_Save"
        Me.Bt_Save.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Save.TabIndex = 6
        Me.Bt_Save.Text = "保存"
        Me.Bt_Save.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(235, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 247)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Bt_Save)
        Me.Controls.Add(Me.tb_verify_password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_new_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_old_password)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "修改口令"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_old_password As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_new_password As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_verify_password As System.Windows.Forms.TextBox
    Friend WithEvents Bt_Save As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
