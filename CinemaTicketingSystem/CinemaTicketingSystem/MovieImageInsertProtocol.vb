Public Class MovieImageInsertProtocol


    Dim Myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\khai xiang\Source\Repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb"
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                Pic1.ImageLocation = imgpath

            End If

            OFD = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Try
            Dim conn As New OleDb.OleDbConnection
            conn.ConnectionString = Myconnection

            Dim mstream As New System.IO.MemoryStream()
            Pic1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length

            mstream.Close()

            conn.Open()
            sql = "UPDATE Movies SET MovieImage = ? WHERE MovieID = 'M1000001'"
            Using cmd = New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@p1", arrImage)
                cmd.ExecuteNonQuery()

            End Using



            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class