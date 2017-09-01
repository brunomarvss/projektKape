Module moduleLogin
    '''''''''''''''''''''''''formEmployee variables'''''''''''''''''''''''''
    'Variable for listview that catches fetched data requested on the database
    Public listItems = vbEmpty

    'Gets all the information clicked by the user in a row on list of employees
    Public FullName = vbEmpty
    Public ContactDetails = vbEmpty

    '''''''''''''''''''''''''formLogin variables'''''''''''''''''''''''''
    'Gets the matching credentials request by the user
    Public global_user = vbEmpty
    Public global_pass = vbEmpty

    'Gets user inputed credentials to access his/her account
    Public input_user = vbEmpty
    Public input_pass = vbEmpty

    'Enables user to clear txtfields when first time using it
    Public token_user_count As Integer = 1
    Public token_pass_count As Integer = 1

    Public Sub ClearLogin()
        formLogin.txtUser.Text = vbEmpty
        formLogin.txtPass.Text = vbEmpty
        input_user = vbEmpty
        input_pass = vbEmpty
    End Sub

    Public Sub ListloginEmployee()
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Employees WHERE NOT JobTitle='Owner'", cn, 1, 2)

                '''''''''''''''''''''''''Select employee data only on the database'''''''''''''''''''''''''
                formEmployee.listEmployee.Items.Clear()

                While .EOF = False
                    listItems = formEmployee.listEmployee.Items.Add(.Fields("FirstName").Value + " " + .Fields("LastName").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("Contact").Value))
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub



    Public Sub loginAdmin()
        Try
            rs = New ADODB.Recordset

            'Restriction 
            If formLogin.txtUser.Text = "" Or formLogin.txtPass.Text = "" Then
                MsgBox("You must fill up all fields before you login", vbCritical, "Error")
                formLogin.txtUser.Focus()
                Exit Sub
            End If

            'Catches users inputed credentials
            input_user = formLogin.txtUser.Text.Trim
            input_pass = formLogin.txtPass.Text.Trim

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Employees WHERE AccessUser='" + input_user + "' AND AccessPass='" + input_pass + "' AND JobTitle='Owner'", cn, 1, 2)

                'Catches when query finds any matching account
                If .EOF = False Then
                    global_user = .Fields("AccessUser").Value.ToString
                    global_pass = .Fields("AccessPass").Value.ToString

                    'Checks if inputed credentials and global credentials are match
                    If global_user.Equals(input_user) And global_pass.Equals(input_pass) Then
                        MsgBox("WELCOME ADMIN!", MsgBoxStyle.Information, "ECT Pharmacy POS")

                        'Calls and clears all successfully signin credentials
                        Call moduleLogin.ClearLogin()
                        formLogin.Hide()
                        formMainAdmin.Show()
                        Exit Sub

                        'Notifies the user that inputed credentials is not match on accurate fetch data request
                    Else
                        MsgBox("INVALID USERNAME OR PASSWORD!", MsgBoxStyle.Critical, "ECT Pharmacy POS")
                        formLogin.txtUser.Focus()
                        Exit Sub
                    End If

                    'Notifies the user that login fails
                Else
                    MsgBox("The username or password you've entered doesn't match with any account, please check it correctly", MsgBoxStyle.Critical, "ECT Pharmacy POS")
                    formLogin.txtUser.Focus()
                    Exit Sub
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Module
