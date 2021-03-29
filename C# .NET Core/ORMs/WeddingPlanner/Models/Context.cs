using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner
{
    public class Context: DbContext
    {
        public Context(DbContextOptions options) : base(options) {}

        public DbSet<Wedding> Weddings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Response> Responses { get; set; }
    }
}