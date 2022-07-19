<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim Dealer_NameLabel As System.Windows.Forms.Label
        Dim Book_NameLabel As System.Windows.Forms.Label
        Dim Total_PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Dealer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookstoremanageDataSet = New WindowsApplication1.bookstoremanageDataSet()
        Me.Book_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Total_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PurchaseDataGridView = New System.Windows.Forms.DataGridView()
        Me.DealerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PurchaseTableAdapter = New WindowsApplication1.bookstoremanageDataSetTableAdapters.purchaseTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager()
        Me.purchaseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Dealer_NameLabel = New System.Windows.Forms.Label()
        Book_NameLabel = New System.Windows.Forms.Label()
        Total_PriceLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookstoremanageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.purchaseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.purchaseBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dealer_NameLabel
        '
        Dealer_NameLabel.AutoSize = True
        Dealer_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dealer_NameLabel.Location = New System.Drawing.Point(56, 124)
        Dealer_NameLabel.Name = "Dealer_NameLabel"
        Dealer_NameLabel.Size = New System.Drawing.Size(138, 24)
        Dealer_NameLabel.TabIndex = 72
        Dealer_NameLabel.Text = "Dealer Name:"
        '
        'Book_NameLabel
        '
        Book_NameLabel.AutoSize = True
        Book_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Book_NameLabel.Location = New System.Drawing.Point(56, 174)
        Book_NameLabel.Name = "Book_NameLabel"
        Book_NameLabel.Size = New System.Drawing.Size(124, 24)
        Book_NameLabel.TabIndex = 74
        Book_NameLabel.Text = "Book Name:"
        '
        'Total_PriceLabel
        '
        Total_PriceLabel.AutoSize = True
        Total_PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_PriceLabel.Location = New System.Drawing.Point(56, 223)
        Total_PriceLabel.Name = "Total_PriceLabel"
        Total_PriceLabel.Size = New System.Drawing.Size(116, 24)
        Total_PriceLabel.TabIndex = 76
        Total_PriceLabel.Text = "Total Price:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Aqua
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Dealer_NameLabel)
        Me.Panel1.Controls.Add(Me.Dealer_NameTextBox)
        Me.Panel1.Controls.Add(Book_NameLabel)
        Me.Panel1.Controls.Add(Me.Book_NameTextBox)
        Me.Panel1.Controls.Add(Total_PriceLabel)
        Me.Panel1.Controls.Add(Me.Total_PriceTextBox)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(27, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 430)
        Me.Panel1.TabIndex = 0
        '
        'Dealer_NameTextBox
        '
        Me.Dealer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseBindingSource, "Dealer Name", True))
        Me.Dealer_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dealer_NameTextBox.Location = New System.Drawing.Point(237, 119)
        Me.Dealer_NameTextBox.Multiline = True
        Me.Dealer_NameTextBox.Name = "Dealer_NameTextBox"
        Me.Dealer_NameTextBox.Size = New System.Drawing.Size(158, 20)
        Me.Dealer_NameTextBox.TabIndex = 73
        '
        'PurchaseBindingSource
        '
        Me.PurchaseBindingSource.DataMember = "purchase"
        Me.PurchaseBindingSource.DataSource = Me.BookstoremanageDataSet
        '
        'BookstoremanageDataSet
        '
        Me.BookstoremanageDataSet.DataSetName = "bookstoremanageDataSet"
        Me.BookstoremanageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Book_NameTextBox
        '
        Me.Book_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseBindingSource, "Book Name", True))
        Me.Book_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book_NameTextBox.Location = New System.Drawing.Point(237, 171)
        Me.Book_NameTextBox.Multiline = True
        Me.Book_NameTextBox.Name = "Book_NameTextBox"
        Me.Book_NameTextBox.Size = New System.Drawing.Size(158, 20)
        Me.Book_NameTextBox.TabIndex = 75
        '
        'Total_PriceTextBox
        '
        Me.Total_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseBindingSource, "Total Price", True))
        Me.Total_PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_PriceTextBox.Location = New System.Drawing.Point(237, 223)
        Me.Total_PriceTextBox.Multiline = True
        Me.Total_PriceTextBox.Name = "Total_PriceTextBox"
        Me.Total_PriceTextBox.Size = New System.Drawing.Size(158, 20)
        Me.Total_PriceTextBox.TabIndex = 77
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(277, 372)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 35)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(96, 372)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 35)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(91, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(304, 25)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "PURCHASE MANAGEMENT"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(277, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 35)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(94, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(87, -20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "PURCHASE MANAGEMENT"
        '
        'PurchaseDataGridView
        '
        Me.PurchaseDataGridView.AllowUserToOrderColumns = True
        Me.PurchaseDataGridView.AutoGenerateColumns = False
        Me.PurchaseDataGridView.BackgroundColor = System.Drawing.Color.Cyan
        Me.PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DealerNameDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn})
        Me.PurchaseDataGridView.DataSource = Me.PurchaseBindingSource
        Me.PurchaseDataGridView.GridColor = System.Drawing.Color.Blue
        Me.PurchaseDataGridView.Location = New System.Drawing.Point(511, 52)
        Me.PurchaseDataGridView.Name = "PurchaseDataGridView"
        Me.PurchaseDataGridView.Size = New System.Drawing.Size(500, 430)
        Me.PurchaseDataGridView.TabIndex = 2
        '
        'DealerNameDataGridViewTextBoxColumn
        '
        Me.DealerNameDataGridViewTextBoxColumn.DataPropertyName = "Dealer Name"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DealerNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DealerNameDataGridViewTextBoxColumn.HeaderText = "Dealer Name"
        Me.DealerNameDataGridViewTextBoxColumn.Name = "DealerNameDataGridViewTextBoxColumn"
        Me.DealerNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DealerNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DealerNameDataGridViewTextBoxColumn.Width = 150
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "Book Name"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "Book Name"
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        Me.BookNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BookNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BookNameDataGridViewTextBoxColumn.Width = 150
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total Price"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price"
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        Me.TotalPriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TotalPriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TotalPriceDataGridViewTextBoxColumn.Width = 150
        '
        'PurchaseTableAdapter
        '
        Me.PurchaseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.addbookTableAdapter = Nothing
        Me.TableAdapterManager.addcustomerTableAdapter = Nothing
        Me.TableAdapterManager.adddealerTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.purchaseTableAdapter = Me.PurchaseTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'purchaseBindingNavigator
        '
        Me.purchaseBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.purchaseBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.purchaseBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.purchaseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.purchaseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.purchaseBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.purchaseBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.purchaseBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.purchaseBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.purchaseBindingNavigator.Name = "purchaseBindingNavigator"
        Me.purchaseBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.purchaseBindingNavigator.Size = New System.Drawing.Size(1023, 25)
        Me.purchaseBindingNavigator.TabIndex = 3
        Me.purchaseBindingNavigator.Text = "BindingNavigator1"
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
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1023, 514)
        Me.Controls.Add(Me.purchaseBindingNavigator)
        Me.Controls.Add(Me.PurchaseDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookstoremanageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.purchaseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.purchaseBindingNavigator.ResumeLayout(False)
        Me.purchaseBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PurchaseDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BookstoremanageDataSet As WindowsApplication1.bookstoremanageDataSet
    Friend WithEvents PurchaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseTableAdapter As WindowsApplication1.bookstoremanageDataSetTableAdapters.purchaseTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dealer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Book_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents purchaseBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DealerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
End Class
