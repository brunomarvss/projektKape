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

            If useradmin.Equals(txtUser.Text.ToLower()) And passadmin.Equals(txtPass.Text.ToLower()) Then
                MsgBox("WELCOME ADMIN!", MsgBoxStyle.Information, "ECT Pharmacy POS")
                Me.Hide()
                'formUI.Show()

            ElseIf userassist.Equals(txtUser.Text.ToLower()) And passassist.Equals(txtPass.Text.ToLower()) Then
                'MsgBox("WELCOME!")
                Me.Hide()
                formMainPos.Show()

            Else
                MsgBox("INVALID USERNAME OR PASSWORD!", MsgBoxStyle.Critical, "ECT Pharmacy POS")
                txtPass.Clear()
                txtPass.Focus()

            End If

        End With
    End Sub

    Private Sub ShowPassword()
        If (txtPass.Text = "") Then
            txtPass.Visible = True
            passwordBox.Visible = False
            txtPass.Focus()
            txtPass.Text = passwordBox.Text
        End If
    End Sub

    Private Sub HidePassword()
        If (txtPass.Text = "") Then
            txtPass.Visible = False
            passwordBox.Visible = True
            passwordBox.Focus()
        End If
    End Sub

    Private Sub checkToggle_CheckedChanged(sender As Object, e As EventArgs) Handles checkToggle.CheckedChanged
        If checkToggle.Checked = True Then
            'ShowPassword()
            passwordBox.PasswordChar = Nothing

        Else
            'HidePassword()
            passwordBox.PasswordChar = "●"
        End If
    End Sub

    Private Sub txtUser_Click(sender As Object, e As EventArgs) Handles txtUser.Click
        txtUser.Clear()
    End Sub

    Private Sub passwordBox_Click(sender As Object, e As EventArgs) Handles passwordBox.Click

    End Sub
End Class
