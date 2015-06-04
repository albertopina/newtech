Imports NewTech.Library.Database
''' <summary>
''' Equivalment from former business class (ah puto!)
''' </summary>
''' <remarks></remarks>
Public Class ClientService
    Implements IDisposable

    Private myContext As New NewTech.Library.Database.NewtechContext

    'Insert
    Public Sub Insert(cte As Client)
        myContext.Entry(cte).State = Entity.EntityState.Added
    End Sub

    'Update
    Public Sub Update(cte As Client)
        myContext.Entry(cte).State = Entity.EntityState.Modified
    End Sub

    'Delete
    Public Sub Delete(cte As Client)
        myContext.Entry(cte).State = Entity.EntityState.Deleted
    End Sub

    Public Function GetClientByID(id As Long) As Client
        Return myContext.Clients.Where(Function(a) a.ID = id).FirstOrDefault()
    End Function

    Public Function GetClients() As List(Of Client)
        Return myContext.Clients.Where(Function(a) a.Nombre <> String.Empty).ToList()
    End Function

    'Select
    Public Sub Save()
        myContext.SaveChanges()
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
                myContext.Dispose()
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
