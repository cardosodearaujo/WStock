<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTerceiros
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTerceiros))
        Me.lblpontosFortes = New System.Windows.Forms.Label()
        Me.txtPontosFortes = New System.Windows.Forms.TextBox()
        Me.lblPontosFracos = New System.Windows.Forms.Label()
        Me.txtPontosFracos = New System.Windows.Forms.TextBox()
        Me.lblAvalidacao = New System.Windows.Forms.Label()
        Me.dtpAvaliacao = New System.Windows.Forms.DateTimePicker()
        Me.lblDataAvaliacao = New System.Windows.Forms.Label()
        Me.dtpPeriodoInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpPeriodoFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblPeriodoInicial = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAvaliacao = New System.Windows.Forms.ComboBox()
        Me.txtAcao = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAvaliacaoGeral = New System.Windows.Forms.Label()
        Me.txtAvaliacaoGeral = New System.Windows.Forms.TextBox()
        Me.dgvAvaliacoes = New System.Windows.Forms.DataGridView()
        Me.AVALIADOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONTOS_FORTES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONTOS_FRACOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA_AVALIACAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AVALIACAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.nswAvaliador = New WStock.NewSearchWindow()
        Me.nswLiderDireto = New WStock.NewSearchWindow()
        Me.nswFuncionario = New WStock.NewSearchWindow()
        Me.nswTurno = New WStock.NewSearchWindow()
        Me.nswArea = New WStock.NewSearchWindow()
        Me.nswEmpresa = New WStock.NewSearchWindow()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAvaliacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblpontosFortes
        '
        Me.lblpontosFortes.AutoSize = True
        Me.lblpontosFortes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpontosFortes.Location = New System.Drawing.Point(18, 144)
        Me.lblpontosFortes.Name = "lblpontosFortes"
        Me.lblpontosFortes.Size = New System.Drawing.Size(69, 13)
        Me.lblpontosFortes.TabIndex = 12
        Me.lblpontosFortes.Text = "Pontos fortes"
        '
        'txtPontosFortes
        '
        Me.txtPontosFortes.Location = New System.Drawing.Point(15, 160)
        Me.txtPontosFortes.Multiline = True
        Me.txtPontosFortes.Name = "txtPontosFortes"
        Me.txtPontosFortes.Size = New System.Drawing.Size(325, 61)
        Me.txtPontosFortes.TabIndex = 13
        '
        'lblPontosFracos
        '
        Me.lblPontosFracos.AutoSize = True
        Me.lblPontosFracos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPontosFracos.Location = New System.Drawing.Point(343, 144)
        Me.lblPontosFracos.Name = "lblPontosFracos"
        Me.lblPontosFracos.Size = New System.Drawing.Size(72, 13)
        Me.lblPontosFracos.TabIndex = 14
        Me.lblPontosFracos.Text = "Pontos fracos"
        '
        'txtPontosFracos
        '
        Me.txtPontosFracos.Location = New System.Drawing.Point(340, 160)
        Me.txtPontosFracos.Multiline = True
        Me.txtPontosFracos.Name = "txtPontosFracos"
        Me.txtPontosFracos.Size = New System.Drawing.Size(325, 61)
        Me.txtPontosFracos.TabIndex = 15
        '
        'lblAvalidacao
        '
        Me.lblAvalidacao.AutoSize = True
        Me.lblAvalidacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAvalidacao.Location = New System.Drawing.Point(343, 225)
        Me.lblAvalidacao.Name = "lblAvalidacao"
        Me.lblAvalidacao.Size = New System.Drawing.Size(54, 13)
        Me.lblAvalidacao.TabIndex = 16
        Me.lblAvalidacao.Text = "Avaliação"
        '
        'dtpAvaliacao
        '
        Me.dtpAvaliacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAvaliacao.Location = New System.Drawing.Point(235, 242)
        Me.dtpAvaliacao.Name = "dtpAvaliacao"
        Me.dtpAvaliacao.Size = New System.Drawing.Size(99, 20)
        Me.dtpAvaliacao.TabIndex = 23
        '
        'lblDataAvaliacao
        '
        Me.lblDataAvaliacao.AutoSize = True
        Me.lblDataAvaliacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataAvaliacao.Location = New System.Drawing.Point(238, 226)
        Me.lblDataAvaliacao.Name = "lblDataAvaliacao"
        Me.lblDataAvaliacao.Size = New System.Drawing.Size(79, 13)
        Me.lblDataAvaliacao.TabIndex = 24
        Me.lblDataAvaliacao.Text = "Data avaliação"
        '
        'dtpPeriodoInicial
        '
        Me.dtpPeriodoInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPeriodoInicial.Location = New System.Drawing.Point(9, 242)
        Me.dtpPeriodoInicial.Name = "dtpPeriodoInicial"
        Me.dtpPeriodoInicial.Size = New System.Drawing.Size(99, 20)
        Me.dtpPeriodoInicial.TabIndex = 28
        '
        'dtpPeriodoFinal
        '
        Me.dtpPeriodoFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPeriodoFinal.Location = New System.Drawing.Point(132, 242)
        Me.dtpPeriodoFinal.Name = "dtpPeriodoFinal"
        Me.dtpPeriodoFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtpPeriodoFinal.TabIndex = 29
        '
        'lblPeriodoInicial
        '
        Me.lblPeriodoInicial.AutoSize = True
        Me.lblPeriodoInicial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPeriodoInicial.Location = New System.Drawing.Point(12, 226)
        Me.lblPeriodoInicial.Name = "lblPeriodoInicial"
        Me.lblPeriodoInicial.Size = New System.Drawing.Size(94, 13)
        Me.lblPeriodoInicial.TabIndex = 30
        Me.lblPeriodoInicial.Text = "Período avaliação"
        '
        'btnSalvar
        '
        Me.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalvar.Image = Global.WStock.My.Resources.Resources.floppy_disk
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(6, 485)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(95, 29)
        Me.btnSalvar.TabIndex = 31
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(110, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "até"
        '
        'cboAvaliacao
        '
        Me.cboAvaliacao.FormattingEnabled = True
        Me.cboAvaliacao.Items.AddRange(New Object() {"Ruim", "Regular", "Bom", "Ótimo"})
        Me.cboAvaliacao.Location = New System.Drawing.Point(340, 241)
        Me.cboAvaliacao.Name = "cboAvaliacao"
        Me.cboAvaliacao.Size = New System.Drawing.Size(158, 21)
        Me.cboAvaliacao.TabIndex = 61
        '
        'txtAcao
        '
        Me.txtAcao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAcao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcao.ForeColor = System.Drawing.SystemColors.Control
        Me.txtAcao.Location = New System.Drawing.Point(181, 270)
        Me.txtAcao.Multiline = True
        Me.txtAcao.Name = "txtAcao"
        Me.txtAcao.ReadOnly = True
        Me.txtAcao.Size = New System.Drawing.Size(312, 24)
        Me.txtAcao.TabIndex = 62
        Me.txtAcao.Text = "Convocar somente em urgência"
        Me.txtAcao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAvaliacaoGeral)
        Me.GroupBox1.Controls.Add(Me.txtAvaliacaoGeral)
        Me.GroupBox1.Controls.Add(Me.txtAcao)
        Me.GroupBox1.Controls.Add(Me.txtPontosFracos)
        Me.GroupBox1.Controls.Add(Me.lblPontosFracos)
        Me.GroupBox1.Controls.Add(Me.dtpPeriodoInicial)
        Me.GroupBox1.Controls.Add(Me.cboAvaliacao)
        Me.GroupBox1.Controls.Add(Me.dtpPeriodoFinal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblPeriodoInicial)
        Me.GroupBox1.Controls.Add(Me.dtpAvaliacao)
        Me.GroupBox1.Controls.Add(Me.lblDataAvaliacao)
        Me.GroupBox1.Controls.Add(Me.lblAvalidacao)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 299)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'lblAvaliacaoGeral
        '
        Me.lblAvaliacaoGeral.AutoSize = True
        Me.lblAvaliacaoGeral.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAvaliacaoGeral.Location = New System.Drawing.Point(507, 225)
        Me.lblAvaliacaoGeral.Name = "lblAvaliacaoGeral"
        Me.lblAvaliacaoGeral.Size = New System.Drawing.Size(80, 13)
        Me.lblAvaliacaoGeral.TabIndex = 63
        Me.lblAvaliacaoGeral.Text = "Avaliação geral"
        '
        'txtAvaliacaoGeral
        '
        Me.txtAvaliacaoGeral.Location = New System.Drawing.Point(504, 241)
        Me.txtAvaliacaoGeral.Multiline = True
        Me.txtAvaliacaoGeral.Name = "txtAvaliacaoGeral"
        Me.txtAvaliacaoGeral.ReadOnly = True
        Me.txtAvaliacaoGeral.Size = New System.Drawing.Size(163, 21)
        Me.txtAvaliacaoGeral.TabIndex = 62
        '
        'dgvAvaliacoes
        '
        Me.dgvAvaliacoes.AllowUserToAddRows = False
        Me.dgvAvaliacoes.AllowUserToDeleteRows = False
        Me.dgvAvaliacoes.BackgroundColor = System.Drawing.Color.White
        Me.dgvAvaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvaliacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AVALIADOR, Me.PONTOS_FORTES, Me.PONTOS_FRACOS, Me.DATA_AVALIACAO, Me.AVALIACAO})
        Me.dgvAvaliacoes.GridColor = System.Drawing.SystemColors.Control
        Me.dgvAvaliacoes.Location = New System.Drawing.Point(6, 303)
        Me.dgvAvaliacoes.Name = "dgvAvaliacoes"
        Me.dgvAvaliacoes.ReadOnly = True
        Me.dgvAvaliacoes.Size = New System.Drawing.Size(680, 176)
        Me.dgvAvaliacoes.TabIndex = 64
        '
        'AVALIADOR
        '
        Me.AVALIADOR.HeaderText = "Avaliador"
        Me.AVALIADOR.Name = "AVALIADOR"
        Me.AVALIADOR.ReadOnly = True
        '
        'PONTOS_FORTES
        '
        Me.PONTOS_FORTES.HeaderText = "Pontos fortes"
        Me.PONTOS_FORTES.Name = "PONTOS_FORTES"
        Me.PONTOS_FORTES.ReadOnly = True
        Me.PONTOS_FORTES.Width = 165
        '
        'PONTOS_FRACOS
        '
        Me.PONTOS_FRACOS.HeaderText = "Pontos fracos"
        Me.PONTOS_FRACOS.Name = "PONTOS_FRACOS"
        Me.PONTOS_FRACOS.ReadOnly = True
        Me.PONTOS_FRACOS.Width = 165
        '
        'DATA_AVALIACAO
        '
        Me.DATA_AVALIACAO.HeaderText = "Data da avaliação"
        Me.DATA_AVALIACAO.Name = "DATA_AVALIACAO"
        Me.DATA_AVALIACAO.ReadOnly = True
        '
        'AVALIACAO
        '
        Me.AVALIACAO.HeaderText = "Avaliação"
        Me.AVALIACAO.Name = "AVALIACAO"
        Me.AVALIACAO.ReadOnly = True
        '
        'btnProcurar
        '
        Me.btnProcurar.Image = Global.WStock.My.Resources.Resources.search
        Me.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcurar.Location = New System.Drawing.Point(106, 485)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(95, 29)
        Me.btnProcurar.TabIndex = 65
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'nswAvaliador
        '
        Me.nswAvaliador.CampoCodigoTabelaRetono = ""
        Me.nswAvaliador.CampoDescricaoTabelaRetono = ""
        Me.nswAvaliador.Codigo = Nothing
        Me.nswAvaliador.Descricao = Nothing
        Me.nswAvaliador.ListaColunas = Nothing
        Me.nswAvaliador.Location = New System.Drawing.Point(343, 100)
        Me.nswAvaliador.Name = "nswAvaliador"
        Me.nswAvaliador.OrderBy = Nothing
        Me.nswAvaliador.Size = New System.Drawing.Size(328, 41)
        Me.nswAvaliador.Tabela = ""
        Me.nswAvaliador.TabIndex = 59
        Me.nswAvaliador.Titulo = "Avaliador*"
        Me.nswAvaliador.Where = Nothing
        '
        'nswLiderDireto
        '
        Me.nswLiderDireto.CampoCodigoTabelaRetono = ""
        Me.nswLiderDireto.CampoDescricaoTabelaRetono = ""
        Me.nswLiderDireto.Codigo = Nothing
        Me.nswLiderDireto.Descricao = Nothing
        Me.nswLiderDireto.Enabled = False
        Me.nswLiderDireto.ListaColunas = Nothing
        Me.nswLiderDireto.Location = New System.Drawing.Point(12, 100)
        Me.nswLiderDireto.Name = "nswLiderDireto"
        Me.nswLiderDireto.OrderBy = Nothing
        Me.nswLiderDireto.Size = New System.Drawing.Size(328, 41)
        Me.nswLiderDireto.Tabela = ""
        Me.nswLiderDireto.TabIndex = 58
        Me.nswLiderDireto.Titulo = "Lider direto"
        Me.nswLiderDireto.Where = Nothing
        '
        'nswFuncionario
        '
        Me.nswFuncionario.CampoCodigoTabelaRetono = ""
        Me.nswFuncionario.CampoDescricaoTabelaRetono = ""
        Me.nswFuncionario.Codigo = Nothing
        Me.nswFuncionario.Descricao = Nothing
        Me.nswFuncionario.ListaColunas = Nothing
        Me.nswFuncionario.Location = New System.Drawing.Point(12, 12)
        Me.nswFuncionario.Name = "nswFuncionario"
        Me.nswFuncionario.OrderBy = Nothing
        Me.nswFuncionario.Size = New System.Drawing.Size(328, 41)
        Me.nswFuncionario.Tabela = ""
        Me.nswFuncionario.TabIndex = 57
        Me.nswFuncionario.Titulo = "Funcionário*"
        Me.nswFuncionario.Where = Nothing
        '
        'nswTurno
        '
        Me.nswTurno.CampoCodigoTabelaRetono = ""
        Me.nswTurno.CampoDescricaoTabelaRetono = ""
        Me.nswTurno.Codigo = Nothing
        Me.nswTurno.Descricao = Nothing
        Me.nswTurno.Enabled = False
        Me.nswTurno.ListaColunas = Nothing
        Me.nswTurno.Location = New System.Drawing.Point(10, 54)
        Me.nswTurno.Name = "nswTurno"
        Me.nswTurno.OrderBy = Nothing
        Me.nswTurno.Size = New System.Drawing.Size(332, 41)
        Me.nswTurno.Tabela = ""
        Me.nswTurno.TabIndex = 56
        Me.nswTurno.Titulo = "Turno"
        Me.nswTurno.Where = Nothing
        '
        'nswArea
        '
        Me.nswArea.CampoCodigoTabelaRetono = ""
        Me.nswArea.CampoDescricaoTabelaRetono = ""
        Me.nswArea.Codigo = Nothing
        Me.nswArea.Descricao = Nothing
        Me.nswArea.Enabled = False
        Me.nswArea.ListaColunas = Nothing
        Me.nswArea.Location = New System.Drawing.Point(341, 54)
        Me.nswArea.Name = "nswArea"
        Me.nswArea.OrderBy = Nothing
        Me.nswArea.Size = New System.Drawing.Size(332, 41)
        Me.nswArea.Tabela = ""
        Me.nswArea.TabIndex = 55
        Me.nswArea.Titulo = "Área"
        Me.nswArea.Where = Nothing
        '
        'nswEmpresa
        '
        Me.nswEmpresa.CampoCodigoTabelaRetono = ""
        Me.nswEmpresa.CampoDescricaoTabelaRetono = ""
        Me.nswEmpresa.Codigo = Nothing
        Me.nswEmpresa.Descricao = Nothing
        Me.nswEmpresa.Enabled = False
        Me.nswEmpresa.ListaColunas = Nothing
        Me.nswEmpresa.Location = New System.Drawing.Point(343, 12)
        Me.nswEmpresa.Name = "nswEmpresa"
        Me.nswEmpresa.OrderBy = Nothing
        Me.nswEmpresa.Size = New System.Drawing.Size(328, 41)
        Me.nswEmpresa.Tabela = ""
        Me.nswEmpresa.TabIndex = 43
        Me.nswEmpresa.Titulo = "Empresa"
        Me.nswEmpresa.Where = Nothing
        '
        'FrmTerceiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 519)
        Me.Controls.Add(Me.btnProcurar)
        Me.Controls.Add(Me.dgvAvaliacoes)
        Me.Controls.Add(Me.nswAvaliador)
        Me.Controls.Add(Me.nswLiderDireto)
        Me.Controls.Add(Me.nswFuncionario)
        Me.Controls.Add(Me.nswTurno)
        Me.Controls.Add(Me.nswArea)
        Me.Controls.Add(Me.nswEmpresa)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtPontosFortes)
        Me.Controls.Add(Me.lblpontosFortes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTerceiros"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avaliação terceirizados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAvaliacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpontosFortes As Label
    Friend WithEvents txtPontosFortes As TextBox
    Friend WithEvents lblPontosFracos As Label
    Friend WithEvents txtPontosFracos As TextBox
    Friend WithEvents lblAvalidacao As Label
    Friend WithEvents dtpAvaliacao As DateTimePicker
    Friend WithEvents lblDataAvaliacao As Label
    Friend WithEvents dtpPeriodoInicial As DateTimePicker
    Friend WithEvents dtpPeriodoFinal As DateTimePicker
    Friend WithEvents lblPeriodoInicial As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents nswEmpresa As NewSearchWindow
    Friend WithEvents nswArea As NewSearchWindow
    Friend WithEvents nswTurno As NewSearchWindow
    Friend WithEvents nswFuncionario As NewSearchWindow
    Friend WithEvents nswLiderDireto As NewSearchWindow
    Friend WithEvents nswAvaliador As NewSearchWindow
    Friend WithEvents Label2 As Label
    Friend WithEvents cboAvaliacao As ComboBox
    Friend WithEvents txtAcao As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvAvaliacoes As DataGridView
    Friend WithEvents btnProcurar As Button
    Friend WithEvents AVALIADOR As DataGridViewTextBoxColumn
    Friend WithEvents PONTOS_FORTES As DataGridViewTextBoxColumn
    Friend WithEvents PONTOS_FRACOS As DataGridViewTextBoxColumn
    Friend WithEvents DATA_AVALIACAO As DataGridViewTextBoxColumn
    Friend WithEvents AVALIACAO As DataGridViewTextBoxColumn
    Friend WithEvents lblAvaliacaoGeral As Label
    Friend WithEvents txtAvaliacaoGeral As TextBox
End Class
