Module FunctionLogin

    ''''''''''''''''''''' Login Form ''''''''''''''''''''''''''''''''''''''
    Sub ClearUserInput()
        FormLogin.txtPass.Text = Nothing
        FormLogin.txtUser.Text = Nothing
        FormLogin.togglePass.Checked = False
    End Sub

    Sub UserLogin()
        global_user = FormLogin.txtUser.Text.Trim
        global_pass = FormLogin.txtPass.Text.Trim

        rs = New ADODB.Recordset

        If FormLogin.txtUser.Text = "" Or FormLogin.txtPass.Text = "" Then
            MsgBox("You must fill up all fields before you login", vbCritical, "Error")
            FormLogin.txtUser.Focus()
            Exit Sub
        End If

        With rs
            If .State <> 0 Then .Close()
            .Open("Select * from tbl_login where access_user='" + global_user +
                  "' and access_pass='" + global_pass + "'", cn, 1, 2)

            If .EOF = False Then
                global_user = .Fields("access_user").Value.ToString
                global_pass = .Fields("access_pass").Value.ToString

                'MsgBox(user + " " + pass)
                If global_user = FormLogin.txtUser.Text And global_pass = FormLogin.txtPass.Text Then
                    If .Fields("access_type").Value = "ADMIN" Then
                        MsgBox("Welcome Admin", vbInformation, "Welcome")
                        FormAdmin.Show()
                        FormLogin.Hide()
                    End If
                Else
                    MsgBox("The username you've entered doesn't match with any account", vbCritical, "Error")
                    FormLogin.txtUser.Text = ""
                    FormLogin.txtPass.Text = ""
                    FormLogin.txtUser.Focus()
                    Exit Sub
                End If

            Else
                MsgBox("The username you've entered doesn't match with ant account", vbCritical, "Error")
                FormLogin.txtUser.Text = ""
                FormLogin.txtPass.Text = ""
                FormLogin.txtUser.Focus()
                Exit Sub
            End If

            .Close()
        End With
    End Sub

End Module
