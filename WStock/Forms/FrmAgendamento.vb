Imports WStock.Domain
Imports WStock.Framework.DepedencyInjection
Imports WStock.Framework.Extensions

Public Class FrmAgendamento
    Public Overridable Property Codigo As Integer

    Private Sub FrmAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Configurar()
            Carregar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Dim service = New AgendamentoService()
            service.Save(ObterDados())

            If service.Messages.HasErrors() Then
                MessageBox.Show(service.Messages.ToString(),
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            If MessageBox.Show("Você tem certeza que deseja cancelar este agendamento?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim service = New AgendamentoService()
                Dim entity = ObterDados()

                entity.DataCancelamento = Date.Now
                service.Cancel(entity)

                If service.Messages.HasErrors() Then
                    MessageBox.Show(service.Messages.ToString(),
                                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSaida_Click(sender As Object, e As EventArgs) Handles btnSaida.Click
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObterDados() As Agendamento
        Dim Agendamento As New Agendamento
        With Agendamento
            If String.IsNullOrEmpty(txtCodigo.Text) Then .Codigo = Nothing Else .Codigo = txtCodigo.Text
            .DataAgendamento = dtpAgendamento.Value
            .DataCancelamento = Nothing
            .Transportador = New Transportador()
            .Transportador.Codigo = nswTransportador.Codigo
            .Transportador.Transportador = nswTransportador.Descricao
            .Empresa = New Empresa()
            .Empresa.Codigo = nswEmpresa.Codigo
            .Empresa.Empresa = nswEmpresa.Descricao
            .TipoAgendamento = New TipoAgendamento()
            .TipoAgendamento.Codigo = nswTipoAgendamento.Codigo
            .TipoAgendamento.TipoAgendamento = nswTipoAgendamento.Descricao
            .TipoPallet = New TipoPallet()
            .TipoPallet.Codigo = nswTipoPallet.Codigo
            .TipoPallet.TipoPallet = nswTipoPallet.Descricao
            .TipoCarga = New TipoCarga()
            .TipoCarga.Codigo = nswTipoCarga.Codigo
            .TipoCarga.TipoCarga = nswTipoCarga.Descricao
            .TipoVeiculo = New TipoVeiculo()
            .TipoVeiculo.Codigo = nswTipoVeiculo.Codigo
            .TipoVeiculo.TipoVeiculo = nswTipoVeiculo.Descricao
            .NFE = txtNFE.Text
            .QuantidadePallet = IIf(IsNumeric(txtQtdPallet.Text), txtQtdPallet.Text, 0)
            .Origem = txtOrigem.Text
            .Destino = txtDestino.Text
            .NomeMotorista = txtNomeMotorista.Text
            .Observacao = txtObservacao.Text
        End With
        Return Agendamento
    End Function

    Private Sub LimparCampos()
        txtCodigo.Clear()
        dtpAgendamento.Value = Date.Now
        dtpAgendamento.Value = Date.Now
        nswTransportador.Clear()
        nswEmpresa.Clear()
        nswTipoAgendamento.Clear()
        nswTipoPallet.Clear()
        nswTipoCarga.Clear()
        nswTipoVeiculo.Clear()
        txtNFE.Clear()
        txtQtdPallet.Clear()
        txtOrigem.Clear()
        txtDestino.Clear()
        txtNomeMotorista.Clear()
        txtObservacao.Clear()
        btnEntrada.Enabled = False
        btnSaida.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub Carregar()
        If Codigo > 0 Then
            Dim Agendamento = DependencyInjectionFactory.CreateInstance(Of IAgendamentoRepository).SelectById(Codigo)
            If Not IsNothing(Agendamento) Then
                With Agendamento
                    txtCodigo.Text = .Codigo
                    dtpAgendamento.Value = .DataAgendamento
                    dtpDataCancelamento.Text = IIf(IsNothing(.DataCancelamento), String.Empty, .DataCancelamento)
                    nswTransportador.Codigo = .Transportador.Codigo
                    nswTransportador.Descricao = .Transportador.Transportador
                    nswEmpresa.Codigo = .Empresa.Codigo
                    nswEmpresa.Descricao = .Empresa.Empresa
                    nswTipoAgendamento.Codigo = .TipoAgendamento.Codigo
                    nswTipoAgendamento.Descricao = .TipoAgendamento.TipoAgendamento
                    nswTipoPallet.Codigo = .TipoPallet.Codigo
                    nswTipoPallet.Descricao = .TipoPallet.TipoPallet
                    nswTipoCarga.Codigo = .TipoCarga.Codigo
                    nswTipoCarga.Descricao = .TipoCarga.TipoCarga
                    nswTipoVeiculo.Codigo = .TipoVeiculo.Codigo
                    nswTipoVeiculo.Descricao = .TipoVeiculo.TipoVeiculo
                    txtNFE.Text = .NFE
                    txtQtdPallet.Text = .QuantidadePallet
                    txtOrigem.Text = .Origem
                    txtDestino.Text = .Destino
                    txtNomeMotorista.Text = .NomeMotorista
                    txtObservacao.Text = .Observacao
                End With
            End If
        End If
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