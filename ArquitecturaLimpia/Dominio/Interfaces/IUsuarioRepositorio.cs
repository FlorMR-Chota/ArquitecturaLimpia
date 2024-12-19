using ArquitecturaLimpiaApp.Dominio.Entidades;

namespace ArquitecturaLimpiaApp.Dominio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<Usuario> CrearAsync(Usuario usuario);
        Task<IEnumerable<Usuario>> ObtenerTodosAsync();
        Task<Usuario> ListaPorIdAsync(int id);
        Task ActualizarAsync(Usuario usuario);
        Task EliminarAsync(int id);
       
    }
}
