Imports System.Data.SqlClient
Public Class Login
    Dim connection As New Connection

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = usernameTxt.Text
        Dim pass As String = passwordTxt.Text
        Dim command As New SqlCommand("SELECT * FROM Users WHERE Username = '" & username & "' and Password = '" & pass & "' ", connection.con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)

        If dt.Rows.Count >= 1 Then
            MessageBox.Show("Login Successfully")
            MainMenu.Show()
            Me.Close()
        Else
            MessageBox.Show("Incoreect Username and Password")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        usernameTxt.Text = ""
        passwordTxt.Text = ""
    End Sub

    Private Sub passwordTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles passwordTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
End Class