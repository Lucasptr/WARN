using System.Data.Entity.ModelConfiguration;
using Warn.Domain.Entities;

namespace Warn.Data.EntityConfig
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(x => x.UserID);

            Property(e => e.Login)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(20);

            Property(e => e.Password)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(128);

            Property(e => e.Name)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(80);

            Property(e => e.Email)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(80);

            //HasMany(e => e.Subscribed)
            //      .WithRequired(e => e.User)
            //      .HasForeignKey(e => e.UserID)
            //      .WillCascadeOnDelete(false);

            //HasMany(e => e.Message)
            //    .WithRequired(e => e.User)
            //    .HasForeignKey(e => e.UserID)
            //    .WillCascadeOnDelete(false);


            ToTable("tb_usuario");
            Property(x => x.UserID).HasColumnName("idt_usuario");
            Property(x => x.Login).HasColumnName("lgn_usuario");
            Property(x => x.Password).HasColumnName("pwr_usuario");
            Property(x => x.Name).HasColumnName("nme_usuario");
            Property(x => x.Email).HasColumnName("eml_usuario");
            Property(x => x.Phone).HasColumnName("tel_usuario");
            Property(x => x.Ativo).HasColumnName("flg_ativo");
            Property(x => x.CreationDate).HasColumnName("dta_cadastro");
            Property(x => x.ProfileID).HasColumnName("fk_usuario_perfil");
        }
    }
}
