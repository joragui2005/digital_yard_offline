using System.Runtime.CompilerServices;

namespace TipMexico.DigitalYard.WebAPI.Extensions
{
    internal static class ConfigurationExtension
    {
        private static string MyAllowSpecificOrigins = "_tip_mexico_digital_yard";
        private static string NameSectionCors = "AllowedHosts";
        internal static IServiceCollection AddModules(this IServiceCollection services, IConfiguration configuration)
        {

            #region Cors
            var origins = configuration.GetSection(NameSectionCors).Value?.Split(";");
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.AllowAnyHeader().AllowAnyMethod().WithOrigins(origins);
                                  });
            });
            #endregion
            return services;
        }

        internal static IApplicationBuilder UseModules(this IApplicationBuilder app)
        {
            app.UseCors(MyAllowSpecificOrigins);
            return app;
        }
    }
}
