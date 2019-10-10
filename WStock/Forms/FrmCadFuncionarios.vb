Imports WStock.Domain
Imports WStock.Framework.DepedencyInjection
Imports WStock.Framework.Extensions

Public Class FrmCadFuncionarios
    Private Sub FrmCadFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Configurar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        Try
            ConfigurarPesquisa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Salvar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Salvar()
        Dim service As New FuncionarioService()
        service.Save(ObterDados())
        If service.Messages.HasErrors() Then
            MessageBox.Show(service.Messages.ToString(),
                            "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimparCampos()
        End If
    End Sub

    Private Function ObterDados() As Funcionario
        Dim Funcionario As New Funcionario
        With Funcionario
            If String.IsNullOrEmpty(txtCodigo.Text) Then .Codigo = Nothing Else .Codigo = txtCodigo.Text
            .NomeFuncionario = txtNome.Text
            .TerminoContrato = dtpTerminoContrato.Value
            .Telefone = txtTelefone.Text
            .BancoHoras = IIf(IsNumeric(txtBancoHoras.Text), txtBancoHoras.Text, 0)
            .Empresa = New Empresa
            .Empresa.Codigo = nswEmpresa.Codigo
            .Empresa.Empresa = nswEmpresa.Descricao
            .Turno = New Turno
            .Turno.Codigo = nswTurno.Codigo
            .Turno.Turno = nswTurno.Descricao
            .Situacao = New Situacao
            .Situacao.Codigo = nswSituacao.Codigo
            .Situacao.Situacao = nswSituacao.Descricao
            .Area = New Area
            .Area.Codigo = nswArea.Codigo
            .Area.Area = nswArea.Descricao
        End With
        Return Funcionario
    End Function

    Private Sub LimparCampos()
        txtCodigo.Clear()
        txtNome.Clear()
        nswEmpresa.Clear()
        nswTurno.Clear()
        nswSituacao.Clear()
        nswArea.Clear()
        txtTelefone.Clear()
        txtBancoHoras.Clear()
        dtpTerminoContrato.Value = Date.Now
    End Sub

    Private Sub ConfigurarPesquisa()
        Dim Pesquisa As New FrmPesquisa
        With Pesquisa
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "NOME_FUNCIONARIO"
            .ListaColunas = New List(Of RotuloPesquisaVO)
            .ListaColunas.Add(New RotuloPesquisaVO("CODIGO", "Código"))
            .ListaColunas.Add(New RotuloPesquisaVO("NOME_FUNCIONARIO", "Nome"))
            .ListaColunas.Add(New RotuloPesquisaVO("TELEFONE", "Telefone"))
            .ListaColunas.Add(New RotuloPesquisaVO("TERMINO_CONTRATO", "Dt. terminio contrato"))
            .ListaColunas.Add(New RotuloPesquisaVO("BANCO_HORAS", "Banco de horas"))
            .Tabela = "TB_FUNCIONARIO"
            .OrderBy = "NOME_FUNCIONARIO"
            .ShowDialog()
            Carregar(.CodigoRetorno)
        End With
    End Sub

    Private Sub Carregar(Codigo As Integer)
        If Not IsNothing(Codigo) Then
            Dim Funcionario = DependencyInjectionFactory _
                    .CreateInstance(Of IFuncionarioRepository) _
                    .SelectById(Codigo)

            If Not IsNothing(Funcionario) AndAlso Funcionario.Codigo > 0 Then
                txtCodigo.Text = Funcionario.Codigo
                txtNome.Text = Funcionario.NomeFuncionario
                nswEmpresa.Codigo = Funcionario.Empresa.Codigo
                nswEmpresa.Descricao = Funcionario.Empresa.Empresa
                nswTurno.Codigo = Funcionario.Turno.Codigo
                nswTurno.Descricao = Funcionario.Turno.Turno
                nswSituacao.Codigo = Funcionario.Situacao.Codigo
                nswSituacao.Descricao = Funcionario.Situacao.Situacao
                nswArea.Codigo = Funcionario.Area.Codigo
                nswArea.Descricao = Funcionario.Area.Area
                txtTelefone.Text = Funcionario.Telefone
                txtBancoHoras.Text = Funcionario.BancoHoras
                dtpTerminoContrato.Value = Funcionario.TerminoContrato
            End If
        End If
    End Sub

    Private Sub Configurar()
        ConfigEmpresa()
        ConfigTurno()
        ConfigSituacao()
        ConfigArea()
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

    Private Sub ConfigTurno()
        With nswTurno
            .Titulo = "Turno"
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "TURNO"
            .ListaColunas = New List(Of RotuloPesquisaVO)
            .ListaColunas.Add(New RotuloPesquisaVO("CODIGO", "Código"))
            .ListaColunas.Add(New RotuloPesquisaVO("TURNO", "Turno"))
            .Tabela = "TB_TURNO"
        End With
    End Sub

    Private Sub ConfigSituacao()
        With nswSituacao
            .Titulo = "Situação"
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "SITUACAO"
            .ListaColunas = New List(Of RotuloPesquisaVO)
            .ListaColunas.Add(New RotuloPesquisaVO("CODIGO", "Código"))
            .ListaColunas.Add(New RotuloPesquisaVO("SITUACAO", "Situação"))
            .Tabela = "TB_SITUACAO"
        End With
    End Sub

    Private Sub ConfigArea()
        With nswArea
            .Titulo = "Área"
            .CampoCodigoTabelaRetono = "CODIGO"
            .CampoDescricaoTabelaRetono = "AREA"
            .ListaColunas = New List(Of RotuloPesquisaVO)
            .ListaColunas.Add(New RotuloPesquisaVO("CODIGO", "Código"))
            .ListaColunas.Add(New RotuloPesquisaVO("AREA", "Área"))
            .Tabela = "TB_AREA"
        End With
    End Sub
End Class