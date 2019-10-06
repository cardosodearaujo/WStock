Imports WStock.Framework.Bases
Imports WStock.Framework.DepedencyInjection
Imports WStock.Framework.Extensions

Public Class AgendamentoService
    Inherits BaseService

    Private Repository As IAgendamentoRepository

    Public Sub New()
        Repository = DependencyInjectionFactory.CreateInstance(Of IAgendamentoRepository)
    End Sub

    Public Sub Save(entity As Agendamento)
        Dim validation = New AgendamentoSaveValidation()
        validation.Validate(entity)
        Messages = validation.Messages
        If Not validation.Messages.HasErrors() Then
            Repository.Save(entity)
        End If
    End Sub

    Public Sub Cancel(entity As Agendamento)
        Dim validation = New AgendamentoSaveValidation()
        validation.Validate(entity)
        Messages = validation.Messages
        If Not validation.Messages.HasErrors() Then
            Repository.Update(entity)
        End If
    End Sub
End Class
