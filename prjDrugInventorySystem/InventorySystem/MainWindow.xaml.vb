Class MainWindow
    Public isChecked As Boolean = False
    Private Sub FormLogin_Loaded(sender As Object, e As RoutedEventArgs) Handles FormLogin.Loaded
        Call dbConnection.Connect()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As RoutedEventArgs) Handles buttonLogin.Click
        MessageBox.Show("Hello World")

    End Sub

    Private Sub ShowPassword()
        textPassword.Text = passwordBox.Password
        textPassword.Visibility = Visibility.Visible
        passwordBox.Visibility = Visibility.Hidden
    End Sub

    Private Sub HidePassword()
        textPassword.Visibility = Visibility.Hidden
        passwordBox.Visibility = Visibility.Visible
        passwordBox.Focus()
    End Sub

    Private Sub checkToggle_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs) Handles checkToggle.Click
        If checkToggle.IsChecked = True Then
            ShowPassword()
        Else
            HidePassword()
        End If
    End Sub
End Class
