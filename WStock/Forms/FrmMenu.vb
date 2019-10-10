Public Class FrmMenu
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub NovaSolicitaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaSolicitaçãoToolStripMenuItem.Click
        Dim SolicitacaoCompra As New FrmSolicitacaoCompra
        SolicitacaoCompra.MdiParent = Me
        SolicitacaoCompra.Show()
    End Sub
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlMDI = Controls(Controls.Count - 1)
        ctlMDI.BackColor = Color.White
        ctlMDI.BackgroundImage = Image.FromFile("..\..\WCONTROL_LOGO.png")
    End Sub
    Private Sub AvaliaçãoIndividualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvaliaçãoIndividualToolStripMenuItem.Click
        Dim AvaliacaoIndividual As New FrmTerceiros
        AvaliacaoIndividual.MdiParent = Me
        AvaliacaoIndividual.Show()
    End Sub
    Private Sub CadastroDeUsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeUsuáriosToolStripMenuItem.Click
        Dim CadastroUsuario As New FrmCadastro
        CadastroUsuario.MdiParent = Me
        CadastroUsuario.Show()
    End Sub
    Private Sub FrmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click
        Dim Agendamento As New FrmListaAgendamentos
        Agendamento.ShowDialog()
    End Sub

    Private Sub CadastroDeFuncionariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeFuncionariosToolStripMenuItem.Click
        Dim Funcionarios As New FrmCadFuncionarios
        Funcionarios.ShowDialog()
    End Sub
End Class