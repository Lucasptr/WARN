using System.Data.Entity.ModelConfiguration;
using Warn.Domain.Entities;

namespace Warn.Data.EntityConfig
{
    public class SubscribedMap : EntityTypeConfiguration<Subscribed>
    {
        public SubscribedMap()
        {
            HasKey(x => x.SubscribedID);

            //HasMany(e => e.Feedback)
            //.WithRequired(e => e.Subscribed)
            //.HasForeignKey(e => e.Subscribed)
            //.WillCascadeOnDelete(false);

            ToTable("ta_inscrito");
            Property(x => x.SubscribedID).HasColumnName("idt_inscrito");
            Property(x => x.GroupID).HasColumnName("fk_inscrito_grupo");
            Property(x => x.UserID).HasColumnName("fk_inscrito_usuario");


        }
    }
}
