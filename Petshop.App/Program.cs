using PetShop.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using PetShop.App.Register;

namespace PetShop.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            // Configura o DI
            ConfigureDI.ConfigureService();

            // Obtém o FormLogin do container
            var formLogin = ConfigureDI.serviceProvider.GetRequiredService<FormLogin>();

            Application.Run(formLogin);
        }
    }
}