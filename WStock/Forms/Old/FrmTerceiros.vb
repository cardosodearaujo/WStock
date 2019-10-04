Imports System.Data.OleDb
Public Class FrmTerceiros

    Private listaItens As New List(Of AvaliacoesTerceirizados)

    Private Sub FrmTerceiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarComboNomeFuncionario()
        CarregarComboLiderDireto()
        CarregarComboAvaliador()
        CarregarComboPeriodo()
        CarregarComboAreaAtuacao()
        CarregarComboNota()
        CarregarComboNomeEmprea()
    End Sub

    Private Sub CarregarComboNomeFuncionario()
        Try
            Dim SQL As String = "SELECT CODIGO, NOME_FUNCIONARIO FROM TERCEIRIZADOS ORDER BY NOME_FUNCIONARIO ASC"
            Dim Conexao As New OleDbConnection()
            Conexao.ConnectionString = DadosConexaoAccess
            Conexao.Open()
            Dim Comando = New OleDbCommand(SQL, Conexao)
            Dim adapter = New OleDbDataAdapter()
            adapter.SelectCommand = Comando
            Dim tabela = New DataTable()
            adapter.Fill(tabela)

            'Novo
            Dim lista = New List(Of Generic)
            For Each item In tabela.Rows
                Dim gItem = New Generic()
                gItem.Codigo = item("CODIGO")
                gItem.Descricao = item("NOME_FUNCIONARIO")
                lista.Add(gItem)
            Next
            'Fim
            cboNomeFuncionario.DataSource = lista
            cboNomeFuncionario.ValueMember = "codigo" 'Novo
            cboNomeFuncionario.DisplayMember = "Descricao"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CarregarComboNomeEmprea()
        Try
            Dim SQL As String = "SELECT CODIGO, EMPRESA FROM EMPRESA ORDER BY EMPRESA ASC"
            Dim Conexao As New OleDbConnection()
            Conexao.ConnectionString = DadosConexaoAccess
            Conexao.Open()
            Dim Comando = New OleDbCommand(SQL, Conexao)
            Dim adapter = New OleDbDataAdapter()
            adapter.SelectCommand = Comando
            Dim tabela = New DataTable()
            adapter.Fill(tabela)

            Dim lista = (From T In tabela.AsEnumerable()
                         Select New Generic(T.Field(Of Integer)("CODIGO"), T.Field(Of String)("EMPRESA"))).ToList()

            cboNomeEmpresa.DataSource = lista
            cboNomeEmpresa.ValueMember = "Codigo" 'Novo
            cboNomeEmpresa.DisplayMember = "Descricao"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CarregarComboLiderDireto()
        Try
            Dim SQL As String = "SELECT CODIGO, LIDER_DIRETO FROM LIDER_DIRETO ORDER BY LIDER_DIRETO ASC"
            Dim Conexao As New OleDbConnection()
            Conexao.ConnectionString = DadosConexaoAccess
            Conexao.Open()
            Dim Comando = New OleDbCommand(SQL, Conexao)
            Dim adapter = New OleDbDataAdapter()
            adapter.SelectCommand = Comando
            Dim tabela = New DataTable()
            adapter.Fill(tabela)

            'Novo
            Dim lista = New List(Of Generic)
            For Each item In tabela.Rows
                Dim gItem = New Generic()
                gItem.Codigo = item("CODIGO")
                gItem.Descricao = item("LIDER_DIRETO")
                lista.Add(gItem)
            Next
            'Fim
            cboLiderDireto.DataSource = lista
            cboLiderDireto.ValueMember = "codigo" 'Novo
            cboLiderDireto.DisplayMember = "Descricao"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CarregarComboAvaliador()

        Try
            Dim SQL As String = "SELECT CODIGO, AVALIADOR FROM AVALIADOR ORDER BY AVALIADOR ASC"
            Dim Conexao As New OleDbConnection()
            Conexao.ConnectionString = DadosConexaoAccess
            Conexao.Open()
            Dim Comando = New OleDbCommand(SQL, Conexao)
            Dim adapter = New OleDbDataAdapter()
            adapter.SelectCommand = Comando
            Dim tabela = New DataTable()
            adapter.Fill(tabela)

            'Novo
            Dim lista = New List(Of Generic)
            For Each item In tabela.Rows
                Dim gItem = New Generic()
                gItem.Codigo = item("CODIGO")
                gItem.Descricao = item("AVALIADOR")
                lista.Add(gItem)
            Next
            'Fim

            cboAvaliador.DataSource = lista
            cboAvaliador.ValueMember = "codigo" 'Novo
            cboAvaliador.DisplayMember = "descricao"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CarregarComboPeriodo()
        Try
            Dim SQL As String = "SELECT CODIGO, PERIODO FROM PERIODO ORDER BY PERIODO ASC"
            Dim Conexao As New OleDbConnection()
            Conexao.ConnectionString = DadosConexaoAccess
            Conexao.Open()
            Dim Comando = New OleDbCommand(SQL, Conexao)
            Dim adapter = New OleDbDataAdapter()
            adapter.SelectCommand = Comando
            Dim tabela = New DataTable()
            adapter.Fill(tabela)

            'Novo
            Dim lista = New List(Of Generic)
            For Each item In tabela.Rows
                Dim gItem = New Generic()
                gItem.Codigo = item("CODIGO")
                gItem.Descricao = item("PERIODO")
                lista.Add(gItem)
            Next
            'Fim

            cboPeriodo.DataSource = lista
            cboPeriodo.ValueMember = "codigo" 'Novo
            cboPeriodo.DisplayMember = "Descricao"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CarregarComboAreaAtuacao()
        Try
            Dim SQL As String = "SELECT CODIGO, AREA_ATUACAO FROM AREA_ATUACAO ORDER BY AREA_ATUACAO ASC"
            Dim Conexao As New OleDbConnection()
            Conexao.ConnectionString = DadosConexaoAccess
            Conexao.Open()
            Dim Comando = New OleDbCommand(SQL, Conexao)
            Dim adapter = New OleDbDataAdapter()
            adapter.SelectCommand = Comando
            Dim tabela = New DataTable()
            adapter.Fill(tabela)

            'Novo
            Dim lista = New List(Of Generic)
            For Each item In tabela.Rows
                Dim gItem = New Generic()
                gItem.Codigo = item("CODIGO")
                gItem.Descricao = item("AREA_ATUACAO")
                lista.Add(gItem)
            Next
            'Fim

            cboAreaAtuacao.DataSource = lista
            cboAreaAtuacao.ValueMember = "codigo" 'Novo
            cboAreaAtuacao.DisplayMember = "Descricao"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CarregarComboNota()
        Try
            Dim SQL As String = "SELECT CODIGO, NOTA & ' - ' & ' ( ' & CONCEITO & ' ) ' AS NOTA FROM NOTA_AVALIACAO ORDER BY NOTA ASC"
            Dim Conexao As New OleDbConnection()
            Conexao.ConnectionString = DadosConexaoAccess
            Conexao.Open()
            Dim Comando = New OleDbCommand(SQL, Conexao)
            Dim adapter = New OleDbDataAdapter()
            adapter.SelectCommand = Comando
            Dim tabela = New DataTable()
            adapter.Fill(tabela)

            'Novo
            Dim lista = New List(Of Generic)
            For Each item In tabela.Rows
                Dim gItem = New Generic()
                gItem.Codigo = item("CODIGO")
                cboNota.ValueMember = "CODIGO" 'Novo
                gItem.Descricao = item("NOTA")
                lista.Add(gItem)
            Next
            'Fim

            cboNota.DataSource = lista
            cboNota.ValueMember = "codigo" 'Novo
            cboNota.DisplayMember = "Descricao"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnSalvarT_Click(sender As Object, e As EventArgs) Handles btnSalvarT.Click

        'Salvar dados no bamc
        Try
            If cboNomeFuncionario.SelectedIndex < 0 Then
                MessageBox.Show("Selecione o funcionário", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboNomeFuncionario.Focus()
                Exit Sub
            End If

            If IsNothing(cboNota.SelectedItem) Then
                MessageBox.Show("Informe a nota", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboNota.Focus()
                Exit Sub
            End If

            If dtpDataAvaliacao.Value.Date < Now.Date Then
                MessageBox.Show("Não é possível a inclusão de data retroativa", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dtpDataAvaliacao.Focus()
                Exit Sub
            End If

            If cboLiderDireto.SelectedIndex < 0 Then
                MessageBox.Show("Selecione um lider direto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboLiderDireto.Focus()
                Exit Sub
            End If

            If cboAvaliador.SelectedIndex < 0 Then
                MessageBox.Show("Selecione um avaliador", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboAvaliador.Focus()
                Exit Sub
            End If

            Dim Item As New AvaliacoesTerceirizados
            Item.Codigo = IIf(String.IsNullOrEmpty(txtCodigo.Text), 0, txtCodigo.Text)
            Item.NomeFuncionario = cboNomeFuncionario.SelectedItem().Codigo
            Item.Empresa = cboNomeEmpresa.SelectedItem().Codigo
            Item.LiderDireto = cboLiderDireto.SelectedItem().Codigo
            Item.Avaliador = cboAvaliador.SelectedItem().Codigo
            Item.Periodo = cboPeriodo.SelectedItem().Codigo
            Item.AreaAtuacao = cboAreaAtuacao.SelectedItem().Codigo
            Item.PontosFortes = txtPontosFortes.Text
            Item.PontosFracos = txtPontosFracos.Text
            Item.Nota = cboNota.SelectedItem().Codigo
            Item.DataAvaliacao = dtpDataAvaliacao.Value
            listaItens.Add(Item)

            AbrirConexao()

            Dim SQL As String
            If Item.Codigo > 0 Then 'Update
                SQL = "Update AVALIACOES_TERCEIRIZADOS set
                        ,NOME_FUNCIONARIO = @NOME_FUNCIONARIO
                        ,EMPRESA = @EMPRESA
                        ,LIDER_DIRETO = @LIDER_DIRETO
                        ,AVALIADOR = @AVALIADOR
                        ,PERIODO = @PERIODO
                        ,AREA_ATUACAO = @AREA_ATUACAO
                        ,PONTOS_FORTES = @PONTOS_FORTES
                        ,PONTOS_FRACOS = @PONTOS_FRACOS
                        ,ID_NOTA = @ID_NOTA
                        Where Codigo =" & Item.Codigo
            Else 'Inserir
                SQL = "INSERT INTO AVALIACOES_TERCEIRIZADOS(
                         NOME_FUNCIONARIO 
                        ,EMPRESA 
                        ,LIDER_DIRETO 
                        ,AVALIADOR 
                        ,PERIODO 
                        ,AREA_ATUACAO 
                        ,PONTOS_FORTES 
                        ,PONTOS_FRACOS 
                        ,ID_NOTA )
                     Values(
                          @NOME_FUNCIONARIO,
                          @EMPRESA,
                          @LIDER_DIRETO,
                          @AVALIADOR,
                          @PERIODO,
                          @AREA_ATUACAO,
                          @PONTOS_FORTES,
                          @PONTOS_FRACOS,
                          @ID_NOTA)"
            End If

            Comando = New OleDbCommand()
            Comando.Parameters.AddWithValue("@NOME_FUNCIONARIO", SqlDbType.NVarChar).Value = Item.NomeFuncionario
            Comando.Parameters.AddWithValue("@EMPRESA", SqlDbType.NVarChar).Value = Item.Empresa
            Comando.Parameters.AddWithValue("@LIDER_DIRETO", SqlDbType.NVarChar).Value = Item.LiderDireto
            Comando.Parameters.AddWithValue("@AVALIADOR", SqlDbType.NVarChar).Value = Item.Avaliador
            Comando.Parameters.AddWithValue("@PERIODO", SqlDbType.NVarChar).Value = Item.Periodo
            Comando.Parameters.AddWithValue("@AREA_ATUACAO", SqlDbType.NVarChar).Value = Item.AreaAtuacao
            Comando.Parameters.AddWithValue("@PONTOS_FORTES", SqlDbType.NVarChar).Value = Item.PontosFortes
            Comando.Parameters.AddWithValue("@PONTOS_FRACOS", SqlDbType.NVarChar).Value = Item.PontosFortes
            Comando.Parameters.AddWithValue("@ID_NOTA", SqlDbType.NVarChar).Value = Item.Nota


            Comando.CommandText = SQL.ToString()
            Comando.Connection = Conexao
            Comando.ExecuteNonQuery()

            If Item.Codigo <= 0 Then
                Comando.CommandText = "Select @@IDENTITY"
                txtCodigo.Text = Comando.ExecuteScalar
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LimparCampos()

        cboNomeFuncionario.SelectedIndex = -1
        cboNomeEmpresa.SelectedIndex = -1
        cboLiderDireto.SelectedIndex = -1
        cboAvaliador.SelectedIndex = -1
        cboPeriodo.SelectedIndex = -1
        cboAreaAtuacao.SelectedIndex = -1
        txtPontosFortes.Clear()
        txtPontosFracos.Clear()
        cboNota.SelectedIndex = -1
    End Sub
    Private Const DadosConexaoAccess As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\WStock\WStock.mdb"
    Private Conexao As New OleDbConnection()
    Private Comando As New OleDbCommand()
    Private Sub AbrirConexao()
        Conexao = New OleDbConnection()
        Conexao.ConnectionString = DadosConexaoAccess
        Conexao.Open()
    End Sub

    Private Class AvaliacoesTerceirizados
        Private _NomeFuncionario As String
        Public Property NomeFuncionario() As String
            Get
                Return _NomeFuncionario
            End Get
            Set(ByVal value As String)
                _NomeFuncionario = value
            End Set
        End Property
        Private _Codigo As String
        Public Property Codigo() As String
            Get
                Return _Codigo
            End Get
            Set(ByVal value As String)
                _Codigo = value
            End Set
        End Property

        Private _Empresa As String
        Public Property Empresa() As String
            Get
                Return _Empresa
            End Get
            Set(ByVal value As String)
                _Empresa = value
            End Set
        End Property

        Private _LiderDireto As String
        Public Property LiderDireto() As String
            Get
                Return _LiderDireto
            End Get
            Set(ByVal value As String)
                _LiderDireto = value
            End Set
        End Property

        Private _Avaliador As String
        Public Property Avaliador() As String
            Get
                Return _Avaliador
            End Get
            Set(ByVal value As String)

                _Avaliador = value
            End Set
        End Property

        Private _Periodo As String
        Public Property Periodo() As String
            Get
                Return _Periodo
            End Get
            Set(ByVal value As String)
                _Periodo = value
            End Set
        End Property

        Private _AreaAtuacao As String
        Public Property AreaAtuacao() As String
            Get
                Return _AreaAtuacao
            End Get
            Set(ByVal value As String)
                _AreaAtuacao = value
            End Set
        End Property

        Private _PontosFortes As String
        Public Property PontosFortes() As String
            Get
                Return _PontosFortes
            End Get
            Set(ByVal value As String)
                _PontosFortes = value
            End Set
        End Property

        Private _PontosFracos As String
        Public Property PontosFracos() As String
            Get
                Return _PontosFracos
            End Get
            Set(ByVal value As String)
                _PontosFracos = value
            End Set
        End Property

        Private _Nota As String
        Public Property Nota() As String
            Get
                Return _Nota
            End Get
            Set(ByVal value As String)
                _Nota = value
            End Set
        End Property

        Private _Conceito As String
        Public Property Conceito() As String
            Get
                Return _Conceito
            End Get
            Set(ByVal value As String)
                _Conceito = value
            End Set
        End Property

        Private _DataAvaliacao As String
        Public Property DataAvaliacao() As String
            Get
                Return _DataAvaliacao
            End Get
            Set(ByVal value As String)
                _DataAvaliacao = value
            End Set
        End Property
    End Class
    Private Class Generic

        Public Sub New()

        End Sub

        Public Sub New(Codigo As Integer, Descricao As String)
            Me.Codigo = Codigo
            Me.Descricao = Descricao
        End Sub

        Private _Codigo As Integer
        Public Property Codigo() As Integer
            Get
                Return _Codigo
            End Get
            Set(ByVal value As Integer)
                _Codigo = value
            End Set
        End Property
        Private _Descricao As String
        Public Property Descricao() As String
            Get
                Return _Descricao
            End Get
            Set(ByVal value As String)
                _Descricao = value
            End Set
        End Property
    End Class

End Class


