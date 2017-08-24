Class MainWindow
    Public global_user = vbEmpty
    Public global_pass = vbEmpty

    Public token_user = 0
    Public token_pass = 0

    Private Sub FormLogin_Loaded(sender As Object, e As RoutedEventArgs) Handles FormLogin.Loaded
        Call dbConnection.Connect()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As RoutedEventArgs) Handles buttonLogin.Click
        rs = New ADODB.Recordset

        If FormLogin.txtUser.Text = "" Or FormLogin.txtPass.Text = "" Then
            MsgBox("You must fill up all fields before you login", vbCritical, "Error")
            FormLogin.txtUser.Focus()
            Exit Sub
        End If

        With rs
            If .State <> 0 Then .Close()
            .Open("Select * from tbl_login where access_user='" + txtUser.Text.Trim +
                  "' and access_pass='" + txtPass.Text.Trim + "'", cn, 1, 2)

            If .EOF = False Then
                global_user = .Fields("access_user").Value.ToString
                global_pass = .Fields("access_pass").Value.ToString

                If global_user = FormLogin.txtUser.Text And global_pass = FormLogin.txtPass.Text Then
                    If .Fields("access_type").Value = "ADMIN" Then
                        MsgBox("Welcome Admin", vbInformation, "Welcome")
                        'Call UserInfoRetrieveAdmin()
                        'FormAdmin.Show()
                        FormLogin.Hide()


                    ElseIf .Fields("access_type").Value = "CASHIER" Then
                        MsgBox("Welcome Student", vbInformation, "Welcome")
                        'Call UserInfoStudent()
                        'Call listEvaluation()
                        'EvaluationForm.EvaluatePanel.SelectedIndex = 0
                        'EvaluationForm.Show()
                        FormLogin.Hide()
                    End If

                Else
                    MsgBox("The username or password you've entered doesn't match with any account, please check it correctly", vbCritical, "Error")
                    FormLogin.txtUser.Text = ""
                    FormLogin.txtPass.Text = ""
                    FormLogin.txtUser.Focus()
                    Exit Sub
                End If

            Else
                MsgBox("The username or password you've entered doesn't match with any account, please check it correctly", vbCritical, "Error")
                FormLogin.txtUser.Text = ""
                FormLogin.txtPass.Text = ""
                FormLogin.txtUser.Focus()
                Exit Sub
            End If

            .Close()
        End With
    End Sub

    Private Sub ShowPassword()
        If (txtPass.Text = Not "") Then
            txtPass.Visibility = Visibility.Visible
            passwordBox.Visibility = Visibility.Hidden
            txtPass.Text = passwordBox.Password
        End If
    End Sub

    Private Sub HidePassword()
        If (txtPass.Text = Not "") Then
            txtPass.Visibility = Visibility.Hidden
            passwordBox.Visibility = Visibility.Visible
            passwordBox.Focus()
        End If
    End Sub

    Private Sub checkToggle_Checked(sender As Object, e As RoutedEventArgs) Handles checkToggle.Checked
        If checkToggle.IsChecked = True Then
            ShowPassword()
        Else
            HidePassword()
        End If
    End Sub



    Private Sub txtUser_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtUser.GotFocus
        txtUser.Clear()
        txtUser.Focus()
    End Sub

    Private Sub txtUser_MouseLeave(sender As Object, e As MouseEventArgs) Handles txtUser.MouseLeave
        If (txtUser.Focus = False And txtUser.Text = "") Then
            txtUser.Text = "Username"

        End If
    End Sub

    Private Sub txtPass_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtPass.GotFocus
        txtPass.Clear()
        txtPass.Focus()
    End Sub


    Private Sub txtPass_MouseLeave(sender As Object, e As MouseEventArgs) Handles txtPass.MouseLeave
        If (txtPass.Focus = False And txtPass.Text = "") Then
            txtPass.Text = "Password"
        End If
    End Sub


End Class
