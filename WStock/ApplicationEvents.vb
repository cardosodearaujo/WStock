﻿Imports WStock.Domain
Imports WStock.Framework.DepedencyInjection
Imports WStock.Framework.NHibernate
Imports WStock.Infraestructure

Namespace My
    Partial Friend Class MyApplication
        Public Sub Start() Handles Me.Startup
            ConfigureConnection()
            ConfigureDependencyInjection()
        End Sub

        Public Sub Exception(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show("Ocorreu um erro sem tratamento! Consulte o suporte." + vbCrLf + e.Exception.Message)
        End Sub

        Public Sub ConfigureConnection()
            NHibernateConfigurationData.Dialect = "NHibernate.Dialect.MySQLDialect"
            NHibernateConfigurationData.Driver = "NHibernate.Driver.MySqlDataDriver"
            NHibernateConfigurationData.Provider = "NHibernate.Connection.DriverConnectionProvider"
            NHibernateConfigurationData.Connection = New Framework.Models.ConnectionData()
            NHibernateConfigurationData.Connection.Database = "bd_wstock"
            NHibernateConfigurationData.Connection.Server = "localhost"
            NHibernateConfigurationData.Connection.User = "cardoso"
            NHibernateConfigurationData.Connection.Password = "M1n3Rv@7"
            NHibernateConfigurationData.Assembly = "WStock.Infraestructure"
        End Sub

        Public Sub ConfigureDependencyInjection()
            DependencyInjectionFactory.AddDependencyInjection(GetType(IUsuarioRepository), GetType(UsuarioRepository))
            DependencyInjectionFactory.AddDependencyInjection(GetType(IAgendamentoRepository), GetType(AgendamentoRepository))
            DependencyInjectionFactory.AddDependencyInjection(GetType(IEmpresaRepository), GetType(EmpresaRepository))
            DependencyInjectionFactory.AddDependencyInjection(GetType(ITipoAgendamentoRepository), GetType(TipoAgendamentoRepository))
            DependencyInjectionFactory.AddDependencyInjection(GetType(ITipoCargaRepository), GetType(TipoCargaRepository))
            DependencyInjectionFactory.AddDependencyInjection(GetType(ITipoPalletRepository), GetType(TipoPalletRepository))
            DependencyInjectionFactory.AddDependencyInjection(GetType(ITipoVeiculoRepository), GetType(TipoVeiculoRepository))
            DependencyInjectionFactory.AddDependencyInjection(GetType(ITransportadorRepository), GetType(TransportadorRepository))
        End Sub
    End Class
End Namespace
