Imports WStock.Domain
Imports WStock.Framework.DepedencyInjection

Public Class FrmListaAgendamentos
    Private Sub FrmListaAgendamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Filtrar()
    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Filtrar()
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Dim FrmAgendamento As New FrmAgendamento
        FrmAgendamento.ShowDialog()
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesqTrans.Click
        Dim Lista As New List(Of RotuloPesquisaVO)
        Lista.Add(New RotuloPesquisaVO("CODIGO", "Código"))
        Lista.Add(New RotuloPesquisaVO("TRANSPORTADOR", "Transportador"))

        Dim FrmPesquisa As New FrmPesquisa
        With FrmPesquisa
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TRANSPORTADOR"
            .ListaColunas = Lista
            .Tabela = "TB_TRANSPORTADOR"
        End With

        FrmPesquisa.ShowDialog()

        If Not IsNothing(FrmPesquisa.CodigoRetorno) Then
            txtCodTrans.Text = FrmPesquisa.CodigoRetorno.ToString()
            txtDscTrans.Text = FrmPesquisa.DescricaoRetorno.ToString()
        End If
    End Sub

    Private Sub BtnLimparTransportador_Click(sender As Object, e As EventArgs) Handles btnLimpTrans.Click
        txtCodTrans.Text = String.Empty
        txtDscTrans.Text = String.Empty
    End Sub

    Private Sub BtnPesqEmp_Click(sender As Object, e As EventArgs) Handles btnPesqEmp.Click
        Dim Lista As New List(Of RotuloPesquisaVO)
        Lista.Add(New RotuloPesquisaVO("CODIGO", "Código"))
        Lista.Add(New RotuloPesquisaVO("EMPRESA", "Empresa"))

        Dim FrmPesquisa As New FrmPesquisa
        With FrmPesquisa
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "EMPRESA"
            .ListaColunas = Lista
            .Tabela = "TB_EMPRESA"
        End With

        FrmPesquisa.ShowDialog()

        If Not IsNothing(FrmPesquisa.CodigoRetorno) Then
            txtCodEmp.Text = FrmPesquisa.CodigoRetorno.ToString()
            txtDscEmp.Text = FrmPesquisa.DescricaoRetorno.ToString()
        End If
    End Sub

    Private Sub BtnLimpEmp_Click(sender As Object, e As EventArgs) Handles btnLimpEmp.Click
        txtCodEmp.Text = String.Empty
        txtDscEmp.Text = String.Empty
    End Sub

    Private Sub BtnPesqTpAgd_Click(sender As Object, e As EventArgs) Handles btnPesqTpAgd.Click
        Dim Lista As New List(Of RotuloPesquisaVO)
        Lista.Add(New RotuloPesquisaVO("CODIGO", "Código"))
        Lista.Add(New RotuloPesquisaVO("TIPO_AGENDAMENTO", "Tipo de agendamento"))

        Dim FrmPesquisa As New FrmPesquisa
        With FrmPesquisa
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TIPO_AGENDAMENTO"
            .ListaColunas = Lista
            .Tabela = "TB_TIPO_AGENDAMENTO"
        End With

        FrmPesquisa.ShowDialog()

        If Not IsNothing(FrmPesquisa.CodigoRetorno) Then
            txtCodTpAgd.Text = FrmPesquisa.CodigoRetorno.ToString()
            txtDscTpAgd.Text = FrmPesquisa.DescricaoRetorno.ToString()
        End If
    End Sub

    Private Sub BtnLimpTpAgd_Click(sender As Object, e As EventArgs) Handles btnLimpTpAgd.Click
        txtCodTpAgd.Text = String.Empty
        txtDscTpAgd.Text = String.Empty
    End Sub

    Private Sub BtnPesqTpPall_Click(sender As Object, e As EventArgs) Handles btnPesqTpPall.Click
        Dim Lista As New List(Of RotuloPesquisaVO)
        Lista.Add(New RotuloPesquisaVO("CODIGO", "Código"))
        Lista.Add(New RotuloPesquisaVO("TIPO_PALLET", "Tipo de pallet"))

        Dim FrmPesquisa As New FrmPesquisa
        With FrmPesquisa
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TIPO_PALLET"
            .ListaColunas = Lista
            .Tabela = "TB_TIPO_PALLET"
        End With

        FrmPesquisa.ShowDialog()

        If Not IsNothing(FrmPesquisa.CodigoRetorno) Then
            txtCodTpPall.Text = FrmPesquisa.CodigoRetorno.ToString()
            txtDscTpPall.Text = FrmPesquisa.DescricaoRetorno.ToString()
        End If
    End Sub

    Private Sub BtnLimpTpPall_Click(sender As Object, e As EventArgs) Handles btnLimpTpPall.Click
        txtCodTpPall.Text = String.Empty
        txtDscTpPall.Text = String.Empty
    End Sub

    Private Sub BtnPesqTpCarg_Click(sender As Object, e As EventArgs) Handles btnPesqTpCarg.Click
        Dim Lista As New List(Of RotuloPesquisaVO)
        Lista.Add(New RotuloPesquisaVO("CODIGO", "Código"))
        Lista.Add(New RotuloPesquisaVO("TIPO_CARGA", "Tipo de carga"))

        Dim FrmPesquisa As New FrmPesquisa
        With FrmPesquisa
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TIPO_CARGA"
            .ListaColunas = Lista
            .Tabela = "TB_TIPO_CARGA"
        End With

        FrmPesquisa.ShowDialog()

        If Not IsNothing(FrmPesquisa.CodigoRetorno) Then
            txtCodTpCarg.Text = FrmPesquisa.CodigoRetorno.ToString()
            txtDscTpCarg.Text = FrmPesquisa.DescricaoRetorno.ToString()
        End If
    End Sub

    Private Sub BtnLimpTpCarg_Click(sender As Object, e As EventArgs) Handles btnLimpTpCarg.Click
        txtCodTpCarg.Text = String.Empty
        txtDscTpCarg.Text = String.Empty
    End Sub

    Private Sub BtnPesqTpVeic_Click(sender As Object, e As EventArgs) Handles btnPesqTpVeic.Click
        Dim Lista As New List(Of RotuloPesquisaVO)
        Lista.Add(New RotuloPesquisaVO("CODIGO", "Código"))
        Lista.Add(New RotuloPesquisaVO("TIPO_VEICULO", "Tipo de veículo"))

        Dim FrmPesquisa As New FrmPesquisa
        With FrmPesquisa
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TIPO_VEICULO"
            .ListaColunas = Lista
            .Tabela = "TB_TIPO_VEICULO"
        End With

        FrmPesquisa.ShowDialog()

        If Not IsNothing(FrmPesquisa.CodigoRetorno) Then
            txtCodTpVeic.Text = FrmPesquisa.CodigoRetorno.ToString()
            txtDscTpVeic.Text = FrmPesquisa.DescricaoRetorno.ToString()
        End If
    End Sub

    Private Sub BtnLimpTpVeic_Click(sender As Object, e As EventArgs) Handles btnLimpTpVeic.Click
        txtCodTpVeic.Text = String.Empty
        txtDscTpVeic.Text = String.Empty
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

        If Not String.IsNullOrEmpty(txtCodTrans.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.Transportador.Codigo = txtCodTrans.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtCodEmp.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.Empresa.Codigo = txtCodEmp.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtCodTpAgd.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoAgendamento.Codigo = txtCodTpAgd.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtCodTpPall.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoPallet.Codigo = txtCodTpPall.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtCodTpCarg.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoCarga.Codigo = txtCodTpCarg.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtCodTpVeic.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.TipoVeiculo.Codigo = txtCodTpVeic.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtNumNFe.Text) Then
            lista = lista.AsEnumerable.Where(Function(F) F.NFE = txtNumNFe.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtQtdPallet.Text) Then
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
End Class