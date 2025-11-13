
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Mapping
{
    public class DonoMap : IEntityTypeConfiguration<Dono>
    {
        public void Configure(EntityTypeBuilder<Dono> builder)
        {
            //Chave primária
            builder.ToTable("Donos");
            builder.HasKey(d => d.Id);

            //Propriedades
            builder.Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(d => d.Endereco)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(d => d.Telefone)
                .IsRequired()
                .HasMaxLength(15);
            builder.Property(d => d.Email)
                .IsRequired()
                .HasMaxLength(100);

            //Relacionamento um Dono tem muitos Pets
            
            builder.HasMany(d => d.Pets)
                .WithOne(p => p.Dono)
                .HasForeignKey(p => p.IdDono)
                .OnDelete(DeleteBehavior.Cascade);

            //Relacionamento um Dono tem muitas Vendas
            builder.HasMany(d => d.Vendas)
                .WithOne(v => v.Dono)
                .HasForeignKey(v => v.IdDono)
                .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento um Dono tem uma Cidade
            builder.HasOne(d => d.CidadeObj)
                .WithMany(c => c.Donos)
                .HasForeignKey(d => d.IdCidade)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
