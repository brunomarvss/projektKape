Module moduleAdminStatistics
    Public Sub evaluateDailySales()
        Dim TotalOrigPriceDaily = 0.00, TotalSalesDaily = 0.00, TotalOrigPriceWeekly = 0.00, TotalSalesWeekly = 0.00, TotalOrigPriceMonthly = 0.00, TotalSalesMonthly = 0.00, TotalOrigPriceYearly = 0.00, TotalSalesYearly As Decimal = 0.00

        Try
            rs = New ADODB.Recordset

            ''  Clear all recent datas
            formMainAdmin.lblDaily.Text = Nothing
            formMainAdmin.lblWeekly.Text = Nothing
            formMainAdmin.lblMonthly.Text = Nothing
            formMainAdmin.lblYearly.Text = Nothing

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT CSR_ItemRawPrice, CSR_ItemPrice FROM CustomerRecord " +
                      "WHERE CSR_DateOfSale BETWEEN '" + DateAndTime.Today + "' AND '" + DateAndTime.Today + " 23:59:59'" +
                      "ORDER BY CSR_DateOfSale ASC;", cn, 1, 2)

                While .EOF = False
                    ''  Get all sales report on current day
                    TotalOrigPriceDaily = TotalOrigPriceDaily + (.Fields("CSR_ItemRawPrice").Value)
                    TotalSalesDaily = TotalSalesDaily + (.Fields("CSR_ItemPrice").Value)
                    .MoveNext()
                End While



                If .State <> 0 Then .Close()
                .Open("SELECT CSR_ItemRawPrice, CSR_ItemPrice FROM CustomerRecord " +
                      "WHERE CSR_DateOfSale LIKE '" + Format(Now, "MM") + "%';", cn, 1, 2)

                While .EOF = False
                    ''  Get all sales report on current month
                    TotalOrigPriceMonthly += (.Fields("CSR_ItemRawPrice").Value)
                    TotalSalesMonthly += (.Fields("CSR_ItemPrice").Value)
                    .MoveNext()
                End While



                If .State <> 0 Then .Close()
                .Open("SELECT CSR_ItemRawPrice, CSR_ItemPrice FROM CustomerRecord " +
                      "WHERE CSR_DateOfSale LIKE '%" + Format(Now, "yyyy") + "%' ORDER BY CSR_DateOfSale ASC;", cn, 1, 2)

                While .EOF = False
                    ''  Get all sales report on current year
                    TotalOrigPriceYearly = TotalOrigPriceYearly + (.Fields("CSR_ItemRawPrice").Value)
                    TotalSalesYearly = TotalSalesYearly + (.Fields("CSR_ItemPrice").Value)
                    .MoveNext()
                End While

                formMainAdmin.lblDaily.Text = Val(TotalSalesDaily)
                formMainAdmin.lblWeekly.Text = Val(TotalSalesWeekly)
                formMainAdmin.lblMonthly.Text = Val(TotalSalesMonthly)
                formMainAdmin.lblYearly.Text = Val(TotalSalesYearly)
                .Close()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Module
