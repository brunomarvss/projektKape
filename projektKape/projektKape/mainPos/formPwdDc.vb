Public Class formPwdDc
    Private Sub formPwdDc_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Hide()
    End Sub

    Private Sub formPwdDc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnPWD.Click
        My.Forms.formMainPos.discountName = textboxPCusName.Text.ToUpper
        My.Forms.formMainPos.discountType = "PWD"
        My.Forms.formMainPos.discountNo = textboxPCusNo.Text.ToUpper

        My.Forms.formCashTender.labelDisc.Text = Format(formMainPos.labelTempTotal.Text * 0.2, "0.00")
        formMainPos.labelTotalPrice.Text = Format(formMainPos.labelTempTotal.Text - My.Forms.formCashTender.labelDisc.Text, "0.00")
        My.Forms.formCashTender.labelTotalTender.Text = Format(My.Forms.formCashTender.labelAmtToBe.Text - My.Forms.formCashTender.labelDisc.Text, "0.00")
        Close()
    End Sub
End Class