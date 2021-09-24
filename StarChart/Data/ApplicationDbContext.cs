using Microsoft.EntityFrameworkCore;
using StarChart.Models;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CelestialObjects> celestialObjects { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
