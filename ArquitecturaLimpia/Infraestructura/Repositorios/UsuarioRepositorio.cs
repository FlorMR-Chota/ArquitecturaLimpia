using ArquitecturaLimpiaApp.Dominio.Entidades;
using ArquitecturaLimpiaApp.Dominio.Interfaces;
using ArquitecturaLimpiaAPP.Infraestructura.Contexto;
using Microsoft.EntityFrameworkCore;

namespace ArquitecturaLimpiaApp.Infraestructura.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly AppDbContext _dbContext;

        public UsuarioRepositorio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Usuario>> ObtenerTodosAsync()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public void Crear(Usuario usuario)
        {
            _dbContext.Usuarios.Add(usuario);
        }

        public async Task<Usuario> CrearAsync(Usuario usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            return usuario;
        }

        public async Task<Usuario> ListaPorIdAsync(int id)
        {
            return await _dbContext.Usuarios.FindAsync(id);
        }

        public async Task ActualizarAsync(Usuario usuario)
        {
            var usuarioEncontrado= await _dbContext.Usuarios.FindAsync(usuario.Id);
            if(usuarioEncontrado != null)
            {
                _dbContext.Entry(usuarioEncontrado).CurrentValues.SetValues(usuario);
            }
        }

        public async Task EliminarAsync(int id)
        {
            var usuarioEncontrado = await _dbContext.Usuarios.FindAsync(id);
            if (usuarioEncontrado != null)
            {
                _dbContext.Usuarios.Remove(usuarioEncontrado);
            }
        }
    }
}
