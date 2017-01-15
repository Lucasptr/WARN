using System.Data.Entity.ModelConfiguration;
using Warn.Domain.Entities;

namespace Warn.Data.EntityConfig
{
    public class FeedbackTypeMap : EntityTypeConfiguration<FeedbackType>
    {
        public FeedbackTypeMap()
        {
            HasKey(x => x.FeedbackTypeID);

            Property(e => e.Description)
                    .IsUnicode(false)
                    .HasMaxLength(200);

            //HasMany(e => e.Feedback)
            //        .WithRequired(e => e.FeedbackType)
            //        .HasForeignKey(e => e.FeedbackType)
            //        .WillCascadeOnDelete(false);

            ToTable("tt_tipo_feedback");
            Property(x => x.FeedbackTypeID).HasColumnName("idt_tipo_feedback");
            Property(x => x.Description).HasColumnName("dsc_feedback");
        }
    }
}
