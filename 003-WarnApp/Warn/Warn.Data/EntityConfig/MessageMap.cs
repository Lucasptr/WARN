using System.Data.Entity.ModelConfiguration;
using Warn.Domain.Entities;

namespace Warn.Data.EntityConfig
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            HasKey(x => x.MessageID);

            Property(e => e.Text)
                    .IsUnicode(false)
                    .IsRequired()
                    .HasMaxLength(300);

            //HasMany(e => e.Feedback)
            //        .WithRequired(e => e.Message)
            //        .HasForeignKey(e => e.MessageID)
            //        .WillCascadeOnDelete(false);

            ToTable("tb_mensagem");
            Property(x => x.MessageID).HasColumnName("idt_mensagem");
            Property(x => x.Text).HasColumnName("txt_mensagem");
            Property(x => x.SendDate).HasColumnName("dt_envio");
            Property(x => x.GroupID).HasColumnName("fk_mensagem_grupo");
            Property(x => x.MessageTypeID).HasColumnName("fk_mensagem_tipo_mensagem");
            Property(x => x.UserID).HasColumnName("fk_mensagem_usuario");
        }
    }
}
