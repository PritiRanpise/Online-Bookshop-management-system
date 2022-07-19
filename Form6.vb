Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookstoremanageDataSet.purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter.Fill(Me.BookstoremanageDataSet.purchase)
     

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PurchaseTableAdapter.Insertp(Dealer_NameTextBox.Text, Book_NameTextBox.Text, Total_PriceTextBox.Text)
          Me.PurchaseTableAdapter.Fill(Me.BookstoremanageDataSet.purchase)
    End Sub

    Private Sub PurchaseBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PurchaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookstoremanageDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PurchaseBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PurchaseBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

End Class