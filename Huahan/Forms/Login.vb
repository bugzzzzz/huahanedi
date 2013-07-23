Imports System.Security.Cryptography
Imports System.Security


Public Class Login

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        
    End Sub

    Private Sub Button_Login_Click(sender As System.Object, e As System.EventArgs) Handles Button_Login.Click
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

    Private Sub sha1test()
        Dim sh2 As SHA1
        Dim crypebyte As Byte()
        Dim str As Byte()
        Dim str1 As New System.Text.StringBuilder

        str = System.Text.Encoding.Default.GetBytes("admin")

        sh2 = SHA1.Create
        crypebyte = sh2.ComputeHash(str)

        For i = 0 To crypebyte.Length - 1
            str1.Append(crypebyte(i).ToString("x2"))
        Next
        Debug.Print(str1.ToString)
    End Sub
End Class
