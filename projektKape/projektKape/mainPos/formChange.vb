Public Class formChange
    Private Sub formChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelChange.Text = Format(Val(My.Forms.formCashTender.change), "0.00")
        If labelChange.Text = "" Then

        Else
            btnChangeOK.Enabled = True
        End If
    End Sub

    Private Sub btnChangeOK_Click(sender As Object, e As EventArgs) Handles btnChangeOK.Click
        MsgBox("TRANSACTION COMPLETE!", vbInformation, "ECT Pharmacy POS")

        My.Forms.formMainPos.refresh()
        My.Forms.formMainPos.listBuy.Items.Clear()
        My.Forms.formMainPos.subTotal = 0
        My.Forms.formMainPos.total = 0
        My.Forms.formMainPos.discount = 0
        My.Forms.formMainPos.labelTempTotal.Text = Format(0, "0.00")
        My.Forms.formMainPos.labelTotalPrice.Text = Format(0, "0.00")
        My.Forms.formMainPos.btnTender.Enabled = False
        My.Forms.formMainPos.btnVoid.Enabled = False
        My.Forms.formCashTender.labelAmtToBe.Text = "0.00"
        My.Forms.formCashTender.txtBoxPayment.Text = "0.00"
        Me.Close()
        My.Forms.formCashTender.Close()


    End Sub
End Class