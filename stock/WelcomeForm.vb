Public Class WelcomeForm
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()

    End Sub

    Private Sub button_PO_Click(sender As Object, e As EventArgs) Handles button_PO.Click
        Dim f As stock_out = New stock_out

        f.TopLevel = False
        Panel6.AutoScroll = True



        Panel5.Controls.Add(f)
        f.Show()
        f.Parent = Panel6






    End Sub
End Class