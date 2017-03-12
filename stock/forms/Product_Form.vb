
Imports System.Data.SqlClient


Public Class Product_Form
    Dim valueslist As List(Of String) = New List(Of String)
    Dim validate_counter As Integer = 0
    Dim checked_cat As String
    Dim cat_id As Integer


    Private Sub Product_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Call load_datagrid()
        Call load_units()
        Label1.Text = datagrid_product.RowCount
        Label1.Hide()

        Call clear_fields()


    End Sub









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
        datagrid_product.Columns.Item(3).HeaderText = "Bar Code"
        datagrid_product.Columns.Item(4).HeaderText = "Unit"
        datagrid_product.Columns.Item(5).HeaderText = "Category"
        datagrid_product.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader)







        con.Close()


    End Sub







    'validate the fields

    Sub validate()
        Call check_cat()

        If txtbox_eng_name.Text = Nothing Then

            MessageBox.Show("Plase enter the name")
            txtbox_eng_name.Focus()
            validate_counter = 1

        ElseIf txtbox_dhiv_name.Text = Nothing Then

            MessageBox.Show("Plase enter the name")
            txtbox_dhiv_name.Focus()
            validate_counter = 1

        ElseIf txtbox_details.Text = Nothing Then
            MessageBox.Show("Plase enter the Details")
            txtbox_details.Focus()
            validate_counter = 1

        ElseIf combo_unit.Text = "Unit" Then
            MessageBox.Show("Plase Select A Unit")
            combo_unit.Focus()
            validate_counter = 1


        ElseIf checkbox_liyekiyumuge.Checked = False And checkbox_mudhaluge.Checked = False Then
            MessageBox.Show("Plase Select A Category")
            checkbox_liyekiyumuge.Focus()
            validate_counter = 1


        ElseIf datagrid_product.Rows(datagrid_product.CurrentRow.Index).Cells(1).Value = txtbox_eng_name.Text And
           datagrid_product.Rows(datagrid_product.CurrentRow.Index).Cells(5).Value = checked_cat Then











            validate_counter = 2




        Else

            validate_counter = 0


        End If








    End Sub







    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click


        Call validate()
        Call check_datagrid_duplicate()

        If validate_counter = 0 Then


            Call add_product()
            Label1.Text = datagrid_product.RowCount + 1
            Call add_product_cat()

            Call load_datagrid()



        Else

            validate_counter = 0

        End If




    End Sub




    'selected rows values into the data fields




    Sub load_units()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from product_unit", con)
        dr = cmd.ExecuteReader

        While dr.Read

            combo_unit.ValueMember = dr.Item(0)
            combo_unit.DisplayMember = dr.Item(1).ToString

            valueslist.Add(dr.Item(0))
            combo_unit.Items.Add(dr.Item(1).ToString)




        End While

        con.Close()


    End Sub


    'creates a dataset and assigns it to datagrid
    Private Sub datagrid_product_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagrid_product.RowHeaderMouseClick
        checkbox_liyekiyumuge.Checked = False
        checkbox_mudhaluge.Checked = False

        Label1.Text = datagrid_product.Rows(e.RowIndex).Cells(0).Value
        txtbox_eng_name.Text = datagrid_product.Rows(e.RowIndex).Cells(1).Value
        txtbox_dhiv_name.Text = datagrid_product.Rows(e.RowIndex).Cells(2).Value
        txtbox_details.Text = datagrid_product.Rows(e.RowIndex).Cells(3).Value


        combo_unit.SelectedIndex = combo_unit.FindString(datagrid_product.Rows(e.RowIndex).Cells(4).Value)

        If datagrid_product.Rows(e.RowIndex).Cells(5).Value = "Liyekiyumuge Stock" Then

            checkbox_liyekiyumuge.Checked = True
            checked_cat = "Liyekiyumuge Stock"
        Else
            checkbox_mudhaluge.Checked = True
            checked_cat = "Mudhaluge Stock"
        End If

    End Sub

    Private Sub checkbox_liyekiyumuge_OnChange(sender As Object, e As EventArgs) Handles checkbox_liyekiyumuge.OnChange
        checkbox_mudhaluge.Checked = False
        checked_cat = "Liyekiyumuge Stock"
        cat_id = 1

    End Sub

    Private Sub checkbox_mudhaluge_OnChange(sender As Object, e As EventArgs) Handles checkbox_mudhaluge.OnChange
        checkbox_liyekiyumuge.Checked = False
        checked_cat = "Mudhaluge Stock"
        cat_id = 2
    End Sub




    Sub add_product()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()



        Dim cmd As New SqlClient.SqlCommand("Insert into Product (Product_id,Product_name,Product_name_dhi,Product_description,Unit) values (@product_id,@product_name,@product_dhiv,@product_desc,@unit)", con)


        cmd.Parameters.Add("@product_id", SqlDbType.Int).Value = datagrid_product.RowCount + 1

        cmd.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = txtbox_eng_name.Text
        cmd.Parameters.Add("@product_dhiv", SqlDbType.NVarChar).Value = txtbox_dhiv_name.Text
        cmd.Parameters.Add("@product_desc", SqlDbType.VarChar).Value = txtbox_details.Text
        cmd.Parameters.Add("@unit", SqlDbType.Int).Value = combo_unit.SelectedIndex + 1




        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        con.Close()


    End Sub


    Sub add_product_cat()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()



        Dim cmd As New SqlClient.SqlCommand("Insert into Product_category(Category_category_id,Product_product_id) values (@category_id,@product_id)", con)

        cmd.Parameters.Add("@category_id", SqlDbType.Int).Value = cat_id
        cmd.Parameters.Add("@product_id", SqlDbType.Int).Value = datagrid_product.RowCount + 1




        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        con.Close()


    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        validate_counter = 0
        Call validate()
        Call check_datagrid_duplicate()

        If validate_counter = 1 Then
        Else
            Call update_product()
            Call update_product_cat()

            Call load_datagrid()

        End If




    End Sub




    Sub update_product()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()



        Dim cmd As New SqlClient.SqlCommand(" UPDATE Product SET Product_name = 
        @Product_name, Product_description = @Product_description, Unit = @Unit, 
        Product_name_dhi = @Product_name_dhi 
        WHERE (Product_id = @Product_id)", con)

        cmd.Parameters.Add("@Product_name", SqlDbType.NVarChar).Value = txtbox_eng_name.Text
        cmd.Parameters.Add("@Product_id", SqlDbType.Int).Value = Label1.Text
        cmd.Parameters.Add("@Product_description", SqlDbType.VarChar).Value = txtbox_details.Text
        cmd.Parameters.Add("@Unit", SqlDbType.Int).Value = combo_unit.SelectedIndex + 1
        cmd.Parameters.Add("@Product_name_dhi", SqlDbType.NVarChar).Value = txtbox_dhiv_name.Text


        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        con.Close()


    End Sub




    Sub update_product_cat()

        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()



        Dim cmd As New SqlClient.SqlCommand("Update Product_category
        SET Category_category_id = @category_id, Product_product_id =  @product_id Where Product_product_id =  @product_id ", con)


        Call check_cat()



        cmd.Parameters.Add("@category_id", SqlDbType.Int).Value = cat_id
        cmd.Parameters.Add("@Product_id", SqlDbType.Int).Value = Label1.Text



        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        con.Close()


    End Sub



    Sub check_cat()
        If checkbox_liyekiyumuge.Checked = True Then

            cat_id = 1
            checked_cat = "Liyekiyumuge Stock"
        Else
            cat_id = 2
            checked_cat = "Mudhaluge Stock"
        End If
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        Dim result As Integer = MessageBox.Show("Deleting the product might delete the existing records associated with this product DO NOT DELETE unless you are sure", "ARE YOU SURE? ", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Call delete_product_cat()
            Call delete_product()
            Call load_datagrid()
            Call clear_fields()

        End If







    End Sub







    Sub delete_product()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()



        Dim cmd As New SqlClient.SqlCommand("DELETE  From Product Where (Product_id = @Original_Product_id)", con)


        Call check_cat()



        cmd.Parameters.Add("@Original_Product_id", SqlDbType.Int).Value = Label1.Text



        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        con.Close()



    End Sub


    Sub delete_product_cat()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()



        Dim cmd As New SqlClient.SqlCommand("DELETE  From Product_category Where (Product_id = @Original_Product_id)", con)


        Call check_cat()



        cmd.Parameters.Add("@Original_Product_id", SqlDbType.Int).Value = Label1.Text



        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        con.Close()
    End Sub



    Sub clear_fields()

        txtbox_details.Text = Nothing
        txtbox_dhiv_name.Text = Nothing
        txtbox_eng_name.Text = Nothing
        combo_unit.Text = "Unit"

        checkbox_liyekiyumuge.Checked = False
        checkbox_mudhaluge.Checked = False



    End Sub


    Sub check_datagrid_duplicate()

        For index = 0 To datagrid_product.RowCount - 1
            If datagrid_product.Rows(index).Cells(3).Value = txtbox_details.Text Then
                validate_counter = 1
                MessageBox.Show("item already exist")


            End If
        Next




    End Sub
End Class