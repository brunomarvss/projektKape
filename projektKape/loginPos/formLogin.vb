Public Class formLogin
    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connectionModule.Connect()
    End Sub

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Call moduleLogin.loginAdmin()
    End Sub

    'Show the text within password field when request toggle on it
    Private Sub checkToggle_CheckedChanged(sender As Object, e As EventArgs) Handles checkToggle.CheckedChanged
        If checkToggle.Checked = True Then
            txtPass.PasswordChar = Nothing
            txtPass.UseSystemPasswordChar = False

        Else
            txtPass.PasswordChar = "●"
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    'When tokens is equal to 1 will clearoff the txtUser and txtPass fields
    Private Sub txtUser_Click(sender As Object, e As EventArgs) Handles txtUser.Click
        If token_user_count = 1 Then
            token_user_count -= 1
            txtUser.Clear()
        End If
    End Sub

    Private Sub passwordBox_Click(sender As Object, e As EventArgs) Handles txtPass.Click
        If token_pass_count = 1 Then
            token_pass_count -= 1
            txtPass.Clear()
        End If
    End Sub

    'Employee login access login
    Private Sub linkEmployeeLogin_Click(sender As Object, e As EventArgs) Handles linkEmployeeLogin.Click
        formEmployee.Show()
    End Sub
End Class
