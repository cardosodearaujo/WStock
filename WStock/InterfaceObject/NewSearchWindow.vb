Imports WStock.Domain

Public Class NewSearchWindow
    Inherits UserControl

    Private _CodigoRetorno As String
    Public ReadOnly Property CodigoRetorno() As String
        Get
            Return _CodigoRetorno
        End Get
    End Property

    Private _DescricaoRetorno As String
    Public ReadOnly Property DescricaoRetorno() As String
        Get
            Return _DescricaoRetorno
        End Get
    End Property

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
            If Not String.IsNullOrEmpty(OrderBy) Then .OrderBy = OrderBy

            .ShowDialog()

            If Not IsNothing(.CodigoRetorno) Then
                txtCodigo.Text = .CodigoRetorno.ToString()
                txtDescricao.Text = .DescricaoRetorno.ToString()
                _CodigoRetorno = .CodigoRetorno.ToString()
                _DescricaoRetorno = .DescricaoRetorno.ToString()
            End If
        End With
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtCodigo.Text = String.Empty
        txtDescricao.Text = String.Empty
        _CodigoRetorno = String.Empty
        _DescricaoRetorno = String.Empty
    End Sub
End Class
