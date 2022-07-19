<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim Customer_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Phone_numberLabel As System.Windows.Forms.Label
        Dim Book_InterestedLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Customer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookstoremanageDataSet = New WindowsApplication1.bookstoremanageDataSet()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Book_InterestedTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddcustomerTableAdapter = New WindowsApplication1.bookstoremanageDataSetTableAdapters.addcustomerTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager()
        Me.AddcustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddcustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AddcustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Customer_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Phone_numberLabel = New System.Windows.Forms.Label()
        Book_InterestedLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.AddcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookstoremanageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddcustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddcustomerBindingNavigator.SuspendLayout()
        CType(Me.AddcustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Customer_NameLabel
        '
        Customer_NameLabel.AutoSize = True
        Customer_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_NameLabel.Location = New System.Drawing.Point(56, 82)
        Customer_NameLabel.Name = "Customer_NameLabel"
        Customer_NameLabel.Size = New System.Drawing.Size(142, 20)
        Customer_NameLabel.TabIndex = 25
        Customer_NameLabel.Text = "Customer Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(61, 123)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(80, 20)
        AddressLabel.TabIndex = 27
        AddressLabel.Text = "Address:"
        '
        'Phone_numberLabel
        '
        Phone_numberLabel.AutoSize = True
        Phone_numberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_numberLabel.Location = New System.Drawing.Point(61, 163)
        Phone_numberLabel.Name = "Phone_numberLabel"
        Phone_numberLabel.Size = New System.Drawing.Size(130, 20)
        Phone_numberLabel.TabIndex = 29
        Phone_numberLabel.Text = "Phone number:"
        '
        'Book_InterestedLabel
        '
        Book_InterestedLabel.AutoSize = True
        Book_InterestedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Book_InterestedLabel.Location = New System.Drawing.Point(57, 204)
        Book_InterestedLabel.Name = "Book_InterestedLabel"
        Book_InterestedLabel.Size = New System.Drawing.Size(143, 20)
        Book_InterestedLabel.TabIndex = 31
        Book_InterestedLabel.Text = "Book Interested:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Aqua
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Customer_NameLabel)
        Me.Panel1.Controls.Add(Me.Customer_NameTextBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(Phone_numberLabel)
        Me.Panel1.Controls.Add(Me.Phone_numberTextBox)
        Me.Panel1.Controls.Add(Book_InterestedLabel)
        Me.Panel1.Controls.Add(Me.Book_InterestedTextBox)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(57, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 430)
        Me.Panel1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(276, 369)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 39)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(97, 369)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 39)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Customer_NameTextBox
        '
        Me.Customer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddcustomerBindingSource, "Customer Name", True))
        Me.Customer_NameTextBox.Location = New System.Drawing.Point(225, 84)
        Me.Customer_NameTextBox.Multiline = True
        Me.Customer_NameTextBox.Name = "Customer_NameTextBox"
        Me.Customer_NameTextBox.Size = New System.Drawing.Size(177, 26)
        Me.Customer_NameTextBox.TabIndex = 26
        '
        'AddcustomerBindingSource
        '
        Me.AddcustomerBindingSource.DataMember = "addcustomer"
        Me.AddcustomerBindingSource.DataSource = Me.BookstoremanageDataSet
        '
        'BookstoremanageDataSet
        '
        Me.BookstoremanageDataSet.DataSetName = "bookstoremanageDataSet"
        Me.BookstoremanageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddcustomerBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(225, 125)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(177, 26)
        Me.AddressTextBox.TabIndex = 28
        '
        'Phone_numberTextBox
        '
        Me.Phone_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddcustomerBindingSource, "Phone number", True))
        Me.Phone_numberTextBox.Location = New System.Drawing.Point(226, 165)
        Me.Phone_numberTextBox.Multiline = True
        Me.Phone_numberTextBox.Name = "Phone_numberTextBox"
        Me.Phone_numberTextBox.Size = New System.Drawing.Size(177, 26)
        Me.Phone_numberTextBox.TabIndex = 30
        '
        'Book_InterestedTextBox
        '
        Me.Book_InterestedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddcustomerBindingSource, "Book Interested", True))
        Me.Book_InterestedTextBox.Location = New System.Drawing.Point(226, 206)
        Me.Book_InterestedTextBox.Multiline = True
        Me.Book_InterestedTextBox.Name = "Book_InterestedTextBox"
        Me.Book_InterestedTextBox.Size = New System.Drawing.Size(177, 26)
        Me.Book_InterestedTextBox.TabIndex = 32
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(276, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 39)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(97, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 39)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(124, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ADD CUSTOMER"
        '
        'AddcustomerTableAdapter
        '
        Me.AddcustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.addbookTableAdapter = Nothing
        Me.TableAdapterManager.addcustomerTableAdapter = Me.AddcustomerTableAdapter
        Me.TableAdapterManager.adddealerTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.purchaseTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AddcustomerBindingNavigator
        '
        Me.AddcustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AddcustomerBindingNavigator.BindingSource = Me.AddcustomerBindingSource
        Me.AddcustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AddcustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AddcustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AddcustomerBindingNavigatorSaveItem})
        Me.AddcustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AddcustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AddcustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AddcustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AddcustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AddcustomerBindingNavigator.Name = "AddcustomerBindingNavigator"
        Me.AddcustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AddcustomerBindingNavigator.Size = New System.Drawing.Size(1095, 25)
        Me.AddcustomerBindingNavigator.TabIndex = 1
        Me.AddcustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AddcustomerBindingNavigatorSaveItem
        '
        Me.AddcustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddcustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("AddcustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AddcustomerBindingNavigatorSaveItem.Name = "AddcustomerBindingNavigatorSaveItem"
        Me.AddcustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AddcustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AddcustomerDataGridView
        '
        Me.AddcustomerDataGridView.AutoGenerateColumns = False
        Me.AddcustomerDataGridView.BackgroundColor = System.Drawing.Color.Cyan
        Me.AddcustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddcustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AddcustomerDataGridView.DataSource = Me.AddcustomerBindingSource
        Me.AddcustomerDataGridView.GridColor = System.Drawing.Color.Blue
        Me.AddcustomerDataGridView.Location = New System.Drawing.Point(560, 66)
        Me.AddcustomerDataGridView.Name = "AddcustomerDataGridView"
        Me.AddcustomerDataGridView.Size = New System.Drawing.Size(498, 430)
        Me.AddcustomerDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Customer Name"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Customer Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Address"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Phone number"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Book Interested"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Book Interested"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1095, 550)
        Me.Controls.Add(Me.AddcustomerDataGridView)
        Me.Controls.Add(Me.AddcustomerBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AddcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookstoremanageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddcustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddcustomerBindingNavigator.ResumeLayout(False)
        Me.AddcustomerBindingNavigator.PerformLayout()
        CType(Me.AddcustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BookstoremanageDataSet As WindowsApplication1.bookstoremanageDataSet
    Friend WithEvents AddcustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddcustomerTableAdapter As WindowsApplication1.bookstoremanageDataSetTableAdapters.addcustomerTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AddcustomerBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddcustomerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Customer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_numberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Book_InterestedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddcustomerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewButtonColumn
End Class
