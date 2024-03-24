using Autofac;
using TipMexico.DigitalYard.WebAPI.Extensions.AutofacModules;

namespace TipMexico.DigitalYard.WebAPI.Extensions
{
    public static class ContainerBuilderExtension
    {
        private static string _digitalYardConnectionString = "DefaultConnection";
        public static void RegisterAutoFacModules(this ContainerBuilder containerBuilder, IConfiguration configuration)
        {
            containerBuilder.RegisterModule(new DataAccessModule(configuration.GetConnectionString(_digitalYardConnectionString)));
            containerBuilder.RegisterModule(new ApplicationAccessModule());
        }
    }
}
