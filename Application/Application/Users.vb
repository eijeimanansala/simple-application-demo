Imports System.Data.SqlClient
Public Class Users
    Dim connection As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Desktop\Desktop\demo-project\Application\Application\Database1.mdf;Integrated Security=True")

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Database1DataSet.Users)

    End Sub

    Private Sub addusersBtn_Click(sender As Object, e As EventArgs) Handles addusersBtn.Click
        Dim uname As String = createusernameTxt.Text
        Dim pass As String = createpasswordTxt.Text
        Dim confirmpass As String = createconfirmpassTxt.Text

        If pass = confirmpass Then
            connection.Open()
            Dim command As New SqlCommand("INSERT INTO USERS VALUES ('" & uname & "', '" & pass & "', '" & confirmpass & "')", connection)
            command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Succesfully Inserted!")
        Else
            MessageBox.Show("Password are not match")
        End If
    End Sub

    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("Select * from Users", connection)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub updateusersBtn_Click(sender As Object, e As EventArgs) Handles updateusersBtn.Click
        Dim uid As Integer = createusersidTxt.Text
        Dim uname As String = createusernameTxt.Text
        Dim pass As String = createpasswordTxt.Text
        Dim confirmpass As String = createconfirmpassTxt.Text

        If pass = confirmpass Then
            connection.Open()
            Dim command As New SqlCommand("UPDATE USERS SET Username = '" & uname & "', Password = '" & pass & "', ConfirmPassword = '" & confirmpass & "' WHERE UserID = '" & uid & "'", connection)
            command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Succesfully Updated!")
            LoadDataInGrid()
        Else
            MessageBox.Show("Password are not match")
        End If
    End Sub

    Private Sub deleteusersBtn_Click(sender As Object, e As EventArgs) Handles deleteusersBtn.Click
        If MessageBox.Show("Are you sure do you to delete?", "Delete Document", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim uid As Integer = createusersidTxt.Text
            connection.Open()
            Dim command As New SqlCommand("Delete Users where UserID = '" & uid & "'", connection)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Deleted")
            LoadDataInGrid()
            connection.Close()
        End If
    End Sub
End Class