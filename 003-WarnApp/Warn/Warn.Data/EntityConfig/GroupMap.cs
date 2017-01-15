using System.Data.Entity.ModelConfiguration;
using Warn.Domain.Entities;

namespace Warn.Data.EntityConfig
{
    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            HasKey(x => x.GroupID);

            Property(e => e.Name)
                    .IsUnicode(false)
                    .IsRequired()
                    .HasMaxLength(80);

            Property(e => e.Description)
                    .IsUnicode(false)
                    .IsRequired()
                    .HasMaxLength(200);

            //HasMany(e => e.Subscribed)
            //        .WithRequired(e => e.Group)
            //        .HasForeignKey(e => e.GroupID)
            //        .WillCascadeOnDelete(false);

            //HasMany(e => e.Message)
            //        .WithRequired(e => e.Group)
            //        .HasForeignKey(e => e.GroupID)
            //        .WillCascadeOnDelete(false);

            ToTable("tb_grupo");
            Property(x => x.GroupID).HasColumnName("idt_grupo");
            Property(x => x.Name).HasColumnName("nme_grupo");
            Property(x => x.Description).HasColumnName("dsc_grupo");
            Property(x => x.CreationDate).HasColumnName("dta_cadastro");
        }
    }
}
