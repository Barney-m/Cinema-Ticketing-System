Public Class userProfile
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Visible = True
        txtAddress.Enabled = True
        txtEmail.Enabled = True
        txtPhone.Enabled = True

    End Sub


End Class