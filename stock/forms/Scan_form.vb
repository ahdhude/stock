Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data

Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Imaging

Imports Bytescout.Scan
Imports System.IO



Public Class Scan_form
    Private Sub Twain321_AcquireCompleted(sender As Object, e As EventArgs) Handles Twain321.AcquireCompleted
        Try
            If Not Me.PictureBox1.Image Is Nothing Then
                Me.PictureBox1.Image.Dispose()
            End If
            Me.PictureBox1.Image = Me.Twain321.GetImage(0)




        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




        'when scan is completed update the in the module the path




    End Sub

    Private Sub btn_scanner_Click(sender As Object, e As EventArgs) Handles btn_scanner.Click
        Try
            Me._Twain321.SelectSource()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_scan_Click(sender As Object, e As EventArgs) Handles btn_scan.Click
        Try
            Me._Twain321.Acquire()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Twain321_EndXfer(sender As Object, e As Saraff.Twain.Twain32.EndXferEventArgs) Handles Twain321.EndXfer
        Try

            e.Image.Save("GRF.jpeg", ImageFormat.Jpeg)

        Catch ex As Exception

        End Try
    End Sub
End Class