Imports System.Threading.Thread
Imports System.Globalization
Imports System.Threading

Public Class stock_out

    Dim x As Integer = 0



    Private Sub stock_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LBMSTOCKDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.LBMSTOCKDataSet.Product)



    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid1.CellContentClick

    End Sub



    Private Sub textbox_details_MouseClick(sender As Object, e As MouseEventArgs) Handles textbox_details.MouseClick


    End Sub

    Private Sub textbox_details_Leave(sender As Object, e As EventArgs) Handles textbox_details.Leave
        System.Windows.Forms.InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(0)

    End Sub

    Private Sub textbox_details_Enter(sender As Object, e As EventArgs) Handles textbox_details.Enter

        'change language direction to right to left 

        textbox_details.TextAlign = HorizontalAlignment.Right
        System.Windows.Forms.InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(1)
        textbox_details.Font = New Font("faruma", 12, FontStyle.Regular)


    End Sub

    Private Sub DataGrid1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGrid1.CellValidating

        If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then

            ' DataGrid1.Rows(e.RowIndex).ErrorText = "Error"
            'e.Cancel = True

        ElseIf e.ColumnIndex = 1 Then

            If Not IsNumeric(e.FormattedValue) Or (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                DataGrid1.Rows(e.RowIndex).ErrorText = "Please enter a number"
                e.Cancel = True



            End If

        ElseIf e.ColumnIndex = 2 Then

            If Not IsNumeric(e.FormattedValue) Then
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint


    End Sub
End Class