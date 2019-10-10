Imports WStock.Framework.Bases
Imports WStock.Framework.DepedencyInjection
Imports WStock.Framework.Extensions

Public Class FuncionarioService
    Inherits BaseService

    Private Repository As IFuncionarioRepository

    Public Sub New()
        Repository = DependencyInjectionFactory.CreateInstance(Of IFuncionarioRepository)
    End Sub

    Public Sub Save(entity As Funcionario)
        Dim validation = New FuncionarioSaveValidation()
        validation.Validate(entity)
        Messages = validation.Messages
        If Not validation.Messages.HasErrors() Then
            Repository.Save(entity)
        End If
    End Sub
End Class
