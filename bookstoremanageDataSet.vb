Partial Class bookstoremanageDataSet
    Partial Class addbookDataTable

        Private Sub addbookDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
           
        End Sub

    End Class

    Partial Class purchaseDataTable


    End Class

    Partial Class adddealerDataTable

        Private Sub adddealerDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
         


        End Sub

    End Class

    Partial Class addcustomerDataTable

        Private Sub addcustomerDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Phone_numberColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace bookstoremanageDataSetTableAdapters
    
    Partial Class purchaseTableAdapter

    End Class

    Partial Public Class addbookTableAdapter
    End Class
End Namespace
