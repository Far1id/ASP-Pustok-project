using Microsoft.EntityFrameworkCore;
using Pustok_Project.Models;

namespace Pustok_Project.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feature> Features { get; set; }

    }
}
