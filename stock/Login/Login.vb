Imports System
Imports System.Security.Cryptography
Imports System.Text
Public Class Login
    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click

        'THIS PART CONVERTS PASSWORD INTO MD5 HASH 
        Dim passhash As String
        Dim [source] As String = textbox_pass.Text.ToString
        Using md5Hash As MD5 = MD5.Create()
            Dim hash As String = GetMd5Hash(md5Hash, source)
            passhash = hash
        End Using



        Dim con As New SqlClient.SqlConnection(Myconnection.MYconnectionstring)
        con.Open()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from [user] where username = '" + textbox_name.Text + "' AND password = '" + passhash + "' ", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            MsgBox("you are logged in")
        Else
            MsgBox("maan its false")
        End If
    End Sub


    Shared Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function 'GetMd5Hash


    ' Verify a hash against a string.
    Shared Function VerifyMd5Hash(ByVal md5Hash As MD5, ByVal input As String, ByVal hash As String) As Boolean
        ' Hash the input.
        Dim hashOfInput As String = GetMd5Hash(md5Hash, input)

        ' Create a StringComparer an compare the hashes.
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase

        If 0 = comparer.Compare(hashOfInput, hash) Then
            Return True
        Else
            Return False
        End If

    End Function 'VerifyMd5Hash
End Class