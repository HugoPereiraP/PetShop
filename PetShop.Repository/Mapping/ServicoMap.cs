using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Mapping
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            //  Chave primária
            builder.ToTable("Servico");

            builder.HasKey(s => s.Id);

            //  Propriedades
            builder.Property(s => s.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.Descricao)
                .HasMaxLength(255);

            builder.Property(s => s.Preco)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            //  Relacionamento: 1 Servico tem N Agendamentos
            builder.HasMany(s => s.Agendamentos)
                .WithOne(a => a.Servico)
                .HasForeignKey(a => a.IdServico)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
