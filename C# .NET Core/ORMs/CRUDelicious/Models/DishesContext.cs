using Microsoft.EntityFrameworkCore;
namespace CRUDelicious.Models
{
    public class DishesContext : DbContext
    {
        public DishesContext(DbContextOptions options) : base(options){}

        public DbSet<Dishes> Dishes { get; set; }
    }
}