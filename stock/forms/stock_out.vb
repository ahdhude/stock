Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading
Imports System.IO

Imports System.Data.SqlClient

Public Class stock_out



    Dim gemscode As String = "LDSX"
    Dim req_user As String

    Dim x As Integer = 0



    Private Sub stock_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        upload_path.Hide()






        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from product", con)

        dr = cmd.ExecuteReader

        While dr.Read
            Product.ValueMember = dr.Item(0)
            Product.DisplayMember = dr.Item(1).ToString
            Product.Items.Add(dr.Item(1).ToString)




        End While

        con.Close()


        Call loademployees()



    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid1.CellContentClick

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

    Private Sub btn_process_Click(sender As Object, e As EventArgs) Handles btn_process.Click
        If x = 1 Then

            'Process the Info

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





    Public Sub grf_validate()

        If textbox_grf_num.Text = Nothing Then

        End If



    End Sub









    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click






        upload_path.Text = Nothing
        OpenFileDialog1.ShowDialog()
        Dim file_path As String
        file_path = OpenFileDialog1.FileName
        file_path = Path.GetFileName(file_path)
        upload_path.Text = file_path
        upload_path.Show()



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
        End If








    End Sub

    Private Sub textbox_grf_num_Leave(sender As Object, e As EventArgs) Handles textbox_grf_num.Leave
        If textbox_grf_num.Text = "(FRM)-LDS1/138/" + Year(Date.Today).ToString + "/" Then


            textbox_grf_num.Text = Nothing
        ElseIf textbox_grf_num.Text = "(FRM)-LDS2/138/" + Year(Date.Today).ToString + "/" Then

            textbox_grf_num.Text = Nothing


        End If
    End Sub

    Private Sub lable_scanner_Click(sender As Object, e As EventArgs) Handles lable_scanner.Click
        Dim f As Scan_form = New Scan_form


        f.Show()


    End Sub


End Class