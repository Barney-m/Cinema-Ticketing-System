Imports System.Data.OleDb

Public Class removeStaff
    Private Sub removeStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatedgv()
    End Sub

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\college material\vb assignment\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand

    Private Sub updatedgv()
        conn.Open()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim str1 As String = "select Full_Name, Status from Employees where jobID = 1"
        da.SelectCommand = New OleDbCommand(str1, conn)
        da.Fill(ds)
        conn.Close()
        dgv.DataSource = ds.Tables(0)


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If CbStatus.Text = "" Then
            MessageBox.Show("Select a staff to do modification !")
        Else
            conn.Open()
            Dim updateString As String = "UPDATE Employees SET Status=@p4 WHERE Full_Name=@p5"

            cmd = New OleDbCommand(updateString, conn)

            cmd.Parameters.AddWithValue("@p4", CbStatus.Text)
            cmd.Parameters.AddWithValue("@p5", txtName.Text)
            cmd.ExecuteNonQuery()

            conn.Close()

            MessageBox.Show("Staff Status Updated !")
            updatedgv()

        End If




    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        txtName.Text = dgv.CurrentRow.Cells(0).Value
        CbStatus.Text = dgv.CurrentRow.Cells(1).Value
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class