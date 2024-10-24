using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkManage.Data.Models;

namespace WorkManage.Data.Configurations
{
    internal class WorkStageConfiguration : IEntityTypeConfiguration<WorkStage>
    {
        public void Configure(EntityTypeBuilder<WorkStage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(ws => ws.Work)
                .WithMany(w => w.WorkStages)
                .HasForeignKey(ws => ws.WorkId);

            builder.Navigation(x => x.Work).AutoInclude();
        }
    }
}
