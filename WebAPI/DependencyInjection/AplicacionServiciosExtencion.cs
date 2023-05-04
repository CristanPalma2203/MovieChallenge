
using Aplicacion.Services.ConsultaPermiso;
using Aplicacion.Services.Movie;

namespace WebAPI.DependencyInjection

{

    public static class AplicacionServiciosExtencion
    {
        public static void AddAplicacionServices(this IServiceCollection services)
        {
            services.AddTransient<ICarga, UsuarioService>();
            services.AddTransient<IConsultaPermisoService, ConsultaPermisoService>();

        }
    }
}
