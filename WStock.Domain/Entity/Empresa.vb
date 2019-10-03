Imports WStock.Framework.Bases

Public Class Empresa
    Inherits BaseModel
    Public Overridable Property Codigo As Integer
    Public Overridable Property Empresa As String

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj Is Nothing) Then Return False
        Dim entity = obj
        Return (Me.Codigo = entity.Codigo)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return String.Concat(Codigo).GetHashCode()
    End Function
End Class
