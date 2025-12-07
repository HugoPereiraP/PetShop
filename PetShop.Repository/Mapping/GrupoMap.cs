using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Mapping
{
    public class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            //Chave primária
            builder.ToTable("Grupos");
            builder.HasKey(g => g.Id);

            //Propriedades
            builder.Property(g => g.Nome)
                .IsRequired()
                .HasMaxLength(100);

            // Relacionamento 1 Grupo tem muitos Produtos
            builder.HasMany(g => g.Produtos)
                .WithOne(p => p.Grupo)
                .HasForeignKey(p => p.IdGrupo)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
