using CaseStudy.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CaseStudy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Buses { get; set; }


        public DbSet<Car> Cars { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    } 
}
