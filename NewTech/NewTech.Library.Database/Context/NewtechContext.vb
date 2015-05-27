Imports System.Data.Entity

Public Class NewtechContext
    Inherits DbContext

    Public Property Clients As DbSet(Of Client)
    Public Property Activities As DbSet(Of Activity)

    Public Sub New()
        MyBase.New("Name=NewtechConnection")
    End Sub

End Class
