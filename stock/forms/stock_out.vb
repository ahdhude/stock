Public Class stock_out
    Private Sub stock_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LBMSTOCKDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.LBMSTOCKDataSet.Product)







    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub



    Private Sub textbox_details_MouseClick(sender As Object, e As MouseEventArgs) Handles textbox_details.MouseClick

        'change language direction to right to left 

        textbox_details.TextAlign = HorizontalAlignment.Right

    End Sub
End Class