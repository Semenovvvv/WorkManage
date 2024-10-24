using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorkManage.Data.Configurations;
using WorkManage.Data.Models;

namespace WorkManage.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Master> Masters {  get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<WorkStage> WorkStages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MasterConfiguration());
            modelBuilder.ApplyConfiguration(new WorkConfiguration());
            modelBuilder.ApplyConfiguration(new WorkStageConfiguration());
        }
    }
}
