Class MainWindow

    Private Sub FormLogin_Loaded(sender As Object, e As RoutedEventArgs) Handles FormLogin.Loaded
        Call dbConnection.Connect()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As RoutedEventArgs) Handles buttonLogin.Click
        MessageBox.Show("Hello World")

    End Sub

    Private Sub ShowPassword()
        textPassword.Visibility = Visibility.Visible
        passwordBox.Visibility = Visibility.Hidden
        textPassword.Text = passwordBox.Password
    End Sub

    Private Sub HidePassword()
        textPassword.Visibility = Visibility.Hidden
        passwordBox.Visibility = Visibility.Visible
        passwordBox.Focus()
    End Sub
    Private Sub checkToggle_Checked(sender As Object, e As RoutedEventArgs) Handles checkToggle.Checked
        If checkToggle.IsChecked = True Then
            ShowPassword()
        Else
            HidePassword()
        End If
    End Sub
End Class
