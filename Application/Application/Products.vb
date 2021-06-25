Imports System.Data.SqlClient
Public Class Products
    Dim connection As New Connection

    Private Sub addproductBtn_Click(sender As Object, e As EventArgs) Handles addproductBtn.Click
        Dim pid As Integer = productidTxt.Text
        Dim pname As String = productnameTxt.Text
        Dim pquantity As String = productquantityTxt.Text
        Dim pdescription As String = productdescriptionTxt.Text
        Dim pcategory As String = productcategory.Text
        connection.con.Open()
        Dim command As New SqlCommand("Insert into Products values ('" & pid & "', '" & pname & "', '" & pquantity & "', '" & pdescription & "', '" & pcategory & "')", connection.con)
        command.ExecuteNonQuery()
        connection.con.Close()
        MessageBox.Show("Successfully Inserted")
        LoadDataInGrid()

    End Sub
    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("Select * from Products", connection.con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Database1DataSet.Products)

    End Sub

    Private Sub updateproductBtn_Click(sender As Object, e As EventArgs) Handles updateproductBtn.Click
        Dim pid As Integer = productidTxt.Text
        Dim pname As String = productnameTxt.Text
        Dim pquantity As String = productquantityTxt.Text
        Dim pdescription As String = productdescriptionTxt.Text
        Dim pcategory As String = productcategory.Text
        connection.con.Open()
        Dim command As New SqlCommand("Update Products SET ProductName= '" & pname & "', Quantity = '" & pquantity & "', Description = '" & pdescription & "', Category = '" & pcategory & "' WHERE ProductID = '" & pid & "' ", connection.con)
        command.ExecuteNonQuery()
        connection.con.Close()
        MessageBox.Show("Successfully Updated")
        LoadDataInGrid()
    End Sub

    Private Sub productdeleteBtn_Click(sender As Object, e As EventArgs) Handles productdeleteBtn.Click
        If MessageBox.Show("Are you sure do you to delete?", "Delete Document", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim pid As Integer = productidTxt.Text
            connection.con.Open()
            Dim command As New SqlCommand("Delete Products where ProductID = '" & pid & "'", connection.con)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Deleted")
            LoadDataInGrid()
            connection.con.Close()
        End If
    End Sub

    Private Sub productmenuBtn_Click(sender As Object, e As EventArgs) Handles productmenuBtn.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class