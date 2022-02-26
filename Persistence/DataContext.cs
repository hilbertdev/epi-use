using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Organisation> Organisations {get; set;}

        public DbSet<RoleDescription> RoleDescriptions {get; set;}
    }
}