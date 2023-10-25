using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RatingSite.Models;
namespace RatingSite
{
	public class RatingSiteDbContext : DbContext
    {
		public RatingSiteDbContext(DbContextOptions<RatingSiteDbContext> options) : base(options)
        {
		}

        // DbSet properties for your entities go here
        public DbSet<UserModel> Users { get; set; }
        // Removed because it is inheriting from the IdentityDbContext<IdentityUser> --- public DbSet<User> Users { get; set; }
        public DbSet<RecipeModel> Recipes { get; set; }
        public DbSet<RatingModel> Ratings { get; set; }
        // Define DbSet properties for other entities as needed
    }
}

