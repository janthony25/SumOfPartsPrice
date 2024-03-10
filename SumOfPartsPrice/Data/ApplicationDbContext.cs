using Microsoft.EntityFrameworkCore;
using SumOfPartsPrice.Models;

namespace SumOfPartsPrice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Issue>()
                .Property(i => i.TotalPrice)
                .HasComputedColumnSql("SUM(PartsPrice)");
        }
        public DbSet<Issue> Issues { get; set; }
    }
}
