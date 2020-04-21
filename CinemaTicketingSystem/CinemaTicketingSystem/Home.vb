Imports System.Data.OleDb
Public Class Home


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oConn As OleDb.OleDbConnection = New OleDb.OleDbConnection
        oConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\khai xiang\Source\Repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb"
        oConn.Open()
        Dim sSql As String = "SELECT * FROM EMPLOYEES WHERE EmployeeID ='" & PubVar & "';"
        Dim cmd As OleDbCommand = New OleDbCommand(sSql, oConn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            Dim User As String = ""
            While dr.Read
                User = dr("Full_Name").ToString

            End While
            lblName.Text = User



        End If



        oConn.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        PubVar = ""
        Me.Close()
        Login.Show()
        Login.txtID.Clear()
        Login.txtPass.Clear()
    End Sub

    Private Sub lblProfile_Click(sender As Object, e As EventArgs) Handles lblProfile.Click
        Me.Hide()
        userProfile.Visible = True

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()

        Movie.Visible = True

    End Sub
End Class