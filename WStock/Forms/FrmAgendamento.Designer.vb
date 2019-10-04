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
        Me.lblTransportador = New System.Windows.Forms.Label()
        Me.cboTransportadora = New System.Windows.Forms.ComboBox()
        Me.txtNomeMotorista = New System.Windows.Forms.TextBox()
        Me.lblNomeMotorista = New System.Windows.Forms.Label()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.lblEmpresaAgenda = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblObservacaoAgenda = New System.Windows.Forms.Label()
        Me.cboTipoAgendamento = New System.Windows.Forms.ComboBox()
        Me.lblTipoAgendamento = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnSaida = New System.Windows.Forms.Button()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.dtpAgendamento = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoVeiculo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboTipopPallet = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.cboTipoCarga = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpCancelamento = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTransportador
        '
        Me.lblTransportador.AutoSize = True
        Me.lblTransportador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTransportador.Location = New System.Drawing.Point(19, 50)
        Me.lblTransportador.Name = "lblTransportador"
        Me.lblTransportador.Size = New System.Drawing.Size(79, 13)
        Me.lblTransportador.TabIndex = 0
        Me.lblTransportador.Text = "Transportadora"
        '
        'cboTransportadora
        '
        Me.cboTransportadora.FormattingEnabled = True
        Me.cboTransportadora.Location = New System.Drawing.Point(16, 66)
        Me.cboTransportadora.Name = "cboTransportadora"
        Me.cboTransportadora.Size = New System.Drawing.Size(297, 21)
        Me.cboTransportadora.TabIndex = 1
        '
        'txtNomeMotorista
        '
        Me.txtNomeMotorista.Location = New System.Drawing.Point(322, 107)
        Me.txtNomeMotorista.Name = "txtNomeMotorista"
        Me.txtNomeMotorista.Size = New System.Drawing.Size(297, 20)
        Me.txtNomeMotorista.TabIndex = 2
        '
        'lblNomeMotorista
        '
        Me.lblNomeMotorista.AutoSize = True
        Me.lblNomeMotorista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNomeMotorista.Location = New System.Drawing.Point(325, 92)
        Me.lblNomeMotorista.Name = "lblNomeMotorista"
        Me.lblNomeMotorista.Size = New System.Drawing.Size(80, 13)
        Me.lblNomeMotorista.TabIndex = 3
        Me.lblNomeMotorista.Text = "Nome motorista"
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNotaFiscal.Location = New System.Drawing.Point(325, 51)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(27, 13)
        Me.lblNotaFiscal.TabIndex = 4
        Me.lblNotaFiscal.Text = "NFe"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(322, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(297, 20)
        Me.TextBox1.TabIndex = 5
        '
        'cboEmpresa
        '
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(16, 107)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(297, 21)
        Me.cboEmpresa.TabIndex = 7
        '
        'lblEmpresaAgenda
        '
        Me.lblEmpresaAgenda.AutoSize = True
        Me.lblEmpresaAgenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEmpresaAgenda.Location = New System.Drawing.Point(19, 91)
        Me.lblEmpresaAgenda.Name = "lblEmpresaAgenda"
        Me.lblEmpresaAgenda.Size = New System.Drawing.Size(48, 13)
        Me.lblEmpresaAgenda.TabIndex = 6
        Me.lblEmpresaAgenda.Text = "Empresa"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(322, 149)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(297, 20)
        Me.TextBox2.TabIndex = 9
        '
        'lblObservacaoAgenda
        '
        Me.lblObservacaoAgenda.AutoSize = True
        Me.lblObservacaoAgenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblObservacaoAgenda.Location = New System.Drawing.Point(325, 133)
        Me.lblObservacaoAgenda.Name = "lblObservacaoAgenda"
        Me.lblObservacaoAgenda.Size = New System.Drawing.Size(65, 13)
        Me.lblObservacaoAgenda.TabIndex = 8
        Me.lblObservacaoAgenda.Text = "Observação"
        '
        'cboTipoAgendamento
        '
        Me.cboTipoAgendamento.FormattingEnabled = True
        Me.cboTipoAgendamento.Location = New System.Drawing.Point(16, 149)
        Me.cboTipoAgendamento.Name = "cboTipoAgendamento"
        Me.cboTipoAgendamento.Size = New System.Drawing.Size(297, 21)
        Me.cboTipoAgendamento.TabIndex = 11
        '
        'lblTipoAgendamento
        '
        Me.lblTipoAgendamento.AutoSize = True
        Me.lblTipoAgendamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTipoAgendamento.Location = New System.Drawing.Point(19, 133)
        Me.lblTipoAgendamento.Name = "lblTipoAgendamento"
        Me.lblTipoAgendamento.Size = New System.Drawing.Size(96, 13)
        Me.lblTipoAgendamento.TabIndex = 10
        Me.lblTipoAgendamento.Text = "Tipo agendamento"
        '
        'btnSalvar
        '
        Me.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(15, 279)
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
        Me.btnSaida.Location = New System.Drawing.Point(217, 279)
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
        Me.btnLiberar.Location = New System.Drawing.Point(116, 279)
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
        Me.dtpAgendamento.Location = New System.Drawing.Point(16, 244)
        Me.dtpAgendamento.Name = "dtpAgendamento"
        Me.dtpAgendamento.Size = New System.Drawing.Size(142, 20)
        Me.dtpAgendamento.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(19, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Data agendamento"
        '
        'cboTipoVeiculo
        '
        Me.cboTipoVeiculo.FormattingEnabled = True
        Me.cboTipoVeiculo.Location = New System.Drawing.Point(461, 243)
        Me.cboTipoVeiculo.Name = "cboTipoVeiculo"
        Me.cboTipoVeiculo.Size = New System.Drawing.Size(158, 21)
        Me.cboTipoVeiculo.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(324, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tipo carga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(464, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Tipo veículo"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(15, 194)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(143, 20)
        Me.TextBox4.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(18, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Origem"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(325, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Tipo de pallet"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(461, 195)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(158, 20)
        Me.TextBox6.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(464, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Quantidade pallet"
        '
        'cboTipopPallet
        '
        Me.cboTipopPallet.FormattingEnabled = True
        Me.cboTipopPallet.Location = New System.Drawing.Point(322, 195)
        Me.cboTipopPallet.Name = "cboTipopPallet"
        Me.cboTipopPallet.Size = New System.Drawing.Size(133, 21)
        Me.cboTipopPallet.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(167, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Destino"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(164, 194)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(149, 20)
        Me.TextBox5.TabIndex = 35
        '
        'cboTipoCarga
        '
        Me.cboTipoCarga.FormattingEnabled = True
        Me.cboTipoCarga.Location = New System.Drawing.Point(321, 243)
        Me.cboTipoCarga.Name = "cboTipoCarga"
        Me.cboTipoCarga.Size = New System.Drawing.Size(134, 21)
        Me.cboTipoCarga.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(167, 228)
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
        Me.dtpCancelamento.Location = New System.Drawing.Point(164, 244)
        Me.dtpCancelamento.Name = "dtpCancelamento"
        Me.dtpCancelamento.Size = New System.Drawing.Size(149, 20)
        Me.dtpCancelamento.TabIndex = 37
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(16, 23)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(82, 20)
        Me.TextBox3.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(19, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Código"
        '
        'FrmAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 317)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpCancelamento)
        Me.Controls.Add(Me.cboTipoCarga)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboTipopPallet)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboTipoVeiculo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAgendamento)
        Me.Controls.Add(Me.btnSaida)
        Me.Controls.Add(Me.btnLiberar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.cboTipoAgendamento)
        Me.Controls.Add(Me.lblTipoAgendamento)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblObservacaoAgenda)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.lblEmpresaAgenda)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNotaFiscal)
        Me.Controls.Add(Me.lblNomeMotorista)
        Me.Controls.Add(Me.txtNomeMotorista)
        Me.Controls.Add(Me.cboTransportadora)
        Me.Controls.Add(Me.lblTransportador)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAgendamento"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agendamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTransportador As Label
    Friend WithEvents cboTransportadora As ComboBox
    Friend WithEvents txtNomeMotorista As TextBox
    Friend WithEvents lblNomeMotorista As Label
    Friend WithEvents lblNotaFiscal As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cboEmpresa As ComboBox
    Friend WithEvents lblEmpresaAgenda As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblObservacaoAgenda As Label
    Friend WithEvents cboTipoAgendamento As ComboBox
    Friend WithEvents lblTipoAgendamento As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnSaida As Button
    Friend WithEvents btnLiberar As Button
    Friend WithEvents dtpAgendamento As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cboTipoVeiculo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboTipopPallet As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents cboTipoCarga As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpCancelamento As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
End Class
