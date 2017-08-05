Module dbConnection
    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Sub Connect()
        cn = New ADODB.Connection
        With cn
            If .State <> 0 Then .Close()
            .ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=../../../prjDB.mdb;Jet OLEDB:Database Password=PASSWORD;"
            .Open()
        End With
    End Sub

End Module
