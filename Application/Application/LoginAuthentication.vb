Imports System.Data.SqlClient
Public Class LoginAuthentication
    Dim connection As New Connection
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles authconfirmpassTxt.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim auth_username As String = authusernameTxt.Text
        Dim auth_pass As String = authpassTxt.Text
        Dim auth_confirmpass As String = authconfirmpassTxt.Text

        Dim command As New SqlCommand("SELECT * FROM Users WHERE Username = '" & auth_username & "' and Password = '" & auth_pass & "' and ConfirmPassword = '" & auth_confirmpass & "' ", connection.con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)

        If dt.Rows.Count >= 1 Then
            If auth_pass = auth_confirmpass Then
                Users.Show()
                authusernameTxt.Text = ""
                authpassTxt.Text = ""
                authconfirmpassTxt.Text = ""
                Me.Hide()
            End If
        Else
            MessageBox.Show("Incoreect Username and Password")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class