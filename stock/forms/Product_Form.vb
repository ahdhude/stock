
Imports System.Data.SqlClient


Public Class Product_Form
    Private Sub Product_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Call load_datagrid()


    End Sub







    'creates a dataset and assigns it to datagrid

    Sub load_datagrid()

        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)

        Dim cmd As New SqlClient.SqlCommand("select product_id,Product_name,Product_name_dhi,Product_description,Unit_symbol,category_name from Product INNER Join  Product_unit On Product.Unit = Product_unit.Unit_id INNER Join  Product_category On Product.Product_id = Product_category.Product_product_id INNER Join Category On Product_category.Category_category_id = Category.category_id", con)

        Dim adapter As New SqlDataAdapter()

        Dim table As New DataTable()
        con.Open()
        adapter.SelectCommand = cmd

        adapter.Fill(table)
        adapter.Dispose()
        cmd.Dispose()
        con.Close()


        datagrid_product.DataSource = table
        datagrid_product.Columns.Item(0).HeaderText = "id"
        datagrid_product.Columns.Item(1).HeaderText = "Name Eng"
        datagrid_product.Columns.Item(2).HeaderText = "Name Dhiv"
        datagrid_product.Columns.Item(3).HeaderText = "description"
        datagrid_product.Columns.Item(4).HeaderText = "Unit"
        datagrid_product.Columns.Item(5).HeaderText = "Category"
        datagrid_product.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader)



        ' dropdown_emp.ValueMember = "employee_id"
        'dropdown_emp.DisplayMember = "employee_name"



        con.Close()


    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

    End Sub
End Class