Public Class formSeniorDc
    Private Sub formSeniorDc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()

    End Sub

    Private Sub formSeniorDc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSenior_Click(sender As Object, e As EventArgs) Handles btnSenior.Click


        My.Forms.formMainPos.discountName = textboxSCusName.Text.ToUpper
        My.Forms.formMainPos.discountType = "SENIOR"
        My.Forms.formMainPos.discountNo = textboxSCusNo.Text.ToUpper
        My.Forms.formCashTender.labelDisc.Text = Format(formMainPos.labelTempTotal.Text * 0.2, "0.00")
        formMainPos.labelTotalPrice.Text = Format(formMainPos.labelTempTotal.Text - My.Forms.formCashTender.labelDisc.Text, "0.00")
        My.Forms.formCashTender.labelTotalTender.Text = Format(My.Forms.formCashTender.labelAmtToBe.Text - My.Forms.formCashTender.labelDisc.Text, "0.00")

        Me.Close()

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
End Class