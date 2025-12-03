using PetShop.App;



namespace IFSPStore.App
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfigureService();

            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal());
        }
    }
}