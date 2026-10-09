using Microsoft.EntityFrameworkCore;

namespace ACTIVIDAD.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Modelos.Usuarios> Usuarios { get; set; }
        public DbSet<Modelos.Salas> Salas { get; set; }
        public DbSet<Modelos.Reservaciones> Reservaciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Reservaciones.db");
        }
    }
}