using Event_Bridge.Model;
using Microsoft.EntityFrameworkCore;

namespace Event_Bridge.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<UsuarioModel> Usuario { get; set; }
    public DbSet<EventosModel> Eventos { get; set; }
}
