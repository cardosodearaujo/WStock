Imports WStock.Framework.Bases

Public Class Funcionario
    Inherits BaseModel
    Public Overridable Property Codigo As Integer
    Public Overridable Property Empresa As Empresa
    Public Overridable Property Turno As Turno
    Public Overridable Property Area As Area
    Public Overridable Property Situacao As Situacao
    Public Overridable Property NomeFuncionario As String
    Public Overridable Property Telefone As String
    Public Overridable Property BancoHoras As Decimal
    Public Overridable Property TerminoContrato As DateTime

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj Is Nothing) Then Return False
        Dim entity = obj
        Return (Me.Codigo = entity.Codigo)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return String.Concat(Codigo).GetHashCode()
    End Function
End Class
