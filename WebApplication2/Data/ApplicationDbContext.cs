using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Company A", IsDefault = true },
                new Company { Id = 2, Name = "Company B", IsDefault = false },
                new Company { Id = 3, Name = "Company C", IsDefault = false },
                new Company { Id = 4, Name = "Company D", IsDefault = false },
                new Company { Id = 5, Name = "Company E", IsDefault = false }
            );
        }
    }
}
