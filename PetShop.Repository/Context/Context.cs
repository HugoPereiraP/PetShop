

using Microsoft.EntityFrameworkCore;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Context
{
    public  class PetShopContext : DbContext
    {
        public PetShopContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=PetShop;user=root;password=your_password");
        }

        public DbSet<Dono> Donos { get; set; }
        public DbSet<Pet> Pets { get; set; }    
        public DbSet<Agendamento> Agendamentos { get; set; }    
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<VendaItem> ItensVendas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }

    }

}
