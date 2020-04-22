Imports System.Data.OleDb
Public Class TicketPurchasementReport

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\khai xiang\Source\Repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand
    Dim day As Integer = 0
    Dim report As String

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

    Sub dailyReport()
        conn.Open()
        Dim date1 As String = txtDay.Text + "/" + cbMonth.Text + "/" + cbYear.Text
        Try
            Dim oDate As DateTime = Convert.ToDateTime(date1)
            Dim query = "SELECT * FROM TicketPurchasement WHERE PurchaseDate = ? ORDER BY [TicketID] ASC"

            cmd = New OleDbCommand(query, conn)

            cmd.Parameters.AddWithValue("@p1", oDate)


            Dim dr As OleDbDataReader = cmd.ExecuteReader


            ListView1.Items.Clear()

            Dim x As ListViewItem
            If dr.HasRows Then
                Do While dr.Read = True
                    x = New ListViewItem(dr("TicketID").ToString)
                    x.SubItems.Add(dr("EmployeeID"))
                    x.SubItems.Add(dr("ScheduleID"))
                    x.SubItems.Add(dr("Price"))
                    x.SubItems.Add(dr("PurchaseDate"))
                    ListView1.Items.Add(x)
                Loop
            Else
                MessageBox.Show("No data at this date!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MsgBox("Please choose a valid date!")
        End Try
        conn.Close()
    End Sub

    Sub monthlyReport()
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

        Dim query = "SELECT * FROM TicketPurchasement WHERE (PurchaseDate BETWEEN ? AND ?) ORDER BY [TicketID] ASC"
        cmd = New OleDbCommand(query, conn)

        cmd.Parameters.AddWithValue("@p1", oDate)
        cmd.Parameters.AddWithValue("@p2", oDate2)

        Dim dr As OleDbDataReader = cmd.ExecuteReader


        ListView1.Items.Clear()

        Dim x As ListViewItem
        If dr.HasRows Then
            Do While dr.Read = True
                x = New ListViewItem(dr("TicketID").ToString)
                x.SubItems.Add(dr("EmployeeID"))
                x.SubItems.Add(dr("ScheduleID"))
                x.SubItems.Add(dr("Price"))
                x.SubItems.Add(dr("PurchaseDate"))
                ListView1.Items.Add(x)
            Loop
        Else
            MessageBox.Show("No data at this month!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If

        conn.Close()
    End Sub

    Sub yearlyReport()
        conn.Open()
        Dim date1 As String = "1" + "/" + "1" + "/" + cbYear.Text
        Dim date2 As String = "31" + "/" + "12" + "/" + cbYear.Text
        Dim oDate As DateTime = Convert.ToDateTime(date1)
        Dim oDate2 As DateTime = Convert.ToDateTime(date2)



        Dim query = "SELECT * FROM TicketPurchasement WHERE (PurchaseDate BETWEEN ? AND ?) ORDER BY [TicketID] ASC"
        cmd = New OleDbCommand(query, conn)

        cmd.Parameters.AddWithValue("@p1", oDate)
        cmd.Parameters.AddWithValue("@p2", oDate2)

        Dim dr As OleDbDataReader = cmd.ExecuteReader


        ListView1.Items.Clear()

        Dim x As ListViewItem
        If dr.HasRows Then
            Do While dr.Read = True
                x = New ListViewItem(dr("TicketID").ToString)
                x.SubItems.Add(dr("EmployeeID"))
                x.SubItems.Add(dr("ScheduleID"))
                x.SubItems.Add(dr("Price"))
                x.SubItems.Add(dr("PurchaseDate"))
                ListView1.Items.Add(x)
            Loop
        Else
            MessageBox.Show("No data at this year!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        conn.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If report = "daily" Then
            dailyReport()
        ElseIf report = "monthly" Then
            monthlyReport()
        ElseIf report = "yearly" Then
            yearlyReport()
        End If
    End Sub
End Class