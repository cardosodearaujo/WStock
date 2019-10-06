Imports WStock.Framework.Bases

Public Class Agendamento
    Inherits BaseModel
    Public Overridable Property Codigo As Integer?
    Public Overridable Property Transportador As Transportador
    Public Overridable Property Empresa As Empresa
    Public Overridable Property TipoAgendamento As TipoAgendamento
    Public Overridable Property TipoPallet As TipoPallet
    Public Overridable Property TipoCarga As TipoCarga
    Public Overridable Property TipoVeiculo As TipoVeiculo
    Public Overridable Property NFE As String
    Public Overridable Property NomeMotorista As String
    Public Overridable Property Observacao As String
    Public Overridable Property Origem As String
    Public Overridable Property Destino As String
    Public Overridable Property QuantidadePallet As Decimal
    Public Overridable Property DataAgendamento As DateTime
    Public Overridable Property DataEntrada As DateTime?
    Public Overridable Property DataSaida As DateTime?
    Public Overridable Property DataCancelamento As DateTime?

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj Is Nothing) Then Return False
        Dim entity = obj
        Return (Me.Codigo = entity.Codigo)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return String.Concat(Codigo).GetHashCode()
    End Function
End Class
