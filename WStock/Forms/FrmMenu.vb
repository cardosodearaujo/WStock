Imports WStock.Framework.NHibernate

Public Class FrmMenu
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ConfigLogo()
        Dim ctlMDI = Controls(Controls.Count - 1)
        ctlMDI.BackColor = Color.White
        ctlMDI.BackgroundImage = Image.FromFile("..\..\WCONTROL_LOGO.png")
        ctlMDI.BackgroundImageLayout = ImageLayout.Center
    End Sub

    Private Sub Config()
        tspConexao.Text = "Conectado no servidor MySQL: " & NHibernateConfigurationData.Connection.Server _
            & IIf(NHibernateConfigurationData.Connection.Port = String.Empty, ",3306", "," & NHibernateConfigurationData.Connection.Port) _
            & " | Banco de dados: " & NHibernateConfigurationData.Connection.Database
    End Sub

    Private Sub NovaSolicitaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaSolicitaçãoToolStripMenuItem.Click
        Dim SolicitacaoCompra As New FrmSolicitacaoCompra
        SolicitacaoCompra.Show()
    End Sub
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigLogo()
        Config()
    End Sub
    Private Sub AvaliaçãoIndividualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvaliaçãoIndividualToolStripMenuItem.Click
        Dim Terceiros As New FrmTerceiros
        Terceiros.Show()
    End Sub
    Private Sub CadastroDeUsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeUsuáriosToolStripMenuItem.Click
        Dim CadastroUsuario As New FrmCadastro
        CadastroUsuario.Show()
    End Sub
    Private Sub FrmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click
        Dim Agendamento As New FrmListaAgendamentos
        Agendamento.Show()
    End Sub

    Private Sub CadastroDeFuncionariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeFuncionariosToolStripMenuItem.Click
        Dim Funcionarios As New FrmCadFuncionarios
        Funcionarios.Show()
    End Sub
End Class