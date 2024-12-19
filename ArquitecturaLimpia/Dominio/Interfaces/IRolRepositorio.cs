using ArquitecturaLimpia.Dominio.Entidades;
using ArquitecturaLimpiaApp.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLimpia.Dominio.Interfaces
{
    public interface IRolRepositorio
    {
        Task<Rol> CrearAsync(Rol rol);
        Task<IEnumerable<Rol>> ObtenerTodosAsync();
        Task<Rol> ListaPorIdAsync(int id);
        Task ActualizarAsync(Rol rol);
        Task EliminarAsync(int id);
    }
}
