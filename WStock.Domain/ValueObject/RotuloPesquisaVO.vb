Public Class RotuloPesquisaVO
    Implements ICloneable
    Public Sub New(coluna As String, rotulo As String)
        Me.Coluna = coluna
        Me.Rotulo = rotulo
    End Sub

    Public Sub New()

    End Sub

    Public Function Clone() As Object Implements ICloneable.Clone
        Return Me.MemberwiseClone()
    End Function

    Public Property Coluna As String
    Public Property Rotulo As String
End Class
