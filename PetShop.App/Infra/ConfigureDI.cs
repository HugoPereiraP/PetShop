
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PetShop.App.Register;
using PetShop.App.ViewModels;
using PetShop.Domain.Base;
using PetShop.Domain.Interfaces;
using PetShop.Repository.Base;
using PetShop.Repository.Context;
using PetShop.Service.Service;
using PetshopStore.Domain.Entities;


namespace PetShop.App.Infra
{
    internal static class ConfigureDI
    {
        public static IServiceProvider serviceProvider;

        public static void ConfigureService()
        {
            var dbConfigFile = "Config/DbConfig.txt";
            var dbConnectionString = File.ReadAllText(dbConfigFile);

            var services = new ServiceCollection();

          
            

            services.AddDbContext<PetShopDbContext>(options =>
            {
                options.LogTo(Console.WriteLine);
                options.UseMySQL(dbConnectionString);
            });

            services.AddLogging();

            services.AddAutoMapper(config =>
            {
                config.CreateMap<Dono, DonoModel>();
                config.CreateMap<Cidade, CidadeModel>();
                config.CreateMap<Produto, ProdutoModel>();
                config.CreateMap<Grupo, GrupoModel>();
                config.CreateMap<Pet, PetModel>();
                config.CreateMap<Venda, VendaModel>();
                config.CreateMap<VendaItem,VendaItem>();
                config.CreateMap<Servico, ServicoModel>();
                config.CreateMap<Agendamento, AgendamentoModel>();
            });

         
            services.AddScoped<IBaseRepository<Agendamento>, BaseRepository<Agendamento>>();
            services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            services.AddScoped<IBaseRepository<Dono>, BaseRepository<Dono>>();
            services.AddScoped<IBaseRepository<Grupo>, BaseRepository<Grupo>>();
            services.AddScoped<IBaseRepository<Pet>, BaseRepository<Pet>>();
            services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            services.AddScoped<IBaseRepository<Servico>, BaseRepository<Servico>>();
            services.AddScoped<IBaseRepository<Venda>, BaseRepository<Venda>>();
            services.AddScoped<IBaseRepository<VendaItem>, BaseRepository<VendaItem>>();

           
            services.AddScoped<IAgendamentoService, AgendamentoService>();
            services.AddScoped<IVendaService, VendaService>();
            services.AddScoped<IVendaItemService, VendaItemService>();
            services.AddScoped<IDonoService, DonoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IPetService, PetService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IServicoService, ServicoService>();
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IGrupoService, GrupoService>();

          
            services.AddTransient<FormLogin>();
            services.AddTransient<FormPrincipal>();
            services.AddTransient<FormCadastroUsuario>();


          
            serviceProvider = services.BuildServiceProvider();
        }
    }
}
