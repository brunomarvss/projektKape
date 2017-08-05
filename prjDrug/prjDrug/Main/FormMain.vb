Imports Microsoft.Office.Interop
Public Class FormMain

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        '''''Database Connection'''''
        Call dbConnection.Connect()

        '
        '''''Get all information stored on the database and set on the list
        Call dbFunctions.listpreview()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xl As New Excel.Application
        Dim xlwbook As Excel.Workbook
        Dim xlwsheet As Excel.Worksheet

        xl = CreateObject("Excel.Application")
        xlwbook = xl.Workbooks.Add(Application.StartupPath & "\DRUG.xls")

        Dim num As Integer
        num = 1
        xlwsheet = xlwbook.Sheets("sheet1")
        Dim row As Integer = 4

        rs = New ADODB.Recordset
        With xlwsheet
            With rs
                xlwsheet.Cells(1, 1) = "Mercury Drug"
                xlwsheet.Cells(2, 1) = "List of " & ddDrugFilter.Text & ""
                If ddDrugFilter.SelectedIndex = 0 Then
                    .Open("Select * from tblDrug", cn, 1, 2)
                ElseIf ddDrugFilter.SelectedIndex = 1 Then
                    .Open("Select * from tblDrug where DRUG_GNAME ='" & ddDrugFilter.Text & "'", cn, 1, 2)
                ElseIf ddDrugFilter.SelectedIndex = 2 Then
                    .Open("Select * from tblDrug where DRUG_GNAME ='" & ddDrugFilter.Text & "'", cn, 1, 2)
                ElseIf ddDrugFilter.SelectedIndex = 3 Then
                    .Open("Select * from tblDrug where DRUG_GNAME ='" & ddDrugFilter.Text & "'", cn, 1, 2)
                Else
                    Exit Sub
                End If
                If .EOF = True Then
                    Exit Sub
                End If
                While .EOF = False
                    xlwsheet.Cells(row, 1) = num
                    xlwsheet.Cells(row, 2) = .Fields("DRUG_GNAME").Value
                    xlwsheet.Cells(row, 3) = .Fields("DRUG_NAME").Value
                    xlwsheet.Cells(row, 4) = .Fields("DRUG_STOCK").Value
                    xlwsheet.Cells(row, 5) = .Fields("DRUG_EXP").Value

                    num += 1
                    row += 1
                    .MoveNext()
                End While
                .Close()
            End With
        End With

        xl.Visible = True
        xlwbook.PrintPreview()
        xlwbook.Close()
        xl.Quit()
    End Sub


    Private Sub ddDrugFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddDrugFilter.SelectedIndexChanged
        Call dbFunctions.listfilter()
    End Sub
End Class
