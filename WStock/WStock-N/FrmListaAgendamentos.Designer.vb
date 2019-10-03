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
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTpVeic = New System.Windows.Forms.Label()
        Me.txtCodTpVeic = New System.Windows.Forms.TextBox()
        Me.txtDscTpVeic = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblTpAgd = New System.Windows.Forms.Label()
        Me.txtCodTpAgd = New System.Windows.Forms.TextBox()
        Me.txtDscTpAgd = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblTpCarg = New System.Windows.Forms.Label()
        Me.txtCodTpCarg = New System.Windows.Forms.TextBox()
        Me.txtDscTpCarg = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblEmp = New System.Windows.Forms.Label()
        Me.txtCodEmp = New System.Windows.Forms.TextBox()
        Me.txtDscEmp = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblTpPall = New System.Windows.Forms.Label()
        Me.txtCodTpPall = New System.Windows.Forms.TextBox()
        Me.txtDscTpPall = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTrans = New System.Windows.Forms.Label()
        Me.txtCodTrans = New System.Windows.Forms.TextBox()
        Me.txtDscTrans = New System.Windows.Forms.TextBox()
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
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnLimpTpVeic = New System.Windows.Forms.Button()
        Me.btnPesqTpVeic = New System.Windows.Forms.Button()
        Me.btnLimpTpAgd = New System.Windows.Forms.Button()
        Me.btnPesqTpAgd = New System.Windows.Forms.Button()
        Me.btnLimpTpCarg = New System.Windows.Forms.Button()
        Me.btnPesqTpCarg = New System.Windows.Forms.Button()
        Me.btnLimpEmp = New System.Windows.Forms.Button()
        Me.btnPesqEmp = New System.Windows.Forms.Button()
        Me.btnLimpTpPall = New System.Windows.Forms.Button()
        Me.btnPesqTpPall = New System.Windows.Forms.Button()
        Me.btnLimpTrans = New System.Windows.Forms.Button()
        Me.btnPesqTrans = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Panel1MinSize = 10
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvAgendamentos)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(1217, 525)
        Me.SplitContainer1.SplitterDistance = 137
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.btnNovo)
        Me.Panel1.Controls.Add(Me.chkOcultarCancelados)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dtpAgendaAte)
        Me.Panel1.Controls.Add(Me.dtpAgendaDe)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtDestino)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtOrigem)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtQtdPallet)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtObservacao)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNomeMotorista)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNumNFe)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnPesquisar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1217, 137)
        Me.Panel1.TabIndex = 0
        '
        'chkOcultarCancelados
        '
        Me.chkOcultarCancelados.AutoSize = True
        Me.chkOcultarCancelados.Checked = True
        Me.chkOcultarCancelados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOcultarCancelados.Location = New System.Drawing.Point(955, 111)
        Me.chkOcultarCancelados.Name = "chkOcultarCancelados"
        Me.chkOcultarCancelados.Size = New System.Drawing.Size(118, 17)
        Me.chkOcultarCancelados.TabIndex = 27
        Me.chkOcultarCancelados.Text = "Ocultar cancelados"
        Me.chkOcultarCancelados.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(796, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Até"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(674, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Agendamento:"
        '
        'dtpAgendaAte
        '
        Me.dtpAgendaAte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAgendaAte.Location = New System.Drawing.Point(824, 108)
        Me.dtpAgendaAte.Name = "dtpAgendaAte"
        Me.dtpAgendaAte.Size = New System.Drawing.Size(120, 20)
        Me.dtpAgendaAte.TabIndex = 24
        '
        'dtpAgendaDe
        '
        Me.dtpAgendaDe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAgendaDe.Location = New System.Drawing.Point(671, 108)
        Me.dtpAgendaDe.Name = "dtpAgendaDe"
        Me.dtpAgendaDe.Size = New System.Drawing.Size(120, 20)
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
        Me.Label3.Location = New System.Drawing.Point(892, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(889, 64)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(215, 20)
        Me.txtObservacao.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(674, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nome do motorista:"
        '
        'txtNomeMotorista
        '
        Me.txtNomeMotorista.Location = New System.Drawing.Point(671, 64)
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnLimpTpVeic)
        Me.Panel5.Controls.Add(Me.lblTpVeic)
        Me.Panel5.Controls.Add(Me.btnPesqTpVeic)
        Me.Panel5.Controls.Add(Me.txtCodTpVeic)
        Me.Panel5.Controls.Add(Me.txtDscTpVeic)
        Me.Panel5.Location = New System.Drawing.Point(335, 90)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(330, 44)
        Me.Panel5.TabIndex = 11
        '
        'lblTpVeic
        '
        Me.lblTpVeic.AutoSize = True
        Me.lblTpVeic.Location = New System.Drawing.Point(6, 3)
        Me.lblTpVeic.Name = "lblTpVeic"
        Me.lblTpVeic.Size = New System.Drawing.Size(65, 13)
        Me.lblTpVeic.TabIndex = 5
        Me.lblTpVeic.Text = "Tipo veiculo"
        '
        'txtCodTpVeic
        '
        Me.txtCodTpVeic.Location = New System.Drawing.Point(3, 18)
        Me.txtCodTpVeic.Name = "txtCodTpVeic"
        Me.txtCodTpVeic.ReadOnly = True
        Me.txtCodTpVeic.Size = New System.Drawing.Size(64, 20)
        Me.txtCodTpVeic.TabIndex = 2
        '
        'txtDscTpVeic
        '
        Me.txtDscTpVeic.Location = New System.Drawing.Point(68, 18)
        Me.txtDscTpVeic.Name = "txtDscTpVeic"
        Me.txtDscTpVeic.ReadOnly = True
        Me.txtDscTpVeic.Size = New System.Drawing.Size(210, 20)
        Me.txtDscTpVeic.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnLimpTpAgd)
        Me.Panel4.Controls.Add(Me.lblTpAgd)
        Me.Panel4.Controls.Add(Me.btnPesqTpAgd)
        Me.Panel4.Controls.Add(Me.txtCodTpAgd)
        Me.Panel4.Controls.Add(Me.txtDscTpAgd)
        Me.Panel4.Location = New System.Drawing.Point(5, 90)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(330, 44)
        Me.Panel4.TabIndex = 8
        '
        'lblTpAgd
        '
        Me.lblTpAgd.AutoSize = True
        Me.lblTpAgd.Location = New System.Drawing.Point(6, 3)
        Me.lblTpAgd.Name = "lblTpAgd"
        Me.lblTpAgd.Size = New System.Drawing.Size(111, 13)
        Me.lblTpAgd.TabIndex = 5
        Me.lblTpAgd.Text = "Tipo de agendamento"
        '
        'txtCodTpAgd
        '
        Me.txtCodTpAgd.Location = New System.Drawing.Point(3, 18)
        Me.txtCodTpAgd.Name = "txtCodTpAgd"
        Me.txtCodTpAgd.ReadOnly = True
        Me.txtCodTpAgd.Size = New System.Drawing.Size(64, 20)
        Me.txtCodTpAgd.TabIndex = 2
        '
        'txtDscTpAgd
        '
        Me.txtDscTpAgd.Location = New System.Drawing.Point(68, 18)
        Me.txtDscTpAgd.Name = "txtDscTpAgd"
        Me.txtDscTpAgd.ReadOnly = True
        Me.txtDscTpAgd.Size = New System.Drawing.Size(210, 20)
        Me.txtDscTpAgd.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnLimpTpCarg)
        Me.Panel6.Controls.Add(Me.lblTpCarg)
        Me.Panel6.Controls.Add(Me.btnPesqTpCarg)
        Me.Panel6.Controls.Add(Me.txtCodTpCarg)
        Me.Panel6.Controls.Add(Me.txtDscTpCarg)
        Me.Panel6.Location = New System.Drawing.Point(335, 47)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(330, 44)
        Me.Panel6.TabIndex = 10
        '
        'lblTpCarg
        '
        Me.lblTpCarg.AutoSize = True
        Me.lblTpCarg.Location = New System.Drawing.Point(6, 3)
        Me.lblTpCarg.Name = "lblTpCarg"
        Me.lblTpCarg.Size = New System.Drawing.Size(58, 13)
        Me.lblTpCarg.TabIndex = 5
        Me.lblTpCarg.Text = "Tipo carga"
        '
        'txtCodTpCarg
        '
        Me.txtCodTpCarg.Location = New System.Drawing.Point(3, 18)
        Me.txtCodTpCarg.Name = "txtCodTpCarg"
        Me.txtCodTpCarg.ReadOnly = True
        Me.txtCodTpCarg.Size = New System.Drawing.Size(64, 20)
        Me.txtCodTpCarg.TabIndex = 2
        '
        'txtDscTpCarg
        '
        Me.txtDscTpCarg.Location = New System.Drawing.Point(68, 18)
        Me.txtDscTpCarg.Name = "txtDscTpCarg"
        Me.txtDscTpCarg.ReadOnly = True
        Me.txtDscTpCarg.Size = New System.Drawing.Size(210, 20)
        Me.txtDscTpCarg.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnLimpEmp)
        Me.Panel3.Controls.Add(Me.lblEmp)
        Me.Panel3.Controls.Add(Me.btnPesqEmp)
        Me.Panel3.Controls.Add(Me.txtCodEmp)
        Me.Panel3.Controls.Add(Me.txtDscEmp)
        Me.Panel3.Location = New System.Drawing.Point(5, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(330, 44)
        Me.Panel3.TabIndex = 7
        '
        'lblEmp
        '
        Me.lblEmp.AutoSize = True
        Me.lblEmp.Location = New System.Drawing.Point(6, 3)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(48, 13)
        Me.lblEmp.TabIndex = 5
        Me.lblEmp.Text = "Empresa"
        '
        'txtCodEmp
        '
        Me.txtCodEmp.Location = New System.Drawing.Point(3, 18)
        Me.txtCodEmp.Name = "txtCodEmp"
        Me.txtCodEmp.ReadOnly = True
        Me.txtCodEmp.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEmp.TabIndex = 2
        '
        'txtDscEmp
        '
        Me.txtDscEmp.Location = New System.Drawing.Point(68, 18)
        Me.txtDscEmp.Name = "txtDscEmp"
        Me.txtDscEmp.ReadOnly = True
        Me.txtDscEmp.Size = New System.Drawing.Size(210, 20)
        Me.txtDscEmp.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnLimpTpPall)
        Me.Panel7.Controls.Add(Me.lblTpPall)
        Me.Panel7.Controls.Add(Me.btnPesqTpPall)
        Me.Panel7.Controls.Add(Me.txtCodTpPall)
        Me.Panel7.Controls.Add(Me.txtDscTpPall)
        Me.Panel7.Location = New System.Drawing.Point(335, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(330, 44)
        Me.Panel7.TabIndex = 9
        '
        'lblTpPall
        '
        Me.lblTpPall.AutoSize = True
        Me.lblTpPall.Location = New System.Drawing.Point(6, 3)
        Me.lblTpPall.Name = "lblTpPall"
        Me.lblTpPall.Size = New System.Drawing.Size(56, 13)
        Me.lblTpPall.TabIndex = 5
        Me.lblTpPall.Text = "Tipo pallet"
        '
        'txtCodTpPall
        '
        Me.txtCodTpPall.Location = New System.Drawing.Point(3, 18)
        Me.txtCodTpPall.Name = "txtCodTpPall"
        Me.txtCodTpPall.ReadOnly = True
        Me.txtCodTpPall.Size = New System.Drawing.Size(64, 20)
        Me.txtCodTpPall.TabIndex = 2
        '
        'txtDscTpPall
        '
        Me.txtDscTpPall.Location = New System.Drawing.Point(68, 18)
        Me.txtDscTpPall.Name = "txtDscTpPall"
        Me.txtDscTpPall.ReadOnly = True
        Me.txtDscTpPall.Size = New System.Drawing.Size(210, 20)
        Me.txtDscTpPall.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnLimpTrans)
        Me.Panel2.Controls.Add(Me.lblTrans)
        Me.Panel2.Controls.Add(Me.btnPesqTrans)
        Me.Panel2.Controls.Add(Me.txtCodTrans)
        Me.Panel2.Controls.Add(Me.txtDscTrans)
        Me.Panel2.Location = New System.Drawing.Point(5, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 44)
        Me.Panel2.TabIndex = 4
        '
        'lblTrans
        '
        Me.lblTrans.AutoSize = True
        Me.lblTrans.Location = New System.Drawing.Point(6, 3)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(73, 13)
        Me.lblTrans.TabIndex = 5
        Me.lblTrans.Text = "Transportador"
        '
        'txtCodTrans
        '
        Me.txtCodTrans.Location = New System.Drawing.Point(3, 18)
        Me.txtCodTrans.Name = "txtCodTrans"
        Me.txtCodTrans.ReadOnly = True
        Me.txtCodTrans.Size = New System.Drawing.Size(64, 20)
        Me.txtCodTrans.TabIndex = 2
        '
        'txtDscTrans
        '
        Me.txtDscTrans.Location = New System.Drawing.Point(68, 18)
        Me.txtDscTrans.Name = "txtDscTrans"
        Me.txtDscTrans.ReadOnly = True
        Me.txtDscTrans.Size = New System.Drawing.Size(210, 20)
        Me.txtDscTrans.TabIndex = 3
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
        Me.dgvAgendamentos.Size = New System.Drawing.Size(1217, 384)
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
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNovo.Image = Global.WStock.My.Resources.Resources._new
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(1117, 45)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(90, 23)
        Me.btnNovo.TabIndex = 28
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnLimpTpVeic
        '
        Me.btnLimpTpVeic.Image = Global.WStock.My.Resources.Resources.delete
        Me.btnLimpTpVeic.Location = New System.Drawing.Point(278, 17)
        Me.btnLimpTpVeic.Name = "btnLimpTpVeic"
        Me.btnLimpTpVeic.Size = New System.Drawing.Size(25, 23)
        Me.btnLimpTpVeic.TabIndex = 6
        Me.btnLimpTpVeic.UseVisualStyleBackColor = True
        '
        'btnPesqTpVeic
        '
        Me.btnPesqTpVeic.Image = Global.WStock.My.Resources.Resources.search
        Me.btnPesqTpVeic.Location = New System.Drawing.Point(302, 17)
        Me.btnPesqTpVeic.Name = "btnPesqTpVeic"
        Me.btnPesqTpVeic.Size = New System.Drawing.Size(25, 23)
        Me.btnPesqTpVeic.TabIndex = 1
        Me.btnPesqTpVeic.UseVisualStyleBackColor = True
        '
        'btnLimpTpAgd
        '
        Me.btnLimpTpAgd.Image = Global.WStock.My.Resources.Resources.delete
        Me.btnLimpTpAgd.Location = New System.Drawing.Point(278, 17)
        Me.btnLimpTpAgd.Name = "btnLimpTpAgd"
        Me.btnLimpTpAgd.Size = New System.Drawing.Size(25, 23)
        Me.btnLimpTpAgd.TabIndex = 6
        Me.btnLimpTpAgd.UseVisualStyleBackColor = True
        '
        'btnPesqTpAgd
        '
        Me.btnPesqTpAgd.Image = Global.WStock.My.Resources.Resources.search
        Me.btnPesqTpAgd.Location = New System.Drawing.Point(302, 17)
        Me.btnPesqTpAgd.Name = "btnPesqTpAgd"
        Me.btnPesqTpAgd.Size = New System.Drawing.Size(25, 23)
        Me.btnPesqTpAgd.TabIndex = 1
        Me.btnPesqTpAgd.UseVisualStyleBackColor = True
        '
        'btnLimpTpCarg
        '
        Me.btnLimpTpCarg.Image = Global.WStock.My.Resources.Resources.delete
        Me.btnLimpTpCarg.Location = New System.Drawing.Point(278, 17)
        Me.btnLimpTpCarg.Name = "btnLimpTpCarg"
        Me.btnLimpTpCarg.Size = New System.Drawing.Size(25, 23)
        Me.btnLimpTpCarg.TabIndex = 6
        Me.btnLimpTpCarg.UseVisualStyleBackColor = True
        '
        'btnPesqTpCarg
        '
        Me.btnPesqTpCarg.Image = Global.WStock.My.Resources.Resources.search
        Me.btnPesqTpCarg.Location = New System.Drawing.Point(302, 17)
        Me.btnPesqTpCarg.Name = "btnPesqTpCarg"
        Me.btnPesqTpCarg.Size = New System.Drawing.Size(25, 23)
        Me.btnPesqTpCarg.TabIndex = 1
        Me.btnPesqTpCarg.UseVisualStyleBackColor = True
        '
        'btnLimpEmp
        '
        Me.btnLimpEmp.Image = Global.WStock.My.Resources.Resources.delete
        Me.btnLimpEmp.Location = New System.Drawing.Point(278, 17)
        Me.btnLimpEmp.Name = "btnLimpEmp"
        Me.btnLimpEmp.Size = New System.Drawing.Size(25, 23)
        Me.btnLimpEmp.TabIndex = 6
        Me.btnLimpEmp.UseVisualStyleBackColor = True
        '
        'btnPesqEmp
        '
        Me.btnPesqEmp.Image = Global.WStock.My.Resources.Resources.search
        Me.btnPesqEmp.Location = New System.Drawing.Point(302, 17)
        Me.btnPesqEmp.Name = "btnPesqEmp"
        Me.btnPesqEmp.Size = New System.Drawing.Size(25, 23)
        Me.btnPesqEmp.TabIndex = 1
        Me.btnPesqEmp.UseVisualStyleBackColor = True
        '
        'btnLimpTpPall
        '
        Me.btnLimpTpPall.Image = Global.WStock.My.Resources.Resources.delete
        Me.btnLimpTpPall.Location = New System.Drawing.Point(278, 17)
        Me.btnLimpTpPall.Name = "btnLimpTpPall"
        Me.btnLimpTpPall.Size = New System.Drawing.Size(25, 23)
        Me.btnLimpTpPall.TabIndex = 6
        Me.btnLimpTpPall.UseVisualStyleBackColor = True
        '
        'btnPesqTpPall
        '
        Me.btnPesqTpPall.Image = Global.WStock.My.Resources.Resources.search
        Me.btnPesqTpPall.Location = New System.Drawing.Point(302, 17)
        Me.btnPesqTpPall.Name = "btnPesqTpPall"
        Me.btnPesqTpPall.Size = New System.Drawing.Size(25, 23)
        Me.btnPesqTpPall.TabIndex = 1
        Me.btnPesqTpPall.UseVisualStyleBackColor = True
        '
        'btnLimpTrans
        '
        Me.btnLimpTrans.Image = Global.WStock.My.Resources.Resources.delete
        Me.btnLimpTrans.Location = New System.Drawing.Point(278, 17)
        Me.btnLimpTrans.Name = "btnLimpTrans"
        Me.btnLimpTrans.Size = New System.Drawing.Size(25, 23)
        Me.btnLimpTrans.TabIndex = 6
        Me.btnLimpTrans.UseVisualStyleBackColor = True
        '
        'btnPesqTrans
        '
        Me.btnPesqTrans.Image = Global.WStock.My.Resources.Resources.search
        Me.btnPesqTrans.Location = New System.Drawing.Point(302, 17)
        Me.btnPesqTrans.Name = "btnPesqTrans"
        Me.btnPesqTrans.Size = New System.Drawing.Size(25, 23)
        Me.btnPesqTrans.TabIndex = 1
        Me.btnPesqTrans.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPesquisar.BackColor = System.Drawing.SystemColors.Control
        Me.btnPesquisar.Image = Global.WStock.My.Resources.Resources.search1
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.Location = New System.Drawing.Point(1117, 74)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(90, 23)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'FrmListaAgendamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 525)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvAgendamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTrans As Label
    Friend WithEvents txtCodTrans As TextBox
    Friend WithEvents txtDscTrans As TextBox
    Friend WithEvents btnPesqTrans As Button
    Friend WithEvents btnLimpTrans As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnLimpEmp As Button
    Friend WithEvents lblEmp As Label
    Friend WithEvents btnPesqEmp As Button
    Friend WithEvents txtCodEmp As TextBox
    Friend WithEvents txtDscEmp As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnLimpTpVeic As Button
    Friend WithEvents lblTpVeic As Label
    Friend WithEvents btnPesqTpVeic As Button
    Friend WithEvents txtCodTpVeic As TextBox
    Friend WithEvents txtDscTpVeic As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnLimpTpAgd As Button
    Friend WithEvents lblTpAgd As Label
    Friend WithEvents btnPesqTpAgd As Button
    Friend WithEvents txtCodTpAgd As TextBox
    Friend WithEvents txtDscTpAgd As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnLimpTpCarg As Button
    Friend WithEvents lblTpCarg As Label
    Friend WithEvents btnPesqTpCarg As Button
    Friend WithEvents txtCodTpCarg As TextBox
    Friend WithEvents txtDscTpCarg As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnLimpTpPall As Button
    Friend WithEvents lblTpPall As Label
    Friend WithEvents btnPesqTpPall As Button
    Friend WithEvents txtCodTpPall As TextBox
    Friend WithEvents txtDscTpPall As TextBox
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
End Class
