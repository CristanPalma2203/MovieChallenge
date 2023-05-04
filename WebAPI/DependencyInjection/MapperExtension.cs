using Aplicacion.Mappers;
using AutoMapper;
using Dominio.Repositories;

namespace WebAPI.DependencyInjection
{
    public static class MapperExtension
    {
        public static void AddMappers(this IServiceCollection services)
        {
            services.AddTransient(provider => new MapperConfiguration(cfg =>
            {

                cfg.AddProfile(new DtoUsuarioToUsuarioMapper(provider.GetService<IRolRepository>()));
                cfg.AddProfile<DtoRolToRol>();
                cfg.AddProfile<MovieDtoToMovie>();
                cfg.AddProfile(new UsuarioToDtoLogin(provider.GetService<IPermisoRepository>()));
                cfg.AddProfile<PermisoToDtoPermiso>();
                cfg.AddProfile<DtoRatingMovieToRatingMovie>();

            }).CreateMapper());
        }
    }
}
