Imports System.Data.SqlClient
Public Class Login
    Dim connection As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Desktop\Desktop\demo-project\Application\Application\Database1.mdf;Integrated Security=True")

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = usernameTxt.Text
        Dim pass As String = passTxt.Text
        Dim command As New SqlCommand("SELECT * FROM Users WHERE Username = '" & username & "', Password = '" & pass & "'", connection)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable()
        sda.Fill(dt)

        If dt.Rows.Count() <= 1 Then
            MessageBox.Show("Username or Password invalid")
        Else
            MessageBox.Show("Login Successfully")
            MainMenu.Show()
            Me.Hide()
        End If
    End Sub
End Class