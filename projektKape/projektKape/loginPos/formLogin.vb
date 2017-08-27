Public Class formLogin
    'Catches the matching credentials request by the user
    Public global_user = vbEmpty
    Public global_pass = vbEmpty

    'Enables user to clear txtfields when first time using it
    Public token_user_count As Integer = 1
    Public token_pass_count As Integer = 1


    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connectionModule.Connect()
    End Sub

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click

        rs = New ADODB.Recordset

        With rs
            If .State <> 0 Then .Close()
            .Open("SELECT * FROM Employees", cn, 1, 2)

            'Catches when query finds any matching account
            If .EOF = False Then
                global_user = .Fields("AccessUser").Value
                global_pass = .Fields("AccessPass").Value

                If global_user.Equals(txtUser.Text.Trim) And global_pass.Equals(txtPass.Text.Trim) Then
                    MsgBox("WELCOME ADMIN!", MsgBoxStyle.Information, "ECT Pharmacy POS")
                    Me.Hide()

                Else
                    MsgBox("INVALID USERNAME OR PASSWORD!", MsgBoxStyle.Critical, "ECT Pharmacy POS")
                    txtUser.Focus()
                    Exit Sub
                End If

                'Notifies the user that login fails
            Else
                MsgBox("The username or password you've entered doesn't match with any account, please check it correctly", MsgBoxStyle.Critical, "ECT Pharmacy POS")
                txtUser.Focus()
                Exit Sub
            End If
        End With
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
        Me.Hide()
    End Sub
End Class
