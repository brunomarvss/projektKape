Public Class formLogin
    Public useradmin = ""
    Dim passadmin = ""
    Public userassist = ""
    Dim passassist = ""


    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()

    End Sub

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click

        rs = New ADODB.Recordset

        With rs
            If .State <> 0 Then .Close()
            .Open("select * from tblCredentials", cn, 1, 2)
            useradmin = .Fields("credentialsUsr").Value
            passadmin = .Fields("credentialsUsrPss").Value
            .MoveNext()
            userassist = .Fields("credentialsUsr").Value
            passassist = .Fields("credentialsUsrPss").Value

            If useradmin.Equals(textBoxUser.Text.ToLower()) And passadmin.Equals(textBoxPass.Text.ToLower()) Then
                MsgBox("WELCOME ADMIN!", MsgBoxStyle.Information, "ECT Pharmacy POS")
                Me.Hide()
                'formUI.Show()

            ElseIf userassist.Equals(textBoxUser.Text.ToLower()) And passassist.Equals(textBoxPass.Text.ToLower()) Then
                'MsgBox("WELCOME!")
                Me.Hide()
                formMainPos.Show()

            Else
                MsgBox("INVALID USERNAME OR PASSWORD!", MsgBoxStyle.Critical, "ECT Pharmacy POS")
                textBoxPass.Clear()
                textBoxPass.Focus()

            End If

        End With
    End Sub
End Class
