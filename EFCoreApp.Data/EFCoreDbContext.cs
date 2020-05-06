using EFCoreApp.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Data
{
    public class EFCoreDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EFCoreApp.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
