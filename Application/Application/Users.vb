Imports System.Data.SqlClient
Public Class Users
    Dim connection As New Connection

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Database1DataSet.Users)

    End Sub
    Private Sub addusersBtn_Click(sender As Object, e As EventArgs) Handles addusersBtn.Click
        Dim uname As String = createusernameTxt.Text
        Dim pass As String = createpasswordTxt.Text
        Dim confirmpass As String = createconfirmpassTxt.Text

        If pass = confirmpass Then
            connection.con.Open()
            Dim command As New SqlCommand("INSERT INTO USERS VALUES ('" & uname & "', '" & pass & "', '" & confirmpass & "')", connection.con)
            command.ExecuteNonQuery()
            connection.con.Close()
            MessageBox.Show("Succesfully Inserted!")
        Else
            MessageBox.Show("Password are not match")
        End If
    End Sub
    Private Sub updateusersBtn_Click(sender As Object, e As EventArgs) Handles updateusersBtn.Click
        Dim uid As Integer = createusersidTxt.Text
        Dim uname As String = createusernameTxt.Text
        Dim pass As String = createpasswordTxt.Text
        Dim confirmpass As String = createconfirmpassTxt.Text

        If pass = confirmpass Then
            connection.con.Open()
            Dim command As New SqlCommand("UPDATE USERS SET Username = '" & uname & "', Password = '" & pass & "', ConfirmPassword = '" & confirmpass & "' WHERE UserID = '" & uid & "'", connection.con)
            command.ExecuteNonQuery()
            connection.con.Close()
            MessageBox.Show("Succesfully Updated!")
            LoadDataInGrid()
        Else
            MessageBox.Show("Password are not match")
        End If
    End Sub
    Private Sub deleteusersBtn_Click(sender As Object, e As EventArgs) Handles deleteusersBtn.Click
        If MessageBox.Show("Are you sure do you to delete?", "Delete Document", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim uid As Integer = createusersidTxt.Text
            connection.con.Open()
            Dim command As New SqlCommand("Delete Users where UserID = '" & uid & "'", connection.con)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Deleted")
            LoadDataInGrid()
            connection.con.Close()
        End If
    End Sub

    Private Sub userstbackBtn_Click(sender As Object, e As EventArgs) Handles userstbackBtn.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub searchuseridBtn_Click(sender As Object, e As EventArgs) Handles searchuseridBtn.Click
        Dim uid As Integer = createusersidTxt.Text
        Dim command As New SqlCommand("SELECT * FROM Users WHERE UserID = '" & uid & "'", connection.con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("Select * from Users", connection.con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub createusersidTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles createusersidTxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub
End Class