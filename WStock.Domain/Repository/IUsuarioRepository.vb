Imports WStock.Framework.Interfaces

Public Interface IUsuarioRepository
    Inherits IBaseRepository(Of Usuario)
    Function Login(Email As String, Senha As String) As Usuario
End Interface
