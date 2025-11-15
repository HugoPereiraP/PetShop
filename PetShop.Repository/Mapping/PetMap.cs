using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Mapping
{
    public class PetMap : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            
            builder.ToTable("Pets");
            builder.HasKey(p => p.Id);

            
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.Especie)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Raca)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Idade)
                .IsRequired()
                .HasMaxLength(3);
            builder.Property(p => p.Sexo)
                .IsRequired()
                .HasMaxLength(10);  
            builder.Property(p => p.Peso)
                .IsRequired()
                .HasColumnType("decimal(5,2)");

            

            // Relacionamento um Pet tem 1 Dono
            builder.HasOne(p => p.Dono)
                .WithMany(d => d.Pets)
                .HasForeignKey(p => p.IdDono)
                .OnDelete(DeleteBehavior.Cascade);

            //Relacionamento um Pet tem muitos Agendamentos
            builder.HasMany(p => p.Agendamentos)
                .WithOne(a => a.Pet)
                .HasForeignKey(a => a.IdPet)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
