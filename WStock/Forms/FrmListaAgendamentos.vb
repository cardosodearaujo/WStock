Imports WStock.Domain
Imports WStock.Framework.DepedencyInjection

Public Class FrmListaAgendamentos
    Private Sub FrmListaAgendamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Configurar()
            Filtrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            Filtrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Try
            Dim FrmAgendamento As New FrmAgendamento
            FrmAgendamento.ShowDialog()
            Filtrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvAgendamentos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAgendamentos.CellDoubleClick
        Try
            If dgvAgendamentos.Rows.Count > 0 Then
                Dim FrmAgendamento As New FrmAgendamento
                FrmAgendamento.Codigo = dgvAgendamentos.Item("CODIGO", e.RowIndex).Value
                FrmAgendamento.ShowDialog()
                Filtrar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FrmListaAgendamentos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.Control = False And e.Shift = False And e.Alt = False And e.KeyCode = Keys.F10 Then
                ExportGridToExcel.ExportGridToExcel(dgvAgendamentos, xlsOption.xlsOpen, New FrmPesquisa, tspExportar)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Listar() As List(Of Agendamento)
        Return DependencyInjectionFactory _
            .CreateInstance(Of IAgendamentoRepository) _
            .SelectAll()
    End Function

    Private Sub Carregar(lista As List(Of Agendamento))

        tspTotalRegistros.Text = "Total de registros: " & lista.Count

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

        If Not String.IsNullOrEmpty(nswTransportador.Codigo) Then
            lista = lista.AsEnumerable.Where(Function(F) F.Transportador.Codigo = nswTransportador.Codigo).ToList()
        End If

        If Not String.IsNullOrEmpty(nswEmpresa.Codigo) Then
            lista = lista.AsEnumerable.Where(Function(F) F.Empresa.Codigo = nswEmpresa.Codigo).ToList()
        End If

        If Not String.IsNullOrEmpty(nswTipoAgendamento.Codigo) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoAgendamento.Codigo = nswTipoAgendamento.Codigo).ToList()
        End If

        If Not String.IsNullOrEmpty(nswTipoPallet.Codigo) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoPallet.Codigo = nswTipoPallet.Codigo).ToList()
        End If

        If Not String.IsNullOrEmpty(nswTipoCarga.Codigo) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoCarga.Codigo = nswTipoCarga.Codigo).ToList()
        End If

        If Not String.IsNullOrEmpty(nswTipoVeiculo.Codigo) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoVeiculo.Codigo = nswTipoVeiculo.Codigo).ToList()
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
            lista = lista.AsEnumerable.Where(Function(F) IsNothing(F.DataCancelamento)).ToList()
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