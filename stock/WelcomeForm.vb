Public Class WelcomeForm
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()

    End Sub

    Private Sub button_PO_Click(sender As Object, e As EventArgs) Handles button_PO.Click
        Dim f As New stock_out
        f.TopLevel = False



        Panel5.Controls.Add(f)



    End Sub
End Class