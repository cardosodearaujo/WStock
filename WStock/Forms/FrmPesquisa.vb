﻿Imports System.Text
Imports WStock.Domain
Imports WStock.Framework.NHibernate
Imports MySql.Data.MySqlClient

Public Class FrmPesquisa
    Public Property CodigoRetorno As Object
    Public Property DescricaoRetorno As Object
    Public Property CampoCodigoTabelaRetono As String
    Public Property CampoDescricaoTabelaRetono As String
    Public Property ListaColunas As List(Of RotuloPesquisaVO)
    Public Property Tabela As String
    Public Property Where As String
    Public Property OrderBy As String

    Private Sub FrmPesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ValidarParamentros() Then
            PreecherCombo()
            ConfigurarGrid()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Consultar()
    End Sub
    Private Sub DgvResultados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultados.CellDoubleClick
        Try
            If dgvResultados.Rows.Count > 0 Then
                CodigoRetorno = dgvResultados.Item(CampoCodigoTabelaRetono, e.RowIndex).Value
                If Not String.IsNullOrEmpty(CampoDescricaoTabelaRetono) Then
                    DescricaoRetorno = dgvResultados.Item(CampoDescricaoTabelaRetono, e.RowIndex).Value
                End If
                Me.Close()
            End If
        Catch
        End Try
    End Sub

    Private Function ValidarParamentros() As Boolean
        If String.IsNullOrEmpty(CampoCodigoTabelaRetono) Then
            Return False
        End If
        If IsNothing(ListaColunas) OrElse ListaColunas.Count <= 0 Then
            Return False
        End If
        If String.IsNullOrEmpty(Tabela) Then
            Return False
        End If
        Return True
    End Function

    Private Sub PreecherCombo()
        cboOpcoes.DataSource = ListaColunas
        cboOpcoes.ValueMember = "Coluna"
        cboOpcoes.DisplayMember = "Rotulo"
    End Sub

    Private Sub ConfigurarGrid()
        For Each item In ListaColunas
            dgvResultados.Columns.Add(item.Coluna, item.Rotulo)
            dgvResultados.Columns(item.Coluna).DataPropertyName = item.Coluna
        Next
    End Sub

    Private Sub Consultar()
        Try
            Dim SQL As New StringBuilder()

            SQL.AppendLine("Select ")

            For Each item In ListaColunas
                If item.Coluna = ListaColunas.Last.Coluna Then
                    SQL.AppendLine(item.Coluna)
                Else
                    SQL.AppendLine(item.Coluna + ",")
                End If
            Next

            SQL.AppendLine("From " + Tabela)

            SQL.AppendLine("Where 1=1 ")

            If Not String.IsNullOrEmpty(Where) Then
                SQL.AppendLine(Where)
            End If

            If Not String.IsNullOrEmpty(txtFiltro.Text) Then
                SQL.AppendLine(" And " + cboOpcoes.SelectedValue + " LIKE '%" + txtFiltro.Text.Replace("'", "''") + "%'")
            End If

            If Not String.IsNullOrEmpty(OrderBy) Then
                SQL.AppendLine("OrderBy " + OrderBy)
            End If

            Dim Conexao As New MySqlConnection
            Conexao.ConnectionString = NHibernateConfigurationData.Connection.getConnectionMySql()
            Conexao.Open()

            Dim Adaptador As New MySqlDataAdapter(SQL.ToString(), Conexao)
            Dim DataSet As New DataSet()
            Adaptador.Fill(DataSet, Tabela)

            dgvResultados.DataSource = DataSet
            dgvResultados.DataMember = Tabela

            tspTotal.Text = "Total de registros: " & DataSet.Tables(Tabela).Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class