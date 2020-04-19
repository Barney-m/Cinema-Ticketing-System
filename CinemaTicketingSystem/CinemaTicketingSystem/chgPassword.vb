Imports System.Data.OleDb

Public Class chgPassword

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\college material\vb assignment\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand

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

    Dim id As String = PubVar
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim oldpass As String
        Dim confirmPass As String
        Dim check As String

        oldpass = encode(Trim(txtOldPassword.Text))
        confirmPass = encode(Trim(txtConfirmPassword.Text))

        conn.Open()

        Dim queryStr As String = "select [Password] from Employees where EmployeeID  = '" & id & "'"
        Dim queryStr2 As String = "update Employees Set [password] = '" & confirmPass & "' where EmployeeID = '" & id & "'"
        cmd = New OleDbCommand(queryStr, conn)
        check = cmd.ExecuteScalar()

        If oldpass.Equals(check) Then

            If txtNewPassword.Text.Equals(txtConfirmPassword.Text) Then

                cmd = New OleDbCommand(queryStr2, conn)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Password Successfully Changed !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                userProfile.Show(Me)
            Else
                MessageBox.Show("New password does not match !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Incorrent old Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        conn.Close()



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class