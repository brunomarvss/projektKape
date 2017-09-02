﻿Public Class formMainPos
    Dim lvi As ListViewItem
    Dim viewTwo As ListViewItem
    Dim subTotal As Double
    Dim total As Double
    Dim discount As Double
    Sub refresh()
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Products '", cn, 1, 2)

                '''''''''''''''''''''''''Select employee data only on the database'''''''''''''''''''''''''
                listProducts.Items.Clear()

                While .EOF = False
                    listItems = listProducts.Items.Add(.Fields("Qty").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("BrandName").Value))
                    listItems.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("GenericName").Value))
                    listItems.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("SRP").Value))
                    listItems.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, .Fields("ID").Value))
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
        ' labelTime.Text = Format(Now, "yyyy-MM-dd    hh:mm:ss")
    End Sub

    Private Sub btnSenior_Click(sender As Object, e As EventArgs) Handles btnSenior.Click
        formSeniorDc.Show()
    End Sub

    Private Sub btnSenior_MouseClick(sender As Object, e As MouseEventArgs) Handles btnSenior.MouseClick
        formSeniorDc.Close()
        formPwdDc.Close()
        formSeniorDc.Show()
    End Sub

    Private Sub btnPwd_Click(sender As Object, e As EventArgs) Handles btnPwd.Click
        formPwdDc.Close()
        formSeniorDc.Close()
        formPwdDc.Show()
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
            labelDiscount.Text = Format(0, "0.00")
            btnPwd.Enabled = False
            btnSenior.Enabled = False
            btnTender.Enabled = False
            btnVoid.Enabled = False


        End If


    End Sub

    Private Sub btnTender_Click(sender As Object, e As EventArgs) Handles btnTender.Click

        MsgBox("ARE SURE TO COMPLETE THIS TRANSACTION?", MsgBoxStyle.YesNo, "ECT Pharmacy POS")

        '' code for subtracting bought item to inventory
        rs = New ADODB.Recordset
        Dim remStock As String
        Dim i As Integer
        i = 0

        Try


            With rs
                If .State <> 0 Then .Close()
                While i < listBuy.Items.Count
                    remStock = Val(listBuy.Items(i).SubItems(4).Text) - Val(listBuy.Items(i).SubItems(0).Text)
                    MsgBox(remStock)
                    .Open("UPDATE Products SET Qty='" + remStock + "' WHERE ID=" + listBuy.Items(i).SubItems(3).Text + "", cn, 1, 2)

                    i = i + 1
                End While
                refresh()
            End With


            Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtSearchProduct_Click(sender As Object, e As EventArgs) Handles txtSearchProduct.Click

    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Products WHERE BrandName LIKE '%" + txtSearchProduct.Text.Trim + "%'", cn, 1, 2)

                '''''''''''''''''''''''''Select employee data only on the database'''''''''''''''''''''''''
                listProducts.Items.Clear()

                While .EOF = False
                    listItems = listProducts.Items.Add(.Fields("Qty").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("BrandName").Value))
                    listItems.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("GenericName").Value))
                    listItems.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("SRP").Value))
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
                FullName = items.SubItems(i).Text
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
        Try
            rs = New ADODB.Recordset


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        If listProducts.FocusedItem.SubItems(0).Text <> 0 Then


            qtyMsg = InputBox("ENTER QUANTITY", "ECT PHARMACY", 0)

            If qtyMsg = "" Or Val(qtyMsg) > Val(listProducts.FocusedItem.SubItems(0).Text) Then
                MsgBox("ERROR IN QTY, PLEASE CHECK YOUR QUANTITY", vbOKOnly)
            Else

                viewTwo = listBuy.Items.Add(qtyMsg)
                viewTwo.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, listProducts.FocusedItem.SubItems(1).Text))
                viewTwo.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, Format(qtyMsg * listProducts.FocusedItem.SubItems(3).Text, "0.00")))
                viewTwo.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, listProducts.FocusedItem.SubItems(4).Text))
                viewTwo.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, listProducts.FocusedItem.SubItems(0).Text))

                subTotal += Format(qtyMsg * listProducts.FocusedItem.SubItems(3).Text, "0.00")




                labelTempTotal.Text = Format(subTotal, "0.00")
                total = Format(subTotal, "0.00")
                labelTotalPrice.Text = Format(total - discount, "0.00")

                btnPwd.Enabled = True
                btnSenior.Enabled = True
                btnTender.Enabled = True
                btnVoid.Enabled = True

            End If
        Else
            MsgBox("ITEM OUT OF STOCK!", vbOKOnly, "ECT PHARMACY")
        End If


    End Sub


End Class