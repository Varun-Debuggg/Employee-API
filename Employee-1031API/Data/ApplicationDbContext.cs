using Employee_1031API.Model;
using Microsoft.EntityFrameworkCore;

namespace Employee_1031API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}
