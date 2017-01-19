Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading
Imports System.Data.SqlClient

Public Class stock_out

    Dim x As Integer = 0



    Private Sub stock_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load





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

    Private Sub BunifuDatepicker1_onValueChanged(sender As Object, e As EventArgs) Handles BunifuDatepicker1.onValueChanged


        Dim testdate As String = BunifuDatepicker1.Value.ToString("dd/MM/yyyy HH:mm tt")
        MessageBox.Show(testdate)

    End Sub
End Class