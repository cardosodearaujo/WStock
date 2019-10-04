<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaAgendamentos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnlFiltro = New System.Windows.Forms.Panel()
        Me.nswTransportador = New WStock.NewSearchWindow()
        Me.nswEmpresa = New WStock.NewSearchWindow()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.chkOcultarCancelados = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpAgendaAte = New System.Windows.Forms.DateTimePicker()
        Me.dtpAgendaDe = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOrigem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtdPallet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeMotorista = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumNFe = New System.Windows.Forms.TextBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.dgvAgendamentos = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO_TRANSPORTADORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSPORTADOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO_TIPO_AGENDAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_AGENDAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO_TIPO_PALLET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_PALLET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO_TIPO_CARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_CARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO_TIPO_VEICULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_VEICULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NFE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOME_MOTORISTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORIGEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTIDADE_PALLET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA_AGENDAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA_CANCELAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nswTipoAgendamento = New WStock.NewSearchWindow()
        Me.nswTipoPallet = New WStock.NewSearchWindow()
        Me.nswTipoCarga = New WStock.NewSearchWindow()
        Me.nswTipoVeiculo = New WStock.NewSearchWindow()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlFiltro.SuspendLayout()
        CType(Me.dgvAgendamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlFiltro)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Panel1MinSize = 10
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvAgendamentos)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(1112, 525)
        Me.SplitContainer1.SplitterDistance = 127
        Me.SplitContainer1.TabIndex = 0
        '
        'pnlFiltro
        '
        Me.pnlFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlFiltro.Controls.Add(Me.nswTipoVeiculo)
        Me.pnlFiltro.Controls.Add(Me.nswTipoCarga)
        Me.pnlFiltro.Controls.Add(Me.nswTipoPallet)
        Me.pnlFiltro.Controls.Add(Me.nswTipoAgendamento)
        Me.pnlFiltro.Controls.Add(Me.nswTransportador)
        Me.pnlFiltro.Controls.Add(Me.nswEmpresa)
        Me.pnlFiltro.Controls.Add(Me.btnNovo)
        Me.pnlFiltro.Controls.Add(Me.chkOcultarCancelados)
        Me.pnlFiltro.Controls.Add(Me.Label8)
        Me.pnlFiltro.Controls.Add(Me.Label7)
        Me.pnlFiltro.Controls.Add(Me.dtpAgendaAte)
        Me.pnlFiltro.Controls.Add(Me.dtpAgendaDe)
        Me.pnlFiltro.Controls.Add(Me.Label6)
        Me.pnlFiltro.Controls.Add(Me.txtDestino)
        Me.pnlFiltro.Controls.Add(Me.Label5)
        Me.pnlFiltro.Controls.Add(Me.txtOrigem)
        Me.pnlFiltro.Controls.Add(Me.Label4)
        Me.pnlFiltro.Controls.Add(Me.txtQtdPallet)
        Me.pnlFiltro.Controls.Add(Me.Label3)
        Me.pnlFiltro.Controls.Add(Me.txtObservacao)
        Me.pnlFiltro.Controls.Add(Me.Label2)
        Me.pnlFiltro.Controls.Add(Me.txtNomeMotorista)
        Me.pnlFiltro.Controls.Add(Me.Label1)
        Me.pnlFiltro.Controls.Add(Me.txtNumNFe)
        Me.pnlFiltro.Controls.Add(Me.btnPesquisar)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFiltro.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(1112, 127)
        Me.pnlFiltro.TabIndex = 0
        '
        'nswTransportador
        '
        Me.nswTransportador.CampoCodigoTabelaRetono = Nothing
        Me.nswTransportador.CampoDescricaoTabelaRetono = Nothing
        Me.nswTransportador.ListaColunas = Nothing
        Me.nswTransportador.Location = New System.Drawing.Point(3, 4)
        Me.nswTransportador.Name = "nswTransportador"
        Me.nswTransportador.OrderBy = Nothing
        Me.nswTransportador.Size = New System.Drawing.Size(332, 41)
        Me.nswTransportador.Tabela = Nothing
        Me.nswTransportador.TabIndex = 30
        Me.nswTransportador.Titulo = "Transportador"
        Me.nswTransportador.Where = Nothing
        '
        'nswEmpresa
        '
        Me.nswEmpresa.CampoCodigoTabelaRetono = ""
        Me.nswEmpresa.CampoDescricaoTabelaRetono = ""
        Me.nswEmpresa.ListaColunas = Nothing
        Me.nswEmpresa.Location = New System.Drawing.Point(3, 44)
        Me.nswEmpresa.Name = "nswEmpresa"
        Me.nswEmpresa.OrderBy = Nothing
        Me.nswEmpresa.Size = New System.Drawing.Size(332, 41)
        Me.nswEmpresa.Tabela = ""
        Me.nswEmpresa.TabIndex = 29
        Me.nswEmpresa.Titulo = "Empresa"
        Me.nswEmpresa.Where = Nothing
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNovo.Image = Global.WStock.My.Resources.Resources._new
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(919, 103)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(90, 23)
        Me.btnNovo.TabIndex = 28
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'chkOcultarCancelados
        '
        Me.chkOcultarCancelados.AutoSize = True
        Me.chkOcultarCancelados.Checked = True
        Me.chkOcultarCancelados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOcultarCancelados.Location = New System.Drawing.Point(804, 85)
        Me.chkOcultarCancelados.Name = "chkOcultarCancelados"
        Me.chkOcultarCancelados.Size = New System.Drawing.Size(118, 17)
        Me.chkOcultarCancelados.TabIndex = 27
        Me.chkOcultarCancelados.Text = "Ocultar cancelados"
        Me.chkOcultarCancelados.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(779, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Até"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(674, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Agendamento:"
        '
        'dtpAgendaAte
        '
        Me.dtpAgendaAte.CustomFormat = "dd/MM/yyyy"
        Me.dtpAgendaAte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAgendaAte.Location = New System.Drawing.Point(804, 103)
        Me.dtpAgendaAte.Name = "dtpAgendaAte"
        Me.dtpAgendaAte.Size = New System.Drawing.Size(106, 20)
        Me.dtpAgendaAte.TabIndex = 24
        '
        'dtpAgendaDe
        '
        Me.dtpAgendaDe.CustomFormat = "dd/MM/yyyy"
        Me.dtpAgendaDe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAgendaDe.Location = New System.Drawing.Point(671, 103)
        Me.dtpAgendaDe.Name = "dtpAgendaDe"
        Me.dtpAgendaDe.Size = New System.Drawing.Size(106, 20)
        Me.dtpAgendaDe.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1001, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Destino:"
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(998, 22)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(106, 20)
        Me.txtDestino.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(892, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Origem:"
        '
        'txtOrigem
        '
        Me.txtOrigem.Location = New System.Drawing.Point(889, 22)
        Me.txtOrigem.Name = "txtOrigem"
        Me.txtOrigem.Size = New System.Drawing.Size(106, 20)
        Me.txtOrigem.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(783, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Qtd. Pallet:"
        '
        'txtQtdPallet
        '
        Me.txtQtdPallet.Location = New System.Drawing.Point(780, 22)
        Me.txtQtdPallet.Name = "txtQtdPallet"
        Me.txtQtdPallet.Size = New System.Drawing.Size(106, 20)
        Me.txtQtdPallet.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(892, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(889, 61)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(215, 20)
        Me.txtObservacao.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(674, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nome do motorista:"
        '
        'txtNomeMotorista
        '
        Me.txtNomeMotorista.Location = New System.Drawing.Point(671, 61)
        Me.txtNomeMotorista.Name = "txtNomeMotorista"
        Me.txtNomeMotorista.Size = New System.Drawing.Size(215, 20)
        Me.txtNomeMotorista.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(674, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Número NF-e:"
        '
        'txtNumNFe
        '
        Me.txtNumNFe.Location = New System.Drawing.Point(671, 22)
        Me.txtNumNFe.Name = "txtNumNFe"
        Me.txtNumNFe.Size = New System.Drawing.Size(106, 20)
        Me.txtNumNFe.TabIndex = 12
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPesquisar.BackColor = System.Drawing.SystemColors.Control
        Me.btnPesquisar.Image = Global.WStock.My.Resources.Resources.search1
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.Location = New System.Drawing.Point(1015, 103)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(90, 23)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'dgvAgendamentos
        '
        Me.dgvAgendamentos.AllowUserToAddRows = False
        Me.dgvAgendamentos.AllowUserToDeleteRows = False
        Me.dgvAgendamentos.AllowUserToResizeColumns = False
        Me.dgvAgendamentos.AllowUserToResizeRows = False
        Me.dgvAgendamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAgendamentos.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAgendamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.CODIGO_TRANSPORTADORA, Me.TRANSPORTADOR, Me.CODIGO_EMPRESA, Me.EMPRESA, Me.CODIGO_TIPO_AGENDAMENTO, Me.TIPO_AGENDAMENTO, Me.CODIGO_TIPO_PALLET, Me.TIPO_PALLET, Me.CODIGO_TIPO_CARGA, Me.TIPO_CARGA, Me.CODIGO_TIPO_VEICULO, Me.TIPO_VEICULO, Me.NFE, Me.NOME_MOTORISTA, Me.OBSERVACAO, Me.ORIGEM, Me.DESTINO, Me.QUANTIDADE_PALLET, Me.DATA_AGENDAMENTO, Me.DATA_CANCELAMENTO})
        Me.dgvAgendamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAgendamentos.Location = New System.Drawing.Point(0, 0)
        Me.dgvAgendamentos.MultiSelect = False
        Me.dgvAgendamentos.Name = "dgvAgendamentos"
        Me.dgvAgendamentos.ReadOnly = True
        Me.dgvAgendamentos.RowHeadersVisible = False
        Me.dgvAgendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAgendamentos.Size = New System.Drawing.Size(1112, 394)
        Me.dgvAgendamentos.TabIndex = 25
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "Codigo"
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'CODIGO_TRANSPORTADORA
        '
        Me.CODIGO_TRANSPORTADORA.DataPropertyName = "CodigoTransportadora"
        Me.CODIGO_TRANSPORTADORA.HeaderText = "CODIGO_TRANSPORTADORA"
        Me.CODIGO_TRANSPORTADORA.Name = "CODIGO_TRANSPORTADORA"
        Me.CODIGO_TRANSPORTADORA.ReadOnly = True
        Me.CODIGO_TRANSPORTADORA.Visible = False
        '
        'TRANSPORTADOR
        '
        Me.TRANSPORTADOR.DataPropertyName = "Transportadora"
        Me.TRANSPORTADOR.HeaderText = "TRANSPORTADOR"
        Me.TRANSPORTADOR.Name = "TRANSPORTADOR"
        Me.TRANSPORTADOR.ReadOnly = True
        '
        'CODIGO_EMPRESA
        '
        Me.CODIGO_EMPRESA.DataPropertyName = "CodigoEmpresa"
        Me.CODIGO_EMPRESA.HeaderText = "CODIGO_EMPRESA"
        Me.CODIGO_EMPRESA.Name = "CODIGO_EMPRESA"
        Me.CODIGO_EMPRESA.ReadOnly = True
        Me.CODIGO_EMPRESA.Visible = False
        '
        'EMPRESA
        '
        Me.EMPRESA.DataPropertyName = "Empresa"
        Me.EMPRESA.HeaderText = "EMPRESA"
        Me.EMPRESA.Name = "EMPRESA"
        Me.EMPRESA.ReadOnly = True
        '
        'CODIGO_TIPO_AGENDAMENTO
        '
        Me.CODIGO_TIPO_AGENDAMENTO.DataPropertyName = "CodigoTipoAgendamento"
        Me.CODIGO_TIPO_AGENDAMENTO.HeaderText = "CODIGO_TIPO_AGENDAMENTO"
        Me.CODIGO_TIPO_AGENDAMENTO.Name = "CODIGO_TIPO_AGENDAMENTO"
        Me.CODIGO_TIPO_AGENDAMENTO.ReadOnly = True
        Me.CODIGO_TIPO_AGENDAMENTO.Visible = False
        '
        'TIPO_AGENDAMENTO
        '
        Me.TIPO_AGENDAMENTO.DataPropertyName = "TipoAgendamento"
        Me.TIPO_AGENDAMENTO.HeaderText = "TIPO AGENDAMENTO"
        Me.TIPO_AGENDAMENTO.Name = "TIPO_AGENDAMENTO"
        Me.TIPO_AGENDAMENTO.ReadOnly = True
        '
        'CODIGO_TIPO_PALLET
        '
        Me.CODIGO_TIPO_PALLET.DataPropertyName = "CodigoTipoPallet"
        Me.CODIGO_TIPO_PALLET.HeaderText = "CODIGO_TIPO_PALLET"
        Me.CODIGO_TIPO_PALLET.Name = "CODIGO_TIPO_PALLET"
        Me.CODIGO_TIPO_PALLET.ReadOnly = True
        Me.CODIGO_TIPO_PALLET.Visible = False
        '
        'TIPO_PALLET
        '
        Me.TIPO_PALLET.DataPropertyName = "TipoPallet"
        Me.TIPO_PALLET.HeaderText = "TIPO PALLET"
        Me.TIPO_PALLET.Name = "TIPO_PALLET"
        Me.TIPO_PALLET.ReadOnly = True
        '
        'CODIGO_TIPO_CARGA
        '
        Me.CODIGO_TIPO_CARGA.DataPropertyName = "CodigoTipoCarga"
        Me.CODIGO_TIPO_CARGA.HeaderText = "CODIGO_TIPO_CARGA"
        Me.CODIGO_TIPO_CARGA.Name = "CODIGO_TIPO_CARGA"
        Me.CODIGO_TIPO_CARGA.ReadOnly = True
        Me.CODIGO_TIPO_CARGA.Visible = False
        '
        'TIPO_CARGA
        '
        Me.TIPO_CARGA.DataPropertyName = "TipoCarga"
        Me.TIPO_CARGA.HeaderText = "TIPO CARGA"
        Me.TIPO_CARGA.Name = "TIPO_CARGA"
        Me.TIPO_CARGA.ReadOnly = True
        '
        'CODIGO_TIPO_VEICULO
        '
        Me.CODIGO_TIPO_VEICULO.DataPropertyName = "CodigoTipoVeiculo"
        Me.CODIGO_TIPO_VEICULO.HeaderText = "CODIGO_TIPO_VEICULO"
        Me.CODIGO_TIPO_VEICULO.Name = "CODIGO_TIPO_VEICULO"
        Me.CODIGO_TIPO_VEICULO.ReadOnly = True
        Me.CODIGO_TIPO_VEICULO.Visible = False
        '
        'TIPO_VEICULO
        '
        Me.TIPO_VEICULO.DataPropertyName = "TipoVeiculo"
        Me.TIPO_VEICULO.HeaderText = "TIPO VEICULO"
        Me.TIPO_VEICULO.Name = "TIPO_VEICULO"
        Me.TIPO_VEICULO.ReadOnly = True
        '
        'NFE
        '
        Me.NFE.DataPropertyName = "NFE"
        Me.NFE.HeaderText = "NFE"
        Me.NFE.Name = "NFE"
        Me.NFE.ReadOnly = True
        '
        'NOME_MOTORISTA
        '
        Me.NOME_MOTORISTA.DataPropertyName = "NomeMotorista"
        Me.NOME_MOTORISTA.HeaderText = "NOME MOTORISTA"
        Me.NOME_MOTORISTA.Name = "NOME_MOTORISTA"
        Me.NOME_MOTORISTA.ReadOnly = True
        '
        'OBSERVACAO
        '
        Me.OBSERVACAO.DataPropertyName = "Observacao"
        Me.OBSERVACAO.HeaderText = "OBSERVAÇÃO"
        Me.OBSERVACAO.Name = "OBSERVACAO"
        Me.OBSERVACAO.ReadOnly = True
        '
        'ORIGEM
        '
        Me.ORIGEM.DataPropertyName = "Origem"
        Me.ORIGEM.HeaderText = "ORIGEM"
        Me.ORIGEM.Name = "ORIGEM"
        Me.ORIGEM.ReadOnly = True
        '
        'DESTINO
        '
        Me.DESTINO.DataPropertyName = "Destino"
        Me.DESTINO.HeaderText = "DESTINO"
        Me.DESTINO.Name = "DESTINO"
        Me.DESTINO.ReadOnly = True
        '
        'QUANTIDADE_PALLET
        '
        Me.QUANTIDADE_PALLET.DataPropertyName = "QuantidadePallet"
        Me.QUANTIDADE_PALLET.HeaderText = "QTD. PALLET"
        Me.QUANTIDADE_PALLET.Name = "QUANTIDADE_PALLET"
        Me.QUANTIDADE_PALLET.ReadOnly = True
        '
        'DATA_AGENDAMENTO
        '
        Me.DATA_AGENDAMENTO.DataPropertyName = "DataAgendamento"
        Me.DATA_AGENDAMENTO.HeaderText = "DT. AGENDAMENTO"
        Me.DATA_AGENDAMENTO.Name = "DATA_AGENDAMENTO"
        Me.DATA_AGENDAMENTO.ReadOnly = True
        '
        'DATA_CANCELAMENTO
        '
        Me.DATA_CANCELAMENTO.DataPropertyName = "DataCancelamento"
        Me.DATA_CANCELAMENTO.HeaderText = "DT. CANCELAMENTO"
        Me.DATA_CANCELAMENTO.Name = "DATA_CANCELAMENTO"
        Me.DATA_CANCELAMENTO.ReadOnly = True
        '
        'nswTipoAgendamento
        '
        Me.nswTipoAgendamento.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoAgendamento.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoAgendamento.ListaColunas = Nothing
        Me.nswTipoAgendamento.Location = New System.Drawing.Point(3, 85)
        Me.nswTipoAgendamento.Name = "nswTipoAgendamento"
        Me.nswTipoAgendamento.OrderBy = Nothing
        Me.nswTipoAgendamento.Size = New System.Drawing.Size(332, 41)
        Me.nswTipoAgendamento.Tabela = Nothing
        Me.nswTipoAgendamento.TabIndex = 31
        Me.nswTipoAgendamento.Titulo = "Tipo de agendamento"
        Me.nswTipoAgendamento.Where = Nothing
        '
        'nswTipoPallet
        '
        Me.nswTipoPallet.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoPallet.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoPallet.ListaColunas = Nothing
        Me.nswTipoPallet.Location = New System.Drawing.Point(335, 4)
        Me.nswTipoPallet.Name = "nswTipoPallet"
        Me.nswTipoPallet.OrderBy = Nothing
        Me.nswTipoPallet.Size = New System.Drawing.Size(332, 41)
        Me.nswTipoPallet.Tabela = Nothing
        Me.nswTipoPallet.TabIndex = 32
        Me.nswTipoPallet.Titulo = "Tipo de pallet"
        Me.nswTipoPallet.Where = Nothing
        '
        'nswTipoCarga
        '
        Me.nswTipoCarga.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoCarga.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoCarga.ListaColunas = Nothing
        Me.nswTipoCarga.Location = New System.Drawing.Point(335, 44)
        Me.nswTipoCarga.Name = "nswTipoCarga"
        Me.nswTipoCarga.OrderBy = Nothing
        Me.nswTipoCarga.Size = New System.Drawing.Size(332, 41)
        Me.nswTipoCarga.Tabela = Nothing
        Me.nswTipoCarga.TabIndex = 33
        Me.nswTipoCarga.Titulo = "Tipo de carga"
        Me.nswTipoCarga.Where = Nothing
        '
        'nswTipoVeiculo
        '
        Me.nswTipoVeiculo.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoVeiculo.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoVeiculo.ListaColunas = Nothing
        Me.nswTipoVeiculo.Location = New System.Drawing.Point(335, 85)
        Me.nswTipoVeiculo.Name = "nswTipoVeiculo"
        Me.nswTipoVeiculo.OrderBy = Nothing
        Me.nswTipoVeiculo.Size = New System.Drawing.Size(332, 41)
        Me.nswTipoVeiculo.Tabela = Nothing
        Me.nswTipoVeiculo.TabIndex = 34
        Me.nswTipoVeiculo.Titulo = "Tipo de veículo"
        Me.nswTipoVeiculo.Where = Nothing
        '
        'FrmListaAgendamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 525)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListaAgendamentos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de agendamentos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlFiltro.ResumeLayout(False)
        Me.pnlFiltro.PerformLayout()
        CType(Me.dgvAgendamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pnlFiltro As Panel
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents dgvAgendamentos As DataGridView
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_TRANSPORTADORA As DataGridViewTextBoxColumn
    Friend WithEvents TRANSPORTADOR As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_EMPRESA As DataGridViewTextBoxColumn
    Friend WithEvents EMPRESA As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_TIPO_AGENDAMENTO As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_AGENDAMENTO As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_TIPO_PALLET As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_PALLET As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_TIPO_CARGA As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_CARGA As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO_TIPO_VEICULO As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_VEICULO As DataGridViewTextBoxColumn
    Friend WithEvents NFE As DataGridViewTextBoxColumn
    Friend WithEvents NOME_MOTORISTA As DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACAO As DataGridViewTextBoxColumn
    Friend WithEvents ORIGEM As DataGridViewTextBoxColumn
    Friend WithEvents DESTINO As DataGridViewTextBoxColumn
    Friend WithEvents QUANTIDADE_PALLET As DataGridViewTextBoxColumn
    Friend WithEvents DATA_AGENDAMENTO As DataGridViewTextBoxColumn
    Friend WithEvents DATA_CANCELAMENTO As DataGridViewTextBoxColumn
    Friend WithEvents txtNumNFe As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomeMotorista As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQtdPallet As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpAgendaAte As DateTimePicker
    Friend WithEvents dtpAgendaDe As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOrigem As TextBox
    Friend WithEvents chkOcultarCancelados As CheckBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents nswEmpresa As NewSearchWindow
    Friend WithEvents nswTransportador As NewSearchWindow
    Friend WithEvents nswTipoAgendamento As NewSearchWindow
    Friend WithEvents nswTipoPallet As NewSearchWindow
    Friend WithEvents nswTipoCarga As NewSearchWindow
    Friend WithEvents nswTipoVeiculo As NewSearchWindow
End Class
