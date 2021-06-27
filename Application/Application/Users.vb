Imports System.Data.SqlClient
Public Class Users
    Dim connection As New Connection
    Dim uid As String
    Dim uname As String
    Dim pass As String
    Dim confirmpass As String

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Database1DataSet.Users)

    End Sub
    Private Sub addusersBtn_Click(sender As Object, e As EventArgs) Handles addusersBtn.Click
        addingUsers()
    End Sub
    Private Sub updateusersBtn_Click(sender As Object, e As EventArgs) Handles updateusersBtn.Click
        updatedUsers()
    End Sub
    Private Sub deleteusersBtn_Click(sender As Object, e As EventArgs) Handles deleteusersBtn.Click
        If MessageBox.Show("Are you sure do you to delete?", "Delete Document", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            uid = createusersidTxt.Text
            connection.uid = uid
            connection.deleteUser()
            LoadDataInGrid()
        End If
    End Sub

    Private Sub userstbackBtn_Click(sender As Object, e As EventArgs) Handles userstbackBtn.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub searchuseridBtn_Click(sender As Object, e As EventArgs) Handles searchuseridBtn.Click
        uid = createusersidTxt.Text
        If uid = "" Then
            Dim command As New SqlCommand("SELECT * FROM Users", connection.con)
            Dim sda As New SqlDataAdapter(command)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView2.DataSource = dt
        Else
            Dim command As New SqlCommand("SELECT * FROM Users WHERE UserID = '" & uid & "'", connection.con)
            Dim sda As New SqlDataAdapter(command)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView2.DataSource = dt
        End If
    End Sub

    'Add user private sub class
    Private Sub addingUsers()
        uname = createusernameTxt.Text
        pass = createpasswordTxt.Text
        confirmpass = createconfirmpassTxt.Text

        connection.username = uname
        connection.password = pass
        connection.confirmpassword = confirmpass

        If pass = confirmpass Then
            connection.addUser()
        Else
            MessageBox.Show("Password are not match")
        End If
    End Sub

    'Update user private sub class
    Private Sub updatedUsers()
        uid = createusersidTxt.Text
        uname = createusernameTxt.Text
        pass = createpasswordTxt.Text
        confirmpass = createconfirmpassTxt.Text

        connection.uid = uid
        connection.username = uname
        connection.password = pass
        connection.confirmpassword = confirmpass

        If connection.password = connection.confirmpassword Then
            connection.updateUser()
            LoadDataInGrid()
        Else
            MessageBox.Show("Password are not match")
        End If
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

    Private Sub createpasswordTxt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub createconfirmpassTxt_TextChanged(sender As Object, e As EventArgs) Handles createconfirmpassTxt.TextChanged, createpasswordTxt.TextChanged

    End Sub

    Private Sub createusersidTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles createusersidTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchuseridBtn_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
End Class