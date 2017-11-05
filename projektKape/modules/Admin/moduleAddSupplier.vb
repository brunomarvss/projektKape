Module moduleAddSupplier
    Sub AddNewSupplier()
        ''  Declares the variable only on adding suppliers
        Dim getLname = "", getFname = "", getSuffix = "", getContact = "", getAddress = "", getCity = "", getProvince = "", getCompany As String = ""
        Dim setLname = "", setFname = "", setSuffix = "", setContact = "", setAddress = "", setCity = "", setProvince = "", setCompany As String = ""

        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            getCompany = formAddSupplier.txtCompany.Text.Trim

            getLname = formAddSupplier.txtLname.Text.Trim
            getFname = formAddSupplier.txtFname.Text.Trim
            getSuffix = formAddSupplier.txtSuffix.Text.Trim

            getContact = formAddSupplier.txtContact.Text.Trim
            getAddress = formAddSupplier.txtAddress.Text.Trim
            getCity = formAddSupplier.txtCity.Text.Trim
            getProvince = formAddSupplier.txtProvince.Text.Trim


            ''  Check if any text fields have no applicable record
            If Not getCompany = "Company Name" Then
                setCompany = getCompany
            End If

            If Not getLname = "Last Name" Then
                setLname = getLname
            End If

            If Not getFname = "First Name" Then
                setFname = getFname
            End If

            If Not getSuffix = "Suffix e.g. (Jr.)" Then
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

            If Not getProvince = "Province" Then
                setProvince = getProvince
            End If


            With rs
                If .State <> 0 Then .Close()

                ''  Saves new supplier data on the database
                .Open("INSERT INTO Suppliers (LastName, FirstName, Suffix, Company, Contact, Address, City, Province)" +
                      "VALUES ('" + setLname + "', '" + setFname + "', '" + setSuffix + "', '" +
                      setCompany + "', '" + setContact + "', '" + setAddress + "', '" + setCity + "', '" + setProvince + "');", cn, 1, 2)

                MsgBox("Saving Successful!", MsgBoxStyle.Information, "Record Saved")
                formAddSupplier.txtCompany.Text = Nothing

                formAddSupplier.txtLname.Text = Nothing
                formAddSupplier.txtFname.Text = Nothing
                formAddSupplier.txtSuffix.Text = Nothing

                formAddSupplier.txtContact.Text = Nothing
                formAddSupplier.txtAddress.Text = Nothing
                formAddSupplier.txtCity.Text = Nothing
                formAddSupplier.txtProvince.Text = Nothing
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Module
