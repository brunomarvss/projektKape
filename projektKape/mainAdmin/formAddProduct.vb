Public Class formAddProduct
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call moduleAddProduct.AddNewProduct()
    End Sub
End Class