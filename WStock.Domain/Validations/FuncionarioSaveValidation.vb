Imports WStock.Domain.My.Resources
Imports WStock.Framework.Bases

Public Class FuncionarioSaveValidation
    Inherits BaseValidation(Of Funcionario)

    Public Overrides Sub Validate(objeto As Funcionario)
        If String.IsNullOrEmpty(objeto.NomeFuncionario) Then
            AddAlert(FuncionarioResource.VALIDA_NOME)
        End If

        If IsNothing(objeto.TerminoContrato) OrElse objeto.TerminoContrato = Date.MinValue Then
            AddAlert(FuncionarioResource.VALIDA_TERMINO_CONTRATO)
        End If

        If String.IsNullOrEmpty(objeto.Telefone) Then
            AddAlert(FuncionarioResource.VALIDA_TELEFONE)
        End If

        If objeto.Empresa.Codigo <= 0 Then
            AddAlert(FuncionarioResource.VALIDA_EMPRESA)
        End If

        If objeto.Turno.Codigo <= 0 Then
            AddAlert(FuncionarioResource.VALIDA_TURNO)
        End If

        If objeto.Situacao.Codigo <= 0 Then
            AddAlert(FuncionarioResource.VALIDA_SITUACAO)
        End If

        If objeto.Area.Codigo <= 0 Then
            AddAlert(FuncionarioResource.VALIDA_AREA)
        End If

    End Sub
End Class
