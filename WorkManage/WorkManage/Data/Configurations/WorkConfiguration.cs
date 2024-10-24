using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkManage.Data.Models;

namespace WorkManage.Data.Configurations
{
    internal class WorkConfiguration : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(w => w.Master)
                .WithMany(m => m.Works)
                .HasForeignKey(w => w.MasterId);

            builder.Navigation(x => x.Master).AutoInclude();
        }
    }
}
