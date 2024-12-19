

using ArquitecturaLimpia.Dominio.Entidades;
using ArquitecturaLimpiaApp.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ArquitecturaLimpiaAPP.Infraestructura.Contexto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<UsuarioRol> UsuariosRoles { get; set; }
    }
}
