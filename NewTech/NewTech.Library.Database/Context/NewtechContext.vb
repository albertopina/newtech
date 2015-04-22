Imports System.Data.Entity

Public Class NewtechContext
    Inherits DbContext

    Public Property Clientes As DbSet(Of Cliente)
    Public Property Actividades As DbSet(Of Actividad)

    Public Sub New()
        MyBase.New("Name=NewtechConnection")
    End Sub

End Class
