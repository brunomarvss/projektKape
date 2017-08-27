Public Class formEmployee
    Private Sub formEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connectionModule.Connect()

        With rs
            If .State <> 0 Then .Close()
            .Open("SELECT * FROM Employees", cn, 1, 2)


            If .EOF = False Then

            End If
        End With
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Close()
        formMainPos.Show()

    End Sub
End Class