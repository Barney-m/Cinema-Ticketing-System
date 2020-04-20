﻿Imports System.Data.OleDb

Public Class Movie

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\khai xiang\source\repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Public acsconn As New OleDbConnection 'listview
    Public ds As New DataSet
    Dim dr As OleDbDataReader
    Dim movie As String
    Dim movieDate As String
    Dim movieTime As String
    Dim movieHall As String
    Dim scheduleID As String
    Dim seatID As New ArrayList()
    Dim defaultSeat As New System.Drawing.Bitmap(My.Resources.seatdefault)
    Dim availableSeat As New System.Drawing.Bitmap(My.Resources.seatavailable)
    Dim unavailableSeat As New System.Drawing.Bitmap(My.Resources.seatunavailable)
    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Movie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MovieListView.View = View.LargeIcon
        MovieListView.SelectedItems.Clear()
        MovieListView.SelectedIndices.Clear()
        MovieListView.MultiSelect = False

        ListView()

    End Sub



    Sub ListView()
        Try
            Dim query As String
            Dim imglist As New ImageList()
            MovieImg.ImageSize = New Size(200, 200)


            conn.Open()
            query = "SELECT * FROM Movies"
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(query, conn)
            da.Fill(ds, "Movie")
            conn.Close()
            Dim i As Integer = 0
            For Each row As DataRow In ds.Tables(0).Rows
                MovieListView.Items.Add(row.ItemArray(1).ToString, i)
                MovieImg.Images.Add(Image.FromFile("C:\Users\khai xiang\source\repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\images\Avengers.jpg"))
                i += 1
            Next

            MovieListView.Items(0).Selected = True
            MovieListView.Items(0).EnsureVisible()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        If MovieListView.SelectedItems Is Nothing Then
            MsgBox("Please Select A Movie.")
        Else

            MovieListView.Hide()
            btnNext1.Hide()
            MovieDetailsPanel.Visible = True
            movie = MovieListView.Items(MovieListView.FocusedItem.Index).SubItems(0).Text
            movieName.Text = movie
            Label5.Text = movie
            Label27.Text = movie
            conn.Open()
            ComboBox1.Items.Clear()
            Dim cmd As New OleDbCommand
            cmd.CommandText = "SELECT * FROM Movies WHERE MovieName = ?"
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@p1", movie)

            Dim idReader As OleDbDataReader

            idReader = cmd.ExecuteReader()
            While idReader.Read
                movie = idReader.GetString(0)
            End While



            conn.Close()
            MovieSchedule()

        End If
    End Sub

    Sub MovieSchedule()
        ComboBox1.Text = ""
        Dim cmd As New OleDbCommand
        conn.Open()
        cmd.CommandText = "SELECT * FROM MovieSchedule WHERE MovieID = ?"
        cmd.Connection = conn
        cmd.Parameters.AddWithValue("@p1", movie)

        dr = cmd.ExecuteReader

        'String.Format("{0:MM/dd/yyyy}", DateTime.Now.ToString("dd/MM/yyyy"))
        While dr.Read
            If String.Format("{0:MM/dd/yyyy}", dr.GetDateTime(1)).ToString.Equals("04/09/2020") Then

                Dim schedule As String = String.Format("{0:MM/dd/yyyy}", dr.GetDateTime(1)) + " " + dr.GetString(2) + " " + dr.GetString(3)

                ComboBox1.Items.Add(schedule)
            End If

        End While

        dr.Close()
        conn.Close()
    End Sub

    Sub getScheduleID()
        Dim cmd As New OleDbCommand
        Dim oDate As DateTime = Convert.ToDateTime(movieDate)
        Dim mDate = DateTime.Parse(oDate).ToString("M/d/yyyy")
        conn.Open()
        cmd.CommandText = "SELECT * FROM MovieSchedule WHERE MovieDate = ? AND ScreeningTime = ? AND HallID = ?"
        cmd.Connection = conn
        cmd.Parameters.AddWithValue("@p1", mDate)
        cmd.Parameters.AddWithValue("@p2", movieTime)
        cmd.Parameters.AddWithValue("@p3", movieHall)

        dr = cmd.ExecuteReader

        While dr.Read
            scheduleID = dr.GetString(0)
        End While
        conn.Close()
        dr.Close()

    End Sub

    Sub getTicketID()
        Dim cmd As New OleDbCommand
        conn.Open()
        cmd.CommandText = "SELECT * FROM TicketPurchasement WHERE ScheduleID = ?"
        cmd.Connection = conn
        cmd.Parameters.AddWithValue("@p1", scheduleID)

        dr = cmd.ExecuteReader
        Dim count As Integer
        Do While dr.Read
            count += 1
        Loop
        Dim ticketID(count - 1) As String
        count = 0
        dr.Close()
        dr = cmd.ExecuteReader
        Dim i As Integer = 0
        While dr.Read
            ticketID(i) = dr.GetString(0)
            i += 1
        End While
        i = 0
        conn.Close()
        dr.Close()

        getTicketDetails(ticketID)

    End Sub

    Sub getTicketDetails(ByVal ParamArray ticketID() As String)
        conn.Open()
        For x = 0 To ticketID.Length - 1 Step 1


            Dim cmd As New OleDbCommand
            cmd.CommandText = "SELECT * FROM TicketDetails WHERE TicketID = ?"
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@p1", ticketID(x))

            dr = cmd.ExecuteReader
            While dr.Read
                seatID.Add(dr.GetString(1))
            End While
        Next
        conn.Close()
        dr.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If ComboBox1.SelectedIndex > -1 Then
            movieHall = ComboBox1.SelectedItem.ToString().Substring(ComboBox1.SelectedItem.ToString().Length - 2)
            movieDate = ComboBox1.SelectedItem.ToString().Substring(0, 8)
            movieTime = ComboBox1.SelectedItem.ToString().Substring(11, 4)

            getScheduleID()
            getTicketID()

            Hall()

            panelHall.Visible = True

        Else
            MsgBox("Select an option")
        End If

    End Sub

    Private Sub backLogo1_Click(sender As Object, e As EventArgs) Handles backLogo1.Click
        MovieListView.Show()
        MovieDetailsPanel.Visible = False
        btnNext1.Visible = True
    End Sub

    Private Sub backLogo2_Click(sender As Object, e As EventArgs) Handles backLogo2.Click
        MovieDetailsPanel.Visible = True
        panelHall.Visible = False
    End Sub

    Private Sub backLogo3_Click(sender As Object, e As EventArgs)
        panelOrder.Visible = False
        panelHall.Visible = True
        MovieDetailsPanel.Visible = False
    End Sub

    Sub Hall()
        Dim c As Control

        For Each c In Me.Panel5.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = defaultSeat
                AddHandler c.Click, AddressOf PictureBox10_Click
            End If
        Next

        Try
            For i As Integer = 1 To 30
                If seatID.Contains(i.ToString) Then
                    Dim con() As Control
                    con = Me.Controls.Find("PictureBox" & i.ToString(), True)
                    DirectCast(con(0), PictureBox).Image = unavailableSeat
                    DirectCast(con(0), PictureBox).Cursor = Cursors.Default
                End If
            Next
        Catch ex As Exception

        Finally
            seatID.Clear()
        End Try
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If CType(sender, PictureBox).Image Is availableSeat Then
            CType(sender, PictureBox).Image = defaultSeat
        ElseIf CType(sender, PictureBox).Image Is defaultSeat Then
            CType(sender, PictureBox).Image = availableSeat
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        panelOrder.Visible = True
    End Sub

End Class