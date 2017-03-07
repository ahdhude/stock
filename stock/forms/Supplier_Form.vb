Imports System.Data.SqlClient

Public Class Supplier_Form






    Sub load_datgrid()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)

        Dim cmd As New SqlClient.SqlCommand("select supplier_id,supplier_name,supplier_contact FROM supplier", con)

        Dim adapter As New SqlDataAdapter()

        Dim table As New DataTable()
        con.Open()
        adapter.SelectCommand = cmd

        adapter.Fill(table)
        adapter.Dispose()
        cmd.Dispose()
        con.Close()


        DataGrid_supplier.DataSource = table
        DataGrid_supplier.Columns.Item(0).HeaderText = "Supplier ID"
        DataGrid_supplier.Columns.Item(1).HeaderText = "Supplier Name"
        DataGrid_supplier.Columns.Item(2).HeaderText = "Contact"
        DataGrid_supplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader)







        con.Close()
    End Sub


    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

    End Sub

    Private Sub Supplier_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_datgrid()

    End Sub
End Class