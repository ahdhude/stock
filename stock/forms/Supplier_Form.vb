Imports System.Data.SqlClient

Public Class Supplier_Form
    Dim valueslist As List(Of String) = New List(Of String)
    Dim validate_counter As Integer = 0





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
        Call validate()
        Call check_datagrid_duplicate()

        If validate_counter = 0 Then
            Call add_product()
            Label1.Text = DataGrid_supplier.RowCount + 1

            Call load_datgrid()
        Else
            validate_counter = 0


        End If
    End Sub

    Private Sub Supplier_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call load_datgrid()
        Label1.Text = DataGrid_supplier.RowCount
        Label1.Hide()


    End Sub



    Sub validate()

        If txtbox_details.Text = Nothing Then

            MessageBox.Show("Plase enter contact number")
            txtbox_details.Focus()
            validate_counter = 1
        ElseIf txtbox_eng_name.Text = Nothing Then
            MessageBox.Show("Plase enter supplier english name")
            txtbox_eng_name.Focus()
            validate_counter = 1

        ElseIf txtbox_supplier_dhiv_name.Text = Nothing Then
            MessageBox.Show("Plase enter supplier dhivehi name")
            txtbox_eng_name.Focus()
            validate_counter = 1



        Else

        End If




    End Sub



    Sub check_datagrid_duplicate()

        For index = 0 To DataGrid_supplier.RowCount - 1
            If DataGrid_supplier.Rows(index).Cells(1).Value = txtbox_eng_name.Text Then
                validate_counter = 1
                MessageBox.Show("item already exist")


            End If
        Next




    End Sub


    Sub add_product()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()



        Dim cmd As New SqlClient.SqlCommand("Insert into Supplier (Supplier_name,supplier_dhiv_name,supplier_Contact) values (@Supplier_name,@supplier_dhiv_name,@supplier_Contact)", con)




        cmd.Parameters.Add("@Supplier_name", SqlDbType.NVarChar).Value = txtbox_eng_name.Text
        cmd.Parameters.Add("@supplier_dhiv_name", SqlDbType.NVarChar).Value = txtbox_supplier_dhiv_name.Text
        cmd.Parameters.Add("@supplier_Contact", SqlDbType.Int).Value = txtbox_details.Text





        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        con.Close()



    End Sub
End Class