using SistemaGestion.Entities.Entities;

namespace SistemaGestion.Entities.Interfaces
{
    public interface IUsuarioRepository
    {
        void insertarUsuario(Usuario usuario);
        void EliminarUsuario(int usuarioId);
        bool ExisteUsuario(string nombreUsuario);
        Task<Usuario> ObtenerUsuarioPorNombre(string nombreUsuario);
    }
}
