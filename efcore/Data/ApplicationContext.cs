using efcore.Domain;
using Microsoft.EntityFrameworkCore;

namespace efcore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;User=sa;Password=Docker@Docker;");

        }

    }
}