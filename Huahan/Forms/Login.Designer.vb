<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.tb_login_name = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_login_password = New System.Windows.Forms.TextBox()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_login_name
        '
        Me.tb_login_name.Location = New System.Drawing.Point(124, 26)
        Me.tb_login_name.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_login_name.Name = "tb_login_name"
        Me.tb_login_name.Size = New System.Drawing.Size(187, 21)
        Me.tb_login_name.TabIndex = 0
        Me.tb_login_name.Text = "admin"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_login_password)
        Me.GroupBox1.Controls.Add(Me.tb_login_name)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(328, 83)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "密码："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "用户名："
        '
        'tb_login_password
        '
        Me.tb_login_password.Location = New System.Drawing.Point(124, 50)
        Me.tb_login_password.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_login_password.Name = "tb_login_password"
        Me.tb_login_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_login_password.Size = New System.Drawing.Size(187, 21)
        Me.tb_login_password.TabIndex = 1
        '
        'Button_Login
        '
        Me.Button_Login.Location = New System.Drawing.Point(300, 145)
        Me.Button_Login.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(77, 26)
        Me.Button_Login.TabIndex = 2
        Me.Button_Login.Text = "登录"
        Me.Button_Login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "天津货代企业EDI系统"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 200)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Login)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登录"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_login_name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_login_password As System.Windows.Forms.TextBox
    Friend WithEvents Button_Login As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
