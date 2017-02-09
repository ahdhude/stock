Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading
Imports System.IO
Imports Infragistics.UltraGauge.Resources

Imports System.Data.SqlClient

Public Class stock_out
    Dim image_id As Integer
    Dim last_grf As Integer
    Dim last_product_id As Integer
    Dim last_product As String

    Dim valueslist As List(Of String) = New List(Of String)
    Dim list1 As New ArrayList

    Dim list2 As New ArrayList


    Dim selected_item As Integer
    Dim selected_item_qty As Integer
    Dim slected_stri As String



    Dim validate_product_counter As Integer = 0


    Dim validate_counter As Integer = 0





    Dim gemscode As String = "LDSX"
    Dim req_user As String

    Dim x As Integer = 0



    Private Sub stock_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGrid1.AllowUserToAddRows = False



        upload_path.Hide()

        Dim current_user As String
        Dim grf_path As String
        current_user = Environment.UserName
        grf_path = "C:\Users\" + current_user + "\Documents\GRF"

        grf_cons_path = grf_path

        If (Not System.IO.Directory.Exists(grf_path)) Then
            System.IO.Directory.CreateDirectory(grf_path)
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


        Call loademployees()



    End Sub




    Private Sub textbox_details_MouseClick(sender As Object, e As MouseEventArgs) Handles textbox_details.MouseClick


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

    Private Sub DataGrid1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGrid1.CellValidating

        If e.ColumnIndex = 0 Then



        ElseIf e.ColumnIndex = 1 Then

            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGrid1.Rows(e.RowIndex).ErrorText = "Cannot be empty"
                e.Cancel = True

            ElseIf Not IsNumeric(e.FormattedValue) Or (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then

                DataGrid1.Rows(e.RowIndex).ErrorText = "Please enter a number"
                e.Cancel = True



            End If

        ElseIf e.ColumnIndex = 2 Then

            If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGrid1.Rows(e.RowIndex).ErrorText = "Cannot be empty"
                e.Cancel = True

            ElseIf Not IsNumeric(e.FormattedValue) Or (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then

                DataGrid1.Rows(e.RowIndex).ErrorText = "Please enter a number"
                e.Cancel = True
            End If
        End If


    End Sub



    Private Sub DataGrid1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid1.CellEndEdit

        DataGrid1.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    Private Sub DataGrid1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGrid1.RowHeaderMouseDoubleClick
        If DataGrid1.CurrentCell.Value = Nothing Then



        Else
            DataGrid1.Rows.Remove(DataGrid1.Rows(e.RowIndex))

        End If
    End Sub

    Private Sub DataGrid1_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGrid1.ColumnHeaderMouseDoubleClick
        DataGrid1.AllowUserToAddRows = True

    End Sub

    Private Sub DataGrid1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGrid1.UserAddedRow
        DataGrid1.AllowUserToAddRows = False


    End Sub

    Private Sub DataGrid1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGrid1.RowHeaderMouseClick
        DataGrid1.CurrentRow.Selected = True
    End Sub




    Public Sub loademployees()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)

        Dim cmd As New SqlClient.SqlCommand("select * from employee", con)
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()

        con.Open()
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        adapter.Dispose()
        cmd.Dispose()
        con.Close()


        dropdown_emp.DataSource = ds.Tables(0)
        dropdown_emp.ValueMember = "employee_id"
        dropdown_emp.DisplayMember = "employee_name"



        con.Close()

    End Sub





    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        If textbox_grf_num.Text = Nothing Or textbox_grf_num.Text = grf_num_shared Then

            MsgBox("please enter a valid GRF number First")
            textbox_grf_num.Focus()
        Else

            scan_file_name = textbox_grf_num.Text





            Dim f As New Scan_form


            f.Show()


        End If


    End Sub





    'GET GEMS CODE FROM DATBASE BASED ON USER SELECTED
    Public Sub get_gems_Code()


        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT Unit.Gems_grf_code FROM Unit INNER JOIN Employee ON Unit.Unit_id = Employee.Unit_Unit_id WHERE (Employee.Employee_name = '" + dropdown_emp.Text + "')", con)

        dr = cmd.ExecuteReader

        While dr.Read
            gemscode = dr.Item(0).ToString
            gemscode.Trim()


        End While

        con.Close()


    End Sub

    Private Sub dropdown_emp_ValueChanged(sender As Object, e As EventArgs) Handles dropdown_emp.ValueChanged

        If dropdown_emp.Text = "Requested By" Then
        Else
            Call get_gems_Code()

            textbox_grf_num.Text = "(FRM)-" + gemscode + "/138/" + Year(Date.Today).ToString + "/"
            grf_num_shared = "(FRM)-" + gemscode + "/138/" + Year(Date.Today).ToString + "/"
        End If








    End Sub

    Private Sub textbox_grf_num_Leave(sender As Object, e As EventArgs) Handles textbox_grf_num.Leave
        If textbox_grf_num.Text = "(FRM)-LDS1/138/" + Year(Date.Today).ToString + "/" Then


            textbox_grf_num.Text = Nothing
        ElseIf textbox_grf_num.Text = "(FRM)-LDS2/138/" + Year(Date.Today).ToString + "/" Then

            textbox_grf_num.Text = Nothing


        End If
    End Sub

    Public Sub lable_scanner_Click(sender As Object, e As EventArgs)
        If textbox_grf_num.Text = Nothing Or textbox_grf_num.Text = grf_num_shared Then

            MsgBox("please enter a valid GRF number First")
            textbox_grf_num.Focus()
        Else

            scan_file_name = textbox_grf_num.Text





            Dim f As New Scan_form


            f.Show()
        End If





    End Sub

    Private Sub upload_path_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles upload_path.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString)

    End Sub











    Private Sub dropdown_emp_MouseEnter(sender As Object, e As EventArgs) Handles dropdown_emp.MouseEnter
        textbox_grf_num.Enabled = True

    End Sub

    Private Sub textbox_qty_req_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textbox_qty_req.KeyPress

        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Call product_add_validation()

        If validate_product_counter = 0 Then
            DataGrid1.AllowUserToAddRows = True
            Dim row As String() = New String() {combo_product.Text, textbox_qty_req.Text, textbox_qty_giv.Text}
            DataGrid1.Rows.Add(row)
        Else
            MessageBox.Show("Please enter a valid value")
            validate_product_counter = 0

        End If

        Call into_array()



        DataGrid1.AllowUserToAddRows = False
        combo_product.Text = Nothing
        textbox_qty_giv.Text = Nothing
        textbox_qty_req.Text = Nothing

        Call array_toDB()




    End Sub


    Sub product_add_validation()

        Dim combo As String = combo_product.Text


        If combo_product.Items.Contains(combo_product.Text) = False Or combo_product.Text = Nothing Then

            validate_product_counter = 1
            combo_product.Focus()



        ElseIf textbox_qty_req.Text = Nothing Then
            validate_product_counter = 1
            textbox_qty_req.Focus()


        ElseIf textbox_qty_giv.Text = Nothing Then
            validate_product_counter = 1
            textbox_qty_giv.Focus()

        ElseIf textbox_qty_giv.Text = Nothing Then

            validate_product_counter = 1
            textbox_qty_giv.Focus()

        ElseIf CInt(textbox_qty_giv.Text) > (textbox_qty_req.Text) Then

            validate_product_counter = 1
            textbox_qty_giv.Focus()

        ElseIf label1.text <= 0 Then

            MsgBox("The item does not exist in stock")
            validate_product_counter = 1

            Exit Sub



        Else



        End If




    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If DataGrid1.Rows.Count = 0 Or DataGrid1.CurrentCell Is Nothing Then

        Else
            Call delete_frm_array()
            DataGrid1.Rows.Remove(DataGrid1.CurrentRow)



        End If
    End Sub


    Sub validation()

        If dropdown_emp.Text = Nothing Then
            MessageBox.Show("Please select a name")
            dropdown_emp.Focus()

        ElseIf upload_path.Text = "LinkLabel" Then
            MessageBox.Show("please scan the document")

        ElseIf textbox_details.Text = Nothing Then
            MessageBox.Show("Please enter Details")
            textbox_details.Focus()


        ElseIf DataGrid1.RowCount = 0 Then

            MsgBox("please add an item ")


        Else

            Call process()


        End If


    End Sub




    Sub process()




        Call imagetodb()

        Call datatodb()

        Call DG_todb()





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

        Dim cmd As New SqlClient.SqlCommand("INSERT INTO GRFPHOTO ( GRF_photo) VALUES(@grfphoto)", con)

        cmd.Parameters.Add("@grfphoto", SqlDbType.Image).Value = ms.ToArray()

        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
        con.Close()



    End Sub



    Sub datatodb()

        Call get_last_imageid()

        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)


        Dim cmd As New SqlClient.SqlCommand("INSERT INTO GRF (Grf_Number, Grf_date, Grf_requested_by, grf_photo) VALUES(@Grf_Number,@Grf_date,@Grf_requested_by,@grf_photo)", con)



        con.Open()



        cmd.Parameters.AddWithValue("@Grf_Number", textbox_grf_num.Text.ToString)
        cmd.Parameters.AddWithValue("@Grf_date", textbox_date.Value.ToString)
        cmd.Parameters.AddWithValue("@Grf_requested_by", dropdown_emp.SelectedItem.DataValue)
        cmd.Parameters.AddWithValue("@grf_photo", image_id)

        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("GRF already Exist")
        End Try

        con.Close()


    End Sub


    Sub get_last_imageid()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM  GRFPHOTO WHERE Id = (SELECT MAX(Id) FROM GRFPHOTO)", con)

        dr = cmd.ExecuteReader

        While dr.Read

            image_id = dr.Item(0)

        End While


        con.Close()

    End Sub


    Sub get_last_grf_id()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM  GRF WHERE Grf_id = (SELECT MAX(Grf_id) FROM GRF)", con)

        dr = cmd.ExecuteReader

        While dr.Read

            last_grf = dr.Item(0)

        End While


        con.Close()
    End Sub






    Sub DG_todb()

        Call get_last_grf_id()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        Dim cmd As New SqlClient.SqlCommand("INSERT INTO GRF_Transaction(Gtrans_date, Gtrans_description, item_sold_qtry,item_req_qty, Grf_Grf_id, Products_product_id)VALUES(@Gtrans_date,@Gtrans_description,@item_sold_qtry,@item_req_qty,@Grf_Grf_id,@Products_product_id)", con)


        cmd.Parameters.Add("@Gtrans_date", SqlDbType.DateTime)
        cmd.Parameters.Add("@Gtrans_description", SqlDbType.NVarChar)
        cmd.Parameters.Add("@item_sold_qtry", SqlDbType.Int)
        cmd.Parameters.Add("@item_req_qty", SqlDbType.Int)
        cmd.Parameters.Add("@Grf_Grf_id", SqlDbType.Int)
        cmd.Parameters.Add("@Products_product_id", SqlDbType.Int)



        For i As Integer = 0 To DataGrid1.Rows.Count - 1
            con.Close()

            cmd.Parameters(0).Value = DateTime.Today
            cmd.Parameters(1).Value = textbox_details.Text
            cmd.Parameters(2).Value = DataGrid1.Rows(i).Cells(2).Value
            cmd.Parameters(3).Value = DataGrid1.Rows(i).Cells(1).Value
            cmd.Parameters(4).Value = last_grf
            last_product = DataGrid1.Rows(i).Cells(0).Value.ToString
            Call find_product_id()
            cmd.Parameters(5).Value = last_product_id
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




    Sub update_inventory()
        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        Dim cmd As New SqlClient.SqlCommand("Update Office_inventory Set total_availiable = @total_availiable WHERE(product_product_id = @product_id))", con)

        cmd.Parameters.Add("@total_availiable", SqlDbType.Int)
        cmd.Parameters.Add("@product_id", SqlDbType.Int)


        For i As Integer = 0 To DataGrid1.Rows.Count - 1
            con.Close()

            'cmd.Parameters(0).Value = 

            'cmd.Parameters(1).Value = textbox_details.Text
            'cmd.Parameters(2).Value = DataGrid1.Rows(i).Cells(2).Value
            'cmd.Parameters(3).Value = DataGrid1.Rows(i).Cells(1).Value
            'cmd.Parameters(4).Value = last_grf
            'last_product = DataGrid1.Rows(i).Cells(0).Value.ToString
            'Call find_product_id()
            'cmd.Parameters(5).Value = last_product_id
            'con.Open()
            'cmd.ExecuteNonQuery()
        Next





    End Sub





    Private Sub combo_product_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combo_product.SelectionChangeCommitted, combo_product.Leave, combo_product.TextChanged




        Call check_pro_availiablity()



        If selected_item_qty < 10 Then
            slected_stri = String.Format("{0:0#}", selected_item_qty)

            Label1.Text = slected_stri

        Else
            Label1.Text = selected_item_qty

        End If




        BunifuCircleProgressbar1.Value = selected_item_qty

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



        list1.Add(CInt(Label1.Text) - CInt(textbox_qty_giv.Text))
        list2.Add(valueslist.Item(combo_product.SelectedIndex))





    End Sub


    'the two arrays of products and qty updated to inventory
    Sub array_toDB()
        Dim x As Integer = 0

        Dim i As Integer = list1.Count


        Do Until x >= i



            MessageBox.Show(list1(x))

            MessageBox.Show(list2(x))





            x = x + 1

        Loop






    End Sub


    Sub delete_frm_array()
        Dim i As Integer = DataGrid1.CurrentRow.Index
        list1.RemoveAt(i)
        list2.RemoveAt(i)

    End Sub



    Sub get_baaky_into_list()




    End Sub
End Class

