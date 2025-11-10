using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Mapping
{
    public class AgendamentoMap : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento>builder)
        {
            // Chave primária
            builder.ToTable("Agendamentos");
            builder.HasKey(a => a.Id);

            // Propriedades
            builder.Property(a => a.DataHora)
                .IsRequired()
                .HasColumnType("datetime");
                    
            builder.Property(a => a.ValorTotal)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(a => a.Status)
                .IsRequired()
                .HasMaxLength(50);

            // Relacionamento um Agendamento tem 1 pet
               builder.HasOne(a => a.Pet)
                .WithMany(p => p.Agendamentos)
                .HasForeignKey(a => a.IdPet)
                .OnDelete(DeleteBehavior.Restrict);

           // Relacionamento um Agendamento tem 1 serviço
               builder.HasOne(a => a.Servico)
                .WithMany(s => s.Agendamentos)
                .HasForeignKey(a => a.IdServico)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
