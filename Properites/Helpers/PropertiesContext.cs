using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Properites.Models;

namespace Properites.Helpers
{
    public class PropertiesContext : IdentityDbContext<ApplicationUser> 
    {
        public DbSet<Property> Properties { get; set; }

        public PropertiesContext(DbContextOptions<PropertiesContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 

            builder.Entity<Property>().HasKey(p => p.ID);
            builder.Entity<Property>().Property(p => p.ID).ValueGeneratedOnAdd();

            builder.Entity<Property>()
                .Property(p => p.Latitude)
                .HasColumnType("float");

            builder.Entity<Property>()
                .Property(p => p.Longitude)
                .HasColumnType("float");

        }
    }
}
