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
Imports System.Text.RegularExpressions

Public Class Scan_form

    Dim grf_new_name As String

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
            Call grf_copy()
            Call scan_finished()




        Catch ex As Exception

        End Try

    End Sub


    'WHAT HAPPENS WHEN SCAN IS COMPLETE

    Sub scan_finished()

        If My.Computer.FileSystem.FileExists(grf_cons_path + "\" + grf_new_name + ".jpeg") Then



            Module_scan.stock_out.upload_path.Text = grf_new_name + ".jpeg"
            Module_scan.stock_out.upload_path.Show()
            objlink = Module_scan.stock_out.upload_path.Links.Add(0, 200)
            objlink.LinkData = grf_cons_path + "\" + grf_new_name + ".jpeg"




        Else

        End If




    End Sub

    Private Sub Scan_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call grf_newname()

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




    'THis function copies scanned gf from main directory to document directory 
    'renames the file to GRF number

    Sub grf_copy()

        If My.Computer.FileSystem.FileExists(path + "\GRF.jpeg") Then



            My.Computer.FileSystem.CopyFile(
           path + "\GRF.jpeg",
           grf_cons_path + "\" + grf_new_name + ".jpeg",
           Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
           Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)


            My.Computer.FileSystem.DeleteFile(path + "\GRF.jpeg")
        Else



        End If


    End Sub

    'Removes characters from so can rename the GRF 
    Sub grf_newname()



        grf_new_name = Regex.Replace(scan_file_name, "[^\w\.@-]", "")



    End Sub


End Class