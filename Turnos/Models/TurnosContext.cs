using Microsoft.EntityFrameworkCore;

namespace Turnos.Models
{
    public class TurnosContext : DbContext
    {
        public DbSet<Especialidad> Especialidad { get; set; }
        
        public TurnosContext(DbContextOptions<TurnosContext> opciones) : base(opciones)
        {

        }
    }
}