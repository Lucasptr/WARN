using System.Data.Entity.ModelConfiguration;
using Warn.Domain.Entities;

namespace Warn.Data.EntityConfig
{
    public class ProfileMap : EntityTypeConfiguration<Profile>
    {
        public ProfileMap()
        {
            HasKey(x => x.ProfileID);

            Property(e => e.Name)
                 .IsUnicode(false)
                 .IsRequired()
                 .HasMaxLength(80);

            //HasMany(e => e.User)
            //     .WithRequired(e => e.Profile)
            //     .HasForeignKey(e => e.ProfileID)
            //     .WillCascadeOnDelete(false);

            ToTable("tt_perfil");
            Property(x => x.ProfileID).HasColumnName("idt_perfil");
            Property(x => x.Name).HasColumnName("nme_perfil");

        }
    }
}
