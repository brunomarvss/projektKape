Public Class formCashTender
    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        txtBoxPayment.Text = "50"

    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        txtBoxPayment.Text = "100"
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        txtBoxPayment.Text = "500"
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        txtBoxPayment.Text = "1000"
    End Sub

    Private Sub formCashTender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelAmtToBe.Text = My.Forms.formMainPos.labelTotalPrice.Text
        labelTotalTender.Text = labelAmtToBe.Text
        btnPwd.Enabled = True
        btnSenior.Enabled = True

    End Sub
    Public change As String
    Dim cusNum As String

    Private Sub btnConfirmPayment_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        If txtBoxPayment.Text = "" Or Val(txtBoxPayment.Text) < Val(labelTotalTender.Text) Or IsNumeric(txtBoxPayment.Text) = False Then
            MsgBox("ERROR IN PAYMENT, PLEASE CHECK YOUR PAYMENT", vbOKOnly)
        Else
            ''customer's change
            change = Val(txtBoxPayment.Text) - Val(labelTotalTender.Text)


            '' code for subtracting bought item to inventory
            rs = New ADODB.Recordset
            Dim remStock As String
            Dim i As Integer
            i = 0

            Try


                With rs
                    If .State <> 0 Then .Close()

                    .Open("SELECT * FROM CustomerRecord ORDER BY CSR_ID DESC;", cn, 1, 2)

                    'query for getting the latest customer number
                    If .EOF = False Then
                        cusNum = .Fields("CSR_ID").Value.ToString
                        .Close()
                    End If

                    cusNum += 1
                    'MsgBox(cusNum)
                    'inserts validated data to db
                    While i < My.Forms.formMainPos.listBuy.Items.Count
                        remStock = Val(My.Forms.formMainPos.listBuy.Items(i).SubItems(5).Text) - Val(My.Forms.formMainPos.listBuy.Items(i).SubItems(0).Text)

                        .Open("UPDATE Inventory " +
                          "SET Available='" + remStock + "', CurrentLevel='" + remStock + "' " +
                          "WHERE ID=" + My.Forms.formMainPos.listBuy.Items(i).SubItems(4).Text + "", cn, 1, 2)

                        .Open("INSERT INTO CustomerRecord (CSR_ID,CSR_Item,CSR_GItem,CSR_Qty,CSR_DateOfSale,CSR_TimeOfSale,CSR_PaidPrice,CSR_TotalPrice,CSR_ItemRawPrice,CSR_ItemPrice,CSR_DiscountType,CSR_DiscName,CSR_DiscIdNo,CSR_TransactBy) " +
                              "VALUES ('" + cusNum + "','" + My.Forms.formMainPos.listBuy.Items(i).SubItems(1).Text + "','" + My.Forms.formMainPos.listBuy.Items(i).SubItems(2).Text + "','" + My.Forms.formMainPos.listBuy.Items(i).SubItems(0).Text + "','" + Format(Now, "yyyy-MM-dd") + "','" + Format(Now, "hh:mm:ss tt") + "','" + Format(Val(txtBoxPayment.Text), "0.00") + "','" + labelTotalTender.Text + "','" + My.Forms.formMainPos.listBuy.Items(i).SubItems(6).Text + "','" + My.Forms.formMainPos.listBuy.Items(i).SubItems(3).Text + "','" + My.Forms.formMainPos.discountType + " ','" + My.Forms.formMainPos.discountName + "','" + My.Forms.formMainPos.discountNo + "','" + EmployeeName + "');", cn, 1, 2)

                        i = i + 1
                    End While

                    Me.Hide()

                    formChange.Show()


                End With


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If

    End Sub

    Private Sub txtBoxPayment_TextChanged(sender As Object, e As EventArgs) Handles txtBoxPayment.TextChanged
        If txtBoxPayment.Text <> "" Or txtBoxPayment.Text > "0" Then
            btnConfirmPayment.Enabled = True
        Else
            btnConfirmPayment.Enabled = False

        End If
    End Sub

    Private Sub btnSenior_Click(sender As Object, e As EventArgs) Handles btnSenior.Click
        formSeniorDc.Show()
    End Sub

    Private Sub btnPwd_Click(sender As Object, e As EventArgs) Handles btnPwd.Click
        formPwdDc.Show()
    End Sub

    Private Sub txtBoxPayment_Click(sender As Object, e As EventArgs) Handles txtBoxPayment.Click
        txtBoxPayment.Text = ""
    End Sub
End Class