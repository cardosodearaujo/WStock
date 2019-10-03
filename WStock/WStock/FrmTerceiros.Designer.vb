<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTerceiros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTerceiros))
        Me.cboNomeFuncionario = New System.Windows.Forms.ComboBox()
        Me.lblNomeFuncionario = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.cboAreaAtuacao = New System.Windows.Forms.ComboBox()
        Me.lblAreaAtuacao = New System.Windows.Forms.Label()
        Me.lblLiderDireto = New System.Windows.Forms.Label()
        Me.cboLiderDireto = New System.Windows.Forms.ComboBox()
        Me.cboAvaliador = New System.Windows.Forms.ComboBox()
        Me.lblAvaliador = New System.Windows.Forms.Label()
        Me.lblpontosFortes = New System.Windows.Forms.Label()
        Me.txtPontosFortes = New System.Windows.Forms.TextBox()
        Me.lblPontosFracos = New System.Windows.Forms.Label()
        Me.txtPontosFracos = New System.Windows.Forms.TextBox()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.lblConceito = New System.Windows.Forms.Label()
        Me.cboNota = New System.Windows.Forms.ComboBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvarT = New System.Windows.Forms.Button()
        Me.dtpDataAvaliacao = New System.Windows.Forms.DateTimePicker()
        Me.lblDataAvaliacao = New System.Windows.Forms.Label()
        Me.cboNomeEmpresa = New System.Windows.Forms.ComboBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAvaliacoes = New System.Windows.Forms.DataGridView()
        Me.grbAvaliacoes = New System.Windows.Forms.GroupBox()
        CType(Me.dgvAvaliacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAvaliacoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboNomeFuncionario
        '
        Me.cboNomeFuncionario.FormattingEnabled = True
        Me.cboNomeFuncionario.Location = New System.Drawing.Point(77, 34)
        Me.cboNomeFuncionario.Name = "cboNomeFuncionario"
        Me.cboNomeFuncionario.Size = New System.Drawing.Size(274, 21)
        Me.cboNomeFuncionario.TabIndex = 0
        '
        'lblNomeFuncionario
        '
        Me.lblNomeFuncionario.AutoSize = True
        Me.lblNomeFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNomeFuncionario.Location = New System.Drawing.Point(74, 15)
        Me.lblNomeFuncionario.Name = "lblNomeFuncionario"
        Me.lblNomeFuncionario.Size = New System.Drawing.Size(90, 13)
        Me.lblNomeFuncionario.TabIndex = 1
        Me.lblNomeFuncionario.Text = "Nome funcionário"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEmpresa.Location = New System.Drawing.Point(358, 15)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.lblEmpresa.TabIndex = 3
        Me.lblEmpresa.Text = "Empresa"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPeriodo.Location = New System.Drawing.Point(355, 61)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(35, 13)
        Me.lblPeriodo.TabIndex = 4
        Me.lblPeriodo.Text = "Turno"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(358, 77)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(190, 21)
        Me.cboPeriodo.TabIndex = 5
        '
        'cboAreaAtuacao
        '
        Me.cboAreaAtuacao.FormattingEnabled = True
        Me.cboAreaAtuacao.Location = New System.Drawing.Point(557, 77)
        Me.cboAreaAtuacao.Name = "cboAreaAtuacao"
        Me.cboAreaAtuacao.Size = New System.Drawing.Size(271, 21)
        Me.cboAreaAtuacao.TabIndex = 6
        '
        'lblAreaAtuacao
        '
        Me.lblAreaAtuacao.AutoSize = True
        Me.lblAreaAtuacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAreaAtuacao.Location = New System.Drawing.Point(554, 61)
        Me.lblAreaAtuacao.Name = "lblAreaAtuacao"
        Me.lblAreaAtuacao.Size = New System.Drawing.Size(71, 13)
        Me.lblAreaAtuacao.TabIndex = 7
        Me.lblAreaAtuacao.Text = "Área atuação"
        '
        'lblLiderDireto
        '
        Me.lblLiderDireto.AutoSize = True
        Me.lblLiderDireto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLiderDireto.Location = New System.Drawing.Point(554, 17)
        Me.lblLiderDireto.Name = "lblLiderDireto"
        Me.lblLiderDireto.Size = New System.Drawing.Size(59, 13)
        Me.lblLiderDireto.TabIndex = 8
        Me.lblLiderDireto.Text = "Lider direto"
        '
        'cboLiderDireto
        '
        Me.cboLiderDireto.FormattingEnabled = True
        Me.cboLiderDireto.Location = New System.Drawing.Point(557, 34)
        Me.cboLiderDireto.Name = "cboLiderDireto"
        Me.cboLiderDireto.Size = New System.Drawing.Size(271, 21)
        Me.cboLiderDireto.TabIndex = 9
        '
        'cboAvaliador
        '
        Me.cboAvaliador.FormattingEnabled = True
        Me.cboAvaliador.Location = New System.Drawing.Point(12, 77)
        Me.cboAvaliador.Name = "cboAvaliador"
        Me.cboAvaliador.Size = New System.Drawing.Size(339, 21)
        Me.cboAvaliador.TabIndex = 10
        '
        'lblAvaliador
        '
        Me.lblAvaliador.AutoSize = True
        Me.lblAvaliador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAvaliador.Location = New System.Drawing.Point(12, 61)
        Me.lblAvaliador.Name = "lblAvaliador"
        Me.lblAvaliador.Size = New System.Drawing.Size(51, 13)
        Me.lblAvaliador.TabIndex = 11
        Me.lblAvaliador.Text = "Avaliador"
        '
        'lblpontosFortes
        '
        Me.lblpontosFortes.AutoSize = True
        Me.lblpontosFortes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpontosFortes.Location = New System.Drawing.Point(12, 105)
        Me.lblpontosFortes.Name = "lblpontosFortes"
        Me.lblpontosFortes.Size = New System.Drawing.Size(69, 13)
        Me.lblpontosFortes.TabIndex = 12
        Me.lblpontosFortes.Text = "Pontos fortes"
        '
        'txtPontosFortes
        '
        Me.txtPontosFortes.Location = New System.Drawing.Point(12, 121)
        Me.txtPontosFortes.Name = "txtPontosFortes"
        Me.txtPontosFortes.Size = New System.Drawing.Size(816, 20)
        Me.txtPontosFortes.TabIndex = 13
        '
        'lblPontosFracos
        '
        Me.lblPontosFracos.AutoSize = True
        Me.lblPontosFracos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPontosFracos.Location = New System.Drawing.Point(12, 148)
        Me.lblPontosFracos.Name = "lblPontosFracos"
        Me.lblPontosFracos.Size = New System.Drawing.Size(72, 13)
        Me.lblPontosFracos.TabIndex = 14
        Me.lblPontosFracos.Text = "Pontos fracos"
        '
        'txtPontosFracos
        '
        Me.txtPontosFracos.Location = New System.Drawing.Point(12, 164)
        Me.txtPontosFracos.Name = "txtPontosFracos"
        Me.txtPontosFracos.Size = New System.Drawing.Size(816, 20)
        Me.txtPontosFracos.TabIndex = 15
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNota.Location = New System.Drawing.Point(12, 194)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(30, 13)
        Me.lblNota.TabIndex = 16
        Me.lblNota.Text = "Nota"
        '
        'lblConceito
        '
        Me.lblConceito.AutoSize = True
        Me.lblConceito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblConceito.Location = New System.Drawing.Point(43, 194)
        Me.lblConceito.Name = "lblConceito"
        Me.lblConceito.Size = New System.Drawing.Size(65, 13)
        Me.lblConceito.TabIndex = 19
        Me.lblConceito.Text = "/  Avaliação"
        '
        'cboNota
        '
        Me.cboNota.FormattingEnabled = True
        Me.cboNota.Location = New System.Drawing.Point(12, 209)
        Me.cboNota.Name = "cboNota"
        Me.cboNota.Size = New System.Drawing.Size(93, 21)
        Me.cboNota.TabIndex = 20
        '
        'btnExcluir
        '
        Me.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExcluir.Location = New System.Drawing.Point(753, 206)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 22
        Me.btnExcluir.Text = "   Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvarT
        '
        Me.btnSalvarT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalvarT.Image = CType(resources.GetObject("btnSalvarT.Image"), System.Drawing.Image)
        Me.btnSalvarT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvarT.Location = New System.Drawing.Point(672, 206)
        Me.btnSalvarT.Name = "btnSalvarT"
        Me.btnSalvarT.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvarT.TabIndex = 21
        Me.btnSalvarT.Text = "   Salvar"
        Me.btnSalvarT.UseVisualStyleBackColor = True
        '
        'dtpDataAvaliacao
        '
        Me.dtpDataAvaliacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataAvaliacao.Location = New System.Drawing.Point(556, 209)
        Me.dtpDataAvaliacao.Name = "dtpDataAvaliacao"
        Me.dtpDataAvaliacao.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataAvaliacao.TabIndex = 23
        '
        'lblDataAvaliacao
        '
        Me.lblDataAvaliacao.AutoSize = True
        Me.lblDataAvaliacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataAvaliacao.Location = New System.Drawing.Point(553, 193)
        Me.lblDataAvaliacao.Name = "lblDataAvaliacao"
        Me.lblDataAvaliacao.Size = New System.Drawing.Size(80, 13)
        Me.lblDataAvaliacao.TabIndex = 24
        Me.lblDataAvaliacao.Text = "Data Avaliação"
        '
        'cboNomeEmpresa
        '
        Me.cboNomeEmpresa.FormattingEnabled = True
        Me.cboNomeEmpresa.Location = New System.Drawing.Point(358, 34)
        Me.cboNomeEmpresa.Name = "cboNomeEmpresa"
        Me.cboNomeEmpresa.Size = New System.Drawing.Size(190, 21)
        Me.cboNomeEmpresa.TabIndex = 25
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCodigo.Location = New System.Drawing.Point(12, 14)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 26
        Me.lblCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(12, 34)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(59, 20)
        Me.txtCodigo.TabIndex = 27
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(119, 209)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataInicial.TabIndex = 28
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(224, 209)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataFinal.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(116, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Período de Avaliação"
        '
        'dgvAvaliacoes
        '
        Me.dgvAvaliacoes.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvAvaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvaliacoes.Location = New System.Drawing.Point(10, 19)
        Me.dgvAvaliacoes.Name = "dgvAvaliacoes"
        Me.dgvAvaliacoes.Size = New System.Drawing.Size(804, 325)
        Me.dgvAvaliacoes.TabIndex = 31
        '
        'grbAvaliacoes
        '
        Me.grbAvaliacoes.Controls.Add(Me.dgvAvaliacoes)
        Me.grbAvaliacoes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grbAvaliacoes.Location = New System.Drawing.Point(12, 250)
        Me.grbAvaliacoes.Name = "grbAvaliacoes"
        Me.grbAvaliacoes.Size = New System.Drawing.Size(824, 356)
        Me.grbAvaliacoes.TabIndex = 32
        Me.grbAvaliacoes.TabStop = False
        Me.grbAvaliacoes.Text = "Avalições realizadas"
        '
        'FrmTerceiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 618)
        Me.Controls.Add(Me.grbAvaliacoes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDataFinal)
        Me.Controls.Add(Me.dtpDataInicial)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.cboNomeEmpresa)
        Me.Controls.Add(Me.lblDataAvaliacao)
        Me.Controls.Add(Me.dtpDataAvaliacao)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvarT)
        Me.Controls.Add(Me.cboNota)
        Me.Controls.Add(Me.lblConceito)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.txtPontosFracos)
        Me.Controls.Add(Me.lblPontosFracos)
        Me.Controls.Add(Me.txtPontosFortes)
        Me.Controls.Add(Me.lblpontosFortes)
        Me.Controls.Add(Me.lblAvaliador)
        Me.Controls.Add(Me.cboAvaliador)
        Me.Controls.Add(Me.cboLiderDireto)
        Me.Controls.Add(Me.lblLiderDireto)
        Me.Controls.Add(Me.lblAreaAtuacao)
        Me.Controls.Add(Me.cboAreaAtuacao)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.lblNomeFuncionario)
        Me.Controls.Add(Me.cboNomeFuncionario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTerceiros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avaliação terceirizados"
        CType(Me.dgvAvaliacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAvaliacoes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboNomeFuncionario As ComboBox
    Friend WithEvents lblNomeFuncionario As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents lblPeriodo As Label
    Friend WithEvents cboPeriodo As ComboBox
    Friend WithEvents cboAreaAtuacao As ComboBox
    Friend WithEvents lblAreaAtuacao As Label
    Friend WithEvents lblLiderDireto As Label
    Friend WithEvents cboLiderDireto As ComboBox
    Friend WithEvents cboAvaliador As ComboBox
    Friend WithEvents lblAvaliador As Label
    Friend WithEvents lblpontosFortes As Label
    Friend WithEvents txtPontosFortes As TextBox
    Friend WithEvents lblPontosFracos As Label
    Friend WithEvents txtPontosFracos As TextBox
    Friend WithEvents lblNota As Label
    Friend WithEvents lblConceito As Label
    Friend WithEvents cboNota As ComboBox
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvarT As Button
    Friend WithEvents dtpDataAvaliacao As DateTimePicker
    Friend WithEvents lblDataAvaliacao As Label
    Friend WithEvents cboNomeEmpresa As ComboBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents dtpDataInicial As DateTimePicker
    Friend WithEvents dtpDataFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvAvaliacoes As DataGridView
    Friend WithEvents grbAvaliacoes As GroupBox
End Class
