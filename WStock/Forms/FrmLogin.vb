Imports System.Data.OleDb
Imports WStock.Domain
Imports WStock.Framework.DepedencyInjection
Imports WStock.Framework.NHibernate

Public Class FrmLogin
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Conexao = ArchiveConnection.Read()
            If Not IsNothing(Conexao) Then
                NHibernateConfigurationData.Connection = New Framework.Models.ConnectionData()
                NHibernateConfigurationData.Connection.Database = Conexao.Database
                NHibernateConfigurationData.Connection.Server = Conexao.Server
                NHibernateConfigurationData.Connection.Port = IIf(String.IsNullOrEmpty(Conexao.Port), "3306", Conexao.Port)
                NHibernateConfigurationData.Connection.User = Conexao.User
                NHibernateConfigurationData.Connection.Password = Conexao.Password
            Else
                ConfigBancoDados()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Logar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FrmLogin_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        ConfigTeclado(e)
    End Sub
    Private Sub TxtloginUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtloginUsuario.KeyDown
        ConfigTeclado(e)
    End Sub
    Private Sub TxtSenhaLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenhaLogin.KeyDown
        ConfigTeclado(e)
    End Sub
    Private Sub BtnLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLogin.KeyDown
        ConfigTeclado(e)
    End Sub
    Private Sub ConfigTeclado(e As KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                Logar()
            ElseIf e.Control = True And e.Alt = True And e.KeyCode = Keys.F10 Then
                ConfigBancoDados()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ConfigBancoDados()
        Dim FrmDatabase As New FrmDatabase
        FrmDatabase.ShowDialog()
    End Sub
    Private Sub Logar()
        If Not ValidaCampos() Then Exit Sub

        Dim Usuario = DependencyInjectionFactory _
            .CreateInstance(Of IUsuarioRepository) _
            .Login(txtloginUsuario.Text, txtSenhaLogin.Text)

        If Not IsNothing(Usuario) AndAlso Usuario.Codigo > 0 Then
            Me.Hide()
            Dim frmMenu As New FrmMenu
            frmMenu.Show()
        Else
            MessageBox.Show("Usuário ou senha incorretos, tente novamente!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Function ValidaCampos() As Boolean

        If String.IsNullOrEmpty(txtloginUsuario.Text) Then
            MessageBox.Show("Preencha o campo de Login!")
            txtloginUsuario.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtSenhaLogin.Text) Then
            MessageBox.Show("Preencha o campo senha!")
            txtSenhaLogin.Focus()
            Return False
        End If

        Return True
    End Function
End Class
