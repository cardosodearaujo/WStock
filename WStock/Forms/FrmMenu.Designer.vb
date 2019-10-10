<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AnáliseDeConsumoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnáliseRessuprimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitaçãoRessuprimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerdasEDescartesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriaçãoPedidoDePerdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvisãoDePerdasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CervejaEGourmetFiscalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Geral90DiasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimuladorDePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustesDeSaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketSalesForceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversãoKitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecebimentosClubeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecebimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleDePaletesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaixaRelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarDiretórioSalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitaçãoDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaSolicitaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarSolicitaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FollowUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeUsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeFornecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleTerceirizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvaliaçãoIndividualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarAvaliaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeFuncionariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnáliseDeConsumoToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.PerdasEDescartesToolStripMenuItem, Me.RecebimentoToolStripMenuItem, Me.BaseScriptToolStripMenuItem, Me.SolicitaçãoDeCompraToolStripMenuItem, Me.CadastrosToolStripMenuItem, Me.ControleTerceirizadasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1070, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AnáliseDeConsumoToolStripMenuItem
        '
        Me.AnáliseDeConsumoToolStripMenuItem.Image = CType(resources.GetObject("AnáliseDeConsumoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AnáliseDeConsumoToolStripMenuItem.Name = "AnáliseDeConsumoToolStripMenuItem"
        Me.AnáliseDeConsumoToolStripMenuItem.Size = New System.Drawing.Size(154, 20)
        Me.AnáliseDeConsumoToolStripMenuItem.Text = "Análises WMS x MEGA"
        Me.AnáliseDeConsumoToolStripMenuItem.Visible = False
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnáliseRessuprimentoToolStripMenuItem, Me.SolicitaçãoRessuprimentoToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.Image = CType(resources.GetObject("EstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        Me.EstoqueToolStripMenuItem.Visible = False
        '
        'AnáliseRessuprimentoToolStripMenuItem
        '
        Me.AnáliseRessuprimentoToolStripMenuItem.Name = "AnáliseRessuprimentoToolStripMenuItem"
        Me.AnáliseRessuprimentoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.AnáliseRessuprimentoToolStripMenuItem.Text = "Análise ressuprimento"
        '
        'SolicitaçãoRessuprimentoToolStripMenuItem
        '
        Me.SolicitaçãoRessuprimentoToolStripMenuItem.Name = "SolicitaçãoRessuprimentoToolStripMenuItem"
        Me.SolicitaçãoRessuprimentoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SolicitaçãoRessuprimentoToolStripMenuItem.Text = "Solicitação ressuprimento"
        '
        'PerdasEDescartesToolStripMenuItem
        '
        Me.PerdasEDescartesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriaçãoPedidoDePerdaToolStripMenuItem, Me.ProvisãoDePerdasToolStripMenuItem1, Me.SimuladorDePedidoToolStripMenuItem, Me.AjustesDeSaldosToolStripMenuItem, Me.InventárioToolStripMenuItem, Me.TicketSalesForceToolStripMenuItem, Me.ConversãoKitToolStripMenuItem1, Me.RecebimentosClubeToolStripMenuItem1})
        Me.PerdasEDescartesToolStripMenuItem.Image = CType(resources.GetObject("PerdasEDescartesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PerdasEDescartesToolStripMenuItem.Name = "PerdasEDescartesToolStripMenuItem"
        Me.PerdasEDescartesToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.PerdasEDescartesToolStripMenuItem.Text = "Controle qualidade"
        Me.PerdasEDescartesToolStripMenuItem.Visible = False
        '
        'CriaçãoPedidoDePerdaToolStripMenuItem
        '
        Me.CriaçãoPedidoDePerdaToolStripMenuItem.Name = "CriaçãoPedidoDePerdaToolStripMenuItem"
        Me.CriaçãoPedidoDePerdaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CriaçãoPedidoDePerdaToolStripMenuItem.Text = "Criação pedido de perda"
        '
        'ProvisãoDePerdasToolStripMenuItem1
        '
        Me.ProvisãoDePerdasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CervejaEGourmetFiscalToolStripMenuItem, Me.Geral90DiasToolStripMenuItem1})
        Me.ProvisãoDePerdasToolStripMenuItem1.Name = "ProvisãoDePerdasToolStripMenuItem1"
        Me.ProvisãoDePerdasToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ProvisãoDePerdasToolStripMenuItem1.Text = "Provisão de perdas"
        '
        'CervejaEGourmetFiscalToolStripMenuItem
        '
        Me.CervejaEGourmetFiscalToolStripMenuItem.Name = "CervejaEGourmetFiscalToolStripMenuItem"
        Me.CervejaEGourmetFiscalToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CervejaEGourmetFiscalToolStripMenuItem.Text = "Cerveja e gourmet fiscal"
        '
        'Geral90DiasToolStripMenuItem1
        '
        Me.Geral90DiasToolStripMenuItem1.Name = "Geral90DiasToolStripMenuItem1"
        Me.Geral90DiasToolStripMenuItem1.Size = New System.Drawing.Size(201, 22)
        Me.Geral90DiasToolStripMenuItem1.Text = "Geral 90 dias"
        '
        'SimuladorDePedidoToolStripMenuItem
        '
        Me.SimuladorDePedidoToolStripMenuItem.Name = "SimuladorDePedidoToolStripMenuItem"
        Me.SimuladorDePedidoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.SimuladorDePedidoToolStripMenuItem.Text = "Simulador de Pedido"
        '
        'AjustesDeSaldosToolStripMenuItem
        '
        Me.AjustesDeSaldosToolStripMenuItem.Name = "AjustesDeSaldosToolStripMenuItem"
        Me.AjustesDeSaldosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AjustesDeSaldosToolStripMenuItem.Text = "Ajustes de saldos"
        '
        'InventárioToolStripMenuItem
        '
        Me.InventárioToolStripMenuItem.Name = "InventárioToolStripMenuItem"
        Me.InventárioToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.InventárioToolStripMenuItem.Text = "Inventário"
        '
        'TicketSalesForceToolStripMenuItem
        '
        Me.TicketSalesForceToolStripMenuItem.Name = "TicketSalesForceToolStripMenuItem"
        Me.TicketSalesForceToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.TicketSalesForceToolStripMenuItem.Text = "Ticket SalesForce"
        '
        'ConversãoKitToolStripMenuItem1
        '
        Me.ConversãoKitToolStripMenuItem1.Name = "ConversãoKitToolStripMenuItem1"
        Me.ConversãoKitToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ConversãoKitToolStripMenuItem1.Text = "Conversão kit"
        '
        'RecebimentosClubeToolStripMenuItem1
        '
        Me.RecebimentosClubeToolStripMenuItem1.Name = "RecebimentosClubeToolStripMenuItem1"
        Me.RecebimentosClubeToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.RecebimentosClubeToolStripMenuItem1.Text = "Recebimentos clube"
        '
        'RecebimentoToolStripMenuItem
        '
        Me.RecebimentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendaToolStripMenuItem, Me.ControleDePaletesToolStripMenuItem})
        Me.RecebimentoToolStripMenuItem.Image = CType(resources.GetObject("RecebimentoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RecebimentoToolStripMenuItem.Name = "RecebimentoToolStripMenuItem"
        Me.RecebimentoToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.RecebimentoToolStripMenuItem.Text = "Recebimento"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgendaToolStripMenuItem.Text = "Agendamento"
        '
        'ControleDePaletesToolStripMenuItem
        '
        Me.ControleDePaletesToolStripMenuItem.Name = "ControleDePaletesToolStripMenuItem"
        Me.ControleDePaletesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ControleDePaletesToolStripMenuItem.Text = "Controle de paletes"
        Me.ControleDePaletesToolStripMenuItem.Visible = False
        '
        'BaseScriptToolStripMenuItem
        '
        Me.BaseScriptToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaixaRelatóriosToolStripMenuItem, Me.AlterarDiretórioSalvarToolStripMenuItem})
        Me.BaseScriptToolStripMenuItem.Image = CType(resources.GetObject("BaseScriptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BaseScriptToolStripMenuItem.Name = "BaseScriptToolStripMenuItem"
        Me.BaseScriptToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.BaseScriptToolStripMenuItem.Text = "Produção"
        Me.BaseScriptToolStripMenuItem.Visible = False
        '
        'BaixaRelatóriosToolStripMenuItem
        '
        Me.BaixaRelatóriosToolStripMenuItem.Name = "BaixaRelatóriosToolStripMenuItem"
        Me.BaixaRelatóriosToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.BaixaRelatóriosToolStripMenuItem.Text = "Baixar Relatórios"
        '
        'AlterarDiretórioSalvarToolStripMenuItem
        '
        Me.AlterarDiretórioSalvarToolStripMenuItem.Name = "AlterarDiretórioSalvarToolStripMenuItem"
        Me.AlterarDiretórioSalvarToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AlterarDiretórioSalvarToolStripMenuItem.Text = "Alterar Diretório Salvar"
        '
        'SolicitaçãoDeCompraToolStripMenuItem
        '
        Me.SolicitaçãoDeCompraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaSolicitaçãoToolStripMenuItem, Me.ConsultarSolicitaçãoToolStripMenuItem, Me.FollowUpToolStripMenuItem})
        Me.SolicitaçãoDeCompraToolStripMenuItem.Image = CType(resources.GetObject("SolicitaçãoDeCompraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SolicitaçãoDeCompraToolStripMenuItem.Name = "SolicitaçãoDeCompraToolStripMenuItem"
        Me.SolicitaçãoDeCompraToolStripMenuItem.Size = New System.Drawing.Size(159, 20)
        Me.SolicitaçãoDeCompraToolStripMenuItem.Text = "Solicitação embalagens"
        Me.SolicitaçãoDeCompraToolStripMenuItem.Visible = False
        '
        'NovaSolicitaçãoToolStripMenuItem
        '
        Me.NovaSolicitaçãoToolStripMenuItem.Name = "NovaSolicitaçãoToolStripMenuItem"
        Me.NovaSolicitaçãoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.NovaSolicitaçãoToolStripMenuItem.Text = "Nova Solicitação"
        '
        'ConsultarSolicitaçãoToolStripMenuItem
        '
        Me.ConsultarSolicitaçãoToolStripMenuItem.Name = "ConsultarSolicitaçãoToolStripMenuItem"
        Me.ConsultarSolicitaçãoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ConsultarSolicitaçãoToolStripMenuItem.Text = "Consultar Solicitação"
        '
        'FollowUpToolStripMenuItem
        '
        Me.FollowUpToolStripMenuItem.Name = "FollowUpToolStripMenuItem"
        Me.FollowUpToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.FollowUpToolStripMenuItem.Text = "Follow up"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeUsuáriosToolStripMenuItem, Me.CadastroDeFornecedorToolStripMenuItem, Me.CadastroDeProdutosToolStripMenuItem, Me.CadastroDeFuncionariosToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Image = CType(resources.GetObject("CadastrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'CadastroDeUsuáriosToolStripMenuItem
        '
        Me.CadastroDeUsuáriosToolStripMenuItem.Name = "CadastroDeUsuáriosToolStripMenuItem"
        Me.CadastroDeUsuáriosToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro de Usuários"
        Me.CadastroDeUsuáriosToolStripMenuItem.Visible = False
        '
        'CadastroDeFornecedorToolStripMenuItem
        '
        Me.CadastroDeFornecedorToolStripMenuItem.Name = "CadastroDeFornecedorToolStripMenuItem"
        Me.CadastroDeFornecedorToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CadastroDeFornecedorToolStripMenuItem.Text = "Cadastro de Fornecedor"
        Me.CadastroDeFornecedorToolStripMenuItem.Visible = False
        '
        'CadastroDeProdutosToolStripMenuItem
        '
        Me.CadastroDeProdutosToolStripMenuItem.Name = "CadastroDeProdutosToolStripMenuItem"
        Me.CadastroDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos"
        Me.CadastroDeProdutosToolStripMenuItem.Visible = False
        '
        'ControleTerceirizadasToolStripMenuItem
        '
        Me.ControleTerceirizadasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvaliaçãoIndividualToolStripMenuItem, Me.ConsultarAvaliaçõesToolStripMenuItem})
        Me.ControleTerceirizadasToolStripMenuItem.Image = CType(resources.GetObject("ControleTerceirizadasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ControleTerceirizadasToolStripMenuItem.Name = "ControleTerceirizadasToolStripMenuItem"
        Me.ControleTerceirizadasToolStripMenuItem.Size = New System.Drawing.Size(150, 20)
        Me.ControleTerceirizadasToolStripMenuItem.Text = "Controle Terceirizadas"
        Me.ControleTerceirizadasToolStripMenuItem.Visible = False
        '
        'AvaliaçãoIndividualToolStripMenuItem
        '
        Me.AvaliaçãoIndividualToolStripMenuItem.Name = "AvaliaçãoIndividualToolStripMenuItem"
        Me.AvaliaçãoIndividualToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AvaliaçãoIndividualToolStripMenuItem.Text = "Avaliação individual"
        '
        'ConsultarAvaliaçõesToolStripMenuItem
        '
        Me.ConsultarAvaliaçõesToolStripMenuItem.Name = "ConsultarAvaliaçõesToolStripMenuItem"
        Me.ConsultarAvaliaçõesToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ConsultarAvaliaçõesToolStripMenuItem.Text = "Consultar avaliações"
        '
        'CadastroDeFuncionariosToolStripMenuItem
        '
        Me.CadastroDeFuncionariosToolStripMenuItem.Name = "CadastroDeFuncionariosToolStripMenuItem"
        Me.CadastroDeFuncionariosToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CadastroDeFuncionariosToolStripMenuItem.Text = "Cadastro de funcionarios"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1070, 524)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WStock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SolicitaçãoDeCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnáliseDeConsumoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaSolicitaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarSolicitaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FollowUpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaixaRelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarDiretórioSalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeUsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeFornecedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerdasEDescartesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CriaçãoPedidoDePerdaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvisãoDePerdasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CervejaEGourmetFiscalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Geral90DiasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SimuladorDePedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecebimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjustesDeSaldosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicketSalesForceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConversãoKitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RecebimentosClubeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnáliseRessuprimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitaçãoRessuprimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleTerceirizadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvaliaçãoIndividualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarAvaliaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleDePaletesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeFuncionariosToolStripMenuItem As ToolStripMenuItem
End Class
