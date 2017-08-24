Module dbFunctions
    Public lstDrug As New ListViewItem
    Public global_guess_id = "", global_admin_id As String = ""
    Public global_pass = "", global_user = ""
    Public active As Boolean = False

    Sub listpreview()
        rs = New ADODB.Recordset
        With rs
            If .State <> 0 Then .Close()
            .Open("SELECT * FROM tblDrug", cn, 1, 2)
            If .EOF = True Then
                Exit Sub
            End If

            FormMain.ListView1.Items.Clear()
            While .EOF = False
                lstDrug = FormMain.ListView1.Items.Add(.Fields("DRUG_ID").Value)
                lstDrug.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("DRUG_GNAME").Value))
                lstDrug.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("DRUG_NAME").Value))
                lstDrug.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("DRUG_STOCK").Value))
                lstDrug.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, .Fields("DRUG_EXP").Value))
                .MoveNext()
            End While

        End With
    End Sub



    Sub listfilter()
        rs = New ADODB.Recordset
        With rs
            If .State <> 0 Then .Close()
            .Open("SELECT * FROM tblDrug '" +
                  "'WHERE DRUG_GNAME='" + FormMain.ddDrugFilter.SelectedItem + "'", cn, 1, 2)

            If .EOF = True Then
                Exit Sub
                ''Call dbFunctions.listpreview()
            End If

            FormMain.ListView1.Items.Clear()
            While .EOF = False
                lstDrug = FormMain.ListView1.Items.Add(.Fields("DRUG_ID").Value)
                lstDrug.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("DRUG_GNAME").Value))
                lstDrug.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("DRUG_NAME").Value))
                lstDrug.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("DRUG_STOCK").Value))
                lstDrug.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, .Fields("DRUG_EXP").Value))
                .MoveNext()
            End While
        End With
    End Sub
End Module
