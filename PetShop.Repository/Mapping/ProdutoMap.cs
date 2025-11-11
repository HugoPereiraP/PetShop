using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
          
          

            //  Chave primária
            builder.ToTable("Produto");

            builder.HasKey(p => p.Id);

            //  Propriedades
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Preco)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(p => p.Quantidade)
                .IsRequired();

            builder.Property(p => p.UnidadeVenda)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(p => p.Estoque)
                .IsRequired();

            builder.Property(p => p.IdGrupo)
                .IsRequired();

            // Relacionamento: 1 Grupo tem N Produtos
            builder.HasOne(p => p.Grupo)
                .WithMany(g => g.Produtos)
                .HasForeignKey(p => p.IdGrupo)
                .OnDelete(DeleteBehavior.Restrict);

            //  Relacionamento: 1 Produto tem N Itens de Venda
            builder.HasMany(p => p.VendaItens)
                .WithOne(vi => vi.Produto)
                .HasForeignKey(vi => vi.IdProduto)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
