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
        Me.lblNota = New System.Windows.Forms.Label()
        Me.dtpDataAvaliacao = New System.Windows.Forms.DateTimePicker()
        Me.lblDataAvaliacao = New System.Windows.Forms.Label()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtAcao = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.AVALIADOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONTOS_FORTES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONTOS_FRACOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA_AVALIACAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AVALIACAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NewSearchWindow3 = New WStock.NewSearchWindow()
        Me.NewSearchWindow2 = New WStock.NewSearchWindow()
        Me.NewSearchWindow1 = New WStock.NewSearchWindow()
        Me.nswTurno = New WStock.NewSearchWindow()
        Me.nswArea = New WStock.NewSearchWindow()
        Me.nswEmpresa = New WStock.NewSearchWindow()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNota.Location = New System.Drawing.Point(343, 225)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(54, 13)
        Me.lblNota.TabIndex = 16
        Me.lblNota.Text = "Avaliação"
        '
        'dtpDataAvaliacao
        '
        Me.dtpDataAvaliacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataAvaliacao.Location = New System.Drawing.Point(235, 242)
        Me.dtpDataAvaliacao.Name = "dtpDataAvaliacao"
        Me.dtpDataAvaliacao.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataAvaliacao.TabIndex = 23
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
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(9, 242)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataInicial.TabIndex = 28
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(132, 242)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataFinal.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Período avaliação"
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ruim", "Regular", "Bom", "Ótimo"})
        Me.ComboBox1.Location = New System.Drawing.Point(340, 241)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(158, 21)
        Me.ComboBox1.TabIndex = 61
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
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txtAcao)
        Me.GroupBox1.Controls.Add(Me.txtPontosFracos)
        Me.GroupBox1.Controls.Add(Me.lblPontosFracos)
        Me.GroupBox1.Controls.Add(Me.dtpDataInicial)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.dtpDataFinal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDataAvaliacao)
        Me.GroupBox1.Controls.Add(Me.lblDataAvaliacao)
        Me.GroupBox1.Controls.Add(Me.lblNota)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 299)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AVALIADOR, Me.PONTOS_FORTES, Me.PONTOS_FRACOS, Me.DATA_AVALIACAO, Me.AVALIACAO})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(6, 303)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(680, 176)
        Me.DataGridView1.TabIndex = 64
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(504, 241)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(163, 21)
        Me.TextBox1.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(507, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Avaliação geral"
        '
        'NewSearchWindow3
        '
        Me.NewSearchWindow3.CampoCodigoTabelaRetono = ""
        Me.NewSearchWindow3.CampoDescricaoTabelaRetono = ""
        Me.NewSearchWindow3.Codigo = Nothing
        Me.NewSearchWindow3.Descricao = Nothing
        Me.NewSearchWindow3.ListaColunas = Nothing
        Me.NewSearchWindow3.Location = New System.Drawing.Point(343, 100)
        Me.NewSearchWindow3.Name = "NewSearchWindow3"
        Me.NewSearchWindow3.OrderBy = Nothing
        Me.NewSearchWindow3.Size = New System.Drawing.Size(328, 41)
        Me.NewSearchWindow3.Tabela = ""
        Me.NewSearchWindow3.TabIndex = 59
        Me.NewSearchWindow3.Titulo = "Avaliador*"
        Me.NewSearchWindow3.Where = Nothing
        '
        'NewSearchWindow2
        '
        Me.NewSearchWindow2.CampoCodigoTabelaRetono = ""
        Me.NewSearchWindow2.CampoDescricaoTabelaRetono = ""
        Me.NewSearchWindow2.Codigo = Nothing
        Me.NewSearchWindow2.Descricao = Nothing
        Me.NewSearchWindow2.Enabled = False
        Me.NewSearchWindow2.ListaColunas = Nothing
        Me.NewSearchWindow2.Location = New System.Drawing.Point(12, 100)
        Me.NewSearchWindow2.Name = "NewSearchWindow2"
        Me.NewSearchWindow2.OrderBy = Nothing
        Me.NewSearchWindow2.Size = New System.Drawing.Size(328, 41)
        Me.NewSearchWindow2.Tabela = ""
        Me.NewSearchWindow2.TabIndex = 58
        Me.NewSearchWindow2.Titulo = "Lider direto"
        Me.NewSearchWindow2.Where = Nothing
        '
        'NewSearchWindow1
        '
        Me.NewSearchWindow1.CampoCodigoTabelaRetono = ""
        Me.NewSearchWindow1.CampoDescricaoTabelaRetono = ""
        Me.NewSearchWindow1.Codigo = Nothing
        Me.NewSearchWindow1.Descricao = Nothing
        Me.NewSearchWindow1.ListaColunas = Nothing
        Me.NewSearchWindow1.Location = New System.Drawing.Point(12, 12)
        Me.NewSearchWindow1.Name = "NewSearchWindow1"
        Me.NewSearchWindow1.OrderBy = Nothing
        Me.NewSearchWindow1.Size = New System.Drawing.Size(328, 41)
        Me.NewSearchWindow1.Tabela = ""
        Me.NewSearchWindow1.TabIndex = 57
        Me.NewSearchWindow1.Titulo = "Funcionário*"
        Me.NewSearchWindow1.Where = Nothing
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
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.NewSearchWindow3)
        Me.Controls.Add(Me.NewSearchWindow2)
        Me.Controls.Add(Me.NewSearchWindow1)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpontosFortes As Label
    Friend WithEvents txtPontosFortes As TextBox
    Friend WithEvents lblPontosFracos As Label
    Friend WithEvents txtPontosFracos As TextBox
    Friend WithEvents lblNota As Label
    Friend WithEvents dtpDataAvaliacao As DateTimePicker
    Friend WithEvents lblDataAvaliacao As Label
    Friend WithEvents dtpDataInicial As DateTimePicker
    Friend WithEvents dtpDataFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents nswEmpresa As NewSearchWindow
    Friend WithEvents nswArea As NewSearchWindow
    Friend WithEvents nswTurno As NewSearchWindow
    Friend WithEvents NewSearchWindow1 As NewSearchWindow
    Friend WithEvents NewSearchWindow2 As NewSearchWindow
    Friend WithEvents NewSearchWindow3 As NewSearchWindow
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtAcao As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnProcurar As Button
    Friend WithEvents AVALIADOR As DataGridViewTextBoxColumn
    Friend WithEvents PONTOS_FORTES As DataGridViewTextBoxColumn
    Friend WithEvents PONTOS_FRACOS As DataGridViewTextBoxColumn
    Friend WithEvents DATA_AVALIACAO As DataGridViewTextBoxColumn
    Friend WithEvents AVALIACAO As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
