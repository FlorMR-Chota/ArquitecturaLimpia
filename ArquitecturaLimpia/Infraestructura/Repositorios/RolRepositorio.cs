using ArquitecturaLimpia.Dominio.Entidades;
using ArquitecturaLimpia.Dominio.Interfaces;
using ArquitecturaLimpiaApp.Dominio.Entidades;
using ArquitecturaLimpiaAPP.Infraestructura.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLimpia.Infraestructura.Repositorios
{
    public class RolRepositorio : IRolRepositorio
    {
        private readonly AppDbContext _dbContext;


        public RolRepositorio(AppDbContext dbContext)
        { 
            _dbContext = dbContext;

        }

        public async Task<Rol> CrearAsync(Rol rol)
        {
            await _dbContext.Roles.AddAsync(rol);
            return rol;
        }


        public async Task ActualizarAsync(Rol rol)
        {
            var rolEncontrado = await _dbContext.Roles.FindAsync(rol.Id);
            if (rolEncontrado != null)
            {
                _dbContext.Entry(rolEncontrado).CurrentValues.SetValues(rol);
            }
        }


        public async Task EliminarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Rol> ListaPorIdAsync(int id)
        {
            return await _dbContext.Roles.FindAsync(id);
        }

        public async Task<IEnumerable<Rol>> ObtenerTodosAsync()
        {
            return await _dbContext.Roles.ToListAsync();
        }
    }
}
