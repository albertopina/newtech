Imports NewTech.Services
Imports NewTech.Library.Database

Module Module1

    Sub Main()
        AppDomain.CurrentDomain.SetData("DataDirectory", "C:\Users\" & Environment.UserName & "\Source\DB")

        'Dim myContext As New NewTech.Library.Database.NewtechContext

        'Dim myCliente As New NewTech.Library.Database.Client
        'With myCliente
        '    .Nombre = "Knova SA de CV"
        'End With

        'myContext.Clients.Add(myCliente)
        'myContext.SaveChanges()
        'myContext.Dispose()

        

        Using myClientService As New ClientService
            'Try
            '    Dim myClient As New Client()
            '    myClient.ID = 3
            '    myClientService.Delete(myClient)
            '    myClientService.Save()
            '    System.Console.WriteLine("Ya te borro pinche Knova puto!")
            'Catch ex As Exception
            '    System.Console.WriteLine(ex.Message)
            'End Try

            'Try
            '    Dim newClient As New Client()
            '    'newClient.ID = 3
            '    newClient.Nombre = "El Oso es baboso"
            '    myClientService.Insert(newClient)
            '    myClientService.Save()
            'Catch ex As Exception
            '    System.Console.WriteLine(ex.Message)
            'End Try

            Try
                Dim myClient As New Client
                myClient.ID = 6
                myClient.Nombre = "No es tan baboso"
                myClientService.Update(myClient)
                myClientService.Save()
            Catch ex As Exception
                System.Console.WriteLine(ex.Message)
            End Try


            Dim myList As List(Of Client) = myClientService.GetClients()

            For Each mClient As Client In myList
                System.Console.WriteLine(mClient.ID & " - " & mClient.Nombre)
            Next

            System.Console.ReadKey()

        End Using
    End Sub

End Module
