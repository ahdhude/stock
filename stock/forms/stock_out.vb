Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading
Imports System.IO

Imports System.Data.SqlClient

Public Class stock_out
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
        uploaded_path = Nothing
        upload_path.Hide()





        upload_path.Text = Nothing
        OpenFileDialog1.ShowDialog()
        Dim file_path As String
        file_path = OpenFileDialog1.FileName
        file_path = Path.GetFileName(file_path)
        upload_path.Text = file_path
        If file_path = "OpenFileDialog1" Then
        Else
            upload_path.Show()


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

    Public Sub lable_scanner_Click(sender As Object, e As EventArgs) Handles lable_scanner.Click
        If textbox_grf_num.Text = Nothing Or textbox_grf_num.Text = grf_num_shared Then

            MsgBox("please enter a valid GRF number First")
            textbox_grf_num.Focus()
        Else

            scan_file_name = textbox_grf_num.Text





            Dim f As New Scan_form


            f.Show()
        End If





    End Sub

    Private Sub upload_path_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
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

        DataGrid1.AllowUserToAddRows = False


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


        Else



        End If




    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If DataGrid1.Rows.Count = 0 Or DataGrid1.CurrentCell Is Nothing Then

        Else
            DataGrid1.Rows.Remove(DataGrid1.CurrentRow)

        End If
    End Sub
End Class

