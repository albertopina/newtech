Module Module1

    Sub Main()

        Dim myContext As New NewTech.Library.Database.NewtechContext

        Dim myCliente As New NewTech.Library.Database.Client
        With myCliente
            .Nombre = "Knova SA de CV"
        End With

        myContext.Clientes.Add(myCliente)
        myContext.SaveChanges()
        myContext.Dispose()

    End Sub

End Module
