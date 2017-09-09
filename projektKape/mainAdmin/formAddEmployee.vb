Public Class formAddEmployee
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call moduleAddEmployee.AddNewEmployee()
    End Sub
End Class