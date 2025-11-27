using Microsoft.EntityFrameworkCore;
using PetShop.Repository.Mapping;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Context
{
    public class PetShopContext : DbContext
    {
        public PetShopContext()
        {
            // 🔹 Garante que o banco e as tabelas sejam criados se ainda não existirem
            Database.EnsureCreated();
        }

        public PetShopContext(DbContextOptions<PetShopContext> options)
            : base(options)
        {
            Database.EnsureCreated(); // Mesmo comportamento para este construtor
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // ⚙️ Conexão com o MySQL sem senha
                optionsBuilder.UseMySQL("server=localhost;database=petshop;user=root;");
            }
        }

        // 🔹 DbSets — representam suas tabelas
        public DbSet<Dono> Donos { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<VendaItem> VendaItems { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 🔹 Aplica todas as configurações (mappings)
            modelBuilder.Entity<Dono>(new DonoMap().Configure);
            modelBuilder.Entity<Pet>(new PetMap().Configure);
            modelBuilder.Entity<Agendamento>(new AgendamentoMap().Configure);
            modelBuilder.Entity<Servico>(new ServicoMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Venda>(new VendaMap().Configure);
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<VendaItem>(new VendaItemMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Grupo>(new GrupoMap().Configure);
        }
    }
}
