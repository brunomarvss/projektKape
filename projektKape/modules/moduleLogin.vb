Module moduleLogin
    Sub ListLoginEmployee()
        '''''''''''''''''''''''''''''''Connection''''''''''''''''''''''''''''''''''''''
        With rs
            '''''''''''''''''''''''''''Update all data'''''''''''''''''''''''''''''''
            If .State <> 0 Then .Close()
            .Open("SELECT * FROM Employees WHERE NOT JobTitle='Owner'", cn, 1, 2)

            '''''''''''''''''''List all possible employee '''''''''''''''''''''''''''
            If .EOF = False Then

            End If
        End With

    End Sub
End Module
