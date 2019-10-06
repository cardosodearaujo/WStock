<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgendamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgendamento))
        Me.txtNomeMotorista = New System.Windows.Forms.TextBox()
        Me.lblNomeMotorista = New System.Windows.Forms.Label()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.txtNFE = New System.Windows.Forms.TextBox()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.dtpAgendamento = New System.Windows.Forms.DateTimePicker()
        Me.lblDataAgendamento = New System.Windows.Forms.Label()
        Me.txtOrigem = New System.Windows.Forms.TextBox()
        Me.lblOrigem = New System.Windows.Forms.Label()
        Me.txtQtdPallet = New System.Windows.Forms.TextBox()
        Me.lblQtdPallet = New System.Windows.Forms.Label()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.lblDataCancelamento = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSaida = New System.Windows.Forms.Button()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.nswTipoVeiculo = New WStock.NewSearchWindow()
        Me.nswTipoCarga = New WStock.NewSearchWindow()
        Me.nswTipoPallet = New WStock.NewSearchWindow()
        Me.nswTipoAgendamento = New WStock.NewSearchWindow()
        Me.nswEmpresa = New WStock.NewSearchWindow()
        Me.nswTransportador = New WStock.NewSearchWindow()
        Me.dtpCancelamento = New System.Windows.Forms.TextBox()
        Me.dtpEntrada = New System.Windows.Forms.TextBox()
        Me.lblDataEntrada = New System.Windows.Forms.Label()
        Me.dtpSaida = New System.Windows.Forms.TextBox()
        Me.lblDataSaida = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNomeMotorista
        '
        Me.txtNomeMotorista.Location = New System.Drawing.Point(14, 225)
        Me.txtNomeMotorista.Name = "txtNomeMotorista"
        Me.txtNomeMotorista.Size = New System.Drawing.Size(323, 20)
        Me.txtNomeMotorista.TabIndex = 2
        '
        'lblNomeMotorista
        '
        Me.lblNomeMotorista.AutoSize = True
        Me.lblNomeMotorista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNomeMotorista.Location = New System.Drawing.Point(17, 210)
        Me.lblNomeMotorista.Name = "lblNomeMotorista"
        Me.lblNomeMotorista.Size = New System.Drawing.Size(80, 13)
        Me.lblNomeMotorista.TabIndex = 3
        Me.lblNomeMotorista.Text = "Nome motorista"
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNotaFiscal.Location = New System.Drawing.Point(17, 169)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(31, 13)
        Me.lblNotaFiscal.TabIndex = 4
        Me.lblNotaFiscal.Text = "NFe*"
        '
        'txtNFE
        '
        Me.txtNFE.Location = New System.Drawing.Point(14, 184)
        Me.txtNFE.Name = "txtNFE"
        Me.txtNFE.Size = New System.Drawing.Size(159, 20)
        Me.txtNFE.TabIndex = 5
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(344, 225)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(323, 20)
        Me.txtObservacao.TabIndex = 9
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblObservacao.Location = New System.Drawing.Point(347, 209)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(65, 13)
        Me.lblObservacao.TabIndex = 8
        Me.lblObservacao.Text = "Observação"
        '
        'dtpAgendamento
        '
        Me.dtpAgendamento.CalendarForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpAgendamento.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.dtpAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAgendamento.Location = New System.Drawing.Point(81, 22)
        Me.dtpAgendamento.Name = "dtpAgendamento"
        Me.dtpAgendamento.Size = New System.Drawing.Size(126, 20)
        Me.dtpAgendamento.TabIndex = 17
        '
        'lblDataAgendamento
        '
        Me.lblDataAgendamento.AutoSize = True
        Me.lblDataAgendamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataAgendamento.Location = New System.Drawing.Point(84, 6)
        Me.lblDataAgendamento.Name = "lblDataAgendamento"
        Me.lblDataAgendamento.Size = New System.Drawing.Size(102, 13)
        Me.lblDataAgendamento.TabIndex = 18
        Me.lblDataAgendamento.Text = "Data agendamento*"
        '
        'txtOrigem
        '
        Me.txtOrigem.Location = New System.Drawing.Point(344, 184)
        Me.txtOrigem.Name = "txtOrigem"
        Me.txtOrigem.Size = New System.Drawing.Size(159, 20)
        Me.txtOrigem.TabIndex = 28
        '
        'lblOrigem
        '
        Me.lblOrigem.AutoSize = True
        Me.lblOrigem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOrigem.Location = New System.Drawing.Point(347, 168)
        Me.lblOrigem.Name = "lblOrigem"
        Me.lblOrigem.Size = New System.Drawing.Size(40, 13)
        Me.lblOrigem.TabIndex = 27
        Me.lblOrigem.Text = "Origem"
        '
        'txtQtdPallet
        '
        Me.txtQtdPallet.Location = New System.Drawing.Point(178, 184)
        Me.txtQtdPallet.Name = "txtQtdPallet"
        Me.txtQtdPallet.Size = New System.Drawing.Size(159, 20)
        Me.txtQtdPallet.TabIndex = 32
        '
        'lblQtdPallet
        '
        Me.lblQtdPallet.AutoSize = True
        Me.lblQtdPallet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblQtdPallet.Location = New System.Drawing.Point(181, 168)
        Me.lblQtdPallet.Name = "lblQtdPallet"
        Me.lblQtdPallet.Size = New System.Drawing.Size(94, 13)
        Me.lblQtdPallet.TabIndex = 31
        Me.lblQtdPallet.Text = "Quantidade pallet*"
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDestino.Location = New System.Drawing.Point(511, 168)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(43, 13)
        Me.lblDestino.TabIndex = 34
        Me.lblDestino.Text = "Destino"
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(508, 184)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(159, 20)
        Me.txtDestino.TabIndex = 35
        '
        'lblDataCancelamento
        '
        Me.lblDataCancelamento.AutoSize = True
        Me.lblDataCancelamento.Enabled = False
        Me.lblDataCancelamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataCancelamento.Location = New System.Drawing.Point(478, 6)
        Me.lblDataCancelamento.Name = "lblDataCancelamento"
        Me.lblDataCancelamento.Size = New System.Drawing.Size(100, 13)
        Me.lblDataCancelamento.TabIndex = 38
        Me.lblDataCancelamento.Text = "Data cancelamento"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(14, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodigo.TabIndex = 39
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCodigo.Location = New System.Drawing.Point(17, 6)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 40
        Me.lblCodigo.Text = "Código"
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(572, 256)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 29)
        Me.btnCancelar.TabIndex = 47
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSaida
        '
        Me.btnSaida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSaida.Image = CType(resources.GetObject("btnSaida.Image"), System.Drawing.Image)
        Me.btnSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaida.Location = New System.Drawing.Point(216, 256)
        Me.btnSaida.Name = "btnSaida"
        Me.btnSaida.Size = New System.Drawing.Size(95, 29)
        Me.btnSaida.TabIndex = 15
        Me.btnSaida.Text = "Saída"
        Me.btnSaida.UseVisualStyleBackColor = True
        '
        'btnEntrada
        '
        Me.btnEntrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEntrada.Image = CType(resources.GetObject("btnEntrada.Image"), System.Drawing.Image)
        Me.btnEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrada.Location = New System.Drawing.Point(115, 256)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(95, 29)
        Me.btnEntrada.TabIndex = 14
        Me.btnEntrada.Text = "Entrada"
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalvar.Image = Global.WStock.My.Resources.Resources.floppy_disk
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(14, 256)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(95, 29)
        Me.btnSalvar.TabIndex = 12
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'nswTipoVeiculo
        '
        Me.nswTipoVeiculo.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoVeiculo.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoVeiculo.Codigo = Nothing
        Me.nswTipoVeiculo.Descricao = Nothing
        Me.nswTipoVeiculo.ListaColunas = Nothing
        Me.nswTipoVeiculo.Location = New System.Drawing.Point(339, 124)
        Me.nswTipoVeiculo.Name = "nswTipoVeiculo"
        Me.nswTipoVeiculo.OrderBy = Nothing
        Me.nswTipoVeiculo.Size = New System.Drawing.Size(332, 41)
        Me.nswTipoVeiculo.Tabela = Nothing
        Me.nswTipoVeiculo.TabIndex = 46
        Me.nswTipoVeiculo.Titulo = "Tipo de veículo*"
        Me.nswTipoVeiculo.Where = Nothing
        '
        'nswTipoCarga
        '
        Me.nswTipoCarga.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoCarga.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoCarga.Codigo = Nothing
        Me.nswTipoCarga.Descricao = Nothing
        Me.nswTipoCarga.ListaColunas = Nothing
        Me.nswTipoCarga.Location = New System.Drawing.Point(339, 83)
        Me.nswTipoCarga.Name = "nswTipoCarga"
        Me.nswTipoCarga.OrderBy = Nothing
        Me.nswTipoCarga.Size = New System.Drawing.Size(332, 41)
        Me.nswTipoCarga.Tabela = Nothing
        Me.nswTipoCarga.TabIndex = 45
        Me.nswTipoCarga.Titulo = "Tipo de carga*"
        Me.nswTipoCarga.Where = Nothing
        '
        'nswTipoPallet
        '
        Me.nswTipoPallet.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoPallet.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoPallet.Codigo = Nothing
        Me.nswTipoPallet.Descricao = Nothing
        Me.nswTipoPallet.ListaColunas = Nothing
        Me.nswTipoPallet.Location = New System.Drawing.Point(339, 43)
        Me.nswTipoPallet.Name = "nswTipoPallet"
        Me.nswTipoPallet.OrderBy = Nothing
        Me.nswTipoPallet.Size = New System.Drawing.Size(332, 41)
        Me.nswTipoPallet.Tabela = Nothing
        Me.nswTipoPallet.TabIndex = 44
        Me.nswTipoPallet.Titulo = "Tipo de pallet*"
        Me.nswTipoPallet.Where = Nothing
        '
        'nswTipoAgendamento
        '
        Me.nswTipoAgendamento.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoAgendamento.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoAgendamento.Codigo = Nothing
        Me.nswTipoAgendamento.Descricao = Nothing
        Me.nswTipoAgendamento.ListaColunas = Nothing
        Me.nswTipoAgendamento.Location = New System.Drawing.Point(9, 124)
        Me.nswTipoAgendamento.Name = "nswTipoAgendamento"
        Me.nswTipoAgendamento.OrderBy = Nothing
        Me.nswTipoAgendamento.Size = New System.Drawing.Size(328, 41)
        Me.nswTipoAgendamento.Tabela = Nothing
        Me.nswTipoAgendamento.TabIndex = 43
        Me.nswTipoAgendamento.Titulo = "Tipo de agendamento*"
        Me.nswTipoAgendamento.Where = Nothing
        '
        'nswEmpresa
        '
        Me.nswEmpresa.CampoCodigoTabelaRetono = ""
        Me.nswEmpresa.CampoDescricaoTabelaRetono = ""
        Me.nswEmpresa.Codigo = Nothing
        Me.nswEmpresa.Descricao = Nothing
        Me.nswEmpresa.ListaColunas = Nothing
        Me.nswEmpresa.Location = New System.Drawing.Point(9, 83)
        Me.nswEmpresa.Name = "nswEmpresa"
        Me.nswEmpresa.OrderBy = Nothing
        Me.nswEmpresa.Size = New System.Drawing.Size(328, 41)
        Me.nswEmpresa.Tabela = ""
        Me.nswEmpresa.TabIndex = 42
        Me.nswEmpresa.Titulo = "Empresa*"
        Me.nswEmpresa.Where = Nothing
        '
        'nswTransportador
        '
        Me.nswTransportador.CampoCodigoTabelaRetono = Nothing
        Me.nswTransportador.CampoDescricaoTabelaRetono = Nothing
        Me.nswTransportador.Codigo = Nothing
        Me.nswTransportador.Descricao = Nothing
        Me.nswTransportador.ListaColunas = Nothing
        Me.nswTransportador.Location = New System.Drawing.Point(9, 43)
        Me.nswTransportador.Name = "nswTransportador"
        Me.nswTransportador.OrderBy = Nothing
        Me.nswTransportador.Size = New System.Drawing.Size(328, 41)
        Me.nswTransportador.Tabela = Nothing
        Me.nswTransportador.TabIndex = 41
        Me.nswTransportador.Titulo = "Transportador*"
        Me.nswTransportador.Where = Nothing
        '
        'dtpDataCancelamento
        '
        Me.dtpCancelamento.Enabled = False
        Me.dtpCancelamento.Location = New System.Drawing.Point(475, 22)
        Me.dtpCancelamento.Name = "dtpDataCancelamento"
        Me.dtpCancelamento.ReadOnly = True
        Me.dtpCancelamento.Size = New System.Drawing.Size(126, 20)
        Me.dtpCancelamento.TabIndex = 48
        '
        'txtDataEntrada
        '
        Me.dtpEntrada.Enabled = False
        Me.dtpEntrada.Location = New System.Drawing.Point(211, 22)
        Me.dtpEntrada.Name = "txtDataEntrada"
        Me.dtpEntrada.ReadOnly = True
        Me.dtpEntrada.Size = New System.Drawing.Size(126, 20)
        Me.dtpEntrada.TabIndex = 50
        '
        'lblDataEntrada
        '
        Me.lblDataEntrada.AutoSize = True
        Me.lblDataEntrada.Enabled = False
        Me.lblDataEntrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataEntrada.Location = New System.Drawing.Point(215, 6)
        Me.lblDataEntrada.Name = "lblDataEntrada"
        Me.lblDataEntrada.Size = New System.Drawing.Size(69, 13)
        Me.lblDataEntrada.TabIndex = 49
        Me.lblDataEntrada.Text = "Data entrada"
        '
        'txtDataSaida
        '
        Me.dtpSaida.Enabled = False
        Me.dtpSaida.Location = New System.Drawing.Point(343, 22)
        Me.dtpSaida.Name = "txtDataSaida"
        Me.dtpSaida.ReadOnly = True
        Me.dtpSaida.Size = New System.Drawing.Size(126, 20)
        Me.dtpSaida.TabIndex = 52
        '
        'lblDataSaida
        '
        Me.lblDataSaida.AutoSize = True
        Me.lblDataSaida.Enabled = False
        Me.lblDataSaida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataSaida.Location = New System.Drawing.Point(346, 6)
        Me.lblDataSaida.Name = "lblDataSaida"
        Me.lblDataSaida.Size = New System.Drawing.Size(58, 13)
        Me.lblDataSaida.TabIndex = 51
        Me.lblDataSaida.Text = "Data saida"
        '
        'FrmAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 292)
        Me.Controls.Add(Me.dtpSaida)
        Me.Controls.Add(Me.lblDataSaida)
        Me.Controls.Add(Me.dtpEntrada)
        Me.Controls.Add(Me.lblDataEntrada)
        Me.Controls.Add(Me.dtpCancelamento)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.nswTipoVeiculo)
        Me.Controls.Add(Me.nswTipoCarga)
        Me.Controls.Add(Me.nswTipoPallet)
        Me.Controls.Add(Me.nswTipoAgendamento)
        Me.Controls.Add(Me.nswEmpresa)
        Me.Controls.Add(Me.nswTransportador)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblDataCancelamento)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.txtQtdPallet)
        Me.Controls.Add(Me.lblQtdPallet)
        Me.Controls.Add(Me.txtOrigem)
        Me.Controls.Add(Me.lblOrigem)
        Me.Controls.Add(Me.lblDataAgendamento)
        Me.Controls.Add(Me.dtpAgendamento)
        Me.Controls.Add(Me.btnSaida)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.lblObservacao)
        Me.Controls.Add(Me.txtNFE)
        Me.Controls.Add(Me.lblNotaFiscal)
        Me.Controls.Add(Me.lblNomeMotorista)
        Me.Controls.Add(Me.txtNomeMotorista)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAgendamento"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agendamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomeMotorista As TextBox
    Friend WithEvents lblNomeMotorista As Label
    Friend WithEvents lblNotaFiscal As Label
    Friend WithEvents txtNFE As TextBox
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents lblObservacao As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnSaida As Button
    Friend WithEvents btnEntrada As Button
    Friend WithEvents dtpAgendamento As DateTimePicker
    Friend WithEvents lblDataAgendamento As Label
    Friend WithEvents txtOrigem As TextBox
    Friend WithEvents lblOrigem As Label
    Friend WithEvents txtQtdPallet As TextBox
    Friend WithEvents lblQtdPallet As Label
    Friend WithEvents lblDestino As Label
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents lblDataCancelamento As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents nswTransportador As NewSearchWindow
    Friend WithEvents nswEmpresa As NewSearchWindow
    Friend WithEvents nswTipoAgendamento As NewSearchWindow
    Friend WithEvents nswTipoPallet As NewSearchWindow
    Friend WithEvents nswTipoCarga As NewSearchWindow
    Friend WithEvents nswTipoVeiculo As NewSearchWindow
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dtpCancelamento As TextBox
    Friend WithEvents dtpEntrada As TextBox
    Friend WithEvents lblDataEntrada As Label
    Friend WithEvents dtpSaida As TextBox
    Friend WithEvents lblDataSaida As Label
End Class
