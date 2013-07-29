Public Class ChangePassword

    Public db As New SQLite1

    Private Sub Bt_save_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Save.Click
        If tb_new_password.Text <> tb_verify_password.Text Then
            MessageBox.Show("您两次输入的口令不一致，请重新填写", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_new_password.Text = ""
            tb_verify_password.Text = ""
            tb_new_password.Focus()
        End If

        db.Init()
        If Login.sha1test(tb_old_password.Text) <> db.systemtable.login_password Then
            MessageBox.Show("原密码错误！请重新输入。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb_old_password.Text = ""
            tb_old_password.Focus()
        Else
            db.ChangePassword(Login.sha1test(tb_new_password.Text))
            MessageBox.Show("密码修改成功，下次登录请输入新的密码。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        db.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ChangePassword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
