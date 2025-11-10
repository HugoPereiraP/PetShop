using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopStore.Domain.Entities;



namespace PetShop.Repository.Mapping
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            // Chave primária
            builder.ToTable("Cidades");
            builder.HasKey(c => c.Id);

            // Propriedades
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.Estado)
                .IsRequired()
                .HasMaxLength(2);

            builder.HasMany(c => c.Donos)
                .WithOne(d => d.Cidade)
                .HasForeignKey(d => d.IdCidade)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
