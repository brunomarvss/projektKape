Public Class formMainAdmin
    Dim selectedSearchType As String

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        labelTimeAdmin.Text = Format(Now, "yyyy-MM-dd    hh:mm:ss")
    End Sub

    Private Sub formMainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        moduleAdminStatistics.evaluateDailySales()

        '' List all datas recorded on the database
        refreshProductList()
        refreshEmployeeList()
        refreshSupplierList()
    End Sub

    Sub refreshProductList()
        Dim txtSearch = txtSearchProduct.Text.Trim

        If comboSearchProduct.SelectedIndex.Equals(0) Then
            selectedSearchType = "WHERE Products.BrandName LIKE '%" + txtSearch + "%'"
        ElseIf comboSearchProduct.SelectedIndex.Equals(1) Then
            selectedSearchType = "WHERE Inventory.Available LIKE '%" + txtSearch + "%'"
        ElseIf comboSearchProduct.SelectedIndex.Equals(2) Then
            selectedSearchType = "WHERE Suppliers.Company LIKE '%" + txtSearch + "%'"
        ElseIf comboSearchProduct.SelectedIndex.Equals(3) Then
            selectedSearchType = "WHERE Products.SRP LIKE '%" + txtSearch + "%'"
        Else
            selectedSearchType = Nothing
        End If

        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT Products.*, Suppliers.*, Inventory.Available " +
                      "FROM ((Products " +
                      "INNER JOIN Inventory ON Products.ID=Inventory.ID) " +
                      "INNER JOIN Suppliers ON Products.Supplier_ID=Suppliers.ID) " +
                      selectedSearchType + ";", cn, 1, 2)

                '''''''''''''''''''''''''Backup query if joining will be cancelled'''''''''''''''''''''''''
                '.Open("SELECT * FROM Products WHERE BrandName Like '%" + txtSearchProduct.Text.Trim + "%'", cn, 1, 2)

                '''''''''''''''''''''''''List all possible products search by employee'''''''''''''''''''''''''
                listProducts.Items.Clear()

                While .EOF = False
                    listItems = listProducts.Items.Add(.Fields("Products.ID").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("BrandName").Value))
                    listItems.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("GenericName").Value))
                    listItems.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("Available").Value))
                    listItems.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, .Fields("Company").Value))
                    listItems.SubItems.Insert(5, New ListViewItem.ListViewSubItem(Nothing, .Fields("RawPrice").Value))
                    listItems.SubItems.Insert(6, New ListViewItem.ListViewSubItem(Nothing, .Fields("SRP").Value))
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub refreshEmployeeList()
        Dim txtSearch = txtSearchEmployee.Text.Trim

        If comboSearchEmployee.SelectedIndex.Equals(0) Then
            selectedSearchType = "AND (Address LIKE '%" + txtSearch + "%' OR City LIKE '%" + txtSearch + "%' OR Province LIKE '%" + txtSearch + "%')"
        ElseIf comboSearchEmployee.SelectedIndex.Equals(1) Then
            selectedSearchType = "AND Contact LIKE '%" + txtSearch + "%'"
        ElseIf comboSearchEmployee.SelectedIndex.Equals(2) Then
            selectedSearchType = "AND JobTitle LIKE '%" + txtSearch + "%'"
        ElseIf comboSearchEmployee.SelectedIndex.Equals(3) Then
            selectedSearchType = "AND (LastName LIKE '%" + txtSearch + "%' OR Suffix LIKE '%" + txtSearch + "%' OR FirstName LIKE '%" + txtSearch + "%' OR MiddleName LIKE '%" + txtSearch + "%')"
        Else
            selectedSearchType = Nothing
        End If

        Try
            rs = New ADODB.Recordset

            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Employees " +
                "WHERE NOT JobTitle='Owner' " + selectedSearchType + ";", cn, 1, 2)

                ''  List all registered employee accounts from the database
                listEmployee.Items.Clear()

                While .EOF = False
                    listItems = listEmployee.Items.Add(.Fields("LastName").Value + " " + .Fields("Suffix").Value + ", " + .Fields("FirstName").Value + " " + .Fields("MiddleName").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("Contact").Value))
                    listItems.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("JobTitle").Value))
                    listItems.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("Address").Value + " " + .Fields("City").Value + " " + .Fields("Province").Value))
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub refreshSupplierList()
        Dim txtSearch = txtSearchSupplier.Text.Trim
        Dim txtSelectedSearch As String = ""
        Dim getSuffix = "", setSuffix As String = ""

        If comboSearchSupplier.SelectedIndex = 0 Then
            txtSelectedSearch = "WHERE (Address LIKE '%" + txtSearch + "%' OR City LIKE '%" + txtSearch + "%' OR Province LIKE '%" + txtSearch + "%')"
        ElseIf comboSearchSupplier.SelectedIndex = 1 Then
            txtSelectedSearch = "WHERE Company LIKE '%" + txtSearch + "%'"
        ElseIf comboSearchSupplier.SelectedIndex = 2 Then
            txtSelectedSearch = "WHERE Contact LIKE '%" + txtSearch + "%'"
        ElseIf comboSearchSupplier.SelectedIndex = 3 Then
            txtSelectedSearch = "WHERE LastName LIKE '%" + txtSearch + "%' OR FirstName LIKE '%" + txtSearch + "%' OR Suffix LIKE '%" + txtSearch + "%'"
        Else
        End If

        Try
            rs = New ADODB.Recordset
            With rs
                If .State <> 0 Then .Close()
                .Open("SELECT * FROM Suppliers " + txtSelectedSearch + ";", cn, 1, 2)

                '''''''''''''''''''''''''Select supplier data only on the database'''''''''''''''''''''''''
                listSupplier.Items.Clear()

                While .EOF = False
                    ''  Initials variable to clear recent value
                    getSuffix = vbNull
                    getSuffix = .Fields("Suffix").Value

                    ''  Checks if variable is not null 
                    If Not getSuffix.Equals("<N/A>") Then
                        setSuffix = " " + getSuffix
                    End If

                    listItems = listSupplier.Items.Add(.Fields("Company").Value)
                    listItems.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("LastName").Value + setSuffix + ", " + .Fields("FirstName").Value))
                    listItems.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("Contact").Value))
                    listItems.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("Address").Value + ", " + .Fields("City").Value + ", " + .Fields("Province").Value))
                    .MoveNext()
                End While
                .Close()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs)
        MsgBox("Double click an item in the listview to add a stock.", vbInformation)

    End Sub



    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        formAddEmployee.ShowDialog()
    End Sub
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        formAddProduct.ShowDialog()
    End Sub
    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        formAddSupplier.ShowDialog()
    End Sub



    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        refreshProductList()
    End Sub
    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        refreshEmployeeList()
    End Sub
    Private Sub txtSearchSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSupplier.TextChanged
        refreshSupplierList()
    End Sub


End Class