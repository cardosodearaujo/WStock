Imports WStock.Domain
Imports WStock.Framework.Bases

Public Class UsuarioRepository
    Inherits BaseRepository(Of Usuario)
    Implements IUsuarioRepository

    Public Function Login(Email As String, Senha As String) As Usuario Implements IUsuarioRepository.Login
        Return MyBase.session.Query(Of Usuario) _
            .Where(Function(F) F.Email.Equals(Email) AndAlso F.Senha.Equals(Senha)) _
            .FirstOrDefault()
    End Function
End Class
