Imports System.Data.OleDb


Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        Dim oConn As OleDb.OleDbConnection = New OleDb.OleDbConnection
        oConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC\Desktop\AstronomiaDb.accdb; "
        oConn.Open()
        Dim sSql As String = "SELECT EmployeeID, Password, Full_Name FROM EMPLOYEES WHERE EmployeeID ='" & txtID.Text & "' AND Password='" & txtPass.Text & "';"
        Dim cmd As OleDbCommand = New OleDbCommand(sSql, oConn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        PubVar = txtID.Text



        If dr.HasRows Then
            Dim User As String = ""
            While dr.Read
                User = dr("Full_Name").ToString

            End While
            userProfile.Visible = True


            Me.Hide()
        Else
            MsgBox("Login Failed! Please enter a correct ID and Password.")
        End If


    End Sub
End Class
