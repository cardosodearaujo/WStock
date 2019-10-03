Imports System.Data.OleDb

Public Class FrmSolicitacaoCompra
    Private Const DadosConexaoAccess As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\WStock\WStock.mdb"
    Private listaItens As New List(Of SolicitacaoCompraItem)

    Private Sub FrmSolicitacaoCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        CarregarComboSKU()
        CarregarComboFornecedor()
    End Sub

    Private Sub CarregarComboSKU()
        Try
            Dim SQL As String = "SELECT CODIGO, SKU & ' - ' & DESCRICAO AS SKU, LEADTIME FROM SKU ORDER BY SKU ASC"
            Dim Conexao As New OleDbConnection()
            Conexao.ConnectionString = DadosConexaoAccess
            Conexao.Open()
            Dim Comando = New OleDbCommand(SQL, Conexao)
            Dim adapter = New OleDbDataAdapter()
            adapter.SelectCommand = Comando
            Dim tabela = New DataTable()
            adapter.Fill(tabela)

            cboSKU.DataSource = tabela
            cboSKU.DisplayMember = "SKU"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CarregarComboFornecedor()
        Try
            Dim SQL As String = "SELECT CODIGO, FORNECEDOR FROM FORNECEDOR ORDER BY FORNECEDOR ASC"
            Dim Conexao As New OleDbConnection()
            Conexao.ConnectionString = DadosConexaoAccess
            Conexao.Open()
            Dim Comando = New OleDbCommand(SQL, Conexao)
            Dim adapter = New OleDbDataAdapter()
            adapter.SelectCommand = Comando
            Dim tabela = New DataTable()
            adapter.Fill(tabela)

            cboFornecedor.DataSource = tabela
            cboFornecedor.DisplayMember = "FORNECEDOR"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboSKU_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSKU.SelectedIndexChanged
        Try
            Dim item As Object = cboSKU.SelectedItem
            If (Not IsNothing(item) AndAlso Not IsNothing(item("LEADTIME"))) Then
                Dim leadTime As Integer = item("LEADTIME")
                dtpEntrega.Value = Now().AddDays(leadTime)
            Else
                dtpEntrega.Value = Now()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try
            If cboSKU.SelectedIndex < 0 Then
                MessageBox.Show("Selecione o SKU", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboSKU.Focus()
                Exit Sub
            End If

            If String.IsNullOrEmpty(txtQuantidade.Text) OrElse Not IsNumeric(txtQuantidade.Text) OrElse Integer.Parse(txtQuantidade.Text) <= 0 Then
                MessageBox.Show("Informe a quantidade", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtQuantidade.Focus()
                Exit Sub
            End If

            If dtpEntrega.Value < Now Then
                MessageBox.Show("Não é possível a inclusão de data retroativa", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dtpEntrega.Focus()
                Exit Sub
            End If

            If cboStatusItem.SelectedIndex < 0 Then
                MessageBox.Show("Selecione um status", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboStatusItem.Focus()
                Exit Sub
            End If

            If cboFornecedor.SelectedIndex < 0 Then
                MessageBox.Show("Selecione um fornecedor", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboFornecedor.Focus()
                Exit Sub
            End If

            Dim Item As New SolicitacaoCompraItem

            Item.SKU = cboSKU.SelectedItem("CODIGO")
            Item.DescricaoSKU = cboSKU.SelectedItem("SKU")
            Item.Quantidade = txtQuantidade.Text
            Item.DataEntrega = dtpEntrega.Value
            Item.StatusItem = cboStatusItem.SelectedItem.ToString
            Item.Fornecedor = cboFornecedor.SelectedItem("CODIGO")
            Item.FornecedorDescricao = cboFornecedor.SelectedItem("FORNECEDOR")
            Item.NumeroPedido = txtNumeroPedido.Text
            listaItens.Add(Item)

            dgvItens.DataSource = Nothing
            dgvItens.DataSource = listaItens
            ConfigurarGrid()
            LimparItemGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarGrid()
        If dgvItens.Rows.Count <= 0 Then dgvItens.DataSource = New List(Of SolicitacaoCompraItem)

        dgvItens.Columns("SKU").HeaderText = "SKU"
        dgvItens.Columns("DescricaoSKU").HeaderText = "SKU"
        dgvItens.Columns("Quantidade").HeaderText = "Quantidade"
        dgvItens.Columns("DataEntrega").HeaderText = "Data entrega"
        dgvItens.Columns("StatusItem").HeaderText = "Status item"
        dgvItens.Columns("Fornecedor").HeaderText = "Fornecedor"
        dgvItens.Columns("FornecedorDescricao").HeaderText = "Fornecedor"
        dgvItens.Columns("NumeroPedido").HeaderText = "Número do pedido"

        dgvItens.Columns("SKU").Visible = False
        dgvItens.Columns("Fornecedor").Visible = False

        dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LimparItemGrid()
        cboSKU.SelectedIndex = -1
        txtQuantidade.Clear()
        dtpEntrega.Value = Now
        cboStatusItem.SelectedIndex = -1
        cboFornecedor.SelectedIndex = -1
        txtNumeroPedido.Clear()
    End Sub

    Private Class SolicitacaoCompraItem
        Private _SKU As String
        Public Property SKU() As String
            Get
                Return _SKU
            End Get
            Set(ByVal value As String)
                _SKU = value
            End Set
        End Property

        Private _DescricaoSKU As String
        Public Property DescricaoSKU() As String
            Get
                Return _DescricaoSKU
            End Get
            Set(ByVal value As String)
                _DescricaoSKU = value
            End Set
        End Property

        Private _Quantidade As String
        Public Property Quantidade() As String
            Get
                Return _Quantidade
            End Get
            Set(ByVal value As String)
                _Quantidade = value
            End Set
        End Property

        Private _DataEntrega As Date
        Public Property DataEntrega() As Date
            Get
                Return _DataEntrega
            End Get
            Set(ByVal value As Date)

                _DataEntrega = value
            End Set
        End Property

        Private _StatusItem As String
        Public Property StatusItem() As String
            Get
                Return _StatusItem
            End Get
            Set(ByVal value As String)
                _StatusItem = value
            End Set
        End Property

        Private _Fornecedor As String
        Public Property Fornecedor() As String
            Get
                Return _Fornecedor
            End Get
            Set(ByVal value As String)
                _Fornecedor = value
            End Set
        End Property

        Private _FornecedorDescricao As String
        Public Property FornecedorDescricao() As String
            Get
                Return _FornecedorDescricao
            End Get
            Set(ByVal value As String)
                _FornecedorDescricao = value
            End Set
        End Property

        Private _NumeroPedido As String
        Public Property NumeroPedido() As String
            Get
                Return _NumeroPedido
            End Get
            Set(ByVal value As String)
                _NumeroPedido = value
            End Set
        End Property
    End Class
End Class



