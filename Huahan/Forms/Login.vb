Imports System.Security.Cryptography
Imports System.Security


Public Class Login

    Public db As New SQLite1

    Private Sub Login_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed
        db.Close()

    End Sub

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        db.Init()
        
    End Sub

    Private Sub Button_Login_Click(sender As System.Object, e As System.EventArgs) Handles Button_Login.Click
        
        If tb_login_name.Text <> db.systemtable.login_name Then
            MessageBox.Show("用户名错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If sha1test(tb_login_password.Text) <> db.systemtable.login_password Then
            MessageBox.Show("密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        MDImain.Show()
        Me.Visible = False
    End Sub

    Public Function sha1test(str As String) As String
        Dim sha As SHA1
        Dim crypebyte As Byte()
        Dim bytetemp As Byte()
        Dim returnstr As New System.Text.StringBuilder

        bytetemp = System.Text.Encoding.Default.GetBytes(str)

        If str = "" Then Return ""

        sha = SHA1.Create
        crypebyte = sha.ComputeHash(bytetemp)

        For i = 0 To crypebyte.Length - 1
            returnstr.Append(crypebyte(i).ToString("x2"))
        Next

        Return returnstr.ToString
    End Function

    Private Sub md5test()
        Dim sh1 As MD5
        Dim crypebyte As Byte()
        Dim str As Byte()
        Dim str1 As New System.Text.StringBuilder

        str = System.Text.Encoding.Default.GetBytes("admin")

        sh1 = MD5.Create()
        crypebyte = sh1.ComputeHash(str)

        'str1 = System.Text.Encoding.ASCII.GetString(crypebyte)
        For i = 0 To 15
            'str1 = str1 & Hex(crypebyte(i))
            str1.Append(crypebyte(i).ToString("x2"))
        Next
    End Sub
End Class
