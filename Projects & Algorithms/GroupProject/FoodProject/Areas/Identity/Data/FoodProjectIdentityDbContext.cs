using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodProject.Areas.Identity.Data
{
    public class FoodProjectIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public FoodProjectIdentityDbContext(DbContextOptions<FoodProjectIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
