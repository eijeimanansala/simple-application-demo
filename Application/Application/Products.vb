Imports System.Data.SqlClient
Public Class Products
    Dim product As New Product
    Dim pid As String
    Dim pname As String
    Dim pquantity As String
    Dim pdescription As String
    Dim pcategory As String
    Dim index As Integer

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
            deleteProduct()
        End If
    End Sub

    Private Sub productmenuBtn_Click(sender As Object, e As EventArgs) Handles productmenuBtn.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub searchproductidBtn_Click(sender As Object, e As EventArgs) Handles searchproductidBtn.Click
        pid = productidTxt.Text
        If pid = "" Then
            Dim command As New SqlCommand("SELECT * FROM PRODUCTS", product.con)
            Dim sda As New SqlDataAdapter(command)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt
        Else
            Dim command As New SqlCommand("SELECT * FROM PRODUCTS WHERE ProductID = '" & pid & "' ", product.con)
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
        pid = productidTxt.Text
        pname = productnameTxt.Text
        pquantity = productquantityTxt.Text
        pdescription = productdescriptionTxt.Text
        pcategory = productcategory.Text

        product.productid = pid
        product.productname = pname
        product.productquantity = pquantity
        product.productdescript = pdescription
        product.productcategory = pcategory
        product.createProduct()

        productidTxt.Clear()
        productnameTxt.Clear()
        productquantityTxt.Clear()
        productdescriptionTxt.Clear()
    End Sub
    'Update Product Sub Class
    Private Sub updatedProduct()
        pid = productidTxt.Text
        pname = productnameTxt.Text
        pquantity = productquantityTxt.Text
        pdescription = productdescriptionTxt.Text
        pcategory = productcategory.Text

        product.productid = pid
        product.productname = pname
        product.productquantity = pquantity
        product.productdescript = pdescription
        product.productcategory = pcategory

        If productidTxt.Text = "" Or productnameTxt.Text = "" Or productquantityTxt.Text = "" Or productdeleteBtn.Text = "" Or productcategory.Text = "" Then
            MessageBox.Show("All fields are required!")
        Else
            product.updateProduct()
            productidTxt.Clear()
            productnameTxt.Clear()
            productquantityTxt.Clear()
            productdescriptionTxt.Clear()
            productcategory.SelectedItem = Nothing
        End If
    End Sub
    'Delete Product Sub Class
    Private Sub deleteProduct()
        pid = productidTxt.Text
        product.productid = pid
        product.deleteProduct()
        LoadDataInGrid()

        productidTxt.Clear()
        productnameTxt.Clear()
        productquantityTxt.Clear()
        productdescriptionTxt.Clear()
        productcategory.SelectedItem = Nothing
    End Sub
    'Load Data in Grind sub class
    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("Select * from Products", product.con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub productidTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles productidTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchproductidBtn_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        productidTxt.Text = selectedRow.Cells(0).Value.ToString()
        productnameTxt.Text = selectedRow.Cells(1).Value.ToString()
        productquantityTxt.Text = selectedRow.Cells(2).Value.ToString()
        productdescriptionTxt.Text = selectedRow.Cells(3).Value.ToString()
        productcategory.SelectedItem = selectedRow.Cells(4).Value.ToString()
    End Sub
End Class