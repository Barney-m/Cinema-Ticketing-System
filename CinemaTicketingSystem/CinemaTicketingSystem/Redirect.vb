Public Class Redirect
    Private Sub Redirect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Close()

        Movie.Show()

    End Sub
End Class