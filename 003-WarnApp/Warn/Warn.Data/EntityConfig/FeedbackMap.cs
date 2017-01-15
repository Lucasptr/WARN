using System.Data.Entity.ModelConfiguration;
using Warn.Domain.Entities;

namespace Warn.Data.EntityConfig
{
    public class FeedbackMap : EntityTypeConfiguration<Feedback>
    {
        public FeedbackMap()
        {
            HasKey(x => x.FeedbackID);

            ToTable("tb_feedback");
            Property(x => x.FeedbackID).HasColumnName("idt_feedback");
            Property(x => x.MessageID).HasColumnName("fk_feedback_mensagem");
            Property(x => x.SubscribedID).HasColumnName("fk_feedback_inscrito");
            Property(x => x.FeedbackTypeID).HasColumnName("fk_feedback_tipo_feedback");

        }
    }
}
