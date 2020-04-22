Imports System.Data.OleDb

Public Class staffRegistReport

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\college material\vb assignment\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand
    Dim day As Integer = 0
    Dim report As String = ""

    Private Sub load_monthly()

        conn.Open()
        Dim date1 As String = "1" + "/" + cbMonth.Text + "/" + cbYear.Text

        Dim oDate As DateTime = Convert.ToDateTime(date1)
        Dim oDate2 As DateTime

        If cbMonth.Text = "1" Or cbMonth.Text = "3" Or cbMonth.Text = "5" Or cbMonth.Text = "7" Or cbMonth.Text = "8" Or cbMonth.Text = "10" Or cbMonth.Text = "12" Then
            Dim date2 As String = "31" + "/" + cbMonth.Text + "/" + cbYear.Text
            oDate2 = Convert.ToDateTime(date2)
        ElseIf cbMonth.Text = "2" Then
            Dim date2 As String = "29" + "/" + cbMonth.Text + "/" + cbYear.Text
            oDate2 = Convert.ToDateTime(date2)
        Else
            Dim date2 As String = "30" + "/" + cbMonth.Text + "/" + cbYear.Text
            oDate2 = Convert.ToDateTime(date2)
        End If


        cmd = New OleDbCommand("
        SELECT *
        FROM Employees
        WHERE (recruitedDate BETWEEN @p1 AND @p2)
        ORDER BY [recruitedDate] ASC", conn)

        cmd.Parameters.AddWithValue("@p1", oDate)
        cmd.Parameters.AddWithValue("@p2", oDate2)

        Dim dr As OleDbDataReader = cmd.ExecuteReader


        ListView1.Items.Clear()

        Dim x As ListViewItem
        If dr.HasRows Then
            Do While dr.Read = True
                x = New ListViewItem(dr("Full_Name").ToString)
                x.SubItems.Add(dr("Birth_Date"))
                x.SubItems.Add(dr("Phone_No"))
                x.SubItems.Add(dr("E-mail"))
                x.SubItems.Add(dr("recruitedDate"))
                ListView1.Items.Add(x)
            Loop
        Else
            MessageBox.Show("This month have no new assigned staff !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If

        conn.Close()
    End Sub

    Private Sub load_yearly()

        conn.Open()
        Dim date1 As String = "1" + "/" + "1" + "/" + cbYear.Text
        Dim date2 As String = "31" + "/" + "12" + "/" + cbYear.Text
        Dim oDate As DateTime = Convert.ToDateTime(date1)
        Dim oDate2 As DateTime = Convert.ToDateTime(date2)




        cmd = New OleDbCommand("
        SELECT *
        FROM Employees
        WHERE (recruitedDate BETWEEN @p1 AND @p2)
        ORDER BY [recruitedDate] ASC", conn)

        cmd.Parameters.AddWithValue("@p1", oDate)
        cmd.Parameters.AddWithValue("@p2", oDate2)

        Dim dr As OleDbDataReader = cmd.ExecuteReader


        ListView1.Items.Clear()

        Dim x As ListViewItem
        If dr.HasRows Then
            Do While dr.Read = True
                x = New ListViewItem(dr("Full_Name").ToString)
                x.SubItems.Add(dr("Birth_Date"))
                x.SubItems.Add(dr("Phone_No"))
                x.SubItems.Add(dr("E-mail"))
                x.SubItems.Add(dr("recruitedDate"))
                ListView1.Items.Add(x)
            Loop
        Else
            MessageBox.Show("This year have no new assigned staff !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        conn.Close()
    End Sub


    Private Sub load_daily()

        conn.Open()
        Dim date1 As String = txtDay.Text + "/" + cbMonth.Text + "/" + cbYear.Text

        Dim oDate As DateTime = Convert.ToDateTime(date1)


        cmd = New OleDbCommand("
        SELECT *
        FROM Employees
        WHERE recruitedDate = @p1
        ORDER BY [recruitedDate] ASC", conn)

        cmd.Parameters.AddWithValue("@p1", oDate)


        Dim dr As OleDbDataReader = cmd.ExecuteReader


        ListView1.Items.Clear()

        Dim x As ListViewItem
        If dr.HasRows Then
            Do While dr.Read = True
                x = New ListViewItem(dr("Full_Name").ToString)
                x.SubItems.Add(dr("Birth_Date"))
                x.SubItems.Add(dr("Phone_No"))
                x.SubItems.Add(dr("E-mail"))
                x.SubItems.Add(dr("recruitedDate"))
                ListView1.Items.Add(x)
            Loop
        Else
            MessageBox.Show("This date have no new assigned staff !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        conn.Close()
    End Sub


    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        cbMonth.Text = ""
        cbYear.Text = ""
        txtDay.Text = ""
        cbMonth.Enabled = True
        cbYear.Enabled = True
        txtDay.Enabled = True
        report = "daily"

    End Sub


    Private Sub btnMonth_Click(sender As Object, e As EventArgs) Handles btnMonth.Click
        cbMonth.Text = ""
        cbYear.Text = ""
        txtDay.Text = ""
        cbMonth.Enabled = True
        cbYear.Enabled = True
        txtDay.Enabled = False
        report = "monthly"
    End Sub

    Private Sub btnYear_Click(sender As Object, e As EventArgs) Handles btnYear.Click
        cbMonth.Text = ""
        cbYear.Text = ""
        txtDay.Text = ""
        cbMonth.Enabled = False
        cbYear.Enabled = True
        txtDay.Enabled = False
        report = "yearly"
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If report = "monthly" Then
            load_monthly()
        ElseIf report = "yearly" Then
            load_yearly()
        ElseIf report = "daily" Then
            load_daily()
        End If
    End Sub
End Class