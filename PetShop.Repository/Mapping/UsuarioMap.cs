using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //  Nome da tabela
            builder.ToTable("Usuario");

            //  Chave primária
            builder.HasKey(u => u.Id);

            //  Propriedades
            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(255); 

            builder.Property(u => u.Email)
                .HasMaxLength(100);

            // 🔗 Relacionamento: 1 Usuário tem N  Vendas
            builder.HasMany(u => u.Vendas)
                .WithOne(v => v.Usuario)
                .HasForeignKey(v => v.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
