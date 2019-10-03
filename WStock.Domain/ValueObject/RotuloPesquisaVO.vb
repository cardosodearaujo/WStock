Public Class RotuloPesquisaVO
    Public Sub New(coluna As String, rotulo As String)
        Me.Coluna = coluna
        Me.Rotulo = rotulo
    End Sub

    Public Sub New()

    End Sub

    Public Property Coluna As String
    Public Property Rotulo As String
End Class
