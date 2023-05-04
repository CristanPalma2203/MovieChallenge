using Microsoft.OpenApi.Models;
using System.Reflection;

namespace WebAPI.DependencyInjection
{
    public static class SwaggerExtencion
    {
        public static void AddSwaggerConf(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("alpha", new OpenApiInfo
                {
                    Version = "alpha",
                    Title = "Documentacion Movie Challenge",
                    Description = ".",

                    Contact = new OpenApiContact
                    {
                        Name = "Cristian Palma",
                        Email = "",

                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });


        }
    }
}
