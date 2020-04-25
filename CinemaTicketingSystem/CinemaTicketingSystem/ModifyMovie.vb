Imports System.Data.OleDb
Imports System.IO

Public Class ModifyMovie
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\khai xiang\Source\Repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Dim cmd As OleDbCommand
    Dim imgpath As String
    Dim arrImage() As Byte
    Dim sql As String
    Dim sql1 As String
    Dim cmd1 As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub ModifyMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add the Button Column.
        Dim buttonColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        buttonColumn.Width = 50
        buttonColumn.Name = "buttonColumn"
        buttonColumn.Text = "Modify"
        buttonColumn.UseColumnTextForButtonValue = True
        schedule.Columns.Insert(0, buttonColumn)

        Dim buttonColumn1 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        buttonColumn1.HeaderText = ""
        buttonColumn1.Width = 50
        buttonColumn1.Name = "buttonColumn"
        buttonColumn1.Text = "Delete"
        buttonColumn1.UseColumnTextForButtonValue = True
        schedule.Columns.Insert(1, buttonColumn1)

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
        CheckStatuss.Visible = False
        TextMdesc.Visible = False
        schedule.Visible = False
        AddSchedule.Visible = False
        addSchedule1.Visible = False
        ModifySchedule.Visible = False
        lblDate.Visible = False
        lblTime.Visible = False
        lblHall.Visible = False
        lblSchedule.Visible = False
        lblHintTime.Visible = False
        lblHintHall.Visible = False
        txtHall.Visible = False
        txtScheduleID.Visible = False
        txtTime.Visible = False
        DTSchedule.Visible = False
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        ''retrieve movie info

        Try
            updateSchedule()
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
                CheckStatuss.Visible = True
                TextMdesc.Visible = True
                schedule.Visible = True
                AddSchedule.Visible = True
                addSchedule1.Visible = False
                lblDate.Visible = False
                lblTime.Visible = False
                lblHall.Visible = False
                lblSchedule.Visible = False
                lblHintTime.Visible = False
                lblHintHall.Visible = False
                txtHall.Visible = False
                txtScheduleID.Visible = False
                txtTime.Visible = False
                DTSchedule.Visible = False
                ModifySchedule.Visible = False

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
                conn.Close()


                TextMname.Text = mname
                TextMgenre.Text = genre
                TextMlength.Text = length
                TextMrating.Text = rating
                TextMdesc.Text = desc
                If status = "Up" Then
                    CheckStatuss.Checked = True
                Else
                    CheckStatuss.Checked = False
                End If
            Else
                MessageBox.Show("Movie Not Exist. Check Movie ID")
            End If

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

            Dim MovieStatus As String = ""
            If CheckStatuss.Checked Then
                MovieStatus = "Up"
            Else
                MovieStatus = "Down"
            End If

            conn.Open()
            sql = "UPDATE Movies SET MovieName=@p1, MovieGenre=@p2, MovieLength=@p3, MovieRating=@p4, MovieStatus=@p5,MovieImage=@p6,MovieDescription=@p7 WHERE MovieID = '" & TextMid.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@p1", TextMname.Text)
            cmd.Parameters.AddWithValue("@p2", TextMgenre.Text)
            cmd.Parameters.AddWithValue("@p3", TextMlength.Text)
            cmd.Parameters.AddWithValue("@p4", TextMrating.Text)
            cmd.Parameters.AddWithValue("@p5", MovieStatus)
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
            CheckStatuss.Visible = False
            TextMdesc.Visible = False
            schedule.Visible = False
            AddSchedule.Visible = False
            addSchedule1.Visible = False
            lblDate.Visible = False
            lblTime.Visible = False
            lblHall.Visible = False
            lblSchedule.Visible = False
            lblHintTime.Visible = False
            lblHintHall.Visible = False
            txtHall.Visible = False
            txtScheduleID.Visible = False
            txtTime.Visible = False
            DTSchedule.Visible = False
            ModifySchedule.Visible = False

            MessageBox.Show("Successful Updated")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub updateSchedule()

        conn.Open()
        Dim status As String = ""
        status = "Up"
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim str1 As String = "Select * from MovieSchedule where MovieID = '" & TextMid.Text & "'AND ScheduleStatus = '" & status & "'"
        da.SelectCommand = New OleDbCommand(str1, conn)
        da.Fill(ds)

        schedule.DataSource = ds.Tables(0)
        conn.Close()

    End Sub


    Private Sub schedule_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles schedule.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim row As DataGridViewRow = schedule.Rows(e.RowIndex)
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
            CheckStatuss.Visible = False
            TextMdesc.Visible = False
            schedule.Visible = False
            AddSchedule.Visible = False
            ModifySchedule.Visible = False
            addSchedule1.Visible = False

            lblDate.Visible = True
            lblTime.Visible = True
            lblHall.Visible = True
            lblSchedule.Visible = True
            lblHintTime.Visible = True
            lblHintHall.Visible = True

            txtHall.Visible = True
            txtScheduleID.Visible = True
            txtTime.Visible = True
            DTSchedule.Visible = True
            ModifySchedule.Visible = True

            txtHall.Text = row.Cells("HallID").Value
            txtScheduleID.Text = row.Cells("ScheduleID").Value
            txtTime.Text = row.Cells("ScreeningTime").Value
            DTSchedule.Value = row.Cells("MovieDate").Value

        ElseIf e.ColumnIndex = 1 Then
            Dim row As DataGridViewRow = schedule.Rows(e.RowIndex)
            If MessageBox.Show(String.Format("Do you want to delete Customer ID: {0}", row.Cells("ScheduleID").Value), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                da.SelectCommand = New OleDbCommand("DELETE FROM MovieSchedule WHERE ScheduleID = @ScheduleID", conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@ScheduleID", row.Cells("ScheduleID").Value)
                conn.Open()
                sql = "UPDATE MovieSchedule SET ScheduleStatus=@p1 WHERE ScheduleID = @ScheduleID"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@p1", "Down")
                cmd.Parameters.AddWithValue("@ScheduleID", row.Cells("ScheduleID").Value)
                cmd.ExecuteNonQuery()
                conn.Close()
                Me.updateSchedule()
            End If
        End If
    End Sub

    Private Sub AddSchedule_Click(sender As Object, e As EventArgs) Handles AddSchedule.Click
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
        CheckStatuss.Visible = False
        TextMdesc.Visible = False
        schedule.Visible = False
        AddSchedule.Visible = False
        addSchedule1.Visible = True
        lblDate.Visible = True
        lblTime.Visible = True
        lblHall.Visible = True
        lblSchedule.Visible = True
        lblHintTime.Visible = True
        lblHintHall.Visible = True
        txtHall.Visible = True
        txtScheduleID.Visible = True
        txtTime.Visible = True
        DTSchedule.Visible = True
        ModifySchedule.Visible = False

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
        txtScheduleID.Text = newSchduleID.ToString


        txtHall.Text = ""
        txtTime.Text = ""
        DTSchedule.MinDate = DateTime.Now

    End Sub

    Private Sub ModifySchedule_Click(sender As Object, e As EventArgs) Handles ModifySchedule.Click
        Try
            conn.Open()
            If txtTime.Text.Length > 4 Then
                MessageBox.Show("The Schedule time format was wrong.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtTime.Text.Length < 4 Then
                MessageBox.Show("The Schedule time format was wrong.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                sql = "UPDATE MovieSchedule SET MovieDate=@p1, ScreeningTime=@p2, HallID=@p3, MovieID=@p4,ScheduleStatus=@p5 WHERE ScheduleID = '" & txtScheduleID.Text & "'"
                cmd = New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@p1", DTSchedule)
                cmd.Parameters.AddWithValue("@p2", txtTime.Text)
                cmd.Parameters.AddWithValue("@p3", txtHall.Text)
                cmd.Parameters.AddWithValue("@p4", TextMid.Text)
                cmd.Parameters.AddWithValue("@p5", "Up")

                cmd.ExecuteNonQuery()
                Dim r1 As Integer

                r1 = cmd.ExecuteNonQuery()
                If r1 > 0 Then
                    If r1 > 0 Then
                        MsgBox("Movie record hass been Saved!")
                        Me.Close()


                    Else
                        MessageBox.Show("Saving Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Saving Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub addSchedule1_Click(sender As Object, e As EventArgs) Handles addSchedule1.Click
        Try
            conn.Open()
            If txtTime.Text.Length > 4 Then
                MessageBox.Show("The Schedule time format was wrong.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtTime.Text.Length < 4 Then
                MessageBox.Show("The Schedule time format was wrong.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                sql1 = "INSERT INTO MovieSchedule(ScheduleID,MovieDate, ScreeningTime, HallID, MovieID, ScheduleStatus) VALUES (@SID, @SDATE, @STIME, @HALL,@MID, @SSTATUS)"
                cmd1 = New OleDbCommand(sql1, conn)
                cmd1.Parameters.AddWithValue("@SID", txtScheduleID.Text)
                cmd1.Parameters.AddWithValue("@SDATE", DTSchedule)
                cmd1.Parameters.AddWithValue("@STIME", txtTime.Text)
                cmd1.Parameters.AddWithValue("@HALL", txtHall.Text)
                cmd1.Parameters.AddWithValue("@ID", TextMid.Text)
                cmd1.Parameters.AddWithValue("@SSTATUS", "Up")
                Dim r1 As Integer

                r1 = cmd1.ExecuteNonQuery()
                If r1 > 0 Then
                    If r1 > 0 Then
                        MsgBox("Movie record hass been Saved!")
                        Me.Close()

                    Else
                        MessageBox.Show("Saving Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Saving Error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub
End Class