<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim Dealer_AddressLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Details_of_BookLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Dealer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AdddealerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookstoremanageDataSet = New WindowsApplication1.bookstoremanageDataSet()
        Me.Dealer_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Details_of_BookTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AdddealerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DetailsOfBookDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AdddealerTableAdapter = New WindowsApplication1.bookstoremanageDataSetTableAdapters.adddealerTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager()
        Me.adddealerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Dealer_AddressLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Details_of_BookLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.AdddealerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookstoremanageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdddealerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adddealerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adddealerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dealer_NameLabel
        '
        Dealer_NameLabel.AutoSize = True
        Dealer_NameLabel.Location = New System.Drawing.Point(60, 116)
        Dealer_NameLabel.Name = "Dealer_NameLabel"
        Dealer_NameLabel.Size = New System.Drawing.Size(138, 24)
        Dealer_NameLabel.TabIndex = 32
        Dealer_NameLabel.Text = "Dealer Name:"
        '
        'Dealer_AddressLabel
        '
        Dealer_AddressLabel.AutoSize = True
        Dealer_AddressLabel.Location = New System.Drawing.Point(54, 157)
        Dealer_AddressLabel.Name = "Dealer_AddressLabel"
        Dealer_AddressLabel.Size = New System.Drawing.Size(160, 24)
        Dealer_AddressLabel.TabIndex = 34
        Dealer_AddressLabel.Text = "Dealer Address:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(56, 204)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(158, 24)
        Phone_NumberLabel.TabIndex = 36
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Details_of_BookLabel
        '
        Details_of_BookLabel.AutoSize = True
        Details_of_BookLabel.Location = New System.Drawing.Point(56, 245)
        Details_of_BookLabel.Name = "Details_of_BookLabel"
        Details_of_BookLabel.Size = New System.Drawing.Size(154, 24)
        Details_of_BookLabel.TabIndex = 38
        Details_of_BookLabel.Text = "Details of Book:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Aqua
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(175, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ADD DEALER"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(105, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 44)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(309, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 44)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Dealer_NameLabel)
        Me.Panel1.Controls.Add(Me.Dealer_NameTextBox)
        Me.Panel1.Controls.Add(Dealer_AddressLabel)
        Me.Panel1.Controls.Add(Me.Dealer_AddressTextBox)
        Me.Panel1.Controls.Add(Phone_NumberLabel)
        Me.Panel1.Controls.Add(Me.Phone_NumberTextBox)
        Me.Panel1.Controls.Add(Details_of_BookLabel)
        Me.Panel1.Controls.Add(Me.Details_of_BookTextBox)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(25, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 459)
        Me.Panel1.TabIndex = 12
        '
        'Dealer_NameTextBox
        '
        Me.Dealer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdddealerBindingSource, "Dealer Name", True))
        Me.Dealer_NameTextBox.Location = New System.Drawing.Point(257, 111)
        Me.Dealer_NameTextBox.Multiline = True
        Me.Dealer_NameTextBox.Name = "Dealer_NameTextBox"
        Me.Dealer_NameTextBox.Size = New System.Drawing.Size(160, 29)
        Me.Dealer_NameTextBox.TabIndex = 33
        '
        'AdddealerBindingSource
        '
        Me.AdddealerBindingSource.DataMember = "adddealer"
        Me.AdddealerBindingSource.DataSource = Me.BookstoremanageDataSet
        '
        'BookstoremanageDataSet
        '
        Me.BookstoremanageDataSet.DataSetName = "bookstoremanageDataSet"
        Me.BookstoremanageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dealer_AddressTextBox
        '
        Me.Dealer_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdddealerBindingSource, "Dealer Address", True))
        Me.Dealer_AddressTextBox.Location = New System.Drawing.Point(257, 152)
        Me.Dealer_AddressTextBox.Multiline = True
        Me.Dealer_AddressTextBox.Name = "Dealer_AddressTextBox"
        Me.Dealer_AddressTextBox.Size = New System.Drawing.Size(160, 29)
        Me.Dealer_AddressTextBox.TabIndex = 35
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdddealerBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(257, 201)
        Me.Phone_NumberTextBox.Multiline = True
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(160, 29)
        Me.Phone_NumberTextBox.TabIndex = 37
        '
        'Details_of_BookTextBox
        '
        Me.Details_of_BookTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdddealerBindingSource, "Details of Book", True))
        Me.Details_of_BookTextBox.Location = New System.Drawing.Point(257, 245)
        Me.Details_of_BookTextBox.Multiline = True
        Me.Details_of_BookTextBox.Name = "Details_of_BookTextBox"
        Me.Details_of_BookTextBox.Size = New System.Drawing.Size(160, 29)
        Me.Details_of_BookTextBox.TabIndex = 39
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(318, 396)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 44)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(105, 395)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 44)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AdddealerDataGridView
        '
        Me.AdddealerDataGridView.AllowUserToOrderColumns = True
        Me.AdddealerDataGridView.AutoGenerateColumns = False
        Me.AdddealerDataGridView.BackgroundColor = System.Drawing.Color.Aqua
        Me.AdddealerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdddealerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DetailsOfBookDataGridViewTextBoxColumn})
        Me.AdddealerDataGridView.DataSource = Me.AdddealerBindingSource
        Me.AdddealerDataGridView.GridColor = System.Drawing.Color.Blue
        Me.AdddealerDataGridView.Location = New System.Drawing.Point(520, 76)
        Me.AdddealerDataGridView.Name = "AdddealerDataGridView"
        Me.AdddealerDataGridView.Size = New System.Drawing.Size(573, 459)
        Me.AdddealerDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Dealer Name"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Dealer Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dealer Address"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dealer Address"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Phone Number"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DetailsOfBookDataGridViewTextBoxColumn
        '
        Me.DetailsOfBookDataGridViewTextBoxColumn.DataPropertyName = "Details of Book"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsOfBookDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DetailsOfBookDataGridViewTextBoxColumn.HeaderText = "Details of Book"
        Me.DetailsOfBookDataGridViewTextBoxColumn.Name = "DetailsOfBookDataGridViewTextBoxColumn"
        Me.DetailsOfBookDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetailsOfBookDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DetailsOfBookDataGridViewTextBoxColumn.Width = 130
        '
        'AdddealerTableAdapter
        '
        Me.AdddealerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.addbookTableAdapter = Nothing
        Me.TableAdapterManager.addcustomerTableAdapter = Nothing
        Me.TableAdapterManager.adddealerTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.purchaseTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'adddealerBindingNavigator
        '
        Me.adddealerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.adddealerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.adddealerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.adddealerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.adddealerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.adddealerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.adddealerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.adddealerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.adddealerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.adddealerBindingNavigator.Name = "adddealerBindingNavigator"
        Me.adddealerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.adddealerBindingNavigator.Size = New System.Drawing.Size(1105, 25)
        Me.adddealerBindingNavigator.TabIndex = 14
        Me.adddealerBindingNavigator.Text = "BindingNavigator1"
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
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1105, 665)
        Me.Controls.Add(Me.adddealerBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AdddealerDataGridView)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AdddealerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookstoremanageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdddealerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adddealerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adddealerBindingNavigator.ResumeLayout(False)
        Me.adddealerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DealernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DealeraddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PhonenumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AdddealerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BookstoremanageDataSet As WindowsApplication1.bookstoremanageDataSet
    Friend WithEvents AdddealerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdddealerTableAdapter As WindowsApplication1.bookstoremanageDataSetTableAdapters.adddealerTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.bookstoremanageDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Dealer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dealer_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Details_of_BookTextBox As System.Windows.Forms.TextBox
    Friend WithEvents adddealerBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DetailsOfBookDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewButtonColumn
End Class
