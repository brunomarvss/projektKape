Public Class formMainAdmin
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        labelTimeAdmin.Text = Format(Now, "yyyy-MM-dd    hh:mm:ss")
    End Sub

    Private Sub formMainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        formAdminAddItem.Close()
        formAdminAddItem.Show()
    End Sub

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        MsgBox("Double click an item in the listview to add a stock.", vbInformation)

    End Sub
End Class