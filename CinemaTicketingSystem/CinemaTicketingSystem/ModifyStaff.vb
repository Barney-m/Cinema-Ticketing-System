Imports System.Data.OleDb

Public Class ModifyStaff
    Private Sub ModifyStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_AstronomiaDb__1_DataSet.Employees' table. You can move, or remove it, as needed.
        updatedgv()

    End Sub

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\college material\vb assignment\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand

    Private Sub updatedgv()
        conn.Open()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim str1 As String = "select Full_Name, Birth_Date, Phone_No, Address, [E-mail], Salary from Employees where jobID = 1"
        da.SelectCommand = New OleDbCommand(str1, conn)
        da.Fill(ds)
        conn.Close()
        dgv.DataSource = ds.Tables(0)
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtPhone.Text = "" Then
            MessageBox.Show("Select a staff to do modification !")
        Else
            conn.Open()

            Dim updateString As String = "UPDATE Employees SET Phone_No=@p1, Address=@p2, [E-mail]=@p3, Salary=@p4 WHERE Full_Name=@p5"
            Dim salary As Double = CDbl(CbSalary.Text)
            cmd = New OleDbCommand(updateString, conn)
            cmd.Parameters.AddWithValue("@p1", txtPhone.Text)
            cmd.Parameters.AddWithValue("@p2", txtAddress.Text)
            cmd.Parameters.AddWithValue("@p3", txtEmail.Text)
            cmd.Parameters.AddWithValue("@p4", salary)
            cmd.Parameters.AddWithValue("@p5", txtName.Text)
            cmd.ExecuteNonQuery()

            conn.Close()

            MessageBox.Show("Data Updated !")
            updatedgv()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        txtName.Text = dgv.CurrentRow.Cells(0).Value
        DTdob.Text = dgv.CurrentRow.Cells(1).Value
        txtPhone.Text = dgv.CurrentRow.Cells(2).Value
        txtAddress.Text = dgv.CurrentRow.Cells(3).Value
        txtEmail.Text = dgv.CurrentRow.Cells(4).Value
        CbSalary.Text = dgv.CurrentRow.Cells(5).Value
    End Sub
End Class