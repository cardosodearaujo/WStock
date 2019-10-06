Imports WStock.Domain.My.Resources
Imports WStock.Framework.Bases

Public Class AgendamentoSaveValidation
    Inherits BaseValidation(Of Agendamento)

    Public Overrides Sub Validate(objeto As Agendamento)
        If objeto.Transportador.Codigo <= 0 Then
            AddAlert(AgendamentoResource.VALIDA_TRANSPORTADOR)
        End If

        If objeto.Empresa.Codigo <= 0 Then
            AddAlert(AgendamentoResource.VALIDA_EMPRESA)
        End If

        If objeto.TipoAgendamento.Codigo <= 0 Then
            AddAlert(AgendamentoResource.VALIDA_TIPO_AGENDAMENTO)
        End If

        If objeto.TipoPallet.Codigo <= 0 Then
            AddAlert(AgendamentoResource.VALIDA_TIPO_PALLET)
        End If

        If objeto.TipoCarga.Codigo <= 0 Then
            AddAlert(AgendamentoResource.VALIDA_TIPO_CARGA)
        End If

        If objeto.TipoVeiculo.Codigo <= 0 Then
            AddAlert(AgendamentoResource.VALIDA_TIPO_VEICULO)
        End If

        If String.IsNullOrEmpty(objeto.NFE) Then
            AddAlert(AgendamentoResource.VALIDA_NFE)
        End If

        If objeto.QuantidadePallet <= 0 Then
            AddAlert(AgendamentoResource.VALIDA_QTD_PALLET)
        End If
    End Sub
End Class
