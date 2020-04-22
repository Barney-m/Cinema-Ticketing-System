Public Class AdminHome

    Dim pl As Integer = 92
    Dim pl2 As Integer = 92
    Dim pl3 As Integer = 92
    Private Sub btnReport_MouseHover(sender As Object, e As EventArgs) Handles btnReport.MouseHover
        Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl2)
        Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl3)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pl > 365 Then
            Timer1.Stop()
        Else
            Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl)
            pl += 10
        End If
    End Sub

    Private Sub btnReport_MouseLeave(sender As Object, e As EventArgs) Handles btnReport.MouseLeave
        Timer1.Stop()
        pl = 92
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If pl > 365 Then
            Timer2.Stop()
        Else
            Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl2)
            pl2 += 10
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If pl > 365 Then
            Timer3.Stop()
        Else
            Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl3)
            pl3 += 10
        End If
    End Sub

    Private Sub btnStaff_MouseHover(sender As Object, e As EventArgs) Handles btnStaff.MouseHover
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl)
        Me.Panel4.Size = New Size(Me.Panel4.Size.Width, pl3)
        Timer2.Start()
    End Sub

    Private Sub btnMovie_MouseHover(sender As Object, e As EventArgs) Handles btnMovie.MouseHover
        Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl)
        Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl2)
        Timer3.Start()
    End Sub

    Private Sub btnStaff_MouseLeave(sender As Object, e As EventArgs) Handles btnStaff.MouseLeave
        Timer2.Stop()
        pl2 = 92
    End Sub

    Private Sub btnMovie_MouseLeave(sender As Object, e As EventArgs) Handles btnMovie.MouseLeave
        Timer3.Stop()
        pl3 = 92
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        PubVar = ""
        Me.Close()
        Login.Show()
        Login.txtID.Clear()
        Login.txtPass.Clear()
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        staffAssign.Show(Me)
        Me.Hide()
    End Sub

    Private Sub btnModifyStaff_Click(sender As Object, e As EventArgs) Handles btnModifyStaff.Click
        Me.Hide()
        ModifyStaff.Show(Me)
    End Sub

    Private Sub btnRemoveStaff_Click(sender As Object, e As EventArgs) Handles btnRemoveStaff.Click
        Me.Hide()
        removeStaff.Show(Me)
    End Sub

    Private Sub btnMovie_Click(sender As Object, e As EventArgs) Handles btnMovie.Click

    End Sub

    Private Sub btnModifyMovie_Click(sender As Object, e As EventArgs) Handles btnModifyMovie.Click
        ModifyMovie.Show()

    End Sub

    Private Sub btnAddMovie_Click(sender As Object, e As EventArgs) Handles btnAddMovie.Click
        AddMovie.Show()

    End Sub

    Private Sub btnRemoveMovie_Click(sender As Object, e As EventArgs) Handles btnRemoveMovie.Click
        RemoveMovie.Show()
    End Sub
End Class