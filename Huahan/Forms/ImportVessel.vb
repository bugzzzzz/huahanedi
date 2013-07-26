Imports System.Text.RegularExpressions
Imports System.IO

Public Class ImportVessel

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim req As System.Net.HttpWebRequest
        req = System.Net.WebRequest.Create("http://218.69.89.53/CD_QRY/qry_vessel_code.aspx")

        Dim res As System.Net.HttpWebResponse = req.GetResponse
        res.GetResponseStream()
        Dim sr As StreamReader = New StreamReader(res.GetResponseStream(), System.Text.Encoding.GetEncoding("GB18030"))
        Dim html As String = sr.ReadToEnd().Trim()

        Dim j As Integer = 0
        Dim db As New SQLite1
        db.Init()
        Dim tabledata As New DataTable
        tabledata.TableName = "vessel_basic"
        tabledata.Columns.Add("vessel_code")
        tabledata.Columns.Add("vessel_english_name")
        tabledata.Columns.Add("import_voyage")
        tabledata.Columns.Add("export_voyage")
        Dim dr As DataRow
        For Each mm As Match In Regex.Matches(html, "<font color=""#003366"">(?'a'\d{6})</font></td><td><font color=""#003366"">(?'b'.*)</font></td><td><font color=""#003366"">(?'c'.*)</font></td><td><font color=""#003366"">(?'d'.*)</font></td>")
            dr = tabledata.NewRow
            dr("vessel_code") = mm.Groups.Item("a").Value
            dr("vessel_english_name") = mm.Groups.Item("b").Value
            dr("import_voyage") = mm.Groups.Item("c").Value
            dr("export_voyage") = mm.Groups.Item("d").Value
            tabledata.Rows.Add(dr)

            j = j + 1
        Next
        db.updatevesselbasic(tabledata)
        db.Close()
    End Sub

    Private Sub ImportVessel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 100

    End Sub
End Class