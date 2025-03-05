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
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Company A", IsDefault = true },
                new Company { Id = 2, Name = "Company B", IsDefault = false },
                new Company { Id = 3, Name = "Company C", IsDefault = false },
                new Company { Id = 4, Name = "Company D", IsDefault = false },
                new Company { Id = 5, Name = "Company E", IsDefault = false }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "John Doe", CompanyId = 1 },
                new Employee { Id = 2, Name = "Jane Smith", CompanyId = 2 },
                new Employee { Id = 3, Name = "Michael Johnson", CompanyId = 2 },
                new Employee { Id = 4, Name = "Emily Davis", CompanyId = 4 },
                new Employee { Id = 5, Name = "David Wilson", CompanyId = 5 },
                new Employee { Id = 6, Name = "Sarah Brown", CompanyId = 1 },
                new Employee { Id = 7, Name = "James Anderson", CompanyId = 3 },
                new Employee { Id = 8, Name = "Jessica Thomas", CompanyId = 4 },
                new Employee { Id = 9, Name = "Daniel Martinez", CompanyId = 5 },
                new Employee { Id = 10, Name = "Sophia Garcia", CompanyId = 1 },
                new Employee { Id = 11, Name = "William Rodriguez", CompanyId = 2 },
                new Employee { Id = 12, Name = "Olivia Lee", CompanyId = 3 },
                new Employee { Id = 13, Name = "Ethan Harris", CompanyId = 4 },
                new Employee { Id = 14, Name = "Mia White", CompanyId = 5 },
                new Employee { Id = 15, Name = "Alexander Clark", CompanyId = 3 }
            );
        }
    }
}
