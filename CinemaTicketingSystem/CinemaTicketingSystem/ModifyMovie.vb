Imports System.Data.OleDb
Imports System.IO

Public Class ModifyMovie
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PohRemg\Desktop\Visual Basic Assignment\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Dim sql1 As String
    Dim cmd1 As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub ModifyMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Hide button, Label and textBox before user search movie id
        ChangeIMG.Visible = False
        Modify.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        PicMovie.Visible = False
        TextMname.Visible = False
        TextMname.Visible = False
        TextMgenre.Visible = False
        TextMlength.Visible = False
        TextMrating.Visible = False
        TextMstatus.Visible = False
        TextMdesc.Visible = False
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        ''retrieve movie info
        Try
            conn.Open()

            ''This sql use to check movie id exist or not
            sql = "Select * from Movies where MovieID = '" & TextMid.Text & "'"
            cmd = New OleDbCommand(sql, conn)


            dr = cmd.ExecuteReader
            If dr.HasRows Then
                ''Hide out textbox and label before until user click Search button
                ChangeIMG.Visible = True
                Modify.Visible = True
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                PicMovie.Visible = True
                TextMname.Visible = True
                TextMname.Visible = True
                TextMgenre.Visible = True
                TextMlength.Visible = True
                TextMrating.Visible = True
                TextMstatus.Visible = True
                TextMdesc.Visible = True

                ''Another new sql query because it only for image, image need as byte() so need another individual sql1 query
                sql1 = "Select MovieImage from Movies where MovieID= '" & TextMid.Text & "'"
                cmd1 = New OleDbCommand(sql1, conn)
                Dim pictureData As Byte() = DirectCast(cmd1.ExecuteScalar(), Byte())
                cmd.Dispose()
                Dim sstream As New IO.MemoryStream(pictureData)
                PicMovie.Image = Image.FromStream(sstream)

                Dim mname As String = ""
                Dim genre As String = ""
                Dim length As String = ""
                Dim rating As String = ""
                Dim status As String = ""
                Dim desc As String = ""


                While dr.Read
                    mname = dr("MovieName").ToString
                    genre = dr("MovieGenre").ToString
                    length = dr("MovieLength").ToString
                    rating = dr("MovieRating").ToString
                    status = dr("MovieStatus").ToString
                    desc = dr("MovieDescription").ToString
                End While

                TextMname.Text = mname
                TextMgenre.Text = genre
                TextMlength.Text = length
                TextMrating.Text = rating
                TextMstatus.Text = status
                TextMdesc.Text = desc

            Else
                MessageBox.Show("Movie Not Exist. Check Movie ID")
            End If
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub


    Private Sub ChangeIMG_Click(sender As Object, e As EventArgs) Handles ChangeIMG.Click
        ''choose new img to change
        Try
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PicMovie.ImageLocation = imgpath
            End If
            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles Modify.Click
        ''Update movie details
        Try
            Dim mstream As New System.IO.MemoryStream()
            PicMovie.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()

            conn.Open()
            sql = "UPDATE Movies SET MovieName=@p1, MovieGenre=@p2, MovieLength=@p3, MovieRating=@p4, MovieStatus=@p5,MovieImage=@p6,MovieDescription=@p7 WHERE MovieID = '" & TextMid.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@p1", TextMname.Text)
            cmd.Parameters.AddWithValue("@p2", TextMgenre.Text)
            cmd.Parameters.AddWithValue("@p3", TextMlength.Text)
            cmd.Parameters.AddWithValue("@p4", TextMrating.Text)
            cmd.Parameters.AddWithValue("@p5", TextMstatus.Text)
            cmd.Parameters.AddWithValue("@p6", arrImage)
            cmd.Parameters.AddWithValue("@p7", TextMdesc.Text)
            cmd.ExecuteNonQuery()

            ''just want to hide all label button and textbox after update
            ChangeIMG.Visible = False
            Modify.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            PicMovie.Visible = False
            TextMname.Visible = False
            TextMname.Visible = False
            TextMgenre.Visible = False
            TextMlength.Visible = False
            TextMrating.Visible = False
            TextMstatus.Visible = False
            TextMdesc.Visible = False

            MessageBox.Show("Successful Updated")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class