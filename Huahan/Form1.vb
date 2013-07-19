Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Main.EditMenu.Visible = True
    End Sub

    Private Sub Form1_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
        Main.EditMenu.Visible = False
    End Sub
End Class
