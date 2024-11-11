using ImportExport.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImportExport.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.GenerateEmpoyees();
        }
    }
}
