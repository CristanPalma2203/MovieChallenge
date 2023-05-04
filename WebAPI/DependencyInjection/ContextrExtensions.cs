using Dominio.Repositories;
using Dominio.Services;
using Infraestructura.Data;
using Infraestructura.Repositories;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.DependencyInjection
{
    public static class ContextrExtensions
    {
        public static void AddContextConfiguration(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {

            services.AddDbContext<MovieContext>(
         options =>
         {
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

         });

            services.AddScoped<IUnitOfWork, UnitOfWork>();


            services.Scan(scan => scan.FromAssemblyOf<UsuarioRepository>().AddClasses(classes => classes.AssignableTo(typeof(IGenericRepository<>))).AsImplementedInterfaces().WithScopedLifetime());

        }
    }
}
