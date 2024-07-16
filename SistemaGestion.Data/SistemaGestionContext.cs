using Microsoft.EntityFrameworkCore;
using SistemaGestion.Entities.Entities;

namespace SistemaGestion.Data
{
    public class SistemaGestionContext : DbContext
    {
        private readonly string _connectionString;
        public SistemaGestionContext()
        {
            _connectionString = "Initial Catalog=BD_SistemaGestion; Data Source=.; Integrated Security=True; TrustServerCertificate=True;";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<Venta> Venta { get; set; }
    }
}
