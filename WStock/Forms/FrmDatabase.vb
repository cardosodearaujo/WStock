Imports System.Text
Imports MySql.Data.MySqlClient
Imports WStock.Framework.Models

Public Class FrmDatabase
    Private Sub FrmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim data = ArchiveConnection.Read()
            If Not IsNothing(data) Then
                txtBaseDados.Text = data.Database
                txtServidor.Text = data.Server
                txtPorta.Text = data.Port
                txtUsuario.Text = data.User
                txtSenha.Text = data.Password
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Dim Conexao As New StringBuilder
            With Conexao
                .AppendLine(txtBaseDados.Text)
                .AppendLine(txtServidor.Text)
                .AppendLine(txtPorta.Text)
                .AppendLine(txtUsuario.Text)
                .AppendLine(txtSenha.Text)
            End With
            ArchiveConnection.Write(Conexao.ToString())
            MessageBox.Show("O sistema será fechado para aplicar as configurações. Você deverá reabri-lo em seguida.",
                            "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnTestar_Click(sender As Object, e As EventArgs) Handles btnTestar.Click
        Try
            Dim Conexao As New MySqlConnection()
            Dim Data As New ConnectionData()
            With Data
                .Database = txtBaseDados.Text
                .Server = txtServidor.Text
                .Port = txtPorta.Text
                .User = txtUsuario.Text
                .Password = txtSenha.Text
            End With

            Conexao.ConnectionString = Data.getConnectionMySql()
            Conexao.Open()

            MessageBox.Show("Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro no teste de conexão: " & ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class