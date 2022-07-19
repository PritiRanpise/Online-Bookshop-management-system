<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim PriceLabel As System.Windows.Forms.Label
        Dim PagesLabel As System.Windows.Forms.Label
        Dim PublicationLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Book_NameLabel As System.Windows.Forms.Label
        Dim Book_NumberLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.PagesTextBox = New System.Windows.Forms.TextBox()
        Me.PublicationTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.Book_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Book_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.AddbookDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AddbookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookstoremanageDataSet = New WindowsApplication1.bookstoremanageDataSet()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AddbookTableAdapter = New WindowsApplication1.bookstoremanageDataSetTableAdapters.addbookTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager()
        PriceLabel = New System.Windows.Forms.Label()
        PagesLabel = New System.Windows.Forms.Label()
        PublicationLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Book_NameLabel = New System.Windows.Forms.Label()
        Book_NumberLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.AddbookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddbookBindingNavigator.SuspendLayout()
        CType(Me.AddbookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AddbookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookstoremanageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.Location = New System.Drawing.Point(514, 191)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(54, 20)
        PriceLabel.TabIndex = 47
        PriceLabel.Text = "Price:"
        '
        'PagesLabel
        '
        PagesLabel.AutoSize = True
        PagesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PagesLabel.Location = New System.Drawing.Point(511, 146)
        PagesLabel.Name = "PagesLabel"
        PagesLabel.Size = New System.Drawing.Size(64, 20)
        PagesLabel.TabIndex = 45
        PagesLabel.Text = "Pages:"
        '
        'PublicationLabel
        '
        PublicationLabel.AutoSize = True
        PublicationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PublicationLabel.Location = New System.Drawing.Point(511, 108)
        PublicationLabel.Name = "PublicationLabel"
        PublicationLabel.Size = New System.Drawing.Size(102, 20)
        PublicationLabel.TabIndex = 43
        PublicationLabel.Text = "Publication:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AuthorLabel.Location = New System.Drawing.Point(511, 71)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(68, 20)
        AuthorLabel.TabIndex = 41
        AuthorLabel.Text = "Author:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.Location = New System.Drawing.Point(59, 152)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(86, 20)
        CategoryLabel.TabIndex = 39
        CategoryLabel.Text = "Category:"
        '
        'Book_NameLabel
        '
        Book_NameLabel.AutoSize = True
        Book_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Book_NameLabel.Location = New System.Drawing.Point(59, 111)
        Book_NameLabel.Name = "Book_NameLabel"
        Book_NameLabel.Size = New System.Drawing.Size(106, 20)
        Book_NameLabel.TabIndex = 37
        Book_NameLabel.Text = "Book Name:"
        '
        'Book_NumberLabel
        '
        Book_NumberLabel.AutoSize = True
        Book_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Book_NumberLabel.Location = New System.Drawing.Point(59, 72)
        Book_NumberLabel.Name = "Book_NumberLabel"
        Book_NumberLabel.Size = New System.Drawing.Size(122, 20)
        Book_NumberLabel.TabIndex = 35
        Book_NumberLabel.Text = "Book Number:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(59, 194)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(163, 20)
        Label2.TabIndex = 52
        Label2.Text = "Enter Author Name"
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
        Me.AddbookBindingNavigator.Size = New System.Drawing.Size(1192, 25)
        Me.AddbookBindingNavigator.TabIndex = 5
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(325, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "MANAGE BOOK DETAIL"
        '
        'Button1
        '
        Me.Button1.AllowDrop = True
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(298, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(458, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 32)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(617, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 32)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Price", True))
        Me.PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(641, 193)
        Me.PriceTextBox.Multiline = True
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(193, 20)
        Me.PriceTextBox.TabIndex = 48
        '
        'PagesTextBox
        '
        Me.PagesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Pages", True))
        Me.PagesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagesTextBox.Location = New System.Drawing.Point(641, 151)
        Me.PagesTextBox.Multiline = True
        Me.PagesTextBox.Name = "PagesTextBox"
        Me.PagesTextBox.Size = New System.Drawing.Size(193, 20)
        Me.PagesTextBox.TabIndex = 46
        '
        'PublicationTextBox
        '
        Me.PublicationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Publication", True))
        Me.PublicationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicationTextBox.Location = New System.Drawing.Point(641, 108)
        Me.PublicationTextBox.Multiline = True
        Me.PublicationTextBox.Name = "PublicationTextBox"
        Me.PublicationTextBox.Size = New System.Drawing.Size(193, 20)
        Me.PublicationTextBox.TabIndex = 44
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Author", True))
        Me.AuthorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.Location = New System.Drawing.Point(641, 68)
        Me.AuthorTextBox.Multiline = True
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(193, 20)
        Me.AuthorTextBox.TabIndex = 42
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Category", True))
        Me.CategoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryTextBox.Location = New System.Drawing.Point(235, 149)
        Me.CategoryTextBox.Multiline = True
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(214, 20)
        Me.CategoryTextBox.TabIndex = 40
        '
        'Book_NameTextBox
        '
        Me.Book_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Book Name", True))
        Me.Book_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book_NameTextBox.Location = New System.Drawing.Point(235, 111)
        Me.Book_NameTextBox.Multiline = True
        Me.Book_NameTextBox.Name = "Book_NameTextBox"
        Me.Book_NameTextBox.Size = New System.Drawing.Size(214, 20)
        Me.Book_NameTextBox.TabIndex = 38
        '
        'Book_NumberTextBox
        '
        Me.Book_NumberTextBox.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Book_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddbookBindingSource, "Book Number", True))
        Me.Book_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book_NumberTextBox.Location = New System.Drawing.Point(235, 71)
        Me.Book_NumberTextBox.Multiline = True
        Me.Book_NumberTextBox.Name = "Book_NumberTextBox"
        Me.Book_NumberTextBox.Size = New System.Drawing.Size(214, 20)
        Me.Book_NumberTextBox.TabIndex = 36
        '
        'AddbookDataGridView
        '
        Me.AddbookDataGridView.AllowUserToOrderColumns = True
        Me.AddbookDataGridView.AutoGenerateColumns = False
        Me.AddbookDataGridView.BackgroundColor = System.Drawing.Color.Cyan
        Me.AddbookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddbookDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.AddbookDataGridView.DataSource = Me.AddbookBindingSource
        Me.AddbookDataGridView.GridColor = System.Drawing.Color.Blue
        Me.AddbookDataGridView.Location = New System.Drawing.Point(76, 318)
        Me.AddbookDataGridView.Name = "AddbookDataGridView"
        Me.AddbookDataGridView.Size = New System.Drawing.Size(744, 318)
        Me.AddbookDataGridView.TabIndex = 49
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(147, 266)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 32)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cyan
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.AddbookDataGridView)
        Me.GroupBox1.Controls.Add(Book_NumberLabel)
        Me.GroupBox1.Controls.Add(Me.Book_NumberTextBox)
        Me.GroupBox1.Controls.Add(Book_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Book_NameTextBox)
        Me.GroupBox1.Controls.Add(CategoryLabel)
        Me.GroupBox1.Controls.Add(Me.CategoryTextBox)
        Me.GroupBox1.Controls.Add(AuthorLabel)
        Me.GroupBox1.Controls.Add(Me.AuthorTextBox)
        Me.GroupBox1.Controls.Add(PublicationLabel)
        Me.GroupBox1.Controls.Add(Me.PublicationTextBox)
        Me.GroupBox1.Controls.Add(PagesLabel)
        Me.GroupBox1.Controls.Add(Me.PagesTextBox)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.GroupBox1.Location = New System.Drawing.Point(114, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 642)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(235, 191)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 20)
        Me.TextBox1.TabIndex = 51
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Book Number"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Book Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Book Name"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Book Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Category"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Author"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Publication"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn6.HeaderText = "Publication"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Pages"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pages"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Price"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn8.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.Width = 50
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
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1192, 672)
        Me.Controls.Add(Me.AddbookBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.AddbookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddbookBindingNavigator.ResumeLayout(False)
        Me.AddbookBindingNavigator.PerformLayout()
        CType(Me.AddbookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AddbookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookstoremanageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BooknumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents BooknameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents BookstoremanageDataSet As WindowsApplication1.bookstoremanageDataSet
    Friend WithEvents AddbookBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddbookTableAdapter As WindowsApplication1.bookstoremanageDataSetTableAdapters.addbookTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AddbookBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AddbookBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PagesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublicationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Book_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Book_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddbookDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewButtonColumn
End Class
