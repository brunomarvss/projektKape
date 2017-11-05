Public Class formAddProduct
    Private Sub formAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call moduleAddProduct.LoadRegisteredSuppliers()

        comboSupplierList.SelectedIndex = 0
        comboSupplierIDs.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call moduleAddProduct.AddNewProduct()
    End Sub

End Class