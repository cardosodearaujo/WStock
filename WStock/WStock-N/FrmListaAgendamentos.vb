Imports WStock.Domain
Imports WStock.Framework.DepedencyInjection

Public Class FrmListaAgendamentos
    Private Sub FrmListaAgendamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Configurar()
        Filtrar()
    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Filtrar()
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Dim FrmAgendamento As New FrmAgendamento
        FrmAgendamento.ShowDialog()
    End Sub

    Private Sub DgvAgendamentos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAgendamentos.CellDoubleClick
        Dim FrmAgendamento As New FrmAgendamento
        FrmAgendamento.ShowDialog()
    End Sub

    Private Function Listar() As List(Of Agendamento)
        Return DependencyInjectionFactory _
            .CreateInstance(Of IAgendamentoRepository) _
            .SelectAll()
    End Function

    Private Sub Carregar(lista As List(Of Agendamento))
        dgvAgendamentos.DataSource = lista.[Select](Function(F) New AgendamentoVO With {
            .Codigo = F.Codigo,
            .CodigoTransportadora = F.Transportador.Codigo,
            .Transportadora = F.Transportador.Transportador,
            .CodigoEmpresa = F.Empresa.Codigo,
            .Empresa = F.Empresa.Empresa,
            .CodigoTipoAgendamento = F.TipoAgendamento.Codigo,
            .TipoAgendamento = F.TipoAgendamento.TipoAgendamento,
            .CodigoTipoPallet = F.TipoPallet.Codigo,
            .TipoPallet = F.TipoPallet.TipoPallet,
            .CodigoTipoCarga = F.TipoCarga.Codigo,
            .TipoCarga = F.TipoCarga.TipoCarga,
            .CodigoTipoVeiculo = F.TipoVeiculo.Codigo,
            .TipoVeiculo = F.TipoVeiculo.TipoVeiculo,
            .NFE = F.NFE,
            .NomeMotorista = F.NomeMotorista,
            .Observacao = F.Observacao,
            .Origem = F.Origem,
            .Destino = F.Destino,
            .QuantidadePallet = F.QuantidadePallet,
            .DataAgendamento = F.DataAgendamento,
            .DataCancelamento = F.DataCancelamento
        }).ToList()
    End Sub

    Private Sub Filtrar()
        Dim lista = Listar()

        If Not String.IsNullOrEmpty(nswTransportador.CodigoRetorno) Then
            lista = lista.AsEnumerable.Where(Function(F) F.Transportador.Codigo = nswTransportador.CodigoRetorno).ToList()
        End If

        If Not String.IsNullOrEmpty(nswEmpresa.CodigoRetorno) Then
            lista = lista.AsEnumerable.Where(Function(F) F.Empresa.Codigo = nswEmpresa.CodigoRetorno).ToList()
        End If

        If Not String.IsNullOrEmpty(nswTipoAgendamento.CodigoRetorno) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoAgendamento.Codigo = nswTipoAgendamento.CodigoRetorno).ToList()
        End If

        If Not String.IsNullOrEmpty(nswTipoPallet.CodigoRetorno) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoPallet.Codigo = nswTipoPallet.CodigoRetorno).ToList()
        End If

        If Not String.IsNullOrEmpty(nswTipoCarga.CodigoRetorno) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoCarga.Codigo = nswTipoCarga.CodigoRetorno).ToList()
        End If

        If Not String.IsNullOrEmpty(nswTipoVeiculo.CodigoRetorno) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoVeiculo.Codigo = nswTipoVeiculo.CodigoRetorno).ToList()
        End If

        If Not String.IsNullOrEmpty(txtNumNFe.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.NFE = txtNumNFe.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtQtdPallet.Text) AndAlso IsNumeric(txtQtdPallet.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.QuantidadePallet = txtQtdPallet.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtOrigem.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.Origem = txtOrigem.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtDestino.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.Destino = txtDestino.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtNomeMotorista.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.NomeMotorista = txtNomeMotorista.Text).ToList()
        End If

        If Not IsNothing(dtpAgendaDe.Value) Then
            lista = lista.AsEnumerable.Where(Function(F) F.DataAgendamento >= Date.Parse(dtpAgendaDe.Value.ToShortDateString + " 00:00")).ToList()
        End If

        If Not IsNothing(dtpAgendaAte.Value) Then
            lista = lista.AsEnumerable.Where(Function(F) F.DataAgendamento <= Date.Parse(dtpAgendaAte.Value.ToShortDateString + " 23:59")).ToList()
        End If

        If Not String.IsNullOrEmpty(txtObservacao.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.Observacao = txtObservacao.Text).ToList()
        End If

        If chkOcultarCancelados.Checked Then
            lista = lista.AsEnumerable.Where(Function(F) F.DataCancelamento = Date.MinValue).ToList()
        End If

        Carregar(lista)
    End Sub

    Private Sub Configurar()
        ConfigTransportador()
        ConfigEmpresa()
        ConfigTipoAgendamento()
        ConfigTipoPallet()
        ConfigTipoCarga()
        ConfigTipoVeiculo()
    End Sub

    Private Sub ConfigTransportador()
        With nswTransportador
            .Titulo = "Transportador"
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TRANSPORTADOR"
            .ListaColunas = New List(Of RotuloPesquisaVO)
            .ListaColunas.Add(New RotuloPesquisaVO("CODIGO", "Código"))
            .ListaColunas.Add(New RotuloPesquisaVO("TRANSPORTADOR", "Transportador"))
            .Tabela = "TB_TRANSPORTADOR"
        End With
    End Sub

    Private Sub ConfigEmpresa()
        With nswEmpresa
            .Titulo = "Empresa"
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "EMPRESA"
            .ListaColunas = New List(Of RotuloPesquisaVO)
            .ListaColunas.Add(New RotuloPesquisaVO("CODIGO", "Código"))
            .ListaColunas.Add(New RotuloPesquisaVO("EMPRESA", "Empresa"))
            .Tabela = "TB_EMPRESA"
        End With
    End Sub

    Private Sub ConfigTipoAgendamento()
        With nswTipoAgendamento
            .Titulo = "Tipo de agendamento"
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TIPO_AGENDAMENTO"
            .ListaColunas = New List(Of RotuloPesquisaVO)
            .ListaColunas.Add(New RotuloPesquisaVO("CODIGO", "Código"))
            .ListaColunas.Add(New RotuloPesquisaVO("TIPO_AGENDAMENTO", "Tipo de agendamento"))
            .Tabela = "TB_TIPO_AGENDAMENTO"
        End With
    End Sub

    Private Sub ConfigTipoPallet()
        With nswTipoPallet
            .Titulo = "Tipo de pallet"
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TIPO_PALLET"
            .ListaColunas = New List(Of RotuloPesquisaVO)
            .ListaColunas.Add(New RotuloPesquisaVO("CODIGO", "Código"))
            .ListaColunas.Add(New RotuloPesquisaVO("TIPO_PALLET", "Tipo de pallet"))
            .Tabela = "TB_TIPO_PALLET"
        End With
    End Sub

    Private Sub ConfigTipoCarga()
        With nswTipoCarga
            .Titulo = "Tipo de Carga"
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TIPO_CARGA"
            .ListaColunas = New List(Of RotuloPesquisaVO)
            .ListaColunas.Add(New RotuloPesquisaVO("CODIGO", "Código"))
            .ListaColunas.Add(New RotuloPesquisaVO("TIPO_CARGA", "Tipo de carga"))
            .Tabela = "TB_TIPO_CARGA"
        End With
    End Sub

    Private Sub ConfigTipoVeiculo()
        With nswTipoVeiculo
            .Titulo = "Tipo de veículo"
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TIPO_VEICULO"
            .ListaColunas = New List(Of RotuloPesquisaVO)
            .ListaColunas.Add(New RotuloPesquisaVO("CODIGO", "Código"))
            .ListaColunas.Add(New RotuloPesquisaVO("TIPO_VEICULO", "Tipo de veículo"))
            .Tabela = "TB_TIPO_VEICULO"
        End With
    End Sub

End Class