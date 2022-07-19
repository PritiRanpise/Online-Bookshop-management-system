Public Class Form9

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookstoremanageDataSet.addbook' table. You can move, or remove it, as needed.
        Me.AddbookTableAdapter.Fill(Me.BookstoremanageDataSet.addbook)

    End Sub

    Private Sub AddbookBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddbookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AddbookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookstoremanageDataSet)

    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            AddbookBindingSource.EndEdit()
            AddbookTableAdapter.Update(BookstoremanageDataSet.addbook)
            MessageBox.Show("Data updated")

        Catch ex As Exception
            MessageBox.Show("Data not updated")
        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.AddbookTableAdapter.Deletedel(Book_NumberTextBox.Text)
        Me.AddbookTableAdapter.Fill(Me.BookstoremanageDataSet.addbook)
        AddbookBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim search As String = TextBox1.Text
        Me.AddbookTableAdapter.FillBy1SearchName(Me.BookstoremanageDataSet.addbook, search, search)
    End Sub
End Class