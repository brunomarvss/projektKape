Public Class formEmployee
    Public listItems = vbEmpty

    Private Sub formEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connectionModule.Connect()

        With rs
            If .State <> 0 Then .Close()
            .Open("SELECT * FROM Employees WHERE NOT JobTitle='Owner'", cn, 1, 2)

            ''''''''''''''''''''''''Select employee data only on the database''''''''''''''''''''''''''''
            listEmployee.Items.Clear()

            While .EOF = False
                listItems = listEmployee.Items.Add(.Fields("FirstName").Value + " " + .Fields("LastName").Value)
                listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("Contact").Value))
                .MoveNext()
            End While
            .Close()
        End With
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Close()

        formMainPos.Show()
        formLogin.Hide()
    End Sub
End Class