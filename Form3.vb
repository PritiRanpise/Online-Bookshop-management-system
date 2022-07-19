
Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookstoremanageDataSet.addbook' table. You can move, or remove it, as needed.
        Me.AddbookTableAdapter.Fill(Me.BookstoremanageDataSet.addbook)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddbookBindingSource.AddNew()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub AddbookBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddbookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AddbookBindingSource().EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookstoremanageDataSet)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.AddbookTableAdapter.Insertr(Book_NumberTextBox.Text, Book_NameTextBox.Text, CategoryTextBox.Text, AuthorTextBox.Text, PublicationTextBox.Text, PagesTextBox.Text, PriceTextBox1.Text)
        MsgBox("data saved successfully")
        Me.AddbookTableAdapter.Fill(Me.BookstoremanageDataSet.addbook)
       
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.AddbookTableAdapter.Deletedel(Book_NumberTextBox.Text)
        Me.AddbookTableAdapter.Fill(Me.BookstoremanageDataSet.addbook)
        AddbookBindingSource.RemoveCurrent()
    End Sub

End Class