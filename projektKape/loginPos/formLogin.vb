Public Class formLogin
    Dim valid As Integer = 1
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
            txtPass.UseSystemPasswordChar = True

        Else
            txtPass.PasswordChar = "●"
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub



    ''  When tokens is equal to 1 will clearoff the txtUser and txtPass fields
    Private Sub txtUser_GotFocus(sender As Object, e As EventArgs) Handles txtUser.GotFocus
        If token_user_count = 1 Then
            token_user_count = token_user_count - 1
            txtUser.Clear()
        End If
    End Sub

    Private Sub passwordBox_GotFocus(sender As Object, e As EventArgs) Handles txtPass.GotFocus


        If token_pass_count = 1 Then
            token_pass_count = token_pass_count - 1
            txtPass.Clear()

            ''  Hides user inputed password credential
            If valid = 1 Then
                valid = valid - 1
                txtPass.PasswordChar = "●"
                txtPass.UseSystemPasswordChar.Equals(False)
                'MsgBox(txtPass.UseSystemPasswordChar)
            End If

        End If
    End Sub


    ''  Checks if text fields are empty
    Private Sub txtUser_LostFocus(sender As Object, e As EventArgs) Handles txtUser.LostFocus
        If txtUser.Text = Nothing Then
            txtUser.Text = "Username"
            token_user_count = 1
        End If
    End Sub

    Private Sub passwordBox_LostFocus(sender As Object, e As EventArgs) Handles txtPass.LostFocus
        If txtPass.Text = Nothing Then
            txtPass.Text = "Password"
            token_pass_count = 1

            ''  Shows default message notification
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub


    'Employee login access login
    Private Sub linkEmployeeLogin_Click(sender As Object, e As EventArgs) Handles linkEmployeeLogin.Click
        formEmployee.Show()
    End Sub
End Class
