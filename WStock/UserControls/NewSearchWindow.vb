Imports WStock.Domain

Public Class NewSearchWindow
    Inherits UserControl

    Private _Titulo As String
    Public Property Titulo() As String
        Get
            Return _Titulo
        End Get
        Set(ByVal value As String)
            _Titulo = value
            lblTitulo.Text = _Titulo
        End Set
    End Property

    Private _Codigo As String
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
            txtCodigo.Text = Codigo
        End Set
    End Property

    Private _Descricao As String
    Public Property Descricao() As String
        Get
            Return _Descricao
        End Get
        Set(ByVal value As String)
            _Descricao = value
            txtDescricao.Text = _Descricao
        End Set
    End Property
    Public Property CampoCodigoTabelaRetono As String
    Public Property CampoDescricaoTabelaRetono As String
    Public Property ListaColunas As List(Of RotuloPesquisaVO)
    Public Property Tabela As String
    Public Property Where As String
    Public Property OrderBy As String

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim FrmPesquisa As New FrmPesquisa
        With FrmPesquisa
            .CampoCodigoTabelaRetono = CampoCodigoTabelaRetono
            .CampoDescricaoTabelaRetono = CampoDescricaoTabelaRetono
            .ListaColunas = ListaColunas
            .Tabela = Tabela
            If Not String.IsNullOrEmpty(Where) Then .Where = Where

            .ShowDialog()

            If Not IsNothing(.CodigoRetorno) Then
                txtCodigo.Text = .CodigoRetorno.ToString()
                txtDescricao.Text = .DescricaoRetorno.ToString()
                _Codigo = .CodigoRetorno.ToString()
                _Descricao = .DescricaoRetorno.ToString()
            End If
        End With
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Clear()
    End Sub

    Public Sub Clear()
        txtCodigo.Text = String.Empty
        txtDescricao.Text = String.Empty
        _Codigo = String.Empty
        _Descricao = String.Empty
    End Sub
End Class
