Public Class stock_out
    Private Sub stock_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load data into dropdown 

        Dim dataReader As SqlDataReader
        dataReader = sqlCmd.ExecuteReader()
        While dataReader.Read
            ' Write code to insert an Item into dropdownlist
            DropDownItem1.Items.Add(dataReader("City").ToString())
        End While
        dataReader.Close()



    End Sub
End Class