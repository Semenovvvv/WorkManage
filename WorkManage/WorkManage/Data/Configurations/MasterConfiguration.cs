using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkManage.Data.Models;

namespace WorkManage.Data.Configurations
{
    internal class MasterConfiguration : IEntityTypeConfiguration<Master>
    {
        public void Configure(EntityTypeBuilder<Master> builder)
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
