Imports WStock.Domain
Imports WStock.Framework.DepedencyInjection

Public Class FrmAgendamento

    Private Sub FrmAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarComboTransportadora()
        CarregarComboEmpresa()
        CarregarComboTipoAgendamento()
        CarregarComboTipoPallet()
        CarregarComboTipoCarga()
        CarregarComboTipoVeiculo()
    End Sub
    Private Sub CarregarComboTransportadora()
        Dim lista = DependencyInjectionFactory _
            .CreateInstance(Of ITransportadorRepository) _
            .SelectAll()

        cboTransportadora.DataSource = lista
        cboTransportadora.ValueMember = "Codigo"
        cboTransportadora.DisplayMember = "Transportador"
    End Sub
    Private Sub CarregarComboEmpresa()
        Dim lista = DependencyInjectionFactory _
            .CreateInstance(Of IEmpresaRepository) _
            .SelectAll()

        cboEmpresa.DataSource = lista
        cboEmpresa.ValueMember = "Codigo"
        cboEmpresa.DisplayMember = "Empresa"
    End Sub
    Private Sub CarregarComboTipoAgendamento()
        Dim lista = DependencyInjectionFactory _
            .CreateInstance(Of ITipoAgendamentoRepository) _
            .SelectAll()

        cboTipoAgendamento.DataSource = lista
        cboTipoAgendamento.ValueMember = "Codigo"
        cboTipoAgendamento.DisplayMember = "TipoAgendamento"
    End Sub
    Private Sub CarregarComboTipoPallet()
        Dim lista = DependencyInjectionFactory _
            .CreateInstance(Of ITipoPalletRepository) _
            .SelectAll()

        cboTipopPallet.DataSource = lista
        cboTipopPallet.ValueMember = "Codigo"
        cboTipopPallet.DisplayMember = "TipoPallet"
    End Sub
    Private Sub CarregarComboTipoCarga()
        Dim lista = DependencyInjectionFactory _
            .CreateInstance(Of ITipoCargaRepository) _
            .SelectAll()

        cboTipoCarga.DataSource = lista
        cboTipoCarga.DisplayMember = "Codigo"
        cboTipoCarga.DisplayMember = "TipoCarga"
    End Sub
    Private Sub CarregarComboTipoVeiculo()
        Dim lista = DependencyInjectionFactory _
            .CreateInstance(Of ITipoVeiculoRepository) _
            .SelectAll()

        cboTipoVeiculo.DataSource = lista
        cboTipoVeiculo.ValueMember = "Codigo"
        cboTipoVeiculo.DisplayMember = "TipoVeiculo"
    End Sub
End Class