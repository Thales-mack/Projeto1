using EnsaioAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnsaioAPI.Context
{
    public class EnsaioDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Ensaio> Ensaio { get; set; }

        public EnsaioDbContext(DbContextOptions<EnsaioDbContext> options)
            : base(options)
        {
        }
    }
}
