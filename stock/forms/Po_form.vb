Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading
Imports System.IO
Imports Infragistics.UltraGauge.Resources
Imports System.Data.SqlClient

Public Class Po_form
    Dim image_id As Integer
    Dim last_Po As Integer
    Dim last_product_id As Integer
    Dim last_product As String
    Dim po_exist As Integer



    Dim product_exit_grid As Integer

    Dim valueslist As List(Of String) = New List(Of String)
    Dim list1 As New ArrayList

    Dim list2 As New ArrayList



    Dim selected_item As Integer
    Dim selected_item_qty As Integer
    Dim slected_stri As String


    Dim validate_product_counter As Integer = 0


    Dim validate_counter As Integer = 0

    Dim x As Integer = 0

    Private Sub Po_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        upload_path.Hide()


        Dim current_user As String
        Dim po_path As String

        current_user = Environment.UserName

        po_path = "C:\Users\" + current_user + "\Documents\PO"

        grf_cons_path = po_path


        If (Not System.IO.Directory.Exists(po_path)) Then
            System.IO.Directory.CreateDirectory(po_path)
        End If





        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from product", con)
        dr = cmd.ExecuteReader

        While dr.Read

            combo_product.ValueMember = dr.Item(0)
            combo_product.DisplayMember = dr.Item(1).ToString

            valueslist.Add(dr.Item(0))
            combo_product.Items.Add(dr.Item(1).ToString)




        End While

        con.Close()

        Call load_suppliers()


    End Sub

    Private Sub textbox_details_Leave(sender As Object, e As EventArgs) Handles textbox_details.Leave
        System.Windows.Forms.InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(0)

        If textbox_details.Text = Nothing Then
            textbox_details.TextAlign = HorizontalAlignment.Left
            textbox_details.Font = New Font("Century Gothic", 11.25, FontStyle.Regular)
        End If
    End Sub

    Private Sub textbox_details_Enter(sender As Object, e As EventArgs) Handles textbox_details.Enter
        'change language direction to right to left 

        textbox_details.TextAlign = HorizontalAlignment.Right
        System.Windows.Forms.InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(1)
        textbox_details.Font = New Font("faruma", 12, FontStyle.Regular)

    End Sub

    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating
        If e.ColumnIndex = 0 Then



        ElseIf e.ColumnIndex = 1 Then

            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGridView1.Rows(e.RowIndex).ErrorText = "Cannot be empty"
                e.Cancel = True

            ElseIf Not IsNumeric(e.FormattedValue) Or (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then

                DataGridView1.Rows(e.RowIndex).ErrorText = "Please enter a number"
                e.Cancel = True



            End If

        ElseIf e.ColumnIndex = 2 Then

            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGridView1.Rows(e.RowIndex).ErrorText = "Cannot be empty"
                e.Cancel = True

            ElseIf Not IsNumeric(e.FormattedValue) Or (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then

                DataGridView1.Rows(e.RowIndex).ErrorText = "Please enter a number"
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        If DataGridView1.CurrentCell.Value = Nothing Then



        Else
            DataGridView1.Rows.Remove(DataGridView1.Rows(e.RowIndex))

        End If
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseDoubleClick
        DataGridView1.AllowUserToAddRows = True
    End Sub

    Private Sub DataGridView1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        DataGridView1.AllowUserToAddRows = False
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        DataGridView1.CurrentRow.Selected = True
    End Sub



    Public Sub load_suppliers()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)

        Dim cmd As New SqlClient.SqlCommand("select * from supplier", con)
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()

        con.Open()
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        adapter.Dispose()
        cmd.Dispose()
        con.Close()


        dropdown_supplier.DataSource = ds.Tables(0)
        dropdown_supplier.ValueMember = "supplier_id"
        dropdown_supplier.DisplayMember = "supplier_name"



        con.Close()
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        If textbox_po_num.Text = Nothing Or textbox_po_num.Text = "PO Number" Then

            MsgBox("please enter a valid PO number First")
            textbox_po_num.Focus()
        Else

            scan_file_name = textbox_po_num.Text





            Dim f As New Scan_form


            f.Show()


        End If

    End Sub

    Private Sub dropdown_supplier_ValueChanged(sender As Object, e As EventArgs) Handles dropdown_supplier.ValueChanged
        If dropdown_supplier.Text = "Supplier" Then
        Else



        End If
    End Sub

    Private Sub upload_path_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles upload_path.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString)
    End Sub

    Private Sub dropdown_supplier_MouseEnter(sender As Object, e As EventArgs) Handles dropdown_supplier.MouseEnter
        textbox_po_num.Enabled = True

    End Sub

    Private Sub textbox_qty_req_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textbox_qty_req.KeyPress

        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub textbox_qty_giv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textbox_qty_giv.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub txtbox_unit_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_unit_price.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Call product_add_validation()

        If validate_product_counter = 0 Then
            DataGridView1.AllowUserToAddRows = True
            Dim row As String() = New String() {combo_product.Text, textbox_qty_req.Text, textbox_qty_giv.Text, txtbox_unit_price.Text}
            DataGridView1.Rows.Add(row)
            Call into_array()

        Else

            validate_product_counter = 0

        End If




        DataGridView1.AllowUserToAddRows = False
        combo_product.Text = Nothing
        textbox_qty_giv.Text = Nothing
        textbox_qty_req.Text = Nothing



    End Sub



    Sub product_add_validation()
        validate_counter = 0

        Call check_item_exit_grid()




        Dim combo As String = combo_product.Text


        If combo_product.Items.Contains(combo_product.Text) = False Or combo_product.Text = Nothing Then

            validate_product_counter = 1
            combo_product.Focus()
            MessageBox.Show("Please enter a valid value")



        ElseIf textbox_qty_req.Text = Nothing Then
            validate_product_counter = 1
            textbox_qty_req.Focus()
            MessageBox.Show("Please enter a valid value")


        ElseIf textbox_qty_giv.Text = Nothing Then
            validate_product_counter = 1
            textbox_qty_giv.Focus()
            MessageBox.Show("Please enter a valid value")

        ElseIf textbox_qty_giv.Text = Nothing Then

            validate_product_counter = 1
            textbox_qty_giv.Focus()
            MessageBox.Show("Please enter a valid value")

        ElseIf CInt(textbox_qty_giv.Text) > (textbox_qty_req.Text) Then

            validate_product_counter = 1
            textbox_qty_giv.Focus()
            MessageBox.Show("Please enter a valid value")




        ElseIf product_exit_grid = 1 Then
            MsgBox("Item already added")
            validate_product_counter = 1

        ElseIf textbox_po_num.Text = Nothing Then
            MsgBox("Please Enter a valid GRF number ")
            validate_product_counter = 1

        ElseIf upload_path.Text = "LinkLabel1" Then

            MsgBox("Please Scan the PO ")
            validate_product_counter = 1

        Else




        End If



    End Sub


    Sub validation()

        If dropdown_supplier.Text = Nothing Then
            MessageBox.Show("Please select a name")
            dropdown_supplier.Focus()

        ElseIf upload_path.Text = "LinkLabel" Then
            MessageBox.Show("please scan the document")

        ElseIf textbox_details.Text = Nothing Then
            MessageBox.Show("Please enter Details")
            textbox_details.Focus()


        ElseIf DataGridView1.RowCount = 0 Then

            MsgBox("please add an item ")


        Else

            Call Process()


        End If


    End Sub


    Sub process()




        Call imagetodb()

        Call datatodb()

        Call DG_todb()

        Call sucess()





    End Sub

    Private Sub btn_process_Click(sender As Object, e As EventArgs) Handles btn_process.Click
        Call validation()
    End Sub




    Sub imagetodb()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim scan_image As Image = Image.FromFile(grf_cons_path + "\" + upload_path.Text)
        Dim ms As New MemoryStream
        scan_image.Save(ms, scan_image.RawFormat)

        Dim cmd As New SqlClient.SqlCommand("INSERT INTO PO_PHOTO ( PO_photo) VALUES(@POphoto)", con)

        cmd.Parameters.Add("@POphoto", SqlDbType.Image).Value = ms.ToArray()

        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        con.Close()



    End Sub



    Sub datatodb()
        Call check_po_existence()

        If po_exist = 1 Then

            MessageBox.Show("PO already Exist")
            Exit Sub


        End If


        Call get_last_imageid()

        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)


        Dim cmd As New SqlClient.SqlCommand("INSERT INTO PurchaseOrder (Po_num, Po_description, order_date, supplier_supplier_id,po_photo) VALUES(@PO_Number,@PO_description,@order_date,@supplier_id,@po_photo)", con)



        con.Open()



        cmd.Parameters.AddWithValue("@po_Number", textbox_po_num.Text.ToString)
        cmd.Parameters.AddWithValue("@PO_description", textbox_details.Text.ToString)
        cmd.Parameters.AddWithValue("@order_date", textbox_date.Value.ToString)
        cmd.Parameters.AddWithValue("@supplier_id", dropdown_supplier.SelectedItem.DataValue)
        cmd.Parameters.AddWithValue("@po_photo", image_id)


        cmd.ExecuteNonQuery()
        Call array_toDB()


        con.Close()


    End Sub


    Sub get_last_imageid()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM  PO_PHOTO WHERE Id = (SELECT MAX(Id) FROM PO_PHOTO)", con)

        dr = cmd.ExecuteReader

        While dr.Read

            image_id = dr.Item(0)

        End While


        con.Close()

    End Sub

    Sub get_last_po_id()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM  GRF WHERE Grf_id = (SELECT MAX(po_id) FROM PurchaseOrder)", con)

        dr = cmd.ExecuteReader

        While dr.Read

            last_Po = dr.Item(0)

        End While


        con.Close()
    End Sub



    Sub DG_todb()
        Now.ToShortDateString()

        Call get_last_po_id()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        Dim cmd As New SqlClient.SqlCommand("INSERT INTO PO_Transaction( Ptrans_date,Unit_price,Unit_ordered,Unit_recieved, Products_product_id,po_po_id)VALUES(@ptrans_date,@Unit_price,@Unit_ordered,@Unit_recieved,@Products_product_id,po_id)", con)




        cmd.Parameters.Add("@ptrans_date", SqlDbType.DateTime)
        cmd.Parameters.Add("@Unit_price", SqlDbType.Int)
        cmd.Parameters.Add("@Unit_ordered", SqlDbType.Int)
        cmd.Parameters.Add("@Unit_recieved", SqlDbType.Int)
        cmd.Parameters.Add("@Products_product_id", SqlDbType.Int)
        cmd.Parameters.Add("@po_id", SqlDbType.Int)


        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            con.Close()

            cmd.Parameters(0).Value = DateTime.Now
            cmd.Parameters(1).Value = txtbox_unit_price.Text
            cmd.Parameters(2).Value = DataGridView1.Rows(i).Cells(1).Value
            cmd.Parameters(3).Value = DataGridView1.Rows(i).Cells(1).Value


            last_product = DataGridView1.Rows(i).Cells(0).Value.ToString
            Call find_product_id()
            cmd.Parameters(4).Value = last_product_id
            cmd.Parameters(5).Value = last_Po
            con.Open()
            cmd.ExecuteNonQuery()

        Next



    End Sub




    Sub find_product_id()


        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim dr As SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT Product_id, product_name FROM Product WHERE (Product_Name = '" + last_product + "')", con)


        dr = cmd.ExecuteReader

        While dr.Read
            last_product_id = dr.Item(0).ToString







        End While

        con.Close()



    End Sub




    Private Sub combo_product_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combo_product.SelectionChangeCommitted
        Call check_pro_availiablity()
        Label1.Text = selected_item_qty

    End Sub


    Sub check_pro_availiablity()

        Dim dr As SqlDataReader
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        Dim cmd As New SqlClient.SqlCommand("Select inventory_id, product_product_id, total_availiable From Office_inventory Where (product_product_id = @product_id)", con)
        cmd.Parameters.Add("@product_id", SqlDbType.Int)
        cmd.Parameters(0).Value = combo_product.SelectedIndex + 1

        con.Open()
        dr = cmd.ExecuteReader

        While dr.Read
            selected_item_qty = dr.Item(2)







        End While

        con.Close()



    End Sub

    Sub into_array()



        list1.Add(CInt(Label1.Text) + CInt(textbox_qty_giv.Text))
        list2.Add(valueslist.Item(combo_product.SelectedIndex))





    End Sub


    Sub array_toDB()
        Dim x As Integer = 0

        Dim i As Integer = list1.Count

        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        Dim cmd As New SqlClient.SqlCommand("UPDATE Office_inventory SET total_availiable = @ac WHERE (product_product_id = @pro)", con)

        cmd.Parameters.Add("@ac", SqlDbType.Int)
        cmd.Parameters.Add("@pro", SqlDbType.Int)


        Do Until x >= i

            con.Close()


            cmd.Parameters(0).Value = list1(x)
            cmd.Parameters(1).Value = list2(x)

            con.Open()
            cmd.ExecuteNonQuery()





            x = x + 1

        Loop


    End Sub

    Sub delete_frm_array()
        Dim i As Integer = DataGridView1.CurrentRow.Index
        list1.RemoveAt(i)
        list2.RemoveAt(i)

    End Sub


    Sub check_po_existence()

        po_exist = 0


        Dim dr As SqlDataReader
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM po where po_Num=@po_num", con)
        cmd.Parameters.Add("@po_num", SqlDbType.Char)


        cmd.Parameters(0).Value = grf_num_shared

        con.Open()
        dr = cmd.ExecuteReader


        If dr.HasRows Then

            po_exist = 1


        End If

        con.Close()

    End Sub



    Sub check_item_exit_grid()

        If DataGridView1.Rows.Count = 0 Then
        Else
            product_exit_grid = 0

            Dim x As Integer = 0
            Dim y As String


            Do Until x >= DataGridView1.Rows.Count

                y = DataGridView1.Rows(x).Cells(0).Value.ToString()

                x = x + 1

                If y = combo_product.Text Then

                    product_exit_grid = 1


                    Exit Sub
                End If

            Loop





        End If


    End Sub


    Sub sucess()


        MessageBox.Show("PO NUMBER: " + textbox_po_num.Text + " PROCESSED")

        dropdown_supplier.SelectedItem = Nothing
        textbox_po_num.Text = Nothing
        upload_path.Links.Clear()

        upload_path.Text = "LinkLabel1"
        upload_path.Hide()
        combo_product.SelectedItem = Nothing

        Label1.Text = "00"
        textbox_details.Text = Nothing


        DataGridView1.Rows.Clear()




    End Sub



End Class