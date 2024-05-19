using Anyar.Models;
using Microsoft.EntityFrameworkCore;

namespace Anyar.DAL
{
    public class AnyarContext : DbContext
    {
        public AnyarContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }

}
