using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Mapping
{
    public class VendaItemMap : IEntityTypeConfiguration<VendaItem>
    {
        public void Configure(EntityTypeBuilder<VendaItem> builder)
        {
            // 🏷 Nome da tabela
            builder.ToTable("VendaItem");

            //  Chave primária
            builder.HasKey(vi => vi.Id);

            //  Propriedades
            builder.Property(vi => vi.IdVenda)
                .IsRequired();

            builder.Property(vi => vi.IdProduto)
                .IsRequired();

            builder.Property(vi => vi.Quantidade)
                .IsRequired();

            builder.Property(vi => vi.ValorUnitario)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            //  Relacionamento: 1 Venda → tem Itens
            builder.HasOne(vi => vi.Venda)
                .WithMany(v => v.VendaItens)
                .HasForeignKey(vi => vi.IdVenda)
                .OnDelete(DeleteBehavior.Cascade);

            //  Relacionamento: 1 Produto tem N Itens
            builder.HasOne(vi => vi.Produto)
                .WithMany(p => p.VendaItens)
                .HasForeignKey(vi => vi.IdProduto)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
