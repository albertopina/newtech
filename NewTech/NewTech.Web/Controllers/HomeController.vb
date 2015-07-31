Imports NewTech.Library.Database
Imports NewTech.Services

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Title") = "Home Page"

        Dim service As New ClientService
        Dim allClients As List(Of Client) = service.GetClients()

        Return View(allClients)
    End Function
End Class


