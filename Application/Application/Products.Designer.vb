<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.updateproductBtn = New System.Windows.Forms.Button()
        Me.addproductBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.productdescriptionTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.productcategory = New System.Windows.Forms.ComboBox()
        Me.productdeleteBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Application.Database1DataSet()
        Me.ProductsTableAdapter = New Application.Database1DataSetTableAdapters.ProductsTableAdapter()
        Me.productquantityTxt = New System.Windows.Forms.TextBox()
        Me.productnameTxt = New System.Windows.Forms.TextBox()
        Me.productidTxt = New System.Windows.Forms.TextBox()
        Me.productmenuBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(823, 73)
        Me.Panel1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(243, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(330, 44)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Food Inventory Mangement System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add Products" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updateproductBtn
        '
        Me.updateproductBtn.BackColor = System.Drawing.Color.Maroon
        Me.updateproductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateproductBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateproductBtn.ForeColor = System.Drawing.Color.White
        Me.updateproductBtn.Location = New System.Drawing.Point(177, 342)
        Me.updateproductBtn.Name = "updateproductBtn"
        Me.updateproductBtn.Size = New System.Drawing.Size(75, 28)
        Me.updateproductBtn.TabIndex = 21
        Me.updateproductBtn.Text = "Update"
        Me.updateproductBtn.UseVisualStyleBackColor = False
        '
        'addproductBtn
        '
        Me.addproductBtn.BackColor = System.Drawing.Color.Maroon
        Me.addproductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addproductBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addproductBtn.ForeColor = System.Drawing.Color.White
        Me.addproductBtn.Location = New System.Drawing.Point(66, 342)
        Me.addproductBtn.Name = "addproductBtn"
        Me.addproductBtn.Size = New System.Drawing.Size(75, 28)
        Me.addproductBtn.TabIndex = 22
        Me.addproductBtn.Text = "Add"
        Me.addproductBtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(45, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(26, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(41, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ProductID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(31, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Description"
        '
        'productdescriptionTxt
        '
        Me.productdescriptionTxt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productdescriptionTxt.ForeColor = System.Drawing.Color.Black
        Me.productdescriptionTxt.Location = New System.Drawing.Point(177, 254)
        Me.productdescriptionTxt.Name = "productdescriptionTxt"
        Me.productdescriptionTxt.Size = New System.Drawing.Size(186, 23)
        Me.productdescriptionTxt.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(41, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Category"
        '
        'productcategory
        '
        Me.productcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.productcategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productcategory.FormattingEnabled = True
        Me.productcategory.Items.AddRange(New Object() {"Fish", "Meat", "Vegetables", "Fruits"})
        Me.productcategory.Location = New System.Drawing.Point(177, 287)
        Me.productcategory.Name = "productcategory"
        Me.productcategory.Size = New System.Drawing.Size(187, 23)
        Me.productcategory.TabIndex = 23
        '
        'productdeleteBtn
        '
        Me.productdeleteBtn.BackColor = System.Drawing.Color.Maroon
        Me.productdeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.productdeleteBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productdeleteBtn.ForeColor = System.Drawing.Color.White
        Me.productdeleteBtn.Location = New System.Drawing.Point(281, 342)
        Me.productdeleteBtn.Name = "productdeleteBtn"
        Me.productdeleteBtn.Size = New System.Drawing.Size(75, 28)
        Me.productdeleteBtn.TabIndex = 21
        Me.productdeleteBtn.Text = "Delete"
        Me.productdeleteBtn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(389, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(412, 264)
        Me.DataGridView1.TabIndex = 24
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'productquantityTxt
        '
        Me.productquantityTxt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productquantityTxt.ForeColor = System.Drawing.Color.Black
        Me.productquantityTxt.Location = New System.Drawing.Point(177, 225)
        Me.productquantityTxt.Name = "productquantityTxt"
        Me.productquantityTxt.Size = New System.Drawing.Size(186, 23)
        Me.productquantityTxt.TabIndex = 18
        '
        'productnameTxt
        '
        Me.productnameTxt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productnameTxt.ForeColor = System.Drawing.Color.Black
        Me.productnameTxt.Location = New System.Drawing.Point(177, 187)
        Me.productnameTxt.Name = "productnameTxt"
        Me.productnameTxt.Size = New System.Drawing.Size(186, 23)
        Me.productnameTxt.TabIndex = 18
        '
        'productidTxt
        '
        Me.productidTxt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productidTxt.ForeColor = System.Drawing.Color.Black
        Me.productidTxt.Location = New System.Drawing.Point(177, 149)
        Me.productidTxt.Name = "productidTxt"
        Me.productidTxt.Size = New System.Drawing.Size(186, 23)
        Me.productidTxt.TabIndex = 18
        '
        'productmenuBtn
        '
        Me.productmenuBtn.BackColor = System.Drawing.Color.Maroon
        Me.productmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.productmenuBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productmenuBtn.ForeColor = System.Drawing.Color.White
        Me.productmenuBtn.Location = New System.Drawing.Point(153, 403)
        Me.productmenuBtn.Name = "productmenuBtn"
        Me.productmenuBtn.Size = New System.Drawing.Size(145, 40)
        Me.productmenuBtn.TabIndex = 25
        Me.productmenuBtn.Text = "Back to Menu"
        Me.productmenuBtn.UseVisualStyleBackColor = False
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(822, 493)
        Me.Controls.Add(Me.productmenuBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.productcategory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.productdeleteBtn)
        Me.Controls.Add(Me.updateproductBtn)
        Me.Controls.Add(Me.addproductBtn)
        Me.Controls.Add(Me.productidTxt)
        Me.Controls.Add(Me.productnameTxt)
        Me.Controls.Add(Me.productquantityTxt)
        Me.Controls.Add(Me.productdescriptionTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents updateproductBtn As System.Windows.Forms.Button
    Friend WithEvents addproductBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents productdescriptionTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents productcategory As System.Windows.Forms.ComboBox
    Friend WithEvents productdeleteBtn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet As Application.Database1DataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As Application.Database1DataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents productquantityTxt As System.Windows.Forms.TextBox
    Friend WithEvents productnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents productidTxt As System.Windows.Forms.TextBox
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productmenuBtn As System.Windows.Forms.Button
End Class
