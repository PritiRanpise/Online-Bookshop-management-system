Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'BookstoremanageDataSet.adddealer' table. You can move, or remove it, as needed.
        Me.AdddealerTableAdapter.Fill(Me.BookstoremanageDataSet.adddealer)

    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        AdddealerBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.AdddealerTableAdapter.Insertd(Dealer_NameTextBox.Text, Dealer_AddressTextBox.Text, Phone_NumberTextBox.Text, Details_of_BookTextBox.Text)
        Me.AdddealerTableAdapter.Fill(Me.BookstoremanageDataSet.adddealer)
       
    End Sub
    Private Sub AdddealerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AdddealerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookstoremanageDataSet)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AdddealerBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
       
    End Sub


End Class
