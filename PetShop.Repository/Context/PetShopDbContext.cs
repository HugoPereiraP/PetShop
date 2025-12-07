using Microsoft.EntityFrameworkCore;
using PetShop.Repository.Mapping;
using PetshopStore.Domain.Entities;

namespace PetShop.Repository.Context
{
    public class PetShopDbContext : DbContext
    {
        // Construtor com opções (usado pelo DI)
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options)
            : base(options)
        {
            // Cria apenas as tabelas caso o banco exista
            Database.EnsureCreated();
        }

        // DbSets — representam suas tabelas
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Só configura a conexão se não estiver configurada via DI
            if (!optionsBuilder.IsConfigured)
            {
                // Substitua user, password e database conforme seu MySQL
                var connectionString = "server=localhost;database=PetShop;user=root;password=;";
                optionsBuilder.UseMySQL(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplica todos os mappings
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
