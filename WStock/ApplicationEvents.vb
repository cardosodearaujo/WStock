Imports WStock.Domain
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
            DependencyInjectionFactory.AddDependencyInjection(GetType(IFuncionarioRepository), GetType(FuncionarioRepository))
            DependencyInjectionFactory.AddDependencyInjection(GetType(IAreaRepository), GetType(AreaRepository))
            DependencyInjectionFactory.AddDependencyInjection(GetType(ISituacaoRepository), GetType(SituacaoRepository))
            DependencyInjectionFactory.AddDependencyInjection(GetType(ITurnoRepository), GetType(TurnoRepository))
        End Sub
    End Class
End Namespace
