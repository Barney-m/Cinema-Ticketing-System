Imports System.Data.OleDb


Public Class staffAssign

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\college material\vb assignment\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand

    Private Sub staffAssign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_AstronomiaDb__1_DataSet.Employees' table. You can move, or remove it, as needed.
        updatedgv()

        txtName.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
        CbStatus.Text = ""


    End Sub

    Private Sub updatedgv()
        conn.Open()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim str1 As String = "select Full_Name, Birth_Date, Phone_No, Address, [E-mail], Status, [Password] from Employees where jobID = 1"
        da.SelectCommand = New OleDbCommand(str1, conn)
        da.Fill(ds)
        conn.Close()
        dgv.DataSource = ds.Tables(0)
    End Sub



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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim result As Object = Nothing
        Dim sample As String = "S1000007"
        conn.Open()
        Dim sqlString As String = "Select EmployeeID from Employees Where EmployeeID = '" & sample & "'"
        cmd = New OleDbCommand(sqlString, conn)

        result = cmd.ExecuteScalar
        conn.Close()

        Dim EncPassword As String
        Dim int As Integer = result.Substring(1, 7)

        Dim salary As Integer = 0
        Dim job As Integer = 1
        int += 1
        result = "S" + int.ToString()

        EncPassword = encode(Trim(txtPassword.Text))

        conn.Open()
        Dim query As String = "insert into Employees (EmployeeID,Full_Name,Birth_Date,Phone_No,Address,[E-mail],Salary,JobID,Status,[Password]) values (?,?,?,?,?,?,?,?,?,?)"
        cmd = New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", result)
        cmd.Parameters.AddWithValue("@name", txtName.Text)
        cmd.Parameters.AddWithValue("@dob", DTdob)
        cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
        cmd.Parameters.AddWithValue("@address", txtAddress.Text)
        cmd.Parameters.AddWithValue("@email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@salary", salary)
        cmd.Parameters.AddWithValue("@job", job)
        cmd.Parameters.AddWithValue("@status", CbStatus.Text)
        cmd.Parameters.AddWithValue("@password", EncPassword)


        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("New Staff Added !")
        txtName.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
        CbStatus.Text = ""
        updatedgv()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class