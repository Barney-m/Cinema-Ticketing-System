Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class staffAssign

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\college material\vb assignment\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
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
        Dim str1 As String = "select EmployeeID,Full_Name, Birth_Date, Phone_No, Address, [E-mail], Status, [Password] from Employees where jobID = 1"
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

        conn.Open()
        Dim tdate As Date = Date.Now.ToShortDateString()

        Dim sqlString As String = "Select EmployeeID from Employees ORDER BY EmployeeID DESC"
        cmd = New OleDbCommand(sqlString, conn)

        result = cmd.ExecuteScalar
        conn.Close()

        Dim EncPassword As String

        Dim int As Integer = result.Substring(1, 7)

        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(txtEmail.Text.Trim)
        Dim salary As Integer = 0
        Dim theDate As String = DTdob.Value.ToShortDateString()

        Dim job As Integer = 1
        int += 1

        result = "S" + int.ToString()

        EncPassword = encode(Trim(txtPassword.Text))


        If txtName.Text = "" Then
            MessageBox.Show("Please enter your full name.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter your password.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPassword.Text.Length < 6 Then
            MessageBox.Show("The password should be minimum 6 character.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Please enter email.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not isValid Then
            MessageBox.Show("Invalid Email.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtAddress.Text = "" Then
            MessageBox.Show("Please Enter your address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPhone.Text = "" Then
            MessageBox.Show("Please Enter your phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf CbStatus.Text = "" Then
            MessageBox.Show("Please Enter your Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else


            conn.Open()

            Dim query As String = "insert into Employees (EmployeeID,Full_Name,Birth_Date,Phone_No,Address,[E-mail],Salary,JobID,Status,[Password],recruitedDate) values (?,?,?,?,?,?,?,?,?,?,?)"

            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", result)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@dob", theDate)
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@salary", salary)
            cmd.Parameters.AddWithValue("@job", job)
            cmd.Parameters.AddWithValue("@status", CbStatus.Text)
            cmd.Parameters.AddWithValue("@password", EncPassword)
            cmd.Parameters.AddWithValue("@recruiteDate", tdate)




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

        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        AdminHome.Show()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click

        Me.Close()
        Login.Show()
        Login.txtID.Clear()
        Login.txtPass.Clear()
    End Sub
End Class