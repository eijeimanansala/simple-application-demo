<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfirmPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Application.Database1DataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.userstbackBtn = New System.Windows.Forms.Button()
        Me.deleteusersBtn = New System.Windows.Forms.Button()
        Me.updateusersBtn = New System.Windows.Forms.Button()
        Me.addusersBtn = New System.Windows.Forms.Button()
        Me.createconfirmpassTxt = New System.Windows.Forms.TextBox()
        Me.createpasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.createusernameTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.createusersidTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsersTableAdapter = New Application.Database1DataSetTableAdapters.UsersTableAdapter()
        Me.searchuseridBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.ConfirmPasswordDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.UsersBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(381, 106)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.Size = New System.Drawing.Size(403, 264)
        Me.DataGridView2.TabIndex = 40
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConfirmPasswordDataGridViewTextBoxColumn
        '
        Me.ConfirmPasswordDataGridViewTextBoxColumn.DataPropertyName = "ConfirmPassword"
        Me.ConfirmPasswordDataGridViewTextBoxColumn.HeaderText = "ConfirmPassword"
        Me.ConfirmPasswordDataGridViewTextBoxColumn.Name = "ConfirmPasswordDataGridViewTextBoxColumn"
        Me.ConfirmPasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(243, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(330, 44)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Food Inventory Mangement System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add Users"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(-8, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 73)
        Me.Panel1.TabIndex = 25
        '
        'userstbackBtn
        '
        Me.userstbackBtn.BackColor = System.Drawing.Color.Maroon
        Me.userstbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userstbackBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userstbackBtn.ForeColor = System.Drawing.Color.White
        Me.userstbackBtn.Location = New System.Drawing.Point(157, 336)
        Me.userstbackBtn.Name = "userstbackBtn"
        Me.userstbackBtn.Size = New System.Drawing.Size(112, 32)
        Me.userstbackBtn.TabIndex = 35
        Me.userstbackBtn.Text = "Back to Main Menu"
        Me.userstbackBtn.UseVisualStyleBackColor = False
        '
        'deleteusersBtn
        '
        Me.deleteusersBtn.BackColor = System.Drawing.Color.Maroon
        Me.deleteusersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteusersBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteusersBtn.ForeColor = System.Drawing.Color.White
        Me.deleteusersBtn.Location = New System.Drawing.Point(273, 279)
        Me.deleteusersBtn.Name = "deleteusersBtn"
        Me.deleteusersBtn.Size = New System.Drawing.Size(75, 28)
        Me.deleteusersBtn.TabIndex = 36
        Me.deleteusersBtn.Text = "Delete"
        Me.deleteusersBtn.UseVisualStyleBackColor = False
        '
        'updateusersBtn
        '
        Me.updateusersBtn.BackColor = System.Drawing.Color.Maroon
        Me.updateusersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateusersBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateusersBtn.ForeColor = System.Drawing.Color.White
        Me.updateusersBtn.Location = New System.Drawing.Point(169, 279)
        Me.updateusersBtn.Name = "updateusersBtn"
        Me.updateusersBtn.Size = New System.Drawing.Size(75, 28)
        Me.updateusersBtn.TabIndex = 37
        Me.updateusersBtn.Text = "Update"
        Me.updateusersBtn.UseVisualStyleBackColor = False
        '
        'addusersBtn
        '
        Me.addusersBtn.BackColor = System.Drawing.Color.Maroon
        Me.addusersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addusersBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addusersBtn.ForeColor = System.Drawing.Color.White
        Me.addusersBtn.Location = New System.Drawing.Point(58, 279)
        Me.addusersBtn.Name = "addusersBtn"
        Me.addusersBtn.Size = New System.Drawing.Size(75, 28)
        Me.addusersBtn.TabIndex = 38
        Me.addusersBtn.Text = "Add"
        Me.addusersBtn.UseVisualStyleBackColor = False
        '
        'createconfirmpassTxt
        '
        Me.createconfirmpassTxt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createconfirmpassTxt.ForeColor = System.Drawing.Color.Black
        Me.createconfirmpassTxt.Location = New System.Drawing.Point(169, 221)
        Me.createconfirmpassTxt.Name = "createconfirmpassTxt"
        Me.createconfirmpassTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.createconfirmpassTxt.Size = New System.Drawing.Size(186, 23)
        Me.createconfirmpassTxt.TabIndex = 31
        '
        'createpasswordTxt
        '
        Me.createpasswordTxt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createpasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.createpasswordTxt.Location = New System.Drawing.Point(169, 190)
        Me.createpasswordTxt.Name = "createpasswordTxt"
        Me.createpasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.createpasswordTxt.Size = New System.Drawing.Size(186, 23)
        Me.createpasswordTxt.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(10, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Confirm Password"
        '
        'createusernameTxt
        '
        Me.createusernameTxt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createusernameTxt.ForeColor = System.Drawing.Color.Black
        Me.createusernameTxt.Location = New System.Drawing.Point(169, 152)
        Me.createusernameTxt.Name = "createusernameTxt"
        Me.createusernameTxt.Size = New System.Drawing.Size(186, 23)
        Me.createusernameTxt.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(37, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Password"
        '
        'createusersidTxt
        '
        Me.createusersidTxt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createusersidTxt.ForeColor = System.Drawing.Color.Black
        Me.createusersidTxt.Location = New System.Drawing.Point(529, 388)
        Me.createusersidTxt.Name = "createusersidTxt"
        Me.createusersidTxt.Size = New System.Drawing.Size(64, 23)
        Me.createusersidTxt.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(36, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(448, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "UsersID"
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'searchuseridBtn
        '
        Me.searchuseridBtn.BackColor = System.Drawing.Color.Maroon
        Me.searchuseridBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchuseridBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchuseridBtn.ForeColor = System.Drawing.Color.White
        Me.searchuseridBtn.Location = New System.Drawing.Point(608, 385)
        Me.searchuseridBtn.Name = "searchuseridBtn"
        Me.searchuseridBtn.Size = New System.Drawing.Size(87, 30)
        Me.searchuseridBtn.TabIndex = 41
        Me.searchuseridBtn.Text = "Search"
        Me.searchuseridBtn.UseVisualStyleBackColor = False
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(806, 456)
        Me.Controls.Add(Me.searchuseridBtn)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.userstbackBtn)
        Me.Controls.Add(Me.deleteusersBtn)
        Me.Controls.Add(Me.updateusersBtn)
        Me.Controls.Add(Me.addusersBtn)
        Me.Controls.Add(Me.createconfirmpassTxt)
        Me.Controls.Add(Me.createpasswordTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.createusernameTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.createusersidTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents userstbackBtn As System.Windows.Forms.Button
    Friend WithEvents deleteusersBtn As System.Windows.Forms.Button
    Friend WithEvents updateusersBtn As System.Windows.Forms.Button
    Friend WithEvents addusersBtn As System.Windows.Forms.Button
    Friend WithEvents createconfirmpassTxt As System.Windows.Forms.TextBox
    Friend WithEvents createpasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents createusernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents createusersidTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet As Application.Database1DataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As Application.Database1DataSetTableAdapters.UsersTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfirmPasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents searchuseridBtn As System.Windows.Forms.Button
End Class
