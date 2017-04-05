Public Class welcome
    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        Dim f As New Supplier_Form
        f.TopLevel = False

        f.Size = New System.Drawing.Size(200, 150)
        f.Location = New System.Drawing.Point(20, 20)
        f.WindowState = FormWindowState.Normal
        f.Visible = False
        Panel1.Controls.Add(f)
    End Sub
End Class