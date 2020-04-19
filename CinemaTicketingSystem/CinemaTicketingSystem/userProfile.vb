Imports System.Data.OleDb

Public Class userProfile

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\college material\vb assignment\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Visible = True
        txtAddress.Enabled = True
        txtEmail.Enabled = True
        txtPhone.Enabled = True

    End Sub

    Dim id As String = PubVar
    Private Sub userProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        conn.Open()
        Dim sqlString As String = "Select * from Employees where EmployeeID = '" & id & "';"
        cmd = New OleDbCommand(sqlString, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        If dr.HasRows Then
            Dim name As String = ""
            Dim Dob As Date = Nothing
            Dim phone As String = ""
            Dim email As String = ""
            Dim Address As String = ""

            While dr.Read
                name = dr("Full_Name").ToString
                Dob = dr("Birth_Date").ToString
                phone = dr("Phone_No").ToString
                email = dr("E-mail").ToString
                Address = dr("Address").ToString
            End While

            lblName.Text = name
            txtName.Text = name
            txtDob.Text = Dob
            txtEmail.Text = email
            txtPhone.Text = phone
            txtAddress.Text = Address

            conn.Close()
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        conn.Open()

        Dim updateString As String = "UPDATE Employees SET Phone_No=@p1, Address=@p2, [E-mail]=@p3 WHERE EmployeeID=@p4"

        cmd = New OleDbCommand(updateString, conn)
        cmd.Parameters.AddWithValue("@p1", txtPhone.Text)
        cmd.Parameters.AddWithValue("@p2", txtAddress.Text)
        cmd.Parameters.AddWithValue("@p3", txtEmail.Text)
        cmd.Parameters.AddWithValue("@p4", id)
        cmd.ExecuteNonQuery()


        btnSave.Visible = False
        txtAddress.Enabled = False
        txtEmail.Enabled = False
        txtPhone.Enabled = False

        MessageBox.Show("Successful Updated")
        conn.Close()


    End Sub

    Private Sub btnChgPass_Click(sender As Object, e As EventArgs) Handles btnChgPass.Click
        chgPassword.Show(Me)
    End Sub
End Class