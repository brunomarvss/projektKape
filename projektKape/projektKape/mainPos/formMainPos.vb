Public Class formMainPos
    Dim lvi As ListViewItem
    Private Sub MetroListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub formMainPos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerClock.Start()
    End Sub


    Private Sub MetroListView1_DoubleClick(sender As Object, e As EventArgs) Handles MetroListView1.DoubleClick

        formMainQtyDlg.Show()
    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click

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
End Class