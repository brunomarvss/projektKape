Public Class formAddSupplier
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call moduleAddSupplier.AddNewSupplier()
    End Sub
End Class