Imports System.IO
Imports WStock.Framework.Models

Module ArchiveConnection

    Private _FolderOfArchiveConnection As String = "..\..\conexao.config"
    Public ReadOnly Property FolderOfArchiveConnection() As String
        Get
            Return _FolderOfArchiveConnection
        End Get
    End Property

    Public Function Read() As ConnectionData
        If File.Exists(_FolderOfArchiveConnection) Then
            Dim arq = File.ReadLines(_FolderOfArchiveConnection)
            Dim Conexao As New ConnectionData()
            If Not IsNothing(arq) Then
                Conexao.Database = arq(0)
                Conexao.Server = arq(1)
                Conexao.Port = arq(2)
                Conexao.User = arq(3)
                Conexao.Password = arq(4)
                Return Conexao
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function

    Public Sub Write(Archive As String)
        File.WriteAllText(_FolderOfArchiveConnection, Archive)
    End Sub
End Module
