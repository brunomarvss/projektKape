Public Class FormLogin
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connect()
    End Sub

    Private Sub TogglePass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles togglePass.CheckedChanged
        If togglePass.Checked = True Then
            txtPass.PasswordChar = Nothing
            txtPass.UseSystemPasswordChar = Nothing
        Else
            txtPass.PasswordChar = ""
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub linkCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linkCreate.Click
        FormMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Call UserLogin()
    End Sub
End Class