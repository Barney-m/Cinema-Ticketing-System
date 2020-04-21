Imports System.Data.OleDb
Imports System.Net.Mail



Public Class forgetPass

    Public Function encode(ByVal sdata As String) As String
        Try
            Dim encdata_byte As Byte() = New Byte(sdata.Length - 1) {}
            encdata_byte = System.Text.Encoding.UTF8.GetBytes(sdata)
            Dim encodedata As String = Convert.ToBase64String(encdata_byte)
            Return (encodedata)

        Catch ex As Exception
            Throw (New Exception("Error is base64code" & ex.Message))
        End Try
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim EncPassword As String
        Dim chgPassMail As New MailMessage()
        Dim chkEmail As String
        Dim check As String

        Dim oConn As OleDb.OleDbConnection = New OleDb.OleDbConnection
        oConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC\source\repos\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb"
        oConn.Open()

        Dim defaultPass As String = "DDEB8562"
        EncPassword = encode(Trim(defaultPass))

        Dim sSql As String = "SELECT [E-mail] FROM EMPLOYEES WHERE EmployeeID ='" & txtID.Text & "'"
        Dim sSql2 As String = "UPDATE Employees SET [Password] = '" & EncPassword & "' WHERE EmployeeID = '" & txtID.Text & "' AND [E-mail] ='" & txtEmail.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(sSql, oConn)
        check = cmd.ExecuteScalar()
        chkEmail = txtEmail.Text


        If chkEmail.Equals(check) Then
            cmd = New OleDbCommand(sSql2, oConn)
            cmd.ExecuteNonQuery()
            Try
                chgPassMail.From = New MailAddress("chongpeng0218@gmail.com")
                chgPassMail.To.Add(txtEmail.Text)
                chgPassMail.Subject = ("Astronomia's Staff Password Reset.")
                chgPassMail.Body = ("Your account password has changed to default password.Your Password is 'DDEB8562'. Please kindly change your password as soon as you login to your account. Thank you for your cooperation.")
                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.Port = 587
                SMTP.EnableSsl = True
                SMTP.UseDefaultCredentials = False
                SMTP.Credentials = New System.Net.NetworkCredential("chongpeng0218@gmail.com", "ccp218ccp218")
                SMTP.Send(chgPassMail)
                MsgBox("Email has sent successfully!" & vbNewLine & "Please Check Your E-mail to view your new password.")
                txtID.Text = ""
                txtEmail.Text = ""
            Catch ex As Exception
                MsgBox("E-mail could not be sent.")

            End Try

        Else
            MsgBox("Please fill in correct Staff ID and E-mail!")
        End If






        oConn.Close()


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Login.Show()
        Login.txtID.Clear()
        Login.txtPass.Clear()
    End Sub


End Class