Imports System.Data.Entity

Public Class NewtechContext
    Inherits DbContext

    Public Property Clientes As DbSet(Of Client)
    Public Property Actividades As DbSet(Of Activity)

    Public Sub New()
        MyBase.New("Name=NewtechConnection")
    End Sub

End Class
