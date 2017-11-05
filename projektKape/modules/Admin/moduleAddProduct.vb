
Module moduleAddProduct
    Sub LoadRegisteredSuppliers()
        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Suppliers;", cn, 1, 2)

                '''''''''''''''''''''''''Select employee data only on the database'''''''''''''''''''''''''
                formAddProduct.comboSupplierList.Items.Clear()
                formAddProduct.comboSupplierIDs.Items.Clear()
                formAddProduct.comboSupplierList.Items.Add("(Select One Supplier)")
                formAddProduct.comboSupplierIDs.Items.Add("(Select One Supplier)")

                While .EOF = False
                    formAddProduct.comboSupplierList.Items.Add(.Fields("Company").Value)
                    formAddProduct.comboSupplierIDs.Items.Add(.Fields("ID").Value)
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub AddNewProduct()
        ''  Declares the variable only on adding employees
        Dim getBrand = "", getGeneric = "", getQty = "", getSupplier = "", getRawPrice = "", getSRP As String = ""
        Dim setBrand = "", setGeneric = "", setQty = "", setSupplier = "", setRawPrice = "", setSRP As String = ""
        Dim selectedSupplier As Integer = formAddProduct.comboSupplierList.SelectedIndex
        Dim selectedSupplierID As String = formAddProduct.comboSupplierIDs.Items.Item(selectedSupplier)


        Try
            rs = New ADODB.Recordset

            ''  Initialize declared variables
            getSupplier = formAddProduct.comboSupplierList.SelectedItem.ToString

            getBrand = formAddProduct.txtBrand.Text.Trim
            getGeneric = formAddProduct.txtGeneric.Text.Trim
            getQty = formAddProduct.txtQty.Text.Trim

            getRawPrice = formAddProduct.txtRawPrice.Text.Trim
            getSRP = formAddProduct.txtSRP.Text.Trim


            ''  Check if any text fields have no applicable record
            If Not getBrand = "Brand Name" Then
                setBrand = getBrand
            End If

            If Not getGeneric = "Generic Name" Then
                setGeneric = getGeneric
            End If

            If Not getQty = "Quantity" Then
                setQty = getQty
            End If

            If Not getSupplier = "(Select One Supplier)" Then
                setSupplier = getSupplier
            End If

            If Not getRawPrice = "Raw Price" Then
                setRawPrice = getRawPrice
            End If

            If Not getSRP = "SRP" Then
                setSRP = getSRP
            End If


            With rs
                If .State <> 0 Then .Close()
                .Open("INSERT INTO Products (BrandName, GenericName, RawPrice, SRP, Supplier_ID)" +
                      "VALUES ('" + setBrand + "', '" + setGeneric + "', '" + setRawPrice + "', '" + setSRP + "', '" + selectedSupplierID + "');", cn, 1, 2)

                If .State <> 0 Then .Close()
                .Open("INSERT INTO Inventory (Available, CurrentLevel)" +
                      "VALUES ('" + setQty + "','" + setQty + "');", cn, 1, 2)

                ''  Insert product data on the database
                MsgBox("Saving Successful!", MsgBoxStyle.Information, "Record Saved")
                formAddProduct.txtBrand.Text = Nothing
                formAddProduct.txtGeneric.Text = Nothing
                formAddProduct.txtQty.Text = Nothing
                formAddProduct.txtRawPrice.Text = Nothing
                formAddProduct.txtSRP.Text = Nothing
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Module
