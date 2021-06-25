Public Class MainMenu

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Products.Show()
        Me.Hide()
    End Sub

    Private Sub usersbtnCreate_Click(sender As Object, e As EventArgs) Handles usersbtnCreate.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Users.Show()
        Me.Hide()
    End Sub
End Class