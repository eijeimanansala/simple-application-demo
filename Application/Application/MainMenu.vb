Public Class MainMenu

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Products.Show()
        Me.Hide()
    End Sub

    Private Sub usersbtnCreate_Click(sender As Object, e As EventArgs) Handles usersbtnCreate.Click
        If MessageBox.Show("Are you sure do you want to Logout?", "Logout", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LoginAuthentication.Show()
        Me.Hide()
    End Sub
End Class