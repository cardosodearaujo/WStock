Imports System.Data.OleDb
Imports WStock.Domain
Imports WStock.Framework.DepedencyInjection

Public Class FrmLogin
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Logar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FrmLogin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Logar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtloginUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtloginUsuario.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Logar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtSenhaLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSenhaLogin.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Logar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLogin.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Logar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Logar()
        If Not ValidaCampos() Then Exit Sub

        Dim Usuario = DependencyInjectionFactory _
            .CreateInstance(Of IUsuarioRepository) _
            .Login(txtloginUsuario.Text, txtSenhaLogin.Text)

        If Not IsNothing(Usuario) AndAlso Usuario.Codigo > 0 Then
            Me.Hide()
            Dim frmMenu = New FrmMenu
            frmMenu.Show()
        Else
            MsgBox("Erro ao tentar efetuar login, tente novamente", MsgBoxStyle.Information)
            Me.DialogResult = DialogResult.OK
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
