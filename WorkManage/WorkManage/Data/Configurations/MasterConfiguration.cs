using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkManage.Data.Models;

namespace WorkManage.Data.Configurations
{
    internal class MasterConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(m => m.Works)
                .WithOne(w => w.Master)
                .HasForeignKey(m => m.MasterId);

            builder.Property(m => m.HireDate)
                .HasColumnType("timestamp");

            builder.Navigation(m => m.Works).AutoInclude();
        }
    }
}
