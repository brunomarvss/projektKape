Module moduleAddProduct
    Sub AddNewProduct()
        ''  Declares the variable only on adding employees
        Dim getBrand = "", getGeneric = "", getQty = "", getSupplier = "", getRawPrice = "", getSRP As String = ""
        Dim setBrand = "", setGeneric = "", setQty = "", setSupplier = "", setRawPrice = "", setSRP As String = ""

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
                      "VALUES ('" + setBrand + "', '" + setGeneric + "', '" + setRawPrice + "', '" + setSRP + "', '" + setSupplier + "');", cn, 1, 2)

                If .State <> 0 Then .Close()
                .Open("INSERT INTO Inventory (Available)" +
                      "VALUES ('" + setQty + "');", cn, 1, 2)


                ''  Insert product data on the database
                MsgBox("Saving Successful!", MsgBoxStyle.Information, "Record Saved")
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Module
