Public Class WelcomeForm


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()

    End Sub

    Private Sub button_PO_Click(sender As Object, e As EventArgs) Handles button_PO.Click



        Module_scan.stock_out.TopLevel = False
        Panel6.AutoScroll = True



        Panel5.Controls.Add(Module_scan.stock_out)

        Module_scan.stock_out.Parent = Panel6

        Module_scan.stock_out.Show()





    End Sub


End Class