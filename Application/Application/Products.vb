Imports System.Data.SqlClient
Public Class Products
    Dim connection As New Connection

    Private Sub addproductBtn_Click(sender As Object, e As EventArgs) Handles addproductBtn.Click
        addProduct()
        LoadDataInGrid()
    End Sub
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Database1DataSet.Products)

    End Sub

    Private Sub updateproductBtn_Click(sender As Object, e As EventArgs) Handles updateproductBtn.Click
        updatedProduct()
        LoadDataInGrid()
    End Sub

    Private Sub productdeleteBtn_Click(sender As Object, e As EventArgs) Handles productdeleteBtn.Click
        If MessageBox.Show("Are you sure do you to delete?", "Delete Data", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim pid As Integer = productidTxt.Text
            connection.productid = pid
            connection.deleteProduct()
            LoadDataInGrid()
            productidTxt.Text = ""
        End If
    End Sub

    Private Sub productmenuBtn_Click(sender As Object, e As EventArgs) Handles productmenuBtn.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub searchproductidBtn_Click(sender As Object, e As EventArgs) Handles searchproductidBtn.Click
        Dim pid As String = productidTxt.Text
        If pid = "" Then
            Dim command As New SqlCommand("SELECT * FROM PRODUCTS", connection.con)
            Dim sda As New SqlDataAdapter(command)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt
        Else
            Dim command As New SqlCommand("SELECT * FROM PRODUCTS WHERE ProductID = '" & pid & "' ", connection.con)
            Dim sda As New SqlDataAdapter(command)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub productidTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles productidTxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub productquantityTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles productquantityTxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only")
        End If
    End Sub

    Private Sub productnameTxt_TextChanged(sender As Object, e As EventArgs) Handles productnameTxt.TextChanged
        productnameTxt.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(productnameTxt.Text)
        productnameTxt.Select(productnameTxt.Text.Length, 0)
    End Sub

    Private Sub productdescriptionTxt_TextChanged(sender As Object, e As EventArgs) Handles productdescriptionTxt.TextChanged
        productdescriptionTxt.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(productdescriptionTxt.Text)
        productdescriptionTxt.Select(productdescriptionTxt.Text.Length, 0)
    End Sub
    'Add Product Sub Class
    Private Sub addProduct()
        Dim pid As Integer = productidTxt.Text
        Dim pname As String = productnameTxt.Text
        Dim pquantity As String = productquantityTxt.Text
        Dim pdescription As String = productdescriptionTxt.Text
        Dim pcategory As String = productcategory.Text

        connection.productid = pid
        connection.productname = pname
        connection.productquantity = pquantity
        connection.productdescript = pdescription
        connection.productcategory = pcategory

        connection.createProduct()

        productidTxt.Text = ""
        productnameTxt.Text = ""
        productquantityTxt.Text = ""
        productdescriptionTxt.Text = ""
        productcategory.Text = ""
    End Sub
    'Update Product Sub Class
    Private Sub updatedProduct()
        Dim pid As Integer = productidTxt.Text
        Dim pname As String = productnameTxt.Text
        Dim pquantity As String = productquantityTxt.Text
        Dim pdescription As String = productdescriptionTxt.Text
        Dim pcategory As String = productcategory.Text

        connection.productid = pid
        connection.productname = pname
        connection.productquantity = pquantity
        connection.productdescript = pdescription
        connection.productcategory = pcategory
        connection.updateProduct()

        productidTxt.Text = ""
        productnameTxt.Text = ""
        productquantityTxt.Text = ""
        productdescriptionTxt.Text = ""
        productcategory.Text = ""
    End Sub
    'Load Data in Grind sub class
    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("Select * from Products", connection.con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class