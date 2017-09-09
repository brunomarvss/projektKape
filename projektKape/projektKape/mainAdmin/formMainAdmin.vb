Public Class formMainAdmin
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        labelTimeAdmin.Text = Format(Now, "yyyy-MM-dd    hh:mm:ss")
    End Sub

    Private Sub formMainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        moduleAdminStatistics.evaluateDailySales()
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) 
        formAdminAddItem.Close()
        formAdminAddItem.Show()
    End Sub

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) 
        MsgBox("Double click an item in the listview to add a stock.", vbInformation)

    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        formAddEmployee.ShowDialog()
    End Sub
End Class