Module moduleAddEmployee
    Sub AddNewEmployee()
        ''  Declares the variable only on adding employees
        Dim getLname = "", getMname = "", getFname = "", getSuffix = "", getContact = "", getAddress = "", getCity = "", getProvince = "", getJob As String = ""
        Dim setLname = "", setMname = "", setFname = "", setSuffix = "", setContact = "", setAddress = "", setCity = "", setProvince = "", setJob As String = ""

        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            getJob = formAddEmployee.txtJobTitle.text.trim

            getLname = formAddEmployee.txtLname.Text.Trim
            getMname = formAddEmployee.txtMname.Text.Trim
            getFname = formAddEmployee.txtFname.Text.Trim
            getSuffix = formAddEmployee.txtSuffix.Text.Trim

            getContact = formAddEmployee.txtContact.Text.Trim
            getAddress = formAddEmployee.txtAddress.Text.Trim
            getCity = formAddEmployee.txtCity.Text.Trim
            getProvince = formAddEmployee.txtProvince.Text.Trim


            ''  Check if any text fields have no applicable record
            If Not getJob = "Work Title" Then
                setJob = getJob
            End If

            If Not getLname = "Last Name" Then
                setLname = getLname
            End If

            If Not getFname = "First Name" Then
                setFname = getFname
            End If

            If Not getMname = "Middle Name" Then
                setMname = getMname
            End If

            If Not getSuffix = "Suffix" Then
                setSuffix = getSuffix
            End If

            If Not getContact = "Contact Number" Then
                setContact = getContact
            End If

            If Not getAddress = "Address Details" Then
                setAddress = getAddress
            End If


            If Not getCity = "City" Then
                setCity = getCity
            End If

            If Not getProvince = "State/Province" Then
                setProvince = getProvince
            End If


            With rs
                If .State <> 0 Then .Close()
                .Open("INSERT INTO Employees (LastName, FirstName, MiddleName, Suffix, JobTitle, Contact, Address, City)" +
                      "VALUES ('" + setLname + "', '" + setFname + "', '" + setMname + "', '" + setSuffix + "', '" +
                      setJob + "', '" + setContact + "', '" + setAddress + "', '" + setCity + "');", cn, 1, 2)

                '''''''''''''''''''''''''Insert employee data on the database'''''''''''''''''''''''''
                MsgBox("Saving Successful!", MsgBoxStyle.Information, "Record Saved")
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Module
