using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Db
{
    public class HRMContext : DbContext
    {
        public HRMContext(DbContextOptions<HRMContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
