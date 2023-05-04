using Aplicacion.CommandHandlers.Movie;
using Aplicacion.Services.Comandos;
using Aplicacion.Services.Validaciones;
using Aplicacion.Validators;

namespace WebAPI.DependencyInjection
{
    public static class HandlersExtension
    {
        public static void AddHandlers(this IServiceCollection services)
        {
            services.Scan(scan => scan.FromAssemblyOf<ICommandBus>().AddClasses(classes => classes.AssignableTo<ICommandBus>()).AsImplementedInterfaces().WithTransientLifetime());
            services.Scan(scan =>
             scan.FromAssemblyOf<GetMoviesHandler>()
             .AddClasses(classes => classes.AssignableTo(typeof(ICommandHandler<>)))
            .AsImplementedInterfaces()
            .WithTransientLifetime()

            );

            services.AddTransient<IValidatorService, ValidatorService>();
            services.Scan(scan => scan.FromAssemblyOf<IValidador>().AddClasses(classes => classes.AssignableTo<IValidador>()).AsImplementedInterfaces().WithTransientLifetime());
        }
    }
}
