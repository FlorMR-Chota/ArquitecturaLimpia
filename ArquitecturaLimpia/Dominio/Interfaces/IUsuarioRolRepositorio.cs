using ArquitecturaLimpia.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLimpia.Dominio.Interfaces
{
    public interface IUsuarioRolRepositorio
    {
        Task<UsuarioRol> CrearAsync(UsuarioRol usuarioRol);
        Task<IEnumerable<UsuarioRol>> ObtenerTodosAsync();
        Task<UsuarioRol> ListaPorIdAsync(int id);
        Task ActualizarAsync(UsuarioRol usuarioRol);
        Task EliminarAsync(int id);
    }
}
