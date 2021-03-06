using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using vega.Models;

namespace vega.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options): base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
        
        
    }
}