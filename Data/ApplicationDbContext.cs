using EnsaioApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EnsaioApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Models.Ensaio> Ensaio { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
