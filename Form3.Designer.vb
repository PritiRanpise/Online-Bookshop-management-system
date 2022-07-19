<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Book_NameLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim Book_NumberLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim PagesLabel As System.Windows.Forms.Label
        Dim PublicationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PublicationTextBox = New System.Windows.Forms.TextBox()
        Me.PagesTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Book_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Book_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.AddbookDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddbookBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AddbookBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AddbookTableAdapter = New WindowsApplication1.bookstoremanageDataSetTableAdapters.addbookTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager()
        Me.AddbookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookstoremanageDataSet = New WindowsApplication1.bookstoremanageDataSet()
        Me.BookNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PublicationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        CategoryLabel = New System.Windows.Forms.Label()
        Book_NameLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        Book_NumberLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        PagesLabel = New System.Windows.Forms.Label()
        PublicationLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AddbookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddbookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddbookBindingNavigator.SuspendLayout()
        CType(Me.AddbookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookstoremanageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.ForeColor = System.Drawing.Color.Blue
        CategoryLabel.Location = New System.Drawing.Point(115, 172)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(86, 20)
        CategoryLabel.TabIndex = 78
        CategoryLabel.Text = "Category:"
        '
        'Book_NameLabel
        '
        Book_NameLabel.AutoSize = True
        Book_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Book_NameLabel.ForeColor = System.Drawing.Color.Blue
        Book_NameLabel.Location = New System.Drawing.Point(115, 125)
        Book_NameLabel.Name = "Book_NameLabel"
        Book_NameLabel.Size = New System.Drawing.Size(106, 20)
        Book_NameLabel.TabIndex = 92
        Book_NameLabel.Text = "Book Name:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AuthorLabel.ForeColor = System.Drawing.Color.Blue
        AuthorLabel.Location = New System.Drawing.Point(557, 80)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(68, 20)
        AuthorLabel.TabIndex = 80
        AuthorLabel.Text = "Author:"
        '
        'Book_NumberLabel
        '
        Book_NumberLabel.AutoSize = True
        Book_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Book_NumberLabel.ForeColor = System.Drawing.Color.Blue
        Book_NumberLabel.Location = New System.Drawing.Point(115, 76)
        Book_NumberLabel.Name = "Book_NumberLabel"
        Book_NumberLabel.Size = New System.Drawing.Size(122, 20)
        Book_NumberLabel.TabIndex = 90
        Book_NumberLabel.Text = "Book Number:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.Location = New System.Drawing.Point(557, 216)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(64, 24)
        PriceLabel.TabIndex = 109
        PriceLabel.Text = "Price:"
        '
        'PagesLabel
        '
        PagesLabel.AutoSize = True
        PagesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PagesLabel.Location = New System.Drawing.Point(557, 166)
        PagesLabel.Name = "PagesLabel"
        PagesLabel.Size = New System.Drawing.Size(74, 24)
        PagesLabel.TabIndex = 107
        PagesLabel.Text = "Pages:"
        '
        'PublicationLabel
        '
        PublicationLabel.AutoSize = True
        PublicationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PublicationLabel.Location = New System.Drawing.Point(557, 123)
        PublicationLabel.Name = "PublicationLabel"
        PublicationLabel.Size = New System.Drawing.Size(119, 24)
        PublicationLabel.TabIndex = 110
        PublicationLabel.Text = "Publication:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(411, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 25)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Add Books"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(163, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 47)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(342, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 46)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(PublicationLabel)
        Me.GroupBox1.Controls.Add(Me.PublicationTextBox)
        Me.GroupBox1.Controls.Add(PagesLabel)
        Me.GroupBox1.Controls.Add(Me.PagesTextBox)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Book_NumberLabel)
        Me.GroupBox1.Controls.Add(Me.Book_NumberTextBox)
        Me.GroupBox1.Controls.Add(Book_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Book_NameTextBox)
        Me.GroupBox1.Controls.Add(Me.CategoryTextBox)
        Me.GroupBox1.Controls.Add(CategoryLabel)
        Me.GroupBox1.Controls.Add(AuthorLabel)
        Me.GroupBox1.Controls.Add(Me.AuthorTextBox)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.AddbookDataGridView)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(68, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(998, 604)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'PublicationTextBox
        '
        Me.PublicationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Publication", True))
        Me.PublicationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicationTextBox.Location = New System.Drawing.Point(699, 120)
        Me.PublicationTextBox.Multiline = True
        Me.PublicationTextBox.Name = "PublicationTextBox"
        Me.PublicationTextBox.Size = New System.Drawing.Size(192, 25)
        Me.PublicationTextBox.TabIndex = 111
        '
        'PagesTextBox
        '
        Me.PagesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Pages", True))
        Me.PagesTextBox.Location = New System.Drawing.Point(699, 172)
        Me.PagesTextBox.Multiline = True
        Me.PagesTextBox.Name = "PagesTextBox"
        Me.PagesTextBox.Size = New System.Drawing.Size(192, 24)
        Me.PagesTextBox.TabIndex = 108
        '
        'PriceTextBox1
        '
        Me.PriceTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Price", True))
        Me.PriceTextBox1.Location = New System.Drawing.Point(699, 218)
        Me.PriceTextBox1.Multiline = True
        Me.PriceTextBox1.Name = "PriceTextBox1"
        Me.PriceTextBox1.Size = New System.Drawing.Size(192, 24)
        Me.PriceTextBox1.TabIndex = 110
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(539, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 46)
        Me.Button3.TabIndex = 95
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Book_NumberTextBox
        '
        Me.Book_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Book Number", True))
        Me.Book_NumberTextBox.Location = New System.Drawing.Point(243, 78)
        Me.Book_NumberTextBox.Multiline = True
        Me.Book_NumberTextBox.Name = "Book_NumberTextBox"
        Me.Book_NumberTextBox.Size = New System.Drawing.Size(215, 24)
        Me.Book_NumberTextBox.TabIndex = 91
        '
        'Book_NameTextBox
        '
        Me.Book_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Book Name", True))
        Me.Book_NameTextBox.Location = New System.Drawing.Point(243, 125)
        Me.Book_NameTextBox.Multiline = True
        Me.Book_NameTextBox.Name = "Book_NameTextBox"
        Me.Book_NameTextBox.Size = New System.Drawing.Size(215, 24)
        Me.Book_NameTextBox.TabIndex = 93
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(243, 170)
        Me.CategoryTextBox.Multiline = True
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(215, 24)
        Me.CategoryTextBox.TabIndex = 94
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Author", True))
        Me.AuthorTextBox.Location = New System.Drawing.Point(699, 82)
        Me.AuthorTextBox.Multiline = True
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(192, 24)
        Me.AuthorTextBox.TabIndex = 81
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(699, 265)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(98, 47)
        Me.Button6.TabIndex = 56
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'AddbookDataGridView
        '
        Me.AddbookDataGridView.AllowUserToOrderColumns = True
        Me.AddbookDataGridView.AutoGenerateColumns = False
        Me.AddbookDataGridView.BackgroundColor = System.Drawing.Color.Cyan
        Me.AddbookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddbookDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookNumberDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.CategoryDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.PublicationDataGridViewTextBoxColumn, Me.PagesDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.AddbookDataGridView.DataSource = Me.AddbookBindingSource
        Me.AddbookDataGridView.GridColor = System.Drawing.Color.Blue
        Me.AddbookDataGridView.Location = New System.Drawing.Point(119, 351)
        Me.AddbookDataGridView.Name = "AddbookDataGridView"
        Me.AddbookDataGridView.Size = New System.Drawing.Size(796, 247)
        Me.AddbookDataGridView.TabIndex = 53
        '
        'AddbookBindingNavigator
        '
        Me.AddbookBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AddbookBindingNavigator.BindingSource = Me.AddbookBindingSource
        Me.AddbookBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AddbookBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AddbookBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AddbookBindingNavigatorSaveItem})
        Me.AddbookBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AddbookBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AddbookBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AddbookBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AddbookBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AddbookBindingNavigator.Name = "AddbookBindingNavigator"
        Me.AddbookBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AddbookBindingNavigator.Size = New System.Drawing.Size(1179, 25)
        Me.AddbookBindingNavigator.TabIndex = 19
        Me.AddbookBindingNavigator.Text = "BindingNavigator1"
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
        'AddbookBindingNavigatorSaveItem
        '
        Me.AddbookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddbookBindingNavigatorSaveItem.Image = CType(resources.GetObject("AddbookBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AddbookBindingNavigatorSaveItem.Name = "AddbookBindingNavigatorSaveItem"
        Me.AddbookBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AddbookBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AddbookTableAdapter
        '
        Me.AddbookTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.addbookTableAdapter = Me.AddbookTableAdapter
        Me.TableAdapterManager.addcustomerTableAdapter = Nothing
        Me.TableAdapterManager.adddealerTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.purchaseTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AddbookBindingSource
        '
        Me.AddbookBindingSource.DataMember = "addbook"
        Me.AddbookBindingSource.DataSource = Me.BookstoremanageDataSet
        '
        'BookstoremanageDataSet
        '
        Me.BookstoremanageDataSet.DataSetName = "bookstoremanageDataSet"
        Me.BookstoremanageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookNumberDataGridViewTextBoxColumn
        '
        Me.BookNumberDataGridViewTextBoxColumn.DataPropertyName = "Book Number"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookNumberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.BookNumberDataGridViewTextBoxColumn.HeaderText = "Book Number"
        Me.BookNumberDataGridViewTextBoxColumn.Name = "BookNumberDataGridViewTextBoxColumn"
        Me.BookNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BookNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BookNumberDataGridViewTextBoxColumn.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Book Name"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Book Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CategoryDataGridViewTextBoxColumn.Width = 150
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AuthorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AuthorDataGridViewTextBoxColumn.Width = 150
        '
        'PublicationDataGridViewTextBoxColumn
        '
        Me.PublicationDataGridViewTextBoxColumn.DataPropertyName = "Publication"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicationDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PublicationDataGridViewTextBoxColumn.HeaderText = "Publication"
        Me.PublicationDataGridViewTextBoxColumn.Name = "PublicationDataGridViewTextBoxColumn"
        Me.PublicationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PublicationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PublicationDataGridViewTextBoxColumn.Width = 150
        '
        'PagesDataGridViewTextBoxColumn
        '
        Me.PagesDataGridViewTextBoxColumn.DataPropertyName = "Pages"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PagesDataGridViewTextBoxColumn.HeaderText = "Pages"
        Me.PagesDataGridViewTextBoxColumn.Name = "PagesDataGridViewTextBoxColumn"
        Me.PagesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PagesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PagesDataGridViewTextBoxColumn.Width = 50
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PriceDataGridViewTextBoxColumn.Width = 50
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1179, 667)
        Me.Controls.Add(Me.AddbookBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "90i"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AddbookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddbookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddbookBindingNavigator.ResumeLayout(False)
        Me.AddbookBindingNavigator.PerformLayout()
        CType(Me.AddbookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookstoremanageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BookNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents AddbookBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AddbookBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookstoremanageDataSet As WindowsApplication1.bookstoremanageDataSet
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
    Friend WithEvents AddbookBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AddbookTableAdapter As WindowsApplication1.bookstoremanageDataSetTableAdapters.addbookTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Book_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Book_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddbookDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PagesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PublicationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PublicationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PagesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
End Class
