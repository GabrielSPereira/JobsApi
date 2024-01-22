using JobsApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobsApi.Persistence
{
    public class JobDbContext : DbContext
    {
        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        {
            
        }

        public DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasKey(x => x.Id);
        }
    }
}
