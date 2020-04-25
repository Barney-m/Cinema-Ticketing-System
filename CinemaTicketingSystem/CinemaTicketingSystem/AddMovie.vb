Imports System.Data.OleDb
Imports System.IO
Imports System.Web


Public Class AddMovie

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\khai xiang\Source\Repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand
    Dim cmd1 As OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Dim sql1 As String
    Dim dr As OleDbDataReader
    Dim drag As Boolean

    Private Sub AddMovie_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Calulate Movie ID
        Dim result As Object = Nothing

        Dim NextMovieID As Integer
        NextMovieID = 1000001
        conn.Open()
        Dim sqlString As String = "Select MovieID from Movies ORDER BY MovieID DESC"
        cmd = New OleDbCommand(sqlString, conn)
        result = cmd.ExecuteScalar
        conn.Close()
        Dim id As Integer = result.Substring(1, 7)
        Dim MovieStarter As String
        Dim newMovieID As String
        MovieStarter = "M"
        id += 1
        newMovieID = MovieStarter + id.ToString
        TextID.Text = newMovieID.ToString

        Dim result1 As Object = Nothing

        Dim NextSchedule As Long
        NextSchedule = 1000000000001
        conn.Open()
        Dim sqlString1 As String = "Select ScheduleID from MovieSchedule ORDER BY ScheduleID DESC"
        cmd = New OleDbCommand(sqlString1, conn)
        result1 = cmd.ExecuteScalar
        conn.Close()
        Dim sid As Long = result1.Substring(1, 13)
        Dim ScheduleStarter As String
        Dim newSchduleID As String
        ScheduleStarter = "S"
        sid += 1
        newSchduleID = ScheduleStarter + sid.ToString
        sid1.Text = newSchduleID.ToString

        DTSchedule1.MinDate = DateTime.Now
    End Sub

    Private Sub ChooseIMG_Click(sender As Object, e As EventArgs) Handles ChooseIMG.Click
        ''Choose Image
        Try
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                MovieIMG.ImageLocation = imgpath

            End If
            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub AddIMG_Click(sender As Object, e As EventArgs) Handles AddIMG.Click
        ''Add Image Details into database
        Try
            Dim tdate As Date = Date.Now.ToShortDateString()


            Dim mstream As New System.IO.MemoryStream()
            MovieIMG.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()

            Dim theDate As String = DTSchedule1.Value.ToShortDateString()


            Dim MovieStatus As String = ""
            If CheckStatus.Checked Then
                MovieStatus = "Up"
            Else
                MovieStatus = "Down"
            End If


            If TextName.Text = "" Then
                MessageBox.Show("Please Complete Movie Information.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf TextGenre.Text = "" Then
                MessageBox.Show("Please Complete Movie Information.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf TextLength.Text = "" Then
                MessageBox.Show("Please Complete Movie Information.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf TextRating.Text = "" Then
                MessageBox.Show("Please Complete Movie Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf TextDesc.Text = "" Then
                MessageBox.Show("Please Complete Movie Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf hid1.Text = "" Then
                MessageBox.Show("Please Enter Movie Hall ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf stime1.Text.Length > 4 Then
                MessageBox.Show("The Schedule time format was wrong.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf stime1.Text.Length < 4 Then
                MessageBox.Show("The Schedule time format was wrong.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                conn.Open()
                    sql = "INSERT INTO Movies(MovieID,MovieName, MovieGenre, MovieLength, MovieRating, MovieStatus,MovieImage,MovieDescription) VALUES (@ID, @NAME, @GENRE, @LENGTH, @RATE, @STATUS,@IMG,@DESC)"
                    cmd = New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", TextID.Text)
                    cmd.Parameters.AddWithValue("@NAME", TextName.Text)
                    cmd.Parameters.AddWithValue("@GENRE", TextGenre.Text)
                    cmd.Parameters.AddWithValue("@LENGTH", TextLength.Text)
                    cmd.Parameters.AddWithValue("@RATE", TextRating.Text)
                    cmd.Parameters.AddWithValue("@STATUS", MovieStatus)
                    cmd.Parameters.AddWithValue("@IMG", arrImage)
                    cmd.Parameters.AddWithValue("@DESC", TextDesc.Text)

                    sql1 = "INSERT INTO MovieSchedule(ScheduleID,MovieDate, ScreeningTime, HallID, MovieID, ScheduleStatus) VALUES (@SID, @SDATE, @STIME, @HALL,@MID, @SSTATUS)"
                    cmd1 = New OleDbCommand(sql1, conn)
                    cmd1.Parameters.AddWithValue("@SID", sid1.Text)
                cmd1.Parameters.AddWithValue("@SDATE", theDate)
                cmd1.Parameters.AddWithValue("@STIME", stime1.Text)
                cmd1.Parameters.AddWithValue("@HALL", hid1.Text)
                cmd1.Parameters.AddWithValue("@ID", TextID.Text)
                    cmd1.Parameters.AddWithValue("@SSTATUS", "Up")


                    Dim r As Integer
                    Dim r1 As Integer

                    r = cmd.ExecuteNonQuery()
                    r1 = cmd1.ExecuteNonQuery()
                    If r > 0 Then
                        If r1 > 0 Then
                            MsgBox("Movie record hass been Saved!")
                            AdminHome.Show()
                        Else
                            MessageBox.Show("Saving Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Saving Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    End If
                    cmd.Parameters.Clear()
                    conn.Close()
                End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
