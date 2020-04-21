Imports System.Data.OleDb
Imports System.IO

Public Class AddMovie

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PohRemg\Desktop\Visual Basic Assignment\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String

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
            Dim mstream As New System.IO.MemoryStream()
            MovieIMG.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()

            conn.Open()
            sql = "INSERT INTO Movies(MovieID,MovieName, MovieGenre, MovieLength, MovieRating, MovieStatus,MovieImage,MovieDescription) VALUES (@ID, @NAME, @GENRE, @LENGTH, @RATE, @STATUS,@IMG,@DESC)"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ID", TextID.Text)
            cmd.Parameters.AddWithValue("@NAME", TextName.Text)
            cmd.Parameters.AddWithValue("@GENRE", TextGenre.Text)
            cmd.Parameters.AddWithValue("@LENGTH", TextLength.Text)
            cmd.Parameters.AddWithValue("@RATE", TextRating.Text)
            cmd.Parameters.AddWithValue("@STATUS", TextStatus.Text)
            cmd.Parameters.AddWithValue("@IMG", arrImage)
            cmd.Parameters.AddWithValue("@DESC", TextDesc.Text)
            Dim r As Integer
            r = cmd.ExecuteNonQuery()
            If r > 0 Then
                MsgBox("Student Record hass been Saved!")
            Else
                MsgBox("No record has been saved!")
            End If
            cmd.Parameters.Clear()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class