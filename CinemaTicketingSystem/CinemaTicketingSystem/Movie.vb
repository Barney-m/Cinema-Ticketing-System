Imports System.Data.OleDb

Public Class Movie

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\khai xiang\Source\Repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Public acsconn As New OleDbConnection 'listview
    Public ds As New DataSet
    Dim dr As OleDbDataReader
    Dim movie As String
    Dim movieHall As String
    Dim movieDate As String
    Dim movieTime As String

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
                MovieImg.Images.Add(Image.FromFile("C:\Users\khai xiang\Source\Repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\images\Parasite.jpg"))
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

        Dim cmd As New OleDbCommand
        conn.Open()
        cmd.CommandText = "SELECT * FROM MovieSchedule WHERE MovieID = ?"
        cmd.Connection = conn
        cmd.Parameters.AddWithValue("@p1", movie)

        dr = cmd.ExecuteReader
        'DateTime.Now.ToString("dd/MM/yyyy")

        While dr.Read
            If String.Format("{0:MM/dd/yyyy}", dr.GetDateTime(1)).ToString.Equals("04/09/2020") Then

                Dim schedule As String = String.Format("{0:MM/dd/yyyy}", dr.GetDateTime(1)) + " " + dr.GetString(2) + " " + dr.GetString(3)

                ComboBox1.Items.Add(schedule)

            End If

        End While

        dr.Close()
        conn.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        ComboBox1.Items.Clear()
        MovieDetailsPanel.Visible = False
        MovieListView.Show()
        btnNext1.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If ComboBox1.SelectedItem Is Nothing Then
            MsgBox("Choose a schedule!")
        Else
            movieHall = ComboBox1.SelectedItem.ToString.Substring(ComboBox1.SelectedItem.ToString.Length - 2)
            movieDate = ComboBox1.SelectedItem.ToString.Substring(0, 10)
            movieTime = ComboBox1.SelectedItem.ToString.Substring(11, 4)
        End If
        Panel4.Visible = True
    End Sub
End Class