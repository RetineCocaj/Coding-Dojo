using Microsoft.EntityFrameworkCore;

namespace LoginAndRegistration
{
    public class Context : DbContext
    {
         public Context(DbContextOptions options) : base(options) {}
        public DbSet<RegisterUser> Users {get;set;}
    }

}