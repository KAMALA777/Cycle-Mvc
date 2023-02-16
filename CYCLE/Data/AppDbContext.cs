using CYCLE.Models;
using Microsoft.EntityFrameworkCore;

namespace CYCLE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
            public DbSet<Banner> Banners { get; set; }
        public DbSet<Product> Products { get; set; }

    
}
}
