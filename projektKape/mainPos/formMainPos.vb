Public Class formMainPos
    Dim lvi As ListViewItem
    Private Sub MetroListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub formMainPos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerClock.Start()
    End Sub


    Private Sub MetroListView1_DoubleClick(sender As Object, e As EventArgs) Handles listProducts.DoubleClick
        formMainQtyDlg.Close()
        formMainQtyDlg.Show()
    End Sub

    Private Sub timerClock_Tick(sender As Object, e As EventArgs) Handles timerClock.Tick
        labelTime.Text = Format(Now, "yyyy-MM-dd    hh:mm:ss")
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
        MsgBox("ARE SURE TO VOID THIS ITEM?", MsgBoxStyle.YesNo, "ECT Pharmacy POS")

    End Sub

    Private Sub btnTender_Click(sender As Object, e As EventArgs) Handles btnTender.Click
        MsgBox("ARE SURE TO COMPLETE THIS TRANSACTION?", MsgBoxStyle.YesNo, "ECT Pharmacy POS")
    End Sub

    Private Sub txtSearchProduct_Click(sender As Object, e As EventArgs) Handles txtSearchProduct.Click

    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Products WHERE GenericName LIKE '%" + txtSearchProduct.Text.Trim + "%'", cn, 1, 2)

                '''''''''''''''''''''''''Select employee data only on the database'''''''''''''''''''''''''
                listProducts.Items.Clear()

                While .EOF = False
                    listItems = listProducts.Items.Add(.Fields("BrandName").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("GenericName").Value))
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

    Private Sub listProducts_Click(sender As Object, e As EventArgs) Handles listProducts.Click
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
End Class