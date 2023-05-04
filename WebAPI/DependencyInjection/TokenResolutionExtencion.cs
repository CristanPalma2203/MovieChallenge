using Aplicacion.Services.Validaciones;
using Dominio.Services;
using Infraestructura.Services;

namespace WebAPI.DependencyInjection
{
    public static class TokenResolutionExtencion
    {
        public static void AddTokenConfiguration(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient<IAutenticationHelper, AutenticationHelper>();
            services.AddTransient<ITokenService, TokenService>();
            var appSettingsSection = configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
        }
    }
}
