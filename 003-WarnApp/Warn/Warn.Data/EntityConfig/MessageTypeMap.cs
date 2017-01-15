using System.Data.Entity.ModelConfiguration;
using Warn.Domain.Entities;

namespace Warn.Data.EntityConfig
{
    public class MessageTypeMap : EntityTypeConfiguration<MessageType>
    {
        public MessageTypeMap()
        {
            HasKey(x => x.MessageTypeID);

            Property(e => e.Name)
                            .IsUnicode(false)
                            .IsRequired()
                            .HasMaxLength(80);

            //HasMany(e => e.Message)
            //                .WithRequired(e => e.MessageType)
            //                .HasForeignKey(e => e.MessageTypeID)
            //                .WillCascadeOnDelete(false);

            ToTable("tt_tipo_mensagem");
            Property(x => x.MessageTypeID).HasColumnName("idt_tipo_mensagem");
            Property(x => x.Name).HasColumnName("nme_tipo_mensagem");
        }
    }
}
