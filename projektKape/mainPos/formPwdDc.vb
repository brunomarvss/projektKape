Public Class formPwdDc
    Private Sub formPwdDc_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Hide()
    End Sub

    Private Sub formPwdDc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        formMainPos.labelDiscount.Text = Format(formMainPos.labelTempTotal.Text * 0.2, "0.00")
        formMainPos.labelTotalPrice.Text = Format(formMainPos.labelTempTotal.Text - formMainPos.labelDiscount.Text, "0.00")
    End Sub
End Class