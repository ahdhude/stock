Public Class WelcomeForm


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()

    End Sub

    Private Sub button_PO_Click(sender As Object, e As EventArgs) Handles button_PO.Click

        Panel6.Controls.Clear()


        Module_scan.stock_out.TopLevel = False
        Panel6.AutoScroll = True



        Panel5.Controls.Add(Module_scan.stock_out)

        Module_scan.stock_out.Parent = Panel6

        Module_scan.stock_out.Show()





    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Panel6.Controls.Clear()

        Module_scan.product_form.TopLevel = False
        Panel6.AutoScroll = True



        Panel5.Controls.Add(Module_scan.product_form)

        Module_scan.product_form.Parent = Panel6

        Module_scan.product_form.Show()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Panel6.Controls.Clear()

        Module_scan.supplier_form.TopLevel = False
        Panel6.AutoScroll = True



        Panel5.Controls.Add(Module_scan.supplier_form)

        Module_scan.supplier_form.Parent = Panel6

        Module_scan.supplier_form.Show()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Panel6.Controls.Clear()

        Module_scan.po_form.TopLevel = False
        Panel6.AutoScroll = True



        Panel5.Controls.Add(Module_scan.po_form)

        Module_scan.po_form.Parent = Panel6

        Module_scan.po_form.Show()
    End Sub
End Class