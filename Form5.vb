
Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookstoremanageDataSet.addcustomer' table. You can move, or remove it, as needed.
        Me.AddcustomerTableAdapter.Fill(Me.BookstoremanageDataSet.addcustomer)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddcustomerBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.AddcustomerTableAdapter.Insertc(Customer_NameTextBox.Text, AddressTextBox.Text, Phone_numberTextBox.Text, Book_InterestedTextBox.Text)
        Me.AddcustomerTableAdapter.Fill(Me.BookstoremanageDataSet.addcustomer)
       
    End Sub


    Private Sub AddcustomerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddcustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AddcustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookstoremanageDataSet)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AddcustomerBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Me.Close()
    End Sub

End Class
