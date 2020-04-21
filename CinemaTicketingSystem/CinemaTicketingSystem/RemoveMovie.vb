Imports System.Data.OleDb
Imports System.IO

Public Class RemoveMovie
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PohRemg\Desktop\Visual Basic Assignment\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Dim sql1 As String
    Dim cmd1 As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub RemoveMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Hide button, Label and textBox before user search movie id
        RemoveBtn.Visible = False
        MovieNamee.Visible = False
        RMovieIMG.Visible = False
        lblName.Visible = False
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click

        ''retrieve movie info
        Try
            conn.Open()

            ''This sql use to check movie id exist or not
            sql = "Select * from Movies where MovieID = '" & DeleteMovieID.Text & "'"
            cmd = New OleDbCommand(sql, conn)

            Dim status As String = ""
            Dim up As String = "Up"

            dr = cmd.ExecuteReader


            If dr.HasRows Then
                While dr.Read
                    status = dr("MovieStatus").ToString
                End While
                If status.Equals(up) Then
                    ''Hide out textbox and label before until user click Search button
                    RemoveBtn.Visible = True
                    MovieNamee.Visible = True
                    RMovieIMG.Visible = True
                    lblName.Visible = True

                    sql = "Select * from Movies where MovieID = '" & DeleteMovieID.Text & "'"
                    cmd = New OleDbCommand(sql, conn)
                    dr = cmd.ExecuteReader

                    ''Another new sql query because it only for image, image need as byte() so need another individual sql1 query
                    sql1 = "Select MovieImage from Movies where MovieID= '" & DeleteMovieID.Text & "'"
                    cmd1 = New OleDbCommand(sql1, conn)
                    Dim pictureData As Byte() = DirectCast(cmd1.ExecuteScalar(), Byte())
                    cmd.Dispose()
                    Dim sstream As New IO.MemoryStream(pictureData)
                    RMovieIMG.Image = Image.FromStream(sstream)

                    Dim mnamee As String = ""


                    While dr.Read
                        mnamee = dr("MovieName").ToString
                    End While

                    lblName.Text = mnamee
                    conn.Close()
                Else
                    MessageBox.Show("Movie ID Invalid")
                End If
            Else
                MessageBox.Show("Movie ID Invalid")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        Try
            conn.Open()
            sql = "UPDATE Movies SET MovieStatus=@p1 WHERE MovieID = '" & DeleteMovieID.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@p1", "Down")
            cmd.ExecuteNonQuery()

            ''just want to hide all label button and textbox after update
            RemoveBtn.Visible = False
            MovieNamee.Visible = False
            RMovieIMG.Visible = False
            lblName.Visible = False

            MessageBox.Show("Successful Deleted")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class