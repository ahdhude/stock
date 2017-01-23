Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data

Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports stock.stock_out


Imports System.IO



Public Class Scan_form
    Dim path As String = Directory.GetCurrentDirectory





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





    Private Sub Twain321_EndXfer(sender As Object, e As Saraff.Twain.Twain32.EndXferEventArgs) Handles Twain321.EndXfer
        Try


            e.Image.Save("GRF.jpeg", ImageFormat.Jpeg)
            Call scan_finished()




        Catch ex As Exception

        End Try

    End Sub


    'WHAT HAPPENS WHEN SCAN IS COMPLETE

    Sub scan_finished()

        If My.Computer.FileSystem.FileExists(Path + "\GRF.jpeg") Then



            Module_scan.stock_out.upload_path.Text = "GRF.jpeg"
            Module_scan.stock_out.upload_path.Show()
            objlink = Module_scan.stock_out.upload_path.Links.Add(0, 11)
            objlink.LinkData = path + "\GRF.jpeg"




        Else

        End If




    End Sub

    Private Sub Scan_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Me.Twain321.SelectSource = Nothing Then

        Else
            Try
                Me._Twain321.Acquire()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub
End Class