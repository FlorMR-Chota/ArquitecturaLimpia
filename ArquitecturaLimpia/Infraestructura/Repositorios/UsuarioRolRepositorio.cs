using ArquitecturaLimpia.Dominio.Entidades;
using ArquitecturaLimpia.Dominio.Interfaces;
using ArquitecturaLimpiaAPP.Infraestructura.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLimpia.Infraestructura.Repositorios
{
    internal class UsuarioRolRepositorio : IUsuarioRolRepositorio
    {
        private readonly AppDbContext _dbContext;
       

        public UsuarioRolRepositorio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        } 

        public async Task<UsuarioRol> CrearAsync(UsuarioRol usuarioRol)
        {
            await _dbContext.UsuariosRoles.AddAsync(usuarioRol);
            return usuarioRol;
        }


        public Task ActualizarAsync(UsuarioRol usuarioRol)
        {
            throw new NotImplementedException();
        }

        

        public Task EliminarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioRol> ListaPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioRol>> ObtenerTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
