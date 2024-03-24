using Microsoft.OpenApi.Models;
using System.Reflection;

namespace TipMexico.DigitalYard.WebAPI.Extensions
{
    internal static class SwaggerExtension
    {
        private static readonly string VersionApp = "v1";
        private static readonly string NameApp = "Portal Digital Yard Core";
        private static readonly string DescriptionApp = "Version: 1";
        private static readonly string TeamApp = "desarrollo@vti.com";
        private static readonly string NameTeamApp = "Vti Developer Team";
        private static readonly string NameShemaToken = "Bearer";
        private static readonly string DescriptionShemaToken = "Authorization by JWT Azure Ad";
        private static readonly string TypeShemaToken = "Authorization";
        private static readonly string PathJsonSwagger = "/swagger/v1/swagger.json";

        internal static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(VersionApp, new OpenApiInfo
                {
                    Version = VersionApp,
                    Title = NameApp,
                    Description = DescriptionApp,
                    Contact = new OpenApiContact
                    {
                        Name = NameTeamApp,
                        Email = TeamApp,
                    },
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);



                c.AddSecurityDefinition(NameShemaToken, new OpenApiSecurityScheme
                {
                    Description = DescriptionShemaToken,
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Name = TypeShemaToken
                });


                c.AddSecurityRequirement(new OpenApiSecurityRequirement{
                    {
                        new OpenApiSecurityScheme{
                            Reference = new OpenApiReference{
                                Id = NameShemaToken,
                                Type = ReferenceType.SecurityScheme
                            }
                        },new List<string>()
                    }
                });

            });

            return services;
        }

        internal static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(PathJsonSwagger, NameApp); 
                c.DocumentTitle = NameApp;
            });

            return app;
        }
    }
}
