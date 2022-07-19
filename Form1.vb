Public Class Form1

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Enter username")
            If TextBox2.Text = "" Then
                ErrorProvider1.SetError(TextBox2, "Enter password")

            End If
        Else
            If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
                ErrorProvider1.Clear()

                Form2.Show()
            Else
                MsgBox("Please Enter correct username and password")
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Hide()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
    End Sub

End Class
