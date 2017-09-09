Public Class formMainPos
    Dim lvi As ListViewItem
    Dim viewTwo As ListViewItem
    Public subTotal As Double
    Public total As Double
    Public discount As Double
    Public discountName As String = ""
    Public discountType As String = ""
    Public discountNo As String = ""
    Sub refresh()
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT Products.BrandName, Products.GenericName, Products.SRP, Products.ID, Products.RawPrice, Inventory.Available " +
                      "FROM Products " +
                      "INNER JOIN Inventory ON Products.ID=Inventory.ID;", cn, 1, 2)

                '''''''''''''''''''''''''List all registered products from the database'''''''''''''''''''''''''
                listProducts.Items.Clear()

                While .EOF = False
                    listItems = listProducts.Items.Add(.Fields("Available").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("BrandName").Value))
                    listItems.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("GenericName").Value))
                    listItems.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("SRP").Value))
                    listItems.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, .Fields("ID").Value))
                    listItems.SubItems.Insert(5, New ListViewItem.ListViewSubItem(Nothing, .Fields("RawPrice").Value))
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub formMainPos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerClock.Start()
        refresh()
    End Sub


    Private Sub MetroListView1_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub timerClock_Tick(sender As Object, e As EventArgs) Handles timerClock.Tick
        labelTime.Text = Format(Now, "yyyy-MM-dd   hh:mm:ss tt")
    End Sub


    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        Dim askVoid = ""
        askVoid = MsgBox("ARE SURE TO VOID THIS TRANSACTION?", MsgBoxStyle.YesNo, "ECT Pharmacy POS")
        If askVoid = vbYes Then
            listBuy.Items.Clear()
            subTotal = 0
            total = 0
            discount = 0
            labelTempTotal.Text = Format(0, "0.00")
            labelTotalPrice.Text = Format(0, "0.00")


            btnTender.Enabled = False
            btnVoid.Enabled = False


        End If


    End Sub
    Dim paymentMsg As String
    Dim change As String
    'Dim cusNum As String
    Private Sub btnTender_Click(sender As Object, e As EventArgs) Handles btnTender.Click
        formCashTender.Show()


<<<<<<< HEAD
=======
            '' code for subtracting bought item to inventory
            rs = New ADODB.Recordset
            Dim remStock As String
            Dim i As Integer
            i = 0

            Try


                With rs
                    If .State <> 0 Then .Close()
                    While i < listBuy.Items.Count
                        remStock = Val(listBuy.Items(i).SubItems(5).Text) - Val(listBuy.Items(i).SubItems(0).Text)

                        .Open("UPDATE Inventory " +
                          "SET Available='" + remStock + "', CurrentLevel='" + remStock + "' " +
                          "WHERE ID=" + listBuy.Items(i).SubItems(4).Text + "", cn, 1, 2)

                        .Open("INSERT INTO CustomerRecord (CSR_ID,CSR_Item,CSR_GItem,CSR_Qty,CSR_DateOfSale,CSR_TimeOfSale,CSR_PaidPrice,CSR_TotalPrice,CSR_ItemRawPrice,CSR_ItemPrice,CSR_DiscountType,CSR_DiscName,CSR_DiscIdNo,CSR_TransactBy) " +
                              "VALUES ('1','" + listBuy.Items(i).SubItems(1).Text + "','" + listBuy.Items(i).SubItems(2).Text + "','" + listBuy.Items(i).SubItems(0).Text + "','" + Format(Now, "yyyy-MM-dd") + "','" + Format(Now, "hh:mm:ss tt") + "','" + Format(Val(paymentMsg), "0.00") + "','" + labelTotalPrice.Text + "','" + listBuy.Items(i).SubItems(6).Text + "','" + listBuy.Items(i).SubItems(3).Text + "','Senior','juad dela cruz','9999','" + EmployeeName + "');", cn, 1, 2)

                        i = i + 1
                    End While

                    MsgBox("CHANGE IS: " + Format(Val(change), "0.00"), vbInformation, "ECT Pharmacy POS")
                    MsgBox("TRANSACTION COMPLETE!", vbInformation, "ECT Pharmacy POS")

                    refresh()
                    listBuy.Items.Clear()
                    subTotal = 0
                    total = 0
                    discount = 0
                    labelTempTotal.Text = Format(0, "0.00")
                    labelTotalPrice.Text = Format(0, "0.00")
                    labelDiscount.Text = Format(0, "0.00")
                    btnPwd.Enabled = False
                    btnSenior.Enabled = False
                    btnTender.Enabled = False
                    btnVoid.Enabled = False
                End With


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If
>>>>>>> 5bb3d9c199bd638f83388aabe178d866d1a4e7fc
    End Sub

    Private Sub txtSearchProduct_Click(sender As Object, e As EventArgs) Handles txtSearchProduct.Click

    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT Products.BrandName, Products.GenericName, Products.SRP, Products.ID,Products.RawPrice, Inventory.Available " +
                      "FROM Products " +
                      "INNER JOIN Inventory ON Products.ID=Inventory.ID " +
                      "WHERE Products.BrandName LIKE '%" + txtSearchProduct.Text.Trim + "%' OR Products.GenericName LIKE '%" + txtSearchProduct.Text.Trim + "%'", cn, 1, 2)

                '''''''''''''''''''''''''Backup query if joining will be cancelled'''''''''''''''''''''''''
                '.Open("SELECT * FROM Products WHERE BrandName LIKE '%" + txtSearchProduct.Text.Trim + "%'", cn, 1, 2)

                '''''''''''''''''''''''''List all possible products search by employee'''''''''''''''''''''''''
                listProducts.Items.Clear()

                While .EOF = False
                    listItems = listProducts.Items.Add(.Fields("Available").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("BrandName").Value))
                    listItems.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("GenericName").Value))
                    listItems.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("SRP").Value))
                    listItems.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, .Fields("ID").Value))
                    listItems.SubItems.Insert(5, New ListViewItem.ListViewSubItem(Nothing, .Fields("RawPrice").Value))
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim logoutMsg = ""
        logoutMsg = MsgBox("DO YOU WANT TO LOGOUT?", MsgBoxStyle.YesNo, "ECT Pharmacy POS")
        If logoutMsg = vbYes Then
            MsgBox("LOGGED OUT!")

            'Calls and clears all successfully signin credentials
            Call moduleLogin.ClearLogin()
            Me.Close()
            formLogin.Show()
        End If

    End Sub

    Private Sub listProducts_Click(sender As Object, e As EventArgs)
        Try
            Dim item As ListView.SelectedListViewItemCollection
            item = listProducts.SelectedItems
            Dim items As ListViewItem
            Dim i As Integer = 0

            For Each items In item
                EmployeeName = items.SubItems(i).Text
                i += 1
                ContactDetails = items.SubItems(i).Text
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Public qtyMsg As String
    Private Sub listProducts_DoubleClick(sender As Object, e As EventArgs) Handles listProducts.DoubleClick
        ' formMainQtyDlg.Close()
        'formMainQtyDlg.Show()

        rs = New ADODB.Recordset




        If listProducts.FocusedItem.SubItems(0).Text <> 0 Then


            qtyMsg = InputBox("ENTER QUANTITY", "ECT PHARMACY", 0)

            If qtyMsg = "" Or qtyMsg = "0" Or Val(qtyMsg) > Val(listProducts.FocusedItem.SubItems(0).Text) Or IsNumeric(qtyMsg) <> True Then
                MsgBox("ERROR IN QTY, PLEASE CHECK YOUR QUANTITY", vbOKOnly)
            Else

                viewTwo = listBuy.Items.Add(qtyMsg)
                viewTwo.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, listProducts.FocusedItem.SubItems(1).Text))
                viewTwo.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, listProducts.FocusedItem.SubItems(2).Text))
                viewTwo.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, Format(qtyMsg * listProducts.FocusedItem.SubItems(3).Text, "0.00")))
                viewTwo.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, listProducts.FocusedItem.SubItems(4).Text))
                viewTwo.SubItems.Insert(5, New ListViewItem.ListViewSubItem(Nothing, listProducts.FocusedItem.SubItems(0).Text))
                viewTwo.SubItems.Insert(6, New ListViewItem.ListViewSubItem(Nothing, listProducts.FocusedItem.SubItems(5).Text))


                subTotal += Format(qtyMsg * listProducts.FocusedItem.SubItems(3).Text, "0.00")




                labelTempTotal.Text = Format(subTotal, "0.00")
                total = Format(subTotal, "0.00")
                labelTotalPrice.Text = Format(total - discount, "0.00")


                btnTender.Enabled = True
                btnVoid.Enabled = True

            End If
        Else
            MsgBox("ITEM OUT OF STOCK!", vbOKOnly, "ECT PHARMACY")
        End If


    End Sub



    Private Sub listBuy_DoubleClick(sender As Object, e As EventArgs) Handles listBuy.DoubleClick

        Dim result As Integer = MessageBox.Show("DO YOU WANT TO DELETE THIS ITEM?", "ECT Pharmacy", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'MsgBox(listBuy.FocusedItem.Index)
            subTotal = Val(labelTempTotal.Text) - Val(listBuy.Items(listBuy.FocusedItem.Index).SubItems(3).Text)
            listBuy.Items.RemoveAt(listBuy.FocusedItem.Index)
            labelTempTotal.Text = Format(subTotal, "0.00")
            total = Format(subTotal, "0.00")
            labelTotalPrice.Text = Format(total - discount, "0.00")
            MsgBox("ITEM DELETED!")
        End If


    End Sub


End Class