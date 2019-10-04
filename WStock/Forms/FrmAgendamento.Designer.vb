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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblObservacaoAgenda = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnSaida = New System.Windows.Forms.Button()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.dtpAgendamento = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpCancelamento = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nswTipoVeiculo = New WStock.NewSearchWindow()
        Me.nswTipoCarga = New WStock.NewSearchWindow()
        Me.nswTipoPallet = New WStock.NewSearchWindow()
        Me.nswTipoAgendamento = New WStock.NewSearchWindow()
        Me.nswEmpresa = New WStock.NewSearchWindow()
        Me.nswTransportador = New WStock.NewSearchWindow()
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
        Me.lblNotaFiscal.Size = New System.Drawing.Size(27, 13)
        Me.lblNotaFiscal.TabIndex = 4
        Me.lblNotaFiscal.Text = "NFe"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 184)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(344, 225)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(323, 20)
        Me.TextBox2.TabIndex = 9
        '
        'lblObservacaoAgenda
        '
        Me.lblObservacaoAgenda.AutoSize = True
        Me.lblObservacaoAgenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblObservacaoAgenda.Location = New System.Drawing.Point(347, 209)
        Me.lblObservacaoAgenda.Name = "lblObservacaoAgenda"
        Me.lblObservacaoAgenda.Size = New System.Drawing.Size(65, 13)
        Me.lblObservacaoAgenda.TabIndex = 8
        Me.lblObservacaoAgenda.Text = "Observação"
        '
        'btnSalvar
        '
        Me.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(14, 256)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(95, 29)
        Me.btnSalvar.TabIndex = 12
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
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
        'btnLiberar
        '
        Me.btnLiberar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLiberar.Image = CType(resources.GetObject("btnLiberar.Image"), System.Drawing.Image)
        Me.btnLiberar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLiberar.Location = New System.Drawing.Point(115, 256)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(95, 29)
        Me.btnLiberar.TabIndex = 14
        Me.btnLiberar.Text = "Entrada"
        Me.btnLiberar.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(84, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Data agendamento"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(344, 184)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(159, 20)
        Me.TextBox4.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(347, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Origem"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(178, 184)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(159, 20)
        Me.TextBox6.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(181, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Quantidade pallet"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(506, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Destino"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(508, 184)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(159, 20)
        Me.TextBox5.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(214, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Data cancelamento"
        '
        'dtpCancelamento
        '
        Me.dtpCancelamento.CalendarForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpCancelamento.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.dtpCancelamento.Enabled = False
        Me.dtpCancelamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCancelamento.Location = New System.Drawing.Point(211, 22)
        Me.dtpCancelamento.Name = "dtpCancelamento"
        Me.dtpCancelamento.Size = New System.Drawing.Size(126, 20)
        Me.dtpCancelamento.TabIndex = 37
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(14, 22)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(64, 20)
        Me.TextBox3.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(17, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Código"
        '
        'nswTipoVeiculo
        '
        Me.nswTipoVeiculo.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoVeiculo.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoVeiculo.ListaColunas = Nothing
        Me.nswTipoVeiculo.Location = New System.Drawing.Point(339, 124)
        Me.nswTipoVeiculo.Name = "nswTipoVeiculo"
        Me.nswTipoVeiculo.OrderBy = Nothing
        Me.nswTipoVeiculo.Size = New System.Drawing.Size(332, 41)
        Me.nswTipoVeiculo.Tabela = Nothing
        Me.nswTipoVeiculo.TabIndex = 46
        Me.nswTipoVeiculo.Titulo = "Tipo de veículo"
        Me.nswTipoVeiculo.Where = Nothing
        '
        'nswTipoCarga
        '
        Me.nswTipoCarga.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoCarga.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoCarga.ListaColunas = Nothing
        Me.nswTipoCarga.Location = New System.Drawing.Point(339, 83)
        Me.nswTipoCarga.Name = "nswTipoCarga"
        Me.nswTipoCarga.OrderBy = Nothing
        Me.nswTipoCarga.Size = New System.Drawing.Size(332, 41)
        Me.nswTipoCarga.Tabela = Nothing
        Me.nswTipoCarga.TabIndex = 45
        Me.nswTipoCarga.Titulo = "Tipo de carga"
        Me.nswTipoCarga.Where = Nothing
        '
        'nswTipoPallet
        '
        Me.nswTipoPallet.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoPallet.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoPallet.ListaColunas = Nothing
        Me.nswTipoPallet.Location = New System.Drawing.Point(339, 43)
        Me.nswTipoPallet.Name = "nswTipoPallet"
        Me.nswTipoPallet.OrderBy = Nothing
        Me.nswTipoPallet.Size = New System.Drawing.Size(332, 41)
        Me.nswTipoPallet.Tabela = Nothing
        Me.nswTipoPallet.TabIndex = 44
        Me.nswTipoPallet.Titulo = "Tipo de pallet"
        Me.nswTipoPallet.Where = Nothing
        '
        'nswTipoAgendamento
        '
        Me.nswTipoAgendamento.CampoCodigoTabelaRetono = Nothing
        Me.nswTipoAgendamento.CampoDescricaoTabelaRetono = Nothing
        Me.nswTipoAgendamento.ListaColunas = Nothing
        Me.nswTipoAgendamento.Location = New System.Drawing.Point(9, 124)
        Me.nswTipoAgendamento.Name = "nswTipoAgendamento"
        Me.nswTipoAgendamento.OrderBy = Nothing
        Me.nswTipoAgendamento.Size = New System.Drawing.Size(328, 41)
        Me.nswTipoAgendamento.Tabela = Nothing
        Me.nswTipoAgendamento.TabIndex = 43
        Me.nswTipoAgendamento.Titulo = "Tipo de agendamento"
        Me.nswTipoAgendamento.Where = Nothing
        '
        'nswEmpresa
        '
        Me.nswEmpresa.CampoCodigoTabelaRetono = ""
        Me.nswEmpresa.CampoDescricaoTabelaRetono = ""
        Me.nswEmpresa.ListaColunas = Nothing
        Me.nswEmpresa.Location = New System.Drawing.Point(9, 83)
        Me.nswEmpresa.Name = "nswEmpresa"
        Me.nswEmpresa.OrderBy = Nothing
        Me.nswEmpresa.Size = New System.Drawing.Size(328, 41)
        Me.nswEmpresa.Tabela = ""
        Me.nswEmpresa.TabIndex = 42
        Me.nswEmpresa.Titulo = "Empresa"
        Me.nswEmpresa.Where = Nothing
        '
        'nswTransportador
        '
        Me.nswTransportador.CampoCodigoTabelaRetono = Nothing
        Me.nswTransportador.CampoDescricaoTabelaRetono = Nothing
        Me.nswTransportador.ListaColunas = Nothing
        Me.nswTransportador.Location = New System.Drawing.Point(9, 43)
        Me.nswTransportador.Name = "nswTransportador"
        Me.nswTransportador.OrderBy = Nothing
        Me.nswTransportador.Size = New System.Drawing.Size(328, 41)
        Me.nswTransportador.Tabela = Nothing
        Me.nswTransportador.TabIndex = 41
        Me.nswTransportador.Titulo = "Transportador"
        Me.nswTransportador.Where = Nothing
        '
        'FrmAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 292)
        Me.Controls.Add(Me.nswTipoVeiculo)
        Me.Controls.Add(Me.nswTipoCarga)
        Me.Controls.Add(Me.nswTipoPallet)
        Me.Controls.Add(Me.nswTipoAgendamento)
        Me.Controls.Add(Me.nswEmpresa)
        Me.Controls.Add(Me.nswTransportador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpCancelamento)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAgendamento)
        Me.Controls.Add(Me.btnSaida)
        Me.Controls.Add(Me.btnLiberar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblObservacaoAgenda)
        Me.Controls.Add(Me.TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblObservacaoAgenda As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnSaida As Button
    Friend WithEvents btnLiberar As Button
    Friend WithEvents dtpAgendamento As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpCancelamento As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nswTransportador As NewSearchWindow
    Friend WithEvents nswEmpresa As NewSearchWindow
    Friend WithEvents nswTipoAgendamento As NewSearchWindow
    Friend WithEvents nswTipoPallet As NewSearchWindow
    Friend WithEvents nswTipoCarga As NewSearchWindow
    Friend WithEvents nswTipoVeiculo As NewSearchWindow
End Class
