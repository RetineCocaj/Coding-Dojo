using Microsoft.EntityFrameworkCore;

namespace DeploySample
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) {}

        public DbSet<Product> Products { get; set; }
    }
}