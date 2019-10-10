<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadFuncionarios
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtBancoHoras = New System.Windows.Forms.TextBox()
        Me.lblBancoHoras = New System.Windows.Forms.Label()
        Me.dtpTerminoContrato = New System.Windows.Forms.DateTimePicker()
        Me.lblTerminoContrato = New System.Windows.Forms.Label()
        Me.nswEmpresa = New WStock.NewSearchWindow()
        Me.nswTurno = New WStock.NewSearchWindow()
        Me.nswSituacao = New WStock.NewSearchWindow()
        Me.nswArea = New WStock.NewSearchWindow()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(20, 14)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "Código"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(82, 30)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(261, 20)
        Me.txtNome.TabIndex = 31
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(85, 14)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 32
        Me.lblNome.Text = "Nome"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(17, 30)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodigo.TabIndex = 34
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(132, 60)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefone.TabIndex = 37
        Me.lblTelefone.Text = "Telefone"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(129, 76)
        Me.txtTelefone.Mask = "(00)00000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(94, 20)
        Me.txtTelefone.TabIndex = 38
        '
        'txtBancoHoras
        '
        Me.txtBancoHoras.Location = New System.Drawing.Point(229, 76)
        Me.txtBancoHoras.Name = "txtBancoHoras"
        Me.txtBancoHoras.Size = New System.Drawing.Size(114, 20)
        Me.txtBancoHoras.TabIndex = 39
        '
        'lblBancoHoras
        '
        Me.lblBancoHoras.AutoSize = True
        Me.lblBancoHoras.Location = New System.Drawing.Point(229, 60)
        Me.lblBancoHoras.Name = "lblBancoHoras"
        Me.lblBancoHoras.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoHoras.TabIndex = 40
        Me.lblBancoHoras.Text = "Banco de horas"
        '
        'dtpTerminoContrato
        '
        Me.dtpTerminoContrato.CustomFormat = "dd/MM/yyyy"
        Me.dtpTerminoContrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTerminoContrato.Location = New System.Drawing.Point(17, 76)
        Me.dtpTerminoContrato.Name = "dtpTerminoContrato"
        Me.dtpTerminoContrato.Size = New System.Drawing.Size(106, 20)
        Me.dtpTerminoContrato.TabIndex = 41
        '
        'lblTerminoContrato
        '
        Me.lblTerminoContrato.AutoSize = True
        Me.lblTerminoContrato.Location = New System.Drawing.Point(20, 60)
        Me.lblTerminoContrato.Name = "lblTerminoContrato"
        Me.lblTerminoContrato.Size = New System.Drawing.Size(102, 13)
        Me.lblTerminoContrato.TabIndex = 42
        Me.lblTerminoContrato.Text = "Término do contrato"
        '
        'nswEmpresa
        '
        Me.nswEmpresa.CampoCodigoTabelaRetono = ""
        Me.nswEmpresa.CampoDescricaoTabelaRetono = ""
        Me.nswEmpresa.Codigo = Nothing
        Me.nswEmpresa.Descricao = Nothing
        Me.nswEmpresa.ListaColunas = Nothing
        Me.nswEmpresa.Location = New System.Drawing.Point(11, 102)
        Me.nswEmpresa.Name = "nswEmpresa"
        Me.nswEmpresa.OrderBy = Nothing
        Me.nswEmpresa.Size = New System.Drawing.Size(332, 41)
        Me.nswEmpresa.Tabela = ""
        Me.nswEmpresa.TabIndex = 35
        Me.nswEmpresa.Titulo = "Empresa"
        Me.nswEmpresa.Where = Nothing
        '
        'nswTurno
        '
        Me.nswTurno.CampoCodigoTabelaRetono = ""
        Me.nswTurno.CampoDescricaoTabelaRetono = ""
        Me.nswTurno.Codigo = Nothing
        Me.nswTurno.Descricao = Nothing
        Me.nswTurno.ListaColunas = Nothing
        Me.nswTurno.Location = New System.Drawing.Point(11, 149)
        Me.nswTurno.Name = "nswTurno"
        Me.nswTurno.OrderBy = Nothing
        Me.nswTurno.Size = New System.Drawing.Size(332, 41)
        Me.nswTurno.Tabela = ""
        Me.nswTurno.TabIndex = 52
        Me.nswTurno.Titulo = "Turno"
        Me.nswTurno.Where = Nothing
        '
        'nswSituacao
        '
        Me.nswSituacao.CampoCodigoTabelaRetono = ""
        Me.nswSituacao.CampoDescricaoTabelaRetono = ""
        Me.nswSituacao.Codigo = Nothing
        Me.nswSituacao.Descricao = Nothing
        Me.nswSituacao.ListaColunas = Nothing
        Me.nswSituacao.Location = New System.Drawing.Point(11, 196)
        Me.nswSituacao.Name = "nswSituacao"
        Me.nswSituacao.OrderBy = Nothing
        Me.nswSituacao.Size = New System.Drawing.Size(332, 41)
        Me.nswSituacao.Tabela = ""
        Me.nswSituacao.TabIndex = 53
        Me.nswSituacao.Titulo = "Situação"
        Me.nswSituacao.Where = Nothing
        '
        'nswArea
        '
        Me.nswArea.CampoCodigoTabelaRetono = ""
        Me.nswArea.CampoDescricaoTabelaRetono = ""
        Me.nswArea.Codigo = Nothing
        Me.nswArea.Descricao = Nothing
        Me.nswArea.ListaColunas = Nothing
        Me.nswArea.Location = New System.Drawing.Point(11, 241)
        Me.nswArea.Name = "nswArea"
        Me.nswArea.OrderBy = Nothing
        Me.nswArea.Size = New System.Drawing.Size(332, 41)
        Me.nswArea.Tabela = ""
        Me.nswArea.TabIndex = 54
        Me.nswArea.Titulo = "Área"
        Me.nswArea.Where = Nothing
        '
        'btnSalvar
        '
        Me.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalvar.Image = Global.WStock.My.Resources.Resources.floppy_disk
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(17, 293)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(95, 29)
        Me.btnSalvar.TabIndex = 55
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnProcurar
        '
        Me.btnProcurar.Image = Global.WStock.My.Resources.Resources.search
        Me.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcurar.Location = New System.Drawing.Point(118, 293)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(95, 29)
        Me.btnProcurar.TabIndex = 51
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 281)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'FrmCadFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 327)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.nswArea)
        Me.Controls.Add(Me.nswSituacao)
        Me.Controls.Add(Me.nswTurno)
        Me.Controls.Add(Me.btnProcurar)
        Me.Controls.Add(Me.lblTerminoContrato)
        Me.Controls.Add(Me.dtpTerminoContrato)
        Me.Controls.Add(Me.lblBancoHoras)
        Me.Controls.Add(Me.txtBancoHoras)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.nswEmpresa)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCadFuncionarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de funcionários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents nswEmpresa As NewSearchWindow
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents txtBancoHoras As TextBox
    Friend WithEvents lblBancoHoras As Label
    Friend WithEvents dtpTerminoContrato As DateTimePicker
    Friend WithEvents lblTerminoContrato As Label
    Friend WithEvents nswTurno As NewSearchWindow
    Friend WithEvents nswSituacao As NewSearchWindow
    Friend WithEvents nswArea As NewSearchWindow
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnProcurar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
