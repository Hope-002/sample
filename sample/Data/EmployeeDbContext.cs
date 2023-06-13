using sample;
using Microsoft.EntityFrameworkCore;

namespace Sample
{
    public class EmployeeDbContext: DbContext
    {
           public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        public DbSet<Employee> Employees { get; set; }

    }
}

