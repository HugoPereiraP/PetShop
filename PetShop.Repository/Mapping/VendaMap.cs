using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Mapping
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            // Chave primária
            builder.ToTable("Venda");

            builder.HasKey(v => v.Id);

            // Propriedades

            builder.Property(v => v.Data)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(v => v.ValorTotal)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(v => v.IdDono)
                .IsRequired();

            builder.Property(v => v.IdUsuario)
                .IsRequired();

            // Relacionamentos

            // Uma Venda pertence a um Dono
            builder.HasOne(v => v.Dono)
                .WithMany(d => d.Vendas)
                .HasForeignKey(v => v.IdDono)
                .OnDelete(DeleteBehavior.Restrict);

            // Uma Venda pertence a um Usuário
            builder.HasOne(v => v.Usuario)
                .WithMany(u => u.Vendas)
                .HasForeignKey(v => v.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            // Uma Venda tem muitos Itens
            builder.HasMany(v => v.VendaItens)
                .WithOne(vi => vi.Venda)
                .HasForeignKey(vi => vi.IdVenda)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
