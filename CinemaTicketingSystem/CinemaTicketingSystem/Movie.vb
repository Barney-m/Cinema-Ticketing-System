Imports System.Data.OleDb

Public Class Movie

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\khai xiang\Source\Repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\AstronomiaDb (1).accdb")
    Public acsconn As New OleDbConnection 'listview
    Public ds As New DataSet
    Public da As New OleDbDataAdapter 'listview
    Dim lst As ListViewItem

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Movie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MovieListView.View = View.LargeIcon
        ListView()
    End Sub

    Sub ListView()
        Try
            Dim query As String
            Dim imglist As New ImageList()
            imglist.ImageSize = New Size(200, 200)


            conn.Open()
            query = "SELECT * FROM Movies"
            da = New OleDbDataAdapter(query, conn)
            da.Fill(ds, "Movie")
            conn.Close()

            For Each row As DataRow In ds.Tables(0).Rows
                lst = MovieListView.Items.Add(row.ItemArray(1).ToString, 1)
                imglist.Images.Add(Image.FromFile("C: \Users\khai xiang\Source\Repos\Barney-m\Cinema-Ticketing-System\CinemaTicketingSystem\CinemaTicketingSystem\images\DanceBound.png"))
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class