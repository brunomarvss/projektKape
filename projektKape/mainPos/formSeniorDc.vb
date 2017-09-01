Public Class formSeniorDc
    Private Sub formSeniorDc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()

    End Sub

    Private Sub formSeniorDc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSenior_Click(sender As Object, e As EventArgs) Handles btnSenior.Click



        formMainPos.labelDiscount.Text = Format(formMainPos.labelTempTotal.Text * 0.2, "0.00")
        formMainPos.labelTotalPrice.Text = Format(formMainPos.labelTempTotal.Text - formMainPos.labelDiscount.Text, "0.00")
    End Sub

End Class