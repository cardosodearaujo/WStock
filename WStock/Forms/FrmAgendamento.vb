Imports WStock.Domain
Imports WStock.Framework.DepedencyInjection

Public Class FrmAgendamento
    Private Sub FrmAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Configurar()
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