Public Class formEmployee
    Private Sub formEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connectionModule.Connect()
        Call moduleLogin.ListloginEmployee()
    End Sub

    Private Sub listEmployee_Click(sender As Object, e As EventArgs) Handles listEmployee.Click
        Try
            Dim item As ListView.SelectedListViewItemCollection
            item = listEmployee.SelectedItems
            Dim items As ListViewItem
            Dim i As Integer = 0

            For Each items In item
                employeeName = items.SubItems(i).Text
                i += 1
                ContactDetails = items.SubItems(i).Text
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Close()

        formMainPos.ShowDialog()
        formLogin.Hide()
    End Sub
End Class