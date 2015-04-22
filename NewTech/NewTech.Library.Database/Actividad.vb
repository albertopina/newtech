Public Class Actividad

    Public Property ID As Long
    Public Overridable Property Cliente As Cliente
    Public Property Fecha As Date
    Public Property Horas As Integer
    Public Property CostoXHora As Double
    Public Property Descripcion As String
    Public Property Observaciones As String
    Public Property Realizado As Boolean
    Public Property Cobrado As Boolean
    Public Property Costo As Double

End Class
