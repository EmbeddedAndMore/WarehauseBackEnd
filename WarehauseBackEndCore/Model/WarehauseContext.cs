
using Microsoft.EntityFrameworkCore;

namespace WarehauseBackEndCore.Model
{
    public class WarehauseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectinString = Startup.ConnectionString;
            optionsBuilder.UseSqlServer(connectinString);
        }
        public DbSet<Product> Products { get; set; }
    }
}
