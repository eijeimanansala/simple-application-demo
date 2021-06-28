Imports System.Data.SqlClient
Public Class Connection
    Private constring As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Desktop\Desktop\demo-project\Application\Application\Database1.mdf;Integrated Security=True"
    Public con As New SqlConnection(constring)

    'Public property variables for Products
    Public Property productid As Integer
    Public Property productname As String
    Public Property productquantity As String
    Public Property productdescript As String
    Public Property productcategory As String

    'Public property variables for Users
    Public Property uid As Integer
    Public Property username As String
    Public Property password As String
    Public Property confirmpassword As String

    Public Sub createProduct()
        con.Open()
        Dim command As New SqlCommand("Insert into Products Values (@pid, @productname, @productquantity, @productdescript, @productcategory)", con)
        command.Parameters.AddWithValue("@pid", productid)
        command.Parameters.AddWithValue("@productname", productname)
        command.Parameters.AddWithValue("@productquantity", productquantity)
        command.Parameters.AddWithValue("@productdescript", productdescript)
        command.Parameters.AddWithValue("@productcategory", productcategory)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Inserted")
    End Sub

    Public Sub updateProduct()
        con.Open()
        Dim command As New SqlCommand("Update Products SET ProductName= @productname, Quantity = @productquantity, Description = @productdescription, Category = @productcategory WHERE ProductID = @pid ", con)
        command.Parameters.AddWithValue("@pid", productid)
        command.Parameters.AddWithValue("@productname", productname)
        command.Parameters.AddWithValue("@productquantity", productquantity)
        command.Parameters.AddWithValue("@productdescript", productdescript)
        command.Parameters.AddWithValue("@productcategory", productcategory)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Updated")
    End Sub

    Public Sub deleteProduct()
        con.Open()
        Dim command As New SqlCommand("Delete Products where ProductID = @pid ", con)
        command.Parameters.AddWithValue("@pid", productid)
        command.ExecuteNonQuery()
        MessageBox.Show("Successfully Deleted")
        con.Close()
    End Sub

    Public Sub addUser()
        con.Open()
        Dim command As New SqlCommand("INSERT INTO USERS VALUES (@username, @password, @confirmpassword)", con)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        command.Parameters.AddWithValue("@confirmpassword", confirmpassword)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Succesfully Inserted!")
    End Sub

    Public Sub updateUser()
        con.Open()
        Dim command As New SqlCommand("UPDATE USERS SET Username = @username, Password = @password, ConfirmPassword = @confirmpassword WHERE UserID = @userid" & uid & "'", con)
        command.Parameters.AddWithValue("@userid", uid)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        command.Parameters.AddWithValue("@confirmpassword", confirmpassword)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Succesfully Updated!")
    End Sub

    Public Sub deleteUser()
        con.Open()
        Dim command As New SqlCommand("Delete Users where UserID = @userid", con)
        command.Parameters.AddWithValue("@userid", uid)
        command.ExecuteNonQuery()
        MessageBox.Show("Successfully Deleted")
        con.Close()
    End Sub
End Class
