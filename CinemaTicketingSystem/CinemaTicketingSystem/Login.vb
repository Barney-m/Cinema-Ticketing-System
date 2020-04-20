Imports System.Data.OleDb

Public Class Login

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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim EncPassword As String

        Dim oConn As OleDb.OleDbConnection = New OleDb.OleDbConnection
        oConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\khai xiang\Source\Repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb"
        oConn.Open()
        EncPassword = encode(Trim(txtPass.Text))
        Dim sSql As String = "SELECT * FROM EMPLOYEES WHERE EmployeeID ='" & txtID.Text & "' AND Password='" & EncPassword & "';"
        Dim cmd As OleDbCommand = New OleDbCommand(sSql, oConn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        PubVar = txtID.Text


        If dr.HasRows Then
            Dim User As String = ""
            While dr.Read
                If dr("EmployeeID").ToString = "A1000001" Then
                    AdminHome.Visible = True
                    Me.Hide()
                Else

                    Home.Visible = True

                    Me.Hide()

                End If

            End While

        Else
            MsgBox("Login Failed! Please enter a correct ID and Password.")

            oConn.Close()
        End If


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

